Imports teamGen

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Essentials Version
        essVersion_cmb.SelectedIndex = 4 ' Essentials 21

        ' Amount of Pokemon
        numPoké_cmb.SelectedIndex = 0

        ' Gender
        pokemon1Gender_cmb.SelectedIndex = 2

        ' Copyright
        copyright_lbl.Text = My.Application.Info.Copyright
    End Sub

    Private Sub existingBattle_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles existingBattle_chkBox.CheckedChanged
        If existingBattle_chkBox.Checked = True Then
            battleTeamID_lbl.Enabled = True
            battleTeamID_txtBox.Enabled = True
        Else
            battleTeamID_lbl.Enabled = False
            battleTeamID_txtBox.Enabled = False
        End If
    End Sub

    Private Sub essVersion_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles essVersion_cmb.SelectedIndexChanged
        ObjectCheck.EssVersion()
    End Sub

    Private Sub numPoké_cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles numPoké_cmb.SelectedIndexChanged
        If numPoké_cmb.SelectedIndex = 0 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = False
            pokemon3_grp.Enabled = False
            pokemon4_grp.Enabled = False
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 1 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = False
            pokemon4_grp.Enabled = False
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 2 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = False
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 3 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = True
            pokemon5_grp.Enabled = False
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 4 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = True
            pokemon5_grp.Enabled = True
            pokemon6_grp.Enabled = False

        ElseIf numPoké_cmb.SelectedIndex = 5 Then
            pokemon1_grp.Enabled = True
            pokemon2_grp.Enabled = True
            pokemon3_grp.Enabled = True
            pokemon4_grp.Enabled = True
            pokemon5_grp.Enabled = True
            pokemon6_grp.Enabled = True
        End If
    End Sub

    Private Sub useAbilityIndex_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles useAbilityIndex_chkBox.CheckedChanged
        If useAbilityIndex_chkBox.Checked = True Then
            'pokemon1Ability_cmb.Items.Remove
        Else

        End If
    End Sub

    Private Sub allowSuperShiny_chk_CheckedChanged(sender As Object, e As EventArgs) Handles allowSuperShiny_chk.CheckedChanged
        ObjectCheck.SuperShiny()
    End Sub

    Private Sub customBallIDs_chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles customBallIDs_chkBox.CheckedChanged

    End Sub

    Private Sub updatePreview_btn_Click(sender As Object, e As EventArgs) Handles updatePreview_btn.Click
        If essVersion_cmb.SelectedIndex <= 0 Then
            ' Generator.essentials17()
        ElseIf essVersion_cmb.SelectedIndex >= 1 Then

            ' Clear the preview box
            preview_rtb.Text = ""

            Try
                ' Pokemon1
                If numPoké_cmb.SelectedIndex >= 0 Then
                    preview_rtb.Text &= Generator.essentials18(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text,
                                           Integer.Parse(pokemon1Level_txtBox.Text), pokemon1Ability_cmb.Text, pokemon1Gender_cmb.Text, Integer.Parse(pokemon1Form_txtBox.Text),
                                           pokemon1Nature_cmb.Text, pokemon1Happiness_txtBox.Text, pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked,
                                           pokemon1SuperShiny_chkBox.Checked, pokemon1Shadow_rad.Checked,
                                           pokemon1IVsHP_txt.Text, pokemon1IVsATK_txt.Text, pokemon1IVsDEF_txt.Text, pokemon1IVsSPD_txt.Text, pokemon1IVsSPATK_txt.Text, pokemon1IVsSPDEF_txt.Text,
                                           pokemon1EVsHP_txt.Text, pokemon1EVsATK_txt.Text, pokemon1EVsDEF_txt.Text, pokemon1EVsSPD_txt.Text, pokemon1EVsSPATK_txt.Text, pokemon1EVsSPDEF_txt.Text)
                End If

                ' Pokemon2
                If numPoké_cmb.SelectedIndex >= 1 Then
                    preview_rtb.Text &= ""
                End If

                ' Pokemon3
                If numPoké_cmb.SelectedIndex >= 2 Then
                    preview_rtb.Text &= ""
                End If

                ' Pokemon4
                If numPoké_cmb.SelectedIndex >= 3 Then
                    preview_rtb.Text &= ""
                End If

                ' Pokemon5
                If numPoké_cmb.SelectedIndex >= 4 Then
                    preview_rtb.Text &= ""
                End If

                ' Pokemon6
                If numPoké_cmb.SelectedIndex = 5 Then
                    preview_rtb.Text &= ""
                End If
            Catch ex As Exception
                MessageBox.Show("There was an error when generating the team. Please make sure there are only numbers in the Level, Happiness, Form, IVs and EVs boxes.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class
