using System;
int quantidadeExames = 5;

string[] estudantes = ["Sophia", "Andrew", "Emma", "Logan"];

int[] sophiaNotes = [90, 86, 87, 98, 100, 94, 90];
int[] andrewNotes = [92, 89, 81, 96, 90, 89];
int[] emmaNotes = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganNotes = [90, 95, 87, 88, 96, 96];

int[] notasEstudantes = new int[10];

Console.WriteLine($"Aluno\t\tNota\n");

foreach (string estudante in estudantes)
{
    string estudantesGeral = estudante;

    if (estudante == "Sophia")
        notasEstudantes = sophiaNotes;

    else if (estudante == "Andrew")
        notasEstudantes = andrewNotes;

    else if (estudante == "Emma")
        notasEstudantes = emmaNotes;

    else if (estudante == "Logan")
        notasEstudantes = loganNotes;

    //int sumNotas = 0;
    string letrasNotas = "";

    int sumAtividadesExtras = 0;
    decimal mediaEstudantes = 0;
    int atividadesExtras = 0;

    foreach (int notes in notasEstudantes)
    {
        atividadesExtras += 1;
        //sumNotas += notes;
        if (atividadesExtras <= quantidadeExames)
            sumAtividadesExtras += notes;
        else
            sumAtividadesExtras += notes / 10;
    }
     mediaEstudantes = (decimal)(sumAtividadesExtras) / quantidadeExames;

    if (mediaEstudantes >= 97)
        letrasNotas = "A+";
    else if (mediaEstudantes >= 93)
        letrasNotas = "A";
    else if (mediaEstudantes >= 90)
        letrasNotas = "A-";
    else if (mediaEstudantes >= 87)
        letrasNotas = "B+";
    else if (mediaEstudantes >= 83)
        letrasNotas = "B";
    else if (mediaEstudantes >= 80)
        letrasNotas = "B-";
    else if (mediaEstudantes >= 77)
        letrasNotas = "C+";
    else if (mediaEstudantes >= 73)
        letrasNotas = "C";
    else if (mediaEstudantes >= 70)
        letrasNotas = "C-";
    else if (mediaEstudantes >= 67)
        letrasNotas = "D+";
    else if (mediaEstudantes >= 63)
        letrasNotas = "D";
    else if (mediaEstudantes >= 60)
        letrasNotas = "D-";
    else letrasNotas = "F";


    Console.WriteLine($"{estudantesGeral}\t\t{mediaEstudantes}\t{letrasNotas}");
}

Console.WriteLine("Aperte Enter para sair do programa.");
Console.ReadLine();