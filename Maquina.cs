public abstract class Maquina
{
    public int Nivel { get; set; }
    public int Experiencia { get; set; }
    public int Tier { get; set; }
    public int Ataque { get; set; }
    public int Vida { get; set; }

    public virtual void Derrotado() {}
    public virtual void Comprado() {}
    public virtual void Vendido() {}
    public virtual void Nascido() {}
    public virtual void turnoCompra() {}
    public virtual void machucado() {}

}

