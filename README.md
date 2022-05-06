# Labb3-API

Testning av labben genom Postman:

Hämta alla personer i systemet
GET https://localhost:44329/api/person
Hämta alla intressen som är kopplade till en specifik person
GET https://localhost:44329/api/person/hobbies/1
Hämta alla länkar som är kopplade till en specifik person
GET https://localhost:44329/api/person/links/1
Koppla en person till ett nytt intresse
POST https://localhost:44329/api/personHobby { "personId": 5, "person": null, "hobbyId": 2, "hobby": null }
Lägga in nya länkar för en specifik person och ett specifikt intresse
POST https://localhost:44329/api/link { "url": "sv.wikipedia.org/wiki/League_of_Legends", "personId": 3, "person": null, "hobbyId": 1, "hobby": null }
