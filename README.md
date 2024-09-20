<h1>SONHOS OUTRORA</h1>

<h3>Integrantes: João Paulo B. P. C. Filho, Kevin Novais Bezerra, Murilo Rangel de França e Nicollas Lemes de Matos</h3>

<h3>Série: 2º Programação de Jogos Digitais</h3>
<br>
<h3>- Tema:</h3>
O trabalho baseia-se no tema “São Paulo 470 anos” com isso decidimos desenvolver uma temática atemporal, por isso escolhemos o “racismo e a escravidão” que são assuntos que repercutem até os dias de hoje, queríamos mostrar como isso ainda persiste só que de forma mascarada, com isso vieram as pesquisas sobre os locais de São Paulo e suas histórias. Como primeiro local escolhemos o Bairro da Liberdade, muito pelo seu contexto histórico antes chamado de Campo da Força onde os escravos e transgressores da lei eram mortos sendo essa a sua "Liberdade" a região também era ocupada majoritariamente por pessoas negras e hoje é conhecido como Japão-Liberdade uma maneira de tentar apagar o passado desse lugar, outro motivo foi a estátua da Madrinha Eunice (fundadora da primeira escola de samba de São Paulo e ainda funcional, a Lavapés, na década de 30 e foi ativista do movimento negro), em 2023 ocorreu um discussão a respeito de um show que cobriu totalmente a estátua gerando uma grande repercussão e pensamos em adicionar ela ao jogo, como queríamos representar o passado, a outra parte do jogo seria uma vila representado um tempo muito antes da industrialização da cidade de São Paulo.

- Proposta do jogo:<br>
A proposta do nosso grupo é fazer um game conceitual (são jogos, onde os jogadores são submetidos a estímulos que visam desenvolver o entendimento individual/coletivo de alguns conteúdos gerais e específicos do jogo), onde o jogador, no papel de um jovem estudante periférico, deve investigar o desaparecimento da estátua de Madrinha Eunice que se localiza no bairro da Liberdade. Ao longo da história o jogador descobrirá que a estátua de alguma forma foi parar no passado, e agora terá que recuperá-la. Tendo de coletar pistas espalhadas pelas fases, no passado em uma vila, encontrará a estátua de que foi levada. No entanto fica subentendido ao jogador que na verdade, tudo não se passa de um sonho e que a estátua não foi levada ao passado de fato, mas sim que o seu sentido ficou preso ao passado

- Nome do Jogo:<br>
O jogo recebeu o nome Sonho De Outrora que é um título poético e evocativo por sugerir memórias, esperanças e aspirações do passado. "Outrora" é uma palavra que remete a tempos passados, dando um tom nostálgico e reflexivo. "Sonhos" referem-se aos desejos ou ambições que houveram em tempos anteriores. Juntas, estas palavras implicam em um retorno emocional entre passado e presente.

- Protagonista:<br>
O protagonista é um estudante de 17 anos, chamado Juan Martins, tivemos a ideia de ele ser um estudante por nós sermos estudantes e ser possível se sentir como o personagem e por temos experiências próprias nesse meio, ele é inocente, sonhador e corintiano a ideia da inocência e do sonhador se vem pelo fato dele ser jovem e não tem experiências de como é o mundo por ser um jovem moderno tem consciência do que seu povo passou e seus “privilégios” que tem de viver na sociedade moderna, o lado torcedor ao Corinthians foi por causa que grande parte do grupo é corintiano e que o futebol é muito importante para vários brasileiros e integrantes do grupo.

- História:<br>
Após um dia cansativo de aula Juan decide deita-se em sua cama e dormir. Nisso ele acorda no Bairro da Liberdade e descobre que a estátua de Madrinha Eunice desapareceu, explorando melhor o bairro e coletando pistas espalhadas, consegue descobrir que ela está no passado e que precisa encontrá-la nisso precisa procurar por uma porta específica que o levará até o passado. Conseguindo encontrar a porta é levado ao passado em uma pequena vila onde terá de encontrar a estátua que foi dividida em diferentes pedaços e deve reconstrui-la, Juan acordará vendo que foi apenas um sonho.

- Tela de Início:<br>
A tela inicial do jogo foi feita no Piskel, o fundo tem a cor azul para representar o céu, pois na teoria das cores o azul representa a harmonia, os postes vermelhos em referência a própria Liberdade junto com lanternas japonesas, as portas foram colocadas por causa que no jogo elas são o meio que faz o personagem trocar de cenário, as flores são para representar a parte mais rural sendo o passado do jogo.

