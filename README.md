# Desafio: Calculadora de Prêmio de Seguro

Você é um desenvolvedor em uma seguradora digital que precisa calcular o valor do prêmio de um seguro de carro. Dependendo do tipo de cobertura e do perfil do motorista, o valor varia.

## Requisitos

- **Entrada**: duas linhas  
  1. Tipo de cobertura: `"basica"`, `"intermediaria"` ou `"completa"`  
  2. Perfil do motorista: `"novato"`, `"experiente"` ou `"profissional"`  

- **Saída**: valor do prêmio (string)

## Tabela de Valores

| Cobertura      | Novato | Experiente | Profissional |
| -------------- | ------ | ---------- | ------------ |
| **basica**     | 200    | 150        | 100          |
| **intermediaria** | 300    | 250        | 200          |
| **completa**   | 500    | 400        | 300          |

## Exemplos

| Entrada                   | Saída |
| ------------------------- | ----- |
| basica<br>novato          | 200   |
| completa<br>experiente    | 400   |
| intermediaria<br>profissional | 200   |

## Código em C#

