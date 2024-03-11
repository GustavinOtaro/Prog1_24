using static System.Console;

string? nome, email, dtnascimento, sexo, cep, rua, numero, bairro, cidade, uf, pais;

WriteLine("Escreva seu nome:");
    nome = ReadLine();

WriteLine($"Por favor, me informe o seu e-mail.");
    email = ReadLine();

WriteLine("Qual a sua data de nascimento (Favor escrever no formato dd/mm/aaaa)?");
    dtnascimento = ReadLine();

WriteLine("Qual seu sexo/genêro?");
    sexo = ReadLine();

WriteLine("Qual seu CEP?");
    cep = ReadLine();

WriteLine("Qual sua rua?");
    rua = ReadLine();

WriteLine("Qual o número da tua casa?");
    numero = ReadLine();

WriteLine("Qual seu bairro?");
    bairro = ReadLine();

WriteLine("Qual sua cidade?");
    cidade = ReadLine();

WriteLine("Qual sua UF (Estado)?");
    uf = ReadLine();

WriteLine("Qual seu País?");
    pais = ReadLine();

string endereco = $"{cep}, {rua}, n° {numero}, {bairro} {cidade} - {uf}, {pais}.";

WriteLine(
    "---------------Ficha Cadastral---------------"
    + $"\n nome: {nome}"
    + $"\n email: {email}"
    + $"\n data de nascimento: {dtnascimento}"
    + $"\n sexo: {sexo}"
    + $"\n endereço: {endereco}"
    + "\n---------------Ficha Cadastral---------------"
);