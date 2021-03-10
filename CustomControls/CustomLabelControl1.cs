using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControls
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:CustomLabelControl1 runat=server></{0}:CustomLabelControl1>")]
    public class CustomLabelControl1 : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]

        private string _labelText;
        public string LabelText
        {
            get
            {
                return _labelText;
            }

            set
            {
                _labelText = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(_labelText);
        }
    }
}
