﻿Imports teamGen

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
        ' New Function, this doesn't touch pokemon1_grp as it doesn't need to.
        ' This new one works dynamically and took me forever to figure out. It
        ' isn't the prettiest thing, but it does the job.

        'Get the Index of NumPoke and set it as SelIndex
        Dim SelIndex As Integer = numPoké_cmb.SelectedIndex + 1

        For Index As Integer = 0 To 5
            ' Dynamically create the control names.
            Dim grpBoxName As String = "pokemon" & (Index + 1) & "_grp"

            ' Making sure they exists
            Dim controlArray() As Control = Me.Controls.Find(grpBoxName, True)

            ' Making Sure that the array is more than zero
            ' but also making sure that the is a groupbox so
            ' I don't accidently blow anything up.
            If controlArray.Length > 0 AndAlso TypeOf controlArray(0) Is GroupBox Then
                'Create a groupBox that acts as a DirectCast
                Dim Grps As GroupBox = DirectCast(controlArray(0), GroupBox)

                ' Now enable by the selindex, making it act as a bool
                Grps.Enabled = (Index < SelIndex)

                Debug.WriteLine(Grps.Name & "=" & (Index < SelIndex))
            End If
        Next
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


#Region "Old Gen Code"

    ' This is where an old function lives for now. It might stay, not sure though.
    ' DO NOT DELETE FOR NOW.

    'Private Sub updatePreview_btn_Click(sender As Object, e As EventArgs) Handles updatePreview_btn.Click
    '    If essVersion_cmb.SelectedIndex <= 0 Then
    '        ' Generator.essentials17()
    '    ElseIf essVersion_cmb.SelectedIndex >= 1 Then

    '        ' Clear the preview box
    '        preview_rtb.Text = ""

    '        Try
    '            ' Pokemon1
    '            If numPoké_cmb.SelectedIndex >= 0 Then
    '                preview_rtb.Text &= Generator.essentials18(pokemon1Name_txtBox.Text, pokemon1HeldItem_txtBox.Text,
    '                                       Integer.Parse(pokemon1Level_txtBox.Text), pokemon1Ability_cmb.Text, pokemon1Gender_cmb.Text, Integer.Parse(pokemon1Form_txtBox.Text),
    '                                       pokemon1Nature_cmb.Text, pokemon1Happiness_txtBox.Text, pokemon1Nickname_txtBox.Text, pokemon1PokeballID_cmb.Text, pokemon1Shiny_rad.Checked,
    '                                       pokemon1SuperShiny_chkBox.Checked, pokemon1Shadow_rad.Checked,
    '                                       pokemon1IVsHP_txt.Text, pokemon1IVsATK_txt.Text, pokemon1IVsDEF_txt.Text, pokemon1IVsSPD_txt.Text, pokemon1IVsSPATK_txt.Text, pokemon1IVsSPDEF_txt.Text,
    '                                       pokemon1EVsHP_txt.Text, pokemon1EVsATK_txt.Text, pokemon1EVsDEF_txt.Text, pokemon1EVsSPD_txt.Text, pokemon1EVsSPATK_txt.Text, pokemon1EVsSPDEF_txt.Text)
    '            End If

    '            ' Pokemon2
    '            If numPoké_cmb.SelectedIndex >= 1 Then
    '                preview_rtb.Text &= ""
    '            End If

    '            ' Pokemon3
    '            If numPoké_cmb.SelectedIndex >= 2 Then
    '                preview_rtb.Text &= ""
    '            End If

    '            ' Pokemon4
    '            If numPoké_cmb.SelectedIndex >= 3 Then
    '                preview_rtb.Text &= ""
    '            End If

    '            ' Pokemon5
    '            If numPoké_cmb.SelectedIndex >= 4 Then
    '                preview_rtb.Text &= ""
    '            End If

    '            ' Pokemon6
    '            If numPoké_cmb.SelectedIndex = 5 Then
    '                preview_rtb.Text &= ""
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("There was an error when generating the team. Please make sure there are only numbers in the Level, Happiness, Form, IVs and EVs boxes.", "Error",
    '                            MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try

    '    End If
    'End Sub

#End Region

    Private Sub GeneratePreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratePreviewToolStripMenuItem.Click

    End Sub
End Class
