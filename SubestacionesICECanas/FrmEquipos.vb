Imports System.Data.OleDb
Imports System.Configuration

Public Class FrmEquipos

    Dim Equipo As New EquiposEntidad


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        LimpiarControles()
        Dim resultado As Boolean = Insertar()
        If resultado Then
            MsgBox("registro almacenado")
        Else
            MsgBox("registro no almacenado")
        End If
    End Sub

    Private Function Insertar() As Boolean
        convertirControles()
        Dim sql As String = "INSERT INTO TB_Equipos (Marca" & _
                                       ",Tipo" & _
                                       ",NuICE_Marca" & _
                                       ",Modelo" & _
                                       ",Control" & _
                                       ",NuICE_Cont" & _
                                       ",SCADA" & _
                                       ",Remota" & _
                                       ",NuICE_Rem" & _
                                       ",Localizacion" & _
                                       ",Ubicacion)" & _
                               "VALUES (@Marca, " & _
                                       "@Tipo, " & _
                                       "@NuICE_Marca, " & _
                                       "@Modelo, " & _
                                       "@Control, " & _
                                       "@NuICE_Cont, " & _
                                       "@SCADA, " & _
                                       "@Remota, " & _
                                       "@NuICE_Rem, " & _
                                       "@Localizacion, " & _
                                       "@Ubicacion)"

        Using conn As New OleDbConnection(ConfigurationManager.ConnectionStrings("connIce").ToString())

            'Dim NextId As Integer = MaxId() + 1

            Dim command As New OleDbCommand(sql, conn)

            'command.Parameters.AddWithValue("Id_Distritos", NextId)
            command.Parameters.AddWithValue("Marca", Equipo.Marca)
            command.Parameters.AddWithValue("Tipo", Equipo.Tipo)
            command.Parameters.AddWithValue("NuICE_Marca", Equipo.NuICE_Marca)
            command.Parameters.AddWithValue("Modelo", Equipo.Modelo)
            command.Parameters.AddWithValue("Control", Equipo.Control)
            command.Parameters.AddWithValue("NuICE_Cont", Equipo.NuICE_Cont)
            command.Parameters.AddWithValue("SCADA", Equipo.SCADA)
            command.Parameters.AddWithValue("Remota", Equipo.Remota)
            command.Parameters.AddWithValue("NuICE_Rem", Equipo.NuICE_Rem)
            command.Parameters.AddWithValue("Localizacion", Equipo.Localizacion)
            command.Parameters.AddWithValue("Ubicacion", Equipo.Ubicacion)

            conn.Open()

            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                LimpiarControles()
                Return True
            Else
                Return False

            End If

        End Using
    End Function

    Public Sub convertirControles()

        Equipo.Control = Me.TxtControl.Text
        Equipo.NuICE_Cont = Me.TxtICEControl.Text
        Equipo.NuICE_Marca = Me.TxtICEMarca.Text
        Equipo.NuICE_Rem = Me.TxtICERemota.Text
        Equipo.Localizacion = Me.TxtLocalizacion.Text
        Equipo.Marca = Me.TxtMarca.Text
        Equipo.Modelo = Me.TxtModelo.Text
        Equipo.Remota = Me.TxtRemota.Text
        Equipo.Tipo = Me.TxtTipo.Text
        Equipo.Ubicacion = Me.TxtUbicacion.Text
        Equipo.SCADA = chkSCADA.Checked

    End Sub

    Private Sub LimpiarControles()

        Me.TxtControl.Text = ""
        Me.TxtICEControl.Text = ""
        Me.TxtICEMarca.Text = ""
        Me.TxtICERemota.Text = ""
        Me.TxtLocalizacion.Text = ""
        Me.TxtMarca.Text = ""
        Me.TxtModelo.Text = ""
        Me.TxtRemota.Text = ""
        Me.TxtTipo.Text = ""
        Me.TxtUbicacion.Text = ""

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

    End Sub
End Class