// Zadanie 1: 
// Napisz program, który używając pętli while wydrukuje liczby od 1 do 10.


// let x = 1;
// while (x <= 10) {
//     console.log(x);
//     x++;
// }


// Zadanie 2: Suma liczb
// Napisz program, który używając pętli while znajdzie sumę liczb od 1 do 100.


// let licznik = 0;
// let suma = 0;

// while (licznik <= 100) {
//     suma += licznik;
//     licznik++;
// }

// console.log(suma);


// Zadanie 3: 
// Napisz program, który znajduje wszystkie czynniki liczby, używając pętli while.


// let n = 20; 
// let dzielnik = 2;

// while (n !== 1) {
//     while (n % dzielnik === 0) {
//         console.log(dzielnik);
//         n /= dzielnik;
//     }
//     dzielnik++;
// }

// Zadanie 4: Ciąg arytmetyczny
// Napisz program, który generuje pierwsze 10 elementów ciągu arytmetycznego o różnicy 3, zaczynając od 1.


// let i = 0;
// let ciag = 1;

// while (i < 10) {
//     console.log(ciag);
//     ciag += 3;
//     i++;
// }


// Zadanie 5: Sprawdzenie liczby pierwszej
// Napisz program, który sprawdzi czy dana liczba jest liczbą pierwszą.

let i = 2;
let liczba = 6;
let czyPierwsza = true;

while (i < liczba - 1) {
    if (liczba % i === 0) {
        console.log(`${liczba} % ${i} = ${liczba % i}`);
        czyPierwsza = false;
        break;
    }
    i += 1;
}

console.log(czyPierwsza);


// Zadanie 6: Suma parzystych i nieparzystych
// Napisz program, który znajdzie sumę parzystych i nieparzystych liczb od 1 do 100.


// let i = 1;
// let suma = 0;
// let sumaParzystych = 0;
// let sumaNieparzystych = 0;

// while (i < 101) {
//     if (i % 2 === 0) {
//         sumaParzystych += i;
//     } else {
//         sumaNieparzystych += i;
//     }
//     i++;
// }

// suma = sumaParzystych + sumaNieparzystych;

// console.log(`Suma wszystkich liczb: ${suma}`);
// console.log(`Suma liczb parzystych: ${sumaParzystych}`);
// console.log(`Suma liczb nieparzystych: ${sumaNieparzystych}`);

// Zadanie 7: Wyświetl znaki
// Napisz program, który wydrukuje znak '*' 10 razy w jednym rzędzie.

// let gwiazdki = '';

// for (let i = 0; i < 10; i++) {
//     gwiazdki += '*';
// }

// console.log(gwiazdki);

// Zadanie 8: Ciąg geometryczny
// Napisz program, który generuje pierwsze 10 elementów ciągu geometrycznego o ilorazie 2, zaczynając od 1.


// let k = 0;
// let ciag = 1;

// while (k < 10) {
//     console.log(ciag);
//     ciag *= 2;
//     k += 1;
// }


