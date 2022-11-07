
// See https://aka.ms/new-console-template for more information

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
    public Cliente CercaCliente(string codiceFiscale)
    {
        foreach (Cliente cliente in Clienti)
        {
            if(cliente.CodiceFiscale == codiceFiscale)
                return cliente;
        }
        return null;
    }
    public bool NuovoCliente(Cliente cliente)
    {
        if (
            cliente.Nome == null || cliente.Nome == "" ||
            cliente.Cognome == null || cliente.Cognome == "" ||
            cliente.CodiceFiscale == null || cliente.CodiceFiscale == "" ||
            cliente.Stipendio < 0
           )
            return false;
        Cliente clienteEsistente = CercaCliente(cliente.CodiceFiscale);
        if (clienteEsistente != null)
            return false;
        Clienti.Add(cliente);
        return true;
    }
    public bool ModificaCliente(Cliente clienteModificato)
    {
        Cliente cliente = CercaCliente(clienteModificato.CodiceFiscale);
        if (cliente == null)
            return false;
        if(clienteModificato.Nome != "")
            cliente.Nome = clienteModificato.Nome;
        if (clienteModificato.Cognome != "")
            cliente.Cognome = clienteModificato.Cognome;
        if (clienteModificato.Stipendio > 0)
            cliente.Stipendio = clienteModificato.Stipendio;
        return true;
    }
}