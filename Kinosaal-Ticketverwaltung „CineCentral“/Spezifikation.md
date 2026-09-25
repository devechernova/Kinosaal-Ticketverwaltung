

# Kundenauftrag / Mini-Projekt: Kinosaal-Ticketverwaltung „CineCentral“

**Themen:** Zweidimensionale Arrays, verschachtelte Schleifen, Konsolen-I/O & Menüführungslogik

**Auftraggeber:** Lichtspieltheater Central GmbH

**Projektphase:** Prototypentwicklung (MVP – *Minimum Viable Product*)

---
**Projektziel**

Ziel des Projekts ist die Entwicklung eines Konsolen-Prototyps zur Verwaltung von Sitzplätzen in einem Kinosaal.

Das Programm ermöglicht dem Kassenpersonal:

* Freie Plätze einzusehen,
* Plätze zu reservieren,
* Plätze zu verkaufen,
* Reservierungen oder Verkäufe wieder freizugeben.
  
**Verwendete Architektur**

Das Projekt wurde in mehrere Verantwortungsbereiche aufgeteilt.

Program.cs
│
├── Models
│ └── Kinosaal.cs
│
├── Services
│ ├── AnzeigeService.cs
│ └── KinosaalService.cs
│
└── Helpers

Die Hauptlogik und Menüführung befinden sich in Program.cs.
Die fachliche Logik wurde in Service-Klassen ausgelagert.

**Datenmodell**

Klasse: Kinosaal
Die Klasse Kinosaal repräsentiert den gesamten Kinosaal.

Eigenschaften
AnzahlReihen - Speichert die Anzahl der Sitzreihen.
AnzahlSitze - Speichert die Anzahl der Sitze pro Reihe.
Sitzplaetze - Zweidimensionales Array vom Typ char[,].

**Sitzplatzstatus**

Im Array werden folgende Zustände gespeichert:

| Status | Bedeutung  |
| ------ | ---------- |
| F      | Frei       |
| R      | Reserviert |
| B      | Belegt     |


**Konstruktor**

Der Konstruktor erstellt den Kinosaal anhand der übergebenen Größe.
Beispiel:
new Kinosaal(10, 5);

Dabei wird:

* die Anzahl der Reihen gespeichert,
* die Anzahl der Sitze gespeichert,
* das Array erzeugt,
* der Saal initialisiert.


**Initialisierung**

Methode
InitialisiereSaal() - Diese Methode durchläuft das gesamte zweidimensionale Array
und setzt alle Sitzplätze auf:
F - (Frei)

**AnzeigeService**

Die Klasse AnzeigeService ist ausschließlich für die Darstellung verantwortlich.

Methode
ZeigeKinosaal()

Aufgaben:

* Darstellung des Kinosaals als Matrix
* Anzeige der Sitznummern
* Anzeige der Reihennummern
* farbliche Darstellung der Sitzplatzstatus


**Farbdarstellung**

| Status | Farbe         |
| ------ | ------------- |
| F      | Standardfarbe |
| R      | Blau          |
| B      | Rot           |


**KinosaalService**

Die Klasse KinosaalService enthält die Geschäftslogik zur Verwaltung von Sitzplätzen.

Methode
BelegeSitz() - Markiert einen Sitzplatz als verkauft.

Statuswechsel:
F → B
R → B
Nicht erlaubt:
B → B

Methode
ReserviereSitz() - Reserviert einen Sitzplatz.

Statuswechsel:
F → R
Nicht erlaubt:
R → R
B → R

Methode
GibSitzFrei() - Gibt einen Sitzplatz wieder frei.

Statuswechsel:
R → F
B → F
Nicht erlaubt:
F → F


**UML-basierte Zustandsverwaltung**

Die Implementierung orientiert sich an der vorgegebenen UML-Zustandsmaschine.

Erlaubte Übergänge:

F → R
F → B
R → B
R → F
B → F

Alle anderen Statuswechsel werden verhindert.
Der Benutzer erhält in diesem Fall eine entsprechende Fehlermeldung.


**Menüführung**

Das Programm arbeitet mit einem Hauptmenü.
Verfügbare Aktionen:

b = belegen
r = reservieren
f = freigeben
q = beenden

Die Anwendung läuft in einer while-Schleife und ermöglicht mehrere Aktionen innerhalb eines Programmstarts.

**Eingabevalidierung**

Zur Vermeidung von Programmabstürzen wurde eine Eingabevalidierung implementiert.

* Prüfung der Aktion

Erlaubte Eingaben:
b
r
f
q

Ungültige Eingaben werden abgefangen.

* Prüfung von Zahlen

Die Eingaben für Reihe und Sitz werden mit:
int.TryParse()
validiert.

Ungültige Texteingaben wie:

abc
xyz
@
werden abgefangen.

* Bereichsprüfung

Reihen:
1 bis 10

Sitze:
1 bis 5

Werte außerhalb dieses Bereichs werden nicht akzeptiert.


**Umgesetzte Anforderungen**

* Darstellung des Kinosaals als Matrix
* Verwendung eines zweidimensionalen Arrays
* Reservierung von Sitzplätzen
* Verkauf von Sitzplätzen
* Freigabe von Sitzplätzen
* Farben für Reservierungen und Verkäufe
* Menüführung
* Mehrfachausführung über eine Programmschleife
* UML-basierte Statusübergänge
* Prüfung ungültiger Aktionen
* Validierung numerischer Eingaben
* Bereichsprüfung von Reihen und Sitzplätzen
* Objektorientierte Struktur mit mehreren Klassen


**Fazit**

Im Rahmen des Projekts wurde ein vollständiger Konsolen-Prototyp zur Verwaltung eines Kinosaals entwickelt. Das System ermöglicht die Anzeige, Reservierung, den Verkauf sowie die Freigabe von Sitzplätzen. Darüber hinaus wurden UML-basierte Zustandsübergänge, Eingabevalidierung und farbliche Konsolenausgaben erfolgreich umgesetzt.

Der praktische Schwerpunkt des Projekts lag auf der Arbeit mit zweidimensionalen Arrays, verschachtelten Schleifen und einer sauberen objektorientierten Strukturierung der Anwendung.