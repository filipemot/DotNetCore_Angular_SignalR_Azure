**Introdução**

Em alguns projetos se faz necessário a atualização das páginas quando houver alguma atualização, uma prática bem comum porém nada eficiente é adicionar no javascript um setInterval de x segundos e chamar a função para atualizar a tela. 
Uma forma eficiente de fazer essa atualização é utilizar WebSocket, onde o servidor e o cliente se comunica através de métodos que são executados apenas quando invocados pelo servidor, o websocket para plataformas Microsoft é o SignalR. Nesse posts mostrarei como configura um projeto bem simples com a integração Cliente x Servidor utilizando essa tecnologia e publicada no Azure.


Nesse projeto temos um exemplo de uma aplicação DotNetCore com Angular, utilizando o SignalR como Websocket