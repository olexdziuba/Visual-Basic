﻿Public Class Form1
    Dim k As Double
    Dim d As Integer
    ''d=1  +
    ''d=2  -
    ''d=3  *
    ''d=3  /
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        k = TextBox1.Text
        TextBox1.Text = ""
        d = 4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text &= "1"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text &= "2"


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text &= "3"


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Text &= "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox1.Text &= "5"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox1.Text &= "6"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox1.Text &= "7"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text &= "8"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox1.Text &= "9"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text = "0" Then
        Else TextBox1.Text &= "0"
        End If



    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        k = TextBox1.Text
        TextBox1.Text = ""
        d = 1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text &= ","
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Select Case d
            ''is d=1 +
            Case Is = 1

                TextBox1.Text = k + TextBox1.Text
                ''is d=1 -
            Case Is = 2

                TextBox1.Text = k - TextBox1.Text
            Case Is = 3
                TextBox1.Text = k * TextBox1.Text
            Case Is = 4
                If TextBox1.Text <> "" And TextBox1.Text <> 0 Then
                    TextBox1.Text = k / TextBox1.Text
                Else TextBox1.Text = "ERROR"
                End If
        End Select
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = ""
        k = 0
        d = 0
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        k = TextBox1.Text
        TextBox1.Text = ""
        d = 2
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        k = TextBox1.Text
        TextBox1.Text = ""
        d = 3
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
