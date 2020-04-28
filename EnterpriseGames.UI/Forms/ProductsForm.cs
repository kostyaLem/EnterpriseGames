﻿using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Services;
using EnterpriseGames.UI.Forms.EditForms;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EnterpriseGames.UI.Forms
{
    public partial class ProductsForm : MetroForm
    {
        private readonly ProductsService _prService = new ProductsService(Settings.Context);
        private List<Product> _items;

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
            UpdateCounter();
        }

        private void UpdateDataGrid()
        {
            dataGrid.Rows.Clear();

            var products = _prService.GetAll();
            products.ToList().ForEach(pr =>
                           dataGrid.Rows.Add(
                                   pr.Id,
                                   pr.Title,
                                   pr.DateCreated,
                                   pr.ProductDateCreated,
                                   pr.ProductPriceHistory.LastOrDefault()?.Price,
                                   pr.ProductPriceHistory.Any(x => !Convert.ToBoolean(x.IsDeleted)) ? true : false
                               ));

            _items = new List<Product>(products);
        }

        private void UpdateCounter()
        {
            lblCount.Text = dataGrid.Rows.Count.ToString();
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            dtgPrices.Rows.Clear();
            if (dataGrid.SelectedRows.Count != 0)
            {
                btnRemove.Enabled = btnEdit.Enabled = true;

                var selectedProduct = _prService.Find((Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].FormattedValue)));

                using (var ms = new MemoryStream(selectedProduct.Image))
                    picGame.Image = Image.FromStream(ms);

                selectedProduct.ProductPriceHistory.ToList().ForEach(x => dtgPrices.Rows.Add(x.Id, x.Price, x.DateCreated));
            }
            else
            {
                btnRemove.Enabled = btnEdit.Enabled = false;

                picGame.Image?.Dispose();
                picGame.Image = null;
                dtgPrices.Rows.Clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);

            if (_prService.Remove(id))
            {
                dataGrid.Rows.Remove(dataGrid.SelectedRows[0]);
                MetroMessageBox.Show(this, $"Игра удалена", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCounter();
            }
            else
            {
                MetroMessageBox.Show(this, "Ошибка при удалении записи", "Не удалось удалить запись", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var product = _prService.Find(Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value));

            if (product != null)
            {
                var dialogResult = new EditProductForm(product).ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    _prService.Update(product);
                    MetroMessageBox.Show(this, $"Пользователь {product.Title} изменен", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataGrid();
                    UpdateCounter();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product();

            var dialogResult = new EditProductForm(product).ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                _prService.Add(product);
                MetroMessageBox.Show(this, $"Игра {product.Title} успешно создан", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGrid();
                UpdateCounter();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                _items.Where(x => x.Title.Contains(txtFilter.Text.Trim())).ToList()?.ForEach(pr =>
                              dataGrid.Rows.Add(
                                      pr.Id,
                                      pr.Title,
                                      pr.DateCreated,
                                      pr.ProductDateCreated,
                                      pr.ProductPriceHistory.LastOrDefault().Price,
                                      pr.ProductPriceHistory.Any(x => Convert.ToBoolean(x.IsDeleted)) ? false : true
                                  ));
            }
            else
            {
                UpdateDataGrid();
            }
        }
    }
}