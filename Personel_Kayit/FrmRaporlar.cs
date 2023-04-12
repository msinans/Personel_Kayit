using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

            this.reportViewer1.RefreshReport();

            /*
             Projenizde;

        1-Sağdan  Solution Explorer / C# Personel_Kayit (sağ tıklayın) / Manage NuGet Packages...  tıklayın

        2-Installed bölümüne tıklayın ve oradaki tüm Microsoft.Report öğelerini silin (Uninstall). *Microsoft.SqlServer.Types i silmeyin sakın.

        3-Browse kısmına geçip "Microsoft.ReportViewer.WinForms"  yazın.

        Sırasıyla;

          -Microsoft.ReportViewer.WinForms  (üreticisi Microsoft olanı) solunda sonsuzluk işareti olan

          -Microsoft.ReportingServices.ReportViewerControl.Winforms (üreticisi Microsoft olanı)

        yüklemelerini yapın.

        4-Şimdi Yine Solution Explorer da Projemizin üstünde sağ tık / Rebuild  tıklayın.

        5-Project / Add Form / Report Wizard a tıklayın / İsim verin /Add tıklayın.



            Arkadaşlar 2022 için çözüm henüz bulunmamış fakat epey araştırdım nasıl yapılması gerektiğini buldum.

        Design a new report ve Report Wizard Bulamama sorununla karşılaşanlar için..

        Toolbox'tan form'a report wiever eklediniz fakat imleçte design a new report yoksa;

        1-)Projeye sağ tık->Manage NuGet Packess..-> 2 adet eklentiyi indiriyoruz(Microsoft.ReportingServices.ReportViewerControl.Winforms-Microsoft.SqlServer.Types)

        2-)Extensions->Manage Extensions->Microsoft RDLC Report Designer 2022 indiriyoruz

        3-)Project->Add New Item..->Report Wizard

            Yine de çalıştırınca rapor kısmı boş geliyorsa;

            ReporyViewer1 in üstündeki ok açılarak aşağıdakiler yapılır

            FrmRaporlar --> ReportViewer1 --> Choose Report = Personel_Kayit.Report1 seçip --> Choose Data Sources kısmında ise DataSet1'in karşısında çıkan Data Source Instance kısmında da tblPersonelBindingSource Seçince Raporu çekebildim.


        
             */
        }
    }
}
