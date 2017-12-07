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
            Type getEntityType(int dataType);
            void SetCtls(BaseStatusEntity entity);

            void SetCtls(AIEntity entity);

            void SetCtls(AOEntity entity);

            void SetCtls(DIEntity entity);

            void SetCtls(DOEntity entity);

            void SetCtls(AlarmEntity entity);
            void SetCtls(SettingEntity entity);
            void SetCtls(StartStopEntity entity);
        }
        
        public static void Adapter(int dataType, byte[] data, SetFormCtls action)
        {
            if (null != action)
            {
                Type type =action.getEntityType(dataType);
                if (null != type)
                {
                    Type adapterType = typeof(ByteAdapter<>);
                    adapterType = adapterType.MakeGenericType(type);
                    object o = Activator.CreateInstance(adapterType);
                    object result = adapterType.InvokeMember("GetData", BindingFlags.Default | BindingFlags.InvokeMethod, null, o, new object[] { data });
                    action.GetType().InvokeMember("SetCtls", BindingFlags.Default | BindingFlags.InvokeMethod, null, action, new object[] { result });
                }
            }
        }
    }
}
