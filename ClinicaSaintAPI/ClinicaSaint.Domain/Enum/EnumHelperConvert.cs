//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClinicaSaint.Domain.Enum
//{
//    public static class EnumHelperConvert
//    {

//        #region Tamaño Carreta
//        public static string TamañoCarretaConvertString(this TamañoCarreta enumData)
//        {
//            return enumData switch
//            {
//                TamañoCarreta.Pies20 => "20",
//                TamañoCarreta.Pies40 => "40",
//                _ => ""
//            };
//        }

//        public static TamañoCarreta TamañoCarretaConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "20" => TamañoCarreta.Pies20,
//                "40" => TamañoCarreta.Pies40,
//                _ => throw new Exception($"No existe el tipo de conversión para TamañoCarreta {enumString}")
//            };
//        }

//        #endregion

//        #region Terminal
//        public static string TerminalEnumConvertString(this TerminalEnum enumData)
//        {
//            return enumData switch
//            {
//                TerminalEnum.Portuario => "PORT",
//                TerminalEnum.Extraportuario => "EXPO",
//                _ => ""
//            };
//        }

//        public static TerminalEnum TerminalEnumConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "PORT" => TerminalEnum.Portuario,
//                "EXPO" => TerminalEnum.Extraportuario,
//                _ => throw new Exception($"No existe el tipo de conversión para Terminal {enumString}")
//            };
//        }

//        #endregion

//        #region Tipo Geocerca
//        public static string TipoGeocercaEnumConvertString(this GeocercalEnum enumData)
//        {
//            return enumData switch
//            {
//                GeocercalEnum.Circular => "CIRC",
//                GeocercalEnum.Poligonal => "POLI",
//                GeocercalEnum.Libre => "LIBR",
//                _ => ""
//            };
//        }

//        public static GeocercalEnum TipoGeocercConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "CIRC" => GeocercalEnum.Circular,
//                "POLI" => GeocercalEnum.Poligonal,
//                "LIBR" => GeocercalEnum.Libre,
//                _ => throw new Exception($"No existe el tipo de conversión {enumString}")
//            };
//        }

//        #endregion

//        #region Rutas
//        public static string RUTASEnumConvertString(this EstadoRutas enumData)
//        {
//            return enumData switch
//            {
//                EstadoRutas.Activa => "ACt",
//                EstadoRutas.No_Activa => "NAC",
//                _ => ""
//            };
//        }

//        public static EstadoRutas RUTASConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "ACt" => EstadoRutas.Activa,
//                "NAC" => EstadoRutas.No_Activa,
//                _ => throw new Exception($"No existe el tipo de conversión {enumString}")
//            };
//        }

//        #endregion

//        #region TipoIdentificacion
//        public static string EnumConvertString(this TipoIdentificacion enumData)
//        {
//            return enumData switch
//            {
//                TipoIdentificacion.Dni => "DNI",
//                TipoIdentificacion.Ruc => "RUC",
//                TipoIdentificacion.Pasaporte => "PASS",
//                _ => ""
//            };
//        }

//        public static TipoIdentificacion TipoIdentificacionConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "DNI" => TipoIdentificacion.Dni,
//                "RUC" => TipoIdentificacion.Ruc,
//                "PASS" => TipoIdentificacion.Pasaporte,
//                _ => throw new Exception($"No existe el tipo de conversión para TipoIdentificacion {enumString}")
//            };
//        }
//        #endregion

//        #region Tipo Combustible
//        public static string TipoCombustibleEnumConvertString(this TipoCombustible enumData)
//        {
//            return enumData switch
//            {
//                TipoCombustible.Gasolina => "GASO",
//                TipoCombustible.Diesel => "DIES",
//                _ => ""
//            };
//        }

//        public static TipoCombustible TipoCombustibleConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "GASO" => TipoCombustible.Gasolina,
//                "DIES" => TipoCombustible.Diesel,
//                _ => throw new Exception($"No existe el tipo de conversión {enumString}")
//            };
//        }
//        #endregion

