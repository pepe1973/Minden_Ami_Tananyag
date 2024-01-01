# Írj programot, mely beolvas három egész számot, és kiírja a képernyőre a
# legkisebbet! 

# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
elsoSzam = 0
masodikSzam = 0
harmadikSzam = 0
legkisebb = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
elsoSzam = int(input("Kérem az első számot: "))
masodikSzam = int(input("Kérem a második számot: "))
harmadikSzam = int(input("Kérem a harmadik számot: "))

# Üzleti logika (Business Logic) 
if elsoSzam <= masodikSzam:
	if elsoSzam <= harmadikSzam:
		legkisebb = elsoSzam
	else:
		legkisebb = harmadikSzam
else:
	if masodikSzam <= harmadikSzam:
		legkisebb = masodikSzam
	else:
		legkisebb = harmadikSzam

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"A számok: {elsoSzam}, {masodikSzam}, {harmadikSzam}. "
kimenet += f"Legkisebb szám: {legkisebb}"
print(kimenet)