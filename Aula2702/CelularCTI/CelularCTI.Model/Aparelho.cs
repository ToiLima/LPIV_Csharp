﻿using CelularCTI.Model.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CelularCTI.Model.Entidades
{
	public class Aparelho
	{
		private Int64 id_aparelho;
		private string modelo;
		private Fabricante fabricante;
		private double largura, altura, espessura, peso, quantidade;
		private decimal preco, desconto;

		//Getters e Setters
		public Int64 Id_Aparelho { get; set; }
		public string Modelo { get; set; }
		public Fabricante Fabricante { get; set; }
		public double Largura { get; set; }
		public double Altura { get; set; }
		public double Espessura { get; set; }
		public double Peso { get; set; }
		
		//public decimal Preco { get; set; }
		public double Quantidade
		{
			get
			{
				return quantidade;
			}
			set
			{
				if (value > 0)
					quantidade = value;
				/*else
					throw new Exception("O campo Preço do produto deve ser maior que zero!");*/
			}
		}
		public decimal Preco
		{
			get
			{
				return preco;
			}
			set
			{
				if (value > 0)
					preco = value;
				else
					throw new Exception("O campo Preço do produto deve ser maior que zero!");
			}
		}
		public decimal Desconto { get; set; }
		
		//Sobescrever o método toString() para
		//retornar  uma string com os dados que 
		//desejo apresentar de aparelho.
		public override string ToString()
		{
            return Fabricante.Nome.PadRight(12) + " " +
               Modelo.PadRight(25) + " " +
               Preco.ToString("#,##0.00").PadLeft(10) + " " +
               "   (" + Quantidade + " em estoque)"; 
		}
	}
}
