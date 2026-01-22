using System;
using System.Threading;

public class Pedido : IProcessavel
{
    private int id;
    private string cliente;
    private int tempoProcessamento;

    public int Id
    {
        get{ return id; }
        set{ id = value; }
    }

    public string Cliente 
    {
        get{ return cliente; }
        set{ cliente = value; }
    }

    public int TempoProcessamento
    {
        get{ return tempoProcessamento; }
        set{ tempoProcessamento = value; }
    }

    public Pedido(int id, string cliente, int tempoProcessamento)
    {
        this.id = id;
        this.cliente = cliente;
        this.tempoProcessamento = tempoProcessamento;
    }

    public void Processar()
    {
        Console.WriteLine($"Processando pedido {Id} do cliente {Cliente}...");
        Thread.Sleep(TempoProcessamento * 1000);
        Console.WriteLine($"Pedido {Id} finalizado!");
    }
}