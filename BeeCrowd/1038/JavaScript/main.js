const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
})

let map = {
    '1':4.00,
    '2':4.50,
    '3':5.00,
    '4':2.00,
    '5':1.50
}

rl.question("",(answer)=>{
    var string = answer.split(' ');
    var result = (map[string[0]] * parseInt(string[1])).toFixed(2);

    console.log(`Total: R$ ${result}`);
    rl.close();
});