[Vissza](../README.md)

# "Tétel" szint

Egy szakközépiskolában ezeket kérik az első években az iskola által tanított nyelven.

Gyakorlásképpen átírhatod a pszeudokódot bármilyen másik programnyelvre.

[Tételekről bővebben](http://alea.uw.hu/c/Progr_tetelekRendezesek.htm)

## Egy sorozathoz egy érték

### Összegzés

```
Eljárás Összegzés
s:=0
Ciklus i:=1-től N-ig
s:=s+A[i] //az s-be tegyük be s korábbi értékének és az A[i]-nek az összegét
Ciklus vége
Ki: s
Eljárás vége
```

### Eldöntés

```
Eljárás Eldönt
i:=1
Ciklus amíg i<=N És A[i] nem T tulajdonságú
i:=i+1
Ciklus vége
VAN:=i<=N // Van értéke igaz, ha i<=N igaz, egyébként hamis
Eljárás vége
```

### Kiválasztás

```
Eljárás Kiválasztás
i:=1
Ciklus amíg A[i] nem T tulajdonságú //nincs szükség az i<=N vizsgálatra, mert biztosan
 van ilyen elem
i:=i+1
Ciklus vége
Sorsz:=i // a T tulajdonságú elem sorszáma kerül a Sorsz nevű változóba
Eljárás vége
```

### Lineáris keresés

```
Eljárás Lin_Keresés
i:=1
Ciklus amíg i<=N És A[i] nem T tulajdonságú
i:=i+1
Ciklus vége
Van:=i<=N
Ha van akkor Ki: i
Eljárás vége // csak egy elemet keres
```

### Logaritmikus keresés

```
Eljárás Log_Keresés
E:=1: F:=N
Ciklus // K-ban lesz az intervallum közepe
K:=(E+F) DIV 2 // A DIV továbbra is egész osztás
Ha A[K]<X akkor E:=K+1
Ha A[K]>X akkor F:=K-1
Amíg E>F vagy A[K]=X // Ha összeért a két részintervallum, vagy megtaláltam, akkor vége
Van:=E<=F
Ha van akkor Sorsz:=K
Eljárás vége
```

### Megszámlálás

```
Eljárás Megszámlálás
s:=0 // nem szabad elfelejteni
Ciklus i:=1-től N-ig
Ha A[i] T tulajdonságú akkor s:=s+1 // s értékét növeljük eggyel
Ciklus vége
Ki: s
Eljárás vége
```

### Minimum- / maximum-kiválasztás

```
Eljárás Maximum
Max:=A[1]
Ciklus j:=2-től N-ig
Ha Max<A[j] akkor Max:=A[j]
Ciklus vége
Ki: Max
Eljárás vége
```

## Egy sorozathoz egy sorozat

### Kiválogatás

```
Eljárás Kiválogat
j:=0 // Nem szabad elfelejteni
Ciklus i:=1-től N-ig
Ha a[i] T tulajdonságú akkor
j:=j+1
B[j]:= i // a sorszámot tároljuk
Elágazás vége
Ciklus vége
Eljárás vége
```

## Több sorozathoz egy sorozat

### Metszetképzés

```
Eljárás Metszet
szamol:=0
Ciklus i:=1-től N-ig // vesszük A[] elemeit
j:=1
Ciklus amíg j<=M és A[i]<>B[j] //amíg nincs az A[i]-vel egyező, vagy van még elem
j:=j+1 // vesszük B[] elemeit
Ciklus vége
Ha j<=M akkor // ha volt egyező eleme
szamol:=szamol+1; C[szamol]:=A[i] //betesszük C[] vektorba
Elágazás vége
Ciklus vége
Eljárás vége
```

### Egyesítés

```
Eljárás Unió
Ciklus i:=1-től N-ig
C[i]:=A[i] // először az A[] elemei átkerülnek a C[]-be
Ciklus vége
szamol:=N
Ciklus j:=1-től M-ig
i:=1
Ciklus amíg i<=N és A[i]<>B[j] // B[]-beli elemhez keresünk A[]-ból
i:=i+1
Ciklus vége
Ha i>N akkor //ha nincs közös elem
szamol:=szamol+1
C[szamol]:=B[j] //akkor berakjuk az elemet C[]-be
Elágazás vége
Ciklus vége
Eljárás vége
```

### Összefuttatás

```
Eljárás Összefuttat
i:=1: j:=1: k:=0
A[N+1]:= +α: B[M+1]:= +α
Ciklus amíg i<N+1 vagy j<M+1
K:=k+1
Elágazás
A[i]<B[j] esetén C[k]:=A[i]: i:=i+1
A[i]>B[j] esetén C[k]:=B[j]: j:=j+1
A[i]=B[j] esetén C[k]:=A[i]: i:=i+1: j:=j+1
Elágazás vége
Ciklus vége
Eljárás vége
```

## Rendezések

### Buborék rendezés

```
Eljárás Buborék
r:=n; csere:=hamis
Ciklus amíg r>1 és Nem csere
csere:=igaz
Ciklus i:=1-től r-1-ig
Ha A[i]>A[i+1] akkor //itt a páronkénti összehasonlítás
Csere(A[i], A[i+1])
csere:=hamis
Elágazás vége
i:=i+1
Ciklus vége
r:=r-1
Ciklus vége
Eljárás vége
```

### Rendezés minimum / maximum kiválasztással

```
Eljárás MaxKivRend
r:=n
Ciklus amíg r>1
i:=1; m:=A[1]; k:=1
Ciklus amíg i<r
Ha A[i]>m akkor
M:=A[i]; k:=i
Elágazás vége
i:=i+1
Ciklus vége
A[k]:=A[r]; A[r]:=m
r:=r-1
Ciklus vége
Eljárás vége
```