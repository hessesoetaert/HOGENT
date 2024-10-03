databank
-> centrale server/ cloud - waar meerde personen data kunnen accessen
leren databanken opzetten/gebruiken -> SQL = Structured Query Language

12 november tussentijdse test op 25% 
[[00-mysql-cheatsheet.pdf]] van mag gebruikt worden op tests

**DBMS = database management System**
soorten software:
	RDBMS = relational databases        SQL
	key values stores                              NO SQL
	document stores
	graph databases
	...

biggest DB - engines:
	Oracle -> founder van SQL basically
	MySQL -> (half) opensource maar eig. van Oracle	
	Microsoft  SQL server 

SQL = language to communicate met **relationele database**
	CRUD: create, read, update, delete
-> Is gestandaardiseerd(iso/IEC 9075)
alle RDBM gebruiken SQL -> soms wel SQL dialecten(kleine implementatie verschillen)



CLIENT VS. SERVER
	database-client-software & database-server-software
	gamelaunchers, webbrowser, ... = client
	gameserver, webserver = server

**STRUCTUUR VAN EEN RELATIONELE DATABANK**
	• De databank bestaat uit één of meer **tabellen (tables)** 
	• Elke tabel heeft één of meer **rijen (rows/records)** en **kolommen (columns)**. • Een **veld (field)** is de kruising van een rij en kolom. 
	• Elke kolom heeft een **kolomnaam of kop (column name or header)**. 
	• Een veld kan slechts één enkele **waarde (value)** bevatten. Een veld kan ook **leeg** zijn. In dat geval wordt het aangeduid met “**NULL**”. 
	• Alle waarden binnen één bepaalde kolom moeten van **hetzelfde type** zijn (**same datatype**). Voorbeelden van datatypes zijn string (tekst), datum, integer (geheel getal), float (komma-getal). 
	• De **volgorde** van de rijen en de kolommen heeft **geen betekenis** en is **onvoorspelbaar**. 
	• **Tabelnamen** (binnen dezelfde databank) moeten **uniek** zijn. 
	• **Kolomnamen** (binnen dezelfde tabel) moeten **uniek** zijn. 
	• Elke **rij** (binnen dezelfde tabel) moet **uniek** zijn. Er moet altijd minstens één waarde verschillend zijn.

==databank is atomair???==

**FLAT-FILE-DB**
	bad practice 
	= alles in 1 tabel plaatsen
	=> opsplitsen in meerdere tabellen = **normaliseren** <-> denormaliseren = tabellen mergen
	normaliseren kan overzichtelijker en handige zijn als er aanpassingen moeten gebeuren

tabel waar meerdere tabellen in voorkomen = crosstable/kruistabel

**Entity Relationship Diagram (ERD)**
	geeft structuur/ relatie tussen versch. tabellen weer
	bevat enkel headers en kolomkoppen

**EIGENSCHAPPEN RDBM**







