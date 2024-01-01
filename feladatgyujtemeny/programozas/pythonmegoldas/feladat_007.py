# Írj programot, mely beolvas két pozitív egész számot, és kiírja a számtani és
# mértani közepüket! A gyökvonáshoz használd a beépített Sqrt() függvényt!

# Szükséges modulok importálása
import math
            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
elsoAdat = 0
masodikAdat = 0
szamtaniKozep = 0
mertaniKozep = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
elsoAdat = int(input("Kérem az első pozitív egész számot: "))
masodikAdat = int(input("Kérem a második pozitív egész számot: "))

# Üzleti logika (Business Logic) 
szamtaniKozep = (elsoAdat + masodikAdat) / 2
mertaniKozep = math.sqrt(elsoAdat * masodikAdat)

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"Az adatok: {elsoAdat}, {masodikAdat}"
kimenet += f"\nSzámtani közép: {szamtaniKozep}"
kimenet += f"\nMértani közép: {mertaniKozep}"

print(kimenet)