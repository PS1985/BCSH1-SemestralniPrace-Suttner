# BCSH1 - Semestrální práce: Autobazar Suttner

**Varianta:** (a) Jednoduchá databázová aplikace  
**Téma:** Správa inzerce v autobazaru  
**Autor:** [Tvé Jméno / Suttner]  

Tato aplikace slouží k evidenci a správě inzerátů motorových vozidel. Byla vytvořena jako semestrální práce pro předmět BCSH1.


## Datový model a Entity

Aplikace pracuje se třemi hlavními entitami:

* **Vozidlo** (`Id`, `Vin`, `Model`, `RokVyroby`, `Kilometry`, `Cena`, `Palivo`, `CestaKObrazku`)
* **Značka** (`Id`, `Nazev`, `ZemePuvodu`)
* **Prodejce** (`Id`, `Jmeno`, `Kontakt`)

### Vztahy (Relace)
Vztahy jsou realizovány na principu relační databáze (1:N). Entita `Vozidlo` neobsahuje přímo textové názvy značek a prodejců, ale uchovává si pouze jejich číselné identifikátory (`ZnackaId` a `ProdejceId`). K samotnému spárování a zobrazení textových dat dochází až dynamicky v uživatelském rozhraní.

---

## Implementované funkcionality

* **Kompletní CRUD operace:** Aplikace umožňuje vytvářet, číst, upravovat a mazat záznamy o vozidlech, a s tím související záznamy o prodejcích.
* **Dynamické uživatelské rozhraní:** Výpis inzerátů není řešen statickou tabulkou, ale pomocí dynamicky generovaných uživatelských prvků (`UserControl` - InzeratControl).
* **Vyhledávání a filtrování:** Prohledávání inzerce probíhá v reálném čase pomocí technologie LINQ (filtrace podle ID značky a textového názvu modelu).
* **Bezpečná práce s obrázky:** Nahrávání fotek k inzerátům využívá datové proudy (`FileStream`), což zabraňuje uzamčení souborů operačním systémem a umožňuje jejich bezproblémové smazání za běhu aplikace. Nahrané obrázky se fyzicky kopírují do vyhrazené složky `images` pod unikátními názvy (GUID).
* **Chytré mazání (Sirotci):** Při smazání inzerátu program automaticky odstraní fyzický soubor s fotkou. Zároveň zkontroluje, zda daný prodejce nenabízí ještě jiná auta. Pokud se jedná o jeho poslední inzerát, je prodejce automaticky smazán z databáze pro udržení čistých dat.

---

## Architektura a Technologie

* **Jazyk:** C#
* **Platforma:** .NET (Windows Forms)
* **Architektura:** Logické rozdělení projektu na Modely (`Models`), Uživatelské rozhraní (`Forms` / `Controls`) a Služby (`Services`).
* **Perzistence dat (Ukládání):** Data jsou lokálně ukládána do textového formátu **JSON**. Třída `DataManager` zajišťuje serializaci a deserializaci dat (pomocí `System.Text.Json`). Všechny tři kolekce dat jsou pro uložení agregovány do pomocné třídy `DataWrapper`, což umožňuje uložení celé databáze do jediného souboru `data.json`.
