using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.Linq;

#nullable enable annotations

//コンポジットパターン
namespace TestScoring
{
    public partial class Home : Form
    {
        public List<Season> seasons;

        public const string fileName = @".\ScoreFile.xml";

        public Home()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //numericUpDown1の初期化
            // 最小値
            nudAddScore.Minimum = 0;
            // 最大値
            nudAddScore.Maximum = 100;
            // 初期値
            nudAddScore.Value = 50;

            //numericUpDown2の初期化
            // 最小値
            nudFindYear.Minimum = 0;
            // 最大値
            nudFindYear.Maximum = 10000;
            // 初期値
            nudFindYear.Value = 2020;

            //numericUpDown3の初期化
            // 最小値
            nudAddYear.Minimum = 0;
            // 最大値
            nudAddYear.Maximum = 10000;
            // 初期値
            nudAddYear.Value = 2020;

            string[] items = { "前期","後期" };
            //combobox3の初期化
            cmdFindSemester.Text = items[0];
            cmdFindSemester.Items.AddRange(items);
            //combobox4の初期化
            cmdAddSemester.Text = items[0];
            cmdAddSemester.Items.AddRange(items);

            //リストの初期化
            seasons = new List<Season>();
            XMLInput();


            string[] allSubjectsName = { };
            string[] allStudentsName = { };

            string[] subjectsName = new string[0];
            string[] studentsName = new string[0];

            //XMLでとってきた情報を用いた初期化
            seasons.ForEach(
                season =>
                season.subjects.ForEach(
                    subject =>
                    {
                        Array.Resize(ref allSubjectsName, allSubjectsName.Length + 1);
                        allSubjectsName[allSubjectsName.Length - 1] = subject.Name;
                            
                        //生徒情報の追加
                        subject.studentInfos.ForEach(
                            studentInfo =>
                            {
                                Array.Resize(ref allStudentsName, allStudentsName.Length + 1);
                                allStudentsName[allStudentsName.Length - 1] = studentInfo.Name;
                            }
                            );
                    }
                    ));

            //教科の追加
            for (int i = 0; i < allSubjectsName.Length;i++)
            {
                bool isDuplicateName = false;

                for (int j = 0; j < subjectsName.Length; j++)
                {
                    if (string.IsNullOrEmpty(allSubjectsName[i])  || (allSubjectsName[i] == subjectsName[j]))
                    {
                        isDuplicateName = true;
                    }
                }
                if(isDuplicateName == false)
                {
                    //教科情報の追加
                    Array.Resize(ref subjectsName, subjectsName.Length + 1);
                    subjectsName[subjectsName.Length - 1] = allSubjectsName[i];
                }
            }


            for (int i = 0; i < allStudentsName.Length; i++)
            {
                bool isDuplicateName = false;

                for (int j = 0; j < studentsName.Length; j++)
                {
                    if (string.IsNullOrEmpty(allStudentsName[i]) || (allStudentsName[i] == studentsName[j]))
                    {
                        isDuplicateName = true;
                    }
                }
                if (isDuplicateName == false)
                {
                    //教科情報の追加
                    Array.Resize(ref studentsName, studentsName.Length + 1);
                    studentsName[studentsName.Length - 1] = allStudentsName[i];
                }
            }

            cmdAddSubject.Items.AddRange(subjectsName);
            cmdFindSubjct.Items.AddRange(subjectsName);

            cmdAddStudent.Items.AddRange(studentsName);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            XMLOutput();
        }

