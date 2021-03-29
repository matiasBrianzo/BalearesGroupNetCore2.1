/*2) Escribir una consulta SQL para listar el importe total facturado por item con las siguientes características
    a) debe mostrar las columnas nombre del item y el importe total facturado (agrupado por nombre del item)
    b) debe mostrar todos los items de la tabla ITEM incluyendo los que no se usaron en ninguna factura.
    c) debe excluir los items para los cuales el total facturado suma mas de 500.
*/

--a) debe mostrar las columnas nombre del item y el importe total facturado (agrupado por nombre del item)

select ITEM.nombre, FACTURA_DETALLE.precio_unitario_facturado from ITEM 
INNER join Factura_detalle on ITEM.id_item = Factura_detalle.id_item
group by  ITEM.nombre,FACTURA_DETALLE.precio_unitario_facturado
 

 -- b) debe mostrar todos los items de la tabla ITEM incluyendo los que no se usaron en ninguna factura.

 select ITEM.nombre, FACTURA_DETALLE.precio_unitario_facturado from ITEM 
left join Factura_detalle on ITEM.id_item = Factura_detalle.id_item

-- c) debe excluir los items para los cuales el total facturado suma mas de 500.


select * from ITEM
where id_item in(
		select FACTURA_DETALLE.id_item from FACTURA_DETALLE
		Group BY FACTURA_DETALLE.id_item
		HAVING SUM(FACTURA_DETALLE.precio_unitario_facturado) > 500)

