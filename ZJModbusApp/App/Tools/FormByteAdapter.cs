using System;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using ZJModbus.App.Entities;

namespace ZJModbus.App.Tools
{
    public class FormByteAdapter
    {
        public interface SetFormCtls
        {
            void SetCtls(BaseStatusEntity entity);

            void SetCtls(AlEmtity entity);

            void SetCtls(AOEntity entity);

            void SetCtls(DIEntity entity);

            void SetCtls(DOEntity entity);

            void SetCtls(AlarmEntity entity);
        }

        private static Type GetFormAdapterConfig(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath+ "\\FormAdapterConfig.xml");
            foreach(XmlElement node in doc.DocumentElement.ChildNodes)
            {
                if (node.FirstChild.InnerText.Equals(key))
                {
                    return Type.GetType(node.LastChild.InnerText);
                }
            }
            return null;
        }
        
        public static void Adapter(int dataType, byte[] data, SetFormCtls action)
        {
            Type type = GetFormAdapterConfig(dataType.ToString());
            if(null != type)
            {
                Type adapterType = typeof(ByteAdapter<>);
                adapterType = adapterType.MakeGenericType(type);
                object o = Activator.CreateInstance(adapterType);
                object result = adapterType.InvokeMember("GetData", BindingFlags.Default | BindingFlags.InvokeMethod, null, o, new object[] { data });
                if (null != action)
                {
                    action.GetType().InvokeMember("SetCtls", BindingFlags.Default | BindingFlags.InvokeMethod, null, action, new object[] { result });
                }
            }
        }
        
    }
}
