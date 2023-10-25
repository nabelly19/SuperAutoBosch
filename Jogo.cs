using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class Jogo
{

    public State State { get; set; }

    public static int Dinheiros { get; set; }
    public static int Coracoes { get; set; }

    public static int Trofeus { get; set; }

    public static Stack<Maquina> meuTime = new();

    public static Stack<Maquina> timeInimigo = new();

    public List<Maquina> listaBaseMaquinas = new();

    // Loja loja = new();

    public void Inicializar()
    {
        
        // Loja.Preencher();
    }

    public void Rodada()
    {
        Stack<Maquina> saveMeutime = meuTime;
        Stack<Maquina> saveTimeInimigo = timeInimigo;

        while (true)
        {
            meuTime.Peek().Vida -= timeInimigo.Peek().Ataque;
            timeInimigo.Peek().Vida -= meuTime.Peek().Ataque;

            if (meuTime.Peek().Vida < 1)
                meuTime.Pop();
            
            if (timeInimigo.Peek().Vida < 1)
                timeInimigo.Pop();
            

            if(meuTime is null)
            {
                Coracoes--;
                break;
            }

            if(timeInimigo is null)
            {
                Trofeus++;
                break;
            }
        }

        meuTime = saveMeutime;
        timeInimigo = saveTimeInimigo;
    }

}

