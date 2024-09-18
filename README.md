Integrantes: João Paulo B. P. C. Filho, Kevin Novais Bezerra, Murilo Rangel de França, Nicollas Lemes Matos

O tema geral era São Paulo 470 anos com isso decidimos que queríamos algo que representasse esse tempo algo atemporal, por isso escolhemos falar sobre o racismo, escravidão que são assuntos que repercutem até os dias de hoje, com isso queríamos mostrar como isso ainda persiste só que de maneira mascarada, com isso vieram as pesquisas sobre os locais de São Paulo e suas histórias como primeiro local escolhemos o Bairro da Liberdade muito pelo seu contexto histórico antes chamado de Campo da Forca onde os escravos e transgressores da lei eram mortos sendo essa a sua "Liberdade" a região também era ocupada majoritariamente por pessoas negras, outro motivo foi a estátua da Madrinha Eunice (fundadora da primeira escola de samba de São Paulo e ainda funcional, a Lavapés, na década de 30) que em 2023 ocorreu um discução, pois teve um show que cobriu totalmente a estátua gerando uma grande repercussão e pensamos em adicionar ela ao jogo, como queríamos representar o passado, a outra parte do jogo seria uma vila representado um tempo muito antes da industrialização da cidade de São Paulo.

O jogo recebeu o nome Sonho De Outrora que é um título poético e evocativo por sugerir memórias, esperanças e aspirações do passado. "Outrora" é uma palavra que remete a tempos passados, dando um tom nostálgico e reflexivo. "Sonhos" referem-se aos desejos ou ambições que houveram em tempos anteriores. Juntas, estas palavras implicam em um retorno emocional entre passado e presente.

O protagonista é um estudante de 17 anos chamado Juan Martins, tivemos a ideia de ele ser um estudante por nós sermos estudantes e ser possível se sentir como o personagem e por temos experiências próprias nesse meio, ele é inocente, sonhador e corintiano a ideia da inocência e do sonhador se vem pelo fato dele ser jovem e não tem experiências de como é o mundo por ser um jovem moderno tem consciência do que seu povo passou e seus “privilégios” que tem de viver na sociedade moderna, o lado torcedor ao Corinthians foi por causa que grande parte do grupo é corintiano e que o futebol é muito importante para vários brasileiros e integrantes do grupo.

Cenário: A primeira é onde você inicia o jogo que é a sua casa onde há três cômodos, a sala, o quarto e a cozinha, também possui um banheiro, na sala possui sofá, tv, uma mesinha, na cozinha possui uma mesa, algumas cadeiras,um fogão, geladeira e alguns armários, no quarto tem a cama, uma mesinha,guarda-roupa e uma bateria, no banheiro tem a pia, banheira, cesto de lavar roupa e uma máquina de lavar. Na segunda cena se passa na liberdade, onde tem prédios, ruas, calçadas, portões torii (portões japoneses vermelhos encontrados na liberdade), junto com lanternas japonesas, pessoas,pistas espalhadas brilhando em amarelo. Há terceira cena se passa no passado em uma pequena vila, campo aberto,arvores,poço,casas de madeira, a estatua da Madrinha Eunice em diferentes pedaços.

Historia: Juan decidi dormir após um dia cansativo de aula. Nisso ele acorda no Bairro da Liberdade e descobre que a estátua de Madrinha Eunice desapareceu, explorando melhor o bairro e coletando pistas espalhadas, Juan descobre que ela está no passado e que precisa encontrá-la nisso Juan precisa procurar por uma porta específica que o levará até o passado. Conseguindo encontrar a porta Juan agora está no passado em uma pequena vila onde Juan terá de encontrar a estátua que foi dividida em diferentes pedaços e deve rescontrui-la, Juan acordará vendo que foi apenas um sonho.

Músicas: A Vida É Desafio - Racionais MC's, Afro-X, Otus 500 - Racionais MC's, Vivão e Vivendo - Racionais MC's, (A)Bala - Fabio Brazza, Paiva Prod, Tião Preto, Rua da Glória - Aloysio Letra.

A proposta do nosso grupo é fazer um game endie, onde o jogador, no papel de um jovem estudante periférico, deve investigar o desaparecimento da estátua de Madrinha Eunice (fundadora da primeira escola de samba de São Paulo, a Lavapés, na década de 30), que se localiza no bairro da Liberdade. Ao longo da história o jogador descobrirá que a estátua de alguma forma foi parar no passado, e agora terá que recuperá-la. O jogador deverá coletar pistas espalhadas pelo mapa, para depois montar um quebra-cabeça para resolver o caso, o jogador irá ao passado em uma vila, ele deve encontrar os pedaços da estátua de Madrinha Eunice que foram separados para reconstruí-la.

A tela inicial do jogo foi feita no Piskel, o fundo tem a cor azul para representar o céu pois na teoria das cores o azul representa a harmonia, os portoes torii em referencia a propria Liberdade junto com lanternas japonesas, as portas foram colocadas por causa que no jogo elas são o meio que faz o personagem trocar de cenario, as flores são para representar a parte mais rural sendo o passado do jogo.

