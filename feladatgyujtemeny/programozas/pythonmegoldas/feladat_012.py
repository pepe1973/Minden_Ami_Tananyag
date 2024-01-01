# Írj programot, mely beolvassa egy kör átmérőjét, és kiírja a kör kerületét és
# területét! A pi értékének meghatározásához használd a Math.PI értéket!

# Szükséges modulok importálása
import math

# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
sugar = 0
kerulet = 0
terulet = 0
pi = math.pi
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
sugar = int(input("Kérem a kör sugarát: "))

# Üzleti logika (Business Logic) 
kerulet = 2 * sugar * pi
terulet = math.pow(sugar, 2) * pi 

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"A kör sugara: {sugar}"
kimenet += f"\nKerület: {kerulet}"
kimenet += f"\nTerület: {terulet}"
print(kimenet)