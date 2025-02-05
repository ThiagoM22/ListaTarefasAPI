namespace ListaTarefasAPI.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; } // Corrigido para PascalCase
        public string Descricao { get; set; }
        public bool Concluida { get; set; } // Corrigido para remover o acento
        public int TipoTarefaId { get; set; }
        public TipoTarefa? TipoTarefa { get; set; }
    }
}
