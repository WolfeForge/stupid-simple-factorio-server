using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SSFS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("C://FactorioServer/factorio");
            TextWriter txt = new StreamWriter("C://FactorioServer/factorio/server-settings.json");
            txt.WriteLine("{");
            txt.Write("\"name\": \"");
            txt.Write(textBox1.Text);
            txt.WriteLine("\",");
            txt.WriteLine("\"description\": \"A Factorio Server\",");
            txt.WriteLine("\"tags\": [\"game\", \"tags\"],");
            txt.Write("\"max_players\": ");
            txt.Write(textBox3.Text);
            txt.WriteLine(",");
            txt.WriteLine("\"visibility\":");
            txt.WriteLine("{");
            txt.WriteLine("\"public\": true,");
            txt.WriteLine("\"lan\"; true");
            txt.WriteLine("},");
            txt.Write("\"username\": \"");
            txt.Write(textBox4.Text);
            txt.WriteLine("\",");
            txt.WriteLine("\"password\"; \"\",");
            txt.Write("\"token\": \"");
            txt.Write(textBox5.Text);
            txt.WriteLine("\",");
            txt.Write("\"game_password\": \"");
            txt.Write(textBox2.Text);
            txt.WriteLine("\",");
            txt.WriteLine("\"require_user_verification\": true,");
            txt.WriteLine("\"max_upload_in_kilobytes_per_second\": 0,");
            txt.WriteLine("\"max_upload_slots\": 5,");
            txt.WriteLine("\"minimum_latency_in_ticks\": 0,");
            txt.WriteLine("\"ignore_player_limit_for_returning_players\": false,");
            txt.WriteLine("\"allow_commands\": \"admins-only\",");
            txt.WriteLine("\"autosave_interval\": 10,");
            txt.WriteLine("\"autosave_slots\": 5,");
            txt.WriteLine("\"afk_autokick_interval\": 0,");
            txt.WriteLine("\"auto_pause\": true,");
            txt.WriteLine("\"only_admins_can_pause_the_game\": true,");
            txt.WriteLine("\"autosave_only_on_server\": true,");
            txt.WriteLine("\"non_blocking_saving\": false,");
            txt.WriteLine("\"minimum_segment_size\": 25,");
            txt.WriteLine("\"minimum_segment_size_peer_count\": 20,");
            txt.WriteLine("\"maximum_segment_size\": 100,");
            txt.WriteLine("\"maximum_segment_size_peer_count\": 10");
            txt.WriteLine("}");
            txt.Close();
            Form2 form2 = new Form2
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            Form2 frm2 = form2;
            form2.FormClosing += delegate { Application.Exit(); };
            form2.Show();
            this.Hide();

            
        }
    }
}