- Cenário:<br>
A primeira é onde você inicia o jogo que é a sua casa onde há três cômodos, a sala, o quarto e a cozinha, também possui um banheiro, na sala possui sofá, tv, uma mesinha, na cozinha possui uma mesa, algumas cadeiras, um fogão, geladeira e alguns armários, no quarto tem a cama, uma mesinha, guarda-roupa e uma bateria, no banheiro tem a pia, banheira, cesto de lavar roupa e uma máquina de lavar. Na segunda cena se passa na liberdade, onde tem prédios, ruas, calçadas, pessoas, pistas espalhadas brilhando em amarelo. Há terceira cena se passa no passado em uma pequena vila, campo aberto, árvores, poço, casas de madeira, a estátua da Madrinha Eunice.

- Músicas:<br>
A Vida É Desafio - Racionais MC's, Afro-X<br>
Otus 500 - Racionais MC's<br>
Vivão e Vivendo - Racionais MC's<br>
(A)Bala - Fabio Brazza, Paiva Prod, Tião Preto<br>
Rua da Glória - Aloysio Letra<br>
São, São Paulo - Tom Zé<br>
Sampa Midnight - Itamar Assumpção<br>

<h3>Explicação do Código:</h3>

<h3>Câmera:</h3>

- Classes e Objetos da câmera:<br>
A classe "câmera" herda as funções de MonoBehaviour, que é uma classe base do Unity, que permite que o script seja associado a objetos no Unity (como a câmera).

- Uso de Atributos Públicos e Privados:<br>
Fizemos a utilização de atributos públicos e privados. Deixamos todas as propriedades e variáveis privadas, menos a variável "sensibilidade", que deixamos pública, para que o usuário possa definir a sensibilidade que deseja para o mouse.

- Void Start():<br>
Usamos o método Start, para configurar o cursor do mouse, tornando-o invisível e fixo no centro da tela usando Cursor.lockState.

- Void Update():<br>
Usamos este método para a captura do movimento do mouse usando Input.GetAxis("Mouse X") e Input.GetAxis("Mouse Y"), multiplicando esses valores pela variável "sensibilidade".

- Uso do "Transform":<br>
O transform.eulerAngles, foi usado para alterar a rotação da câmera com base no movimento do mouse, aplicando a rotação nos eixos X e Y.

- Entrada de Informações a partir do Usuário:<br>
Usamos Input.GetAxis("Mouse X"), para controlar a câmera no eixo X, e Input.GetAxis("Mouse Y"), para controlar a câmera no eixo Y. Essas propriedades permitem capturar os movimentos do mouse do jogador, sendo convertidos em valores de rotação da câmera.

- O uso do Cursor do Mouse:<br>
Usamos as propriedades Cursor.visible, para sumir com o mouse, e o Cursor.lockState, para travar o mouse no centro da tela. Essas propriedades são características típicas de jogos em primeira pessoa.
<br>
<h3>Movimentação:</h3>

- Classes e Objetos:<br>
A classe "movimento" herda de MonoBehaviour, permitindo que o script seja anexado à objetos em Unity. Usamos essa classe para movimentar, controlar, a câmera, que será o nosso personagem principal (jogo em primeira pessoa).

- Variáveis de Instância:<br>
Vector3 m: essa variável é um vetor de posição tridimensional (eixos X, Y e Z). Ela é usada para armazenar os valores de movimento e definir a posição do objeto.

- Void Start():<br>
Nesse método definimos a posição inicial do nosso objeto, usando transform.position e o vetor m. Após essa definição, a variável m é redefinida para (0, 0, 0).

- Void Update():<br>
Este método é utilizado para detectar entradas do teclado e mover o objeto com base nelas (as entradas).

- Captura de Entrada do Usuário:<br>
Utilizamos a função Input.GetKey(), para detectar se determinada tecla está sendo pressionada:
  - KeyCode.D: Move o objeto para a direita (aumentando o valor de m.x).
  - KeyCode.A: Move o objeto para a esquerda (diminuindo o valor de m.x).
  - KeyCode.W: Move o objeto para frente (aumentando o valor de m.z).
  - KeyCode.S: Move o objeto para trás (diminuindo o valor de m.z).

