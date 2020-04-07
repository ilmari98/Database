using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDBTest.Views
{
    interface IPersonViews
    {
        void CreatePerson();
        void ReadAllData();
        void ReadByCity();
        void UpdatePerson();
        void DeletePerson();
    }
}
