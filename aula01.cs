int main ()
{
	string nome;
	int x, y, z, operacao;
	console.writeIn("digite seu nome");
	nome = console.readline();

	console.writeIn("digite o valor de y");
	y = converte.Toint32()(console.readline());

	console.writeIn("digite o valor de x");
	x = converte.Toint32()(console.readline());

	console.writeIn("Qual operação você quer fazer? 1 -> +, 2 -> - 3 -> *, 4 -> /")
	operacao = converte.Toint32()(console.readline())

	if (operacao = 1
	{
		console.writeIn("O valor da operação é: " + (x + y))
	}

	if (operacao = 2)
	{
		console.writeIn("O valor da operação é: " + (x - y))
	}

	if (operacao = 3)
	{
		console.writeIn("O valor da operação é: " + (x * y))
	}	

	if (operacao = 4)
	{
		console.writeIn("O valor da operação é: " + (x / y))
	}

	else 
	{
		console.writeIn("Por favor, selecione um número de 1 a 4.")
	}
}