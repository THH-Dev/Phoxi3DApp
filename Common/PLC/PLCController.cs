using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanHungHa.Common.PLC
{
    public class PLCRegisterPropertyDescriptor : PropertyDescriptor
    {
        private PropertyDescriptor innerPropertyDescriptor;
        private int index;

        public PLCRegisterPropertyDescriptor(PropertyDescriptor innerPropertyDescriptor, int index)
            : base(innerPropertyDescriptor)
        {
            this.innerPropertyDescriptor = innerPropertyDescriptor;
            this.index = index;
        }

        public override bool CanResetValue(object component)
        {
            return innerPropertyDescriptor.CanResetValue(GetInnerComponent(component));
        }

        public override object GetValue(object component)
        {
            return innerPropertyDescriptor.GetValue(GetInnerComponent(component));
        }

        public override void ResetValue(object component)
        {
            innerPropertyDescriptor.ResetValue(GetInnerComponent(component));
        }

        public override void SetValue(object component, object value)
        {
            innerPropertyDescriptor.SetValue(GetInnerComponent(component), value);
        }

        public override bool ShouldSerializeValue(object component)
        {
            return innerPropertyDescriptor.ShouldSerializeValue(GetInnerComponent(component));
        }

        public override Type ComponentType => typeof(PLCRegister);

        public override bool IsReadOnly => innerPropertyDescriptor.IsReadOnly;

        public override Type PropertyType => innerPropertyDescriptor.PropertyType;

        public override string DisplayName
        {
            get
            {
                string baseDisplayName = innerPropertyDescriptor.DisplayName;
                return $"Register {index + 1} - {baseDisplayName}";
            }
        }

        private object GetInnerComponent(object component)
        {
            if (component is List<PLCRegister> registerList)
            {
                if (index >= 0 && index < registerList.Count)
                {
                    return registerList[index];
                }
            }

            return null;
        }
    }


    public class PLCRegisterListTypeConverter : TypeConverter
    {
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            if (value is List<PLCRegister> registerList)
            {
                PropertyDescriptorCollection properties = new PropertyDescriptorCollection(null);

                for (int i = 0; i < registerList.Count; i++)
                {
                    PLCRegister register = registerList[i];
                    PropertyDescriptorCollection registerProperties = TypeDescriptor.GetProperties(register);

                    foreach (PropertyDescriptor registerProperty in registerProperties)
                    {
                        PLCRegisterPropertyDescriptor descriptor = new PLCRegisterPropertyDescriptor(registerProperty, i);
                        properties.Add(descriptor);
                    }
                }

                return properties;
            }

            return base.GetProperties(context, value, attributes);
        }

        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(PropertyDescriptorCollection))
            {
                return true;
            }

            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(PropertyDescriptorCollection))
            {
                return GetProperties(context, value, null);
            }

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }


    public class PLCController
    {
        private static PLCController _instance;
        private static readonly object _lock = new object();
        public static PLCController GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PLCController();
                    }
                }
            }
            return _instance;
        }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public MyPLC myPLC { get; set; }

        [TypeConverter(typeof(PLCRegisterListTypeConverter))]
        //public List<PLCRegister> list_plc_reg { get; set; }
        PLCController()
        {
            myPLC = MyPLC.GetInstance();
            //list_plc_reg = MyLib.GetListPLCREG();
        }

    }
}
