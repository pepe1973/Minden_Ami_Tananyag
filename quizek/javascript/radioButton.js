function radioButtonMaker(osztaly, kerdes, adatok) {
    let tartalom = '';

    for (let i = 0; i < adatok.length; i++) {
        tartalom += `<input type="radio" id="${osztaly}_${i}" class="${osztaly}" value='${adatok[i]}' name="${kerdes}">`;
        tartalom += `<label for="${osztaly}_${i}">${adatok[i]}</label><br>`;
    }

    return tartalom;
}
