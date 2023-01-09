Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setupForm()
    End Sub
    Sub setupForm()
        Dim x, y As Integer ' Starting co-ordinates
        x = 10
        y = 10
        For i = 1 To 10
            Dim b As New Button ' creates a button object
            With b ' all code within with simulates b.
                .Text = "My Button " & i ' change the text of the button
                .Name = "btn" & i ' give the button a name (for future use)
                .Location = New Point(x, y) 'set the x and y location
                .Size = New Size(100, 30) ' give it a size (w,h)
            End With
            Me.Controls.Add(b) ' add the button object to the form
            y += 35 ' increment y 
        Next

    End Sub
End Class
