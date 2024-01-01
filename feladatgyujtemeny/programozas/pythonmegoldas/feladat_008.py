# Írj programot, mely beolvassa a másodfokú egyenlet együtthatóit, és kiírja, hogy az
# egyenletnek van-e megoldása!

# Szükséges modulok importálása
import math
            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
aEgyutt = 0
bEgyutt = 0
cEgyutt = 0
diszkriminans = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
aEgyutt = int(input("Kérem az első együtthatót: "))
bEgyutt = int(input("Kérem a második együtthatót: "))
cEgyutt = int(input("Kérem a harmadik együtthatót: "))

# Üzleti logika (Business Logic) 
diszkriminans = math.pow(bEgyutt, 2) - 4 * aEgyutt * cEgyutt

if diszkriminans < 0:
	kimenet = "Nics valós megoldás."
else:
	kimenet = "Van valós megoldás."

# Felhasználói felület (User Interface) - kiíratás
print(kimenet)