//        #region EstadoReservasSolicitud

//        public const string SOLICITUD_INGRESADO = "INGR";
//        public const string SOLICITUD_APROBADO = "APRO";
//        public const string SOLICITUD_RECHAZADO = "RECH";
//        public const string SOLICITUD_CANCELADO = "CANC";
//        public static string EstadoReservasSolicitudEnumConvertString(this EstadoReservasSolicitudEnum enumData)
//        {
//            return enumData switch
//            {
//                EstadoReservasSolicitudEnum.Ingresado => SOLICITUD_INGRESADO,
//                EstadoReservasSolicitudEnum.Aprobado => SOLICITUD_APROBADO,
//                EstadoReservasSolicitudEnum.Rechazado => SOLICITUD_RECHAZADO,
//                EstadoReservasSolicitudEnum.Cancelado => SOLICITUD_CANCELADO,
//                _ => ""
//            };
//        }

//        public static EstadoReservasSolicitudEnum EstadoReservaSolicitudConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                SOLICITUD_INGRESADO => EstadoReservasSolicitudEnum.Ingresado,
//                SOLICITUD_APROBADO => EstadoReservasSolicitudEnum.Aprobado,
//                SOLICITUD_RECHAZADO => EstadoReservasSolicitudEnum.Rechazado,
//                SOLICITUD_CANCELADO => EstadoReservasSolicitudEnum.Cancelado,
//                _ => throw new Exception($"No existe el tipo de conversión  para EstadoReserva {enumString}")
//            };
//        }

//        public const string SOLICITUD_INGRESADOSTRING = "INGRESADO";
//        public const string SOLICITUD_APROBADOSTRING = "APROVADO";
//        public const string SOLICITUD_RECHAZADOSTRING = "RECHAZADO";
//        public const string SOLICITUD_CANCELADOSTRING = "CANCELADO";
//        public static string EstadoReservaSolicitudConvertString(string enumString)
//        {
//            return enumString switch
//            {
//                SOLICITUD_INGRESADO => SOLICITUD_INGRESADOSTRING,
//                SOLICITUD_APROBADO => SOLICITUD_APROBADOSTRING,
//                SOLICITUD_RECHAZADO => SOLICITUD_RECHAZADOSTRING,
//                SOLICITUD_CANCELADO => SOLICITUD_CANCELADOSTRING,
//                _ => throw new Exception($"No existe el tipo de conversión para EstadoReserva {enumString}")
//            };
//        }
//        #endregion


//        #region EstadoReserva

//        public const string RESERVAS_INGRESADO = "INGR";
//        public const string RESERVAS_ENPROCESO = "ENPRO";
//        public const string RESERVAS_FINALIZADO = "FINA";
//        public const string RESERVAS_CANCELADO = "CANC";
//        public const string RESERVAS_LISTOFACTURAR = "OKFACT";
//        public static string EstadoReservaEnumConvertString(this EstadoReservaEnum enumData)
//        {
//            return enumData switch
//            {
//                EstadoReservaEnum.Ingresado => RESERVAS_INGRESADO,
//                EstadoReservaEnum.Enproceso => RESERVAS_ENPROCESO,
//                EstadoReservaEnum.Finalizado => RESERVAS_FINALIZADO,
//                EstadoReservaEnum.Cancelado => RESERVAS_CANCELADO,
//                EstadoReservaEnum.Listofacturar => RESERVAS_LISTOFACTURAR,
//                _ => ""
//            };
//        }
        
//        public static EstadoReservaEnum EstadoReservaConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                RESERVAS_INGRESADO => EstadoReservaEnum.Ingresado,
//                RESERVAS_ENPROCESO => EstadoReservaEnum.Enproceso,
//                RESERVAS_FINALIZADO => EstadoReservaEnum.Finalizado,
//                RESERVAS_CANCELADO => EstadoReservaEnum.Cancelado,
//                RESERVAS_LISTOFACTURAR => EstadoReservaEnum.Listofacturar,

