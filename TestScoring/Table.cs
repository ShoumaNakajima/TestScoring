using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable enable annotations

namespace TestScoring
{
    public partial class Table : Form
    {
        public bool SucceededCreatingWindow{set; get;}

        public Table(List<Season> seasonList)
        {
            InitializeComponent();

            dgvTable.ReadOnly = true;

            SucceededCreatingWindow = InitAllSeason(seasonList);
        }

        public Table(List<Season> seasonList,string searchSeasonName,string? searchSubjectName)
        {
            InitializeComponent();

            dgvTable.ReadOnly = true;

            if (string.IsNullOrEmpty(searchSubjectName))
            {
                SucceededCreatingWindow = InitSeason(seasonList, searchSeasonName);
            }
            else
            {
                SucceededCreatingWindow = InitSubject(seasonList, searchSeasonName, searchSubjectName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool InitAllSeason(List<Season> seasonList)
        {
            Sort sort = new Sort();

            sort.SortList(seasonList, Sort.SortKey.Season);

            dgvTable.ColumnCount = 4;

            dgvTable.Columns[0].HeaderText = "時期";
            dgvTable.Columns[1].HeaderText = "教科名";
            dgvTable.Columns[2].HeaderText = "名前";
            dgvTable.Columns[3].HeaderText = "点数";

            if (seasonList.Count == 0)
            {
                MessageBox.Show("表示する要素が存在しません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < seasonList.Count; i++)
            {
                var season = seasonList[i];

                for (int j = 0; j < season.subjects.Count; j++)
                {
                    var subject = season.subjects[j];

                    for (int k = 0; k < subject.studentInfos.Count; k++)
                    {
                        var studentInfo = subject.studentInfos[k];

                        dgvTable.Rows.Add(season.Year + season.semester, subject.Name, studentInfo.Name, studentInfo.Score);
                    }
                }
            }

            return true;
        }

        private bool InitSeason(List<Season> seasonList, string searchSeasonName)
        {
            Sort sort = new Sort();

            sort.SortList(seasonList, Sort.SortKey.Subject);

            dgvTable.ColumnCount = 4;

            dgvTable.Columns[0].HeaderText = "時期";
            dgvTable.Columns[1].HeaderText = "教科名";
            dgvTable.Columns[2].HeaderText = "名前";
            dgvTable.Columns[3].HeaderText = "点数";

            Season? searchSeason = seasonList.Find(season => season.Year + season.semester == searchSeasonName);

            if(searchSeason == null)
            {
                MessageBox.Show("時期が見つかりませんでした", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for(int i = 0; i < searchSeason.subjects.Count; i++)
            {
                var subject = searchSeason.subjects[i];

                for (int j = 0; j < subject.studentInfos.Count; j++)
                {
                    var studentInfo = subject.studentInfos[j];

                    dgvTable.Rows.Add(searchSeason.Year + searchSeason.semester, subject.Name, studentInfo.Name, studentInfo.Score);
                }
            
            }
            return true;

        }

        private bool InitSubject(List<Season> seasonList, string searchSeasonName, string searchSubjectName)
        {
            Sort sort = new Sort();

            sort.SortList(seasonList, Sort.SortKey.Subject);

            dgvTable.ColumnCount = 3;

            dgvTable.Columns[0].HeaderText = "教科名";
            dgvTable.Columns[1].HeaderText = "名前";
            dgvTable.Columns[2].HeaderText = "点数";

            Season? searchSeason = seasonList.Find(season => season.Year + season.semester == searchSeasonName);

            if (searchSeason == null)
            {
                MessageBox.Show("時期が見つかりませんでした", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Subject? searchSubject = searchSeason.subjects.Find(subject => subject.Name == searchSubjectName);

            if (searchSubject == null)
            {
                MessageBox.Show("教科名が見つかりませんでした", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            for (int i = 0; i < searchSubject.studentInfos.Count; i++)
            {
                var studentInfo = searchSubject.studentInfos[i];

                dgvTable.Rows.Add(searchSubject.Name, studentInfo.Name, studentInfo.Score);
            }
            return true;
        }        
    }
}
