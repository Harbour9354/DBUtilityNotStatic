using System;
using System.Configuration;
namespace Maticsoft.DBUtility
{
    /// <summary>
    /// ��������
    /// </summary>
    public class PubConstant
    {
        /// <summary>
        /// ��ȡ�����ַ���
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return GetConnectionString("ConnectionString");
            }
        }

        /// <summary>
        /// �õ�web.config������������ݿ������ַ�����(AppSettings: ConStringEncrypt,true ����)
        /// </summary>
        /// <param name="configName">�����ַ�����</param>
        /// <returns>���ݿ������ַ���</returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }
    }
}
