using BulkMail.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkMail.Data
{
    public interface IdataDAO
    {
        MailData loadData(String filepath);
        void saveData(MailData data, String filepath);
    }
}