//                _ => throw new Exception($"No existe el tipo de conversión  para EstadoReserva {enumString}")
//            };
//        }
      

//        public const string RESERVAS_INGRESADOSTRING = "INGRESADO";
//        public const string RESERVAS_ENPROCESOSTRING = "ENPROCESO";
//        public const string RESERVAS_FINALIZADOSTRING = "FINALIZADO";
//        public const string RESERVAS_CANCELADOSTRING = "CANCELADO";
//        public const string RESERVAS_LISTOFACTURARSTRING = "LISTOFACTURAR ";

//        public static string EstadoReservaConvertString(string enumString)
//        {
//            return enumString switch
//            {
//                RESERVAS_INGRESADO => RESERVAS_INGRESADOSTRING,
//                RESERVAS_ENPROCESO => RESERVAS_ENPROCESOSTRING,
//                RESERVAS_FINALIZADO => RESERVAS_FINALIZADOSTRING,
//                RESERVAS_CANCELADO => RESERVAS_CANCELADOSTRING,
//                RESERVAS_LISTOFACTURAR => RESERVAS_LISTOFACTURARSTRING,

//                _ => throw new Exception($"No existe el tipo de conversión para EstadoReserva {enumString}")
//            };
//        }
//        #endregion

//        #region EstadoReservaCONTENEDORES

//        public const string RESERVAS_CONTENEDORES_INGRESADO = "INGR";
//        public const string RESERVAS_CONTENEDORES_ASIGNADOS = "ASIG";
//        public const string RESERVAS_CONTENEDORES_ENPROCESO = "ENPRO";
//        public const string RESERVAS_CONTENEDORES_FINALIZADO = "FINA";
//        public const string RESERVAS_CONTENEDORES_CANCELADO = "CANC";
//        public const string RESERVAS_CONTENEDORES_LISTOFACTURAR = "OKFACT";
//        public static string EstadoReservaContenedoresEnumConvertString(this EstadoReservaContenedoresEnum enumData)
//        {
//            return enumData switch
//            {
//                EstadoReservaContenedoresEnum.Ingresado => RESERVAS_CONTENEDORES_INGRESADO,
//                EstadoReservaContenedoresEnum.Asignado => RESERVAS_CONTENEDORES_ASIGNADOS,
//                EstadoReservaContenedoresEnum.Enproceso => RESERVAS_CONTENEDORES_ENPROCESO,
//                EstadoReservaContenedoresEnum.Finalizado => RESERVAS_CONTENEDORES_FINALIZADO,
//                EstadoReservaContenedoresEnum.Cancelado => RESERVAS_CONTENEDORES_CANCELADO,
//                EstadoReservaContenedoresEnum.Listofacturar => RESERVAS_CONTENEDORES_LISTOFACTURAR,
//                _ => ""
//            };
//        }
        
//        public static EstadoReservaContenedoresEnum EstadoReservaContenedoresConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                RESERVAS_CONTENEDORES_INGRESADO => EstadoReservaContenedoresEnum.Ingresado,
//                RESERVAS_CONTENEDORES_ASIGNADOS => EstadoReservaContenedoresEnum.Asignado,
//                RESERVAS_CONTENEDORES_ENPROCESO => EstadoReservaContenedoresEnum.Enproceso,
//                RESERVAS_CONTENEDORES_FINALIZADO => EstadoReservaContenedoresEnum.Finalizado,
//                RESERVAS_CONTENEDORES_CANCELADO => EstadoReservaContenedoresEnum.Cancelado,
//                RESERVAS_CONTENEDORES_LISTOFACTURAR => EstadoReservaContenedoresEnum.Listofacturar,

//                _ => throw new Exception($"No existe el tipo de conversión  para EstadoReservaContenedores {enumString}")
//            };
//        }


