using System.Diagnostics.Contracts;
public class ChaveDeFenda : Maquina
{
    public ChaveDeFenda()
    {
        this.Nivel = 1;
        this.Experiencia = 1;
        
        this.Tier = 1;
        this.Ataque = 2;
        this.Vida = 3;
    }
}