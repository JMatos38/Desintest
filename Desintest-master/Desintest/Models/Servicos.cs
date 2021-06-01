using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// esta tabela ainda nao esta completa
namespace TesteDBs.Models
{
    public class Servicos
    {
        /// <summary>
        /// Identificador de cada Serviço
        /// </summary>
        [Key]
        public int IdServico { get; set; }  
        /// <summary>
        /// Nome do Serviço
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Preçario para o serviço selecionado
        /// </summary>
        public decimal Preco { get; set; }
        /// <summary>
        /// Descrição informativa sobre o serviço
        /// </summary>
        public string Descricao { get; set; }
        [ForeignKey(nameof(Marcacoes))]  
        public int MarcacaoFK { get; set; }  
        public Marcacoes IdMarcacao { get; set; }  
    }
}
