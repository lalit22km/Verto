Public Class setup
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2TextBox49_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox49.TextChanged

    End Sub

    Private Sub Guna2TextBox50_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox50.TextChanged

    End Sub

    Private Sub Guna2TextBox51_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox51.TextChanged

    End Sub

    Private Sub Guna2TextBox52_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox52.TextChanged

    End Sub

    Private Sub Guna2TextBox28_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox28.TextChanged

    End Sub

    Private Sub Guna2TextBox27_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox27.TextChanged

    End Sub

    Private Sub Guna2TextBox26_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox26.TextChanged

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2CheckBox1.Checked = True Then
            My.Settings.CB1 = True
        Else
            My.Settings.CB1 = False
        End If
        If Guna2CheckBox2.Checked = True Then
            My.Settings.CB2 = True
        Else
            My.Settings.CB2 = False
        End If
        If Guna2CheckBox3.Checked = True Then
            My.Settings.CB3 = True
        Else
            My.Settings.CB3 = False
        End If
        If Guna2CheckBox4.Checked = True Then
            My.Settings.CB4 = True
        Else
            My.Settings.CB4 = False
        End If
        If Guna2CheckBox5.Checked = True Then
            My.Settings.CB5 = True
        Else
            My.Settings.CB5 = False
        End If
        If Guna2CheckBox6.Checked = True Then
            My.Settings.CB6 = True
        Else
            My.Settings.CB6 = False
        End If
        If Guna2CheckBox7.Checked = True Then
            My.Settings.CB7 = True
        Else
            My.Settings.CB7 = False
        End If
        If Guna2CheckBox8.Checked = True Then
            My.Settings.CB8 = True
        Else
            My.Settings.CB8 = False
        End If
        If Guna2CheckBox9.Checked = True Then
            My.Settings.CB9 = True
        Else
            My.Settings.CB9 = False
        End If
        If Guna2CheckBox10.Checked = True Then
            My.Settings.CB10 = True
        Else
            My.Settings.CB10 = False
        End If
        If Guna2CheckBox11.Checked = True Then
            My.Settings.CB11 = True
        Else
            My.Settings.CB11 = False
        End If
        If Guna2CheckBox12.Checked = True Then
            My.Settings.CB12 = True
        Else
            My.Settings.CB12 = False
        End If
        If Guna2CheckBox13.Checked = True Then
            My.Settings.CB13 = True
        Else
            My.Settings.CB13 = False
        End If
        If Guna2CheckBox14.Checked = True Then
            My.Settings.CB14 = True
        Else
            My.Settings.CB14 = False
        End If
        If Guna2CheckBox15.Checked = True Then
            My.Settings.CB15 = True
        Else
            My.Settings.CB15 = False
        End If
        If Guna2CheckBox16.Checked = True Then
            My.Settings.CB16 = True
        Else
            My.Settings.CB16 = False
        End If

        If My.Settings.CB1 = True Then
            Form1.btn1.Show()

        Else
            Form1.btn1.Hide()
        End If
        If My.Settings.CB2 = True Then
            Form1.btn2.Show()
        Else
            Form1.btn2.Hide()
        End If
        If My.Settings.CB3 = True Then
            Form1.btn3.Show()
        Else
            Form1.btn3.Hide()
        End If
        If My.Settings.CB4 = True Then
            Form1.btn4.Show()
        Else
            Form1.btn4.Hide()
        End If
        If My.Settings.CB5 = True Then
            Form1.btn5.Show()
        Else
            Form1.btn5.Hide()
        End If
        If My.Settings.CB6 = True Then
            Form1.btn6.Show()
        Else
            Form1.btn6.Hide()
        End If
        If My.Settings.CB7 = True Then
            Form1.btn7.Show()
        Else
            Form1.btn7.Hide()
        End If
        If My.Settings.CB8 = True Then
            Form1.btn8.Show()
        Else
            Form1.btn8.Hide()
        End If
        If My.Settings.CB9 = True Then
            Form1.btn9.Show()
        Else
            Form1.btn9.Hide()
        End If
        If My.Settings.CB10 = True Then
            Form1.btn10.Show()
        Else
            Form1.btn10.Hide()
        End If
        If My.Settings.CB11 = True Then
            Form1.btn11.Show()
        Else
            Form1.btn11.Hide()
        End If
        If My.Settings.CB12 = True Then
            Form1.btn12.Show()
        Else
            Form1.btn12.Hide()
        End If
        If My.Settings.CB13 = True Then
            Form1.btn13.Show()
        Else
            Form1.btn13.Hide()
        End If
        If My.Settings.CB14 = True Then
            Form1.btn14.Show()
        Else
            Form1.btn14.Hide()
        End If
        If My.Settings.CB15 = True Then
            Form1.btn15.Show()
        Else
            Form1.btn15.Hide()
        End If
        If My.Settings.CB16 = True Then
            Form1.btn16.Show()
        Else
            Form1.btn16.Hide()
        End If
        My.Settings.link1 = Guna2TextBox1.Text
        My.Settings.link2 = Guna2TextBox2.Text
        My.Settings.link3 = Guna2TextBox3.Text
        My.Settings.link4 = Guna2TextBox4.Text
        My.Settings.link5 = Guna2TextBox5.Text
        My.Settings.link6 = Guna2TextBox6.Text
        My.Settings.link7 = Guna2TextBox7.Text
        My.Settings.link8 = Guna2TextBox8.Text
        My.Settings.link9 = Guna2TextBox9.Text
        My.Settings.link10 = Guna2TextBox10.Text
        My.Settings.link11 = Guna2TextBox11.Text
        My.Settings.link12 = Guna2TextBox12.Text
        My.Settings.link13 = Guna2TextBox13.Text
        My.Settings.link14 = Guna2TextBox14.Text
        My.Settings.link15 = Guna2TextBox15.Text
        My.Settings.link16 = Guna2TextBox16.Text
    End Sub
End Class