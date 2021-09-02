--Cargar el comboBox
Create procedure SP_CargarComboBox
As
Select NombreProducto
from PRODUCTOS

EXEC SP_CONSULTAPRODUCTO 'jamon'