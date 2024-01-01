let x, y;

function setup() {
    createCanvas(700, 700);
    x = width / 2;
    y = height / 2;
}

function draw() {
    background('darkmagenta');
    noStroke();
    fill('white');
    circle(x, y, 600);
    rect(0, y - 50, 2 * x, 100);
    rect(x - 50, 0, 100, 2 * x);
    fill('darkmagenta');
    circle(x, y, 500);
    fill('white');
    textFont('consolas');
    szovegRajzol('Programozás');
    stroke(1);
}

function szovegRajzol(szoveg) {
    let tomb = szoveg.split(' ');
    if (tomb.length === 3) {
        textSize(50);
        text(tomb[0], x - 180, y - 30);
        text(tomb[1], x - 180, y + 16);
        text(tomb[2], x - 180, y + 62);
    } else if (tomb.length === 2) {
        textSize(50);
        text(tomb[0], x - 180, y - 20);
        text(tomb[1], x - 180, y + 52);
    } else {
        textSize(50);
        text(tomb[0], x - 180, y + 16);
    }
}

function mouseClicked() {
    window.location.replace('./index.html');
}