//        public const string RESERVAS_CONTENEDORES_INGRESADOSTRING = "INGRESADO";
//        public const string RESERVAS_CONTENEDORES_ASIGNADOSTRING = "ASIGNADO";
//        public const string RESERVAS_CONTENEDORES_ENPROCESOSTRING = "ENPROCESO";
//        public const string RESERVAS_CONTENEDORES_FINALIZADOSTRING = "FINALIZADO";
//        public const string RESERVAS_CONTENEDORES_CANCELADOSTRING = "CANCELADO";
//        public const string RESERVAS_CONTENEDORES_LISTOFACTURARSTRING = "LISTOFACTURAR ";

//        public static string EstadoReservaContenedoresConvertString(string enumString)
//        {
//            return enumString switch
//            {
//                RESERVAS_CONTENEDORES_INGRESADO => RESERVAS_CONTENEDORES_INGRESADOSTRING,
//                RESERVAS_CONTENEDORES_ASIGNADOS => RESERVAS_CONTENEDORES_ASIGNADOSTRING,
//                RESERVAS_CONTENEDORES_ENPROCESO => RESERVAS_CONTENEDORES_ENPROCESOSTRING,
//                RESERVAS_CONTENEDORES_FINALIZADO => RESERVAS_CONTENEDORES_FINALIZADOSTRING,
//                RESERVAS_CONTENEDORES_CANCELADO => RESERVAS_CONTENEDORES_CANCELADOSTRING,
//                RESERVAS_CONTENEDORES_LISTOFACTURAR => RESERVAS_CONTENEDORES_LISTOFACTURARSTRING,

//                _ => throw new Exception($"No existe el tipo de conversión para EstadoReserva {enumString}")
//            };
//        }
//        #endregion

//        #region EstadoReservaDoumento

//        public const string RESERVAS_NOCARGADO = "NOCARGADO";
//        public const string RESERVAS_CARGADO = "CARG";
//        public const string RESERVAS_PENDIENTE = "PEND";
//        public const string RESERVAS_VALIDADO = "VALI";

//        public static string EstadoReservadDocEnumConvertString(this EstadoResDocEnum enumData)
//        {
//            return enumData switch
//            {
//                EstadoResDocEnum.NoCargado => RESERVAS_NOCARGADO,
//                EstadoResDocEnum.Cargado => RESERVAS_CARGADO,
//                EstadoResDocEnum.Pendiente => RESERVAS_PENDIENTE,
//                EstadoResDocEnum.Validado => RESERVAS_VALIDADO,
//                _ => ""
//            };
//        }

//        public static EstadoResDocEnum EstadoReservaDocConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                RESERVAS_NOCARGADO => EstadoResDocEnum.NoCargado,
//                RESERVAS_CARGADO => EstadoResDocEnum.Cargado,
//                RESERVAS_PENDIENTE => EstadoResDocEnum.Pendiente,
//                RESERVAS_VALIDADO => EstadoResDocEnum.Validado,
//                _ => throw new Exception($"No existe el tipo de conversión  para EstadoReservaDocumento {enumString}")
//            };
//        }
//        #endregion

//        #region EstadoNovedadViaje

//        public const string EstadoNovedad_Registrada        = "Registrada";
//        public const string EstadoNovedad_EnAnalisis        = "EnAnalisis";
//        public const string EstadoNovedad_Solucionencurso   = "Solucionencurso";
//        public const string EstadoNovedad_Resuelta          = "Resuelta";
//        public const string EstadoNovedad_Descartada        = "Descartada";
//        public static string EstadoNovedadViajeEnumConvertString(this EstadoNovedadViaje enumData)
//        {
//            return enumData switch
//            {
//                EstadoNovedadViaje.Registrada => EstadoNovedad_Registrada,
//                EstadoNovedadViaje.EnAnalisis => EstadoNovedad_EnAnalisis,
//                EstadoNovedadViaje.Solucionencurso => EstadoNovedad_Solucionencurso,
//                EstadoNovedadViaje.Resuelta => EstadoNovedad_Resuelta,
//                EstadoNovedadViaje.Descartada => EstadoNovedad_Descartada,
//                _ => ""
//            };
//        }
//        public static EstadoNovedadViaje EstadoNovedadViajeConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                EstadoNovedad_Registrada => EstadoNovedadViaje.Registrada,
//                EstadoNovedad_EnAnalisis => EstadoNovedadViaje.EnAnalisis,
//                EstadoNovedad_Solucionencurso => EstadoNovedadViaje.Solucionencurso,
//                EstadoNovedad_Resuelta => EstadoNovedadViaje.Resuelta,
//                EstadoNovedad_Descartada => EstadoNovedadViaje.Descartada,
//                _ => throw new Exception($"No existe el tipo de conversión  para EstadoNovedadViaje {enumString}")
//            };
//        }
//        #endregion

