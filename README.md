![Build and Deploy](https://github.com/PatrykFigas/ECommerceWebAPI/actions/workflows/ci.yml/badge.svg)

WEB API - ZARZĄDZANIE ZAMÓWIENIAMI (E-COMMERCE)


Projekt ASP.NET Core Web API umożliwiający zarządzanie produktami oraz zamówieniami w systemie e-commerce.

API pozwala na tworzenie, modyfikowanie, usuwanie oraz przeglądanie produktów i zamówień.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Technologie

Projekt został zrealizowany z użyciem:
- ASP.NET Core Web API,
- Entity Framework Core,
- SQLite,
- Swagger / OpenAPI,
- .NET 8,
- GitHub Actions (CI/CD),
- Microsoft Azure App Service.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Funkcjonalności

API umożliwia zarządzanie:

Produktami

- dodawanie produktów,
- przeglądanie listy produktów,
- pobieranie pojedynczego produktu,
- aktualizację produktu,
- usuwanie produktu.

Zamówieniami

- tworzenie zamówień,
- przeglądanie zamówień,
- pobieranie pojedynczego zamówienia,
- aktualizację zamówienia,
- usuwanie zamówienia.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Struktura modeli

Product

Model produktu zawiera podstawowe informacje:
- Id,
- Name,
- Price.

Order

Model zamówienia zawiera:
- Id,
- OrderDate, 
- listę produktów.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Relacja danych

W systemie została zaimplementowana relacja many-to-many pomiędzy zamówieniami i produktami:
- jedno zamówienie może zawierać wiele produktów,
- jeden produkt może występować w wielu zamówieniach.

Relacja została zrealizowana przy użyciu tabeli pośredniej OrderProducts.

Konfiguracja relacji została wykonana w Entity Framework Core.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Endpointy API

Produkty
GET     /api/products
GET     /api/products/{id}
POST    /api/products
PUT     /api/products/{id}
DELETE  /api/products/{id}

Zamówienia
GET     /api/orders
GET     /api/orders/{id}
POST    /api/orders
PUT     /api/orders/{id}
DELETE  /api/orders/{id}

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Baza danych

Projekt wykorzystuje bazę danych SQLite do przechowywania informacji o produktach i zamówieniach.

Baza danych jest tworzona automatycznie przy starcie aplikacji przy użyciu:
db.Database.EnsureCreated();

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Asynchroniczność

Operacje na bazie danych zostały zaimplementowane w sposób asynchroniczny z użyciem metod Entity Framework Core takich jak:
- ToListAsync(),
- FindAsync(),
- SaveChangesAsync().

Dzięki temu API jest bardziej wydajne i lepiej obsługuje wiele równoczesnych zapytań.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

CI/CD – GitHub Actions

W projekcie została skonfigurowana automatyzacja procesu Continuous Integration przy użyciu GitHub Actions.

Workflow uruchamia się automatycznie po każdym pushu na gałąź master.

Pipeline wykonuje następujące kroki:
1. Pobranie kodu z repozytorium,
2. Instalacja środowiska .NET 8,
3. Przywrócenie pakietów NuGet,
4. Zbudowanie aplikacji,
5. Publikacja aplikacji,
6. Wdrożenie aplikacji do Azure

Plik workflow znajduje się w:
.github/workflows/ci.yml

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Wdrożenie w Azure

Aplikacja została wdrożona w chmurze Microsoft Azure przy użyciu usługi Azure App Service.

Publiczny adres API:
https://ecommerce-orders-api-patryk-cchzfebpbhfkcub2.westeurope-01.azurewebsites.net

Swagger (interfejs do testowania API):
https://ecommerce-orders-api-patryk-cchzfebpbhfkcub2.westeurope-01.azurewebsites.net/swagger

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Wykorzystane usługi Azure

Projekt wykorzystuje następujące usługi chmurowe:

- Azure App Service
- GitHub Actions (CI/CD pipeline)

Po każdym pushu do gałęzi MASTER pipeline:
1. Buduje projekt ASP.NET Core
2. Publikuje aplikację
3. Automatycznie wdraża ją do Azure App Service

Dodatkowo w repozytorium znajduje się definicja infrastruktury jako kodu w technologii Bicep.