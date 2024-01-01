function checkBoxMaker(osztaly, adatok) {
    let tartalom = '';

    for (let i = 0; i < adatok.length; i++) {
        tartalom += `<input type="checkbox" id="${osztaly}_${i}" value="${adatok[i]}" class="${osztaly}">`;
        tartalom += `<label for="${osztaly}_${i}">${adatok[i]}</label><br>`;
    }

    return tartalom;
}