A função transform.Translate(m) aplica movimento ao objeto baseado nos valores do vetor m.

- Manipulação de Transformações:<br>
transform.position: usamos está propriedade para definir a posição do objeto na cena. Essa propriedade também é usada para restringir o movimento do objeto dentro da cena.

- Limites de Movimento:<br>
Impusemos limites às coordenadas X, Y e Z do objeto. Isso evita que ele ultrapasse os limites da cena.

- Reset de Movimento:<br>
No final de cada frame, o vetor m é redefinido para 0, usando a função m.Set(0, 0, 0). Isso garanti que o movimento só ocorra quando o jogador pressionar uma tecla, e que o objeto pare de se mover quando nenhuma tecla estiver sendo pressionada.

- Estrutura Condicional (if):<br>
Fizemos o uso de várias condições "if". Elas são usadas para verificar a entrada do usuário, e aplicar as restrições de movimento, garantindo que o objeto se comporte conforme o esperado. Um exemplo é o trecho:<br>
"if (transform.position.y > 2.0){
      transform.position = new Vector3(transform.position.x, 2.0f, transform.position.z);
  }

  if (transform.position.y < 2.0)
  {
      transform.position = new Vector3(transform.position.x, 2.0f, transform.position.z);
  }"<br>
O trecho acima serve para garantir que quando o jogador rotacionar a câmera no eixo X e Z, a câmera não se movimente no eixo Y.
<br>
<h3>Coletar:</h3>

- Collision classes e objetos:<br>
A classe "coletar" herda de MonoBehaviour, permitindo que o script seja anexado ao objeto do Unity.

- Variáveis de Instância:<br>
int pegar: essa variável do tipo inteiro é utilizada para armazenar a contagem de itens coletados. Essa variável é iniciada com o valor 0.

- Função Start():<br>
Esse método é executado uma vez, no início do jogo. Aqui, a variável "pegar" é inicializada com o valor 0.

- Detecção de Colisões:<br>
Em nosso código, utilizamos os dois principais métodos para detectar interações físicas no Unity:
  - OnCollisionEnter(Collision collision):<br>
Esse método é chamado automaticamente quando o objeto ao qual o script está anexado colide com outro objeto com Collider e Rigidbody.<br>
Usamos em nosso código, collision.gameObject.tag, para identificar o tipo de objeto com o qual ocorreu a colisão, verificando sua tag (em nosso código, "caixa"). Se o objeto colidido tiver a tag "caixa", o código executa Destroy(collision.gameObject), o que remove esse objeto da cena.

  - OnTriggerEnter(Collider collision):<br>
Esse método é chamado, exclusivamente, quando o objeto entra em um Trigger Collider.<br>
Similar ao método anterior (collision.gameObject.tag), ele usa collision.gameObject.tag para verificar a tag do objeto.<br>
Em nosso código também usamos um Debug.Log para exibir no console tanto a tag do objeto, quanto o valor de pegar.



- Manipulação de Tags:<br>
O uso de tags permite identificar o tipo de objeto com o qual o personagem está interagindo. As tags são strings atribuídas a objetos no Unity para facilitar sua categorização e manipulação. Um exemplo, é para diferenciar os objetos com a tag "caixa", de outros objetos.

- Estrutura Condicional (switch):<br>
Utilizamos switch case, em nosso código, para comparar a tag do objeto colidido. Se a tag for "caixa", o código deletara esse objeto da cena.

- Função Destroy():<br>
A função Destroy() é usada para remover um objeto do jogo, no caso, o objeto que possui a tag "caixa". Isso simula a coleta do objeto, removendo-o da cena quando o jogador interage com ele.

- Debugging:<br>
Usamos Debug.Log() para exibir no console a tag do objeto com o qual houve colisão, e o valor de pegar, ajudando a monitorar o comportamento do código durante a execução.

- Interações Físicas (Colliders e Triggers):<br>
OnCollisionEnter() é usado para detectar colisões físicas quando os objetos se chocam.<br>
OnTriggerEnter() detecta quando um objeto entra em um Trigger Collider (colisores que permitem a passagem sem colisão física). Triggers são úteis para detecção de áreas ou eventos, como entrar em uma área que desencadeia algum efeito no jogo.
<br>

