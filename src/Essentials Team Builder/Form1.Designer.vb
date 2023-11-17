<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        editor_grp = New GroupBox()
        editor_tab = New TabControl()
        pg_trainer = New TabPage()
        trainer_tab = New TabControl()
        pg_basic = New TabPage()
        essData_lbl = New Label()
        allowSuperShiny_chk = New CheckBox()
        loseTextQuotes_chkBox = New CheckBox()
        useAbilityIndex_chkBox = New CheckBox()
        existingBattle_chkBox = New CheckBox()
        customBallIDs_chkBox = New CheckBox()
        essVersion_cmb = New ComboBox()
        essVersion_lbl = New Label()
        battleTeamID_txtBox = New TextBox()
        battleTeamID_lbl = New Label()
        numPoké_lbl = New Label()
        numPoké_cmb = New ComboBox()
        loseText_lbl = New Label()
        loseText_txt = New TextBox()
        trainerType_txtBox = New TextBox()
        trainerType_lbl = New Label()
        trainerName_txtBox = New TextBox()
        trainerName_lbl = New Label()
        trainerInfoHeader_lbl = New Label()
        pg_items = New TabPage()
        pg_pokemon = New TabPage()
        TabControl3 = New TabControl()
        pg_pkmn1 = New TabPage()
        pokemon1_grp = New GroupBox()
        pokemon1EVs_grp = New GroupBox()
        pokemon1EVsDEF_txt = New TextBox()
        pokemon1EVsDEF_lbl = New Label()
        pokemon1EVsSPDEF_txt = New TextBox()
        pokemon1EVsSPDEF_lbl = New Label()
        pokemon1EVsSPATK_txt = New TextBox()
        pokemon1EVsSPATK_lbl = New Label()
        pokemon1EVsSPD_txt = New TextBox()
        pokemon1EVsSPD_lbl = New Label()
        pokemon1EVsATK_txt = New TextBox()
        pokemon1EVsATK_lbl = New Label()
        pokemon1EVsHP_txt = New TextBox()
        pokemon1EVsHP_lbl = New Label()
        pokemon1IVs_grp = New GroupBox()
        pokemon1RandomIVs_btn = New Button()
        pokemon1MaxIVs_btn = New Button()
        pokemon1IVsDEF_txt = New TextBox()
        pokemon1IVsDEF_lbl = New Label()
        pokemon1IVsSPDEF_txt = New TextBox()
        pokemon1IVsSPDEF_lbl = New Label()
        pokemon1IVsSPATK_txt = New TextBox()
        pokemon1IVsSPATK_lbl = New Label()
        pokemon1IVsSPD_txt = New TextBox()
        pokemon1IVsSPD_lbl = New Label()
        pokemon1IVsATK_txt = New TextBox()
        pokemon1IVsATK_lbl = New Label()
        pokemon1IVsHP_txt = New TextBox()
        pokemon1IVsHP_lbl = New Label()
        pokemon1PokeballID_cmb = New ComboBox()
        pokemon1Ball_lbl = New Label()
        pokemon1Nickname_txtBox = New TextBox()
        pokemon1Nickname_lbl = New Label()
        pokemon1Happiness_txtBox = New TextBox()
        pokemon1Happiness_lbl = New Label()
        pokemon1Nature_cmb = New ComboBox()
        pokemon1Nature_lbl = New Label()
        pokemon1Shiny_grp = New GroupBox()
        pokemon1SuperShiny_chkBox = New CheckBox()
        pokemon1Shiny_rad = New RadioButton()
        pokemon1NotShiny_rad = New RadioButton()
        pokemon1Form_txtBox = New TextBox()
        pokemon1Form_lbl = New Label()
        pokemon1Gender_cmb = New ComboBox()
        pokemon1Gender_lbl = New Label()
        pokemon1Ability_cmb = New ComboBox()
        pokemon1Ability_lbl = New Label()
        pokemon1Moves_grp = New GroupBox()
        pokemon1Move4_txtBox = New TextBox()
        pokemon1Move3_txtBox = New TextBox()
        pokemon1Move2_txtBox = New TextBox()
        pokemon1Move1_txtBox = New TextBox()
        pokemon1Level_txtBox = New TextBox()
        pokemon1Level_lbl = New Label()
        pokemon1HeldItem_lbl = New Label()
        pokemon1HeldItem_txtBox = New TextBox()
        pokemon1Name_txtBox = New TextBox()
        pokemon1Name_lbl = New Label()
        pg_pkmn2 = New TabPage()
        pokemon2_grp = New GroupBox()
        pg_pkmn3 = New TabPage()
        pokemon3_grp = New GroupBox()
        pg_pkmn4 = New TabPage()
        pokemon4_grp = New GroupBox()
        pg_pkmn5 = New TabPage()
        pokemon5_grp = New GroupBox()
        pg_pkmn6 = New TabPage()
        pokemon6_grp = New GroupBox()
        pg_about = New TabPage()
        aboutInfo_lbl = New Label()
        copyright_lbl = New Label()
        aboutHeaderAuthor_lbl = New Label()
        aboutHeader_lbl = New Label()
        preview_grp = New GroupBox()
        preview_rtb = New RichTextBox()
        updatePreview_btn = New Button()
        properSpellingNote_lbl = New Label()
        Label2 = New Label()
        pokemon1Shadow_grp = New GroupBox()
        pokemon1Shadow_rad = New RadioButton()
        pokemon1NotShadow_rad = New RadioButton()
        editor_grp.SuspendLayout()
        editor_tab.SuspendLayout()
        pg_trainer.SuspendLayout()
        trainer_tab.SuspendLayout()
        pg_basic.SuspendLayout()
        pg_pokemon.SuspendLayout()
        TabControl3.SuspendLayout()
        pg_pkmn1.SuspendLayout()
        pokemon1_grp.SuspendLayout()
        pokemon1EVs_grp.SuspendLayout()
        pokemon1IVs_grp.SuspendLayout()
        pokemon1Shiny_grp.SuspendLayout()
        pokemon1Moves_grp.SuspendLayout()
        pg_pkmn2.SuspendLayout()
        pg_pkmn3.SuspendLayout()
        pg_pkmn4.SuspendLayout()
        pg_pkmn5.SuspendLayout()
        pg_pkmn6.SuspendLayout()
        pg_about.SuspendLayout()
        preview_grp.SuspendLayout()
        pokemon1Shadow_grp.SuspendLayout()
        SuspendLayout()
        ' 
        ' editor_grp
        ' 
        editor_grp.Controls.Add(editor_tab)
        editor_grp.Location = New Point(12, 12)
        editor_grp.Name = "editor_grp"
        editor_grp.Size = New Size(757, 559)
        editor_grp.TabIndex = 0
        editor_grp.TabStop = False
        editor_grp.Text = "Editor"
        ' 
        ' editor_tab
        ' 
        editor_tab.Controls.Add(pg_trainer)
        editor_tab.Controls.Add(pg_pokemon)
        editor_tab.Controls.Add(pg_about)
        editor_tab.Dock = DockStyle.Fill
        editor_tab.Location = New Point(3, 19)
        editor_tab.Name = "editor_tab"
        editor_tab.SelectedIndex = 0
        editor_tab.Size = New Size(751, 537)
        editor_tab.TabIndex = 0
        ' 
        ' pg_trainer
        ' 
        pg_trainer.Controls.Add(trainer_tab)
        pg_trainer.Location = New Point(4, 24)
        pg_trainer.Name = "pg_trainer"
        pg_trainer.Padding = New Padding(3)
        pg_trainer.Size = New Size(743, 509)
        pg_trainer.TabIndex = 0
        pg_trainer.Text = "Trainer"
        pg_trainer.UseVisualStyleBackColor = True
        ' 
        ' trainer_tab
        ' 
        trainer_tab.Controls.Add(pg_basic)
        trainer_tab.Controls.Add(pg_items)
        trainer_tab.Dock = DockStyle.Fill
        trainer_tab.Location = New Point(3, 3)
        trainer_tab.Name = "trainer_tab"
        trainer_tab.SelectedIndex = 0
        trainer_tab.Size = New Size(737, 503)
        trainer_tab.TabIndex = 0
        ' 
        ' pg_basic
        ' 
        pg_basic.Controls.Add(essData_lbl)
        pg_basic.Controls.Add(allowSuperShiny_chk)
        pg_basic.Controls.Add(loseTextQuotes_chkBox)
        pg_basic.Controls.Add(useAbilityIndex_chkBox)
        pg_basic.Controls.Add(existingBattle_chkBox)
        pg_basic.Controls.Add(customBallIDs_chkBox)
        pg_basic.Controls.Add(essVersion_cmb)
        pg_basic.Controls.Add(essVersion_lbl)
        pg_basic.Controls.Add(battleTeamID_txtBox)
        pg_basic.Controls.Add(battleTeamID_lbl)
        pg_basic.Controls.Add(numPoké_lbl)
        pg_basic.Controls.Add(numPoké_cmb)
        pg_basic.Controls.Add(loseText_lbl)
        pg_basic.Controls.Add(loseText_txt)
        pg_basic.Controls.Add(trainerType_txtBox)
        pg_basic.Controls.Add(trainerType_lbl)
        pg_basic.Controls.Add(trainerName_txtBox)
        pg_basic.Controls.Add(trainerName_lbl)
        pg_basic.Controls.Add(trainerInfoHeader_lbl)
        pg_basic.Location = New Point(4, 24)
        pg_basic.Name = "pg_basic"
        pg_basic.Size = New Size(729, 475)
        pg_basic.TabIndex = 2
        pg_basic.Text = "Basic Info"
        pg_basic.UseVisualStyleBackColor = True
        ' 
        ' essData_lbl
        ' 
        essData_lbl.AutoSize = True
        essData_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        essData_lbl.Location = New Point(3, 132)
        essData_lbl.Name = "essData_lbl"
        essData_lbl.Size = New Size(184, 32)
        essData_lbl.TabIndex = 29
        essData_lbl.Text = "Essentials Data"
        ' 
        ' allowSuperShiny_chk
        ' 
        allowSuperShiny_chk.AutoSize = True
        allowSuperShiny_chk.Location = New Point(164, 249)
        allowSuperShiny_chk.Name = "allowSuperShiny_chk"
        allowSuperShiny_chk.Size = New Size(129, 34)
        allowSuperShiny_chk.TabIndex = 28
        allowSuperShiny_chk.Text = "Allow Super Shinies" & vbCrLf & "(Essentials 21)"
        allowSuperShiny_chk.UseVisualStyleBackColor = True
        ' 
        ' loseTextQuotes_chkBox
        ' 
        loseTextQuotes_chkBox.AutoSize = True
        loseTextQuotes_chkBox.Location = New Point(8, 249)
        loseTextQuotes_chkBox.Name = "loseTextQuotes_chkBox"
        loseTextQuotes_chkBox.Size = New Size(154, 34)
        loseTextQuotes_chkBox.TabIndex = 27
        loseTextQuotes_chkBox.Text = "Add Quotes to Lose Text" & vbCrLf & "(Essentials 19)"
        loseTextQuotes_chkBox.UseVisualStyleBackColor = True
        ' 
        ' useAbilityIndex_chkBox
        ' 
        useAbilityIndex_chkBox.AutoSize = True
        useAbilityIndex_chkBox.Enabled = False
        useAbilityIndex_chkBox.Location = New Point(493, 213)
        useAbilityIndex_chkBox.Name = "useAbilityIndex_chkBox"
        useAbilityIndex_chkBox.Size = New Size(203, 34)
        useAbilityIndex_chkBox.TabIndex = 26
        useAbilityIndex_chkBox.Text = "Use AbilityIndex instead of Ability" & vbCrLf & "(Essentials 19+)"
        useAbilityIndex_chkBox.UseVisualStyleBackColor = True
        ' 
        ' existingBattle_chkBox
        ' 
        existingBattle_chkBox.AutoSize = True
        existingBattle_chkBox.Location = New Point(8, 213)
        existingBattle_chkBox.Name = "existingBattle_chkBox"
        existingBattle_chkBox.Size = New Size(270, 34)
        existingBattle_chkBox.TabIndex = 24
        existingBattle_chkBox.Text = "Check this box if this NPC already has a team, " & vbCrLf & "then enter the Battle Team ID above."
        existingBattle_chkBox.UseVisualStyleBackColor = True
        ' 
        ' customBallIDs_chkBox
        ' 
        customBallIDs_chkBox.AutoSize = True
        customBallIDs_chkBox.Checked = True
        customBallIDs_chkBox.CheckState = CheckState.Checked
        customBallIDs_chkBox.Location = New Point(284, 213)
        customBallIDs_chkBox.Name = "customBallIDs_chkBox"
        customBallIDs_chkBox.Size = New Size(203, 19)
        customBallIDs_chkBox.TabIndex = 25
        customBallIDs_chkBox.Text = "Allow use of Custom Pokéball IDs"
        customBallIDs_chkBox.UseVisualStyleBackColor = True
        ' 
        ' essVersion_cmb
        ' 
        essVersion_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        essVersion_cmb.FormattingEnabled = True
        essVersion_cmb.Items.AddRange(New Object() {"Essentials 17", "Essentials 18", "Essentials 19", "Essentials 20", "Essentials 21"})
        essVersion_cmb.Location = New Point(8, 184)
        essVersion_cmb.Name = "essVersion_cmb"
        essVersion_cmb.Size = New Size(168, 23)
        essVersion_cmb.TabIndex = 23
        ' 
        ' essVersion_lbl
        ' 
        essVersion_lbl.AutoSize = True
        essVersion_lbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        essVersion_lbl.Location = New Point(8, 164)
        essVersion_lbl.Name = "essVersion_lbl"
        essVersion_lbl.Size = New Size(118, 17)
        essVersion_lbl.TabIndex = 22
        essVersion_lbl.Text = "Essentials Version"
        ' 
        ' battleTeamID_txtBox
        ' 
        battleTeamID_txtBox.Enabled = False
        battleTeamID_txtBox.Location = New Point(8, 92)
        battleTeamID_txtBox.MaxLength = 25
        battleTeamID_txtBox.Name = "battleTeamID_txtBox"
        battleTeamID_txtBox.PlaceholderText = "3"
        battleTeamID_txtBox.Size = New Size(168, 23)
        battleTeamID_txtBox.TabIndex = 19
        ' 
        ' battleTeamID_lbl
        ' 
        battleTeamID_lbl.AutoSize = True
        battleTeamID_lbl.Enabled = False
        battleTeamID_lbl.Location = New Point(8, 76)
        battleTeamID_lbl.Name = "battleTeamID_lbl"
        battleTeamID_lbl.Size = New Size(190, 15)
        battleTeamID_lbl.TabIndex = 20
        battleTeamID_lbl.Text = "Battle Team ID (Must be a number)"
        ' 
        ' numPoké_lbl
        ' 
        numPoké_lbl.AutoSize = True
        numPoké_lbl.Location = New Point(530, 34)
        numPoké_lbl.Name = "numPoké_lbl"
        numPoké_lbl.Size = New Size(119, 15)
        numPoké_lbl.TabIndex = 21
        numPoké_lbl.Text = "Number of Pokémon"
        ' 
        ' numPoké_cmb
        ' 
        numPoké_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        numPoké_cmb.FormattingEnabled = True
        numPoké_cmb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        numPoké_cmb.Location = New Point(530, 50)
        numPoké_cmb.Name = "numPoké_cmb"
        numPoké_cmb.Size = New Size(168, 23)
        numPoké_cmb.TabIndex = 18
        ' 
        ' loseText_lbl
        ' 
        loseText_lbl.AutoSize = True
        loseText_lbl.Location = New Point(356, 34)
        loseText_lbl.Name = "loseText_lbl"
        loseText_lbl.Size = New Size(55, 15)
        loseText_lbl.TabIndex = 17
        loseText_lbl.Text = "Lose Text"
        ' 
        ' loseText_txt
        ' 
        loseText_txt.Location = New Point(356, 50)
        loseText_txt.MaxLength = 255
        loseText_txt.Name = "loseText_txt"
        loseText_txt.PlaceholderText = "Oh dear, it seems I have lost..."
        loseText_txt.Size = New Size(168, 23)
        loseText_txt.TabIndex = 16
        ' 
        ' trainerType_txtBox
        ' 
        trainerType_txtBox.Location = New Point(182, 50)
        trainerType_txtBox.MaxLength = 25
        trainerType_txtBox.Name = "trainerType_txtBox"
        trainerType_txtBox.PlaceholderText = "RIVAL"
        trainerType_txtBox.Size = New Size(168, 23)
        trainerType_txtBox.TabIndex = 8
        ' 
        ' trainerType_lbl
        ' 
        trainerType_lbl.AutoSize = True
        trainerType_lbl.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        trainerType_lbl.Location = New Point(182, 34)
        trainerType_lbl.Name = "trainerType_lbl"
        trainerType_lbl.Size = New Size(175, 13)
        trainerType_lbl.TabIndex = 9
        trainerType_lbl.Text = "Trainer Type (See trainertypes.txt)"
        ' 
        ' trainerName_txtBox
        ' 
        trainerName_txtBox.Location = New Point(8, 50)
        trainerName_txtBox.Name = "trainerName_txtBox"
        trainerName_txtBox.PlaceholderText = "Rosa"
        trainerName_txtBox.Size = New Size(168, 23)
        trainerName_txtBox.TabIndex = 2
        ' 
        ' trainerName_lbl
        ' 
        trainerName_lbl.AutoSize = True
        trainerName_lbl.Location = New Point(8, 32)
        trainerName_lbl.Name = "trainerName_lbl"
        trainerName_lbl.Size = New Size(77, 15)
        trainerName_lbl.TabIndex = 1
        trainerName_lbl.Text = "Trainer Name"
        ' 
        ' trainerInfoHeader_lbl
        ' 
        trainerInfoHeader_lbl.AutoSize = True
        trainerInfoHeader_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        trainerInfoHeader_lbl.Location = New Point(3, 0)
        trainerInfoHeader_lbl.Name = "trainerInfoHeader_lbl"
        trainerInfoHeader_lbl.Size = New Size(239, 32)
        trainerInfoHeader_lbl.TabIndex = 0
        trainerInfoHeader_lbl.Text = "Trainer Information"
        ' 
        ' pg_items
        ' 
        pg_items.Location = New Point(4, 24)
        pg_items.Name = "pg_items"
        pg_items.Padding = New Padding(3)
        pg_items.Size = New Size(729, 475)
        pg_items.TabIndex = 1
        pg_items.Text = "Items"
        pg_items.UseVisualStyleBackColor = True
        ' 
        ' pg_pokemon
        ' 
        pg_pokemon.Controls.Add(TabControl3)
        pg_pokemon.Location = New Point(4, 24)
        pg_pokemon.Name = "pg_pokemon"
        pg_pokemon.Padding = New Padding(3)
        pg_pokemon.Size = New Size(743, 509)
        pg_pokemon.TabIndex = 1
        pg_pokemon.Text = "Pokémon"
        pg_pokemon.UseVisualStyleBackColor = True
        ' 
        ' TabControl3
        ' 
        TabControl3.Controls.Add(pg_pkmn1)
        TabControl3.Controls.Add(pg_pkmn2)
        TabControl3.Controls.Add(pg_pkmn3)
        TabControl3.Controls.Add(pg_pkmn4)
        TabControl3.Controls.Add(pg_pkmn5)
        TabControl3.Controls.Add(pg_pkmn6)
        TabControl3.Dock = DockStyle.Fill
        TabControl3.Location = New Point(3, 3)
        TabControl3.Multiline = True
        TabControl3.Name = "TabControl3"
        TabControl3.SelectedIndex = 0
        TabControl3.Size = New Size(737, 503)
        TabControl3.TabIndex = 0
        ' 
        ' pg_pkmn1
        ' 
        pg_pkmn1.Controls.Add(pokemon1_grp)
        pg_pkmn1.Location = New Point(4, 24)
        pg_pkmn1.Name = "pg_pkmn1"
        pg_pkmn1.Padding = New Padding(3)
        pg_pkmn1.Size = New Size(729, 475)
        pg_pkmn1.TabIndex = 2
        pg_pkmn1.Text = "Pokémon 1"
        pg_pkmn1.UseVisualStyleBackColor = True
        ' 
        ' pokemon1_grp
        ' 
        pokemon1_grp.Controls.Add(pokemon1Shadow_grp)
        pokemon1_grp.Controls.Add(pokemon1EVs_grp)
        pokemon1_grp.Controls.Add(pokemon1IVs_grp)
        pokemon1_grp.Controls.Add(pokemon1PokeballID_cmb)
        pokemon1_grp.Controls.Add(pokemon1Ball_lbl)
        pokemon1_grp.Controls.Add(pokemon1Nickname_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Nickname_lbl)
        pokemon1_grp.Controls.Add(pokemon1Happiness_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Happiness_lbl)
        pokemon1_grp.Controls.Add(pokemon1Nature_cmb)
        pokemon1_grp.Controls.Add(pokemon1Nature_lbl)
        pokemon1_grp.Controls.Add(pokemon1Shiny_grp)
        pokemon1_grp.Controls.Add(pokemon1Form_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Form_lbl)
        pokemon1_grp.Controls.Add(pokemon1Gender_cmb)
        pokemon1_grp.Controls.Add(pokemon1Gender_lbl)
        pokemon1_grp.Controls.Add(pokemon1Ability_cmb)
        pokemon1_grp.Controls.Add(pokemon1Ability_lbl)
        pokemon1_grp.Controls.Add(pokemon1Moves_grp)
        pokemon1_grp.Controls.Add(pokemon1Level_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Level_lbl)
        pokemon1_grp.Controls.Add(pokemon1HeldItem_lbl)
        pokemon1_grp.Controls.Add(pokemon1HeldItem_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Name_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Name_lbl)
        pokemon1_grp.Dock = DockStyle.Fill
        pokemon1_grp.Location = New Point(3, 3)
        pokemon1_grp.Name = "pokemon1_grp"
        pokemon1_grp.Size = New Size(723, 469)
        pokemon1_grp.TabIndex = 0
        pokemon1_grp.TabStop = False
        pokemon1_grp.Text = "Pokémon 1"
        ' 
        ' pokemon1EVs_grp
        ' 
        pokemon1EVs_grp.Controls.Add(pokemon1EVsDEF_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsDEF_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPDEF_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPDEF_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPATK_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPATK_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPD_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPD_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsATK_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsATK_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsHP_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsHP_lbl)
        pokemon1EVs_grp.Location = New Point(324, 154)
        pokemon1EVs_grp.Name = "pokemon1EVs_grp"
        pokemon1EVs_grp.Size = New Size(114, 156)
        pokemon1EVs_grp.TabIndex = 29
        pokemon1EVs_grp.TabStop = False
        pokemon1EVs_grp.Text = "EVs"
        ' 
        ' pokemon1EVsDEF_txt
        ' 
        pokemon1EVsDEF_txt.Location = New Point(6, 125)
        pokemon1EVsDEF_txt.MaxLength = 3
        pokemon1EVsDEF_txt.Name = "pokemon1EVsDEF_txt"
        pokemon1EVsDEF_txt.Size = New Size(44, 23)
        pokemon1EVsDEF_txt.TabIndex = 11
        pokemon1EVsDEF_txt.Text = "0"
        ' 
        ' pokemon1EVsDEF_lbl
        ' 
        pokemon1EVsDEF_lbl.AutoSize = True
        pokemon1EVsDEF_lbl.Location = New Point(14, 107)
        pokemon1EVsDEF_lbl.Name = "pokemon1EVsDEF_lbl"
        pokemon1EVsDEF_lbl.Size = New Size(27, 15)
        pokemon1EVsDEF_lbl.TabIndex = 10
        pokemon1EVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon1EVsSPDEF_txt
        ' 
        pokemon1EVsSPDEF_txt.Location = New Point(55, 125)
        pokemon1EVsSPDEF_txt.MaxLength = 3
        pokemon1EVsSPDEF_txt.Name = "pokemon1EVsSPDEF_txt"
        pokemon1EVsSPDEF_txt.Size = New Size(44, 23)
        pokemon1EVsSPDEF_txt.TabIndex = 9
        pokemon1EVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon1EVsSPDEF_lbl
        ' 
        pokemon1EVsSPDEF_lbl.AutoSize = True
        pokemon1EVsSPDEF_lbl.Location = New Point(55, 109)
        pokemon1EVsSPDEF_lbl.Name = "pokemon1EVsSPDEF_lbl"
        pokemon1EVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon1EVsSPDEF_lbl.TabIndex = 8
        pokemon1EVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon1EVsSPATK_txt
        ' 
        pokemon1EVsSPATK_txt.Location = New Point(55, 81)
        pokemon1EVsSPATK_txt.MaxLength = 3
        pokemon1EVsSPATK_txt.Name = "pokemon1EVsSPATK_txt"
        pokemon1EVsSPATK_txt.Size = New Size(44, 23)
        pokemon1EVsSPATK_txt.TabIndex = 7
        pokemon1EVsSPATK_txt.Text = "0"
        ' 
        ' pokemon1EVsSPATK_lbl
        ' 
        pokemon1EVsSPATK_lbl.AutoSize = True
        pokemon1EVsSPATK_lbl.Location = New Point(56, 65)
        pokemon1EVsSPATK_lbl.Name = "pokemon1EVsSPATK_lbl"
        pokemon1EVsSPATK_lbl.Size = New Size(39, 15)
        pokemon1EVsSPATK_lbl.TabIndex = 6
        pokemon1EVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon1EVsSPD_txt
        ' 
        pokemon1EVsSPD_txt.Location = New Point(55, 37)
        pokemon1EVsSPD_txt.MaxLength = 3
        pokemon1EVsSPD_txt.Name = "pokemon1EVsSPD_txt"
        pokemon1EVsSPD_txt.Size = New Size(44, 23)
        pokemon1EVsSPD_txt.TabIndex = 5
        pokemon1EVsSPD_txt.Text = "0"
        ' 
        ' pokemon1EVsSPD_lbl
        ' 
        pokemon1EVsSPD_lbl.AutoSize = True
        pokemon1EVsSPD_lbl.Location = New Point(63, 21)
        pokemon1EVsSPD_lbl.Name = "pokemon1EVsSPD_lbl"
        pokemon1EVsSPD_lbl.Size = New Size(28, 15)
        pokemon1EVsSPD_lbl.TabIndex = 4
        pokemon1EVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon1EVsATK_txt
        ' 
        pokemon1EVsATK_txt.Location = New Point(6, 81)
        pokemon1EVsATK_txt.MaxLength = 3
        pokemon1EVsATK_txt.Name = "pokemon1EVsATK_txt"
        pokemon1EVsATK_txt.Size = New Size(44, 23)
        pokemon1EVsATK_txt.TabIndex = 3
        pokemon1EVsATK_txt.Text = "0"
        ' 
        ' pokemon1EVsATK_lbl
        ' 
        pokemon1EVsATK_lbl.AutoSize = True
        pokemon1EVsATK_lbl.Location = New Point(14, 63)
        pokemon1EVsATK_lbl.Name = "pokemon1EVsATK_lbl"
        pokemon1EVsATK_lbl.Size = New Size(27, 15)
        pokemon1EVsATK_lbl.TabIndex = 2
        pokemon1EVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon1EVsHP_txt
        ' 
        pokemon1EVsHP_txt.Location = New Point(6, 37)
        pokemon1EVsHP_txt.MaxLength = 3
        pokemon1EVsHP_txt.Name = "pokemon1EVsHP_txt"
        pokemon1EVsHP_txt.Size = New Size(44, 23)
        pokemon1EVsHP_txt.TabIndex = 1
        pokemon1EVsHP_txt.Text = "0"
        ' 
        ' pokemon1EVsHP_lbl
        ' 
        pokemon1EVsHP_lbl.AutoSize = True
        pokemon1EVsHP_lbl.Location = New Point(16, 19)
        pokemon1EVsHP_lbl.Name = "pokemon1EVsHP_lbl"
        pokemon1EVsHP_lbl.Size = New Size(23, 15)
        pokemon1EVsHP_lbl.TabIndex = 0
        pokemon1EVsHP_lbl.Text = "HP"
        ' 
        ' pokemon1IVs_grp
        ' 
        pokemon1IVs_grp.Controls.Add(pokemon1RandomIVs_btn)
        pokemon1IVs_grp.Controls.Add(pokemon1MaxIVs_btn)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsDEF_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsDEF_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPDEF_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPDEF_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPATK_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPATK_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPD_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPD_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsATK_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsATK_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsHP_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsHP_lbl)
        pokemon1IVs_grp.Location = New Point(204, 154)
        pokemon1IVs_grp.Name = "pokemon1IVs_grp"
        pokemon1IVs_grp.Size = New Size(114, 188)
        pokemon1IVs_grp.TabIndex = 28
        pokemon1IVs_grp.TabStop = False
        pokemon1IVs_grp.Text = "IVs (Max 31 Each)"
        ' 
        ' pokemon1RandomIVs_btn
        ' 
        pokemon1RandomIVs_btn.Location = New Point(57, 152)
        pokemon1RandomIVs_btn.Name = "pokemon1RandomIVs_btn"
        pokemon1RandomIVs_btn.Size = New Size(44, 23)
        pokemon1RandomIVs_btn.TabIndex = 15
        pokemon1RandomIVs_btn.Text = "Rand"
        pokemon1RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon1MaxIVs_btn
        ' 
        pokemon1MaxIVs_btn.Location = New Point(7, 152)
        pokemon1MaxIVs_btn.Name = "pokemon1MaxIVs_btn"
        pokemon1MaxIVs_btn.Size = New Size(44, 23)
        pokemon1MaxIVs_btn.TabIndex = 14
        pokemon1MaxIVs_btn.Text = "Max"
        pokemon1MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon1IVsDEF_txt
        ' 
        pokemon1IVsDEF_txt.Location = New Point(7, 123)
        pokemon1IVsDEF_txt.MaxLength = 3
        pokemon1IVsDEF_txt.Name = "pokemon1IVsDEF_txt"
        pokemon1IVsDEF_txt.Size = New Size(44, 23)
        pokemon1IVsDEF_txt.TabIndex = 13
        pokemon1IVsDEF_txt.Text = "0"
        ' 
        ' pokemon1IVsDEF_lbl
        ' 
        pokemon1IVsDEF_lbl.AutoSize = True
        pokemon1IVsDEF_lbl.Location = New Point(18, 105)
        pokemon1IVsDEF_lbl.Name = "pokemon1IVsDEF_lbl"
        pokemon1IVsDEF_lbl.Size = New Size(27, 15)
        pokemon1IVsDEF_lbl.TabIndex = 12
        pokemon1IVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon1IVsSPDEF_txt
        ' 
        pokemon1IVsSPDEF_txt.Location = New Point(57, 123)
        pokemon1IVsSPDEF_txt.MaxLength = 3
        pokemon1IVsSPDEF_txt.Name = "pokemon1IVsSPDEF_txt"
        pokemon1IVsSPDEF_txt.Size = New Size(44, 23)
        pokemon1IVsSPDEF_txt.TabIndex = 9
        pokemon1IVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon1IVsSPDEF_lbl
        ' 
        pokemon1IVsSPDEF_lbl.AutoSize = True
        pokemon1IVsSPDEF_lbl.Location = New Point(59, 105)
        pokemon1IVsSPDEF_lbl.Name = "pokemon1IVsSPDEF_lbl"
        pokemon1IVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon1IVsSPDEF_lbl.TabIndex = 8
        pokemon1IVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon1IVsSPATK_txt
        ' 
        pokemon1IVsSPATK_txt.Location = New Point(57, 79)
        pokemon1IVsSPATK_txt.MaxLength = 3
        pokemon1IVsSPATK_txt.Name = "pokemon1IVsSPATK_txt"
        pokemon1IVsSPATK_txt.Size = New Size(44, 23)
        pokemon1IVsSPATK_txt.TabIndex = 7
        pokemon1IVsSPATK_txt.Text = "0"
        ' 
        ' pokemon1IVsSPATK_lbl
        ' 
        pokemon1IVsSPATK_lbl.AutoSize = True
        pokemon1IVsSPATK_lbl.Location = New Point(59, 61)
        pokemon1IVsSPATK_lbl.Name = "pokemon1IVsSPATK_lbl"
        pokemon1IVsSPATK_lbl.Size = New Size(39, 15)
        pokemon1IVsSPATK_lbl.TabIndex = 6
        pokemon1IVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon1IVsSPD_txt
        ' 
        pokemon1IVsSPD_txt.Location = New Point(57, 35)
        pokemon1IVsSPD_txt.MaxLength = 3
        pokemon1IVsSPD_txt.Name = "pokemon1IVsSPD_txt"
        pokemon1IVsSPD_txt.Size = New Size(44, 23)
        pokemon1IVsSPD_txt.TabIndex = 5
        pokemon1IVsSPD_txt.Text = "0"
        ' 
        ' pokemon1IVsSPD_lbl
        ' 
        pokemon1IVsSPD_lbl.AutoSize = True
        pokemon1IVsSPD_lbl.Location = New Point(65, 17)
        pokemon1IVsSPD_lbl.Name = "pokemon1IVsSPD_lbl"
        pokemon1IVsSPD_lbl.Size = New Size(28, 15)
        pokemon1IVsSPD_lbl.TabIndex = 4
        pokemon1IVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon1IVsATK_txt
        ' 
        pokemon1IVsATK_txt.Location = New Point(7, 79)
        pokemon1IVsATK_txt.MaxLength = 3
        pokemon1IVsATK_txt.Name = "pokemon1IVsATK_txt"
        pokemon1IVsATK_txt.Size = New Size(44, 23)
        pokemon1IVsATK_txt.TabIndex = 3
        pokemon1IVsATK_txt.Text = "0"
        ' 
        ' pokemon1IVsATK_lbl
        ' 
        pokemon1IVsATK_lbl.AutoSize = True
        pokemon1IVsATK_lbl.Location = New Point(18, 61)
        pokemon1IVsATK_lbl.Name = "pokemon1IVsATK_lbl"
        pokemon1IVsATK_lbl.Size = New Size(27, 15)
        pokemon1IVsATK_lbl.TabIndex = 2
        pokemon1IVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon1IVsHP_txt
        ' 
        pokemon1IVsHP_txt.Location = New Point(7, 35)
        pokemon1IVsHP_txt.MaxLength = 3
        pokemon1IVsHP_txt.Name = "pokemon1IVsHP_txt"
        pokemon1IVsHP_txt.Size = New Size(44, 23)
        pokemon1IVsHP_txt.TabIndex = 1
        pokemon1IVsHP_txt.Text = "0"
        ' 
        ' pokemon1IVsHP_lbl
        ' 
        pokemon1IVsHP_lbl.AutoSize = True
        pokemon1IVsHP_lbl.Location = New Point(18, 19)
        pokemon1IVsHP_lbl.Name = "pokemon1IVsHP_lbl"
        pokemon1IVsHP_lbl.Size = New Size(23, 15)
        pokemon1IVsHP_lbl.TabIndex = 0
        pokemon1IVsHP_lbl.Text = "HP"
        ' 
        ' pokemon1PokeballID_cmb
        ' 
        pokemon1PokeballID_cmb.FormattingEnabled = True
        pokemon1PokeballID_cmb.Items.AddRange(New Object() {"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL", "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL", "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
        pokemon1PokeballID_cmb.Location = New Point(6, 169)
        pokemon1PokeballID_cmb.Name = "pokemon1PokeballID_cmb"
        pokemon1PokeballID_cmb.Size = New Size(140, 23)
        pokemon1PokeballID_cmb.TabIndex = 21
        ' 
        ' pokemon1Ball_lbl
        ' 
        pokemon1Ball_lbl.AutoSize = True
        pokemon1Ball_lbl.Location = New Point(8, 151)
        pokemon1Ball_lbl.Name = "pokemon1Ball_lbl"
        pokemon1Ball_lbl.Size = New Size(52, 15)
        pokemon1Ball_lbl.TabIndex = 20
        pokemon1Ball_lbl.Text = "PokéBall"
        ' 
        ' pokemon1Nickname_txtBox
        ' 
        pokemon1Nickname_txtBox.Location = New Point(298, 125)
        pokemon1Nickname_txtBox.Name = "pokemon1Nickname_txtBox"
        pokemon1Nickname_txtBox.PlaceholderText = "Bloom"
        pokemon1Nickname_txtBox.Size = New Size(140, 23)
        pokemon1Nickname_txtBox.TabIndex = 19
        ' 
        ' pokemon1Nickname_lbl
        ' 
        pokemon1Nickname_lbl.AutoSize = True
        pokemon1Nickname_lbl.Location = New Point(298, 107)
        pokemon1Nickname_lbl.Name = "pokemon1Nickname_lbl"
        pokemon1Nickname_lbl.Size = New Size(61, 15)
        pokemon1Nickname_lbl.TabIndex = 18
        pokemon1Nickname_lbl.Text = "Nickname"
        ' 
        ' pokemon1Happiness_txtBox
        ' 
        pokemon1Happiness_txtBox.Location = New Point(152, 125)
        pokemon1Happiness_txtBox.Name = "pokemon1Happiness_txtBox"
        pokemon1Happiness_txtBox.PlaceholderText = "70"
        pokemon1Happiness_txtBox.Size = New Size(140, 23)
        pokemon1Happiness_txtBox.TabIndex = 17
        ' 
        ' pokemon1Happiness_lbl
        ' 
        pokemon1Happiness_lbl.AutoSize = True
        pokemon1Happiness_lbl.Location = New Point(152, 107)
        pokemon1Happiness_lbl.Name = "pokemon1Happiness_lbl"
        pokemon1Happiness_lbl.Size = New Size(62, 15)
        pokemon1Happiness_lbl.TabIndex = 16
        pokemon1Happiness_lbl.Text = "Happiness"
        ' 
        ' pokemon1Nature_cmb
        ' 
        pokemon1Nature_cmb.FormattingEnabled = True
        pokemon1Nature_cmb.Items.AddRange(New Object() {"(random)", "HARDY", "LONELY", "BRAVE", "ADAMANT", "NAUGHTY", "BOLD", "DOCILE", "RELAXED", "IMPISH", "LAX", "MODEST", "MILD", "SERIOUS", "QUIET", "RASH", "CALM", "GENTLE", "SASSY", "BASHFUL", "CAREFUL", "TIMID", "HASTY", "JOLLY", "NAIVE", "QUIRKY"})
        pokemon1Nature_cmb.Location = New Point(6, 125)
        pokemon1Nature_cmb.Name = "pokemon1Nature_cmb"
        pokemon1Nature_cmb.Size = New Size(140, 23)
        pokemon1Nature_cmb.TabIndex = 15
        ' 
        ' pokemon1Nature_lbl
        ' 
        pokemon1Nature_lbl.AutoSize = True
        pokemon1Nature_lbl.Location = New Point(6, 107)
        pokemon1Nature_lbl.Name = "pokemon1Nature_lbl"
        pokemon1Nature_lbl.Size = New Size(43, 15)
        pokemon1Nature_lbl.TabIndex = 14
        pokemon1Nature_lbl.Text = "Nature"
        ' 
        ' pokemon1Shiny_grp
        ' 
        pokemon1Shiny_grp.Controls.Add(pokemon1SuperShiny_chkBox)
        pokemon1Shiny_grp.Controls.Add(pokemon1Shiny_rad)
        pokemon1Shiny_grp.Controls.Add(pokemon1NotShiny_rad)
        pokemon1Shiny_grp.Location = New Point(444, 110)
        pokemon1Shiny_grp.Name = "pokemon1Shiny_grp"
        pokemon1Shiny_grp.Size = New Size(273, 82)
        pokemon1Shiny_grp.TabIndex = 13
        pokemon1Shiny_grp.TabStop = False
        pokemon1Shiny_grp.Text = "Shiny"
        ' 
        ' pokemon1SuperShiny_chkBox
        ' 
        pokemon1SuperShiny_chkBox.AutoSize = True
        pokemon1SuperShiny_chkBox.Enabled = False
        pokemon1SuperShiny_chkBox.Location = New Point(66, 47)
        pokemon1SuperShiny_chkBox.Name = "pokemon1SuperShiny_chkBox"
        pokemon1SuperShiny_chkBox.Size = New Size(88, 19)
        pokemon1SuperShiny_chkBox.TabIndex = 2
        pokemon1SuperShiny_chkBox.Text = "Super Shiny"
        pokemon1SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon1Shiny_rad
        ' 
        pokemon1Shiny_rad.AutoSize = True
        pokemon1Shiny_rad.Location = New Point(6, 47)
        pokemon1Shiny_rad.Name = "pokemon1Shiny_rad"
        pokemon1Shiny_rad.Size = New Size(54, 19)
        pokemon1Shiny_rad.TabIndex = 1
        pokemon1Shiny_rad.Text = "Shiny"
        pokemon1Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1NotShiny_rad
        ' 
        pokemon1NotShiny_rad.AutoSize = True
        pokemon1NotShiny_rad.Checked = True
        pokemon1NotShiny_rad.Location = New Point(6, 22)
        pokemon1NotShiny_rad.Name = "pokemon1NotShiny_rad"
        pokemon1NotShiny_rad.Size = New Size(77, 19)
        pokemon1NotShiny_rad.TabIndex = 0
        pokemon1NotShiny_rad.TabStop = True
        pokemon1NotShiny_rad.Text = "Not Shiny"
        pokemon1NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1Form_txtBox
        ' 
        pokemon1Form_txtBox.Location = New Point(298, 81)
        pokemon1Form_txtBox.Name = "pokemon1Form_txtBox"
        pokemon1Form_txtBox.PlaceholderText = "1"
        pokemon1Form_txtBox.Size = New Size(140, 23)
        pokemon1Form_txtBox.TabIndex = 12
        ' 
        ' pokemon1Form_lbl
        ' 
        pokemon1Form_lbl.AutoSize = True
        pokemon1Form_lbl.Location = New Point(298, 63)
        pokemon1Form_lbl.Name = "pokemon1Form_lbl"
        pokemon1Form_lbl.Size = New Size(123, 15)
        pokemon1Form_lbl.TabIndex = 11
        pokemon1Form_lbl.Text = "Form (Numbers Only)"
        ' 
        ' pokemon1Gender_cmb
        ' 
        pokemon1Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon1Gender_cmb.FormattingEnabled = True
        pokemon1Gender_cmb.Items.AddRange(New Object() {"Male", "Female", "Random"})
        pokemon1Gender_cmb.Location = New Point(152, 81)
        pokemon1Gender_cmb.Name = "pokemon1Gender_cmb"
        pokemon1Gender_cmb.Size = New Size(140, 23)
        pokemon1Gender_cmb.TabIndex = 10
        ' 
        ' pokemon1Gender_lbl
        ' 
        pokemon1Gender_lbl.AutoSize = True
        pokemon1Gender_lbl.Location = New Point(152, 63)
        pokemon1Gender_lbl.Name = "pokemon1Gender_lbl"
        pokemon1Gender_lbl.Size = New Size(45, 15)
        pokemon1Gender_lbl.TabIndex = 9
        pokemon1Gender_lbl.Text = "Gender"
        ' 
        ' pokemon1Ability_cmb
        ' 
        pokemon1Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon1Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon1Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon1Ability_cmb.FormattingEnabled = True
        pokemon1Ability_cmb.Items.AddRange(New Object() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon1Ability_cmb.Location = New Point(6, 81)
        pokemon1Ability_cmb.Name = "pokemon1Ability_cmb"
        pokemon1Ability_cmb.Size = New Size(140, 23)
        pokemon1Ability_cmb.TabIndex = 8
        ' 
        ' pokemon1Ability_lbl
        ' 
        pokemon1Ability_lbl.AutoSize = True
        pokemon1Ability_lbl.Location = New Point(6, 63)
        pokemon1Ability_lbl.Name = "pokemon1Ability_lbl"
        pokemon1Ability_lbl.Size = New Size(41, 15)
        pokemon1Ability_lbl.TabIndex = 7
        pokemon1Ability_lbl.Text = "Ability"
        ' 
        ' pokemon1Moves_grp
        ' 
        pokemon1Moves_grp.Controls.Add(pokemon1Move4_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move3_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move2_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move1_txtBox)
        pokemon1Moves_grp.Location = New Point(444, 22)
        pokemon1Moves_grp.Name = "pokemon1Moves_grp"
        pokemon1Moves_grp.Size = New Size(273, 82)
        pokemon1Moves_grp.TabIndex = 6
        pokemon1Moves_grp.TabStop = False
        pokemon1Moves_grp.Text = "Moves"
        ' 
        ' pokemon1Move4_txtBox
        ' 
        pokemon1Move4_txtBox.Location = New Point(132, 51)
        pokemon1Move4_txtBox.Name = "pokemon1Move4_txtBox"
        pokemon1Move4_txtBox.PlaceholderText = "Move 4"
        pokemon1Move4_txtBox.Size = New Size(120, 23)
        pokemon1Move4_txtBox.TabIndex = 3
        ' 
        ' pokemon1Move3_txtBox
        ' 
        pokemon1Move3_txtBox.Location = New Point(6, 51)
        pokemon1Move3_txtBox.Name = "pokemon1Move3_txtBox"
        pokemon1Move3_txtBox.PlaceholderText = "Move 3"
        pokemon1Move3_txtBox.Size = New Size(120, 23)
        pokemon1Move3_txtBox.TabIndex = 2
        ' 
        ' pokemon1Move2_txtBox
        ' 
        pokemon1Move2_txtBox.Location = New Point(132, 22)
        pokemon1Move2_txtBox.Name = "pokemon1Move2_txtBox"
        pokemon1Move2_txtBox.PlaceholderText = "Move 2"
        pokemon1Move2_txtBox.Size = New Size(120, 23)
        pokemon1Move2_txtBox.TabIndex = 1
        ' 
        ' pokemon1Move1_txtBox
        ' 
        pokemon1Move1_txtBox.Location = New Point(6, 22)
        pokemon1Move1_txtBox.Name = "pokemon1Move1_txtBox"
        pokemon1Move1_txtBox.PlaceholderText = "Move 1"
        pokemon1Move1_txtBox.Size = New Size(120, 23)
        pokemon1Move1_txtBox.TabIndex = 0
        ' 
        ' pokemon1Level_txtBox
        ' 
        pokemon1Level_txtBox.Location = New Point(298, 37)
        pokemon1Level_txtBox.MaxLength = 3
        pokemon1Level_txtBox.Name = "pokemon1Level_txtBox"
        pokemon1Level_txtBox.PlaceholderText = "100"
        pokemon1Level_txtBox.Size = New Size(140, 23)
        pokemon1Level_txtBox.TabIndex = 5
        ' 
        ' pokemon1Level_lbl
        ' 
        pokemon1Level_lbl.AutoSize = True
        pokemon1Level_lbl.Location = New Point(298, 19)
        pokemon1Level_lbl.Name = "pokemon1Level_lbl"
        pokemon1Level_lbl.Size = New Size(34, 15)
        pokemon1Level_lbl.TabIndex = 4
        pokemon1Level_lbl.Text = "Level"
        ' 
        ' pokemon1HeldItem_lbl
        ' 
        pokemon1HeldItem_lbl.AutoSize = True
        pokemon1HeldItem_lbl.Location = New Point(152, 19)
        pokemon1HeldItem_lbl.Name = "pokemon1HeldItem_lbl"
        pokemon1HeldItem_lbl.Size = New Size(59, 15)
        pokemon1HeldItem_lbl.TabIndex = 3
        pokemon1HeldItem_lbl.Text = "Held Item"
        ' 
        ' pokemon1HeldItem_txtBox
        ' 
        pokemon1HeldItem_txtBox.Location = New Point(152, 37)
        pokemon1HeldItem_txtBox.Name = "pokemon1HeldItem_txtBox"
        pokemon1HeldItem_txtBox.PlaceholderText = "FocusSash"
        pokemon1HeldItem_txtBox.Size = New Size(140, 23)
        pokemon1HeldItem_txtBox.TabIndex = 2
        ' 
        ' pokemon1Name_txtBox
        ' 
        pokemon1Name_txtBox.AutoCompleteCustomSource.AddRange(New String() {"BULBASAUR", "IVYSAUR", "VENUSAUR", "CHARMANDER", "CHARMELEON", "CHARIZARD", "SQUIRTLE", "WARTORTLE", "BLASTOISE", "CATERPIE", "METAPOD", "BUTTERFREE", "WEEDLE", "KAKUNA", "BEEDRILL", "PIDGEY", "PIDGEOTTO", "PIDGEOT", "RATTATA", "RATICATE", "SPEAROW", "FEAROW", "EKANS", "ARBOK", "PIKACHU", "RAICHU", "SANDSHREW", "SANDSLASH", "NIDORANfE", "NIDORINA", "NIDOQUEEN", "NIDORANmA", "NIDORINO", "NIDOKING", "CLEFAIRY", "CLEFABLE", "VULPIX", "NINETALES", "JIGGLYPUFF", "WIGGLYTUFF", "ZUBAT", "GOLBAT", "ODDISH", "GLOOM", "VILEPLUME", "PARAS", "PARASECT", "VENONAT", "VENOMOTH", "DIGLETT", "DUGTRIO", "MEOWTH", "PERSIAN", "PSYDUCK", "GOLDUCK", "MANKEY", "PRIMEAPE", "GROWLITHE", "ARCANINE", "POLIWAG", "POLIWHIRL", "POLIWRATH", "ABRA", "KADABRA", "ALAKAZAM", "MACHOP", "MACHOKE", "MACHAMP", "BELLSPROUT", "WEEPINBELL", "VICTREEBEL", "TENTACOOL", "TENTACRUEL", "GEODUDE", "GRAVELER", "GOLEM", "PONYTA", "RAPIDASH", "SLOWPOKE", "SLOWBRO", "MAGNEMITE", "MAGNETON", "FARFETCHD", "DODUO", "DODRIO", "SEEL", "DEWGONG", "GRIMER", "MUK", "SHELLDER", "CLOYSTER", "GASTLY", "HAUNTER", "GENGAR", "ONIX", "DROWZEE", "HYPNO", "KRABBY", "KINGLER", "VOLTORB", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", "CUBONE", "MAROWAK", "HITMONLEE", "HITMONCHAN", "LICKITUNG", "KOFFING", "WEEZING", "RHYHORN", "RHYDON", "CHANSEY", "TANGELA", "KANGASKHAN", "HORSEA", "SEADRA", "GOLDEEN", "SEAKING", "STARYU", "STARMIE", "MRMIME", "SCYTHER", "JYNX", "ELECTABUZZ", "MAGMAR", "PINSIR", "TAUROS", "MAGIKARP", "GYARADOS", "LAPRAS", "DITTO", "EEVEE", "VAPOREON", "JOLTEON", "FLAREON", "PORYGON", "OMANYTE", "OMASTAR", "KABUTO", "KABUTOPS", "AERODACTYL", "SNORLAX", "ARTICUNO", "ZAPDOS", "MOLTRES", "DRATINI", "DRAGONAIR", "DRAGONITE", "MEWTWO", "MEW", "CHIKORITA", "BAYLEEF", "MEGANIUM", "CYNDAQUIL", "QUILAVA", "TYPHLOSION", "TOTODILE", "CROCONAW", "FERALIGATR", "SENTRET", "FURRET", "HOOTHOOT", "NOCTOWL", "LEDYBA", "LEDIAN", "SPINARAK", "ARIADOS", "CROBAT", "CHINCHOU", "LANTURN", "PICHU", "CLEFFA", "IGGLYBUFF", "TOGEPI", "TOGETIC", "NATU", "XATU", "MAREEP", "FLAAFFY", "AMPHAROS", "BELLOSSOM", "MARILL", "AZUMARILL", "SUDOWOODO", "POLITOED", "HOPPIP", "SKIPLOOM", "JUMPLUFF", "AIPOM", "SUNKERN", "SUNFLORA", "YANMA", "WOOPER", "QUAGSIRE", "ESPEON", "UMBREON", "MURKROW", "SLOWKING", "MISDREAVUS", "UNOWN", "WOBBUFFET", "GIRAFARIG", "PINECO", "FORRETRESS", "DUNSPARCE", "GLIGAR", "STEELIX", "SNUBBULL", "GRANBULL", "QWILFISH", "SCIZOR", "SHUCKLE", "HERACROSS", "SNEASEL", "TEDDIURSA", "URSARING", "SLUGMA", "MAGCARGO", "SWINUB", "PILOSWINE", "CORSOLA", "REMORAID", "OCTILLERY", "DELIBIRD", "MANTINE", "SKARMORY", "HOUNDOUR", "HOUNDOOM", "KINGDRA", "PHANPY", "DONPHAN", "PORYGON2", "STANTLER", "SMEARGLE", "TYROGUE", "HITMONTOP", "SMOOCHUM", "ELEKID", "MAGBY", "MILTANK", "BLISSEY", "RAIKOU", "ENTEI", "SUICUNE", "LARVITAR", "PUPITAR", "TYRANITAR", "LUGIA", "HO-OH", "CELEBI", "TREECKO", "GROVYLE", "SCEPTILE", "TORCHIC", "COMBUSKEN", "BLAZIKEN", "MUDKIP", "MARSHTOMP", "SWAMPERT", "POOCHYENA", "MIGHTYENA", "ZIGZAGOON", "LINOONE", "WURMPLE", "SILCOON", "BEAUTIFLY", "CASCOON", "DUSTOX", "LOTAD", "LOMBRE", "LUDICOLO", "SEEDOT", "NUZLEAF", "SHIFTRY", "TAILLOW", "SWELLOW", "WINGULL", "PELIPPER", "RALTS", "KIRLIA", "GARDEVOIR", "SURSKIT", "MASQUERAIN", "SHROOMISH", "BRELOOM", "SLAKOTH", "VIGOROTH", "SLAKING", "NINCADA", "NINJASK", "SHEDINJA", "WHISMUR", "LOUDRED", "EXPLOUD", "MAKUHITA", "HARIYAMA", "AZURILL", "NOSEPASS", "SKITTY", "DELCATTY", "SABLEYE", "MAWILE", "ARON", "LAIRON", "AGGRON", "MEDITITE", "MEDICHAM", "ELECTRIKE", "MANECTRIC", "PLUSLE", "MINUN", "VOLBEAT", "ILLUMISE", "ROSELIA", "GULPIN", "SWALOT", "CARVANHA", "SHARPEDO", "WAILMER", "WAILORD", "NUMEL", "CAMERUPT", "TORKOAL", "SPOINK", "GRUMPIG", "SPINDA", "TRAPINCH", "VIBRAVA", "FLYGON", "CACNEA", "CACTURNE", "SWABLU", "ALTARIA", "ZANGOOSE", "SEVIPER", "LUNATONE", "SOLROCK", "BARBOACH", "WHISCASH", "CORPHISH", "CRAWDAUNT", "BALTOY", "CLAYDOL", "LILEEP", "CRADILY", "ANORITH", "ARMALDO", "FEEBAS", "MILOTIC", "CASTFORM", "KECLEON", "SHUPPET", "BANETTE", "DUSKULL", "DUSCLOPS", "TROPIUS", "CHIMECHO", "ABSOL", "WYNAUT", "SNORUNT", "GLALIE", "SPHEAL", "SEALEO", "WALREIN", "CLAMPERL", "HUNTAIL", "GOREBYSS", "RELICANTH", "LUVDISC", "BAGON", "SHELGON", "SALAMENCE", "BELDUM", "METANG", "METAGROSS", "REGIROCK", "REGICE", "REGISTEEL", "LATIAS", "LATIOS", "KYOGRE", "GROUDON", "RAYQUAZA", "JIRACHI", "DEOXYS", "TURTWIG", "GROTLE", "TORTERRA", "CHIMCHAR", "MONFERNO", "INFERNAPE", "PIPLUP", "PRINPLUP", "EMPOLEON", "STARLY", "STARAVIA", "STARAPTOR", "BIDOOF", "BIBAREL", "KRICKETOT", "KRICKETUNE", "SHINX", "LUXIO", "LUXRAY", "BUDEW", "ROSERADE", "CRANIDOS", "RAMPARDOS", "SHIELDON", "BASTIODON", "BURMY", "WORMADAM", "MOTHIM", "COMBEE", "VESPIQUEN", "PACHIRISU", "BUIZEL", "FLOATZEL", "CHERUBI", "CHERRIM", "SHELLOS", "GASTRODON", "AMBIPOM", "DRIFLOON", "DRIFBLIM", "BUNEARY", "LOPUNNY", "MISMAGIUS", "HONCHKROW", "GLAMEOW", "PURUGLY", "CHINGLING", "STUNKY", "SKUNTANK", "BRONZOR", "BRONZONG", "BONSLY", "MIMEJR", "HAPPINY", "CHATOT", "SPIRITOMB", "GIBLE", "GABITE", "GARCHOMP", "MUNCHLAX", "RIOLU", "LUCARIO", "HIPPOPOTAS", "HIPPOWDON", "SKORUPI", "DRAPION", "CROAGUNK", "TOXICROAK", "CARNIVINE", "FINNEON", "LUMINEON", "MANTYKE", "SNOVER", "ABOMASNOW", "WEAVILE", "MAGNEZONE", "LICKILICKY", "RHYPERIOR", "TANGROWTH", "ELECTIVIRE", "MAGMORTAR", "TOGEKISS", "YANMEGA", "LEAFEON", "GLACEON", "GLISCOR", "MAMOSWINE", "PORYGON-Z", "GALLADE", "PROBOPASS", "DUSKNOIR", "FROSLASS", "ROTOM", "UXIE", "MESPRIT", "AZELF", "DIALGA", "PALKIA", "HEATRAN", "REGIGIGAS", "GIRATINA", "CRESSELIA", "PHIONE", "MANAPHY", "DARKRAI", "SHAYMIN", "ARCEUS", "VICTINI", "SNIVY", "SERVINE", "SERPERIOR", "TEPIG", "PIGNITE", "EMBOAR", "OSHAWOTT", "DEWOTT", "SAMUROTT", "PATRAT", "WATCHOG", "LILLIPUP", "HERDIER", "STOUTLAND", "PURRLOIN", "LIEPARD", "PANSAGE", "SIMISAGE", "PANSEAR", "SIMISEAR", "PANPOUR", "SIMIPOUR", "MUNNA", "MUSHARNA", "PIDOVE", "TRANQUILL", "UNFEZANT", "BLITZLE", "ZEBSTRIKA", "ROGGENROLA", "BOLDORE", "GIGALITH", "WOOBAT", "SWOOBAT", "DRILBUR", "EXCADRILL", "AUDINO", "TIMBURR", "GURDURR", "CONKELDURR", "TYMPOLE", "PALPITOAD", "SEISMITOAD", "THROH", "SAWK", "SEWADDLE", "SWADLOON", "LEAVANNY", "VENIPEDE", "WHIRLIPEDE", "SCOLIPEDE", "COTTONEE", "WHIMSICOTT", "PETILIL", "LILLIGANT", "BASCULIN", "SANDILE", "KROKOROK", "KROOKODILE", "DARUMAKA", "DARMANITAN", "MARACTUS", "DWEBBLE", "CRUSTLE", "SCRAGGY", "SCRAFTY", "SIGILYPH", "YAMASK", "COFAGRIGUS", "TIRTOUGA", "CARRACOSTA", "ARCHEN", "ARCHEOPS", "TRUBBISH", "GARBODOR", "ZORUA", "ZOROARK", "MINCCINO", "CINCCINO", "GOTHITA", "GOTHORITA", "GOTHITELLE", "SOLOSIS", "DUOSION", "REUNICLUS", "DUCKLETT", "SWANNA", "VANILLITE", "VANILLISH", "VANILLUXE", "DEERLING", "SAWSBUCK", "EMOLGA", "KARRABLAST", "ESCAVALIER", "FOONGUS", "AMOONGUSS", "FRILLISH", "JELLICENT", "ALOMOMOLA", "JOLTIK", "GALVANTULA", "FERROSEED", "FERROTHORN", "KLINK", "KLANG", "KLINKLANG", "TYNAMO", "EELEKTRIK", "EELEKTROSS", "ELGYEM", "BEHEEYEM", "LITWICK", "LAMPENT", "CHANDELURE", "AXEW", "FRAXURE", "HAXORUS", "CUBCHOO", "BEARTIC", "CRYOGONAL", "SHELMET", "ACCELGOR", "STUNFISK", "MIENFOO", "MIENSHAO", "DRUDDIGON", "GOLETT", "GOLURK", "PAWNIARD", "BISHARP", "BOUFFALANT", "RUFFLET", "BRAVIARY", "VULLABY", "MANDIBUZZ", "HEATMOR", "DURANT", "DEINO", "ZWEILOUS", "HYDREIGON", "LARVESTA", "VOLCARONA", "COBALION", "TERRAKION", "VIRIZION", "TORNADUS", "THUNDURUS", "RESHIRAM", "ZEKROM", "LANDORUS", "KYUREM", "KELDEO", "MELOETTA", "GENESECT", "CHESPIN", "QUILLADIN", "CHESNAUGHT", "FENNEKIN", "BRAIXEN", "DELPHOX", "FROAKIE", "FROGADIER", "GRENINJA", "BUNNELBY", "DIGGERSBY", "FLETCHLING", "FLETCHINDER", "TALONFLAME", "SCATTERBUG", "SPEWPA", "VIVILLON", "LITLEO", "PYROAR", "FLABEBE", "FLOETTE", "FLORGES", "SKIDDO", "GOGOAT", "PANCHAM", "PANGORO", "FURFROU", "ESPURR", "MEOWSTIC", "HONEDGE", "DOUBLADE", "AEGISLASH", "SPRITZEE", "AROMATISSE", "SWIRLIX", "SLURPUFF", "INKAY", "MALAMAR", "BINACLE", "BARBARACLE", "SKRELP", "DRAGALGE", "CLAUNCHER", "CLAWITZER", "HELIOPTILE", "HELIOLISK", "TYRUNT", "TYRANTRUM", "AMAURA", "AURORUS", "SYLVEON", "HAWLUCHA", "DEDENNE", "CARBINK", "GOOMY", "SLIGGOO", "GOODRA", "KLEFKI", "PHANTUMP", "TREVENANT", "PUMPKABOO", "GOURGEIST", "BERGMITE", "AVALUGG", "NOIBAT", "NOIVERN", "XERNEAS", "YVELTAL", "ZYGARDE", "DIANCIE", "HOOPA", "VOLCANION", "ROWLET", "DARTRIX", "DECIDUEYE", "LITTEN", "TORRACAT", "INCINEROAR", "POPPLIO", "BRIONNE", "PRIMARINA", "PIKIPEK", "TRUMBEAK", "TOUCANNON", "YUNGOOS", "GUMSHOOS", "GRUBBIN", "CHARJABUG", "VIKAVOLT", "CRABRAWLER", "CRABOMINABLE", "ORICORIO", "CUTIEFLY", "RIBOMBEE", "ROCKRUFF", "LYCANROC", "WISHIWASHI", "MAREANIE", "TOXAPEX", "MUDBRAY", "MUDSDALE", "DEWPIDER", "ARAQUANID", "FOMANTIS", "LURANTIS", "MORELULL", "SHIINOTIC", "SALANDIT", "SALAZZLE", "STUFFUL", "BEWEAR", "BOUNSWEET", "STEENEE", "TSAREENA", "COMFEY", "ORANGURU", "PASSIMIAN", "WIMPOD", "GOLISOPOD", "SANDYGAST", "PALOSSAND", "PYUKUMUKU", "TYPENULL", "SILVALLY", "MINIOR", "KOMALA", "TURTONATOR", "TOGEDEMARU", "MIMIKYU", "BRUXISH", "DRAMPA", "DHELMISE", "JANGMO-O", "HAKAMO-O", "KOMMO-O", "TAPUKOKO", "TAPULELE", "TAPUBULU", "TAPUFINI", "COSMOG", "COSMOEM", "SOLGALEO", "LUNALA", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "NECROZMA", "MAGEARNA", "MARSHADOW", "POIPOLE", "NAGANADEL", "STAKATAKA", "BLACEPHALON", "ZERAORA", "MELTAN", "MELMETAL", "GROOKEY", "THWACKEY", "RILLABOOM", "SCORBUNNY", "RABOOT", "CINDERACE", "SOBBLE", "DRIZZILE", "INTELEON", "SKWOVET", "GREEDENT", "ROOKIDEE", "CORVISQUIRE", "CORVIKNIGHT", "BLIPBUG", "DOTTLER", "ORBEETLE", "NICKIT", "THIEVUL", "GOSSIFLEUR", "ELDEGOSS", "WOOLOO", "DUBWOOL", "CHEWTLE", "DREDNAW", "YAMPER", "BOLTUND", "ROLYCOLY", "CARKOL", "COALOSSAL", "APPLIN", "FLAPPLE", "APPLETUN", "SILICOBRA", "SANDACONDA", "CRAMORANT", "ARROKUDA", "BARRASKEWDA", "TOXEL", "TOXTRICITY", "SIZZLIPEDE", "CENTISKORCH", "CLOBBOPUS", "GRAPPLOCT", "SINISTEA", "POLTEAGEIST", "HATENNA", "HATTREM", "HATTERENE", "IMPIDIMP", "MORGREM", "GRIMMSNARL", "OBSTAGOON", "PERRSERKER", "CURSOLA", "SIRFETCHD", "MRRIME", "RUNERIGUS", "MILCERY", "ALCREMIE", "FALINKS", "PINCURCHIN", "SNOM", "FROSMOTH", "STONJOURNER", "EISCUE", "INDEEDEE", "MORPEKO", "CUFANT", "COPPERAJAH", "DRACOZOLT", "ARCTOZOLT", "DRACOVISH", "ARCTOVISH", "DURALUDON", "DREEPY", "DRAKLOAK", "DRAGAPULT", "ZACIAN", "ZAMAZENTA", "ETERNATUS", "KUBFU", "URSHIFU", "ZARUDE", "REGIELEKI", "REGIDRAGO", "GLASTRIER", "SPECTRIER", "CALYREX"})
        pokemon1Name_txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon1Name_txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon1Name_txtBox.Location = New Point(6, 37)
        pokemon1Name_txtBox.Name = "pokemon1Name_txtBox"
        pokemon1Name_txtBox.PlaceholderText = "Bulbasaur"
        pokemon1Name_txtBox.Size = New Size(140, 23)
        pokemon1Name_txtBox.TabIndex = 1
        ' 
        ' pokemon1Name_lbl
        ' 
        pokemon1Name_lbl.AutoSize = True
        pokemon1Name_lbl.Location = New Point(6, 19)
        pokemon1Name_lbl.Name = "pokemon1Name_lbl"
        pokemon1Name_lbl.Size = New Size(93, 15)
        pokemon1Name_lbl.TabIndex = 0
        pokemon1Name_lbl.Text = "Pokémon Name"
        ' 
        ' pg_pkmn2
        ' 
        pg_pkmn2.Controls.Add(pokemon2_grp)
        pg_pkmn2.Location = New Point(4, 24)
        pg_pkmn2.Name = "pg_pkmn2"
        pg_pkmn2.Padding = New Padding(3)
        pg_pkmn2.Size = New Size(729, 475)
        pg_pkmn2.TabIndex = 3
        pg_pkmn2.Text = "Pokémon 2"
        pg_pkmn2.UseVisualStyleBackColor = True
        ' 
        ' pokemon2_grp
        ' 
        pokemon2_grp.Dock = DockStyle.Fill
        pokemon2_grp.Location = New Point(3, 3)
        pokemon2_grp.Name = "pokemon2_grp"
        pokemon2_grp.Size = New Size(723, 469)
        pokemon2_grp.TabIndex = 0
        pokemon2_grp.TabStop = False
        pokemon2_grp.Text = "Pokémon 2"
        ' 
        ' pg_pkmn3
        ' 
        pg_pkmn3.Controls.Add(pokemon3_grp)
        pg_pkmn3.Location = New Point(4, 24)
        pg_pkmn3.Name = "pg_pkmn3"
        pg_pkmn3.Padding = New Padding(3)
        pg_pkmn3.Size = New Size(729, 475)
        pg_pkmn3.TabIndex = 4
        pg_pkmn3.Text = "Pokémon 3"
        pg_pkmn3.UseVisualStyleBackColor = True
        ' 
        ' pokemon3_grp
        ' 
        pokemon3_grp.Dock = DockStyle.Fill
        pokemon3_grp.Location = New Point(3, 3)
        pokemon3_grp.Name = "pokemon3_grp"
        pokemon3_grp.Size = New Size(723, 469)
        pokemon3_grp.TabIndex = 0
        pokemon3_grp.TabStop = False
        pokemon3_grp.Text = "Pokémon 3"
        ' 
        ' pg_pkmn4
        ' 
        pg_pkmn4.Controls.Add(pokemon4_grp)
        pg_pkmn4.Location = New Point(4, 24)
        pg_pkmn4.Name = "pg_pkmn4"
        pg_pkmn4.Padding = New Padding(3)
        pg_pkmn4.Size = New Size(729, 475)
        pg_pkmn4.TabIndex = 5
        pg_pkmn4.Text = "Pokémon 4"
        pg_pkmn4.UseVisualStyleBackColor = True
        ' 
        ' pokemon4_grp
        ' 
        pokemon4_grp.Dock = DockStyle.Fill
        pokemon4_grp.Location = New Point(3, 3)
        pokemon4_grp.Name = "pokemon4_grp"
        pokemon4_grp.Size = New Size(723, 469)
        pokemon4_grp.TabIndex = 0
        pokemon4_grp.TabStop = False
        pokemon4_grp.Text = "Pokémon 4"
        ' 
        ' pg_pkmn5
        ' 
        pg_pkmn5.Controls.Add(pokemon5_grp)
        pg_pkmn5.Location = New Point(4, 24)
        pg_pkmn5.Name = "pg_pkmn5"
        pg_pkmn5.Padding = New Padding(3)
        pg_pkmn5.Size = New Size(729, 475)
        pg_pkmn5.TabIndex = 0
        pg_pkmn5.Text = "Pokémon 5"
        pg_pkmn5.UseVisualStyleBackColor = True
        ' 
        ' pokemon5_grp
        ' 
        pokemon5_grp.Dock = DockStyle.Fill
        pokemon5_grp.Location = New Point(3, 3)
        pokemon5_grp.Name = "pokemon5_grp"
        pokemon5_grp.Size = New Size(723, 469)
        pokemon5_grp.TabIndex = 0
        pokemon5_grp.TabStop = False
        pokemon5_grp.Text = "Pokémon 5"
        ' 
        ' pg_pkmn6
        ' 
        pg_pkmn6.Controls.Add(pokemon6_grp)
        pg_pkmn6.Location = New Point(4, 24)
        pg_pkmn6.Name = "pg_pkmn6"
        pg_pkmn6.Padding = New Padding(3)
        pg_pkmn6.Size = New Size(729, 475)
        pg_pkmn6.TabIndex = 1
        pg_pkmn6.Text = "Pokémon 6"
        pg_pkmn6.UseVisualStyleBackColor = True
        ' 
        ' pokemon6_grp
        ' 
        pokemon6_grp.Dock = DockStyle.Fill
        pokemon6_grp.Location = New Point(3, 3)
        pokemon6_grp.Name = "pokemon6_grp"
        pokemon6_grp.Size = New Size(723, 469)
        pokemon6_grp.TabIndex = 0
        pokemon6_grp.TabStop = False
        pokemon6_grp.Text = "Pokémon 6"
        ' 
        ' pg_about
        ' 
        pg_about.Controls.Add(aboutInfo_lbl)
        pg_about.Controls.Add(copyright_lbl)
        pg_about.Controls.Add(aboutHeaderAuthor_lbl)
        pg_about.Controls.Add(aboutHeader_lbl)
        pg_about.Location = New Point(4, 24)
        pg_about.Name = "pg_about"
        pg_about.Size = New Size(743, 509)
        pg_about.TabIndex = 2
        pg_about.Text = "About"
        pg_about.UseVisualStyleBackColor = True
        ' 
        ' aboutInfo_lbl
        ' 
        aboutInfo_lbl.Location = New Point(3, 62)
        aboutInfo_lbl.Name = "aboutInfo_lbl"
        aboutInfo_lbl.Size = New Size(737, 115)
        aboutInfo_lbl.TabIndex = 3
        aboutInfo_lbl.Text = resources.GetString("aboutInfo_lbl.Text")
        ' 
        ' copyright_lbl
        ' 
        copyright_lbl.AutoSize = True
        copyright_lbl.Location = New Point(3, 494)
        copyright_lbl.Name = "copyright_lbl"
        copyright_lbl.Size = New Size(60, 15)
        copyright_lbl.TabIndex = 2
        copyright_lbl.Text = "Copyright"
        ' 
        ' aboutHeaderAuthor_lbl
        ' 
        aboutHeaderAuthor_lbl.AutoSize = True
        aboutHeaderAuthor_lbl.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        aboutHeaderAuthor_lbl.Location = New Point(3, 32)
        aboutHeaderAuthor_lbl.Name = "aboutHeaderAuthor_lbl"
        aboutHeaderAuthor_lbl.Size = New Size(180, 30)
        aboutHeaderAuthor_lbl.TabIndex = 1
        aboutHeaderAuthor_lbl.Text = "By TheCrafters001"
        ' 
        ' aboutHeader_lbl
        ' 
        aboutHeader_lbl.AutoSize = True
        aboutHeader_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        aboutHeader_lbl.Location = New Point(3, 0)
        aboutHeader_lbl.Name = "aboutHeader_lbl"
        aboutHeader_lbl.Size = New Size(280, 32)
        aboutHeader_lbl.TabIndex = 0
        aboutHeader_lbl.Text = "Essentials Team Builder"
        ' 
        ' preview_grp
        ' 
        preview_grp.Controls.Add(preview_rtb)
        preview_grp.Location = New Point(775, 12)
        preview_grp.Name = "preview_grp"
        preview_grp.Size = New Size(461, 559)
        preview_grp.TabIndex = 1
        preview_grp.TabStop = False
        preview_grp.Text = "Preview"
        ' 
        ' preview_rtb
        ' 
        preview_rtb.Dock = DockStyle.Fill
        preview_rtb.Location = New Point(3, 19)
        preview_rtb.Name = "preview_rtb"
        preview_rtb.ReadOnly = True
        preview_rtb.Size = New Size(455, 537)
        preview_rtb.TabIndex = 0
        preview_rtb.Text = ""
        ' 
        ' updatePreview_btn
        ' 
        updatePreview_btn.Location = New Point(1045, 2)
        updatePreview_btn.Name = "updatePreview_btn"
        updatePreview_btn.Size = New Size(191, 23)
        updatePreview_btn.TabIndex = 2
        updatePreview_btn.Text = "Update Preview/Generate Team"
        updatePreview_btn.UseVisualStyleBackColor = True
        ' 
        ' properSpellingNote_lbl
        ' 
        properSpellingNote_lbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        properSpellingNote_lbl.AutoSize = True
        properSpellingNote_lbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        properSpellingNote_lbl.ForeColor = Color.Red
        properSpellingNote_lbl.Location = New Point(12, 567)
        properSpellingNote_lbl.Name = "properSpellingNote_lbl"
        properSpellingNote_lbl.Size = New Size(192, 15)
        properSpellingNote_lbl.TabIndex = 24
        properSpellingNote_lbl.Text = "Note: Proper spelling IS required."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(210, 567)
        Label2.Name = "Label2"
        Label2.Size = New Size(772, 15)
        Label2.TabIndex = 25
        Label2.Text = "Moves and Items MUST be one word. (ie: Fire Blast = FireBlast). Leave IVs and EVs 0 if you don't want to set them, or don't know how to use them."
        ' 
        ' pokemon1Shadow_grp
        ' 
        pokemon1Shadow_grp.Controls.Add(pokemon1Shadow_rad)
        pokemon1Shadow_grp.Controls.Add(pokemon1NotShadow_rad)
        pokemon1Shadow_grp.Location = New Point(444, 198)
        pokemon1Shadow_grp.Name = "pokemon1Shadow_grp"
        pokemon1Shadow_grp.Size = New Size(273, 82)
        pokemon1Shadow_grp.TabIndex = 30
        pokemon1Shadow_grp.TabStop = False
        pokemon1Shadow_grp.Text = "Shadow"
        ' 
        ' pokemon1Shadow_rad
        ' 
        pokemon1Shadow_rad.AutoSize = True
        pokemon1Shadow_rad.Location = New Point(6, 47)
        pokemon1Shadow_rad.Name = "pokemon1Shadow_rad"
        pokemon1Shadow_rad.Size = New Size(67, 19)
        pokemon1Shadow_rad.TabIndex = 1
        pokemon1Shadow_rad.Text = "Shadow"
        pokemon1Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1NotShadow_rad
        ' 
        pokemon1NotShadow_rad.AutoSize = True
        pokemon1NotShadow_rad.Checked = True
        pokemon1NotShadow_rad.Location = New Point(6, 22)
        pokemon1NotShadow_rad.Name = "pokemon1NotShadow_rad"
        pokemon1NotShadow_rad.Size = New Size(90, 19)
        pokemon1NotShadow_rad.TabIndex = 0
        pokemon1NotShadow_rad.TabStop = True
        pokemon1NotShadow_rad.Text = "Not Shadow"
        pokemon1NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1248, 583)
        Controls.Add(Label2)
        Controls.Add(properSpellingNote_lbl)
        Controls.Add(updatePreview_btn)
        Controls.Add(preview_grp)
        Controls.Add(editor_grp)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Essentials Team Editor"
        editor_grp.ResumeLayout(False)
        editor_tab.ResumeLayout(False)
        pg_trainer.ResumeLayout(False)
        trainer_tab.ResumeLayout(False)
        pg_basic.ResumeLayout(False)
        pg_basic.PerformLayout()
        pg_pokemon.ResumeLayout(False)
        TabControl3.ResumeLayout(False)
        pg_pkmn1.ResumeLayout(False)
        pokemon1_grp.ResumeLayout(False)
        pokemon1_grp.PerformLayout()
        pokemon1EVs_grp.ResumeLayout(False)
        pokemon1EVs_grp.PerformLayout()
        pokemon1IVs_grp.ResumeLayout(False)
        pokemon1IVs_grp.PerformLayout()
        pokemon1Shiny_grp.ResumeLayout(False)
        pokemon1Shiny_grp.PerformLayout()
        pokemon1Moves_grp.ResumeLayout(False)
        pokemon1Moves_grp.PerformLayout()
        pg_pkmn2.ResumeLayout(False)
        pg_pkmn3.ResumeLayout(False)
        pg_pkmn4.ResumeLayout(False)
        pg_pkmn5.ResumeLayout(False)
        pg_pkmn6.ResumeLayout(False)
        pg_about.ResumeLayout(False)
        pg_about.PerformLayout()
        preview_grp.ResumeLayout(False)
        pokemon1Shadow_grp.ResumeLayout(False)
        pokemon1Shadow_grp.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents editor_grp As GroupBox
    Friend WithEvents editor_tab As TabControl
    Friend WithEvents pg_trainer As TabPage
    Friend WithEvents trainer_tab As TabControl
    Friend WithEvents pg_items As TabPage
    Friend WithEvents pg_pokemon As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents pg_pkmn5 As TabPage
    Friend WithEvents pg_pkmn6 As TabPage
    Friend WithEvents preview_grp As GroupBox
    Friend WithEvents pg_basic As TabPage
    Friend WithEvents pg_pkmn1 As TabPage
    Friend WithEvents pg_pkmn2 As TabPage
    Friend WithEvents pg_pkmn3 As TabPage
    Friend WithEvents pg_pkmn4 As TabPage
    Friend WithEvents preview_rtb As RichTextBox
    Friend WithEvents trainerInfoHeader_lbl As Label
    Friend WithEvents updatePreview_btn As Button
    Friend WithEvents trainerName_lbl As Label
    Friend WithEvents trainerName_txtBox As TextBox
    Friend WithEvents trainerType_txtBox As TextBox
    Friend WithEvents trainerType_lbl As Label
    Friend WithEvents loseText_lbl As Label
    Friend WithEvents loseText_txt As TextBox
    Friend WithEvents battleTeamID_txtBox As TextBox
    Friend WithEvents battleTeamID_lbl As Label
    Friend WithEvents numPoké_lbl As Label
    Friend WithEvents numPoké_cmb As ComboBox
    Friend WithEvents essVersion_cmb As ComboBox
    Friend WithEvents essVersion_lbl As Label
    Friend WithEvents properSpellingNote_lbl As Label
    Friend WithEvents essData_lbl As Label
    Friend WithEvents allowSuperShiny_chk As CheckBox
    Friend WithEvents loseTextQuotes_chkBox As CheckBox
    Friend WithEvents useAbilityIndex_chkBox As CheckBox
    Friend WithEvents existingBattle_chkBox As CheckBox
    Friend WithEvents customBallIDs_chkBox As CheckBox
    Friend WithEvents pokemon2_grp As GroupBox
    Friend WithEvents pokemon3_grp As GroupBox
    Friend WithEvents pokemon4_grp As GroupBox
    Friend WithEvents pokemon5_grp As GroupBox
    Friend WithEvents pokemon1_grp As GroupBox
    Friend WithEvents pokemon6_grp As GroupBox
    Friend WithEvents pokemon1Name_lbl As Label
    Friend WithEvents pokemon1Name_txtBox As TextBox
    Friend WithEvents pokemon1HeldItem_lbl As Label
    Friend WithEvents pokemon1HeldItem_txtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pokemon1Level_txtBox As TextBox
    Friend WithEvents pokemon1Level_lbl As Label
    Friend WithEvents pokemon1Moves_grp As GroupBox
    Friend WithEvents pokemon1Move4_txtBox As TextBox
    Friend WithEvents pokemon1Move3_txtBox As TextBox
    Friend WithEvents pokemon1Move2_txtBox As TextBox
    Friend WithEvents pokemon1Move1_txtBox As TextBox
    Friend WithEvents pokemon1Ability_cmb As ComboBox
    Friend WithEvents pokemon1Ability_lbl As Label
    Friend WithEvents pokemon1Gender_cmb As ComboBox
    Friend WithEvents pokemon1Gender_lbl As Label
    Friend WithEvents pokemon1Form_txtBox As TextBox
    Friend WithEvents pokemon1Form_lbl As Label
    Friend WithEvents pokemon1Shiny_grp As GroupBox
    Friend WithEvents pokemon1SuperShiny_chkBox As CheckBox
    Friend WithEvents pokemon1Shiny_rad As RadioButton
    Friend WithEvents pokemon1NotShiny_rad As RadioButton
    Friend WithEvents pokemon1Nature_lbl As Label
    Friend WithEvents pokemon1Nature_cmb As ComboBox
    Friend WithEvents pokemon1Happiness_txtBox As TextBox
    Friend WithEvents pokemon1Happiness_lbl As Label
    Friend WithEvents pokemon1Nickname_txtBox As TextBox
    Friend WithEvents pokemon1Nickname_lbl As Label
    Friend WithEvents pokemon1Ball_lbl As Label
    Friend WithEvents pokemon1PokeballID_cmb As ComboBox
    Friend WithEvents pokemon1IVs_grp As GroupBox
    Friend WithEvents pokemon1RandomIVs_btn As Button
    Friend WithEvents pokemon1MaxIVs_btn As Button
    Friend WithEvents pokemon1IVsDEF_txt As TextBox
    Friend WithEvents pokemon1IVsDEF_lbl As Label
    Friend WithEvents pokemon1IVsSPDEF_txt As TextBox
    Friend WithEvents pokemon1IVsSPDEF_lbl As Label
    Friend WithEvents pokemon1IVsSPATK_txt As TextBox
    Friend WithEvents pokemon1IVsSPATK_lbl As Label
    Friend WithEvents pokemon1IVsSPD_txt As TextBox
    Friend WithEvents pokemon1IVsSPD_lbl As Label
    Friend WithEvents pokemon1IVsATK_txt As TextBox
    Friend WithEvents pokemon1IVsATK_lbl As Label
    Friend WithEvents pokemon1IVsHP_txt As TextBox
    Friend WithEvents pokemon1IVsHP_lbl As Label
    Friend WithEvents pokemon1EVs_grp As GroupBox
    Friend WithEvents pokemon1EVsDEF_txt As TextBox
    Friend WithEvents pokemon1EVsDEF_lbl As Label
    Friend WithEvents pokemon1EVsSPDEF_txt As TextBox
    Friend WithEvents pokemon1EVsSPDEF_lbl As Label
    Friend WithEvents pokemon1EVsSPATK_txt As TextBox
    Friend WithEvents pokemon1EVsSPATK_lbl As Label
    Friend WithEvents pokemon1EVsSPD_txt As TextBox
    Friend WithEvents pokemon1EVsSPD_lbl As Label
    Friend WithEvents pokemon1EVsATK_txt As TextBox
    Friend WithEvents pokemon1EVsATK_lbl As Label
    Friend WithEvents pokemon1EVsHP_txt As TextBox
    Friend WithEvents pokemon1EVsHP_lbl As Label
    Friend WithEvents pg_about As TabPage
    Friend WithEvents aboutHeader_lbl As Label
    Friend WithEvents copyright_lbl As Label
    Friend WithEvents aboutHeaderAuthor_lbl As Label
    Friend WithEvents aboutInfo_lbl As Label
    Friend WithEvents pokemon1Shadow_grp As GroupBox
    Friend WithEvents pokemon1Shadow_rad As RadioButton
    Friend WithEvents pokemon1NotShadow_rad As RadioButton
End Class
