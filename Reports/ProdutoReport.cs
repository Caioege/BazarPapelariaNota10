using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using iTextSharp.text;
using System.IO;
using BazarPapelaria10.Models;

namespace BazarPapelaria10.Reports
{
    public class ProdutoReport
    {
        private IWebHostEnvironment _oHostEnvironment;

        public ProdutoReport(IWebHostEnvironment oHostEnvironment)
        {
            _oHostEnvironment = oHostEnvironment;
        }

        #region Declaracao
        int _maxColumn = 6;
        Document _document;
        Font _fontStyle;
        PdfPCell _pdfCell;
        PdfPTable _pdfTable = new PdfPTable(6);
        MemoryStream _memoryStream = new MemoryStream();
        List<Produto> _oProdutos = new List<Produto>();
        #endregion

        public byte[] Report(List<Produto> oProdutos)
        {
            _oProdutos = oProdutos;
            _document = new Document();
            _document.SetPageSize(PageSize.A4);
            _document.SetMargins(5f, 5f, 10f, 5f);
            _pdfTable.WidthPercentage = 90;
            _pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

            _fontStyle = FontFactory.GetFont("Calibri", 10f, 1);
            PdfWriter docWrite = PdfWriter.GetInstance(_document, _memoryStream);

            _document.Open();
            float[] sizes = new float[_maxColumn];
            sizes[0] = 30;
            sizes[1] = 200;
            sizes[2] = 50;
            sizes[3] = 50;
            sizes[4] = 30;
            sizes[5] = 100;

            _pdfTable.SetWidths(sizes);

            this.ReportHeader();
            this.ReportBody();

            _pdfTable.HeaderRows = 2;

            _document.Add(_pdfTable);
            _document.Close();

            return _memoryStream.ToArray();
        }
        private void ReportHeader()
        {
            _pdfCell = new PdfPCell(this.AddLogo());
            _pdfCell.Colspan = 1;
            _pdfCell.Border = 0;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(this.SetPageTitle());
            _pdfCell.Colspan = _maxColumn;
            _pdfCell.Border = 1;
            _pdfTable.AddCell(_pdfCell);

            _pdfTable.CompleteRow();
        }
        private PdfPTable AddLogo()
        {
            int maxColumn = 1;
            PdfPTable pdfPTable = new PdfPTable(maxColumn);

            string imgCombine = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/logorel.png");
            Image img = Image.GetInstance(imgCombine);

            _pdfCell = new PdfPCell(img);
            _pdfCell.Colspan = _maxColumn;
            _pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
            _pdfCell.Border = 0;
            _pdfCell.ExtraParagraphSpace = 0;
            pdfPTable.AddCell(_pdfCell);
            pdfPTable.CompleteRow();

            return pdfPTable;
        }
        private PdfPTable SetPageTitle()
        {
            int maxColumn = 4;
            string dataHoraLocal = DateTime.Now.Date.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();

            PdfPTable pdfPTable = new PdfPTable(maxColumn);
            _fontStyle = FontFactory.GetFont("Calibri", 16f, 1);
            _pdfCell = new PdfPCell(new Phrase("RELATÓRIO DETALHADO DE PRODUTOS", _fontStyle));
            _pdfCell.Colspan = _maxColumn;
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.Border = 0;
            _pdfCell.ExtraParagraphSpace = 1;
            pdfPTable.AddCell(_pdfCell);
            pdfPTable.CompleteRow();

            _fontStyle = FontFactory.GetFont("Times New Roman", 14f, 1);
            _pdfCell = new PdfPCell(new Phrase("ATUALIZADO EM: " + dataHoraLocal, _fontStyle));
            _pdfCell.Colspan = _maxColumn;
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.Border = 0;
            _pdfCell.Colspan = 2;
            _pdfCell.ExtraParagraphSpace = 1;
            _pdfTable.AddCell(_pdfCell);
            _pdfTable.CompleteRow();

            return pdfPTable;
        }

        //private void EmpyRow(int qtdLinhas)
        //{
        //    for (int cont = 1; cont <= qtdLinhas; cont++)
        //    {
        //        _pdfCell = new PdfPCell(new Phrase("", _fontStyle));
        //        _pdfCell.Colspan = _maxColumn;
        //        _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //        _pdfCell.Border = 0;
        //        _pdfCell.ExtraParagraphSpace = 10;
        //        _pdfTable.AddCell(_pdfCell);
        //        _pdfTable.CompleteRow();
        //    }

        //}

        private void ReportBody()
        {
            var fontStyleBold = FontFactory.GetFont("Times New Roman", 9f, 1);
            _fontStyle = FontFactory.GetFont("Times New Roman", 9f, 0);

            #region Detalhes cabeçalho da tabela principal

            _pdfCell = new PdfPCell(new Phrase("ID", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("NOME", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("QTD", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("VALOR", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("ATIVO", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("CATEGORIA", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.GRAY;
            _pdfTable.AddCell(_pdfCell);

            _pdfTable.CompleteRow();
            #endregion

            #region Detalhes corpo da tebela

            foreach (var oProduto in _oProdutos)
            {

                _pdfCell = new PdfPCell(new Phrase(oProduto.Id.ToString(), _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(oProduto.Nomeprod, _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(oProduto.Quantidade.ToString()));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(oProduto.Valorprod.ToString("C")));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfTable.AddCell(_pdfCell);

                if(oProduto.Ativo)
                {
                    _pdfCell = new PdfPCell(new Phrase("Sim"));
                }
                else
                {
                    _pdfCell = new PdfPCell(new Phrase("Não"));
                }
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(oProduto.CategoriaId.ToString()));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfTable.AddCell(_pdfCell);

                _pdfTable.CompleteRow();
            }
            #endregion
        }
    }
}
