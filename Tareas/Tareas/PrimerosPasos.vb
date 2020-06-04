Public Class PrimerosPasos
    Private Sub btnNoobGuitarra_Click(sender As Object, e As EventArgs) Handles btnNoobGuitarra.Click
        Dim NoobG As Integer

        Randomize()
        NoobG = Int(Rnd() * 3)
        Select Case NoobG
            Case 0
                MessageBox.Show("Lamento Boliviano - Enanitos Verdes", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("Fuentez De Ortiz - Ed Maverick", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Come As You Are - Nirvana", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnNoobPiano_Click(sender As Object, e As EventArgs) Handles btnNoobPiano.Click
        Dim NoobP As Integer

        Randomize()
        NoobP = Int(Rnd() * 3)
        Select Case NoobP
            Case 0
                MessageBox.Show("Perfect - Ed Sheeran", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("Himno a la alegria", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("twinkle twinkle little star", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnNoobBajo_Click(sender As Object, e As EventArgs) Handles btnNoobBajo.Click
        Dim NoobB As Integer

        Randomize()
        NoobB = Int(Rnd() * 3)
        Select Case NoobB
            Case 0
                MessageBox.Show("Feel goob.inc - Gorillaz", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("Pumped up kid - Foster the People", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Stand by me - Ben E King", "Noob", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnMedioGuitarra_Click(sender As Object, e As EventArgs) Handles btnMedioGuitarra.Click
        Dim MedG As Integer

        Randomize()
        MedG = Int(Rnd() * 3)
        Select Case MedG
            Case 0
                MessageBox.Show("Don - Miranda", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("What You Know - Two Doors Cinema Club", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Imagination - Foster The People", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnMedioPiano_Click(sender As Object, e As EventArgs) Handles btnMedioPiano.Click
        Dim Medp As Integer

        Randomize()
        Medp = Int(Rnd() * 3)
        Select Case Medp
            Case 0
                MessageBox.Show("The Scientist - Coldplay", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("Imagine - John Lennon", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("We Are The Champions - Queen", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnMedioBajo_Click(sender As Object, e As EventArgs) Handles btnMedioBajo.Click
        Dim MedB As Integer

        Randomize()
        MedB = Int(Rnd() * 3)
        Select Case MedB
            Case 0
                MessageBox.Show("Dark Necessities - RHCP", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("Disco Yes - Tom Misch", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Forget me nots - Patrice Rushen", "Medium", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnProGuitarra_Click(sender As Object, e As EventArgs) Handles btnProGuitarra.Click
        Dim ProG As Integer

        Randomize()
        ProG = Int(Rnd() * 3)
        Select Case ProG
            Case 0
                MessageBox.Show("Entre Dos Aguas - Paco de Lucia", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("What Once Was - Hers", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Though the Fire And Flames - DragonForce", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnProPiano_Click(sender As Object, e As EventArgs) Handles btnProPiano.Click
        Dim ProP As Integer

        Randomize()
        ProP = Int(Rnd() * 3)
        Select Case ProP
            Case 0
                MessageBox.Show("Nocturne op.9 No 2 - Chopin", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("Moonlight Sonata - Beethoveen", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Claire De Lune - Claude Debussy", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub

    Private Sub btnProBajo_Click(sender As Object, e As EventArgs) Handles btnProBajo.Click
        Dim ProB As Integer

        Randomize()
        ProB = Int(Rnd() * 3)
        Select Case ProB
            Case 0
                MessageBox.Show("Don´t Start Now - Dua Lipa", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("Trying to Be Cool - Breakbot", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("If I Ever Feel Better - Phoenix", "Pro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class