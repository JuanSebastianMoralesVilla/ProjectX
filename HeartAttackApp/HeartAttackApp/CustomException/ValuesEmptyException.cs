using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartAttackApp.CustomException
{
    public class ValuesEmptyException:Exception
    {
        private MessageBox message;
        public void show()
        {
            MessageBox.Show("Some values are Empty", " Values Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
