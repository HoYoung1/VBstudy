<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk빨강 = New System.Windows.Forms.CheckBox()
        Me.chk주황 = New System.Windows.Forms.CheckBox()
        Me.chk노랑 = New System.Windows.Forms.CheckBox()
        Me.chk초록 = New System.Windows.Forms.CheckBox()
        Me.chk파랑 = New System.Windows.Forms.CheckBox()
        Me.chk보라 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lab선택목록 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "좋아하는 색을 선택하세요"
        '
        'chk빨강
        '
        Me.chk빨강.AutoSize = True
        Me.chk빨강.Location = New System.Drawing.Point(130, 158)
        Me.chk빨강.Name = "chk빨강"
        Me.chk빨강.Size = New System.Drawing.Size(48, 16)
        Me.chk빨강.TabIndex = 1
        Me.chk빨강.Text = "빨강"
        Me.chk빨강.UseVisualStyleBackColor = True
        '
        'chk주황
        '
        Me.chk주황.AutoSize = True
        Me.chk주황.Location = New System.Drawing.Point(240, 158)
        Me.chk주황.Name = "chk주황"
        Me.chk주황.Size = New System.Drawing.Size(48, 16)
        Me.chk주황.TabIndex = 2
        Me.chk주황.Text = "주황"
        Me.chk주황.UseVisualStyleBackColor = True
        '
        'chk노랑
        '
        Me.chk노랑.AutoSize = True
        Me.chk노랑.Location = New System.Drawing.Point(359, 158)
        Me.chk노랑.Name = "chk노랑"
        Me.chk노랑.Size = New System.Drawing.Size(48, 16)
        Me.chk노랑.TabIndex = 3
        Me.chk노랑.Text = "노랑"
        Me.chk노랑.UseVisualStyleBackColor = True
        '
        'chk초록
        '
        Me.chk초록.AutoSize = True
        Me.chk초록.Location = New System.Drawing.Point(130, 216)
        Me.chk초록.Name = "chk초록"
        Me.chk초록.Size = New System.Drawing.Size(48, 16)
        Me.chk초록.TabIndex = 4
        Me.chk초록.Text = "초록"
        Me.chk초록.UseVisualStyleBackColor = True
        '
        'chk파랑
        '
        Me.chk파랑.AutoSize = True
        Me.chk파랑.Location = New System.Drawing.Point(240, 216)
        Me.chk파랑.Name = "chk파랑"
        Me.chk파랑.Size = New System.Drawing.Size(48, 16)
        Me.chk파랑.TabIndex = 5
        Me.chk파랑.Text = "파랑"
        Me.chk파랑.UseVisualStyleBackColor = True
        '
        'chk보라
        '
        Me.chk보라.AutoSize = True
        Me.chk보라.Location = New System.Drawing.Point(359, 216)
        Me.chk보라.Name = "chk보라"
        Me.chk보라.Size = New System.Drawing.Size(48, 16)
        Me.chk보라.TabIndex = 6
        Me.chk보라.Text = "보라"
        Me.chk보라.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "선택완료"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lab선택목록
        '
        Me.lab선택목록.AutoSize = True
        Me.lab선택목록.Location = New System.Drawing.Point(128, 287)
        Me.lab선택목록.Name = "lab선택목록"
        Me.lab선택목록.Size = New System.Drawing.Size(0, 12)
        Me.lab선택목록.TabIndex = 8
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lab선택목록)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chk보라)
        Me.Controls.Add(Me.chk파랑)
        Me.Controls.Add(Me.chk초록)
        Me.Controls.Add(Me.chk노랑)
        Me.Controls.Add(Me.chk주황)
        Me.Controls.Add(Me.chk빨강)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chk빨강 As CheckBox
    Friend WithEvents chk주황 As CheckBox
    Friend WithEvents chk노랑 As CheckBox
    Friend WithEvents chk초록 As CheckBox
    Friend WithEvents chk파랑 As CheckBox
    Friend WithEvents chk보라 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lab선택목록 As Label
End Class
