# Írj programot, mely beolvassa a téglatest három élének hosszát, és kiírja a
# felszínének és térfogatának mérőszámát!
            
# Adatszerkezet (Data Structure)
# (Globális) Változók definiálása
aOldal = 0
bOldal = 0
cOldal = 0
felszin = 0
terfogat = 0
kimenet = ""

# Felhasználói felület (User Interface) - bekérés
aOldal = int(input("Kérem az a-oldalt: "))
bOldal = int(input("Kérem a b-oldalt: "))
cOldal = int(input("Kérem a c-oldalt: "))

# Üzleti logika (Business Logic) 
felszin = 2 * (aOldal * bOldal + aOldal * cOldal + bOldal * cOldal)
terfogat = aOldal * bOldal * cOldal

# Felhasználói felület (User Interface) - kiíratás
kimenet = f"Téglatest oldalai: {aOldal}, {bOldal}, {cOldal}"
kimenet += f"\nFelszín: {felszin}"
kimenet += f"\nTérfogat: {terfogat}"
print(kimenet)