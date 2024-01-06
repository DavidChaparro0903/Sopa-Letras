--Creacion de base de datos 
CREATE DATABASE supermercado;

-- Usar la base de datos recién creada
USE supermercado;

-- Creacion de tablas

CREATE TABLE CLIENTES (
	CEDULA 		INT PRIMARY KEY,
    NOMBRE 		VARCHAR(255),
    TELEFONO 	VARCHAR(15) UNIQUE
);


CREATE TABLE PRODUCTOS (
    ID 		VARCHAR(15) PRIMARY KEY,
    NOMBRE  VARCHAR(255) UNIQUE,
    VALOR   INT
);


CREATE TABLE Factura (
    NO_FACTURA INT,
    CLIENTE INT,
    PRODUCTO VARCHAR(15)
    FOREIGN KEY (CLIENTE) REFERENCES Clientes(CEDULA),
    FOREIGN KEY (PRODUCTO) REFERENCES Productos(ID)
);


-- INSERTAR DATOS A LAS TABLAS
-- Insertar datos en la tabla Cliente
INSERT INTO Clientes(CEDULA, NOMBRE, TELEFONO) VALUES
(234567896, 'JUAN CASAS', '3102334567'),
(123983874, 'MARIA MESA', '3102334561'),
(298767639, 'JULIO COCINA', '3102334562'),
(98273646, 'ANDRES DIAS', '3102334563');

-- Insertar datos en la tabla Productos
INSERT INTO Productos (ID, NOMBRE, VALOR) VALUES
('P000000001', 'MEDIAS LARGAS', 15200),
('P000000002', 'MEDIAS CORTAS', 12400),
('P000000003', 'MEDIAS AZULES', 14100),
('P000000004', 'MEDIAS ROTAS', 10000);

-- Insertar datos en la tabla Factura
INSERT INTO Factura (NO_FACTURA, CLIENTE, PRODUCTO) VALUES
(1, '234567896', 'P000000002'),
(1, '234567896', 'P000000003'),
(2, '298767639', 'P000000001'),
(3, '098273646', 'P000000002'),
(3, '098273646', 'P000000004'),
(4, '234567896', 'P000000001'),
(4, '234567896', 'P000000002'),
(4, '234567896', 'P000000001');


--2.Realizar un query que liste todos los clientes, la cantidad de facturas 
-- a su nombre y el valor total de todas ellas.
SELECT
     C.CEDULA, 
	 C.NOMBRE, 
	 COUNT(F.NO_FACTURA) CANTIDAD_FACTURA,
	 ISNULL(SUM(p.VALOR),0) VALOR_TOTAL_FACTURAS
FROM
    CLIENTES c
LEFT JOIN
    Factura f ON c.CEDULA = f.CLIENTE
LEFT JOIN
    Productos p ON f.PRODUCTO = p.ID
GROUP BY
    c.CEDULA, c.NOMBRE
ORDER BY ISNULL(SUM(p.VALOR),0) DESC;

-- 3. Crear un procedimiento que reciba la identificación de cliente 
-- y retorne el artículo de mayor valor que este haya comprado y su valor.


CREATE PROCEDURE ObtenerArticuloMayorValor
    @ClienteId INT
AS
BEGIN
    SELECT TOP 1
        p.NOMBRE AS Articulo,
        p.VALOR AS Valor
    FROM
        Factura f
    INNER JOIN
        Productos p ON f.PRODUCTO = p.ID
    WHERE
        f.CLIENTE = @ClienteId
    ORDER BY
        p.VALOR DESC;
END;

EXEC ObtenerArticuloMayorValor @ClienteId = 298767639;
-- 4.	Realizar un query que liste 
--todos los clientes que no han hecho ninguna compra.


SELECT
    C.CEDULA,
	C.NOMBRE
FROM
    CLIENTES c
LEFT JOIN
    Factura f ON c.CEDULA = f.CLIENTE
LEFT JOIN
    Productos p ON f.PRODUCTO = p.ID
WHERE  f.NO_FACTURA IS NULL;

-- 5.Crear una función que reciba un texto 
-- (ej: “aut:11111|respuesta:Ok|recibo:33333333”) y 
-- el nombre de un campo (ef: “respuesta”),
-- esta función debe devolver el valor de este campo en el texto (ej: “Ok”)
DROP FUNCTION dbo.OBTENER_CAMPO;

CREATE FUNCTION OBTENER_CAMPO
(
    @texto NVARCHAR(MAX),
    @nombreCampo NVARCHAR(MAX)
)
RETURNS NVARCHAR(MAX)
AS
BEGIN
    DECLARE @inicio INT, @fin INT

    -- Buscar la posición del nombre del campo en el texto
    SET @inicio = CHARINDEX(@nombreCampo + ':', @texto)

    -- Si se encuentra el nombre del campo
    IF @inicio > 0
    BEGIN
        -- Calcular la posición del primer carácter después del nombre del campo
        SET @inicio = @inicio + LEN(@nombreCampo) + 1

        -- Buscar la posición del siguiente separador '|' a partir del inicio
        SET @fin = CHARINDEX('|', @texto, @inicio)

        -- Si se encuentra el siguiente separador
        IF @fin > 0
        BEGIN
            -- Extraer y devolver la subcadena entre el inicio y el fin
            RETURN SUBSTRING(@texto, @inicio, @fin - @inicio)
        END
        ELSE
        BEGIN
            -- Si no hay siguiente separador, devolver el resto del texto desde el inicio
            RETURN SUBSTRING(@texto, @inicio, LEN(@texto))
        END
    END
    ELSE
    BEGIN
        -- Si no se encuentra el nombre del campo, devolver NULL o un valor predeterminado según sea necesario
        RETURN 'NO ENCONTRADO'
    END
    RETURN NULL
END;

-- Pruebas
DECLARE @texto NVARCHAR(MAX) = 'aut:11111|respuesta:Ok|recibo:33333333'
DECLARE @nombreCampo NVARCHAR(MAX) = 'respuesta'

SELECT dbo.OBTENER_CAMPO(@texto, @nombreCampo) AS ValorCampo

