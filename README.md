# piramide
## Descrizione esecizio
#### Esercizio C# in console che, una volta dati i mattoni in ingresso, ritorna il numero dei piani realizzabili e i mattoni avanzati.

## Descizione soluzione utilizzata

<details>
<summary>Funzione per il calcolo dei piani</summary>
 
```c#
public static int Piani( int mattoni )
{
```
Dichiariamo la funzione dove andare ad inserire le istruzioni per il calcolo dei piani.

<details>
<summary>Controllo del numero dei mattoni</summary>
 
```c#
if(mattoni<=0){
    return 0;
}
```
Controlliamo che i mattoni siano maggiori di 0.
</details>
<details>
<summary>Creazione variabili utili</summary>

```c#
int risultato=0;
int counterFloors=0;
int counterBlocks=1;
```
Creaiamo le variabili che ci serviranno in seguito.
</details>
<details>
<summary>Calcolo dei piani</summary>

```c#
for(counterFloors=0;mattoni>0;counterFloors++){
    risultato = counterBlocks*counterBlocks;
    mattoni-=risultato;
    counterBlocks+=2;
}

if(mattoni<0){
    counterFloors--;
}

return counterFloors;
```
Tramite <i>for</i> calcoliamo in <i><b>counterFloors</b></i> i piani che riusciremo a costruire. Con l'<i>if</i> in caso i mattoni vadano in negativo togliamo un piano, dato che l'ultimo piano non siamo chiaramenti riusciti a costruirlo essendo andati in negativo con i mattoni.
</details>
</details>


<details>
<summary>Funzione per il calcolo dei mattoni rimanenti</summary>

```c#
public static int Rimanenti( int mattoni )
{
```   
Dichiariamo la funzione dove andare ad inserire le istruzioni per il calcolo dei mattoni rimanenti.
<details>
<summary>Dichiarazione variabili utili</summary>

```c#
int piani=Piani(mattoni);
int restoMattoni=mattoni;
int num=1;
```
Creaiamo le variabili che ci serviranno in seguito.
</details>
<details>
<summary>Calcolo dei mattoni rimasti</summary>

```c#
for(int i=0;i<piani;i++){
    restoMattoni-=num*num;
    num+=2;
}
return restoMattoni;
```
Tramite <i>for</i> calcoliamo quanti mattoni ci resteranno dopo aver costruito la piramide, inserendo questo dato nella variabile <i><b>restoMattoni</b></i>. Restituiamo poi la variabile.
</details>
