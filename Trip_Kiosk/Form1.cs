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
            public double Val1(string a)//값1
            {
                if (a == "뉴욕")
                    return 1777061;
                else if (a == "워싱턴")
                    return 2057900;
                else if (a == "시카고")
                    return 1732900;
                else if (a == "로스엔젤레스")
                    return 1314000;
                else if (a == "바르셀로나")
                    return 1231000;
                else if (a == "마드리드")
                    return 2448600;
                else if (a == "세비야")
                    return 3529538;
                else if (a == "테네리페")
                    return 2303900;
                else if (a == "도쿄")
                    return 421000;
                else if (a == "오사카")
                    return 265800;
                else if (a == "후쿠오카")
                    return 185699;
                else if (a == "나가사키")
                    return 528313;
                else if (a == "보라카이")
                    return 262700;
                else if (a == "세부")
                    return 213700;
                else if (a == "팔라완")
                    return 256798;
                else
                    return 165477;
            }

            public double Val2(string a)//값2
            {
                if (a == "인천국제공항T1")
                    return 30000;
                else
                    return 50000;
            }

            public double Val3(string a)//값3
            {
                if (a == "대한항공")
                    return 50000;
                else if (a == "아시아나항공")
                    return 30000;
                else if (a == "진에어")
                    return 10000;
                else
                    return 10000;
            }
            public double Val4(string a)//값4
            {
                if (a == "퍼스트클래스")
                    return 100000;
                else if (a == "비지니스클래스")
                    return 50000;
                else
                    return 10000;
            }
            class ExChange//각 나라 환전 메소드 선언하기
            {
                //public double exchange_USA(double b)
                // {

                // }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) //rdAmerica_1버튼임
        {
            if (rdAmerica_1.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_1.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdAmerica_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmerica_2.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_2.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdAmerica_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmerica_3.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_3.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdAmerica_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAmerica_4.Checked == true)
            {
                MessageBox.Show(lbAmerica.Text + " " + rdAmerica_4.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdSpain_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_1.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_1.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdSpain_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_2.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_2.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdSpain_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_3.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_3.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdSpain_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSpain_4.Checked == true)
            {
                MessageBox.Show(lbSpain.Text + " " + rdSpain_4.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdJapan_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_1.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_1.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdJapan_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_2.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_2.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdJapan_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_3.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_3.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdJapan_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdJapan_4.Checked == true)
            {
                MessageBox.Show(lbJapan.Text + " " + rdJapan_4.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdPhil_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_1.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_1.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdPhil_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_2.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_2.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdPhil_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_3.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_3.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }

        private void rdPhil_4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPhil_4.Checked == true)
            {
                MessageBox.Show(lbPhil.Text + " " + rdPhil_4.Text + " " + "여행하시는군요!" + "\n여행일정을 선택해주세요.");
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReserv_Click(object sender, EventArgs e)//예약확인 버튼 클릭
        {
            string str = "";//문자열 초기화
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

            //결제금액 출력
            Values values = new Values();

            double val1 = values.Val1(label9.Text);
            double val2 = values.Val2(label12.Text);
            double val3 = values.Val3(label13.Text);
            double val4 = values.Val4(label14.Text);

            double sum = val1 + val2 + val3 + val4;
            label22.Text = (string.Format("{0:#,0}원", sum));//1,000,000처럼 3번째 단위마다 ,
            //label22.Text = sum.ToString(sum+"원");//총 결제금액

            MessageBox.Show("예약내역을 확인해주세요.\n변동사항이 없으시면 결제버튼을 눌러주세요.");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //결제란
        {
            listBox1.Items.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add("일시불");
                listBox1.Items.Add("3개월 할부");
                listBox1.Items.Add("6개월 할부");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Add("네이버페이");
                listBox1.Items.Add("카카오페이");
                listBox1.Items.Add("제로페이");
            }


        }

        private void button1_Click(object sender, EventArgs e)//결제버튼
        {
            MessageBox.Show(comboBox1.Text + " " + listBox1.Text + " " + label22.Text + "을 결제하시겠습니까?");
            MessageBox.Show("결제되었습니다. 좋은여행 되시길 바랍니다.");

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
            MessageBox.Show("환전하실 금액을 입력하시고,\n오른쪽 국가버튼을 눌러주세요.");
        }

        private void exchg_USA_Click(object sender, EventArgs e)//달러 환전
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 김포국제공항\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else
                MessageBox.Show("공항: 김포국제공항\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");

            double before = double.Parse(textBox1.Text);//텍스트 입력받은 돈 

            double middle = before / 1278.6;
            double after = Math.Round(middle, 2);//Math.Round사용으로 소숫점 2째 자리까지
            textBox2.Text = (string.Format("{0:#,0.00}",after));//환전한 숫자 문자열로 변환
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "단위: USD";
        }

        private void exchg_Spain_Click(object sender, EventArgs e)//유로 환전
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 김포국제공항\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else
                MessageBox.Show("공항: 김포국제공항\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");

            double before = double.Parse(textBox1.Text);

            double middle = before / 1419.1;
            double after = Math.Round(middle, 2);
            textBox2.Text = (string.Format("{0:#,0.00}", after));
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "단위: EUR";
        }

        private void exchg_JP_Click(object sender, EventArgs e)//엔화 환전
        {
            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 김포국제공항\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else
                MessageBox.Show("공항: 김포국제공항\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");

            double before = double.Parse(textBox1.Text);

            double middle = before / 9.127;
            double after = Math.Round(middle, 2);
            textBox2.Text = (string.Format("{0:#,0.00}", after));
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "단위: JPY";
        }

        private void exchg_Phil_Click(object sender, EventArgs e)//페소 환전
        {

            if (radioButton1.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
                MessageBox.Show("공항: 인천국제공항T1\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
                MessageBox.Show("공항: 김포국제공항\n은행: 우리은행\n수령지점을 꼭 기억해주세요!");
            else
                MessageBox.Show("공항: 김포국제공항\n은행: 하나은행\n수령지점을 꼭 기억해주세요!");

            double before = double.Parse(textBox1.Text);

            double middle = before / 23.4;
            double after = Math.Round(middle, 2);
            textBox2.Text = (string.Format("{0:#,0.00}", after));
            textBox2.BackColor = Color.DeepSkyBlue;
            label42.Text = "단위: PHP";
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
            USAinfo_1.Text = "▶국가 이름: 미국(United States of America)";
            USAinfo_2.Text = "▶언어: 영어";
            USAinfo_3.Text = "▶수도: 워싱턴";
            USAinfo_4.Text = "▶인구: 3억 3,999만 6,563명";
            USAinfo_5.Text = "▶기후: 북부의 습윤대륙성기후로부터 남부의 아열대기후까지 다양한 기후를\n 볼 수 있다.";
            USAinfo_6.Text = "▶문화: 세계의 여러문화가 혼재된 다문화주의 사회의 전형적인 모습을 보여준다.";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
        }

        private void btn_Spain_info_Click(object sender, EventArgs e)
        {
            USAinfo_1.Text = "▶국가이름: 스페인(Spain)";
            USAinfo_2.Text = "▶언어: 에스파냐어";
            USAinfo_3.Text = "▶수도: 마드리드";
            USAinfo_4.Text = "▶인구: 4,751만 9,628명";
            USAinfo_5.Text = "▶기후: 건조상태가 심한 지중해성 기후, 여름과 겨울의 온도차가 심하여\n 국지적 사막 존재";
            USAinfo_6.Text = "▶문화: 기독교와 이슬람이 공존했던 시기가 있어 유럽치고는 아랍 \n문화의 흔적이 있다.";

        }

        private void btn_Japan_info_Click(object sender, EventArgs e)
        {
            USAinfo_1.Text = "▶국가이름: 일본(Japan)";
            USAinfo_2.Text = "▶언어: 일본어";
            USAinfo_3.Text = "▶수도: 도쿄";
            USAinfo_4.Text = "▶인구: 1억 2,329만 4,513명";
            USAinfo_5.Text = "▶기후: 남북으로 5000Km에 뻗어있어 냉대기후와 열대기후가 존재, \n지역별 기후 차이가 크다";
            USAinfo_6.Text = "▶문화: 일본의 조몬시대부터, 아시아,유럽,북미로부터의 영향을 받아 \n수천년에 걸쳐 변화했다.";
        }

        private void btn_Phil_info_Click(object sender, EventArgs e)
        {
            USAinfo_1.Text = "▶국가이름: 필리핀(Phpilippines";
            USAinfo_2.Text = "▶언어: 타갈로그어, 영어";
            USAinfo_3.Text = "▶수도: 마닐라";
            USAinfo_4.Text = "▶인구: 1억 1,733만 7,368명";
            USAinfo_5.Text = "▶기후: 열대계절풍기후 지대로서 우기와 건기의 차이가 큰 편, \n건기는 12월~5월, 6월~11월 우기";
            USAinfo_6.Text = "▶문화: 다양한 종족과 종교뿐만 아니라 기층문화에 스페인, \n미국문화까지 혼합된 복합 문화";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void show_message_america()// 미국 선택
        {
            if(rdAmerica_1.Checked)
            {
                MessageBox.Show("미국 어디를 여행하시는군요");
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