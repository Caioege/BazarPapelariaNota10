using BazarPapelaria10.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BazarPapelaria10.Reports
{
    public class ClienteReport
    {
        private IWebHostEnvironment _oHostEnvironment;

        public ClienteReport(IWebHostEnvironment oHostEnvironment)
        {
            _oHostEnvironment = oHostEnvironment;

        }
        #region Declaracao

        int qtdAtivos = 0;
        int qtdInativos = 0;

        int _maxColumn = 5;
        Document _document;
        Font _fontStyle;
        PdfPCell _pdfCell;
        PdfPTable _pdfTable = new PdfPTable(5);
        PdfPTable _pdfTableSubHeader = new PdfPTable(4);
        PdfPTable _pdfTableHeader = new PdfPTable(2);
        PdfPTable _pdfTitulo = new PdfPTable(1);
        MemoryStream _memoryStream = new MemoryStream();
        List<Pessoa> _oClientes = new List<Pessoa>();
        #endregion

        public byte[] Report(List<Pessoa> oClientes)
        {
            _oClientes = oClientes;
            _document = new Document();
            _document.SetPageSize(PageSize.A4);
            _document.SetMargins(5f, 5f, 10f, 5f);
            _pdfTable.WidthPercentage = 90;
            _pdfTableSubHeader.WidthPercentage = 90;
            _pdfTableHeader.WidthPercentage = 90;
            _pdfTitulo.WidthPercentage = 90;
            _pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfTableSubHeader.HorizontalAlignment = Element.ALIGN_CENTER;

            _fontStyle = FontFactory.GetFont("Calibri", 10f, 1);
            PdfWriter docWrite = PdfWriter.GetInstance(_document, _memoryStream);

            _document.Open();
            float[] sizes = new float[_maxColumn];
            sizes[0] = 30;
            sizes[1] = 150;
            sizes[2] = 150;
            sizes[3] = 30;
            sizes[4] = 100;

            _pdfTable.SetWidths(sizes);

            this.ReportHeader();
            this.EmpyRow(2, 2, _pdfTableHeader);
            this.SetPageTitle();
            this.EmpyRow(2, 1, _pdfTitulo);
            this.ReportSubHeader();
            this.EmpyRow(2, 4, _pdfTableSubHeader);
            this.ReportBody();

            _pdfTable.HeaderRows = 1;

            _document.Add(_pdfTableHeader);
            _document.Add(_pdfTableSubHeader);
            _document.Add(_pdfTable);
            _document.Close();

            return _memoryStream.ToArray();
        }
        private void ReportSubHeader()
        {
            var fontStyleBold = FontFactory.GetFont("Calibri", 9f, 1);
            _fontStyle = FontFactory.GetFont("Calibri", 9f, 0);

            #region Detalhes sub cabeçalho da tabela principal
            _pdfCell = new PdfPCell(new Phrase("QTD DE PESSOAS", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTableSubHeader.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("QTD DE ATIVOS", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTableSubHeader.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("QTD DE INATIVOS", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTableSubHeader.AddCell(_pdfCell);


            _pdfCell = new PdfPCell(new Phrase("ATUALIZADO EM", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.GRAY;
            _pdfTableSubHeader.AddCell(_pdfCell);


            _pdfTableSubHeader.CompleteRow();

            _pdfCell = new PdfPCell(new Phrase(_oClientes.Count().ToString(), _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTableSubHeader.AddCell(_pdfCell);

            foreach (var cliente in _oClientes)
            {
                if (cliente.Ativo)
                {
                    qtdAtivos++;
                }
                else
                {
                    qtdInativos++;
                }
            }

            _pdfCell = new PdfPCell(new Phrase(qtdAtivos.ToString(), _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTableSubHeader.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase(qtdInativos.ToString(), _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTableSubHeader.AddCell(_pdfCell);

            string dataHoraLocal = DateTime.Now.Date.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            _pdfCell = new PdfPCell(new Phrase(dataHoraLocal, _fontStyle));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTableSubHeader.AddCell(_pdfCell);

            _pdfTableSubHeader.CompleteRow();
            #endregion

            #region Detalhes cabeçalho da tabela principal

            _pdfCell = new PdfPCell(new Phrase("ID", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("NOME", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("EMAIL", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("SEXO", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTable.AddCell(_pdfCell);

            _pdfCell = new PdfPCell(new Phrase("ATIVO", fontStyleBold));
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            _pdfCell.BackgroundColor = BaseColor.WHITE;
            _pdfTable.AddCell(_pdfCell);


            _pdfTable.CompleteRow();
            #endregion
        }
        private void ReportHeader()
        {
            _pdfCell = new PdfPCell(this.AddLogo());
            _pdfCell.Colspan = 1;
            _pdfCell.Border = 0;
            _pdfTableHeader.AddCell(_pdfCell);



            _fontStyle = FontFactory.GetFont("Times New Roman", 16f, 1);
            _pdfCell = new PdfPCell(new Phrase("RELATÓRIO DE CLIENTES", _fontStyle));
            _pdfCell.Colspan = _maxColumn;
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.Border = 0;
            _pdfCell.Colspan = 2;
            _pdfCell.ExtraParagraphSpace = 1;
            _pdfTableHeader.AddCell(_pdfCell);
            _pdfTableHeader.CompleteRow();

            _pdfTableHeader.CompleteRow();
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
        private void SetPageTitle()
        {

            _fontStyle = FontFactory.GetFont("Calibri", 16f, 1);
            _pdfCell = new PdfPCell(new Phrase("RELATÓRIO DETALHADO DE PRODUTOS", _fontStyle));
            _pdfCell.Colspan = 3;
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            _pdfCell.Border = 0;
            _pdfCell.ExtraParagraphSpace = 0;
            _pdfTitulo.AddCell(_pdfCell);
            _pdfTitulo.CompleteRow();

        }
        private void ReportBody()
        {
            var fontStyleBold = FontFactory.GetFont("Times New Roman", 9f, 1);
            _fontStyle = FontFactory.GetFont("Times New Roman", 9f, 0);


            #region Detalhes corpo da tebela

            foreach (var oCliente in _oClientes)
            {

                _pdfCell = new PdfPCell(new Phrase(oCliente.Id.ToString(), _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(oCliente.Nome, _fontStyle));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(oCliente.Email.ToString()));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase(oCliente.Sexo.ToString()));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfTable.AddCell(_pdfCell);

                _pdfCell = new PdfPCell(new Phrase((oCliente.Ativo) ? "Sim" : "Não"));
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                _pdfCell.BackgroundColor = BaseColor.WHITE;
                _pdfTable.AddCell(_pdfCell);

                _pdfTable.CompleteRow();
            }
            #endregion
        }
        private void EmpyRow(int qtdLinhas, int qtdColunas, PdfPTable pdfTable)
        {
            for (int cont = 1; cont <= qtdLinhas; cont++)
            {
                _pdfCell = new PdfPCell(new Phrase(" ", _fontStyle));
                _pdfCell.Colspan = qtdColunas;
                _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                _pdfCell.Border = 0;
                _pdfCell.ExtraParagraphSpace = 2;
                pdfTable.AddCell(_pdfCell);
                pdfTable.CompleteRow();
            }

        }

    }
}