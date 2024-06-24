'' Author: Francisco Bumanglag
'' Project: Compound Interest
'' Assignment: Module 8 Homework
'' Course: Visual Basic, Santa Ana College
'' Class: CMPR105 Derendal Huynh 
'' Date: October 12, 2022

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim simple As Double = 1000 + 50
        Dim compound As Double = 1000 * 1.05

        ListBox1.Items.Add("    " & vbTab & "SIMPLE" & vbTab & vbTab & "COMPOUND")
        ListBox1.Items.Add("YEAR" & vbTab & "INTEREST" & vbTab & vbTab & "INTEREST")

        For yr As Integer = 1 To 9

            ListBox1.Items.Add(yr & vbTab & FormatCurrency(simple) & vbTab & vbTab & FormatCurrency(compound))

            simple += 50
            compound = compound * 1.05

        Next

    End Sub



End Class