# BCSH1-SemestralniPrace-Suttner 

**Varianta:** (a) Jednoduchá databázová aplikace  
**Téma:** Správa inzerce v autobazaru

# Sledované entity
**Vozidlo** (VIN, Model, Rok výroby, Kilometry, Cena, Palivo)
**Značka** (Název výrobce, Země původu)
**Prodejce** (Jméno, Kontakt)

# Vztahy
Každé vozidlo je přiřazeno k jedné konkrétní značce a má určeného jednoho prodejce (vazba 1:N).

# Základní seznam funkcionalit
**Správa dat (CRUD):** Aplikace umožňuje vytvářet, editovat a mazat veškeré uvedené typy entit.
**Vyhledávání:** Zobrazení seznamu vozidel s možností vyhledávání podle modelu nebo VIN.
**Filtrování:** Možnost filtrovat vozidla podle značky a cenového rozpětí.
**Data:** Pro ukládání dat je využit formát JSON.

# Technologie
**Jazyk:** C# 
**Platforma:** Windows Forms 
**Framework:** .NET
