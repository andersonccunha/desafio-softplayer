# desafio-softplayer
desafio calculo de juros composto

A demanda
Você deverá criar duas API's uma com dois endpoints e outra com um endpoint:
API Juros
1) Incluir taxa de juros
Responde pelo path relativo "/taxaJuros"
Deve incluir taxa de juros e salvar no banco de dados.
2) Retorna taxa de juros
Responde pelo path relativo "/taxaJuros"
Retorna o último registro cadastrado da taxa de juros
Exemplo: /taxaJuros Resultado esperado para uma taxa de 1%: 0,01
API Calcula Juros
1) Calcula Juros
Responde pelo path relativo "/calculaJuros"
Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final =
Valor Inicial * (1 + juros) ^ Tempo
Valor inicial é um decimal recebido como parâmetro.
Valor do Juros deve ser consultado na API Juros.
Tempo é um inteiro, que representa meses, também recebido como parâmetro.
^ representa a operação de potência.
Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.
Exemplo: /calculaJuros?valorinicial=100&meses=5 Resultado esperado
considerando taxa de juros de 1%: 105,10
2) Sobre o código
Esperamos que a entrega tenha
1. Código fonte no github
2. Aplicação escrita em .net core 3.1
3. Documentação para execução da aplicação
4. Teste unitários e de integração utilizando xunit

O Código
Requisitos : mongodb
suba imagem docker:
docker run -d -p 27017:27017 -p 28017:28017 -e AUTH=no mongo

suba as api's
na pasta softplayer.api.calculo.juros: dotnet run
na pasta softplayer.api.juros: dotnet run

será disponibilizado 2 endpoints

![image](https://user-images.githubusercontent.com/85852245/142753120-825d105c-59b0-4600-b40f-b03f0db8573d.png)


<h2><b>API Juros- Registre e consulte Taxa juros</b><br></h2>
<b>Para consulta</b> deve-se chamar a url :https://localhost:5001/api/juros/taxajuros
e ele retornará a taxa cadastrada.

![image](https://user-images.githubusercontent.com/85852245/142753207-f4ee5ecb-b522-4bfb-9331-c4a5ccaf0ef5.png)

<br>
<b>Para registro</b>, chama-se o mesmo url, mas no método Post e passando como parâmetro o valor da taxa
https://localhost:5001/api/juros/taxajuros?taxa=1
![image](https://user-images.githubusercontent.com/85852245/142753230-d2304947-efcd-4725-9982-693c649d8574.png)
<p>
<h2><b>API Calculo Juros- calcula juros compostos</b></h2>

Essa api, retorna o valor do cálculo do juros, mediante dos parâmetros valor inicial e tempo (meses);
https://localhost:5002/api/juros/calculaJuros?valorinicial=100&tempo=5
![image](https://user-images.githubusercontent.com/85852245/142753364-9f0144ad-06fd-440b-9c49-1bff0181f826.png)


