# Írj programot, ami beolvas két számot, majd kiírja:
# a. az összegüket;
# b. különbségüket;
# c. szorzatukat;
# d. hányadosukat, ha lehet!

            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
elsoAdat = 0
masodikAdat = 0
osszeg = 0
kulonbseg = 0
szorzat = 0
hanyados = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
elsoAdat = int(input("Kérek egy pozitív egész számot: "))
masodikAdat = int(input("Kérek egy másik pozitív egész számot (!= 0): "))

# Üzleti logika (Business Logic)
osszeg = elsoAdat + masodikAdat
kulonbseg = elsoAdat - masodikAdat
szorzat = elsoAdat * masodikAdat
hanyados = elsoAdat / masodikAdat

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"A két szám: {elsoAdat}, {masodikAdat}"
kimenet += f"\nÖsszege: {osszeg}"
kimenet += f"\nKülönbsége: {kulonbseg}"
kimenet += f"\nSzorzata: {szorzat}"
kimenet += f"\nHányadosa: {hanyados}"
print(kimenet)