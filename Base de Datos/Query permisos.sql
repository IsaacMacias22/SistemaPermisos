CREATE DATABASE sistemapermisos;
USE sistemapermisos;

CREATE TABLE usuarios(
idusuario INT AUTO_INCREMENT PRIMARY KEY,
usuario VARCHAR(100) UNIQUE,
nombre VARCHAR(100),
apellidop VARCHAR(100),
apellidom VARCHAR(100),
fechanacimiento DATE,
rfc VARCHAR(20),
pwd VARCHAR(100)
);

CREATE TABLE modulos(
idmodulo INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(100)
);

CREATE TABLE permisos(
fkidusuario INT,
fkidmodulo INT,
permisoAcceso BOOL,
permisoLectura BOOL,
permisoEscritura BOOL,
permisoEliminacion BOOL,
permisoActualizacion BOOL,	
PRIMARY KEY(fkidusuario, fkidmodulo),
FOREIGN KEY(fkidusuario) REFERENCES usuarios(idusuario),
FOREIGN KEY(fkidmodulo) REFERENCES modulos(idmodulo)
); 

CREATE TABLE productos(
codigobarras VARCHAR(100) PRIMARY KEY,
nombre VARCHAR(100),
descripcion VARCHAR(100),
marca VARCHAR(100)
);

CREATE TABLE herramientas(
codigoherramienta VARCHAR(100) PRIMARY KEY,
nombre VARCHAR(100),
medida VARCHAR(100),
marca VARCHAR(100),
descripcion VARCHAR(100)
);

/* Procedimientos almacenados */
delimiter ;;
DROP PROCEDURE if EXISTS p_insertOrUpdateUsuario;
CREATE PROCEDURE p_insertOrUpdateUsuario(
IN p_idusuario INT,
IN p_usuario VARCHAR(100),
IN p_nombre VARCHAR(100),
IN p_apellidop VARCHAR(100),
IN p_apellidom VARCHAR(100),
IN p_fechanacimiento DATE,
IN p_rfc VARCHAR(20),
IN p_pwd VARCHAR(100)
)
BEGIN
	DECLARE X INT;
	SELECT COUNT(*) FROM usuarios WHERE usuario = p_usuario INTO X;
	if X = 0 AND p_idusuario < 0 then
		INSERT INTO usuarios VALUES(NULL, p_usuario, p_nombre, p_apellidop, p_apellidom, p_fechanacimiento, p_rfc, p_pwd);
	ELSE if X = 0 AND p_idusuario > 0 then
		UPDATE usuarios SET usuario = p_usuario, nombre = p_nombre, apellidop = p_apellidop, apellidom = p_apellidom,
		fechanacimiento = p_fechanacimiento, rfc = p_rfc, pwd = p_pwd
		WHERE idusuario = p_idusuario;
	ELSE
		UPDATE usuarios SET nombre = p_nombre, apellidop = p_apellidop, apellidom = p_apellidom,
		fechanacimiento = p_fechanacimiento, rfc = p_rfc, pwd = p_pwd
		WHERE idusuario = p_idusuario;
	END if;
	END if;
END;;

CALL p_insertOrUpdateUsuario(-1, 'Administrador', 'Earvin', 'Macías', 'Rodríguez', '2022-09-22', 'MARE020922HJ', '12345');
SELECT * FROM usuarios;

delimiter ;;
DROP PROCEDURE if EXISTS p_deleteUsuarios;
CREATE PROCEDURE p_deleteUsuarios(
IN p_idusuario INT	
)
BEGIN
	DELETE FROM usuarios WHERE idusuario = p_idusuario;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS p_showUsuarios;
CREATE PROCEDURE p_showUsuarios(
IN p_filtro VARCHAR(100)
)
BEGIN	
	SELECT * FROM usuarios 
	WHERE usuario LIKE p_filtro
	OR nombre LIKE p_filtro
	OR apellidop LIKE p_filtro
	OR apellidom LIKE p_filtro
	OR fechanacimiento LIKE p_filtro
	OR rfc LIKE p_filtro;
END;;

CALL p_showUsuarios('%%');


delimiter ;;
DROP PROCEDURE if EXISTS p_insertOrUpdatePermisos;
CREATE PROCEDURE p_insertOrUpdatePermisos(
IN p_fkidusuario INT,
IN p_fkidmodulo INT,
IN p_permisoAcceso BOOL,
IN p_permisoLectura BOOL,
IN p_permisoEscritura BOOL,
IN p_permisoEliminacion BOOL,
IN p_permisoActualizacion BOOL
)
BEGIN	
	DECLARE X INT;
	SELECT COUNT(*) FROM permisos WHERE fkidusuario = p_fkidusuario AND fkidmodulo = p_fkidmodulo INTO X;
	if X = 0 then
		INSERT INTO permisos VALUES
		(p_fkidusuario, p_fkidmodulo, p_permisoAcceso, p_permisoLectura, p_permisoEscritura, p_permisoEliminacion, p_permisoActualizacion);
	ELSE if X > 0 then
		UPDATE permisos SET 
		permisoAcceso = p_permisoAcceso,
		permisoLectura = p_permisoLectura,
		permisoEscritura = p_permisoEscritura,
		permisoEliminacion = p_permisoEliminacion,
		permisoActualizacion = p_permisoActualizacion
		WHERE	fkidusuario = p_fkidusuario AND fkidmodulo = p_fkidmodulo;
	END if;
	END if;