Explicação do Código:
Classes e Objetos da câmara:
- A classe "camera" herda as funções de MonoBehaviour, que é uma classe base do Unity, que permite que o script seja associado a objetos no Unity (como a câmera).
Uso de Atributos Públicos e Privados:
- Fizemos a utilização de atributos públicos e privados. Deixamos todas as propriedades e variáveis privadas, menos a variável "sensibilidade", que deixamos pública, para que o usuário possa definir a sensibilidade que deseja para o mouse.
Função Start():
- Usamos o método Start, para configurar o cursor do mouse, tornando-o invisível e fixo no centro da tela usando Cursor.lockState.
Função Update():
- Usamos este método para a captura do movimento do mouse usando Input.GetAxis("Mouse X") e Input.GetAxis("Mouse Y"), multiplicando esses valores pela variável "sensibilidade".
Uso do "Transform":
- O transform.eulerAngles, foi usado para alterar a rotação da câmera com base no movimento do mouse, aplicando a rotação nos eixos X e Y.
Entrada de Informações a partir do Usuário:
- Usamos Input.GetAxis("Mouse X"), para controlar a câmera no eixo X, e Input.GetAxis("Mouse Y"), para controlar a câmera no eixo Y. Essas propriedades permitem capturar os movimentos do mouse do jogador, que são convertidos em valores de rotação da câmera.
O uso do Cursor do Mouse:
- Usamos as propriedades Cursor.visible, para sumir com o mouse, e Cursor.lockState, para travar o mouse no centro da tela. Essas propriedades são características típicas de jogos em primeira pessoa.

  Movimentação:
- Classes e Objetos:
- A classe "movimento" herda de MonoBehaviour, permitindo que o script seja anexado à objetos em Unity. Usamos essa classe para movimentar, controlar, a câmera, que será o nosso personagem principal (jogo em primeira pessoa).

Variáveis de Instância:
- Vector3 m: Essa variável é um vetor de posição tridimensional (eixos X, Y e Z). Ela é usada para armazenar os valores de movimento e definir a posição do objeto.

Função Start():
- Nesse método definimos a posição inicial do nosso objeto, usando transform.position e o vetor m. Após essa definição, a variável m é redefinida para (0, 0, 0).

Função Update():
- Este método é utilizado para detectar entradas do teclado e mover o objeto com base nelas (as entradas).

Captura de Entrada do Usuário:
- Utilizamos a função Input.GetKey(), para detectar se determinada tecla está sendo pressionada:
--> KeyCode.D: Move o objeto para a direita (aumentando o valor de m.x).
--> KeyCode.A: Move o objeto para a esquerda (diminuindo o valor de m.x).
--> KeyCode.W: Move o objeto para frente (aumentando o valor de m.z).
--> KeyCode.S: Move o objeto para trás (diminuindo o valor de m.z).
- A função transform.Translate(m) aplica movimento ao objeto baseado nos valores do vetor m.

Manipulação de Transformações:
- transform.position: Usamos está propriedade para definir a posição do objeto na cena. Essas propriedade também é usada pra restringir o movimento do objeto dentro da cena.

Limites de Movimento:
- Impusemos limites às coordenadas X, Y e Z do objeto. Isso evita que ele ultrapasse os limites da cena.

Reset de Movimento:
- No final de cada frame, o vetor m é redefinido para 0, usando a função m.Set(0, 0, 0). Isso garanti que o movimento só ocorra quando o jogador pressionar uma tecla, e que o objeto pare de se mover quando nenhuma tecla estiver sendo pressionada.

Estrutura Condicional (if):
- Fizemos o uso de várias condições "if". Elas são usadas para verificar a entrada do usuário, e aplicar as restrições de movimento, garantindo que o objeto se comporte conforme o esperado. Um exemplo é o trecho:
"if (transform.position.y < 2.0){
            transform.position = new Vector3(transform.position.x, 2.0f, transform.position.z);
        }

        if (transform.position.y > 2.0)
        {
            transform.position = new Vector3(transform.position.x, 2.0f, transform.position.z);
        }"
O trecho acima serve para garantir que quando o jogador rotacionar a câmera no eixo X e Y, a câmera não se movimente no eixo Y.

Assets utilizados:
FREE - Modular Character - Fantasy RPG Human Male
https://assetstore.unity.com/packages/3d/characters/humanoids/humans/free-modular-character-fantasy-rpg-human-male-228952
Villager Animations FREE
https://assetstore.unity.com/packages/3d/animations/villager-animations-free-157920
FREE Low Poly Human - RPG Character
https://assetstore.unity.com/packages/3d/characters/humanoids/fantasy/free-low-poly-human-rpg-character-219979
Low Poly Farm Pack Lite
https://assetstore.unity.com/packages/3d/environments/industrial/low-poly-farm-pack-lite-188100
Madrinha Eunice
https://sketchfab.com/3d-models/madrinha-eunice-deolinda-madre-fef0930308d34d3681dbf8845f64dc59
RPG Poly Pack - Lite
https://assetstore.unity.com/packages/3d/environments/landscapes/rpg-poly-pack-lite-148410
Farm Animals Set
https://assetstore.unity.com/packages/3d/farm-animals-set-97945
City People Lite
https://assetstore.unity.com/packages/3d/characters/city-people-lite-260446
Simple City pack plain
https://assetstore.unity.com/packages/3d/environments/urban/simple-city-pack-plain-100348
Bolinha de Papel
https://sketchfab.com/3d-models/paper-low-bab9b0a4a3194165be4ac939c565d39f

https://drive.google.com/drive/folders/1ohX-2R7PknoC_GAVfwDm20zMsjciNwbL?usp=drive_link
