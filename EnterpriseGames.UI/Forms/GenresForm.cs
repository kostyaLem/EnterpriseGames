﻿using EnterpriseGames.Core.Models;
using EnterpriseGames.Core.Services;
using EnterpriseGames.UI.Utility;
using MetroFramework;
using MetroFramework.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EnterpriseGames.UI.Forms
{
    public partial class GenresForm : MetroForm
    {
        private readonly GenresService _genresService = new GenresService(Settings.Context);
        private IList<Genre> _items;

        public GenresForm()
        {
            InitializeComponent();
        }

        private void GenresForm_Load(object sender, System.EventArgs e)
        {
            var items = _genresService.GetAll(); ;

            lstGenres.Items.AddRange(items.Select(MapToItem).ToArray());
            _items = new List<Genre>(items);

            UpdateCounter();
        }

        private void btnRemove_Click(object sender, System.EventArgs e)
        {
            if (lstGenres.SelectedItems.Count != 0)
            {
                if (_genresService.Remove((long)lstGenres.SelectedItems[0].Tag))
                {
                    lstGenres.Items.Remove(lstGenres.SelectedItems[0]);
                    MetroMessageBox.Show(this, $"Жанр удалён", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateCounter();
                }
            }
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var genre = _genresService.Find((long)lstGenres.SelectedItems[0].Tag);
            genre.Name = txtName.Text.Trim();

            _genresService.Update(genre);
            MetroMessageBox.Show(this, $"Изменено", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstGenres.SelectedItems[0].Text = genre.Name;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            if (Helpers.IsAnyEmpty(string.IsNullOrEmpty, txtName.Text))
            {
                MetroMessageBox.Show(this, "Заполните название жанра", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var genre = new Genre() { Name = txtName.Text.Trim() };
            _genresService.Add(genre);
            lstGenres.Items.Add(new ListViewItem(txtName.Text.Trim()) { Tag = genre.Id });

            txtName.Text = string.Empty;
            UpdateCounter();
        }

        private void lstGenres_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstGenres.SelectedIndices.Count != 0)
            {
                btnRemove.Enabled = btnEdit.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = btnEdit.Enabled = false;
            }
        }

        private void txtFilter_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                lstGenres.Items.Clear();
                lstGenres.Items.AddRange(_items.Where(x => x.Name.Contains(txtFilter.Text.Trim())).Select(MapToItem).ToArray());
                lstGenres.Update();
            }
            else
            {
                lstGenres.Items.Clear();
                lstGenres.Items.AddRange(_items.Select(MapToItem).ToArray());
            }
        }

        private static ListViewItem MapToItem(Genre genre)
        {
            return new ListViewItem(genre.Name) { Tag = genre.Id };
        }

        private void UpdateCounter()
        {
            lblCount.Text = lstGenres.Items.Count.ToString();
        }
    }
}
