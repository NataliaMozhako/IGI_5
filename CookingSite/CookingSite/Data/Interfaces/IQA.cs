using CookingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingSite.Data.Interfaces
{
    interface IQA
    {
        public void AddQADB(QA qa);
        public IEnumerable<QA> AllQAs();
        public void DeleteQA(QA qa);
        public QA GetQADB(int id);
        public void UpdateQA(QA qa);
    }
}
