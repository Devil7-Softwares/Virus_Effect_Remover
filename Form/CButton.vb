'******************************************************************'
'          This code is made By Avinash Sachan                     '
'                avinashsachan@gmail.com                           '
'                     Last Edited :                                '
'                  Date : 06/01/2010                               '
'                                '
'******************************************************************'
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Namespace C_Button
    'internal class resfinder
    ' {
    ' }

    '<ToolboxBitmap(typeof(resfinder) is "cloudbutton.png")> _
    <DefaultEvent("Click")>
    Public Class CButton
        Inherits UserControl

#Region "Constructor"

        Public Sub New()
            Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
            Me.SetStyle(ControlStyles.UserPaint, True)
            Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

            Me.BackColor = Color.Transparent
            Me.ForeColor = Color.FromArgb(69, 105, 152)

            InitializeComponent()

            ButtonText = "VER BUTTON"
            m_iconSpacingX = 5
            m_iconSpacingY = 5

            m_textSpacingX = 5
            m_textSpacingY = 5

            '#Region "MouseDown colors"
            mouseDownColors = New Color(6) {}
            mouseDownColors(0) = Color.FromArgb(208, 193, 135)
            mouseDownColors(1) = Color.FromArgb(217, 208, 171)
            mouseDownColors(2) = Color.FromArgb(234, 220, 167)
            mouseDownColors(3) = Color.FromArgb(247, 239, 205)
            mouseDownColors(4) = Color.FromArgb(247, 215, 112)
            mouseDownColors(5) = Color.FromArgb(247, 200, 49)
            mouseDownColors(6) = Color.FromArgb(247, 221, 132)
            '#End Region

            '#Region "MouseOn colors"
            mouseOnColors = New Color(6) {}
            mouseOnColors(0) = Color.FromArgb(191, 168, 113)
            mouseOnColors(1) = Color.FromArgb(208, 185, 129)
            mouseOnColors(2) = Color.FromArgb(243, 231, 182)
            mouseOnColors(3) = Color.FromArgb(255, 248, 217)
            mouseOnColors(4) = Color.FromArgb(255, 226, 133)
            mouseOnColors(5) = Color.FromArgb(255, 213, 77)
            mouseOnColors(6) = Color.FromArgb(255, 232, 151)
            '#End Region

            '#Region "Normal colors"
            normalColors = New Color(6) {}
            normalColors(0) = Color.FromArgb(161, 189, 207)
            normalColors(1) = Color.FromArgb(202, 214, 212)
            normalColors(2) = Color.FromArgb(188, 208, 221)
            normalColors(3) = Color.FromArgb(246, 249, 253)
            normalColors(4) = Color.FromArgb(229, 238, 249)
            normalColors(5) = Color.FromArgb(210, 225, 244)
            normalColors(6) = Color.FromArgb(233, 242, 253)
            '#End Region

            '#Region "Disabled colors"
            m_disabledColors = New Color(6) {}
            m_disabledColors(0) = Color.FromArgb(212, 212, 212)
            m_disabledColors(1) = Color.FromArgb(239, 239, 239)
            m_disabledColors(2) = Color.FromArgb(224, 224, 224)
            m_disabledColors(3) = Color.FromArgb(251, 251, 251)
            m_disabledColors(4) = Color.FromArgb(244, 244, 244)
            m_disabledColors(5) = Color.FromArgb(235, 235, 235)
            '#End Region
            m_disabledColors(6) = Color.FromArgb(236, 236, 236)
        End Sub

#End Region

#Region "Default button colors"

        Private borderLineColor As Color = Color.FromArgb(161, 189, 207)
        Private borderPointColor As Color = Color.FromArgb(202, 214, 212)
        Private borderPoint2Color As Color = Color.FromArgb(188, 208, 221)
        Private upperGradientColor1 As Color = Color.FromArgb(246, 249, 253)
        Private upperGradientColor2 As Color = Color.FromArgb(229, 238, 249)
        Private lowerGradientColor1 As Color = Color.FromArgb(210, 225, 244)
        Private lowerGradientColor2 As Color = Color.FromArgb(233, 242, 253)

#End Region

#Region "Tools"

        Private borderPen As Pen
        Private gradientBrush As Brush

#End Region

