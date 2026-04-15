# Busca Vetorial

## O que são Embeddings?

- Impressão digital de uma palavra ou frase, representação numérica de texto;
- Conjunto de números (vetor) que captura o **significado semântico** do texto;
- Texto com significados semelhantes terão **embeddings** (vetores) próximos um dos outros em espaço matemático;
- São criados por modelos de linguagens menores, que convertem cada documento, parágrafo ou frase de sua base de dados externa em uma sequência numérica.

## O que é a Busca Vetorial?

- Busca por similaridade vetorial: técnica usada para encontrar os embeddings mais próximos de uma base de dados;
- Ao fazer uma pergunta para o sistema RAG, ela é convertida em um embedding;
- Em seguida, o sistema varre a base de dados e encontra os vetores que estão mais próximos do vetor da pergunta;
- Vetores próximos representam os documentos com significado mais similar a sua pergunta (mais relevante).

## Processo

- Preparação: todos os documentos da base de dados são processados, transformados em embeddings e armazenados dem um banco de dados vetorial;
- Consulta: o ator faz a pergunta;
- Conversão: a pergunta é transformada em embedding;
- Busca: o sistema realiza a busca vetorial para encontrar o embeddings mais parecidos com o da pergunta, retornando os trechos mais relevantes;
- Geração: o texto original dos trechos é anexado à pergunta e enviado à LLM, que gera a resposta final
