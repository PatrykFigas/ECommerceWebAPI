WebAPI – Zarządzanie zamówieniami (E-commerce)

Projekt Web API w technologii ASP.Net Core, umożliwiający zarządzanie produktami oraz zamówieniami w systemie e-commerce.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Technologie

Projekt został zrealizowany z użyciem:

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server (LocalDB)
- Swagger / OpenAPI
- .NET 8

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Funkcjonalności

API umożliwia:

- dodawanie produktów
- przeglądanie produktów
- aktualizację produktów
- usuwanie produktów

oraz

- tworzenie zamówień
- przeglądanie zamówień
- aktualizację zamówień
- usuwanie zamówień

Zamówienie może zawierać WIELE PRODUKTÓW, a produkt może występować w WIELU ZAMÓWIENIACH (relacja wiele-do-wielu).

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Struktura modeli

Product

Produkt zawiera podstawowe informacje:

- Id
- Name
- Price

Order

Zamówienie zawiera:

- Id
- OrderDate
- listę produktów

Relacja między ORDER i PRODUCT została zrealizowana jako MANY TO MANY przy użyciu tabeli pośredniej ORDERPRODUCTS.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Endpointy API

Produkty

GET /api/products
GET /api/products/{id}
POST /api/products
PUT /api/products/{id}
DELETE /api/products/{id}

Zamówienia

GET /api/orders
GET /api/orders/{id}
POST /api/orders
PUT /api/orders/{id}
DELETE /api/orders/{id}

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CI/CD

W projekcie została skonfigurowana automatyzacja procesu CI z użyciem GitHub Actions.

Workflow uruchamia się automatycznie po każdym pushu na gałąź MAIN.

Proces CI wykonuje następujące kroki:

- pobranie kodu repozytorium
- instalacja środowiska .NET 8
- przywrócenie pakietów NuGet
- budowanie aplikacji

Plik workflow znajduje się w:

.github/workflows/ci.yml

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Projekt wykonany jako zadanie rekrutacyjne.
