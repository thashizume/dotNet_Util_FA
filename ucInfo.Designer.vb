﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pg1 = New System.Windows.Forms.PropertyGrid()
        Me.SuspendLayout()
        '
        'pg1
        '
        Me.pg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pg1.Location = New System.Drawing.Point(0, 0)
        Me.pg1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pg1.Name = "pg1"
        Me.pg1.Size = New System.Drawing.Size(302, 396)
        Me.pg1.TabIndex = 0
        '
        'ucInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pg1)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ucInfo"
        Me.Size = New System.Drawing.Size(302, 396)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pg1 As System.Windows.Forms.PropertyGrid

End Class
