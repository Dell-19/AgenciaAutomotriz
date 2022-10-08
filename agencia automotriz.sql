create DATABASE agenciaAutomotriz;
USE agenciaAutomotriz;

CREATE TABLE usuarios(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(100),
apellidop VARCHAR(100),
apellidom VARCHAR(100),
fdn VARCHAR(30),
rfc VARCHAR(13));

CREATE TABLE productos(
idproducto INT PRIMARY KEY AUTO_INCREMENT,
codigoBarras VARCHAR(30),
nombre VARCHAR(50),
descripcion VARCHAR(150),
marca VARCHAR(30));

CREATE TABLE herramientas(
idherramientas INT PRIMARY KEY AUTO_INCREMENT,
codigoherramientas VARCHAR(30),
nombre VARCHAR(50),
medida VARCHAR(30),
marca VARCHAR(30),
descripcion VARCHAR(150));


delimiter ;;
CREATE PROCEDURE insertarUsuario(
IN _nombre VARCHAR(100),
IN _apellidop VARCHAR(100),
IN _apellidom VARCHAR(100),
IN _fdn VARCHAR(30),
IN _rfc VARCHAR(13)
IN _idusuario INT)
BEGIN 
DECLARE x INT;
SELECT COUNT(*) FROM usuarios WHERE nombre = _nombre INTO X;
if x=0 AND _idusuario < 0 then 
INSERT INTO usuarios VALUES(NULL,_nombre,_apellidop,_apellidom,_fdn,_rfc);
ELSE if x=0 AND _idusuario > 0 then
UPDATE usuarios SET nombre=_nombre,apellidop=_apellidop,apellidom=_apellidom,fdn=_fdn,rfc=_rfc WHERE idusuario=_idusuario;
ELSE
UPDATE usuarios SET apellidop=_apellidop,apellidom=_apellidom,fdn=_fdn,rfc=_rfc WHERE idusuario=_idusuario;
END if;
END if;
END;;

delimiter;;
CREATE PROCEDURE deleteusuarios(
IN _idusuario INT )
BEGIN
DELETE FROM usuarios WHERE idusuario = _idusuario;
END;;

delimiter;;
CREATE PROCEDURE showusuario(
IN _nombre VARCHAR(100))
BEGIN 
SELECT * FROM producto WHERE nombre LIKE _nombre BY nombre;
END;;