using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class Module
    {
        public Module(string moduleName,Subject subject)
        {
            this.ModuleName = moduleName;
            this.Subject = subject;

            subject.Module.Add(this);
        }

        #region Properties and Members

        private string m_moduleName;
        public string ModuleName
        {
            get { return m_moduleName; }
            set { m_moduleName = value; }
        }

        private Subject m_subject;
        public Subject Subject
        {
            get { return m_subject; }
            set { m_subject = value; }
        }


        #endregion

    }
}
