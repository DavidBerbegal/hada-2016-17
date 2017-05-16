# HadaFlix

## Contingut

- [1. Desenvolupadors del projecte](#1)
- [2. Esquema EERR Base de Dades](#2)
- [3. Proposta de projecte](#3)
  - [3.1. Descripció](#3-1)
  - [3.2. Part Pública](#3-2)
  - [3.3.	Llistat EN Pública](#3-3)
  - [3.4. Part Privada](#3-4)
  - [3.5. Llistat EN Privada](#3-5)
  - [3.6. Possibles millores](#3-6)
- [4. Documentació del projecte](#4)
  - [4.1. Canvis](#4-1)
  - [4.2. Dificultats](#4-2)
  - [4.3. Problemes](#4-3)
  - [4.4. Planificació](#4-4)
    - [4.4.1. Guia d'ús de l'aplicació](#4-4-1)
    - [4.4.2. Usuari i contrasenya](#4-4-2)
  - [4.5. Tasques](#4-5)
    - [4.5.1. Planificació Inicial](#4-5-1)
    - [4.5.2. Planificació Final](#4-5-2)
- [5. Presentació del projecte](#5)

## <a name="1"/> 1. Desenvolupadors del projecte:
- Álvaro Gironés Garcia (gg52@alu.ua.es)
- Javi Monllor Alcaraz (jma86@alu.ua.es)
- Juan Ruiz de Larrea Aracil (jrl12@alu.ua.es)
- Javier Rocamora Garcia (jrg81@alu.ua.es)
- David Berbegal Esteve (dbe4@alu.ua.es)

# <a name="2"/> 2. EERR Base de Dades
## Ubicació: /Esquema Base de Dades/EERR BBDD.png

# <a name="3"/> 3. Proposta de projecte
## Descripció del projecte

## <a name="3-1"/> 3.1.	Descripció
  
> L’aplicació web que volem realitzar serà un videoclub, en el qual es podran llogar les diverses pel·lícules i series que es podran consultar a la pàgina principal. Per altra banda, també podem trobar una pel·lícula o serie mitjançant el filtrat de l’any de sortida, categoria a la que pertany, ...
  
> Amb la pel·lícula o serie ja elegida, i verificat que està disponible per a ser llogada, l’usuari podrà continuar llogant articles o finalitzar la seua operació.
  
> Respecte a la part privada d’un usuari, es podran visualitzar les seues pròpies dades, editar-les o donar de baixa el compte.
  
> En cas de ser un administrador del sistema, amb l’entrada a la part privada es podran afegir, editar i esborrar pel·lícules i series al sistema.


## <a name="3-2"/> 3.2.	Part Pública

> En la pàgina principal trobarem un llistat amb totes les pel·lícules i series que tenim disponibles per a poder ser llogades. 

> En aquesta pàgina es podran ordenar les pel·lícules i series segons els noms o filtrar mitjançant una determinada temàtica/categoria, l’any en que va sortir, ...

> També es podrà llogar una determinada pel·lícula o serie si es troba disponible. En cas de que estiga disponible i es vuiga llogar es tindrà que accedir a la pròpia pulsant sota el títol. Una vegada dins de la pàgina es podrà llegir una xicoteta sinopsi d’aquesta per tal de verificar si és allò que busquem. Es podrà trobar un botó que ens permetrà realitzar el llogament.

> Una vegada s’haja pulsat aquest botó es tindrà que viatjar al carret de llogament i confirmar allò que em triat.

> Seguidament s'adjunten alguns mockups de quina seria l'apariència estimada que obtindríem com a resultat:

<img src="images/inici.png" width="500px">

<img src="images/Categories.png" width="500px">

<img src="images/series.png" width="500px">

<img src="images/pelicules.png" width="500px">

<img src="images/registre.png" width="500px">

<img src="images/login.png" width="500px">


## <a name="3-3"/> 3.3.	Llistat EN Pública

- Series
- Películes
- Clients
- Empleats
- Proveedors
- Venta
- Pedidos


## <a name="3-4"/> 3.4.	Part Privada

> En la part privada de l’aplicació es podran visualitzar les dades personals de l’usuari per tal de veure si són correctes o tenen algun tipus d’error. Amb aquesta acció, i si l’usuari ho considera necessari es podran editar les dades si alguna cosa no és correcta o el perfil es troba incomplet. També es podrà esborrar el compte si es pensa que ja no es necessari tenir-lo.

> En cas de tractar-se de la part privada d’un administrador es podran afegir noves pel·lícules o series al llistat que ja tenim, juntament amb la foto de portada. Al igual que també es podrà realitzar l’eina de modificar-lasi conté en el seu títol, descripció o portada algun camp incorrecte; o esborrar-lai ja no es disposa d’aquesta.

> També es podrà veure un llistat de totes les pel·lícules i series que s’han llogat des de que es va crear un usuari el compte a la pàgina.

<img src="images/administracio.png" width="500px">

<img src="images/perfilUsuari.png" width="500px">

<img src="images/editarUsuari.png" width="500px">


## <a name="3-5"/> 3.5.	Llistat EN Privada

- Series
- Películes
- Clients
- Empleats
- Proveedors
- Venta
- ListaVentas
- Pedidos


## <a name="3-6"/> 3.6.	Possibles millores

> La possibilitat d’afegir a la pàgina el llogament de videojocs, al igual que un apartat de merchandising de les diverses pel·lícules i series de les quals es disposen a la base de dades.
D'altra banda, també seria interessant la possibilitat de poder seleccionar el idioma en el qual es poden visualitzar els continguts de les pel·lícules/series (La sinopsi).

# <a name="4"/> 4. Documentació del projecte

## <a name="4-1"/> 4.1. Canvis:
> Respecte a la proposta de projecte que es va realitzar primerament s’han realitzat diversos canvis que han canviat el resultat final de l’aplicació. Els canvis realitzats són:
o	S’ha afegit un mapa on es pot comprovar la localització física del videoclub.
o	En cas de que un usuari es registre en l’aplicació i oblide la seua contrasenya, amb la inserció del seu correu en la pantalla de “recordar contrasenya”, s’enviarà la contrasenya del correu insertat al correu corresponent.
o	També s’ha afegit un nou tipus d’article al videoclub, els jocs. Un usuari podrà realitzar les mateixes accions que realitzava sobre pel·lícules i sèries, ara també sobre jocs.

## <a name="4-2"/> 4.2. Dificultats:

## <a name="4-3"/> 4.3. Problemes:
> El principal problema en el qual ens em trobat a l’hora de realitzar el projecte a sigut l’enfocament erroni del conjunt final. 
> Primerament es va pensar en la realització d’una aplicació que poguera ajudar a la organització i un correcte funcionament d’un videoclub. Dins de la pròpia aplicació; el gestor del videoclub, o l’empleat, podien donar de alta llogues que fera un client d’un determinat article, donar d’alta un proveïdor, una pel·lícula, … 
> El canvis que acabem de comentar han provocat la creació d’una tenda online on un determinat usuari pot registrar-se per tal de realitzar un lloguer d’una pel·lícula, una sèrie, un joc, ...
> Per altra part cal destacar que el paper del proveïdor de productes ha perdut el seu protagonisme degut a que una persona no està controlant la pàgina per tal de guardar totes aquestes dades.

## <a name="4-4"/> 4.4. Planificació: 
### <a name="4-4-1"/> 4.4.1. Guia d’ús de l’aplicació:

### <a name="4-4-2"/> 4.4.2. Usuari i contrasenya:
> Després del problema de una mala planificació del producte final, l’aplicació s’ha quedat privada d’una part d’administració on es pugui poder afegir els diferents articles dels quals disposa el videoclub.
> Per tal de poder afegir informació es realitzen les insercions en la base de dades directament.

### <a name="4-5"/> 4.5. Tasques:
#### <a name="4-5-1"/> 4.5.1. Planificació Inicial:

<table>
  <tr>
    <td>Nom</td> 
    <td>Tasca</td>
  </tr>
  <tr>
    <td>Álvaro Gironés Garcia</td>
    <td>Proposta de Projecte</td>
  </tr>
  <tr>
    <td></td>
    <td>CADClient: Creació, edició i eliminació de clients</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENClient:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Client</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADProveedor: Creació, edició i eliminació de proveïdors</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENProveedor:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Proveïdor</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Producte</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Contacte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Maquetació</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>Javier Monllor</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>BBDD</td> 
  </tr>
  <tr>
    <td></td>
    <td>Creació Projecte Base</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Login</td> 
  </tr>
  <tr>
    <td></td>
    <td>ASPX de Registre</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Olvidar Contrasenya</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>Javier Rocamora</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADAdquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENAdquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Adquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADLineaAdquisició: Creació, edició i eliminació de línees d'adquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENLineaAdquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Línia d’Adquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Pel·lícules</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Sèries</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>Juan Ruiz de Larrea Aracil</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADProducte: Creació, edició i eliminació de productes</td> 
  </tr>
  <tr>
    <td></td>
    <td>EN Producte:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Producte</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADEmpleat:	Creació, edició i eliminació d'empleats</td> 
  </tr>
  <tr>
    <td></td>
    <td>EN Empleat:</td> 
  </tr>
  <tr> 
    <td></td>
    <td>Test d’Empleat</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Carrito</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>David Berbegal Esteve</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Proposta de Projecte (Documentació)</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADVenta: Creació, edició i eliminació de vendes</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENVenta:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Venta</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADAlquiler:	Creació, edició i eliminació de lloguers</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENAlquiler:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test d’Alquil·ler</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Jocs</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte (Documentació)</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte (Documentació)</td> 
  </tr>
  <tr>
    <td></td>
    <td>Gestió del GitHub</td> 
  </tr>
</table>

#### <a name="4-5-2"/> 4.5.2. Planificació Final:

<table>
  <tr>
    <td>Nom</td> 
    <td>Tasca</td>
  </tr>
  <tr>
    <td>Álvaro Gironés Garcia</td>
    <td>Proposta de Projecte</td>
  </tr>
  <tr>
    <td></td>
    <td>CADClient: Creació, edició i eliminació de clients</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENClient:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Client</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADProveedor: Creació, edició i eliminació de proveïdors</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENProveedor:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Proveïdor</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Producte</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Contacte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Maquetació</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>Javier Monllor</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>BBDD</td> 
  </tr>
  <tr>
    <td></td>
    <td>Creació Projecte Base</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Login</td> 
  </tr>
  <tr>
    <td></td>
    <td>ASPX de Registre</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Olvidar Contrasenya</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>Javier Rocamora</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADAdquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENAdquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Adquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADLineaAdquisició: Creació, edició i eliminació de línees d'adquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENLineaAdquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Línia d’Adquisició</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Pel·lícules</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Sèries</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>Juan Ruiz de Larrea Aracil</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADProducte: Creació, edició i eliminació de productes</td> 
  </tr>
  <tr>
    <td></td>
    <td>EN Producte:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Producte</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADEmpleat:	Creació, edició i eliminació d'empleats</td> 
  </tr>
  <tr>
    <td></td>
    <td>EN Empleat:</td> 
  </tr>
  <tr> 
    <td></td>
    <td>Test d’Empleat</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Carrito</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td>David Berbegal Esteve</td> 
    <td>Proposta de Projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Proposta de Projecte (Documentació)</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADVenta: Creació, edició i eliminació de vendes</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENVenta:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test de Venta</td> 
  </tr>
  <tr>
    <td></td>
    <td>CADAlquiler:	Creació, edició i eliminació de lloguers</td> 
  </tr>
  <tr>
    <td></td>
    <td>ENAlquiler:</td> 
  </tr>
  <tr>
    <td></td>
    <td>Test d’Alquil·ler</td> 
  </tr>
  <tr>
    <td></td>
    <td>APSX de Jocs</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Memòria del projecte (Documentació)</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte</td> 
  </tr>
  <tr>
    <td></td>
    <td>Presentació del projecte (Documentació)</td> 
  </tr>
  <tr>
    <td></td>
    <td>Gestió del GitHub</td> 
  </tr>
</table>

# <a name="5"/> 5. Presentació del projecte: 
## Ubicació: /Presentacio/Presentacio.pdf
