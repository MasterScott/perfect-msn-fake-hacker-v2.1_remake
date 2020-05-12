Public Class Form1
    Dim blnButtonDown
    Private Sub Button1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Button1.Paint
        If blnButtonDown = False Then
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Raised)
        Else
            ControlPaint.DrawBorder3D(e.Graphics, sender.ClientRectangle,
                    Border3DStyle.Sunken)
        End If
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        blnButtonDown = True
        sender.Invalidate()
    End Sub

    Private Sub Button1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseUp
        blnButtonDown = False
        sender.Invalidate()
    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Install patch for work correct"
    End Sub
End Class