#Region "Drawing the button"

        Protected Overloads Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            ' Sometimes when button is disabled in design-time, it doesn't work
            ' so let's put this codeblock in here. Due to be removed in future

            'try
            '{
            If Me.Enabled = False Then
                borderLineColor = m_disabledColors(0)
                borderPointColor = m_disabledColors(1)
                borderPoint2Color = m_disabledColors(2)
                upperGradientColor1 = m_disabledColors(3)
                upperGradientColor2 = m_disabledColors(4)
                lowerGradientColor1 = m_disabledColors(5)
                lowerGradientColor2 = m_disabledColors(6)
            End If
            '}
            'catch
            '{
            '}

            '#Region "Long borderlines"

            borderPen = New Pen(borderLineColor)

            Dim point1 As New Point(0, 2)
            Dim point2 As New Point(0, Me.Height - 3)

            e.Graphics.DrawLine(borderPen, point1, point2)

            point1 = New Point(Me.Width - 1, 2)
            point2 = New Point(Me.Width - 1, Me.Height - 3)

            e.Graphics.DrawLine(borderPen, point1, point2)

            point1 = New Point(2, 0)
            point2 = New Point(Me.Width - 3, 0)

            e.Graphics.DrawLine(borderPen, point1, point2)

            point1 = New Point(2, Me.Height - 1)
            point2 = New Point(Me.Width - 3, Me.Height - 1)

            e.Graphics.DrawLine(borderPen, point1, point2)
            '#End Region

            '#Region "Border points"

            borderPen = New Pen(borderPointColor)

            e.Graphics.DrawEllipse(borderPen, 1, 0, 1, 1)
            e.Graphics.DrawEllipse(borderPen, 0, 1, 1, 1)

            e.Graphics.DrawEllipse(borderPen, 1, Me.Height - 1, 1, 1)
            e.Graphics.DrawEllipse(borderPen, 0, Me.Height - 2, 1, 1)

            e.Graphics.DrawEllipse(borderPen, Me.Width - 2, 0, 1, 1)
            e.Graphics.DrawEllipse(borderPen, Me.Width - 1, 1, 1, 1)

            e.Graphics.DrawEllipse(borderPen, Me.Width - 2, Me.Height - 1, 1, 1)
            e.Graphics.DrawEllipse(borderPen, Me.Width - 1, Me.Height - 2, 1, 1)

            borderPen = New Pen(borderPoint2Color)

            e.Graphics.DrawEllipse(borderPen, 1, 1, 1, 1)
            e.Graphics.DrawEllipse(borderPen, 1, Me.Height - 2, 1, 1)
            e.Graphics.DrawEllipse(borderPen, Me.Width - 2, 1, 1, 1)
            e.Graphics.DrawEllipse(borderPen, Me.Width - 2, Me.Height - 2, 1, 1)

            '#End Region

            '#Region "Gradients"

            ' Upper gradient
            Dim upperGradientPoint1 As New PointF(1, 1)
            Dim upperGradientPoint2 As New PointF(1, Me.Height / 2.4F)

            gradientBrush = New LinearGradientBrush(upperGradientPoint1, upperGradientPoint2, upperGradientColor1,
                                                    upperGradientColor2)
            e.Graphics.FillRectangle(gradientBrush, upperGradientPoint1.X, upperGradientPoint1.Y, Me.Width - 2,
                                     upperGradientPoint2.Y)


            ' Lower gradient
            Dim lowerGradientPoint1 As New PointF(upperGradientPoint2.X, upperGradientPoint2.Y)
            Dim lowerGradientPoint2 As New PointF(upperGradientPoint2.X, Me.Height - 1)

            gradientBrush = New LinearGradientBrush(lowerGradientPoint1, lowerGradientPoint2, lowerGradientColor1,
                                                    lowerGradientColor2)
            e.Graphics.FillRectangle(gradientBrush, lowerGradientPoint1.X, lowerGradientPoint1.Y, Me.Width - 2,
                                     Me.Height - upperGradientPoint2.Y - 1)

            '#End Region

            If m_textImageRelation = ButtonTextImageRelation.TextAboveImage Then
                drawIcon(e.Graphics)
                drawText(e.Graphics)
            Else

                drawText(e.Graphics)
                drawIcon(e.Graphics)
            End If
        End Sub

        Private textPoint As PointF
        Private textBrush As Brush

        Private usedFontStyle As FontStyle = FontStyle.Regular

        <Browsable(True)> _
        <Description("What style should the font be in the button")> _
        <DefaultValue(FontStyle.Regular)>
        Public Property FontsStyle() As FontStyle
            Get
                Return Me.usedFontStyle
            End Get

            Set(ByVal value As FontStyle)
                Me.usedFontStyle = value
            End Set
        End Property

        Private m_fontSize As Integer = 12

        <Browsable(True)> _
        <Description("Font's size on the button")> _
        <DefaultValue(12)>
        Public Property FontSize() As Integer
            Get
                Return Me.m_fontSize
            End Get

            Set(ByVal value As Integer)
                Me.m_fontSize = value
            End Set
        End Property

        Private m_iconTransparency As Single

        <Browsable(True)> _
        <Description("Icon's transparency on the button (0f - 1f)")> _
        <DefaultValue(1.0F)>
        Public Property IconTransparency() As Single
            Get
                Return Me.m_iconTransparency
            End Get

            Set(ByVal value As Single)
                ' Check if the value is between 0 and 1f
                If value > 0.0F AndAlso value < 1.0F Then
                    Me.m_iconTransparency = value
                    Try
                        transparentIcon = MakeTransparentImage(DirectCast(m_icon, Image), Me.m_iconTransparency)
                        transparentDisabledIcon = MakeTransparentImage(DirectCast(IconDisabled, Image),
                                                                       Me.m_iconTransparency)
                    Catch
                        ' Not yet ready or something?
                    End Try
                End If
            End Set
        End Property

        Private Sub drawText(ByVal graphics As Graphics)
            Dim font As New Font("Segoe UI", m_fontSize, usedFontStyle, GraphicsUnit.Pixel)

            If Me.Enabled = True Then
                textBrush = New SolidBrush(Me.ForeColor)
            Else

                textBrush = New SolidBrush(Color.DarkGray)
            End If

            Select Case m_textAlign
                Case ButtonTextAlign.Left
                    textPoint = New PointF(m_textSpacingX, Me.Height / 2 - graphics.MeasureString(text, font).Height / 2)
                    Exit Select

                Case ButtonTextAlign.Right
                    textPoint = New PointF(Me.Width - graphics.MeasureString(text, font).Width - m_textSpacingX,
                                           Me.Height / 2 - graphics.MeasureString(text, font).Height / 2)
                    Exit Select

                Case ButtonTextAlign.Up
                    textPoint = New PointF(Me.Width / 2 - graphics.MeasureString(text, font).Width / 2, m_textSpacingY)
                    Exit Select

                Case ButtonTextAlign.Down
                    textPoint = New PointF(Me.Width / 2 - graphics.MeasureString(text, font).Width / 2,
                                           Me.Height - graphics.MeasureString(text, font).Height - m_textSpacingY)
                    Exit Select

                Case ButtonTextAlign.UpperLeft
                    textPoint = New PointF(m_textSpacingX, m_textSpacingY)
                    Exit Select

                Case ButtonTextAlign.UpperRight
                    textPoint = New PointF(Me.Width - graphics.MeasureString(text, font).Width - m_textSpacingX,
                                           m_textSpacingY)
                    Exit Select

                Case ButtonTextAlign.BottomLeft
                    textPoint = New PointF(m_textSpacingX,
                                           Me.Height - graphics.MeasureString(text, font).Height - m_textSpacingY)
                    Exit Select

                Case ButtonTextAlign.BottomRight
                    textPoint = New PointF(Me.Width - graphics.MeasureString(text, font).Width - m_textSpacingX,
                                           Me.Height - graphics.MeasureString(text, font).Height - m_textSpacingY)
                    Exit Select

                Case ButtonTextAlign.Center
                    textPoint = New PointF(Me.Width / 2 - graphics.MeasureString(text, font).Width / 2,
                                           Me.Height / 2 - graphics.MeasureString(text, font).Height / 2)
                    Exit Select
            End Select

            If text IsNot Nothing Then
                graphics.DrawString(text, font, textBrush, textPoint)
            End If
        End Sub

        Private imagePoint As PointF

        Private Sub drawIcon(ByVal graphics As Graphics)
            Try
                Select Case m_iconAlign
                    Case IconBitmapAlign.Left
                        imagePoint = New PointF(m_iconSpacingX, Me.Height / 2 - m_icon.Height / 2)
                        Exit Select

                    Case IconBitmapAlign.Right
                        imagePoint = New PointF(Me.Width - m_icon.Width - m_iconSpacingX, Me.Height / 2 - m_icon.Height / 2)
                        Exit Select

                    Case IconBitmapAlign.Up
                        imagePoint = New PointF(Me.Width / 2 - m_icon.Width / 2, m_iconSpacingY)
                        Exit Select

                    Case IconBitmapAlign.Down
                        imagePoint = New PointF(Me.Width / 2 - m_icon.Width / 2, Me.Height - m_iconSpacingY - m_icon.Height)
                        Exit Select

                    Case IconBitmapAlign.UpperLeft
                        imagePoint = New PointF(m_iconSpacingX, m_iconSpacingY)
                        Exit Select

                    Case IconBitmapAlign.UpperRight
                        imagePoint = New PointF(Me.Width - m_icon.Width - m_iconSpacingX, m_iconSpacingY)
                        Exit Select

                    Case IconBitmapAlign.BottomLeft
                        imagePoint = New PointF(m_iconSpacingX, Me.Height - m_icon.Height - m_iconSpacingY)
                        Exit Select

                    Case IconBitmapAlign.BottomRight
                        imagePoint = New PointF(Me.Width - m_icon.Width - m_iconSpacingX,
                                                Me.Height - m_icon.Height - m_iconSpacingY)
                        Exit Select

                    Case IconBitmapAlign.Center
                        imagePoint = New PointF((Me.Width / 2) - (m_icon.Width / 2), (Me.Height / 2) - (m_icon.Height / 2))
                        'MessageBox.Show("" + (this.Width / 2));
                        Exit Select
                End Select
                If m_icon IsNot Nothing Then
                    If Me.Enabled = True Then
                        ' If icon's transparency is 0 or greater, not 1
                        If m_iconTransparency <> 1 Then
                            graphics.DrawImage(transparentIcon, imagePoint.X, imagePoint.Y, m_icon.Width, m_icon.Height)
                        Else
                            graphics.DrawImage(m_icon, imagePoint.X, imagePoint.Y, m_icon.Width, m_icon.Height)

                        End If
                    Else
                        If m_iconTransparency <> 1 Then
                            graphics.DrawImage(transparentDisabledIcon, imagePoint.X, imagePoint.Y, m_icon.Width,
                                               m_icon.Height)
                        Else
                            graphics.DrawImage(IconDisabled, imagePoint.X, imagePoint.Y, m_icon.Width, m_icon.Height)
                        End If
                    End If
                End If
            Catch
            End Try
        End Sub

