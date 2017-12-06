using System;
using ZJModbus.App.Attributes;

namespace ZJModbus.App.Tools
{
    public class ByteAdapter<T> where T : class, new()
    {
        public static T GetData(byte[] data)
        {
            T entity = new T();
            var type = entity.GetType();
            var members = type.GetMethods();
            bool isInit = false;
            int index = 0;
            byte[] bf = new byte[2];
            for (int i = 3; i < data.Length - 2; i += 2)
            {
                int num = (data[i] & 0xFF) << 8;
                num += (data[i + 1] & 0xFF);

                foreach (var m in members)
                {
                    var attr = Attribute.GetCustomAttribute(m, typeof(ByteAttribute));
                    if (null == attr)
                    {
                        continue;
                    }
                    var battr = attr as ByteAttribute;
                    if (battr.ByteIndex == index)
                    {
                        m.Invoke(entity, new object[] { num });
                        isInit = true;
                    }
                }
                index++;
            }
            return isInit ? entity : null;
        }
    }
}
