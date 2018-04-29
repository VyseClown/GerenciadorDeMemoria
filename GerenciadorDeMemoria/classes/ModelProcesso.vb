Public Class ModelProcesso
    Public Sub insere(ByRef linkedList As LinkedList(Of Processo), ByVal pid As Integer, ByVal nome As String, ByVal size As Integer, ByVal pageFault As Integer, ByVal proxPagina As Integer)
        Try
            linkedList.AddLast(New Processo With {.pid = pid, .nome = nome, .size = size, .pageFault = pageFault, .proxPagina = proxPagina, .fragmento = 0})
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Function remove(ByRef linkedList As LinkedList(Of Processo), ByVal pid As Integer) As Boolean
        Try
            Dim item = Me.seleciona(linkedList, pid)

            If (item IsNot Nothing) Then
                linkedList.Remove(item)
                Return True
            Else
                Throw New Exception("Item não encontrado")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Function seleciona(ByVal linkedList As LinkedList(Of Processo), ByVal pid As Integer) As Processo
        Try
            Return linkedList.FirstOrDefault(Function(x) x.pid = pid)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Sub atualizaPagina(ByRef linkedList As LinkedList(Of Processo), ByVal pid As Integer, ByVal pagina As Integer)
        Try
            Dim no = Me.seleciona(linkedList, pid) 'seleciono o objeto contido no nó
            no.proxPagina = pagina 'e atualizao o objeto
            ' como o parametro linkedlist é passado por referencia, 
            ' qualquer mudança no objeto reflete diretamente na lista de processos : )
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
