using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public enum TooTyyp
    {
        Palk,
        Toetus
    }

    public enum Oppevorm
    {
        Päevane,
        Kaugõpe,
        Ekstern,
        AkadeemilinePuhkus
    }
    internal interface ITooline
    {
        TooTyyp VäljamakseTüüp { get; set; }
        double ArvutaPalk();

    }
}