#End Region

#Region "Button properties"

#Region "Button's text"

        ' Text of the button
        Private Shadows text As String

        <Browsable(True)> _
        <Category("Text")>
        Public Property ButtonText() As String
            Get
                Return Me.text
            End Get

            Set(ByVal value As String)
                Me.text = value

                ' Paint the control to show the modified text
                Me.Invalidate()
            End Set
        End Property

        Public Enum ButtonTextAlign
            Left = 0
            Right = 1
            Up = 2
            Down = 3
            UpperLeft = 4
            UpperRight = 5
            BottomLeft = 6
            BottomRight = 7
            Center = 8
        End Enum

        Private m_textAlign As ButtonTextAlign = ButtonTextAlign.Center

        <Browsable(True)> _
        <DefaultValue(ButtonTextAlign.Center)>
        Public Property TextAlign() As ButtonTextAlign
            Get
                Return Me.m_textAlign
            End Get

            Set(ByVal value As ButtonTextAlign)
                Me.m_textAlign = value
                Me.Invalidate()
            End Set
        End Property

        Private m_textSpacingX As Integer

        <Browsable(True)>
        Public Property TextSpacingX() As Integer
            Get
                Return Me.m_textSpacingX
            End Get

            Set(ByVal value As Integer)
                Me.m_textSpacingX = value
                Me.Invalidate()
            End Set
        End Property

        Private m_textSpacingY As Integer

        <Browsable(True)>
        Public Property TextSpacingY() As Integer
            Get
                Return Me.m_textSpacingY
            End Get

            Set(ByVal value As Integer)
                Me.m_textSpacingY = value
                Me.Invalidate()
            End Set
        End Property

