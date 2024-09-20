Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Enemy, Avatar, 10)
        follow(Enemy2, Enemy, 5)
    End Sub
    Sub follow(e As PictureBox, a As PictureBox, s As Integer)
        If e.Location.Y > a.Location.Y Then
            move(e, 0, -s)
        Else
            move(e, 0, s)
        End If
        If e.Location.X > a.Location.X Then
            move(e, -s, 0)
        Else
            move(e, s, 0)
        End If
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            move(Avatar, -5, 0)
        End If
        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            move(Avatar, 5, 0)

        End If
        If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            move(Avatar, 0, 15)
        End If
        If e.KeyCode = Keys.R Or e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipXY)
        End If
        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            move(Avatar, 0, -5)
        End If
        Avatar.Refresh()
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If p.Bounds.IntersectsWith(Banana.Bounds) Then
            Banana.Visible = False
        End If
    End Sub
End Class
