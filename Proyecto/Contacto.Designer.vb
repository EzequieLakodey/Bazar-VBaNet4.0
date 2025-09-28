<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contacto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuItemVolver = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelCc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelEmail1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Wheat
        Me.Panel1.Controls.Add(Me.MenuStrip)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.LabelCc)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LabelEmail1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Javanese Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 571)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuStrip.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Font = New System.Drawing.Font("Liberation Mono", 20.25!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemVolver, Me.MenuItemSalir})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Margin = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.Size = New System.Drawing.Size(147, 571)
        Me.MenuStrip.TabIndex = 10
        Me.MenuStrip.Text = "Menu"
        '
        'MenuItemVolver
        '
        Me.MenuItemVolver.Font = New System.Drawing.Font("Liberation Mono", 36.0!, System.Drawing.FontStyle.Bold)
        Me.MenuItemVolver.ForeColor = System.Drawing.Color.Black
        Me.MenuItemVolver.Margin = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.MenuItemVolver.Name = "MenuItemVolver"
        Me.MenuItemVolver.Padding = New System.Windows.Forms.Padding(25, 50, 25, 0)
        Me.MenuItemVolver.Size = New System.Drawing.Size(146, 108)
        Me.MenuItemVolver.Text = "🡐"
        '
        'MenuItemSalir
        '
        Me.MenuItemSalir.Font = New System.Drawing.Font("Liberation Mono", 20.25!, System.Drawing.FontStyle.Bold)
        Me.MenuItemSalir.ForeColor = System.Drawing.Color.Black
        Me.MenuItemSalir.Margin = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.MenuItemSalir.Name = "MenuItemSalir"
        Me.MenuItemSalir.Padding = New System.Windows.Forms.Padding(25, 50, 25, 0)
        Me.MenuItemSalir.Size = New System.Drawing.Size(146, 84)
        Me.MenuItemSalir.Text = "Salir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 47)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "+54 9550 0800"
        '
        'LabelCc
        '
        Me.LabelCc.AutoSize = True
        Me.LabelCc.Font = New System.Drawing.Font("Leelawadee UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCc.Location = New System.Drawing.Point(214, 536)
        Me.LabelCc.Name = "LabelCc"
        Me.LabelCc.Size = New System.Drawing.Size(568, 26)
        Me.LabelCc.TabIndex = 8
        Me.LabelCc.Text = resources.GetString("LabelCc.Text")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(340, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(217, 47)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "bazar@team.com.ar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(348, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 47)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Atencion al cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(364, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 47)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "+54 0800 9550"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(312, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 47)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "bazar@commercial.com.ar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 47)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Comercial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Equipo de Desarrollo"
        '
        'LabelEmail1
        '
        Me.LabelEmail1.AutoSize = True
        Me.LabelEmail1.Font = New System.Drawing.Font("Javanese Text", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail1.Location = New System.Drawing.Point(308, 412)
        Me.LabelEmail1.Name = "LabelEmail1"
        Me.LabelEmail1.Size = New System.Drawing.Size(309, 47)
        Me.LabelEmail1.TabIndex = 0
        Me.LabelEmail1.Text = "ezequiel.lakodey@gmail.com"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(794, 571)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 192
        Me.LineShape2.X2 = 714
        Me.LineShape2.Y1 = 351
        Me.LineShape2.Y2 = 351
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 195
        Me.LineShape1.X2 = 717
        Me.LineShape1.Y1 = 191
        Me.LineShape1.Y2 = 191
        '
        'Contacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Contacto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelEmail1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LabelCc As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuItemVolver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
