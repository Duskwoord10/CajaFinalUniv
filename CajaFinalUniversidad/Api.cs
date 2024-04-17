using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;
namespace CajaFinalUniversidad
{
    public partial class Api : Component
    {
        public Api()
        {
            InitializeComponent();
        }

        public Api(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
