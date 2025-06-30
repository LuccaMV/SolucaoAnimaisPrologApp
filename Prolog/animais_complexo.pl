% Fatos: Caracter�sticas dos animais
tem_pelo(cachorro).
tem_pelo(gato).
tem_pelo(leao).
tem_pelo(macaco).

tem_penas(pardal).
tem_penas(pato).
tem_penas(galinha).

tem_escamas(cobra).
tem_escamas(peixe).

vive_na_agua(baleia).
vive_na_agua(peixe).
vive_na_agua(pato).

% Fatos: Tipo de alimenta��o
e_carnivoro(leao).
e_carnivoro(cobra).
e_carnivoro(gato).

e_herbivoro(macaco).
e_herbivoro(vaca).
e_herbivoro(coelho).

e_onivoro(cachorro).
e_onivoro(galinha).

% Regra 1: Definindo um mam�fero
mamifero(X) :- tem_pelo(X), \+ vive_na_agua(X). % X tem pelo E n�o vive na �gua
mamifero(baleia) :- vive_na_agua(baleia). % Exce��o: baleia � mam�fero que vive na �gua

% Regra 2: Definindo um p�ssaro
passaro(X) :- tem_penas(X).

% Regra 3: Um animal perigoso
animal_perigoso(X) :- e_carnivoro(X), \+ vive_na_agua(X).
animal_perigoso(X) :- tem_escamas(X), \+ e_herbivoro(X).

% Regra 4: Animal dom�stico
animal_domestico(cachorro).
animal_domestico(gato).
animal_domestico(coelho).



