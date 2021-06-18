Public Class Form1
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleButton1_Click_1(sender As Object, e As EventArgs) Handles btn1.Click
        WebView21.CoreWebView2.Navigate(setup.Guna2TextBox1.Text)
    End Sub

    Private Sub WebView21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        WebView21.CoreWebView2.Navigate(setup.Guna2TextBox2.Text)
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles btn3.Click

    End Sub

    Private Sub WebView21_Click_1(sender As Object, e As EventArgs) Handles WebView21.Click

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        setup.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.CB1 = True Then
            btn1.Show()
            setup.Guna2CheckBox1.Checked = True
        Else
            btn1.Hide()
        End If
        If My.Settings.CB2 = True Then
            btn2.Show()
            setup.Guna2CheckBox2.Checked = True
        Else
            btn2.Hide()
        End If
        If My.Settings.CB3 = True Then
            btn3.Show()
            setup.Guna2CheckBox3.Checked = True
        Else
            btn3.Hide()

        End If
        If My.Settings.CB4 = True Then
            btn4.Show()
            setup.Guna2CheckBox4.Checked = True

        Else
            btn4.Hide()
        End If
        If My.Settings.CB5 = True Then
            btn5.Show()
            setup.Guna2CheckBox5.Checked = True

        Else
            btn5.Hide()
        End If
        If My.Settings.CB6 = True Then
            btn6.Show()
            setup.Guna2CheckBox6.Checked = True

        Else
            btn6.Hide()
        End If
        If My.Settings.CB7 = True Then
            btn7.Show()
            setup.Guna2CheckBox7.Checked = True

        Else
            btn7.Hide()
        End If
        If My.Settings.CB8 = True Then
            btn8.Show()
            setup.Guna2CheckBox8.Checked = True

        Else
            btn8.Hide()
        End If
        If My.Settings.CB9 = True Then
            btn9.Show()
            setup.Guna2CheckBox9.Checked = True

        Else
            btn9.Hide()
        End If
        If My.Settings.CB10 = True Then
            btn10.Show()
            setup.Guna2CheckBox10.Checked = True

        Else
            btn10.Hide()
        End If
        If My.Settings.CB11 = True Then
            btn11.Show()
            setup.Guna2CheckBox11.Checked = True

        Else
            btn11.Hide()
        End If
        If My.Settings.CB12 = True Then
            btn12.Show()
            setup.Guna2CheckBox12.Checked = True

        Else
            btn12.Hide()
        End If
        If My.Settings.CB13 = True Then
            btn13.Show()
            setup.Guna2CheckBox13.Checked = True

        Else
            btn13.Hide()
        End If
        If My.Settings.CB14 = True Then
            btn14.Show()
            setup.Guna2CheckBox14.Checked = True

        Else
            btn14.Hide()
        End If
        If My.Settings.CB15 = True Then
            btn15.Show()
            setup.Guna2CheckBox15.Checked = True

        Else
            btn15.Hide()
        End If
        If My.Settings.CB16 = True Then
            btn16.Show()
            setup.Guna2CheckBox16.Checked = True

        Else
            btn16.Hide()
        End If
        setup.Guna2TextBox1.Text = My.Settings.link1
        setup.Guna2TextBox2.Text = My.Settings.link2
        setup.Guna2TextBox3.Text = My.Settings.link3
        setup.Guna2TextBox4.Text = My.Settings.link4
        setup.Guna2TextBox5.Text = My.Settings.link5
        setup.Guna2TextBox6.Text = My.Settings.link6
        setup.Guna2TextBox7.Text = My.Settings.link7
        setup.Guna2TextBox8.Text = My.Settings.link8
        setup.Guna2TextBox9.Text = My.Settings.link9
        setup.Guna2TextBox10.Text = My.Settings.link10
        setup.Guna2TextBox11.Text = My.Settings.link11
        setup.Guna2TextBox12.Text = My.Settings.link12
        setup.Guna2TextBox13.Text = My.Settings.link13
        setup.Guna2TextBox14.Text = My.Settings.link14
        setup.Guna2TextBox15.Text = My.Settings.link15
        setup.Guna2TextBox16.Text = My.Settings.link16

    End Sub
End Class
