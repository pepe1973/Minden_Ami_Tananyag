# Írj programot, ami beolvas egy számot, majd kiírja a kétszeresét!
            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
adat = 0
duplaAdat = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
adat = int(input("Kérek egy pozitív egész számot: "))

# Üzleti logika (Business Logic)
duplaAdat = 2 * adat

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"A szám: {adat} kétszerese: {duplaAdat}."
print(kimenet)