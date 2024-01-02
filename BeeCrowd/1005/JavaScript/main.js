const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question("",(answer)=>{
    rl.question("",(answer2)=>{

        var result = ((parseFloat(answer)*3.5+parseFloat(answer2)*7.5)/11).toFixed(5);
        
        console.log(`MEDIA = ${result}`);

        rl.close();
    })
});