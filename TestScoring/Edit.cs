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
    public partial class Edit : Form
    {
        List<Season> seasons;

        public Edit(List<Season> seasonList)
        {
            InitializeComponent();

            seasons = seasonList;

            InitAllSeason();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            var dataGridView = sender as DataGridView;

            //コミットされていない内容がある
            if (dataGridView.IsCurrentCellDirty)
            {
                dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void InitAllSeason()
        {
            Sort sort = new Sort();

            sort.SortList(seasons, Sort.SortKey.Season);

            dataGridView1.ColumnCount = 4;

            dataGridView1.Columns[0].HeaderText = "時期";
            dataGridView1.Columns[1].HeaderText = "教科名";
            dataGridView1.Columns[2].HeaderText = "名前";
            dataGridView1.Columns[3].HeaderText = "点数";

            foreach (Season season in seasons)
            {
                foreach (Subject subject in season.subjects)
                {
                    foreach (StudentInfo studentInfo in subject.studentInfos)
                    {
                        this.dataGridView1.Rows.Add(season.Year + season.prophaseOrAnaphase, subject.Name, studentInfo.Name, studentInfo.Score);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteItem()
        {
            DataGridViewSelectedRowCollection src = dataGridView1.SelectedRows;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int tableRow = 0;

                for (int i = 0; i < seasons.Count; i++)
                {
                    var season = seasons[i];

                    for (int j = 0; j < season.subjects.Count; j++)
                    {
                        var subject = season.subjects[j];

                        for (int k = 0; k < subject.studentInfos.Count; k++)
                        {
                            if (row.Index == tableRow++)
                            {
                                //生徒情報を削除
                                subject.studentInfos.RemoveAt(k);

                                if (subject.studentInfos.Count == 0)
                                {
                                    //教科を削除
                                    season.subjects.RemoveAt(j);

                                    if (season.subjects.Count == 0)
                                    {
                                        //時期を削除
                                        seasons.RemoveAt(i);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //行の削除
            for (int i = 0; i < src.Count; i++)
            {
                if (src[i].Index != src.Count + 1)
                {
                    dataGridView1.Rows.RemoveAt(src[i].Index);
                }
            }
        }


    }
}
