using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class Item
    {
        public string name;
        public int price;
        public bool correctPrice;
        public Item(string name, string price)
        {
            this.name = name;
            correctPrice = int.TryParse(price, out int result);
            if (correctPrice)
            {
                this.price = result;
            }
        }
        public static Item[] ArrayItem(string array)
        {
            while (array.IndexOf("\n\n") != -1)
            {
                array = array.Replace("\n\n", "\n");
            }
            while (array.IndexOf("  ") != -1)
            {
                array = array.Replace("  ", " ");
            }

            string[] line = array.Split('\n');
            Item[] result = new Item[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                string[] elem = line[i].Split('=');
                if (elem.Length == 2)
                {
                    result[i] = new Item(elem[0], elem[1]);
                }
                else
                {
                    result[i] = new Item(elem[0], "~~~");
                }
            }

            return result;
        }
    }
    abstract public class ChequeAbs
    {
        public abstract Item[] Items
        {
            get;
            set;
        }
        public abstract bool FrameReceiptDetails
        {
            get;
            set;
        }
        public abstract Control Rendering(); // Отрисовка
    }

    public class Cheque : ChequeAbs
    {
        private Item[] items;
        private bool frameReceiptDetails;
        private int len = 20;
        public string receiptDetalis
        {
            get
            {
                int maxLen = 30;
                string result = "";
                if (items.Length > maxLen)
                {
                    return "Слишком много элементов";
                }
                for (int i = 0; i < items.Length - 1; i++)
                {
                    result += (i + 1) + ((i + 1) < 10 ? ".  " : ". ");
                    result += items[i].name;
                    for (int c = items[i].name.Length; c < len; c++)
                    {
                        result += " ";
                    }
                    result += " = ";
                    if (items[i].correctPrice)
                    {
                        result += items[i].price;
                    }
                    else
                    {
                        result += "???";
                    }
                    result += "\n";
                }
                if (items[items.Length - 1].name.Length > 0)
                {
                    result += (items.Length - 1 + 1) + ((items.Length - 1 + 1) < 10 ? ".  " : ". ");
                    result += items[items.Length - 1].name;
                    for (int c = items[items.Length - 1].name.Length; c < len; c++)
                    {
                        result += " ";
                    }
                    result += " = ";
                    if (items[items.Length - 1].correctPrice)
                    {
                        result += items[items.Length - 1].price;
                    }
                    else
                    {
                        result += "???";
                    }
                    result += "\n";
                }
                return result;
            }
        }
        public override Item[] Items
        {
            get { return items; }
            set { items = value; }
        }
        public override bool FrameReceiptDetails
        {
            get { return frameReceiptDetails; }
            set { frameReceiptDetails = value; }
        }
        public Cheque(string data)
        {
            items = Item.ArrayItem(data);
        }
        public override Control Rendering() // Отрисовка
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Consolas", 9.75F);
            label.Text = receiptDetalis;

            Panel result = new Panel();
            result.BorderStyle = BorderStyle.None;
            result.BackColor = System.Drawing.Color.White;
            result.Size = new System.Drawing.Size(246, receiptDetalis.Split('\n').Length * 15);
            result.BorderStyle =
                frameReceiptDetails ?
                BorderStyle.FixedSingle : BorderStyle.None;
            result.Controls.Add(label);

            return result;
        }
    }

    class DecoratorVirtual : ChequeAbs
    {
        protected ChequeAbs _component;
        public override Item[] Items
        {
            get { return _component.Items; }
            set { _component.Items = value; }
        }
        public DecoratorVirtual(ChequeAbs _component)
        {
            this._component = _component;
        }
        public override Control Rendering() // Отрисовка
        {
            return _component.Rendering();
        }
        public override bool FrameReceiptDetails
        {
            get { return _component.FrameReceiptDetails; }
            set { _component.FrameReceiptDetails = value; }
        }
    }

    class DecoratorCompanyName : DecoratorVirtual
    {
        public string _companyName;
        public DecoratorCompanyName(ChequeAbs _component, string _companyName) : base(_component)
        {
            this._companyName = _companyName;
        }
        public override Control Rendering() // Отрисовка
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font(
                "Consolas",
                14.25F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(204)));
            label.Location = new System.Drawing.Point(0, 0);
            label.Text = _companyName;

            Control previous = _component.Rendering();
            previous.Location = new System.Drawing.Point(0, label.Height);

            Panel result = new Panel();
            result.BorderStyle = BorderStyle.None;
            result.BackColor = System.Drawing.Color.White;
            result.Size = new System.Drawing.Size(248, label.Height + previous.Height);
            result.Controls.Add(previous);
            result.Controls.Add(label);

            return result;
        }
    }
    class DecoratoAddress : DecoratorVirtual
    {
        public string _address;
        public DecoratoAddress(ChequeAbs _component, string _address) : base(_component)
        {
            this._address = _address;
        }
        public override Control Rendering() // Отрисовка
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Consolas", 9.75F);
            label.Location = new System.Drawing.Point(0, 0);
            label.Text = _address;

            Control previous = _component.Rendering();
            previous.Location = new System.Drawing.Point(0, label.Height);

            Panel result = new Panel();
            result.BorderStyle = BorderStyle.None;
            result.BackColor = System.Drawing.Color.White;
            result.Size = new System.Drawing.Size(248, label.Height + previous.Height);
            result.Controls.Add(previous);
            result.Controls.Add(label);

            return result;
        }
    }
    class DecoratorFrame : DecoratorVirtual
    {
        public DecoratorFrame(ChequeAbs _component) : base(_component)
        {
        }
        public override Control Rendering() // Отрисовка
        {
            Control previous = _component.Rendering();

            Panel result = new Panel();
            result.BackColor = System.Drawing.Color.White;
            result.Size = new System.Drawing.Size(248, 2 + previous.Height);
            result.Controls.Add(previous);
            result.Controls.Add(_component.Rendering());
            result.BorderStyle = BorderStyle.FixedSingle;
            return result;
        }
    }
    class DecoratorAmount : DecoratorVirtual
    {
        public DecoratorAmount(ChequeAbs _component) : base(_component)
        {
        }
        public override Control Rendering() // Отрисовка
        {
            int sum = 0;
            bool flagCorrect = true;

            for (int i = 0; i < _component.Items.Length - 1; i++)
            {
                sum += _component.Items[i].price;
                flagCorrect &= _component.Items[i].correctPrice;
            }
            if (_component.Items[_component.Items.Length - 1].name.Length > 0)
            {
                sum += _component.Items[_component.Items.Length - 1].price;
                flagCorrect &= _component.Items[_component.Items.Length - 1].correctPrice;
            }

            //foreach (Item item in _component.Items)
            //{
            //    sum += item.price;
            //    flagCorrect &= item.correctPrice;
            //}

            Control previous = _component.Rendering();

            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Consolas", 9.75F);
            label.Text = "цена = ";
            if (flagCorrect)
            {
                label.Text += sum;
            }
            else
            {
                label.Text += "~~~";
            }
            label.Location = new System.Drawing.Point(240 - label.Width, previous.Height);

            previous.Location = new System.Drawing.Point(0, 0);

            Panel result = new Panel();
            result.BorderStyle = BorderStyle.None;
            result.BackColor = System.Drawing.Color.White;
            result.Size = new System.Drawing.Size(248, label.Height + previous.Height);
            result.Controls.Add(previous);
            result.Controls.Add(_component.Rendering());
            result.Controls.Add(label);

            return result;
        }
    }
    class DecoratorAdvertisement : DecoratorVirtual
    {
        public string _advertisement;
        public DecoratorAdvertisement(ChequeAbs _component, string _advertisement) : base(_component)
        {
            this._advertisement = _advertisement;
        }
        public override Control Rendering() // Отрисовка
        {
            Control previous = _component.Rendering();

            Label label = new Label();
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Consolas", 9.75F);
            label.Location = new System.Drawing.Point(0, previous.Height);
            label.Text = _advertisement;

            previous.Location = new System.Drawing.Point(0, 0);

            Panel result = new Panel();
            result.BorderStyle = BorderStyle.None;
            result.BackColor = System.Drawing.Color.White;
            result.Size = new System.Drawing.Size(248, label.Height + previous.Height);
            result.Controls.Add(previous);
            result.Controls.Add(label);

            return result;
        }
    }

    class DecoratorFinal : DecoratorVirtual
    {
        private Form _form;
        public DecoratorFinal(ChequeAbs _component, Form _form) : base(_component)
        {
            this._form = _form;
        }
        public override Control Rendering() // Отрисовка
        {
            Control result = _component.Rendering();
            _form.Rendering(result);
            return result;
        }
    }

}