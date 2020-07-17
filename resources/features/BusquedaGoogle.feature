Feature: BusquedaGoogle
	para obtener informacion de internet
	como usuario de google
	quiero buscar informacion a traves de una palabra clave

@mytag
Scenario Outline: Buscar palabra en Google
	Given Estoy en la pagina principal de Google
	When Ingreso la <PalabraBuscada> en el buscador de Google
	And Presiono boton buscar
	Then Google muestra el resultado de la busqueda
	Examples:
	| PalabraBuscada  |
	| In Motion Chile |