#End Region

#Region "Button's icon"

        Private m_icon As Bitmap
        Private transparentIcon As Bitmap
        Private transparentDisabledIcon As Bitmap

        <Browsable(True)>
        Public Property Icon() As Bitmap
            Get
                Return Me.m_icon
            End Get

            Set(ByVal value As Bitmap)
                Me.m_icon = value
                Me.Invalidate()
                generateDisabledIcon()

                ' Generate a new transparent icon for normal and disabled states
                Try
                    transparentIcon = MakeTransparentImage(m_icon, m_iconTransparency)
                    transparentDisabledIcon = MakeTransparentImage(IconDisabled, Me.m_iconTransparency)
                Catch
                    ' Not yet ready or something?
                End Try
            End Set
        End Property

        Public Enum IconBitmapAlign
            Left = 0
            Right = 1
            Up = 2
            Down = 3
            UpperLeft = 4
            UpperRight = 5
            BottomLeft = 6
            BottomRight = 7
            Center = 8
        End Enum

        Private m_iconAlign As IconBitmapAlign = IconBitmapAlign.Left

        <Browsable(True)>
        Public Property IconAlign() As IconBitmapAlign
            Get
                Return Me.m_iconAlign
            End Get

            Set(ByVal value As IconBitmapAlign)
                Me.m_iconAlign = value
                Me.Invalidate()
            End Set
        End Property

        Private m_iconSpacingX As Integer
        Private m_iconSpacingY As Integer

        '[Browsable(true)]

        '[Description("Icon spacing"), Editor(typeof(SpacingEditor), typeof(UITypeEditor))]
        <Browsable(True)>
        Public Property IconSpacingX() As Integer
            Get
                Return Me.m_iconSpacingX
            End Get

            Set(ByVal value As Integer)

                Me.m_iconSpacingX = value
                Me.Invalidate()
            End Set
        End Property

        <Browsable(True)>
        Public Property IconSpacingY() As Integer
            Get
                Return Me.m_iconSpacingY
            End Get

            Set(ByVal value As Integer)
                Me.m_iconSpacingY = value
                Me.Invalidate()
            End Set
        End Property

#End Region

#Region "TextImageRelation"

        Public Enum ButtonTextImageRelation
            ImageAboveText = 0
            TextAboveImage = 1
        End Enum

        Private m_textImageRelation As ButtonTextImageRelation = ButtonTextImageRelation.TextAboveImage

        <Browsable(True)>
        Public Property TextImageRelation() As ButtonTextImageRelation
            Get
                Return Me.m_textImageRelation
            End Get

            Set(ByVal value As ButtonTextImageRelation)
                Me.m_textImageRelation = value
                Me.Invalidate()
            End Set
        End Property

