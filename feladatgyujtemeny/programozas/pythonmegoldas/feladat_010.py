# Írj programot, mely beolvassa egy derékszögű háromszög két befogóját, és megadja
# az átfogójának a hosszát! Az átfogót 2 tizedesjeggyel add meg!

# Szükséges modulok importálása
import math
            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
aBefogo = 0
bBefogo = 0
cAtfogo = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
aBefogo = int(input("Kérem az a-befogót: "))
bBefogo = int(input("Kérem a b-befogót: "))

# Üzleti logika (Business Logic) 
cAtfogo = math.sqrt(math.pow(aBefogo, 2) + math.pow(bBefogo, 2))

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"Befogók: {aBefogo}, {bBefogo}, átfogó: {cAtfogo:.2f}"
print(kimenet)