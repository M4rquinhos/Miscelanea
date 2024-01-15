
CREATE PROCEDURE sp_ListarCategorias
@estado INT
AS
BEGIN
	SELECT Id_Categoria AS ID, Nombre, Descripcion, Estado 
	FROM Categoria 
	WHERE Estado = @estado;
END