namespace Entidades
{
    //public enum eUnidadDeMedida
    //{
    //    botella_350cm,
    //    botella_500ml,
    //    botella_1Ltr,
    //    botella_1Ltr_y_medio,
    //    botella_2Ltr_y_cuarto,
    //    paquete_1Kgr,
    //    paquete_500gr,
    //    paquete_250gr,
    //}
    public enum eVolumenBotella
    {
        botella_350cm,
        botella_500ml,
        botella_1Ltr,
        botella_1Ltr_y_medio,
        botella_2Ltr_y_cuarto
    }
    public enum ePesoInsumo
    {
        _1Kgr,
        _500gr,
        _250gr,
        _1Ltr,
    }
    public enum eTipoBebida
    {
        SinAlcohol,
        ConAlcohol
    }

    public enum eTipoDeProducto
    {
        Carnes,
        Pastas,
        Lacteos,
        Legumbres,
        Verduras
    }

    public enum eMedioDePago
    {
        Contado,
        Tarjeta,
        Transferencia
    }
}
