// See https://aka.ms/new-console-template for more information

public class Cliente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string CodiceFiscale { get; set; }
    public int Stipendio { get; set; }
    public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        Nome = nome;
        Cognome = cognome;
        CodiceFiscale = codiceFiscale;
        Stipendio = stipendio;
    }
}

public class Prestito
{
    public int Id { get; set; }
    public Cliente Intestatario { get; set; }
    public int Ammontare { get; set; }
    public int ValoreRata { get; set; }
    public DateOnly Inizio { get; set; }
    public DateOnly Fine { get; set; }
    public Prestito(int id, Cliente intestatario, int ammontare, int valoreRata, DateOnly inizio, DateOnly fine)
    {
        Id = id;
        Intestatario = intestatario;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        Inizio = inizio;
        Fine = fine;
    }
}

public class Banca
{
    public string Nome { get; private set; }
    List<Cliente> Clienti { get; set; }
    List<Prestito> Prestiti { get; set; }
    public Banca(string nome)
    {
        Nome = nome;
        Clienti = new List<Cliente>();
        Prestiti = new List<Prestito>();
    }
}