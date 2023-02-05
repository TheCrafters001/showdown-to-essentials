Imports DiscordRPCHandler

Public Class Startup
    Public Shared Sub Init()

        ' Discord Rich Presence
        InitRPC.Setup()

        ' Showdown Combobox
        Form1.sd_PokePos_cmb.SelectedIndex = 0

        ' Set internalBallNames_chk to checked by default.
        Form1.internalBallNames_chk.Checked = True

        ' Clear all Items to remove the object text.
        Form1.trainerItemsList_lstbox.Items.Clear()

        Form1.numPoké_cmb.SelectedIndex = 0
        '
        ' pokemonOne
        '
        Form1.pokemonOneGender_cmb.SelectedIndex = 2
        Form1.pokemonOneNature_cmb.SelectedIndex = 0
        Form1.pokemonOneAbility_cmb.SelectedIndex = 0
        Form1.pokemonOneShinyFalse_rad.Checked = True
        Form1.pokemonOneShadowFalse_rad.Checked = True
        Form1.pokemonOnePokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonTwo
        '
        Form1.pokemonTwoGender_cmb.SelectedIndex = 2
        Form1.pokemonTwoNature_cmb.SelectedIndex = 0
        Form1.pokemonTwoAbility_cmb.SelectedIndex = 0
        Form1.pokemonTwoShinyFalse_rad.Checked = True
        Form1.pokemonTwoShadowFalse_rad.Checked = True
        Form1.pokemonTwoPokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonThree
        '
        Form1.pokemonThreeGender_cmb.SelectedIndex = 2
        Form1.pokemonThreeNature_cmb.SelectedIndex = 0
        Form1.pokemonThreeAbility_cmb.SelectedIndex = 0
        Form1.pokemonThreeShinyFalse_Rad.Checked = True
        Form1.pokemonThreeShadowFalse_rad.Checked = True
        Form1.pokemonThreePokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonFour
        '
        Form1.pokemonFourGender_cmb.SelectedIndex = 2
        Form1.pokemonFourNature_cmb.SelectedIndex = 0
        Form1.pokemonFourAbility_cmb.SelectedIndex = 0
        Form1.pokemonFourShinyFalse_rad.Checked = True
        Form1.pokemonFourShadowFalse_rad.Checked = True
        Form1.pokemonFourPokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonFive
        '
        Form1.pokemonFiveGender_cmb.SelectedIndex = 2
        Form1.pokemonFiveNature_cmb.SelectedIndex = 0
        Form1.pokemonFiveAbility_cmb.SelectedIndex = 0
        Form1.pokemonFiveShinyFalse_rad.Checked = True
        Form1.pokemonFiveShadowFalse_rad.Checked = True
        Form1.pokemonFivePokeballID_cmb.SelectedIndex = 0
        '
        ' pokemonSix
        '
        Form1.pokemonSixGender_cmb.SelectedIndex = 2
        Form1.pokemonSixNature_cmb.SelectedIndex = 0
        Form1.pokemonSixAbility_cmb.SelectedIndex = 0
        Form1.pokemonSixShinyFalse_rad.Checked = True
        Form1.pokemonSixShadowFalse_rad.Checked = True
        Form1.pokemonSixPokeballID_cmb.SelectedIndex = 0

        'Form1.Timer1.Start()
    End Sub
End Class
