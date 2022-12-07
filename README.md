# Projeto ASP.NET Core

![Série](https://img.shields.io/badge/Jeziel%20Almeida-WebAPI-blue)

<h3 align="center">
🚀 Tecnologias utilizadas
<p>&nbsp;</p>
<img src="https://img.shields.io/badge/ASP.NET Core-blue.svg?style=for-the-badge&logo=dotnet&logoColor=white"/>
<img src="https://img.shields.io/badge/Swagger-%23323330.svg?style=for-the-badge&logo=swagger&logoColor=%23F7DF1E">
<img src="https://img.shields.io/badge/git-%23F05033.svg?style=for-the-badge&logo=git&logoColor=white"/>

##  Web API para gerenciamento da VoeAirlines

### Como executar o projeto

**Clonar o repositório**
```
git clone https://github.com/jeziel-almeida/projeto-api-dev-csharp.git
```

**Restaurar os pacotes**

Navegar para a pasta do projeto clonado e executar o seguinte comando:

```
dotnet restore
```

**Executar a aplicação**

Executar o seguinte comando ou utilizar a ferramenta de Debug do Visual Studio u Visual Studio Code (normalmente pressionando F5):
```
dotnet run
```

## Como testar a API

**Acessar a interface de teste do Swagger***
A UI do Swagger estará disponível na URL https://localhost:[porta]/swagger (a porta pode variar e deve ser observada no terminal ao executar o projeto).

**Consumir os endpoints**
Sugestão de ordem para testar a aplicação:

1) Criar, editar e excluir Aeronaves
2) Criar, editar e excluir Manutenção
3) Criar, editar e excluir Piloto
4) Criar, editar e excluir Voo
