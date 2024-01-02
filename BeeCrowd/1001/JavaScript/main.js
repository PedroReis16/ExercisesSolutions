const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});


rl.question("",(answer) => {
    rl.question("",(answer2)=>{
        var result= parseFloat(answer)+parseFloat(answer2);

        console.log(`X = ${result}`);

        rl.close();
    });
});
