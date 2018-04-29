Imports System.Text.RegularExpressions
Imports System.Threading

Public Class FormPrincipal
    Private processos = New LinkedList(Of Processo)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' listTabProcess.Items.Add("List item text", 3)
        listTabProcess.Columns(0).Width = 31
        listTabProcess.Columns(1).Width = 124
        listTabProcess.Columns(2).Width = 68
        listTabProcess.Columns(3).Width = 63
        listTabProcess.Columns(4).Width = 63
        statusLabel.Text = "Seja Bem Vindo Fera :)"
        If (txtLimiteMemPrincipal.Text = "") Then txtLimiteMemPrincipal.Text = 16
    End Sub
    Private Sub btnNovoProcesso_Click(sender As Object, e As EventArgs) Handles btnNovoProcesso.Click
        Dim novo = New ControllerLista
        If (txtPid.Text = "" Or txtNome.Text = "" Or txtTamanho.Text = "") Then
            MsgBox("Por favor Preencha todos os campos")
        Else
            novo.inserirNoh(processos, txtPid.Text, txtNome.Text, txtTamanho.Text)
            carregaListaProcessos()
            'statusLabel.Text = "Novo Processo" & txtNome.Text & " adicionado."
        End If
    End Sub
    Private Sub txtTamanho_KeyUp(sender As Object, e As KeyEventArgs) Handles txtTamanho.KeyUp
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtTamanho.Text = digitsOnly.Replace(txtTamanho.Text, "")
    End Sub
    Private Sub txtPid_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPid.KeyUp
        Dim digitsOnly As Regex = New Regex("[^\d]")
        txtPid.Text = digitsOnly.Replace(txtPid.Text, "")
    End Sub
    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim process = New ControllerLista
        If (txtDelPid.Text <> "") Then
            'removo o processo da Tabela de processos
            process.remover(processos, txtDelPid.Text)
            Me.carregaListaProcessos()
            'remove os fragmentos da memória principal
            Me.limparLista(listMemoriaPrincipal)
            'remove os fragmentos da memória secundária Swap
            Me.limparLista(listMemoriaSwap)
            'remove os fragmentos da memória secundária Swap
            Me.limparLista(listTableMemoriaVirtual)
            'reordenar a visualização dos indices ( desfragmentar a memória principal :v )
            For i As Integer = listMemoriaPrincipal.Items.Count - 1 To 0 Step -1
                listMemoriaPrincipal.Items(i).SubItems(0).Text = i
            Next
            'reordenar a visualização dos indices ( desfragmentar a memória secundária :v )
            For i As Integer = listMemoriaSwap.Items.Count - 1 To 0 Step -1
                listMemoriaSwap.Items(i).SubItems(0).Text = i
            Next
            'Vamos corrigir os indices da memória virtual que está toda bangunçada agora =/
            organizarMemoriaVirtual(listMemoriaPrincipal, 1) ' memória principal
            organizarMemoriaVirtual(listMemoriaSwap, 0) ' memória secundária
        Else
            MsgBox("Por favor Preencha todos os campos")
        End If
    End Sub
    Private Sub btnProcFrag_Click(sender As Object, e As EventArgs) Handles btnProcFrag.Click
        Me.fragmentador(0)
    End Sub
    Public Sub limparLista(ByVal view As ListView)
        For i As Integer = view.Items.Count - 1 To 0 Step -1
            Dim listItem As ListViewItem = view.Items(i)
            If listItem.SubItems(1).Text = txtDelPid.Text Then
                view.Items.Remove(listItem)
            End If
        Next
    End Sub
    Public Sub organizarMemoriaVirtual(ByVal view As ListView, ByVal bitPresenca As Integer)
        For i As Integer = view.Items.Count - 1 To 0 Step -1
            Dim memoria As ListViewItem = view.Items(i)

            For j As Integer = listTableMemoriaVirtual.Items.Count - 1 To 0 Step -1
                Dim virtual As ListViewItem = listTableMemoriaVirtual.Items(j)
                If (
                    memoria.SubItems.Item(1).Text = virtual.SubItems.Item(1).Text And
                    memoria.SubItems.Item(2).Text = virtual.SubItems.Item(2).Text And
                    virtual.SubItems.Item(3).Text = bitPresenca
                    ) Then
                    virtual.SubItems.Item(4).Text = memoria.Text 'Atualiza o endereço de memória na tabela de memória virtual
                End If
            Next
        Next
    End Sub
    Public Sub carregaListaProcessos()
        Dim item = processos.First 'pega o primeiro item da lista
        listTabProcess.Items.Clear()
        While (item IsNot Nothing)
            listTabProcess.Items.Add(item.value.pid).SubItems.AddRange(New String() {item.value.nome, item.value.size, item.value.pageFault, item.value.proxPagina})
            If (item.value.size = 0) Then
                Me.colorirLinha(listTabProcess.FindItemWithText(item.value.pid), Color.Red, 0)
            End If
            item = item.next
        End While
    End Sub
    Public Sub fragmentador(ByRef index As Integer)
        Dim item = processos.first
        Dim presenca As Integer
        Dim endereco As Integer
        btnProcFrag.Enabled = False
        btnGerarProcessos.Enabled = False
        While (item IsNot Nothing)
            If (item.value.size <> item.value.fragmento) Then
                If (txtLimiteMemPrincipal.Text > listMemoriaPrincipal.Items.Count) Then
                    endereco = listMemoriaPrincipal.Items.Count
                    listMemoriaPrincipal.Items.Add(endereco).SubItems.AddRange(New String() {item.value.pid, item.value.fragmento})
                    presenca = 1
                Else
                    endereco = listMemoriaSwap.Items.Count
                    listMemoriaSwap.Items.Add(endereco).SubItems.AddRange(New String() {item.value.pid, item.value.fragmento})
                    presenca = 0
                End If
                listTableMemoriaVirtual.Items.Add(listTableMemoriaVirtual.Items.Count).SubItems.AddRange(New String() {item.value.pid, item.value.fragmento, presenca, endereco})
                item.value.fragmento += 1
            End If
            item = item.next
        End While
        'vamos verificar se algum item da lista ainda possui bytes que não foram distribuidos
        'se sim faça a chamada recursiva 
        item = processos.first
        While (item IsNot Nothing)
            If (item.value.size <> item.value.fragmento) Then Me.fragmentador(index)
            item = item.next
        End While

        Me.atualizarPagina()
        btnNovoProcesso.Enabled = False
    End Sub
    Public Sub atualizarPagina()
        Try
            Dim item = processos.First
            Dim control = New ControllerLista

            While (item IsNot Nothing)
                For i As Integer = 0 To listTableMemoriaVirtual.Items.Count - 1
                    Dim listItem As ListViewItem = listTableMemoriaVirtual.Items(i)
                    If (Integer.Parse(listItem.SubItems.Item(1).Text) = item.value.pid) Then
                        control.atualizaPagina(processos, Integer.Parse(listItem.SubItems.Item(1).Text), Integer.Parse(listItem.SubItems.Item(0).Text))
                        Exit For
                    End If
                Next
                item = item.next
            End While
            Me.carregaListaProcessos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnExec_Click(sender As Object, e As EventArgs) Handles btnExec.Click
        Try
            Dim item = processos.first
            Dim model = New ModelProcesso
            Dim no = New Processo
            Dim local As Integer
            Dim ender As Integer

            If (txtExec.Text <> "") Then
                no = model.seleciona(processos, Integer.Parse(txtExec.Text)) ' vamos selecionar o processo para ser executado
            End If

            If (no IsNot Nothing) Then
                Dim virtual = listTableMemoriaVirtual.FindItemWithText(no.proxPagina)
                btnExec.Enabled = False
                Me.colorirLinha(listTabProcess.FindItemWithText(txtExec.Text), Color.Aqua) 'colorir linha da tabela de processos
                Dim limit = 0

                If (virtual IsNot Nothing) Then
                    local = virtual.SubItems.Item(3).Text ' Aqui sabemos o local Mem. Principal ou Secundária
                    ender = virtual.SubItems.Item(4).Text ' Aqui sabemos qual o endereço
                    Me.colorirLinha(virtual, Color.Aqua) ' colorir linha da tabela de memória virtual
                    If (local = 0) Then Me.colorirLinha(listMemoriaSwap.FindItemWithText(ender), Color.Aqua) ' vamos colorir  a linha da memória swap
                    If (local <> 0) Then virtual.Remove() ' bora remover-lo da tabela de memória virtual se o processo estiver na memória principal
                End If

                If (no.size > 0) Then
                    Me.swappInOut(local, ender, no)
                Else
                    MsgBox("O processo " & no.nome & " já terminou")
                    btnExec.Enabled = True
                End If
                Me.ocuparMemoriaPrincipal() ' Se a memória principal estiver vazia vamos ocupala :)
            Else
                MsgBox("O processo " & txtExec.Text & " não existe.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub swappInOut(ByVal local As Integer, ByVal ender As Integer, ByRef no As Processo)
        Try
            ' Se a parte do processo não se encontra na memória principal então 
            ' vamos alocar espaço e transferir para a memória principal
            Dim linha = New ListViewItem
            If (local = 0) Then
                Dim pid As Integer
                Dim fragmento As Integer
                Dim swap = listMemoriaSwap.FindItemWithText(ender)

                If (swap IsNot Nothing) Then
                    pid = swap.SubItems(1).Text
                    fragmento = swap.SubItems(2).Text
                    swap.Remove()
                    listMemoriaSwap.Refresh()
                End If
                ' Se a memória principal estiver cheia é preciso liberar espaço
                If (listMemoriaPrincipal.Items.Count >= Integer.Parse(txtLimiteMemPrincipal.Text)) Then
                    Dim posicaoPrincipal As Integer = listMemoriaPrincipal.Items.Count - 1
                    Dim posicaoSecundaria As Integer = listMemoriaSwap.Items.Count + 1
                    Dim item As ListViewItem = listMemoriaPrincipal.Items(posicaoPrincipal)

                    listMemoriaSwap.Items.Add(posicaoSecundaria).SubItems.AddRange(New String() {item.SubItems(1).Text, item.SubItems(2).Text})

                    ' Me.transfereSwapPrincipal(no, linha, ender, pid, fragmento)
                    For i As Integer = 0 To listTableMemoriaVirtual.Items.Count - 1
                        Dim virtual As ListViewItem = listTableMemoriaVirtual.Items(i)

                        If (virtual.SubItems.Item(1).Text = item.SubItems(1).Text And virtual.SubItems.Item(2).Text = item.SubItems(2).Text) Then
                            virtual.SubItems.Item(3).Text = 0
                            virtual.SubItems.Item(4).Text = posicaoSecundaria
                            Exit For
                        End If
                    Next
                    item.SubItems.Item(1).Text = pid
                    item.SubItems.Item(2).Text = fragmento

                    For i As Integer = 0 To listTableMemoriaVirtual.Items.Count - 1
                        Dim virtual As ListViewItem = listTableMemoriaVirtual.Items(i)

                        If (virtual.SubItems.Item(1).Text = pid And virtual.SubItems.Item(2).Text = fragmento) Then
                            virtual.SubItems.Item(3).Text = 1
                            virtual.SubItems.Item(4).Text = posicaoPrincipal
                            Exit For
                        End If
                    Next

                Else
                    Me.transfereProcesso(no, linha, ender, pid, fragmento)
                End If
            Else ' beleza o processo já se encontra na memória principal então é só executar :)
                ' macumbinha de leve
                linha = listMemoriaPrincipal.FindItemWithText(ender)
                If (linha IsNot Nothing) Then
                    Me.colorirLinha(linha, Color.Aqua)
                    linha.Remove()
                End If
                no.size -= 1
                If (no.size = 0) Then
                    MsgBox("O processo " & no.nome & " terminou!")
                End If
            End If
            Me.carregaListaProcessos()
            Me.atualizarPagina()
            btnExec.Enabled = True ' hora de habilitar o botão executar =D
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub colorirLinha(ByRef tabela As ListViewItem, ByVal color As Color)
        Try
            tabela.UseItemStyleForSubItems = True
            tabela.BackColor = color
            tabela.ListView.Refresh()
            Thread.Sleep(trkSpeed.Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub colorirLinha(ByRef tabela As ListViewItem, ByVal color As Color, ByVal tempo As Integer) ' metodo colorir com sleep pré definido no código
        Try
            tabela.UseItemStyleForSubItems = True
            tabela.BackColor = color
            tabela.ListView.Refresh()
            Thread.Sleep(tempo)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub transfereProcesso(ByRef no As Processo, ByRef linha As ListViewItem, ByRef ender As Integer, ByRef pid As Integer, ByRef fragmento As Integer)
        Try
            Me.transfereSwapPrincipal(no, linha, ender, pid, fragmento)
            btnExec.Enabled = True
            btnExec.PerformClick() ' vamos disparar a execução do processo novamente
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub transfereSwapPrincipal(ByRef no As Processo, ByRef linha As ListViewItem, ByRef ender As Integer, ByRef pid As Integer, ByRef fragmento As Integer)
        Dim iCount As Integer
        Dim virtual = listTableMemoriaVirtual.FindItemWithText(no.proxPagina)

        If (virtual IsNot Nothing) Then
            iCount = listMemoriaPrincipal.Items.Count + 1
            'vamos ver se o endereço atual já não está sendo usado, se estiver precisamos incrementar
            linha = listMemoriaPrincipal.FindItemWithText(iCount)
            While (linha IsNot Nothing)
                iCount += 1
                linha = listMemoriaPrincipal.FindItemWithText(iCount)
            End While

            no.pageFault += 1
            ender = iCount
            virtual.SubItems(4).Text = iCount
            virtual.SubItems(3).Text = 1
            ' vamos recuperar a cor da lista :)
            Me.colorirLinha(virtual, Color.FromArgb(255, 255, 128), 0)
            Me.carregaListaProcessos()
            listTableMemoriaVirtual.Refresh()
        End If
        ' add novo item na memoria principal
        listMemoriaPrincipal.Items.Add(iCount).SubItems.AddRange(New String() {pid, fragmento})
        linha = listMemoriaPrincipal.FindItemWithText(iCount)
        Me.colorirLinha(linha, Color.FromArgb(192, 255, 192), 0) ' recuperar a cor da linha 
    End Sub
    Private Sub ocuparMemoriaPrincipal()
        Try
            Dim linha = New ListViewItem
            Dim swapIndex = New ListViewItem
            Dim model = New ModelProcesso
            Dim no = model.seleciona(processos, Integer.Parse(txtExec.Text))
            Dim trava As Integer = 0

            If (listMemoriaPrincipal.Items.Count < CInt(Double.Parse(txtLimiteMemPrincipal.Text) * 0.6)) Then

                For i As Integer = 0 To listTableMemoriaVirtual.Items.Count - 1
                    Dim listItem As ListViewItem = listTableMemoriaVirtual.Items(i)
                    Dim iCount As Integer = 0

                    If (Integer.Parse(listItem.SubItems.Item(1).Text) = no.pid And Integer.Parse(listItem.SubItems.Item(3).Text) = 0) Then
                        swapIndex = listMemoriaSwap.FindItemWithText(listItem.SubItems.Item(4).Text)
                        linha = listMemoriaPrincipal.FindItemWithText(iCount)

                        While (linha IsNot Nothing)
                            iCount += 1
                            linha = listMemoriaPrincipal.FindItemWithText(iCount)
                        End While

                        If (listMemoriaPrincipal.Items.Count < Integer.Parse(txtLimiteMemPrincipal.Text)) Then
                            listMemoriaPrincipal.Items.Add(iCount).SubItems.AddRange(New String() {swapIndex.SubItems(1).Text, swapIndex.SubItems(2).Text})
                            Me.colorirLinha(swapIndex, Color.Red, 500)
                            swapIndex.Remove()

                            For j As Integer = 0 To listTableMemoriaVirtual.Items.Count - 1
                                Dim subListItem As ListViewItem = listTableMemoriaVirtual.Items(j)
                                If (subListItem.SubItems(1).Text = swapIndex.SubItems(1).Text And subListItem.SubItems(2).Text = swapIndex.SubItems(2).Text) Then
                                    subListItem.SubItems(3).Text = 1
                                    subListItem.SubItems(4).Text = iCount
                                    Me.colorirLinha(subListItem, Color.LightGreen, 500)
                                    Me.colorirLinha(listMemoriaPrincipal.FindItemWithText(iCount), Color.LightGreen, 500)
                                    Exit For
                                End If
                            Next
                        End If
                        '    listMemoriaPrincipal.Sort() 
                        trava += 1
                        If (trava > 2) Then Exit For

                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGerarProcessos.Click
        Dim novo = New ControllerLista
        Dim addP() As String = {"Firefox", "Chrome", "Avast", "Word", "Excel"}
        Dim nome As String
        Dim pid As Integer = 0
        btnGerarProcessos.Enabled = False
        For Each nome In addP
            'If (txtPid.Text = "" Or txtNome.Text = "" Or txtTamanho.Text = "") Then
            '    MsgBox("Por favor Preencha todos os campos")
            'Else
            ' inicia o random
            Randomize()
            ' valor entre 6 e 15.
            Dim tamanho As Integer = CInt(Int((10 * Rnd()) + 3))
            novo.inserirNoh(processos, pid, nome, tamanho)
            carregaListaProcessos()


            'statusLabel.Text = "Novo Processo" & txtNome.Text & " adicionado."
            pid = pid + 1

            'End If

        Next
        btnProcFrag.PerformClick()

        Dim item = processos.First
        listMemoriaSwap.Refresh()
		
        If (chkAutoExec.Checked = True) Then
            autoExec(item)
        End If
    End Sub

    Private Sub chkAutoExec_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoExec.CheckedChanged
        Dim item = processos.First

        If (chkAutoExec.Checked = True) Then
            autoExec(item)
        End If

    End Sub
	
	Private sub autoExec(item As ???) 
		While (item IsNot Nothing)
			For i As Integer = 0 To listTableMemoriaVirtual.Items.Count - 1
				If (item.value.size <> 0) Then
					txtExec.Text = item.value.pid
					btnExec.PerformClick()
				Else
					Exit For
				End If
			Next
			item = item.next
		End While
	End Sub
End Class