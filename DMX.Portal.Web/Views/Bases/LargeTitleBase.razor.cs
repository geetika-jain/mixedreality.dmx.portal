﻿using Microsoft.AspNetCore.Components;

namespace DMX.Portal.Web.Views.Bases
{
    public partial class LargeTitleBase
    {
        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public string ClassName { get; set; }
    }
}
