# ADR: Adoção do Vue.js 3 para a Interface da Aplicação

* **Status:** Aceito

* **Data:** 2026-08-21

* **Decisores:** Grupo do Projeto DotNetShoes

## 1. Contexto

A aplicação requer uma interface Web desacoplada para consumir a Web API desenvolvida em .NET 10.

O prazo de entrega do projeto é de 15 semanas. A equipe possui conhecimento prévio em HTML/JavaScript básico, mas pouca experiência prática com TypeScript e Orientação a Objetos avançada no Front-end.

## 2. Opções Consideradas

* **Vue.js 3 - Composition API:** Oferece reatividade simples via Proxies, excelente documentação oficial e integração nativa com o Vue Router sem necessidade de bibliotecas externas complexas.

## 3. Decisão

Escolhemos o **Vue.js 3**, pois sua curva de aprendizado suave permitirá que a equipe entregue a interface completa dentro do prazo de 15 semanas, sem comprometer a separação de responsabilidades com o Back-end.

## 4. Consequências

### Positivas:

* Rapidez no desenvolvimento da interface (curva de aprendizado rápida).

* Menos tempo gasto configurando pacotes externos, usando as ferramentas oficiais do Vue (*Vue Router* e *Pinia*).

* Código HTML/CSS fácil de manter e entender por todos os integrantes do grupo.


### Negativas / Riscos (Trade-offs):

* Como a equipe não usará TypeScript estrito nesta etapa, o risco de erros em tempo de execução ao manipular os payloads JSON da API aumenta.

* Mitigação: Criaremos testes manuais organizados usando o arquivo `.http` da API para validar os schemas JSON antes da integração

