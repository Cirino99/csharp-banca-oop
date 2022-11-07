
// See https://aka.ms/new-console-template for more information

using System;

Banca banca = new Banca("N26");
Cliente cliente1 = new Cliente("Mario","Rossi","CRNSMN", 500);
banca.NuovoCliente(cliente1);
Cliente cercaCliente = banca.CercaCliente("CRNSMN");
if(cercaCliente != null)
    Console.WriteLine(cercaCliente.Nome + cercaCliente.Stipendio);
Cliente clieten1mod = new Cliente("", "", "CRNSMN", 1000);
banca.ModificaCliente(clieten1mod);
Cliente cercaCliente2 = banca.CercaCliente("CRNSMN");
if (cercaCliente2 != null)
    Console.WriteLine(cercaCliente2.Nome + cercaCliente2.Stipendio);
DateOnly inizio = DateOnly.FromDateTime(DateTime.Now);
DateOnly fine = inizio.AddMonths(24);
banca.NuovoPrestito("CRNSMN",10000,inizio,fine);
List<Prestito> prestiti = banca.RicercaPrestitiCliente("CRNSMN");
foreach (Prestito prestito in prestiti)
{
    Console.WriteLine("Prestito di {0} da {1} a rata",prestito.Ammontare,prestito.ValoreRata);
}
Console.WriteLine("Ammontare totale dei prestiti concessi: " + banca.AmmontareTotalePrestitiCliente("CRNSMN"));