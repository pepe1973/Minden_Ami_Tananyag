let quiz = document.getElementById('quiz');
let eredmeny = document.getElementById('eredmeny');

kerdesekValaszok = kerdesekValaszok.sort((a, b) => 0.5 - Math.random());

let urlap = '<form>';
for (let i = 0; i < kerdesekValaszok.length; i++) {
    kerdesekValaszok[i].valaszok = kerdesekValaszok[i].valaszok.sort(
        (a, b) => 0.5 - Math.random()
    );

    if (kerdesekValaszok[i].tipus === 'radioButton') {
        urlap += `<h2>${kerdesekValaszok[i].kerdes}</h2>`;
        urlap += `<div class="urlapKep"><img src="${kerdesekValaszok[i].kep}" /></div>`;
        urlap += radioButtonMaker(
            kerdesekValaszok[i].osztaly,
            kerdesekValaszok[i].kerdes,
            kerdesekValaszok[i].valaszok
        );

        urlap += `<button onClick="kiertekel(event, ${i})">Kiértékel</button>`;
        urlap += `<div id="eredmeny_${i}"></div>`;
    } else if (kerdesekValaszok[i].tipus === 'checkBox') {
        urlap += `<h2>${kerdesekValaszok[i].kerdes}</h2>`;
        urlap += `<div class="urlapKep"><img src="${kerdesekValaszok[i].kep}" /></div>`;
        urlap += checkBoxMaker(
            kerdesekValaszok[i].osztaly,
            kerdesekValaszok[i].valaszok
        );

        urlap += `<button onClick="kiertekel(event, ${i})">Kiértékel</button>`;
        urlap += `<div id="eredmeny_${i}"></div>`;
    }
}
urlap += '</form>';

quiz.innerHTML = urlap;

function kiertekel(e, index) {
    e.preventDefault();
    let kiertekel = document.getElementById(`eredmeny_${index}`);
    kiertekel.style.backgroundColor = '#ccc';
    kiertekel.style.padding = '1em';
    kiertekel.style.marginTop = '1em';

    if (kerdesekValaszok[index].tipus === 'checkBox') {
        let selectedElemek = document.querySelectorAll(
            `.${kerdesekValaszok[index].osztaly}`
        );

        let feleletek = [];

        for (let i = 0; i < selectedElemek.length; i++) {
            if (selectedElemek[i].checked === true) {
                feleletek.push(kerdesekValaszok[index].valaszok[i]);
            }
        }

        feleletek.sort();
        kerdesekValaszok[index].joValaszok.sort();

        if (tombEgyenloseg(feleletek, kerdesekValaszok[index].joValaszok)) {
            let szoveg = `<div class='kiertekel'>Helyes válasz!</div>`;
            kiertekel.innerHTML = szoveg;
        } else {
            let jo = '<ul>';
            for (
                let i = 0;
                i < kerdesekValaszok[index].joValaszok.length;
                i++
            ) {
                jo += `<li style="padding-bottom: 1em;">${kerdesekValaszok[index].joValaszok[i]}</li>`;
            }
            jo += '</ul>';
            let szoveg = `<div class='kiertekel'>Helytelen válasz!</div>`;
            console.log(feleletek);
            console.log(kerdesekValaszok[index].joValaszok);
            szoveg += `<div class='kiertekel'>Helyes válasz: </div>`;
            szoveg += jo;
            kiertekel.innerHTML = szoveg;
        }
    } else if (kerdesekValaszok[index].tipus === 'radioButton') {
        let selectedElemek = document.querySelectorAll(
            `.${kerdesekValaszok[index].osztaly}`
        );

        let feleletek = [];

        for (let i = 0; i < selectedElemek.length; i++) {
            if (selectedElemek[i].checked === true) {
                feleletek.push(kerdesekValaszok[index].valaszok[i]);
            }
        }

        if (tombEgyenloseg(feleletek, kerdesekValaszok[index].joValaszok)) {
            let szoveg = `<div class='kiertekel'>Helyes válasz!</div>`;
            kiertekel.innerHTML = szoveg;
        } else {
            let szoveg = `<div class='kiertekel'>Helytelen válasz!</div>`;
            console.log(feleletek);
            console.log(kerdesekValaszok[index].joValaszok);
            szoveg += `<div class='kiertekel'>Helyes válasz: ${kerdesekValaszok[index].joValaszok}</div>`;
            kiertekel.innerHTML = szoveg;
        }
    }
}

function tombEgyenloseg(a, b) {
    return (
        Array.isArray(a) &&
        Array.isArray(b) &&
        a.length === b.length &&
        a.every((val, index) => val === b[index])
    );
}
