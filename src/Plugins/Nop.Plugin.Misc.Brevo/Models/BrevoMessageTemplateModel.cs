﻿using Nop.Web.Framework.Models;

namespace Nop.Plugin.Misc.Brevo.Models
{
    /// <summary>
    /// Represents message template model
    /// </summary>
    public record BrevoMessageTemplateModel : BaseNopEntityModel
    {
        public string Name { get; set; }

        public bool IsActive { get; set; }

        public string ListOfStores { get; set; }

        public bool UseSendinblueTemplate { get; set; }

        public string EditLink { get; set; }
    }
}