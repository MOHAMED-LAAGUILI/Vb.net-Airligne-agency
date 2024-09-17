Public Class Form1
    Public Sub Nouveau()
        txt1.Text = Nothing
        txt2.Text = Nothing
        txt3.Text = Nothing
        txt4.Text = ""
        txt1.Focus()
    End Sub

    Public Sub Calculer()
        Dim pap As Double = 0

        If txt3.Text.CompareTo("Tanger") = 0 Then
            pap = 40.5
        ElseIf txt3.Text.CompareTo("Rabat") = 0 Then
            pap = 60.0
        ElseIf txt3.Text.CompareTo("Casa") = 0 Then
            pap = 97.0
        ElseIf txt3.Text.CompareTo("Fes") = 0 Then
            pap = 120.0
        ElseIf txt3.Text.CompareTo("Agadir") = 0 Then
            pap = 270.0
        ElseIf txt3.Text.CompareTo("Oujda") = 0 Then
            pap = 150.0
        End If

        txt4.Text = pap.ToString + " DH"
    End Sub
  
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        Nouveau()
    End Sub

    Private Sub txt3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.SelectedIndexChanged
        Calculer()
    End Sub

    Private Sub btf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btf.Click
        If MessageBox.Show("Etes vous sure de quiter ?", "Quitter l'application", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
