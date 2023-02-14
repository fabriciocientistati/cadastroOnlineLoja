﻿
//As propriedades e atributos que inserir nessa ClasseModel, ela irá referênciar as colunas no banco de dados
using System.ComponentModel.DataAnnotations;
namespace CadastroPrimoMoveis.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite o CPF!")]
        public string Cpf { get; set; }

        public string? Cnpj { get; set; }

        [Required(ErrorMessage = "Digite o número do telefone Celular!")]
        public string NumTelefone1 { get; set; }
        public string? NumTelefone2 { get; set; }
        public string? Email{ get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
