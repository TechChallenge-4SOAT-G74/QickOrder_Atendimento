﻿namespace QuickOrderAtendimento.Domain.Entities
{
    public class ProdutoItens
    {
        public int ProdutoId { get; set; }
        public int ItemId { get; set; }
        public string NomeProdutoItem { get; set; }
        public int Quantidade { get; set; }
        public double ValorItem { get; set; }
    }
}
