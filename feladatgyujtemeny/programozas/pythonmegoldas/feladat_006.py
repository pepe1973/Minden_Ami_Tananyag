# Írj programot, ami beolvassa a háromszög oldalainak hosszát, és megmondja, hogy
# ilyen oldalakkal szerkeszthető-e háromszög!
            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
elsoAdat = 0
masodikAdat = 0
harmadikAdat = 0
logika = False
szerkesztheto = False
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
elsoAdat = int(input("Kérem az első oldalt: "))
masodikAdat = int(input("Kérem a második oldalt: "))
harmadikAdat = int(input("Kérem a harmadik oldalt: "))

# Üzleti logika (Business Logic) 
logika = elsoAdat < masodikAdat + harmadikAdat and masodikAdat < elsoAdat + harmadikAdat and harmadikAdat < elsoAdat + masodikAdat
if logika:
	szerkesztheto = True

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"Az adatokból: {elsoAdat}, {masodikAdat} és {harmadikAdat}: "
kimenet += f"háromszög szerkeszthető: {szerkesztheto}"

print(kimenet)