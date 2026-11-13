# Lista de Exercícios 41 — Automação com Selenium

Projeto desenvolvido em **C#**, utilizando **Selenium WebDriver** e **MSTest**, com o objetivo de praticar conceitos de automação de testes em aplicações web.

## Sobre o projeto

Este projeto contém exercícios práticos de automação de testes utilizando o formulário de demonstração disponibilizado pelo Selenium.

Foram desenvolvidos três testes automatizados para interagir com diferentes elementos HTML, validar informações e verificar o envio de formulários.

## Tecnologias utilizadas

- **C#** — Linguagem de programação.
- **.NET 10** — Plataforma de desenvolvimento.
- **Selenium WebDriver** — Automação de navegadores.
- **Selenium Support** — Recursos auxiliares para automação.
- **MSTest** — Framework para execução e validação dos testes.
- **Google Chrome** — Navegador utilizado nos testes.
- **Visual Studio Code** — Ambiente de desenvolvimento.

## Estrutura do projeto

```text
ConsoleSelenium41/
│
├── ConsoleSelenium/
│   ├── Program.cs
│   └── ConsoleSelenium.csproj
│
├── ConsoleSelenium.Tests/
│   ├── WebFormularioDesafioTest.cs
│   ├── MSTestSettings.cs
│   └── ConsoleSelenium.Tests.csproj
│
├── ConsoleSelenium41.slnx
├── .gitignore
└── README.md
```

## Exercícios desenvolvidos

### Exercício 1 — Cadastro completo

Automação de preenchimento e envio de formulário, incluindo:

- Preenchimento do campo de texto.
- Preenchimento do campo de senha.
- Preenchimento da área de texto.
- Verificação de campo somente leitura (*Readonly*).
- Envio do formulário.
- Validação da mensagem de confirmação.

### Exercício 2 — Dropdowns e Datalist

Automação de elementos de seleção, incluindo:

- Seleção da opção **Two** no menu dropdown.
- Validação do valor selecionado (`2`).
- Preenchimento do campo Datalist com **Seattle**.
- Envio do formulário.
- Validação da confirmação de envio.

### Exercício 3 — Checkboxes, Radios e Color Picker

Automação de diferentes elementos de formulário, incluindo:

- Verificação do primeiro checkbox.
- Marcação do segundo checkbox.
- Seleção do segundo botão de rádio.
- Alteração da cor no Color Picker para vermelho (`#ff0000`).
- Validação do valor da cor selecionada.
- Envio do formulário e confirmação do resultado.

## Como executar o projeto

### 1. Pré-requisitos

Antes de executar o projeto, é necessário ter instalado:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Google Chrome](https://www.google.com/chrome/)
- [Visual Studio Code](https://code.visualstudio.com/)

Também é necessário ter conexão com a internet para restaurar os pacotes e acessar o formulário de demonstração.

### 2. Clonar o repositório

Abra o terminal e execute:

```bash
git clone https://github.com/Benadinhog/console-selenium-41.git
```

### 3. Acessar a pasta

```bash
cd console-selenium-41
```

### 4. Restaurar as dependências

```bash
dotnet restore
```

### 5. Executar os testes

```bash
dotnet test
```

O comando irá compilar o projeto e executar os testes automatizados utilizando o MSTest.

## Formulário utilizado

Os testes utilizam o formulário oficial de demonstração do Selenium:

https://www.selenium.dev/selenium/web/web-form.html

## Resultados esperados

Ao executar os testes, espera-se que os três exercícios sejam aprovados:

| Exercício | Descrição | Resultado esperado |
|---|---|---|
| 01 | Cadastro completo | Passed |
| 02 | Dropdowns e Datalist | Passed |
| 03 | Checkboxes, Radios e Color Picker | Passed |

**Total esperado: 3 testes aprovados e nenhum teste com falha.**

## Autor

**Bernardo Luiz Monteverde Gonçalves**

Projeto acadêmico desenvolvido como parte da Lista de Exercícios 41, com foco em automação de testes utilizando C#, Selenium WebDriver e MSTest.

---

Projeto desenvolvido para fins educacionais e de aprendizado em testes automatizados.