//        #region EstadoReservaDetalleViaje

//        public const string EstadoReservaDetalleViaje_Ingresado              = "Ingresado";
//        public const string EstadoReservaDetalleViaje_Asignado               = "Asignado";
//        public const string EstadoReservaDetalleViaje_PorIniciar             = "PorIniciar";
//        public const string EstadoReservaDetalleViaje_EnRuta                 = "EnRuta";
//        public const string EstadoReservaDetalleViaje_PuntoDeCarga_Descarga  = "PuntoDeCarga_Descarga";
//        public const string EstadoReservaDetalleViaje_InicioDeCarga_Descarga = "InicioDeCarga_Descarga";
//        public const string EstadoReservaDetalleViaje_FinDeCarga_Descarga    = "FinDeCarga_Descarga";
//        public static string EstadoReservaDetalleViajeEnumConvertString(this EstadoReservaDetalleViajeEnum enumData)
//        {
//            return enumData switch
//            {
//                EstadoReservaDetalleViajeEnum.Ingresado               => EstadoReservaDetalleViaje_Ingresado              ,
//                EstadoReservaDetalleViajeEnum.Asignado                => EstadoReservaDetalleViaje_Asignado               ,
//                EstadoReservaDetalleViajeEnum.PorIniciar              => EstadoReservaDetalleViaje_PorIniciar             ,
//                EstadoReservaDetalleViajeEnum.EnRuta                  => EstadoReservaDetalleViaje_EnRuta                 ,
//                EstadoReservaDetalleViajeEnum.PuntoDeCarga_Descarga   => EstadoReservaDetalleViaje_PuntoDeCarga_Descarga  ,
//                EstadoReservaDetalleViajeEnum.InicioDeCarga_Descarga  => EstadoReservaDetalleViaje_InicioDeCarga_Descarga ,
//                EstadoReservaDetalleViajeEnum.FinDeCarga_Descarga     => EstadoReservaDetalleViaje_FinDeCarga_Descarga    ,
//                _ => ""
//            };
//        }
//        public static EstadoReservaDetalleViajeEnum EstadoReservaDetalleViajeConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                EstadoReservaDetalleViaje_Ingresado              => EstadoReservaDetalleViajeEnum.Ingresado               ,
//                EstadoReservaDetalleViaje_Asignado               => EstadoReservaDetalleViajeEnum.Asignado                ,
//                EstadoReservaDetalleViaje_PorIniciar             => EstadoReservaDetalleViajeEnum.PorIniciar              ,
//                EstadoReservaDetalleViaje_EnRuta                 => EstadoReservaDetalleViajeEnum.EnRuta                  ,
//                EstadoReservaDetalleViaje_PuntoDeCarga_Descarga  => EstadoReservaDetalleViajeEnum.PuntoDeCarga_Descarga   ,
//                EstadoReservaDetalleViaje_InicioDeCarga_Descarga => EstadoReservaDetalleViajeEnum.InicioDeCarga_Descarga  ,
//                EstadoReservaDetalleViaje_FinDeCarga_Descarga    => EstadoReservaDetalleViajeEnum.FinDeCarga_Descarga,
//                _ => throw new Exception($"No existe el tipo de conversión  para EstadoNovedadViaje {enumString}")
//            };
//        }
//        #endregion

