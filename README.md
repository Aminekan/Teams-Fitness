# Teams-Fitness
# Train Digital – Projektidee

Dies ist eine Visualisierung der Kernfeatures von **Train Digital** als digitaler Personal Trainer.
# Übersicht Über unser Programm
```mermaid
flowchart TD
    A[Startseite / Dashboard]

    A --> B[Übungsübersicht]
    B --> B1[Übung auswählen]
    B --> B2[Beschreibung, Bilder/Videos]
    B --> B3[Muskelgruppe anzeigen]

    A --> C[Trainingsprogramme]
    C --> C1[Programm auswählen: Muskelaufbau]
    C --> C2[Programm auswählen: Abnehmen]
    C --> C3[Programm auswählen: Ganzkörper]
    C --> C4[Programm auswählen: Split]
    C --> C5[Übungen hinzufügen/entfernen]
    C --> C6[Plan speichern]

    A --> D[Ernährung & Kalorien]
    D --> D1[Ernährungspläne anzeigen]
    D --> D2[Kalorien- und Makronährstoffangaben]
    D --> D3[Kalorienrechner individuell]

    A --> E[Fortschritts-Tracking]
    E --> E1[Trainingshistorie]
    E --> E2[Diagramme / Tabellen]
    E --> E3[Zielüberprüfung]

    A --> F[Einstellungen / Profil]
    F --> F1[Benutzername, Ziele, Trainingshäufigkeit]
    F --> F2[Personalisierte Empfehlungen]
```
# Überblick für frontend und backend
```mermaid
graph TD

    %% Backend
    subgraph Backend
        A1[Datenmodelle definieren: Übungen, Trainingspläne, Ernährungspläne, Benutzerprofile]
        A2[Logik erstellen: Kalorienbedarf, Fortschritt, Trainingsplan generieren/anpassen]
        A3[APIs erstellen: Daten abrufen & speichern]
    end

    %% Frontend
    subgraph Frontend
        B1[Benutzeroberfläche: Dashboard, Übungsübersicht, Trainingsprogramme, Ernährungs- & Kalorienrechner, Fortschritts-Tracking]
        B2[Interaktion & Datenfluss: Formulare, Buttons, JS sendet Anfragen, Ergebnisse anzeigen]
    end

    %% Datenbank
    subgraph Database
        C1[Trainings- und Ernährungsdaten speichern]
        C2[Verbindung über Entity Framework Core]
    end

    %% Verbindungen
    Frontend --> Backend
    Backend --> Database
```


# Schema : Backend-Aufbau (c#)
```mermaid
mindmap
  root((Backend: C# / ASP.NET Core))
    1. Datenmodelle definieren
      Übungen
        Name
        Muskelgruppe
        Beschreibung
        Bild/Video
      Trainingspläne
        Programmname
        Übungen
        Dauer / Wiederholungen / Sätze
        Ziel (Muskelaufbau, Abnehmen…)
      Ernährungspläne
        Mahlzeiten
        Kalorien
        Makronährstoffe (Proteine, Fette, Kohlenhydrate)
      Benutzerprofile
        Name
        Gewicht / Größe / Alter
        Trainingsziele
        Fortschritt
    2. Logik erstellen
      Kalorienbedarf berechnen
      Fortschritt analysieren
      Trainingsplan generieren / anpassen
    3. APIs erstellen (HTTP-Endpunkte)
      Daten abrufen
        Übungen
        Trainingspläne
        Ernährungspläne
      Daten speichern / aktualisieren
        Benutzerfortschritt
        Neue Trainingspläne
        Eingaben Kalorienrechner
```
# Arbeitsablauf für den Benutzer
```mermaid
flowchart TD
    A["Benutzer öffnet die Webseite"] --> B["Frontend zeigt Dashboard / Startseite"]
    B --> C["Benutzer gibt Daten ein (z. B. Gewicht, Ziel)"]
    C --> D["JavaScript sendet Anfrage an Backend (C# API)"]
    D --> E["Backend verarbeitet Daten (Berechnungen, Datenbankzugriff)"]
    E --> F["Backend sendet Ergebnis zurück"]
    F --> G["Frontend zeigt Ergebnis dem Benutzer an"]
```







