# Lernperiode 5

2.5 bis 23.5

## Grob-Planung

Wie können Sie Ihr Projekt aus der Lernperiode 4 um eine Persistenz-Lösung erweitern? Was gibt es zu speichern, was für Tabellen brauchen Sie und wie muss der bestehende Code mit diesen interagieren?

Ich möchte die Anleitung in meinem Tic-Tac-Toe-Projekt so erweitern, dass sie mehrere Sprachen unterstützt. Statt die Texte direkt im Code zu speichern, lade ich sie zukünftig aus einer Datenbank. So kann ich die Anleitung je nach Sprache dynamisch anzeigen lassen. Das macht das Projekt übersichtlicher und ich kann später einfach neue Sprachen hinzufügen, ohne etwas am Code zu ändern.


## 2.5

- [x] Überlegen was ich mit einer Datenbank verbinden kann
- [x] Neues Forms mit den verschiedenen sprachen erstellt

Heute habe ich die SQL Datenbank für mein Projekt erstellt. Ich habe mich schonmal Informiert wie man das C Sharp Projekt mit der SQL Datenbank verbinden kann. Dann habe ich auch eine Tabelle für die verschiedenen Sprachen erstellt.


## 9.5 Kernfunktionalität

- [x] Datenbank erstellen
- [x] Tabellen erstellen 
- [x] Mit insert into Text in Tabellen einfügen
Heute habe ich habe eine Datenbank erstellt und darin eine Tabelle für Anleitungstexte in verschiedenen Sprachen angelegt. Die Inhalte habe ich mit „INSERT INTO“ eingefügt. So kann ich später die Sprache über Buttons auswählen und der passende Text wird angezeigt – ganz ohne den Code jedes Mal zu ändern.
  

## 16.5 Kernfunktionalität und Ausbau

- [x] Code für die verschiedenen Sprachen schreiben 
- [x]  Nachschauen, wie man Windows Forms mit einer Datenbank verbindet
- [x] Die Datenbank im Code einbauen und die Verbindung testen
- [x] Schauen, ob alles klappt und ob man Daten speichern/lesen kann

Heute habe ich ein Sprachwahlmenü in meinem Windows-Forms-Projekt erstellt. Je nach Auswahl öffnet sich ein neues Formular mit einer Anleitung. Die Texte werden aus einer SQLite-Datenbank geladen. Ich habe gelernt, wie man Events, Datenbankverbindungen und Sprachlogik korrekt in C# umsetzt.


## 23.5 Abschluss

- [x] Beim letzten Test meines Projekts funktionierte die Zurück-Taste (Back-Button) in der Anleitung nicht richtig. Deshalb möchte ich diesen Fehler beheben und 
      sicherstellen, dass man wieder zuverlässig ins Auswahlmenü zurückkehren kann.
- [x] Projekt ausbessern und alles säubern.
- [x] Reflexion über Ihre Arbeitsweise
- [x] Beschreibung des fertigen Projekts mit .gif etc.

Heute habe ich die Back-Funktion in meinem Projekt repariert, sodass man zuverlässig vom Anleitungsfenster zurück ins Auswahlmenü gelangt. Ich habe das Projekt aufgeräumt, Fehler behoben und die Spracheinstellungen mit Datenbankverbindung fertiggestellt. Zum Schluss habe ich mein Projekt beschrieben und meine Arbeit reflektiert.


## Fertiges Projekt

Mein Projekt ist eine einfache Spielkonsole mit Sprachauswahl und Spielanleitung. Der Benutzer wählt zuerst die Sprache (Deutsch, Englisch oder Italienisch), woraufhin eine Anleitung mit einer Erklärung zum Spiel angezeigt wird. Die Inhalte kommen direkt aus einer SQLite-Datenbank. Ein Back-Button ermöglicht es, zur Sprachauswahl zurückzukehren. Das Projekt zeigt, wie man mit Datenbanken, Formularen und Benutzerinteraktion arbeitet.

![Unbenanntes Video – Mit Clipchamp erstellt (2)](https://github.com/user-attachments/assets/b8e33b03-36df-4345-8170-e69f085641e7)


## Reflexion

Gut lief, dass ich die Sprachauswahl und Datenbankabfrage umsetzen konnte. Weniger gut war, dass einige Fehler im Designer lange unklar waren. Ich habe gelernt, wie wichtig sauberes Debugging, Geduld und systematisches Vorgehen sind. Nächstes Mal möchte ich früher eine saubere Struktur planen. Für die nächste Lernphase nehme ich mir vor, die Navigation zwischen Forms zu vertiefen und Fehler schneller gezielt zu beheben.