#End Region

#End Region

#Region "Define Colors"

#Region "Arrays"

        Private mouseOnColors As Color()

        <Browsable(True)>
        Public Property MouseOn_Colors() As Color()
            Get
                Return Me.mouseOnColors
            End Get

            Set(ByVal value As Color())
                Me.mouseOnColors = value
                ' Because the colors don't update when they are changed
                ' it's possible to do that by calling CloudButtonOwn_MouseLeave event
                CloudButtonOwn_MouseLeave(Me, Nothing)
                Me.Invalidate()
            End Set
        End Property

        Private mouseDownColors As Color()

        <Browsable(True)>
        Public Property MouseDown_Colors() As Color()
            Get
                Return Me.mouseDownColors
            End Get

            Set(ByVal value As Color())
                Me.mouseDownColors = value
                ' Because the colors don't update when they are changed
                ' it's possible to do that by calling CloudButtonOwn_MouseLeave event
                CloudButtonOwn_MouseLeave(Me, Nothing)
                Me.Invalidate()
            End Set
        End Property

        Private normalColors As Color()

        <Browsable(True)>
        Public Property Normal_Colors() As Color()
            Get
                Return Me.normalColors
            End Get

            Set(ByVal value As Color())
                Me.normalColors = value
                ' Because the colors don't update when they are changed
                ' it's possible to do that by calling CloudButtonOwn_MouseLeave event
                CloudButtonOwn_MouseLeave(Me, Nothing)
                Me.Invalidate()
            End Set
        End Property

        Private m_disabledColors As Color()

        <Browsable(True)>
        Public Property DisabledColors() As Color()
            Get
                Return Me.m_disabledColors
            End Get

            Set(ByVal value As Color())
                Me.m_disabledColors = value
                Me.Invalidate()
            End Set
        End Property

#End Region


        Private normalToMouseEnter As Boolean = False
        Private mouseDownToMouseEnter As Boolean = False

        Private Sub CloudButtonOwn_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
            ' If we want a smooth border, default colors are assigned
            'if (smoothBorder == true)
            '{
            '    borderLineColor = Color.FromArgb(222, 208, 156);
            '    borderPointColor = Color.FromArgb(228, 220, 186);
            '}

            ' ...otherwise we use more sharp color in MouseOn mode
            'else
            '{
            '}

            ' If the button is disabled, it doesn't look at mouse events

            If Me.Enabled = True Then
                If areAnimationsEnabled = False Then
                    borderLineColor = Color.FromArgb(191, 168, 113)
                    borderPointColor = Color.FromArgb(208, 185, 129)
                    borderPoint2Color = Color.FromArgb(243, 231, 182)
                    upperGradientColor1 = Color.FromArgb(255, 248, 217)
                    upperGradientColor2 = Color.FromArgb(255, 226, 133)
                    lowerGradientColor1 = Color.FromArgb(255, 213, 77)
                    lowerGradientColor2 = Color.FromArgb(255, 232, 151)
                Else

                    normalToMouseEnter = True
                    timerFade.Start()
                End If

                '    }
                '    else
                '    {
                '        CloudButtonOwn_MouseLeave(this, null);
                'this.Invalidate();
                '    }
                Me.Invalidate()
            End If
        End Sub

        Public Sub CMouseLeave()
            If areAnimationsEnabled = False Then
                borderLineColor = normalColors(0)
                borderPointColor = normalColors(1)
                borderPoint2Color = normalColors(2)
                upperGradientColor1 = normalColors(3)
                upperGradientColor2 = normalColors(4)
                lowerGradientColor1 = normalColors(5)
                lowerGradientColor2 = normalColors(6)
            Else

                normalToMouseEnter = False
                timerFade.Start()
            End If
        End Sub

        Private Sub CloudButtonOwn_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            'borderLineColor = Color.FromArgb(161, 189, 207);
            'borderPointColor = Color.FromArgb(202, 214, 212);
            'borderPoint2Color = Color.FromArgb(188, 208, 221);
            'upperGradientColor1 = Color.FromArgb(246, 249, 253);
            'upperGradientColor2 = Color.FromArgb(229, 238, 249);
            'lowerGradientColor1 = Color.FromArgb(210, 225, 244);
            'lowerGradientColor2 = Color.FromArgb(233, 242, 253);

            borderLineColor = normalColors(0)
            borderPointColor = normalColors(1)
            borderPoint2Color = normalColors(2)
            upperGradientColor1 = normalColors(3)
            upperGradientColor2 = normalColors(4)
            lowerGradientColor1 = normalColors(5)
            lowerGradientColor2 = normalColors(6)

            If isButtonSelected = False Then
                If areAnimationsEnabled = False Then
                    borderLineColor = normalColors(0)
                    borderPointColor = normalColors(1)
                    borderPoint2Color = normalColors(2)
                    upperGradientColor1 = normalColors(3)
                    upperGradientColor2 = normalColors(4)
                    lowerGradientColor1 = normalColors(5)
                    lowerGradientColor2 = normalColors(6)
                Else

                    normalToMouseEnter = False
                    timerFade.Start()
                End If
            Else

            End If


            Me.Invalidate()
        End Sub

        'bool isMouseClickedWhileOperation = false;

        Private isButtonSelected As Boolean = False

        Private Sub CloudButtonOwn_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                borderLineColor = Color.FromArgb(208, 193, 135)
                borderPointColor = Color.FromArgb(217, 208, 171)
                borderPoint2Color = Color.FromArgb(234, 220, 167)
                upperGradientColor1 = Color.FromArgb(247, 239, 205)
                upperGradientColor2 = Color.FromArgb(247, 215, 112)
                lowerGradientColor1 = Color.FromArgb(247, 200, 49)
                lowerGradientColor2 = Color.FromArgb(247, 221, 132)

                'borderLineColor = mouseDownColors[0];
                'borderPointColor = mouseDownColors[1];
                'borderPoint2Color = mouseDownColors[2];
                'upperGradientColor1 = mouseDownColors[3];
                'upperGradientColor2 = mouseDownColors[4];
                'lowerGradientColor1 = mouseDownColors[5];
                'lowerGradientColor2 = mouseDownColors[6];

                ' If there is some process going on
                'if (timerFade.Enabled == true && mouseOnToMouseClick == false)
                '{
                '    //isMouseClickedWhileOperation = true;
                '}

                'else
                '{
                '    //borderLineColor = mouseDownColors[0];
                '    //borderPointColor = mouseDownColors[1];
                '    //borderPoint2Color = mouseDownColors[2];
                '    //upperGradientColor1 = mouseDownColors[3];
                '    //upperGradientColor2 = mouseDownColors[4];
                '    //lowerGradientColor1 = mouseDownColors[5];
                '    //lowerGradientColor2 = mouseDownColors[6];
                '}

                isButtonSelected = True

                Me.Invalidate()
            End If
        End Sub

        Private Sub CloudButtonOwn_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Me.CloudButtonOwn_MouseEnter(Me, Nothing)
            timerFade.Start()
            mouseDownToMouseEnter = True
        End Sub

