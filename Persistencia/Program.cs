// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Iniciando aplicação de persistência de dados");
Console.WriteLine("Selecione a opção desejada:");
Console.WriteLine("1 - Inserir dados");
Console.WriteLine("2 - Consultar dados");
Console.WriteLine("3 - Atualizar dados");
Console.WriteLine("4 - Excluir dados");
switch (switch_on)
{
    case 1:
Console.WriteLine("Preenchendo dados tarefa 01");
var tarefa01 = new Tarefa();
tarefa01.Nome = "Fazer compras";
tarefa01.Descricao  = "Comprar arroz, feijão e frutas";
tarefa01.DataCriacao = DateTime.Now; 
tarefa01.Status = 1;
tarefa01.DataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Inserindo dados no banco de dados");

var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: {idInserido}");
case 2:
        Console.WriteLine("Consultando dados no banco de dados");
        var operacoes = new Operacoes();
        var tarefas = operacoes.ObterTodos();
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"Id: {tarefa.Id}, Nome: {tarefa.Nome}, Descrição: {tarefa.Descricao}, Data de Criação: {tarefa.DataCriacao}, Status: {tarefa.Status}, Data de Execução: {tarefa.DataExecucao}");
        }
        break;
    case 3:
        Console.WriteLine("Atualizando dados no banco de dados");
        var operacoes = new Operacoes();
        var tarefaParaAtualizar = operacoes.ObterPorId(1);
        if (tarefaParaAtualizar != null)
        {
            tarefaParaAtualizar.Nome = "Fazer compras no mercado";
            tarefaParaAtualizar.Descricao = "Comprar arroz, feijão, frutas e verduras";
            operacoes.Alterar(tarefaParaAtualizar);
            Console.WriteLine("Dados atualizados com sucesso.");
        }
        else
        {
            Console.WriteLine("Tarefa não encontrada.");
        }
        break;
    case 4:
        Console.WriteLine("Excluindo dados no banco de dados");
        var operacoes = new Operacoes();
        int idParaExcluir = 1;
        operacoes.Excluir(idParaExcluir);
        Console.WriteLine("Dados excluídos com sucesso.");
    
    default:
        Console.WriteLine("Opção inválida. Encerrando aplicação.");
        break;
}
