using _05_Herança._02_Heranca_de_construtores;
var caminhaoTest = new Caminhao("modelo", "marca", 2010, (float)30.00);
var carroTeste = new Carro("modelo", "marca", 2010, (float)30.00, 4);
carroTeste.MostrarInformacoes();
caminhaoTest.MostrarInformacoes();