/*3) Escribir una consulta SQL que devuelva un listado de los clientes que no tienen facturas asociadas. 
Además incluir un campo que segun si el CLIENTE.id_pais es 1 muestre "Argentina", 
en caso contrario que muestre "Extranjero".*/


 select CLIENTE.nombre,case CLIENTE.id_pais when 1 then 'Argentina'  END from CLIENTE
 left join FACTURA on CLIENTE.id_cliente= FACTURA.id_cliente
 WHERE FACTURA.id_cliente IS NULL