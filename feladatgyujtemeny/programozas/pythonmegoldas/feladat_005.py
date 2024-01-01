# Írj programot, mely beolvas két egész számot, és kiírja a képernyőre a nagyobbikat!
            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
elsoAdat = 0
masodikAdat = 0
nagyobb = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
elsoAdat = int(input("Kérek egy egész számot: "))
masodikAdat = int(input("Kérek egy másik egész számot: "))

# Üzleti logika (Business Logic)
if elsoAdat < masodikAdat:
	nagyobb = masodikAdat
else:
	nagyobb = elsoAdat

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"A két szám: {elsoAdat}, {masodikAdat} közül a nagyobb: {nagyobb}"

print(kimenet)