Public Class Form1

    Private Sub FaireClignoter()
        Timer1.Interval = 200
        Timer1.Tag = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Visible = (Label3.Visible = False)
        Timer1.Tag += 1
        If Timer1.Tag = 20 Then
            Timer1.Stop()
            Label3.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Static c As Byte
        c = c + 1
        If TextBox1.Text > Label1.Text Then
            Label2.Text = "C'est moins que " & TextBox1.Text
        ElseIf TextBox1.Text < Label1.Text Then
            Label2.Text = "C'est plus que " & TextBox1.Text
        ElseIf TextBox1.Text = Label1.Text Then
            Label2.Text = "BRAVO!!!"
            Label3.Text = "Tu as gagné en " & c & " coups"
            FaireClignoter()
            c = 0
            Button1.Enabled = False
            Button2.Enabled = True
        End If
        TextBox1.Text = ""
        Me.ActiveControl = TextBox1
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Integer
        Randomize()
        a = Int(500 * Rnd())
        Label1.Text = a
        Label3.Text = ""
        Label2.Text = ""
        Button1.Enabled = True
        Button2.Enabled = False
        TextBox1.Text = ""
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub ElementHost1_ChildChanged(sender As Object, e As Integration.ChildChangedEventArgs)

    End Sub
End Class