//        #region Formato imagen
//        public static string TipoArchivoConvertString(this TipoArchivo enumData)
//        {
//            return enumData switch
//            {
//                TipoArchivo.JPG => "JPG",
//                TipoArchivo.JPEG => "JPEG",
//                TipoArchivo.PNG => "PNG",
//                TipoArchivo.GIF => "GIF",
//                TipoArchivo.BMP => "BMP",

//                TipoArchivo.TXT => "TXT",
//                TipoArchivo.DOCX => "DOCX",
//                TipoArchivo.PDF => "PDF",
//                TipoArchivo.ODT => "ODT",
//                TipoArchivo.XLSX => "XLSX",
//                TipoArchivo.CSV => "CSV",
//                TipoArchivo.ODS => "ODS",
//                _ => ""
//            };
//        }

//        public static TipoArchivo TipoArchivoConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "JPG" => TipoArchivo.JPG,
//                "JPEG" => TipoArchivo.JPEG,
//                "PNG" => TipoArchivo.PNG,
//                "GIF" => TipoArchivo.GIF,
//                "BMP" => TipoArchivo.BMP,

//                "TXT" => TipoArchivo.TXT,
//                "DOCX" => TipoArchivo.DOCX,
//                "PDF" => TipoArchivo.PDF,
//                "ODT" => TipoArchivo.ODT,
//                "XLSX" => TipoArchivo.XLSX,
//                "ODS" => TipoArchivo.ODS,
//                _ => throw new Exception($"No existe el tipo de conversión para TipoArchivo {enumString}")
//            };
//        }
//        #endregion

//        #region Tipo Valor
//        public static string TipoValorConvertString(this TipoValorEnum enumData)
//        {
//            return enumData switch
//            {
//                TipoValorEnum.Texto => "TE",
//                TipoValorEnum.Entero => "EN",
//                TipoValorEnum.Decimal => "DE",
//                TipoValorEnum.Booleano => "BO",
//                TipoValorEnum.Fecha => "DA",
//                _ => ""
//            };
//        }

//        public static TipoValorEnum TipoValorConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "TE" => TipoValorEnum.Texto,
//                "EN" => TipoValorEnum.Entero,
//                "DE" => TipoValorEnum.Decimal,
//                "BO" => TipoValorEnum.Booleano,
//                "FE" => TipoValorEnum.Fecha,
//                _ => throw new Exception($"No existe el tipo de conversión {enumString}")
//            };
//        }
//        #endregion

//        #region Tipo Contenido
//        public static string TipoContenidoConvertString(this TipoContenidoEnum enumData)
//        {
//            return enumData switch
//            {
//                TipoContenidoEnum.Full => "FULL",
//                TipoContenidoEnum.Empty => "EMPTY",
//                _ => ""
//            };
//        }

//        public static TipoContenidoEnum TipoContenidoConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "FULL" => TipoContenidoEnum.Full,
//                "EMPTY" => TipoContenidoEnum.Empty,
//                _ => throw new Exception($"No existe el tipo de conversión para TipoContenido {enumString}")
//            };
//        }
//        #endregion

//        #region Tipo Entrega
//        public static string TipoEntregaConvertString(this TipoEntregaEnum enumData)
//        {
//            return enumData switch
//            {
//                TipoEntregaEnum.Door => "DOOR",
//                TipoEntregaEnum.Yard => "YARD",
//                _ => ""
//            };
//        }

//        public static TipoEntregaEnum TipoEntregaConvertEnum(string enumString)
//        {
//            return enumString switch
//            {
//                "DOOR" => TipoEntregaEnum.Door,
//                "YARD" => TipoEntregaEnum.Yard,
//                _ => throw new Exception($"No existe el tipo de conversión para TipoEntrega {enumString}")
//            };
//        }
//        #endregion
//    }
//}