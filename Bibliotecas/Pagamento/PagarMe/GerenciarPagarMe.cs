using BazarPapelaria10.Bibliotecas.Login;
using BazarPapelaria10.Bibliotecas.Texto;
using BazarPapelaria10.Models;
using Microsoft.Extensions.Configuration;
using PagarMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Bibliotecas.Pagamento.PagarMe
{
    public class GerenciarPagarMe
    {
        private IConfiguration _conf;
        private LoginCliente _loginCliente;
        public GerenciarPagarMe(IConfiguration conf, LoginCliente loginCliente)
        {
            _conf = conf;
            _loginCliente = loginCliente;
        }

        public object GerarBoleto(decimal valor)
        {
            try
            {
                Pessoa cliente = _loginCliente.GetCliente();

                PagarMeService.DefaultApiKey = _conf.GetValue<string>("Pagamento:PagarMe:ApiKey");
                PagarMeService.DefaultEncryptionKey = _conf.GetValue<string>("Pagamento:PagarMe:EncryptionKey");

                Transaction transaction = new Transaction();

                transaction.Amount = Convert.ToInt32(valor);
                transaction.PaymentMethod = PaymentMethod.Boleto;

                transaction.Customer = new Customer
                {
                    ExternalId = cliente.Id.ToString(),
                    Name = cliente.Nome,
                    Type = CustomerType.Individual,
                    Country = "br",
                    Email = cliente.Email,
                    Documents = new[]
                  {
                new Document{
                  Type = DocumentType.Cpf,
                  Number = Mascara.Remover(cliente.Cpf)
                  },
                },
                    PhoneNumbers = new string[]
                              {
                "+55" + Mascara.Remover(cliente.Celular),
                              },
                    Birthday = cliente.Nascimento.ToString("yyyy-MM-dd")
                };

                transaction.Save();

                return new
                {
                    BarCode = transaction.BoletoBarcode,
                    Expiracao = transaction.BoletoExpirationDate,
                    BoletoURL = transaction.BoletoUrl
                };
            }
            catch (Exception e)
            {
                return new { Erro = e.Message };
            }
        }

        //public object GerarPagCartaoCredito(CartaoCredito cartao)
        //{
        //    Pessoa cliente = _loginCliente.GetCliente();

        //    PagarMeService.DefaultApiKey = _conf.GetValue<string>("Pagamento:PagarMe:ApiKey");
        //    PagarMeService.DefaultEncryptionKey = _conf.GetValue<string>("Pagamento:PagarMe:EncryptionKey");

        //    Card card = new Card();
        //    card.Number = cartao.NumeroCartao;
        //    card.HolderName = cartao.NomeNoCartao;
        //    card.ExpirationDate = cartao.Vencimento;
        //    card.Cvv = cartao.Cvv;

        //    card.Save();

        //    Transaction transaction = new Transaction();

        //    transaction.Amount = 2100;
        //    transaction.Card = new Card
        //    {
        //        Id = card.Id
        //    };

        //    transaction.Customer = new Customer
        //    {
        //        ExternalId = cliente.Id.ToString(),
        //        Name = cliente.Nome,
        //        Type = CustomerType.Individual,
        //        Country = "br",
        //        Email = cliente.Email,
        //        Documents = new[]
        //          {
        //        new Document{
        //          Type = DocumentType.Cpf,
        //          Number = Mascara.Remover(cliente.Cpf)
        //          },
        //        },
        //        PhoneNumbers = new string[]
        //                      {
        //        "+55" + Mascara.Remover(cliente.Celular),
        //                      },
        //        Birthday = cliente.Nascimento.ToString("yyyy-MM-dd")
        //    };

        //    transaction.Billing = new Billing
        //    {
        //        Name = cliente.Nome,
        //        Address = new Address()
        //        {
        //            Country = "br",
        //            State = "go",
        //            City = cliente.Cidade,
        //            Neighborhood = cliente.Bairro,
        //            Street = cliente.Logradouro,
        //            StreetNumber = cliente.Numero,
        //            Zipcode = Mascara.Remover(cliente.CEP)
        //        }
        //    };

        //    var Today = DateTime.Now;

        //    transaction.Shipping = new Shipping
        //    {
        //        Name = "Rick",
        //        Fee = 100,
        //        DeliveryDate = Today.AddDays(4).ToString("yyyy-MM-dd"),
        //        Expedited = false,
        //        Address = new Address()
        //        {
        //            Country = "br",
        //            State = "sp",
        //            City = "Cotia",
        //            Neighborhood = "Rio Cotia",
        //            Street = "Rua Matrix",
        //            StreetNumber = "213",
        //            Zipcode = "04250000"
        //        }
        //    };

        //    transaction.Item = new[]
        //    {
        //   new Item()
        //   {
        //     Id = "1",
        //     Title = "Little Car",
        //     Quantity = 1,
        //     Tangible = true,
        //     UnitPrice = 1000
        //   },
        //   new Item()
        //   {
        //     Id = "2",
        //     Title = "Baby Crib",
        //     Quantity = 1,
        //     Tangible = true,
        //     UnitPrice = 1000
        //   }
        //    };

        //    transaction.Save();
        //}
    }
}
