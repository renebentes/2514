# Como atualizar e especificar uam LLM?

- O Retrieval-Augmented Generation (RAG) é uma técnica que combina a capacidade de geração de textos de uma LLM com a recuperação de informações de uma base externa;
- Permite acessar um "arquivo" de informações atualizadas antes de responder;
- O RAG resolve a limitação da janela de contexto, uma vez que faz pesquisa em base de dados;

## Alucinações

- Pode inventar informações quando não tem conhecimento suficiente sobre um tópico;
- O RAG garante que a resposta seja baseada em fatos e dados reais, ao invés de depender apenas do treinamento prévio.

## Atualizações

- LLMs são treinadas com conjuntos de dados fixo até uma determinada data;
- O RAG permite que a LLM acesse informações mais recentes ou mais específicas para um domínio.

## Processo

- Recuperação (Retrieval): após a pergunta o RAG busca na base externa trechos mais relevantes;
- Aumento (Augmentation): os trechos são anexados à pergunta inicial;
- Geração (Generation): a LLM usa a pergunta e as informações adicionais para gerar a resposta.