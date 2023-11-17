Public Class Generator

    ''' <summary>
    ''' Used for generating the Pokemon. This generates in the format of Essentials 18, or higher.
    ''' </summary>
    ''' <param name="pkmnName">Get the name of the Pokemon</param>
    ''' <param name="heldItem">Get the Held Item of the Pokemon</param>
    ''' <param name="lvl">Get the Level of the Pokemon</param>
    ''' <param name="ability">Get the Ability of the Pokemon</param>
    ''' <param name="pkmnGender">Get the gender of the Pokemon</param>
    ''' <param name="form">Get the form of the Pokemon. Pass only an integer.</param>
    ''' <param name="nature">Get the nature of the Pokemon.</param>
    ''' <param name="happiness">Get the Happiness of the Pokemon. Pass only an integer.</param>
    ''' <param name="nickname">Get the nickname of the Pokemon</param>
    ''' <param name="pokeBall">Get the PokeBall of the Pokemon</param>
    ''' <param name="shiny">Get the Shiny of the Pokemon. Pass only a Boolean.</param>
    ''' <param name="superShiny">Get the Super Shiny of the Pokemon. Pass only a Boolean.</param>
    ''' <param name="shadow">Get the shadow of the Pokemon. Pass only a Boolean.</param>
    ''' 
    ''' <param name="ivHP">Get the HP IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivATK">Get the ATK IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivDEF">Get the DEF IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPD">Get the SPD IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPATK">Get the SPATK IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPDEF">Get the SPDEF IV for the Pokemon. Pass only an integer.</param>
    ''' 
    ''' <param name="evHP">Get the HP EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evATK">Get the ATK EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evDEF">Get the DEF EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPD">Get the SPD EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPATK">Get the SPATK EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPDEF">Get the SPDEF EV for the Pokemon. Pass only an integer.</param>
    ''' <returns>A formatted string that should be added to the output.</returns>
    Public Shared Function essentials18(ByVal pkmnName As String, ByVal heldItem As String, ByVal lvl As Integer,
                                   ByVal ability As String, ByVal pkmnGender As String, ByVal form As String,
                                   ByVal nature As String, ByVal happiness As Integer, ByVal nickname As String,
                                   ByVal pokeBall As String, ByVal shiny As Boolean, ByVal superShiny As Boolean,
                                   ByVal shadow As Boolean,
                                   ByVal ivHP As Integer, ByVal ivATK As Integer, ByVal ivDEF As Integer,
                                   ByVal ivSPD As Integer, ByVal ivSPATK As Integer, ByVal ivSPDEF As Integer,
                                   ByVal evHP As Integer, ByVal evATK As Integer, ByVal evDEF As Integer,
                                   ByVal evSPD As Integer, ByVal evSPATK As Integer, ByVal evSPDEF As Integer)
        Dim output As String = ""

        Try

            ' Used for indenting stuff.
            ' Honestly makes soring easier for me.
            Dim Indent As String = "    "

            ' Pokemon = POKEMON,lvl
            Dim pkmn As String = "Pokemon = " & pkmnName.ToUpper & "," & lvl & vbCrLf

            ' Form = form
            Dim pkmnForm As String = ""
            If Not form = 0 Or Not form = "" Then
                pkmnForm = Indent & "Form = " & form & vbCrLf
            End If

            ' Name = nickname
            Dim name As String = ""
            If Not nickname = "" Then
                name = Indent & "Name = " & nickname & vbCrLf
            End If

            ' Item = heldItem
            Dim item As String = ""
            If Not heldItem = "" Then
                item = Indent & "Item = " & heldItem.ToUpper & vbCrLf
            End If

            ' Gender = pkmnGender
            Dim gender As String = ""
            If pkmnGender = "Random" Then
                gender = ""
            Else
                gender = Indent & "Gender = " & pkmnGender & vbCrLf
            End If

            output = pkmn & pkmnForm & name & gender & item
        Catch ex As Exception
            Console.WriteLine("There was an error when generating the team. Please make sure there are only numbers in the Level, Happiness, Form, IVs and EVs boxes." & vbCrLf & ex.Message)
        End Try

        Return output
    End Function


    ''' <summary>
    ''' Used for generating the Pokemon. This generates in the format of Essentials 17, or higher.
    ''' </summary>
    ''' <param name="pkmnName">Get the name of the Pokemon</param>
    ''' <param name="heldItem">Get the Held Item of the Pokemon</param>
    ''' <param name="lvl">Get the Level of the Pokemon</param>
    ''' <param name="ability">Get the Ability of the Pokemon</param>
    ''' <param name="pkmnGender">Get the gender of the Pokemon</param>
    ''' <param name="form">Get the form of the Pokemon. Pass only an integer.</param>
    ''' <param name="nature">Get the nature of the Pokemon.</param>
    ''' <param name="happiness">Get the Happiness of the Pokemon. Pass only an integer.</param>
    ''' <param name="nickname">Get the nickname of the Pokemon</param>
    ''' <param name="pokeBall">Get the PokeBall of the Pokemon</param>
    ''' <param name="shiny">Get the Shiny of the Pokemon. Pass only a Boolean.</param>
    ''' <param name="shadow">Get the shadow of the Pokemon. Pass only a Boolean.</param>
    ''' 
    ''' <param name="ivHP">Get the HP IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivATK">Get the ATK IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivDEF">Get the DEF IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPD">Get the SPD IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPATK">Get the SPATK IV for the Pokemon. Pass only an integer.</param>
    ''' <param name="ivSPDEF">Get the SPDEF IV for the Pokemon. Pass only an integer.</param>
    ''' 
    ''' <param name="evHP">Get the HP EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evATK">Get the ATK EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evDEF">Get the DEF EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPD">Get the SPD EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPATK">Get the SPATK EV for the Pokemon. Pass only an integer.</param>
    ''' <param name="evSPDEF">Get the SPDEF EV for the Pokemon. Pass only an integer.</param>
    ''' <returns>A formatted string that should be added to the output.</returns>
    Public Shared Function essentials17(ByVal pkmnName As String, ByVal heldItem As String, ByVal lvl As Integer,
                                   ByVal ability As String, ByVal pkmnGender As String, ByVal form As String,
                                   ByVal nature As String, ByVal happiness As Integer, ByVal nickname As String,
                                   ByVal pokeBall As String, ByVal shiny As Boolean, ByVal shadow As Boolean,
                                   ByVal ivHP As Integer, ByVal ivATK As Integer, ByVal ivDEF As Integer,
                                   ByVal ivSPD As Integer, ByVal ivSPATK As Integer, ByVal ivSPDEF As Integer,
                                   ByVal evHP As Integer, ByVal evATK As Integer, ByVal evDEF As Integer,
                                   ByVal evSPD As Integer, ByVal evSPATK As Integer, ByVal evSPDEF As Integer)

    End Function


    Public Shared Function trainer18(ByVal trainerName As String, ByVal trainerType As String, ByVal loseText As String,
                                     ByVal loseTextQuotes As Boolean, Optional ByVal battleTeamID As Integer = 0)

    End Function

    Public Shared Function trainer17()

    End Function

End Class
