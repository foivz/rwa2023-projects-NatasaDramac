CREATE TABLE UlazIzlaz
(
    IdUlazIzlaz INT IDENTITY(1,1) PRIMARY KEY,
    IdClana INT NOT NULL,
    Ulaz DATETIME NULL,
    Izlaz DATETIME NULL,
    CONSTRAINT FK_Clanovi_UlazIzlaz FOREIGN KEY (IdClana) REFERENCES Clanovi(IdClana)
)
