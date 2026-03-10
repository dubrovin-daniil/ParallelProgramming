using System.Diagnostics;

namespace ParallelPractise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnNotParallel.Enabled = false;

            Stopwatch sw = Stopwatch.StartNew();
            int filesCount = 0;
            if (Directory.Exists(tbPath.Text))
            {
                string[] files = Directory.GetFiles(tbPath.Text, tbExtension.Text, SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    filesCount++;
                }
            }
            sw.Stop();

            rtbConsole.AppendText($"NotParalel -- Files count: {filesCount}. Time: {sw.ElapsedMilliseconds} ms.\n");
            btnNotParallel.Enabled = true;
        }

        private void btnParallel_Click(object sender, EventArgs e)
        {
            btnParallel.Enabled = false;

            Stopwatch sw = Stopwatch.StartNew();
            int filesCount = 0;
            if (Directory.Exists(tbPath.Text))
            {
                string[] files = Directory.GetFiles(tbPath.Text, tbExtension.Text, SearchOption.AllDirectories);

                Parallel.ForEach<int, int>(files, () => 0,
                    (file, loopState, subtotal) =>
                    {
                        subtotal++;
                        return subtotal;
                    }, subtotal => Interlocked.Add(ref filesCount, subtotal));
            }
            sw.Stop();

            rtbConsole.AppendText($"Paralel -- Files count: {filesCount}. Time: {sw.ElapsedMilliseconds} ms.\n");
            btnParallel.Enabled = true;
        }
    }
}
