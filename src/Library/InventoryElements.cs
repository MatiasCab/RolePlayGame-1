using System;
using System.Collections;

namespace Roleplay
{

public class InventoryElements 
{
    private string name;
    private double defensa;
    private double ataque;
    private double mana;
    private string descripcion;
    private string tipo;

    public InventoryElements( string name, string descipcion,string tipo, double defensa, double ataque, double mana)
    {
        this.Name=name;
        this.Descripcion=descipcion;
        this.Defensa=defensa;
        this.Ataque=ataque;
        this.Mana=mana;
        this.Tipo=tipo;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set 
        {
            this.name=value;
        }
    }
    public string Descripcion
    {
        get
        {
            return this.descripcion;
            
        }
        set 
        {
            this.descripcion=value;
        }
        
    }
    public double Ataque
    {
        get
        {
            return this.ataque;
        }
        set 
        {
            this.ataque=value;
        }
    }
    public double Defensa
    {
        get
        {
            return this.defensa;
        }
        set 
        {
            this.defensa=value;
        }
    }
    public double Mana
    {
        get
        {
            return this.mana;
        }
        set 
        {
            this.mana=value;
        }
    }
    public string Tipo
    {
        get
        {
            return this.tipo;
        }
        set 
        {
            this.tipo=value;
        }
    }

}
}


