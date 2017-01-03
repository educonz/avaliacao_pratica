--1
SELECT *
  FROM TB_VIAGEM 
 WHERE DTINICIO > '2016-08-10'
   AND CDPEDIDO IS NOT NULL
  
--2
	SELECT V.CDPLACAVEICULO, 
		   U.NMUNIDADENEGOCIO
	  FROM TB_UNIDADE_NEGOCIO U
INNER JOIN TB_VEICULO 		  V ON U.CDUNIDADENEGOCIO = V.CDUNIDADENEGOCIO

--3
UPDATE TB_VIAGEM 
   SET DTFIM = GETDATE() 
 WHERE CDVIAGEM = 269802
 
--4
  SELECT TOP 10 *
	FROM TB_VIAGEM 
   WHERE DTINICIO > '2016-08-10'
	 AND CDPEDIDO IS NOT NULL
ORDER BY DTINICIO DESC

--5
  SELECT COUNT(*) QTCLIENTESBAR
    FROM TB_CLIENTE
   WHERE UPPER(NMCLIENTE) LIKE '%BAR%'