#End Region

      
        Private index As Integer = 0

        Private Sub timerFade_Tick(ByVal sender As Object, ByVal e As EventArgs)

            If normalToMouseEnter = True Then
                If index <= count Then
                    borderLineColor = getReadyColor(mouseOnColors(0), normalColors(0))
                    borderPointColor = getReadyColor(mouseOnColors(1), normalColors(1))
                    borderPoint2Color = getReadyColor(mouseOnColors(2), normalColors(2))
                    upperGradientColor1 = getReadyColor(mouseOnColors(3), normalColors(3))
                    upperGradientColor2 = getReadyColor(mouseOnColors(4), normalColors(4))
                    lowerGradientColor1 = getReadyColor(mouseOnColors(5), normalColors(5))
                    lowerGradientColor2 = getReadyColor(mouseOnColors(6), normalColors(6))

                    index += 1
                Else

                    If leaveIsHappened = True Then
                        setNormalColors()
                        leaveIsHappened = False
                    End If
                    timerFade.[Stop]()
                    index = 0
                    normalToMouseEnter = False
                End If
            Else

                If index <= count Then
                    borderLineColor = getReadyColor(normalColors(0), mouseOnColors(0))
                    borderPointColor = getReadyColor(normalColors(1), mouseOnColors(1))
                    borderPoint2Color = getReadyColor(normalColors(2), mouseOnColors(2))
                    upperGradientColor1 = getReadyColor(normalColors(3), mouseOnColors(3))
                    upperGradientColor2 = getReadyColor(normalColors(4), mouseOnColors(4))
                    lowerGradientColor1 = getReadyColor(normalColors(5), mouseOnColors(5))
                    lowerGradientColor2 = getReadyColor(normalColors(6), mouseOnColors(6))

                    index += 1
                Else

                    If leaveIsHappened = True Then
                        setNormalColors()
                        leaveIsHappened = False
                    End If
                    timerFade.[Stop]()
                    index = 0
                End If
            End If

            If mouseDownToMouseEnter = True Then
                If index <= count Then
                    borderLineColor = getReadyColor(mouseDownColors(0), mouseOnColors(0))
                    borderPointColor = getReadyColor(mouseDownColors(1), mouseOnColors(1))
                    borderPoint2Color = getReadyColor(mouseDownColors(2), mouseOnColors(2))
                    upperGradientColor1 = getReadyColor(mouseDownColors(3), mouseOnColors(3))
                    upperGradientColor2 = getReadyColor(mouseDownColors(4), mouseOnColors(4))
                    lowerGradientColor1 = getReadyColor(mouseDownColors(5), mouseOnColors(5))
                    lowerGradientColor2 = getReadyColor(mouseDownColors(6), mouseOnColors(6))

                    index += 1
                Else

                    If leaveIsHappened = True Then
                        setNormalColors()
                        leaveIsHappened = False
                    End If
                    timerFade.[Stop]()
                    index = 0

                    '/ If mouse clicked while operation
                    'if (isMouseClickedWhileOperation == true)
                    '{
                    '    borderLineColor = mouseDownColors[0];
                    '    borderPointColor = mouseDownColors[1];
                    '    borderPoint2Color = mouseDownColors[2];
                    '    upperGradientColor1 = mouseDownColors[3];
                    '    upperGradientColor2 = mouseDownColors[4];
                    '    lowerGradientColor1 = mouseDownColors[5];
                    '    lowerGradientColor2 = mouseDownColors[6];
                    '}
                    mouseDownToMouseEnter = False
                End If
            End If

            If normalToDisabled = True Then
                If index <= count Then
                    borderLineColor = getReadyColor(normalColors(0), m_disabledColors(0))
                    borderPointColor = getReadyColor(normalColors(1), m_disabledColors(1))
                    borderPoint2Color = getReadyColor(normalColors(2), m_disabledColors(2))
                    upperGradientColor1 = getReadyColor(normalColors(3), m_disabledColors(3))
                    upperGradientColor2 = getReadyColor(normalColors(4), m_disabledColors(4))
                    lowerGradientColor1 = getReadyColor(normalColors(5), m_disabledColors(5))
                    lowerGradientColor2 = getReadyColor(normalColors(6), m_disabledColors(6))

                    index += 1
                Else

                    If leaveIsHappened = True Then
                        setNormalColors()
                        leaveIsHappened = False
                    End If
                    timerFade.[Stop]()
                    index = 0
                    normalToDisabled = False
                    '/ If mouse clicked while operation
                    'if (isMouseClickedWhileOperation == true)
                    '{
                    '    borderLineColor = mouseDownColors[0];
                    '    borderPointColor = mouseDownColors[1];
                    '    borderPoint2Color = mouseDownColors[2];
                    '    upperGradientColor1 = mouseDownColors[3];
                    '    upperGradientColor2 = mouseDownColors[4];
                    '    lowerGradientColor1 = mouseDownColors[5];
                    '    lowerGradientColor2 = mouseDownColors[6];
                    '}
                    count = 10
                End If
            End If

            If disabledToNormal = True Then
                If index <= count Then
                    borderLineColor = getReadyColor(m_disabledColors(0), normalColors(0))
                    borderPointColor = getReadyColor(m_disabledColors(1), normalColors(1))
                    borderPoint2Color = getReadyColor(m_disabledColors(2), normalColors(2))
                    upperGradientColor1 = getReadyColor(m_disabledColors(3), normalColors(3))
                    upperGradientColor2 = getReadyColor(m_disabledColors(4), normalColors(4))
                    lowerGradientColor1 = getReadyColor(m_disabledColors(5), normalColors(5))
                    lowerGradientColor2 = getReadyColor(m_disabledColors(6), normalColors(6))

                    index += 1
                Else

                    If leaveIsHappened = True Then
                        setNormalColors()
                        leaveIsHappened = False
                    End If
                    timerFade.[Stop]()
                    index = 0
                    disabledToNormal = False
                    ' If mouse clicked while operation
                    'if (isMouseClickedWhileOperation == true)
                    '{
                    '    borderLineColor = mouseDownColors[0];
                    '    borderPointColor = mouseDownColors[1];
                    '    borderPoint2Color = mouseDownColors[2];
                    '    upperGradientColor1 = mouseDownColors[3];
                    '    upperGradientColor2 = mouseDownColors[4];
                    '    lowerGradientColor1 = mouseDownColors[5];
                    '    lowerGradientColor2 = mouseDownColors[6];
                    '}
                    count = 10
                End If
            End If

            Me.Invalidate()
        End Sub

        Private count As Integer = 10

        Private normalToDisabled As Boolean = False
        Private disabledToNormal As Boolean = False

        Private areAnimationsEnabled As Boolean = False

        Private Sub setNormalColors()
            borderLineColor = normalColors(0)
            borderPointColor = normalColors(1)
            borderPoint2Color = normalColors(2)
            upperGradientColor1 = normalColors(3)
            upperGradientColor2 = normalColors(4)
            lowerGradientColor1 = normalColors(5)
            lowerGradientColor2 = normalColors(6)

            Me.Invalidate()
        End Sub

        Private Function getReadyColor(ByVal color1 As Color, ByVal color2 As Color) As Color
            'Color colorFirst = Color.FromArgb(color1.R * index, color1.G * index, color1.B * index);
            'Color colorSecond = Color.FromArgb(color2.R * 100 - index, color2.G * 100 - index, color2.B * 100 - index);

            Dim FCR As Integer = color1.R * index
            Dim FCG As Integer = color1.G * index
            Dim FCB As Integer = color1.B * index
            Dim SCR As Integer = color2.R * (count - index)
            Dim SCG As Integer = color2.G * (count - index)
            Dim SCB As Integer = color2.B * (count - index)

            Dim readyR As Integer = (FCR + SCR) / count
            Dim readyG As Integer = (FCG + SCG) / count
            Dim readyB As Integer = (FCB + SCB) / count

            'if (readyR > 255)
            '{
            '    readyR = 255;
            '}

            'if (readyR < 0)
            '{
            '    readyR = 0;
            '}

            'if (readyG > 255)
            '{
            '    readyG = 255;
            '}

            'if (readyG < 0)
            '{
            '    readyG = 0;
            '}

            'if (readyB > 255)
            '{
            '    readyB = 255;
            '}

            'if (readyB < 0)
            '{
            '    readyB = 0;
            '}

            Dim readyColor As Color = Color.FromArgb(readyR, readyG, readyB)

            Return readyColor
        End Function

        Private IconDisabled As Bitmap

        Private Sub CloudButton_EnabledChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.Enabled = True Then
                'borderLineColor = disabledColors[0];
                'borderPointColor = disabledColors[1];
                'borderPoint2Color = disabledColors[2];
                'upperGradientColor1 = disabledColors[3];
                'upperGradientColor2 = disabledColors[4];
                'lowerGradientColor1 = disabledColors[5];
                'lowerGradientColor2 = disabledColors[6];

                'index = 0;
                count = 30
                normalToDisabled = True
                timerFade.Start()
            Else

                count = 30
                disabledToNormal = True
                'borderLineColor = normalColors[0];
                'borderPointColor = normalColors[1];
                'borderPoint2Color = normalColors[2];
                'upperGradientColor1 = normalColors[3];
                'upperGradientColor2 = normalColors[4];
                'lowerGradientColor1 = normalColors[5];
                'lowerGradientColor2 = normalColors[6];
                timerFade.Start()
            End If
        End Sub

        Private Sub generateDisabledIcon()
            Try
                If m_icon IsNot Nothing Then
                    IconDisabled = New Bitmap(m_icon.Width, m_icon.Height)
                    Dim graphics__1 As Graphics = Graphics.FromImage(IconDisabled)

                    For i As Integer = 0 To m_icon.Width - 1
                        For j As Integer = 0 To m_icon.Height - 1
                            If m_icon.GetPixel(i, j).A = 0 Then
                                Dim pointpen As New Pen(Color.FromArgb(0, 255, 255, 255))

                                graphics__1.DrawEllipse(pointpen, i, j, 1, 1)
                            Else
                                Dim rgb As Integer =
                                        (m_icon.GetPixel(i, j).R + m_icon.GetPixel(i, j).G + m_icon.GetPixel(i, j).B) / 3
                                Dim a As Integer = m_icon.GetPixel(i, j).A
                                'Pen pointpen = new Pen(Color.FromArgb(rgb, rgb, rgb));
                                'pointpen.Width = 1;

                                'graphics.DrawEllipse(pointpen, i, j, 1, 1);
                                IconDisabled.SetPixel(i, j, Color.FromArgb(a, rgb, rgb, rgb))
                            End If
                        Next
                    Next
                End If
            Catch
            End Try
        End Sub

        ' Following code generates transparent image
        Private Shared Function MakeTransparentImage(ByVal image As Image, ByVal alpha As Single) As Bitmap

            If image Is Nothing Then
                Throw New ArgumentNullException("image")
            End If

            If alpha < 0.0F OrElse alpha > 1.0F Then
                Throw New ArgumentOutOfRangeException("alpha", "Must be between 0.0 and 1.0.")
            End If


            Dim colorMatrix As New ColorMatrix()

            colorMatrix.Matrix33 = 1.0F - alpha

            Dim bmp As New Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb)

            Using attrs As New ImageAttributes()

                attrs.SetColorMatrix(colorMatrix)

                Using g As Graphics = Graphics.FromImage(bmp)
                    g.DrawImage(image, New Rectangle(Point.Empty, New Size(image.Width, image.Height)), 0, 0,
                                image.Width, image.Height,
                                GraphicsUnit.Pixel, attrs)
                End Using
            End Using


            Return bmp
        End Function

        Private leaveIsHappened As Boolean = False

        Private Sub CloudButton_Leave(ByVal sender As Object, ByVal e As EventArgs)
            leaveIsHappened = True

            borderLineColor = normalColors(0)
            borderPointColor = normalColors(1)
            borderPoint2Color = normalColors(2)
            upperGradientColor1 = normalColors(3)
            upperGradientColor2 = normalColors(4)
            lowerGradientColor1 = normalColors(5)
            lowerGradientColor2 = normalColors(6)
            'isButtonSelected = false;

            Me.Invalidate()
        End Sub
    End Class
End Namespace
