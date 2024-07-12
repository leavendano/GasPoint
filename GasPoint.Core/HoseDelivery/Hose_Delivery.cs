
namespace GasPoint.Core.HoseDelivery
{
    public class Hose_Delivery 
    {
        public int Delivery_ID { get; set; }
        public int Hose_ID { get; set; }
        public int? Attendant_ID { get; set; }
        public int Price_Level { get; set; }
        public DateTime Completed_TS { get; set; }
        public DateTime? Cleared_Date_Time { get; set; }
        public short Delivery_Type { get; set; }
        public short Delivery_State { get; set; }
        public decimal Delivery_Volume { get; set; }
        public decimal? Delivery_Value { get; set; }
        public decimal? Del_Sell_Price { get; set; }
        public decimal? Del_Cost_Price { get; set; }
        public int? Cleared_By { get; set; }
        public int Reserved_By { get; set; }
        public int? Transaction_ID { get; set; }
        public int? Del_Item_Number { get; set; }
        public decimal? Delivery2_Volume { get; set; }
        public decimal? Hose_Meter_Volume { get; set; }
        public decimal? Hose_Meter_Value { get; set; }
        public bool? lImpreso { get; set; }
        public int? nId_Venta { get; set; }
        public decimal? nDelivery_Volume { get; set; }
        public decimal? nDelivery_Value { get; set; }
        public int? nGrades_Allocation { get; set; }
        public decimal? nPrecio { get; set; }
        public int? nID_Operacion { get; set; }
        public bool lPagado { get; set; }
        public DateTime? dFecha_Facturado { get; set; }
        public int nId_Factura { get; set; }
        public int nId_Tarjeta { get; set; }
        public decimal? yIEPS { get; set; }
        public decimal? yIEPS_Value { get; set; }
        public decimal? ySub_Total { get; set; }
        public decimal? yIVA { get; set; }
        public decimal? yTotal { get; set; }
        public decimal? yPrecio_Sin_IVA { get; set; }
        public int? nId_Corte_SAT { get; set; }
        public int? nGrade_ID { get; set; }
        public int? nPump_Id { get; set; }
        public int? nId_Autorizacion { get; set; }
        public decimal? nLts_Empieza { get; set; }
        public decimal? nLts_Termina { get; set; }
        public decimal? nMny_Empieza { get; set; }
        public decimal? nMny_Termina { get; set; }
        public decimal? nkilometraje_Anterior { get; set; }
        public decimal? nkilometraje_Empieza { get; set; }
        public decimal? nkilometraje_Termina { get; set; }
        public int? nId_Tarjeta_AutoConsumo { get; set; }
        public bool? lReset_oMny { get; set; }
        public bool? lReset_oLts { get; set; }
        public int? nId_Usuario { get; set; }
        public DateTime? dImpresion { get; set; }
        public int nId_Tarjeta_Corporativo { get; set; }
        public short nId_Tipo_Tarjeta { get; set; }
        public int? nId_Despachador { get; set; }
        public decimal? Hose_Meter_Volume2 { get; set; }
        public decimal? Hose_Meter_Value2 { get; set; }
        public decimal? Blend_Ratio { get; set; }
        public short Previous_Delivery_Type { get; set; }
        public int? Auth_Ref { get; set; }
        public decimal? Delivery1_Volume { get; set; }
        public decimal? Delivery1_Value { get; set; }
        public decimal? Delivery2_Value { get; set; }
        public decimal? Hose_Meter_Volume1 { get; set; }
        public decimal? Hose_Meter_Value1 { get; set; }
        public decimal? Grade1_Price { get; set; }
        public decimal? Grade2_Price { get; set; }
        public string? cWebID { get; set; }
        public int? nDespachoID { get; set; }
        public string? cHashMD5 { get; set; }
        public decimal? nTotalizador_Volumen_Volumen { get; set; }
        public decimal? nTotalizador_Volumen_Venta { get; set; }
        public decimal? nTotalizador_Venta_Volumen { get; set; }
        public decimal? nTotalizador_Venta_Venta { get; set; }
        public decimal? nIVATasa { get; set; }
        public int? nMarcaID { get; set; }
        public short nCRE_ProductoID { get; set; }
        public short nCRE_SubProductoID { get; set; }
        public short nOctanos { get; set; }

    }


}
