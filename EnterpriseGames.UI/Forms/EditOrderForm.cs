using EnterpriseGames.Core.Other;
using EnterpriseGames.Core.Services;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EnterpriseGames.UI.Forms
{
    public partial class EditOrderForm : MetroForm
    {
        public class Status
        {
            public RecordState State { get; set; }
            public override string ToString()
            {
                switch (State)
                {
                    case RecordState.Closed: return "Закрыто";
                    case RecordState.Editing: return "Редактируется";
                    default: return string.Empty;
                }
            }
        }

        private readonly ProductsService _productsService = new ProductsService(Settings.Context);
        private readonly CustomersService _customersService = new CustomersService(Settings.Context);
        private readonly Record _record;

        public EditOrderForm(Record record)
        {
            InitializeComponent();

            _record = record;
        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            cbStatus.Items.AddRange(new Status[] {
                                        new Status() { State = RecordState.Editing },
                                        new Status() { State = RecordState.Closed } });
            cbStatus.SelectedItem = new Status() { State = _record.State };

            cbClients.Items.AddRange(_customersService.GetCustomers());

            var games = _productsService.GetAll(x => x.ProductPriceHistory.Any(z => z.IsDeleted == 0));
            games.ToList().ForEach(pr =>
                           dtgGames.Rows.Add(
                                   pr.Id,
                                   pr.Title,
                                   pr.ProductDateCreated,
                                   pr.ProductPriceHistory.LastOrDefault(x => x.IsDeleted == 0)?.Price
                               ));

            if (!string.IsNullOrEmpty(_record.DateCreated))
                if (DateTime.TryParse(_record.DateCreated, out DateTime dateCreated))
                    dtpCreated.Value = dateCreated;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cells = dtgGames.SelectedRows[0].Cells;
            var selectedId = Convert.ToInt32(cells[0].Value);

            foreach (DataGridViewRow row in dtgBasket.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].FormattedValue) == selectedId)
                {
                    MetroMessageBox.Show(this, "Данная игра уже добавлена", "Справка", MessageBoxButtons.OK);
                    return;
                }
            }

            var newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[0].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[1].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[2].Value });
            newRow.Cells.Add(new DataGridViewTextBoxCell() { Value = cells[3].Value });

            dtgBasket.Rows.Add(newRow);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dtgBasket.Rows.Remove(dtgBasket.SelectedRows[0]);
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            cbClients.SelectedIndex = -1;
        }

        private void dtgGames_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgGames.SelectedRows.Count != 0)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void dtgBasket_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgBasket.SelectedRows.Count != 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }
        }
    }
}