# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Índice
1. [Titúlo](#dio---trilha-net---fundamentos)
2. [Desafio de projeto](#desafio-de-projeto)
3. [Índice](#índice)
3. [Contexto](#contexto)
4. [Proposta](#proposta)
5. [Solução](#solução)
6. [Autor](#autor)

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
- Status do Desafio: ✅ Concluido ✅
- As partes com `//TODO` foram feitas, todos os metodos estão terminados e testados!
- Abaixo a tabela com as alterações dos métodos na classe [Estacionamento](https://github.com/thiagosilvaantenor/trilha-dot-net-fundamentos-desafio/blob/main/DesafioFundamentos/Models/Estacionamento.cs)
<br><br>
  
| Método | Mudanças |
| ------ | -------- |
| AdicionarVeiculo  | Adicionei uma verificação da placa do carro, ela deve seguir o padrão ``ABC1D23``;<br>Além do `Console.ReadLine()` para ler a placa que o usuario irá digitar, também utilizei de estruturas de repetições para verificar se a placa digitada está correta. | 
| RemoverVeiculo | Criei uma variavel e utilizei o `Console.ReadLine()` para ler a placa;<br>Utilizei a estrutura de repetição `While` e o `TryParse` para verificar e garantir que a quantidade de horas digitada esteja correta; Realizei o calculo do valorTotal;<br>Utilizei o método `Remove` e a placa informada para remover o véiculo.|
| ListarVeiculos | Utilizei do laço de repetição `ForEach` para listar os veículos. |


  
## Autor
<div align="center">
<a href="https://www.linkedin.com/in/thiago-antenor/">
<img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/99970279?v=4" width="100px;" alt="foto do autor"/>
 <br />
 <sub><b>Thiago Silva Antenor</b></sub></a> <a href="https://www.linkedin.com/in/thiago-antenor/" title="Linkedin"> 🧑🏾‍💻</a>


Feito por Thiago Silva Antenor 👨🏾‍💻 Entre em contato!

[![Linkedin Badge](https://img.shields.io/badge/-Thiago-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/thiago-antenor/)](https://www.linkedin.com/in/thiago-antenor/) 
[![Gmail Badge](https://img.shields.io/badge/-thiagoantenor31@gmail.com-c14438?style=flat-square&logo=Gmail&logoColor=white&link=mailto:thiagoantenor31.com)](mailto:thiagoantenor31.com)
</div>
