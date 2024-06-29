# Conta Bancária em C# - Exercicio usando os conceitos de Herança  📚 👩🏻‍💻  

Este é um projeto simples em C# que demonstra o uso de herança entre classes para criar uma conta bancária "Principal" 
e uma Empresarial, onde a conta empresarial herda da conta principal.

## Descrição 📝 🛠️

O projeto consiste em duas classes principais:

1. **Account**: Essa é a classe base que representa uma conta bancária principal. 
contém os metodos de depositar e sacar e a implementação do `StringBuilder` para formatar o `output`.

2. **BusinessAccount**: Essa é uma subclasse de `Account` que herda todos os atributos e métodos da classe base. Além disso, ela possui um atributo adicional:
contém um metodo `empréstimo`  faz a verificação de valores para poder realizar o emprestimo, se for `true` o emprestimo
vai cair na `conta Princial.
   


## Como Clonar e Executar o Projeto ❤️ 📚
1. Certifique-se de ter o .NET SDK instalado na sua máquina.
2. Abra o terminal ou prompt de comando.
3. Clone o repositório com o seguinte comando:
    ```bash
    git clone https://github.com/dalleth-martinss/AccountBank-UsingInheritance
    ```
    
4. Navegue até o diretório do projeto:
    ```bash
    cd  nome da pasta que foi feito o fork
    ```
5. Compile o projeto:
    ```bash
    dotnet build
    ```
6. Execute o programa:
    ```bash
    dotnet run
    ```
7. Ou simplesmente pode abrir direto pela IDEA Visual Studio. 

 ## Contribuições 📌 ⚙️

Contribuições são sempre bem-vindas! Para contribuir, por favor, faça um fork do repositório e crie um Pull Request com suas alterações.

## Licença 😎

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](https://opensource.org/license/MIT) para mais detalhes.

---

Desenvolvido por [Dálleth Martins](https://github.com/dalleth-martinss)

