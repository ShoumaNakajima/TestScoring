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
            numericUpDown1.Minimum = 0;
            // 最大値
            numericUpDown1.Maximum = 100;
            // 初期値
            numericUpDown1.Value = 50;

            //numericUpDown2の初期化
            // 最小値
            numericUpDown2.Minimum = 0;
            // 最大値
            numericUpDown2.Maximum = 10000;
            // 初期値
            numericUpDown2.Value = 2020;

            //numericUpDown3の初期化
            // 最小値
            numericUpDown3.Minimum = 0;
            // 最大値
            numericUpDown3.Maximum = 10000;
            // 初期値
            numericUpDown3.Value = 2020;

            string[] items = { "前期","後期" };
            //combobox3の初期化
            comboBox3.Text = items[0];
            comboBox3.Items.AddRange(items);
            //combobox4の初期化
            comboBox4.Text = items[0];
            comboBox4.Items.AddRange(items);

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

            comboBox1.Items.AddRange(subjectsName);
            comboBox5.Items.AddRange(subjectsName);

            comboBox2.Items.AddRange(studentsName);
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
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("教科名が入力されていません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(comboBox2.Text))
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
                if ((seasons[i].Year + seasons[i].prophaseOrAnaphase) == (numericUpDown3.Value + comboBox4.Text))
                {
                    return false;
                }
            }
            return true;
        }

        private bool FindSubject()
        {
            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.prophaseOrAnaphase) == (numericUpDown3.Value + comboBox4.Text));

            if (season == null) return false;

            for (int i = 0; i < season.subjects.Count; i++)
            {
                if (season.subjects[i].Name == comboBox1.Text)
                {
                    return false;
                }
            }
            return true;
        }

        private bool FindStudent()
        {
            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.prophaseOrAnaphase) == (numericUpDown3.Value + comboBox4.Text));

            if (season == null) return false;

            Subject? subject = season.subjects.Find(subjectName => subjectName.Name == comboBox1.Text);

            if (subject == null) return false;

            for (int i = 0; i < season.subjects.Count; i++)
            {
                if (subject.Name == comboBox2.Text)
                {
                    return false;
                }
            }
            return true;
        }

        private bool CreateSeason()
        {
            Season season = new Season((int) numericUpDown3.Value, comboBox4.Text);

            season.AddSubject(comboBox1.Text, comboBox2.Text, (int) numericUpDown1.Value);

            bool isExist = false;

            for (int i = 0; i < seasons.Count; i++)
            {
                if ((seasons[i].Year.ToString() + seasons[i].prophaseOrAnaphase) == (numericUpDown3.Value + comboBox4.Text))
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
            Subject subject = new Subject(comboBox1.Text);

            subject.AddStudentInfo(comboBox2.Text, (int)numericUpDown1.Value);

            bool isExist = false;

            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.prophaseOrAnaphase) == (numericUpDown3.Value + comboBox4.Text));

            for (int i = 0; i < season.subjects.Count; i++)
            {
                if (season.subjects[i].Name == comboBox1.Text)
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
            StudentInfo studentInfo = new StudentInfo(comboBox2.Text, (int)numericUpDown1.Value);

            bool isExist = false;

            Season? season = seasons.Find(seasonName => (seasonName.Year + seasonName.prophaseOrAnaphase) == (numericUpDown3.Value + comboBox4.Text));

            Subject? subject = season.subjects.Find(subjectName => subjectName.Name == comboBox1.Text);

            for(int i = 0;i < subject.studentInfos.Count; i++)
            {
                if(subject.studentInfos[i].Name == comboBox2.Text)
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

            for(int i = 0;i < comboBox1.Items.Count; i++)
            {
                if (comboBox1.Text == comboBox1.Items[i].ToString())
                {
                    isDuplicateSubjectName = true;
                }
            }
            if (isDuplicateSubjectName == false)
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox5.Items.Add(comboBox1.Text);
            }
            
            bool isDuplicateStudentName = false;
            
            for (int j = 0; j < comboBox2.Items.Count; j++)
            {
                if (comboBox2.Text == comboBox2.Items[j].ToString())
                {
                    isDuplicateStudentName = true;
                }
            }
            if (isDuplicateStudentName == false)
            {
                comboBox2.Items.Add(comboBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table table = new Table(seasons);
            table.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table table = new Table(seasons, numericUpDown2.Value + comboBox3.Text, comboBox5.Text);
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
                "XMLFileの入出力はするが利用者側が触れないようにするため、パスの指定などを考えて作った" + Environment.NewLine +
                Environment.NewLine +
                "・見た目" + Environment.NewLine +
                "MessageBoxを用いてUI/UXに配慮して作った" + Environment.NewLine +
                "教科名や生徒の名前などのコンボボックスの要素を追加するたびに更新して入力しやすいように配慮した" + Environment.NewLine
                , "アピールポイント", MessageBoxButtons.OK,MessageBoxIcon.None);
        }
    }
}
