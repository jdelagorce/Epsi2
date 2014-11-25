Méthode Agile 
=====

Synthèse BDD & Webservice

#BDD

La base de données a été crée sur SQL server. Voici sa structure:

Field    | Type
-------|----
Id|Int
LastName  |Varchar
FirstName |Varchar
Password| Varchar
Mail|Varchar
Address1|Varchar
Address2|Varchar
zipCode|Varchar
city|Varchar
Role|Int

The roles defines users's permissions (ADMIN or STANDARD USER)

#WebService

Le Webservice fait la liaison entre les deux applications clientes et admin. Il fait le lien avec la base de données par l'entity framework 5.0 et implémente les méthodes simples du CRUD qui sont accessibles par les applications.
