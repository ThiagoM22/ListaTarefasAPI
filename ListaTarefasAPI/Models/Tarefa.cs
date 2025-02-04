namespace ListaTarefasAPI.Models
{
    public class Tarefa
    {
        public int tarefaId { get; set; }
        public string Descricao { get; set; }
        public bool Concluída { get; set; }
        public int TipoTarefaId { get; set; }
        public TipoTarefa? TipoTarefa { get; set; }
    }
}