END;;

INSERT INTO modulos VALUES(NULL, 'Refacciones'), (NULL, 'Taller');
SELECT * FROM modulos;

CALL p_insertOrUpdatePermisos(1, 1, TRUE, TRUE, TRUE, TRUE, TRUE);
CALL p_insertOrUpdatePermisos(1, 2, TRUE, TRUE, TRUE, TRUE, TRUE);
SELECT * FROM permisos;

delimiter ;;
DROP PROCEDURE if EXISTS p_showPermisos;
CREATE PROCEDURE p_showPermisos(
IN p_filtro VARCHAR(100)
)
BEGIN	
	SELECT us.idusuario, mo.idmodulo, us.usuario, mo.nombre AS modulo, pe.permisoAcceso, pe.permisoLectura, pe.permisoEscritura, pe.permisoEliminacion, pe.permisoActualizacion
	 FROM permisos pe, usuarios us, modulos mo
	 WHERE us.idusuario = pe.fkidusuario AND mo.idmodulo = pe.fkidmodulo
	 AND us.usuario LIKE p_filtro;
END;;

CALL p_showPermisos('%%');

delimiter ;;
DROP PROCEDURE if EXISTS p_insertOrUpdateProductos;
CREATE PROCEDURE p_insertOrUpdateProductos(
IN p_codigobarras VARCHAR(100),
IN p_nombre VARCHAR(100),
IN p_descripcion VARCHAR(100),
IN p_marca VARCHAR(100)
)
BEGIN	
	DECLARE X INT;
	SELECT COUNT(*) FROM productos WHERE codigoBarras = p_codigoBarras INTO X;
	if X = 0 then
		INSERT INTO productos VALUES(p_codigobarras, p_nombre, p_descripcion, p_marca);
	ELSE if X > 0 then
		UPDATE productos SET nombre = p_nombre, descripcion = p_descripcion, marca = p_marca
		WHERE codigobarras = p_codigobarras;
	END if;
	END if;
END;;

CALL p_insertOrUpdateProductos('0101abc', 'Volante BMW', 'Volante deportivo para calle', 'BMW');
CALL p_insertOrUpdateProductos('0101abc', 'Volante BMW', 'Volante deportivo', 'BMW');
SELECT * FROM productos;

delimiter ;;
DROP PROCEDURE if EXISTS p_deleteProductos;
CREATE PROCEDURE p_deleteProductos(
IN p_codigobarras VARCHAR(100)
)
BEGIN	
	DELETE FROM productos WHERE codigobarras = p_codigobarras;
END;;

CALL p_deleteProductos('0101abc');
SELECT * FROM productos;

delimiter ;;
DROP PROCEDURE if EXISTS p_showProductos;
CREATE PROCEDURE p_showProductos(
IN p_filtro VARCHAR(100)
)
BEGIN	
	SELECT * FROM productos WHERE 
	codigobarras LIKE p_filtro
	OR nombre LIKE p_filtro
	OR descripcion LIKE p_filtro
	OR marca LIKE p_filtro;
END;;

CALL p_showProductos('%%');

delimiter ;;
DROP PROCEDURE if EXISTS p_insertOrUpdateHerramientas;
CREATE PROCEDURE p_insertOrUpdateHerramientas(
IN p_codigoherramienta VARCHAR(100),
IN p_nombre VARCHAR(100),
IN p_medida VARCHAR(100),
IN p_marca VARCHAR(100),
IN p_descripcion VARCHAR(100)
)
BEGIN
	DECLARE X INT;
	SELECT COUNT(*) FROM herramientas WHERE codigoherramienta = p_codigoherramienta INTO X;
	if X = 0 then
		INSERT INTO herramientas VALUES(p_codigoherramienta, p_nombre, p_medida, p_marca, p_descripcion);
	ELSE if X > 0 then
		UPDATE herramientas SET nombre = p_nombre, medida = p_medida, marca = p_marca,
		descripcion = p_descripcion WHERE codigoherramienta = p_codigoherramienta;
	END if;
	END if;
END;;

CALL p_insertOrUpdateHerramientas('L-01', 'Llave inglesa', '30 cm', 'Truper', 'Llave inglesa multiusos');
SELECT * FROM herramientas;

delimiter ;;
DROP PROCEDURE if EXISTS p_deleteHerramientas;
CREATE PROCEDURE p_deleteHerramientas(
IN p_codigoherramienta VARCHAR(100)
)
BEGIN
	DELETE FROM herramientas WHERE codigoherramienta = p_codigoherramienta;
END;;

CALL p_deleteHerramientas('L-01');
SELECT * FROM herramientas;

delimiter ;;
DROP PROCEDURE if EXISTS p_showHerramientas;
CREATE PROCEDURE p_showHerramientas(
IN p_filtro VARCHAR(100)
)
BEGIN	
	SELECT * FROM herramientas WHERE codigoherramienta LIKE p_filtro
	OR nombre LIKE p_filtro OR medida LIKE p_filtro OR marca LIKE p_filtro
	OR descripcion LIKE p_filtro;
END;;

CALL p_showHerramientas('%%');
SELECT * FROM usuarios;