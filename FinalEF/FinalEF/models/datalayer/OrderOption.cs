using System;
using System.Collections.Generic;

namespace FinalEF.models.datalayer;

public partial class OrderOption
{
    public int OptionId { get; set; }

    public decimal SalesTaxRate { get; set; }

    public decimal FirstBookShipCharge { get; set; }

    public decimal AdditionalBookShipCharge { get; set; }
}
