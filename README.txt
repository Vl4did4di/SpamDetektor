# AI projekat: Spam Detektor

Skup podataka preuzet je sa:
https://www.kaggle.com/datasets/uciml/sms-spam-collection-dataset

Model mašinskog učenja implementiran je u Windows Forms aplikaciju (.NET 8.0).
Za obuku modela korišćen je ML.NET Model Builder, sekcija: Natural Language
Processing, scenario: Text Classification.

Aplikacija analizira unetu SMS/email poruku i određuje da li je reč o
spam poruci ili legitimnoj (ham) poruci, uz prikaz skorova pouzdanosti.