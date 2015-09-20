using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activator.Items.Blackmarket
{
    class _3434 : item
    {
        internal override int Id
        {
            get { return 3434; }
        }

        internal override int Priority
        {
            get { return 5; }
        }

        internal override string Name
        {
            get { return "Pox"; }
        }

        internal override string DisplayName
        {
            get { return "Pox Arcana (Soon)"; }
        }

        internal override float Range
        {
            get { return 525; }
        }

        internal override int Duration
        {
            get { return 1000; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfCount, MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.SummonersRift }; }
        }

        internal override int DefaultHP
        {
            get { return 95; }
        }

        internal override int DefaultMP
        {
            get { return 35; }
        }
    }
}
