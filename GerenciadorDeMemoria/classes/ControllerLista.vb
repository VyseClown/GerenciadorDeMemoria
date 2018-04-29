Public Class ControllerLista
    Public Sub inserirNoh(ByRef linkedList As LinkedList(Of Processo), ByVal pid As Integer, ByVal nome As String, ByVal size As Integer)
        Try
            Dim novo = New ModelProcesso
            Dim temp As Processo
            Dim proxPagina As Integer = 0
            Dim pageFault As Integer = 0

            temp = novo.seleciona(linkedList, pid)

            If (temp Is Nothing) Then
                novo.insere(linkedList, Integer.Parse(pid), nome, Integer.Parse(size), proxPagina, pageFault)
            Else
                Throw New Exception("Já existe um processo com o mesmo PID")
            End If

            temp = Nothing
            novo = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub remover(ByRef linkedList As LinkedList(Of Processo), ByVal pid As Integer)
        Try
            Dim item = New ModelProcesso
            item.remove(linkedList, Integer.Parse(pid))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub atualizaPagina(ByRef linkedList As LinkedList(Of Processo), ByVal pID As Integer, ByVal enderesso As Integer)
        Try
            Dim model = New ModelProcesso
            model.atualizaPagina(linkedList, pID, enderesso)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
