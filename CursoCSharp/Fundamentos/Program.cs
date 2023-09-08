using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.OrientacaoObj;
using CursoCSharp.Excecoes;
using CursoCSharp.Excesoes;
using CursoCSharp.Api;

namespace CursoCSharp
{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaves E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formantando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios- Fundamentos", OperadoresTernarios.Executar},

                //Estruturas de Controles
                 {"Estrutura If - Estrutas de  Controle", EstruturaIf.Executar},
                 {"Estrutura If/Else - Estrutas de  Controle", EstruturasIfElse.Executar},
                 {"Estrutura If/Else/If - Estrutas de  Controle", EstruraIfElseIf.Executar},
                 {"Estrutura Switch - Estrutas de  Controle", EstruturaSwitch.Executar},
                 {"Estrutura While - Estrutas de  Controle", EstruturaWhile.Executar},
                 {"Estrutura DoWhile - Estrutas de  Controle", EstruturaDoWhile.Executar},
                 {"Estrutura For - Estrutas de  Controle", EstruturaFor.Executar},
                 {"Estrutura ForEach - Estrutas de  Controle", EstruturaForEach.Executar},
                 {"Estrutura Breack - Estrutas de  Controle", EstruraBreack.Executar},
                 {"Estrutura Continue - Estrutas de  Controle", EstruraContinue.Executar},
                 {"Estrutura Treinando - Estrutas de  Controle", Treinando.Executar},


                //Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos Com Retorno - Classes e Metodos", MetadosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos", MetadosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Execuatar},
                {"GetSet - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"ExemploEnum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", Struct.Executar},
                {"Class VS Struct - Classes e Metodos", ClassVsStruct.Executar},
                {"Valor VS Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametro por  Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos", ParametroPadrao.Executar},
                
                //Coleções
                {" Array - Coleções", Colecoes.Array.Executar},
                {" List - Coleções", ColecoesList.Executar},
                {" Array List - Coleções", ColecoesArrayList.Executar},
                {" Set - Coleções", ColecoesSet.Executar},
                {" Queue - Coleções", ColecoesQueue.Executar},
                {" Igualdade - Coleções", Igualdade.Executar},
                {" Stack - Coleções", ColecoesStack.Executar},
                {" Dictionary - Coleções", ColecoesDictionary.Executar},

                //Orientação Obj
                {" Heranca - OrientacãoObj " , Heranca.Executar},
                {" Construtor This - OrientacãoObj " , ConstrutorThis.Executar},
                {" Encapsulamento  - OrientacãoObj " , OrientacaoObj.Encapsulamento.Executar},
                {" Polimorfismo  - OrientacãoObj " , Polimorfismo.Executar},
                {" Class Abstract  - OrientacãoObj " , ClassAbstract.Executar},
                {" Interface  - OrientacãoObj " , Interface.Executar},
                {" Sealed  - OrientacãoObj " , Sealed.Executar},
        
                // Métodos & Funções
                {" Exemplo Lambda  - OrientacãoObj " , ExemploLambda.Executar},
                {" Lambda Como Delegates - OrientacãoObj " , LambdasDelegate.Executar},
                {" Usando  Delegates - OrientacãoObj " , UsandoDelegates.Executar},
                {" Delegates Como Funcao Anonima - OrientacãoObj " , DelegatesFunAnonima.Executar},
                {" Delegates Como Parametros - OrientacãoObj " , DelegatesParametros.Executar},
                {" Métodos de Extensão - OrientacãoObj " , MetodosDeExtensao.Executar},

                //Excesões
                {" Primeira Exceção - Exceções " , PrimeiraExcecao.Executar},
                {" Exceções Personalizadas - Exceções " , ExcecoesPersonalizadas.Executar},
                

                //Api 
                {" Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}