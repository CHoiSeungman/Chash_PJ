using System.Security.Cryptography.X509Certificates;

namespace kiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Values
        {
            public double Val1(string a)//��1
            {
                if (a == "����")
                    return 1777061;
                else if (a == "������")
                    return 2057900;
                else if (a == "��ī��")
                    return 1732900;
                else if (a == "�ν���������")
                    return 1314000;
                else if (a == "�ٸ����γ�")
                    return 1231000;
                else if (a == "���帮��")
                    return 2448600;
                else if (a == "�����")
                    return 3529538;
                else if (a == "�׳׸���")
                    return 2303900;
                else if (a == "����")
                    return 421000;
                else if (a == "����ī")
                    return 265800;
                else if (a == "�����ī")
                    return 185699;
                else if (a == "������Ű")
                    return 528313;
                else if (a == "����ī��")
                    return 262700;
                else if (a == "����")
                    return 213700;
                else if (a == "�ȶ��")
                    return 256798;
                else
                    return 165477;
            }

            public double Val2(string a)//��2
            {
                if (a == "��õ��������T1")
                    return 30000;
                else
                    return 50000;
            }

            public double Val3(string a)//��3
            {
                if (a == "�����װ�")
                    return 50000;
                else if (a == "�ƽþƳ��װ�")
                    return 30000;
                else if (a == "������")
                    return 10000;
                else
                    return 10000;
            }
            public double Val4(string a)//��4
            {
                if (a == "�۽�ƮŬ����")
                    return 100000;
                else if (a == "�����Ͻ�Ŭ����")
                    return 50000;
                else
                    return 10000;
            }
            class ExChange//�� ���� ȯ�� �޼ҵ� �����ϱ�
            {
                //public double exchange_USA(double b)
                // {

                // }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) //rdAmerica_1��ư��
        {
            if (rdAmerica_1.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_1.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdAmerica_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmerica_2.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_2.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdAmerica_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmerica_3.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_3.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdAmerica_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmerica_4.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_4.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdSpain_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_1.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_1.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdSpain_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_2.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_2.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdSpain_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_3.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_3.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdSpain_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_4.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_4.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdJapan_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_1.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_1.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdJapan_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_2.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_2.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdJapan_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_3.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_3.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdJapan_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_4.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_4.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdPhil_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_1.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_1.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdPhil_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_2.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_2.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdPhil_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_3.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_3.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }

        private void rdPhil_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_4.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_4.Text + " " + "�����Ͻô±���!" + "\n���������� �������ּ���.");
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReserv_Click(object sender, EventArgs e)//����Ȯ�� ��ư Ŭ��
        {
            string str = "";//���ڿ� �ʱ�ȭ
            //tbMain.Text = "";

            if (rdAmerica_1.Checked == true || rdAmerica_2.Checked == true || rdAmerica_3.Checked == true || rdAmerica_4.Checked == true)
            {
                if (rdAmerica_1.Checked == true)
                    str += rdAmerica_1.Text;
                else if (rdAmerica_2.Checked == true)
                    str += rdAmerica_2.Text;
                else if (rdAmerica_3.Checked == true)
                    str += rdAmerica_3.Text;
                else 
                    str += rdAmerica_4.Text;
            }              

            if (rdSpain_1.Checked == true || rdSpain_2.Checked == true || rdSpain_3.Checked == true || rdSpain_4.Checked == true)
            {
                if (rdSpain_1.Checked == true)
                    str += rdSpain_1.Text;
                else if (rdSpain_2.Checked == true)
                    str += rdSpain_2.Text;
                else if (rdSpain_3.Checked == true)
                    str += rdSpain_3.Text;
                else
                    str += rdSpain_4.Text;
            }

            if (rdJapan_1.Checked == true || rdJapan_2.Checked == true || rdJapan_3.Checked == true || rdJapan_4.Checked == true)
            {
                if (rdJapan_1.Checked == true)
                    str = rdJapan_1.Text;
                else if (rdJapan_2.Checked == true)
                    str += rdJapan_2.Text;
                else if (rdJapan_3.Checked == true)
                    str += rdJapan_3.Text;
                else
                    str += rdJapan_4.Text;
            }

            if (rdPhil_1.Checked == true || rdPhil_2.Checked == true || rdPhil_3.Checked == true || rdPhil_4.Checked == true)
            {
                if (rdPhil_1.Checked == true)
                    str = rdPhil_1.Text;
                else if (rdPhil_2.Checked == true)
                    str += rdPhil_2.Text;
                else if (rdPhil_3.Checked == true)
                    str += rdPhil_3.Text;
                else
                    str += rdPhil_4.Text;
            }

            label9.Text = str;
            label10.Text = dateTimePicker1.Text;
            label11.Text = dateTimePicker2.Text;

            if (rdAirPort1.Checked == true)
                label12.Text = rdAirPort1.Text;
            else
                label12.Text = rdAirPort2.Text;

            if (rdFly1.Checked == true || rdFly2.Checked == true || rdFly3.Checked == true)
            {
                if (rdFly1.Checked == true)
                    label13.Text = rdFly1.Text;
                else if (rdFly2.Checked == true)
                    label13.Text = rdFly2.Text;
                else
                    label13.Text = rdFly3.Text;
            }

            if (rdSeat1.Checked == true || rdSeat2.Checked == true || rdSeat3.Checked == true)
            {
                if (rdSeat1.Checked == true)
                    label14.Text = rdSeat1.Text;
                else if (rdSeat2.Checked == true)
                    label14.Text = rdSeat2.Text;
                else
                    label14.Text = rdSeat3.Text;
            }

            //�����ݾ� ���
            Values values = new Values();

            double val1 = values.Val1(label9.Text);
            double val2 = values.Val2(label12.Text);
            double val3 = values.Val3(label13.Text);
            double val4 = values.Val4(label14.Text);

            double sum = val1 + val2 + val3 + val4;
            label22.Text = (string.Format("{0:#,0}��", sum));//1,000,000ó�� 3��° �������� ,
            //label22.Text = sum.ToString(sum+"��");//�� �����ݾ�

            MessageBox.Show("���೻���� Ȯ�����ּ���.\n���������� �����ø� ������ư�� �����ּ���.");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //������
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("�Ͻú�");
                listBox1.Items.Add("3���� �Һ�");
                listBox1.Items.Add("6���� �Һ�");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("���̹�����");
                listBox1.Items.Add("īī������");
                listBox1.Items.Add("��������");
            }


        }

        private void button1_Click(object sender, EventArgs e)//������ư
        {
            MessageBox.Show(comboBox1.Text + " " + listBox1.Text + " " + label22.Text + "�� �����Ͻðڽ��ϱ�?");
            MessageBox.Show("�����Ǿ����ϴ�. �������� �ǽñ� �ٶ��ϴ�.");

            rdAmerica_1.Checked = false;
            rdAmerica_2.Checked = false;
            rdAmerica_3.Checked = false;
            rdAmerica_4.Checked = false;

            rdSpain_1.Checked = false;
            rdSpain_2.Checked = false;
            rdSpain_3.Checked = false;
            rdSpain_4.Checked = false;

            rdJapan_1.Checked = false;
            rdJapan_2.Checked = false;
            rdJapan_3.Checked = false;
            rdJapan_4.Checked = false;

            rdPhil_1.Checked = false;
            rdPhil_2.Checked = false;
            rdPhil_3.Checked = false;
            rdPhil_4.Checked = false;

            rdAirPort1.Checked = false;
            rdAirPort2.Checked = false;

            rdFly1.Checked = false;
            rdFly2.Checked = false;
            rdFly3.Checked = false;
            rdFly4.Checked = false;

            rdSeat1.Checked = false;
            rdSeat2.Checked = false;
            rdSeat3.Checked = false;

            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label22.Text = "";

            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";

            comboBox1.SelectedIndex = 0;
            listBox1.Items.Clear();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ȯ���Ͻ� �ݾ��� �Է��Ͻð�,\n������ ������ư�� �����ּ���.");
        }

        private void exchg_USA_Click(object sender, EventArgs e)//�޷� ȯ��
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �츮����\n���������� �� ������ּ���!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �ϳ�����\n���������� �� ������ּ���!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ������������\n����: �츮����\n���������� �� ������ּ���!");
            else
                MessageBox.Show("����: ������������\n����: �ϳ�����\n���������� �� ������ּ���!");

            double before = double.Parse(textBox1.Text);//�ؽ�Ʈ �Է¹��� �� 

            double middle = before / 1278.6;
            double after = Math.Round(middle, 2);//Math.Round������� �Ҽ��� 2° �ڸ�����
            textBox2.Text = (string.Format("{0:#,0.00}",after));//ȯ���� ���� ���ڿ��� ��ȯ
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "����: USD";
        }

        private void exchg_Spain_Click(object sender, EventArgs e)//���� ȯ��
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �츮����\n���������� �� ������ּ���!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �ϳ�����\n���������� �� ������ּ���!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ������������\n����: �츮����\n���������� �� ������ּ���!");
            else
                MessageBox.Show("����: ������������\n����: �ϳ�����\n���������� �� ������ּ���!");

            double before = double.Parse(textBox1.Text);

            double middle = before / 1419.1;
            double after = Math.Round(middle, 2);
            textBox2.Text = (string.Format("{0:#,0.00}", after));
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "����: EUR";
        }

        private void exchg_JP_Click(object sender, EventArgs e)//��ȭ ȯ��
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �츮����\n���������� �� ������ּ���!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �ϳ�����\n���������� �� ������ּ���!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ������������\n����: �츮����\n���������� �� ������ּ���!");
            else
                MessageBox.Show("����: ������������\n����: �ϳ�����\n���������� �� ������ּ���!");

            double before = double.Parse(textBox1.Text);

            double middle = before / 9.127;
            double after = Math.Round(middle, 2);
            textBox2.Text = (string.Format("{0:#,0.00}", after));
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "����: JPY";
        }

        private void exchg_Phil_Click(object sender, EventArgs e)//��� ȯ��
        {

            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �츮����\n���������� �� ������ּ���!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("����: ��õ��������T1\n����: �ϳ�����\n���������� �� ������ּ���!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("����: ������������\n����: �츮����\n���������� �� ������ּ���!");
            else
                MessageBox.Show("����: ������������\n����: �ϳ�����\n���������� �� ������ּ���!");

            double before = double.Parse(textBox1.Text);

            double middle = before / 23.4;
            double after = Math.Round(middle, 2);
            textBox2.Text = (string.Format("{0:#,0.00}", after));
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "����: PHP";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            USAinfo_1.Text = "������ �̸�: �̱�(United States of America)";
            USAinfo_2.Text = "�����: ����";
            USAinfo_3.Text = "������: ������";
            USAinfo_4.Text = "���α�: 3�� 3,999�� 6,563��";
            USAinfo_5.Text = "������: �Ϻ��� ������������ķκ��� ������ �ƿ�����ı��� �پ��� ���ĸ�\n �� �� �ִ�.";
            USAinfo_6.Text = "����ȭ: ������ ������ȭ�� ȥ��� �ٹ�ȭ���� ��ȸ�� �������� ����� �����ش�.";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
        }

        private void btn_Spain_info_Click(object sender, EventArgs e)
        {
            USAinfo_1.Text = "�������̸�: ������(Spain)";
            USAinfo_2.Text = "�����: �����ĳľ�";
            USAinfo_3.Text = "������: ���帮��";
            USAinfo_4.Text = "���α�: 4,751�� 9,628��";
            USAinfo_5.Text = "������: �������°� ���� �����ؼ� ����, ������ �ܿ��� �µ����� ���Ͽ�\n ������ �縷 ����";
            USAinfo_6.Text = "����ȭ: �⵶���� �̽����� �����ߴ� �ñⰡ �־� ����ġ��� �ƶ� \n��ȭ�� ������ �ִ�.";

        }

        private void btn_Japan_info_Click(object sender, EventArgs e)
        {
            USAinfo_1.Text = "�������̸�: �Ϻ�(Japan)";
            USAinfo_2.Text = "�����: �Ϻ���";
            USAinfo_3.Text = "������: ����";
            USAinfo_4.Text = "���α�: 1�� 2,329�� 4,513��";
            USAinfo_5.Text = "������: �������� 5000Km�� �����־� �ô���Ŀ� ������İ� ����, \n������ ���� ���̰� ũ��";
            USAinfo_6.Text = "����ȭ: �Ϻ��� ����ô����, �ƽþ�,����,�Ϲ̷κ����� ������ �޾� \n��õ�⿡ ���� ��ȭ�ߴ�.";
        }

        private void btn_Phil_info_Click(object sender, EventArgs e)
        {
            USAinfo_1.Text = "�������̸�: �ʸ���(Phpilippines";
            USAinfo_2.Text = "�����: Ÿ���α׾�, ����";
            USAinfo_3.Text = "������: ���Ҷ�";
            USAinfo_4.Text = "���α�: 1�� 1,733�� 7,368��";
            USAinfo_5.Text = "������: �������ǳ���� ����μ� ���� �Ǳ��� ���̰� ū ��, \n�Ǳ�� 12��~5��, 6��~11�� ���";
            USAinfo_6.Text = "����ȭ: �پ��� ������ �����Ӹ� �ƴ϶� ������ȭ�� ������, \n�̱���ȭ���� ȥ�յ� ���� ��ȭ";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void show_message_america()// �̱� ����
        {
            if(rdAmerica_1.Checked)
            {
                MessageBox.Show("�̱� ��� �����Ͻô±���");
            }
            else if(rdAmerica_2.Checked)
            {
                MessageBox.Show("");
            }
            else if( rdAmerica_3.Checked)
            {
                MessageBox.Show("");
            }
            else if(rdAmerica_4.Checked)
            {
                MessageBox.Show("");
            }
        }
    }
}