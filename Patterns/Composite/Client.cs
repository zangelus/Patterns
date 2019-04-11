using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Client
    {
        public IComponent Cmp1 { get; private set; }
        public IComponent Cmp2 { get; private set; }
        public IComponent Cmp3 { get; private set; }
        public IComponent Document { get; private set; }

        public Client()
        {
            Cmp1 = new Composite();
            var el11 = new ItemType1("item11");
            var el12 = new ItemType1("item12");

            Cmp2 = new Composite();
            var el21 = new ItemType1("item21");
            var el22 = new ItemType1("item22");

            ((Composite)Cmp1).AddChild(el21);
            ((Composite)Cmp1).AddChild(el22);

            ((Composite)Cmp2).AddChild(el11);
            ((Composite)Cmp2).AddChild(el12);
            ((Composite)Cmp2).AddChild(Cmp1);


            Document        = new Document();
            var page1       = new Page();
            var paragraph1  = new Paragraph();
            var paragrpah2  = new Paragraph();
            var line1       = new ItemType1("Lorem ipsum dolor sit amet, ");
            var line2       = new ItemType1("consectetur adipiscing elit.");
            var line3       = new ItemType1("Nulla molestie nibh id dui fringilla bibendum.");
            var line4       = new ItemType1("Quisque sed risus ut tellus varius");

            paragraph1.AddChild(line1);
            paragraph1.AddChild(line2);
            paragrpah2.AddChild(line3);
            paragrpah2.AddChild(line4);

            page1.AddChild(paragraph1);
            page1.AddChild(paragrpah2);

            ((Composite)Document).AddChild(page1);
        }
    }
}
