using Reminder.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder
{
    public partial class MemoForm : Form
    {
        private long? _currentItem = null;

        public MemoForm()
        {
            InitializeComponent();
        }

        private void MemoForm_Load(object sender, EventArgs e)
        {
            using (var db = new ReminderContext())
            {
                memoTitleList.DataSource = db.Memo
                    .Where(it => it.IsVisible)
                    .OrderByDescending(it => it.RegistrationDate).ToList();

                memoTitleList.DisplayMember = "Title";
            }
        }

        private void submitChange_Click(object sender, EventArgs e)
        {
            using (var db = new ReminderContext())
            {
                Memo parent = null;

                if (_currentItem != null)
                    parent = db.Memo.FirstOrDefault(it => it.MemoId == _currentItem);

                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        var m = new Memo();
                        m.Title = titleTextBox.Text;
                        m.Text = textTextBox.Text;
                        m.RegistrationDate = DateTime.Now;
                        m.IsVisible = true;

                        m.ParentId = parent?.MemoId;
                        db.Memo.Add(m);

                        if (parent != null)
                            parent.IsVisible = false;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                    tran.Commit();
                }

                db.SaveChanges();

                _currentItem = db.Memo
                    .OrderByDescending(it => it.MemoId)
                    .FirstOrDefault()?.MemoId;

                memoTitleList.DataSource = db.Memo
                    .Where(it => it.IsVisible)
                    .OrderByDescending(it => it.RegistrationDate).ToList();
            }
        }

        private void newMemo_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            textTextBox.Text = "";
            _currentItem = null;
        }

        private void purgeMemo_Click(object sender, EventArgs e)
        {
            if (_currentItem != null)
            {
                using (var db = new ReminderContext())
                {
                    var m = db.Memo.FirstOrDefault(it => it.MemoId == _currentItem);
                    if (m != null)
                    {
                        m.IsVisible = false;
                        db.SaveChanges();
                    }
                    memoTitleList.DataSource = db.Memo
                        .Where(it => it.IsVisible)
                        .OrderByDescending(it => it.RegistrationDate).ToList();
                }
            }

            titleTextBox.Text = "";
            textTextBox.Text = "";
            _currentItem = null;
        }

        private void memoTitleList_DoubleClick(object sender, EventArgs e)
        {
            var ix = ((Memo)memoTitleList.SelectedItem)?.MemoId;

            if (ix == null)
                return;

            using (var db = new ReminderContext())
            {
                var m = db.Memo.FirstOrDefault(it => it.MemoId == ix);

                if (m != null)
                {
                    _currentItem = m.MemoId;
                    titleTextBox.Text = m.Title;
                    textTextBox.Text = m.Text;
                }
            }
        }
    }
}
