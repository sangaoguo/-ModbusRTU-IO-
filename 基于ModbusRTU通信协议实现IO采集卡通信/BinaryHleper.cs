using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace 基于ModbusRTU通信协议实现IO采集卡通信
{
    internal class BinaryHleper
    {
        public static void Serializeobject<T>(string path, T obj)
        { 
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                binaryFormatter.Serialize(fileStream, obj);
            }
            catch (Exception ex ) 
            {
                throw ex ;
            } 
            finally
            {
                fileStream.Close();
            }
        }

        public static  T Deseralizeobject<T>(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
         
            try
            {
               return  (T)binaryFormatter.Deserialize(fileStream);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}