        private void XMLInput()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Season>));

            System.IO.StreamReader? streamReader = null;

            try
            {
                 streamReader = new System.IO.StreamReader(fileName);
                 seasons = (List<Season>)serializer.Deserialize(streamReader);
                 streamReader.Close();
            }
            catch
            {
                MessageBox.Show("ScoreFile.xmlが見つかりませんでした", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void XMLOutput()
        {
            var result = MessageBox.Show("本当に保存しますか？", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (result == DialogResult.No)
            {
                // 保存を中止
                return;
            }

            //Serializationのインスタンス生成
            XmlSerializer serializer = new XmlSerializer(typeof(List<Season>));
            //StreamWriterのインスタンス生成
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(fileName, false, new System.Text.UTF8Encoding(false));
            //シリアル化し、XMLにファイルに保存する
            serializer.Serialize(streamWriter, seasons);
            streamWriter.Close();

            MessageBox.Show("保存しました", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmdAddSubject.Text))
            {
                MessageBox.Show("教科名が入力されていません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(cmdAddStudent.Text))
            {
                MessageBox.Show("生徒名が入力されていません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isNewSeason = FindSeason();
            bool isNewSubject = FindSubject();
            bool isNewStudent = FindStudent();

            bool isSuccess = false;
            if(isNewSeason)
            {
                isSuccess = CreateSeason();
            }
            else if(isNewSubject)
            {
                isSuccess = CreateSubject();
            }
            else if(isNewStudent)
            {
                 isSuccess = CreateStudent();
            }

            if (isSuccess)
            {
                AddComboBox();
                MessageBox.Show("追加しました", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("追加に失敗しました", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool FindSeason()
        {
            for(int i = 0;i < seasons.Count;i++)
            {
                if ((seasons[i].Year + seasons[i].semester) == (nudAddYear.Value + cmdAddSemester.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private bool FindSubject()
        {
            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.semester) == (nudAddYear.Value + cmdAddSemester.Text));

            if (season == null) return false;

            for (int i = 0; i < season.subjects.Count; i++)
            {
                if (season.subjects[i].Name == cmdAddSubject.Text)
                {
                    return false;
                }
            }
            return true;
        }

        private bool FindStudent()
        {
            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.semester) == (nudAddYear.Value + cmdAddSemester.Text));

            if (season == null) return false;

            Subject? subject = season.subjects.Find(subjectName => subjectName.Name == cmdAddSubject.Text);

            if (subject == null) return false;

            for (int i = 0; i < season.subjects.Count; i++)
            {
                if (subject.Name == cmdAddStudent.Text)
                {
                    return false;
                }
            }
            return true;
        }

        private bool CreateSeason()
        {
            Season season = new Season((int) nudAddYear.Value, cmdAddSemester.Text);

            season.AddSubject(cmdAddSubject.Text, cmdAddStudent.Text, (int) nudAddScore.Value);

            bool isExist = false;

            for (int i = 0; i < seasons.Count; i++)
            {
                if ((seasons[i].Year.ToString() + seasons[i].semester) == (nudAddYear.Value + cmdAddSemester.Text))
                {
                    isExist = true;
                }
            }

            if (isExist)
            {
                MessageBox.Show("既にseasonが存在します。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            seasons.Add(season);
            return true;
        }

        private bool CreateSubject()
        {
            Subject subject = new Subject(cmdAddSubject.Text);

            subject.AddStudentInfo(cmdAddStudent.Text, (int)nudAddScore.Value);

            bool isExist = false;

            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.semester) == (nudAddYear.Value + cmdAddSemester.Text));

            for (int i = 0; i < season.subjects.Count; i++)
            {
                if (season.subjects[i].Name == cmdAddSubject.Text)
                {
                    isExist = true;
                }
            }

            if(isExist)
            {
                MessageBox.Show("既にsubjectが存在します", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            season.subjects.Add(subject);

            return true;
        }

        private bool CreateStudent()
        {
            StudentInfo studentInfo = new StudentInfo(cmdAddStudent.Text, (int)nudAddScore.Value);

            bool isExist = false;

            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.semester) == (nudAddYear.Value + cmdAddSemester.Text));

            Subject? subject = season.subjects.Find(subjectName => subjectName.Name == cmdAddSubject.Text);

            for(int i = 0;i < subject.studentInfos.Count; i++)
            {
                if(subject.studentInfos[i].Name == cmdAddStudent.Text)
                {
                    isExist = true;
                }
            }

            if(isExist)
            {
                MessageBox.Show("既にstudentInfoが存在します", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            subject.studentInfos.Add(studentInfo);

            return true;
        }

        public void AddComboBox()
        {   
            bool isDuplicateSubjectName = false;

            for(int i = 0;i < cmdAddSubject.Items.Count; i++)
            {
                if (cmdAddSubject.Text == cmdAddSubject.Items[i].ToString())
                {
                    isDuplicateSubjectName = true;
                }
            }
            if (isDuplicateSubjectName == false)
            {
                cmdAddSubject.Items.Add(cmdAddSubject.Text);
                cmdFindSubjct.Items.Add(cmdAddSubject.Text);
            }
            
            bool isDuplicateStudentName = false;
            
            for (int j = 0; j < cmdAddStudent.Items.Count; j++)
            {
                if (cmdAddStudent.Text == cmdAddStudent.Items[j].ToString())
                {
                    isDuplicateStudentName = true;
                }
            }
            if (isDuplicateStudentName == false)
            {
                cmdAddStudent.Items.Add(cmdAddStudent.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table table = new Table(seasons);
            table.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table table = new Table(seasons, nudFindYear.Value + cmdFindSemester.Text, cmdFindSubjct.Text);
            table.Show();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit(seasons);
            edit.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("アプリケーションを終了しますか？", "Select", MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (result == DialogResult.No)
            {
                // 終了処理を中止
                e.Cancel = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "・技術面" + Environment.NewLine +
                "初めてtry catchを使用した" + Environment.NewLine +
                "ListのLinqを多用した" + Environment.NewLine +
                "nullを許容するかどうかを意識しました（Null許容型参照を使用した）" + Environment.NewLine +
                "XMLFileの入出力はするが利用者側が触れないようにするため、パスの指定なども考えて作った" + Environment.NewLine +
                Environment.NewLine +
                "・見た目" + Environment.NewLine +
                "MessageBoxを用いてUI/UXに配慮して作った" + Environment.NewLine +
                "教科名や生徒の名前などのコンボボックスの要素を追加するたびに更新して入力しやすいように配慮した" + Environment.NewLine
                , "アピールポイント", MessageBoxButtons.OK,MessageBoxIcon.None);
        }

        private void season_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
