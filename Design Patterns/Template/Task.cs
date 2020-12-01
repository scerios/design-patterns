using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Template
{
    public abstract class Task
    {
        public AuditTrail AuditTrail { get; set; }

        public Task()
        {
            AuditTrail = new AuditTrail();
        }

        public Task(AuditTrail auditTrail)
        {
            AuditTrail = auditTrail;
        }

        public void Execute()
        {
            AuditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}
