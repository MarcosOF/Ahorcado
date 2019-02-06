Option Strict On
Module Module1

    Sub Main()


        Dim palabras As String = "baloncesto,computadora,montaña,adrenalina,hormigababuino,tejon,murcielago,oso,castor,camello,gato,almeja,cobra,pantera,coyote,cuervo,ciervo,perro,burro,pato,aguila,huron,zorro,rana,cabra,ganso,halcon,leon,lagarto,llama,topo,mono,alce,raton,mula,salamandra,nutria,buho,panda,loro,paloma,piton,conejo,carnero,rata,cuervo,rinoceronte,salmon,foca,tiburon,oveja,tigre,sapo,trucha,pavo,tortuga,comadreja,ballena,lobo,cebra"
        Dim palabras2() As String = palabras.Split(","c)
        Dim al As Random = New Random

        Dim palabraParaUsar As String = palabras2(al.Next(0, palabras2.Length - 1))
        Console.WriteLine(palabraParaUsar)
        Dim copia(palabraParaUsar.Length - 1) As String

        For i As Integer = 0 To copia.Length - 1 Step 1
            copia(i) = "_"
        Next
        'For i As Integer = 0 To palabraParaUsar.Length - 1 Step 1
        '    Console.Write(palabraParaUsar(i))
        'Next
        Dim palIn As String
        Dim cont As String
        Dim p2 As String
        Do

            Console.WriteLine()
            'For i As Integer = 0 To palabraParaUsar.Length - 1 Step 1

            Console.WriteLine()

            'Next
            Dim acertado As Boolean = False
            Console.WriteLine("Vas a introducir un caracter o la palabra? c/p")
            If Console.ReadLine() = "c"c Then
                For i As Integer = 0 To copia.Length - 1 Step 1
                    Console.Write(copia(i))
                Next
                Console.WriteLine()
                Console.WriteLine("Introduce el primer caracter")
                palIn = Console.ReadLine()
                For i As Integer = 0 To palabraParaUsar.Length - 1 Step 1
                    If palIn = palabraParaUsar(i) Then
                        copia(i) = palIn
                        acertado = True
                    End If

                Next
                For i As Integer = 0 To copia.Length - 1 Step 1
                    Console.Write(copia(i))
                Next


                Console.WriteLine()
            Else
                Console.WriteLine("Introduce la palabra, si fallas pierdes")
                p2 = Console.ReadLine()
                If p2 = palabraParaUsar Then
                    Console.WriteLine("Has ganado")
                    Exit Do
                Else
                    Console.WriteLine("Has perdido noob")
                    Exit Do
                End If
            End If
            Console.WriteLine()
            Console.WriteLine("Quieres continuar s/n")
            cont = Console.ReadLine()


        Loop While cont = "s"

        Console.ReadLine()
    End Sub

End Module
