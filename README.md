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

Azure Deployment

API zostało wdrożone w chmurze Microsoft Azure przy użyciu Azure App Service.

Publiczny adres API
https://ecommerce-orders-api-patryk-cchzfebpbhfkcub2.westeurope-01.azurewebsites.net

Swagger
https://ecommerce-orders-api-patryk-cchzfebpbhfkcub2.westeurope-01.azurewebsites.net/swagger

Wykorzystane usługi Azure
- Azure App Service
- GitHub Actions (CI/CD pipeline)

Automatyczne wdrażanie
Po każdym pushu do gałęzi MASTER GitHub Actions:
1. Buduje projekt ASP.NET Core
2. Publikuje aplikację
3. Automatycznie wdraża ją do Azure App Service

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Projekt wykonany jako zadanie rekrutacyjne.
