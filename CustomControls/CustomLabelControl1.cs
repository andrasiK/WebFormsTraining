using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wrapper;


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

        public string CustomId { get; set; }

        protected override void RenderContents(HtmlTextWriter output)
        {
            var language = HttpContext.Current.Session["Language"].ToString();
            var msgList  = (List<string>)HttpContext.Current.Application["Messages"];

            List<Message> msgListCorrect = new List<Message>();

            for (int i = 0; i < msgList.Count; i++)
            {

                for (int j = 0; j < msgList.Count; j++)
                {
                    msgListCorrect[i].MessageId   = int.Parse( msgList[j]);
                    msgListCorrect[i].MessageLanguage = msgList[++j];
                    msgListCorrect[i].MessageText = msgList[++j];
                    msgListCorrect[i].CustomId = msgList[++j];

                    j++;
                }
                msgListCorrect.Add(msgListCorrect[i]);
                i++;
            }
        
            
            foreach (var item in msgListCorrect)
            {
                if (item.MessageLanguage == language && item.CustomId == CustomId)
                {
                    _labelText = item.MessageText;

                    output.Write(_labelText);
                }
                else
                {
                    _labelText = "Error...";
                    output.Write(_labelText);
                }
            }
            
        }
    }
}
