/*1) Escribir una consulta SQL para listar las facturas por cliente con las siguientes características
    a) debe mostrar las columnas CLIENTE.nombre, FACTURA.numero y FACTURA.fecha 
    b) incluir solo las facturas realizadas en el año en curso
    c) ordenar el resultado por nombre de cliente y numero de factura
 */

 --a) debe mostrar las columnas CLIENTE.nombre, FACTURA.numero y FACTURA.fecha 

 select CLIENTE.nombre,FACTURA.numero , FACTURA.fecha  from CLIENTE
 INNER join FACTURA on CLIENTE.id_cliente= FACTURA.id_cliente

 --  b) incluir solo las facturas realizadas en el año en curso

		 select * from FACTURA
		 WHERE fecha BETWEEN '2021-01-01' AND '2022-12-31';

 --c) ordenar el resultado por nombre de cliente y numero de factura 

	  select CLIENTE.nombre,FACTURA.numero  from CLIENTE
	 INNER join FACTURA on CLIENTE.id_cliente= FACTURA.id_cliente
	order by 1 asc


   