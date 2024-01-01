# Írj programot, ami beolvassa a körív sugarát és középponti szögét, és kiírja a körív
# területét és a határoló ív hosszát!

# Szükséges modulok importálása
import math

# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
sugar = 0
kozpontiSzog = 0
pi = math.pi
ivHossz = 0
terulet = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
sugar = int(input("Kérem a körív sugarát: "))
kozpontiSzog = int(input("Kérem a körív középponti szögét: "))

# Üzleti logika (Business Logic) 
ivHossz = (sugar * pi * kozpontiSzog) / 180
korivTerulet = (sugar * ivHossz) / 2

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"A körív sugara: {sugar} és központi szöge: {kozpontiSzog}."
kimenet += f"\nÍvhossza: {ivHossz}"
kimenet += f"\nTerülete: {korivTerulet}"
print(kimenet)