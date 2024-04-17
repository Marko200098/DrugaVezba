using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Primer002

{

//neki koment

class Student : Osoba

{


private string brIndeksa;

private int godina;


public Student()

{

brIndeksa = “”;

godina = 0;

}

public Student(string JMBG1, string imePrezime1, string adresa1, string brIndeksa1, int godina1) : base(JMBG1, imePrezime1, adresa1)

{

brIndeksa = brIndeksa1;

godina = godina1;

}

public override void prikazi()

{

Console.WriteLine(“Ime i prezime: ” + imePrezime + “!nl!JMBG: ” + JMBG + “!nl!Adresa: ” + adresa + “!nl!Broj indeksa: ” + brIndeksa + “!nl!Godina studija: ” + godina);

}

}

}
