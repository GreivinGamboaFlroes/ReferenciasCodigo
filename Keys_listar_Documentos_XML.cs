DdatosList.Add("tipo_Documento", "Factura Electronica");
DdatosList.Add("ID_Cliente", claveFE.ID_Cliente.ToString());
DdatosList.Add("nombre_Cliente", claveFE.nombre_Cliente);
DdatosList.Add("ID_Factura", claveFE.ID_Factura.ToString());
DdatosList.Add("codigoInterno_Factura", claveFE.codigoInterno_Factura.ToString());
DdatosList.Add("total_Factura", claveFE.total_Factura.ToString());
DdatosList.Add("fecha_Factura", claveFE.fecha_Factura.ToString());
DdatosList.Add("Clave", claveFE.Clave);
DdatosList.Add("consecutivo_Clave", claveFE.consecutivo_ClaveFE_Factura);
DdatosList.Add("estadoFactura_Clave", claveFE.estadoFactura_ClaveFE_Factura);

/*EL value del key(tipo_Documento) puede ser (Factura Electronica o Tiquete Electronico)*/
