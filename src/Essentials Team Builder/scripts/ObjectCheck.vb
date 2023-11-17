''' <summary>
''' This function is meant to be ran if you run something like CheckedChanged or SelectedIndexChanged.
''' </summary>
Public Class ObjectCheck

    ''' <summary>
    ''' Used when the version of Essentials is changed.
    ''' </summary>
    Public Shared Sub EssVersion()
        If Form1.essVersion_cmb.SelectedIndex = 0 Then ' Essentials 17
            ' Custom Pokeball IDs
            Form1.customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            Form1.useAbilityIndex_chkBox.Enabled = False
            Form1.useAbilityIndex_chkBox.Checked = False

            ' Quotes for Lose Text
            Form1.loseTextQuotes_chkBox.Enabled = False
            Form1.loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            Form1.allowSuperShiny_chk.Enabled = False
            Form1.allowSuperShiny_chk.Checked = False


        ElseIf Form1.essVersion_cmb.SelectedIndex = 1 Then ' Essentials 18
            ' Custom Pokeball IDs
            Form1.customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            Form1.useAbilityIndex_chkBox.Enabled = False
            Form1.useAbilityIndex_chkBox.Checked = False

            ' Quotes for Lose Text
            Form1.loseTextQuotes_chkBox.Enabled = False
            Form1.loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            Form1.allowSuperShiny_chk.Enabled = False
            Form1.allowSuperShiny_chk.Checked = False


        ElseIf Form1.essVersion_cmb.SelectedIndex = 2 Then ' Essentials 19
            ' Custom Pokeball IDs
            Form1.customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            Form1.useAbilityIndex_chkBox.Enabled = True
            Form1.useAbilityIndex_chkBox.Checked = True

            ' Quotes for Lose Text
            Form1.loseTextQuotes_chkBox.Enabled = True
            Form1.loseTextQuotes_chkBox.Checked = True

            ' Super Shiny
            Form1.allowSuperShiny_chk.Enabled = False
            Form1.allowSuperShiny_chk.Checked = False


        ElseIf Form1.essVersion_cmb.SelectedIndex = 3 Then ' Essentials 20
            ' Custom Pokeball IDs
            Form1.customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            Form1.useAbilityIndex_chkBox.Enabled = True
            Form1.useAbilityIndex_chkBox.Checked = True

            ' Quotes for Lose Text
            Form1.loseTextQuotes_chkBox.Enabled = False
            Form1.loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            Form1.allowSuperShiny_chk.Enabled = False
            Form1.allowSuperShiny_chk.Checked = False


        ElseIf Form1.essVersion_cmb.SelectedIndex = 4 Then ' Essentials 21
            ' Custom Pokeball IDs
            Form1.customBallIDs_chkBox.Enabled = True
            ' customBallIDs_chkBox.Checked = False

            ' Use Ability Index
            Form1.useAbilityIndex_chkBox.Enabled = True
            Form1.useAbilityIndex_chkBox.Checked = True

            ' Quotes for Lose Text
            Form1.loseTextQuotes_chkBox.Enabled = False
            Form1.loseTextQuotes_chkBox.Checked = False

            ' Super Shiny
            Form1.allowSuperShiny_chk.Enabled = True
            Form1.allowSuperShiny_chk.Checked = False
        End If
    End Sub


    ''' <summary>
    ''' Used to update the status of Super Shiny stuff.
    ''' </summary>
    Public Shared Sub SuperShiny()
        If Form1.allowSuperShiny_chk.Checked = True Then
            Form1.pokemon1SuperShiny_chkBox.Enabled = True
        Else
            Form1.pokemon1SuperShiny_chkBox.Enabled = False
        End If
    End Sub


    Public Shared Sub customBallID()
        If Form1.customBallIDs_chkBox.Checked = False Then
            Form1.pokemon1PokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDownList

        ElseIf Form1.customBallIDs_chkBox.Checked = True Then
            Form1.pokemon1PokeballID_cmb.DropDownStyle = ComboBoxStyle.DropDown
        End If
    End Sub
End Class
