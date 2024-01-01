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
x1 = 0
x2 = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
aEgyutt = int(input("Kérem az első együtthatót: "))
bEgyutt = int(input("Kérem a második együtthatót: "))
cEgyutt = int(input("Kérem a harmadik együtthatót: "))

# Üzleti logika (Business Logic) 
diszkriminans = math.pow(bEgyutt, 2) - 4 * aEgyutt * cEgyutt

if diszkriminans < 0:
	kimenet = "Nics valós megoldás."
elif diszkriminans == 0:
	x1 = -bEgyutt / (2 * aEgyutt)
	kimenet = f"Egyetlen valós megoldás: {x1}"
else:
	x1 = (-bEgyutt - math.sqrt(diszkriminans)) / (2 * aEgyutt)
	x2 = (-bEgyutt + math.sqrt(diszkriminans)) / (2 * aEgyutt)
	kimenet = f"Első valós megoldás: {x1}"
	kimenet += f"\nMásodik valós megoldás: {x2}"

# Felhasználói felület (User Interface) - kiíratás
print(kimenet)