<h3>Assets utilizados:</h3>
- FREE - Modular Character - Fantasy RPG Human Male<br>https://assetstore.unity.com/packages/3d/characters/humanoids/humans/free-modular-character-fantasy-rpg-human-male-228952<br>
- Villager Animations FREE<br>https://assetstore.unity.com/packages/3d/animations/villager-animations-free-157920<br>
- FREE Low Poly Human - RPG Character<br>https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/free-low-poly-human-rpg-character-219979<br>
- Low Poly Farm Pack Lite<br>https://assetstore.unity.com/packages/3d/environments/industrial/low-poly-farm-pack-lite-188100<br>
- RPG Poly Pack - Lite<br>https://assetstore.unity.com/packages/3d/environments/landscapes/rpg-poly-pack-lite-148410<br>
- Farm Animals Set<br>https://assetstore.unity.com/packages/3d/farm-animals-set-97945<br>
- City People Lite<br>https://assetstore.unity.com/packages/3d/characters/city-people-lite-260446<br>
- Simple City pack plain<br>https://assetstore.unity.com/packages/3d/environments/urban/simple-city-pack-plain-100348<br>
- Free: House Interior<br>https://assetstore.unity.com/packages/3d/props/interior/free-house-interior-223416<br>
- FREE Skybox Extended Shader<br>https://assetstore.unity.com/packages/vfx/shaders/free-skybox-extended-shader-107400<br>
- Madrinha Eunice<br>https://sketchfab.com/3d-models/madrinha-eunice-deolinda-madre-fef0930308d34d3681dbf8845f64dc59<br>
- Paper Low<br>https://sketchfab.com/3d-models/paper-low-bab9b0a4a3194165be4ac939c565d39f<br>

Os assets da Madrinha Eunice e da Paper Low foram pegos no site Sketchfab

<br>
Link do drive:
https://drive.google.com/drive/folders/1ohX-2R7PknoC_GAVfwDm20zMsjciNwbL?usp=drive_link
<br>
<br>

![Pista 1](https://github.com/user-attachments/assets/2cd413c6-692b-4ede-8b2e-807517d1f95d)
<h5>Imagem da Pista 1</h5>
<br>

![Pista 2](https://github.com/user-attachments/assets/90024f8d-2523-40ca-9bae-98659c13685d)
<h5>Imagem da Pista 2</h5>
<br>

![Pista 3](https://github.com/user-attachments/assets/8c5378ce-954d-4398-8f15-167aaa6600d2)
<h5>Imagem da Pista 3</h5>
<br>

![Pista 4](https://github.com/user-attachments/assets/9b3e1580-cd6e-4eea-abbb-8f8562ee6077)
<h5>Imagem da Pista 4</h5>
<br>

![Tela Inicial](https://github.com/user-attachments/assets/61132e4d-92d8-4b75-9352-e49aa96437cd)
<h5>Imagem da Tela do Inicial do Jogo</h5>
<br>

![Imagem 1 - Cena 1](https://github.com/user-attachments/assets/035aafc8-6cd0-49c7-8fe0-6751319d6fc9)
<h5>Imagem da Cena 1</h5>
<br>

![Imagem 2 - Cena 1](https://github.com/user-attachments/assets/875e1748-c4d4-4cd3-8b2c-5e37e2ab668d)
<h5>Imagem da Cena 1</h5>
<br>

![Imagem 1 - Cena 2](https://github.com/user-attachments/assets/ebd60ab7-4b89-4158-a8c5-1e44581c9c25)
<h5>Imagem da Cena 2</h5>
<br>

![Imagem 2 - Cena 2](https://github.com/user-attachments/assets/63b840e2-3a79-4959-9c3a-4b74e89f23ff)
<h5>Imagem da Cena 2</h5>
<br>

![Imagem 1 - Cena 3](https://github.com/user-attachments/assets/e3a89a9d-d93c-41a6-a5ba-05890da0c133)
<h5>Imagem da Cena 3</h5>
<br>

![Imagem 2 - Cena 3](https://github.com/user-attachments/assets/7c44ab88-5e97-4bcd-a62b-2c268bcd5cf2)
<h5>Imagem da Cena 3</h5>
<br>

https://github.com/user-attachments/assets/079bf952-0469-47e3-9b7b-a5788db69a61

https://github.com/user-attachments/assets/15143589-b55d-4678-a434-b08c6a41aa41

https://github.com/user-attachments/assets/229d6fe1-39ee-4b2c-8adb-fb9addda7ac5
