function calculate(operation) {
    // PEGA OS VALORES DOS INPUTS Q O USUARIO DIGITAR
    const num1 = parseFloat(document.getElementById('number1').value);
    const num2 = parseFloat(document.getElementById('number2').value);
    let result = 0;

    // VERIFICA SE OS VALORES É NUMEROS VALIDOS

    if (isNaN(num1) || isNaN(num2)) {
        alert('Por favor, insira números válidos.');
        return;
    }

    switch (operation) {
        case 'soma':
            result = num1 + num2;
            break;
        case 'sub':
            result = num1 - num2;
            break;
        case 'mult':
            result = num1 * num2;
            break;
        case 'divi':
            if (num2 === 0) {
                alert('Não é possível dividir por zero.');
                return;
            }
            result = num1 / num2;
            break;
        default:
            alert('Operação inválida.');
            return;
    }

    document.getElementById('result').innerText = `Resultado: ${result}`;
}