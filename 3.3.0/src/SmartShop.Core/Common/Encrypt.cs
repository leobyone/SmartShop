using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Common
{
    /// <summary>
    /// 加密解密类
    /// </summary>
    public class Encrypt
    {
        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串,失败返回源串</returns>
        public static string Encode(string encryptString, string encryptKey)
        {
            if (encryptKey.Length < 8)
            {
                encryptKey = encryptKey.PadRight(8);
            }
            else
            {
                encryptKey = encryptKey.Substring(0, 8);
            }
            byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey);
            byte[] rgbIV = Keys;
            byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
            DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Convert.ToBase64String(mStream.ToArray());
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串,失败返源串</returns>
        public static string Decode(string decryptString, string decryptKey)
        {
            if (decryptKey.Length < 8)
            {
                decryptKey = decryptKey.PadRight(8);
            }
            else
            {
                decryptKey = decryptKey.Substring(0, 8);
            }

            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();

                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return "";
            }

        }

        /// <summary>
        /// MD5函数
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <returns>MD5结果</returns>
        public static string MD5(string str)
        {
            byte[] b = Encoding.Default.GetBytes(str);
            b = new MD5CryptoServiceProvider().ComputeHash(b);
            string ret = "";
            for (int i = 0; i < b.Length; i++)
                ret += b[i].ToString("x").PadLeft(2, '0');
            return ret.ToUpper();
        }

        /// <summary>
        /// SHA256函数
        /// </summary>
        /// /// <param name="str">原始字符串</param>
        /// <returns>SHA256结果</returns>
        public static string SHA256(string str)
        {
            byte[] SHA256Data = Encoding.UTF8.GetBytes(str);
            SHA256Managed Sha256 = new SHA256Managed();
            byte[] Result = Sha256.ComputeHash(SHA256Data);
            return Convert.ToBase64String(Result);  //返回长度为44字节的字符串
        }


        /// <summary>  
        /// 加密字符串  
        /// </summary>  
        /// <param name="sinputString"></param>  
        /// <param name="Skey"></param>  
        /// <returns></returns>  
        public static string EncryptString(string sinputString, string Skey)
        {
            byte[] data = Encoding.UTF8.GetBytes(sinputString);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Mode = CipherMode.ECB;
            DES.Padding = PaddingMode.PKCS7;
            //Skey = Skey.PadRight(24);
            //Skey = "123qweas";
            DES.Key = ASCIIEncoding.ASCII.GetBytes(Skey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(Skey);
            //DES.IV = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            ICryptoTransform desEncrypt = DES.CreateEncryptor();
            byte[] result = desEncrypt.TransformFinalBlock(data, 0, data.Length);
            return BitConverter.ToString(result);
        }
        /// <summary>  
        /// 解密字符串  
        /// </summary>  
        /// <param name="sinputString"></param>  
        /// <param name="sKey"></param>  
        /// <returns></returns>  
        public static string DecryptString(string sinputString, string sKey)
        {
            string[] sinput = sinputString.Split("-".ToCharArray());
            byte[] data = new byte[sinput.Length];
            for (int i = 0; i < sinput.Length; i++)
            {
                data[i] = byte.Parse(sinput[i], System.Globalization.NumberStyles.HexNumber);
            }
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            ICryptoTransform desencrypt = DES.CreateDecryptor();
            byte[] result = desencrypt.TransformFinalBlock(data, 0, data.Length);
            return Encoding.UTF8.GetString(result);
        }



        /// <summary>  
        /// DES3 ECB模式加密  
        /// </summary>  
        /// <param name="key">密钥</param>  
        /// <param name="iv">IV(当模式为ECB时，IV无用)</param>  
        /// <param name="str">明文的byte数组</param>  
        /// <returns>密文的byte数组</returns>  
        public static byte[] Des3EncodeECB(byte[] key, byte[] iv, byte[] data)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
                tdsp.Mode = CipherMode.ECB;
                tdsp.Padding = PaddingMode.PKCS7;


                CryptoStream cStream = new CryptoStream(mStream,
                tdsp.CreateEncryptor(key, iv),
                CryptoStreamMode.Write);

                cStream.Write(data, 0, data.Length);
                cStream.FlushFinalBlock();

                byte[] ret = mStream.ToArray();
                cStream.Close();
                mStream.Close();
                return ret;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
                return null;
            }
        }
        public static string DES_ECB(string str, string key)
        {
            byte[] keyArray = System.Text.ASCIIEncoding.ASCII.GetBytes(key);
            byte[] ivArray = System.Text.ASCIIEncoding.ASCII.GetBytes("");
            byte[] toEncryptArray = System.Text.ASCIIEncoding.ASCII.GetBytes(str);

            MemoryStream mStream = new MemoryStream();
            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            //TripleDES tdsp = TripleDES.Create();
            tdsp.Mode = CipherMode.ECB;
            tdsp.Padding = PaddingMode.PKCS7;

            CryptoStream cStream = new CryptoStream(mStream, tdsp.CreateEncryptor(keyArray, ivArray), CryptoStreamMode.Write);

            cStream.Write(toEncryptArray, 0, toEncryptArray.Length);
            cStream.FlushFinalBlock();

            byte[] ret = mStream.ToArray();
            cStream.Close();
            mStream.Close();
            return Convert.ToBase64String(ret);
        }
        public static string ECB(string keyStr, string str)
        {
            byte[] key = Convert.FromBase64String(keyStr);
            byte[] iv = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };      //当模式为ECB时，IV无用  
            byte[] data = Encoding.UTF8.GetBytes(str);

            byte[] str1 = Des3EncodeECB(key, iv, data);
            return Convert.ToBase64String(str1);
        }
        /// <summary>  
        /// DES3 ECB模式解密  
        /// </summary>  
        /// <param name="key">密钥</param>  
        /// <param name="iv">IV(当模式为ECB时，IV无用)</param>  
        /// <param name="str">密文的byte数组</param>  
        /// <returns>明文的byte数组</returns>  
        public static byte[] Des3DecodeECB(byte[] key, byte[] iv, byte[] data)
        {
            //try
            //{
            // Create a new MemoryStream using the passed   
            // array of encrypted data.  
            MemoryStream msDecrypt = new MemoryStream(data);
            TripleDESCryptoServiceProvider tdsp = new TripleDESCryptoServiceProvider();
            tdsp.Mode = CipherMode.ECB;
            tdsp.Padding = PaddingMode.PKCS7;
            // Create a CryptoStream using the MemoryStream   
            // and the passed key and initialization vector (IV).  
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                tdsp.CreateDecryptor(key, iv),
                 CryptoStreamMode.Read);
            // Create buffer to hold the decrypted data.  
            byte[] fromEncrypt = new byte[data.Length];
            // Read the decrypted data out of the crypto stream  
            // and place it into the temporary buffer.  
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
            //Convert the buffer into a string and return it.  
            return fromEncrypt;
            //}
            //catch (CryptographicException e)
            //{
            //    Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            //    return null;
            //}
        }


        public static string cc(string str, string keyStr)
        {
            //byte[] bytes = new byte[24];
            //byte[] _key = Convert.FromBase64String(keyStr);
            //_key.CopyTo(bytes, 0);
            //return Convert.ToBase64String(bytes);

            TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
            byte[] buffer = Encoding.Default.GetBytes(str);
            MemoryStream stream = new MemoryStream();
            byte[] key = Convert.FromBase64String("AQjP4U1aCnnybWsmHUQ7BVIxHyrnQ2AP");
            CryptoStream encStream = new CryptoStream(stream, des.CreateEncryptor(key, null), CryptoStreamMode.Write);
            encStream.Write(buffer, 0, buffer.Length);
            encStream.FlushFinalBlock();
            byte[] res = stream.ToArray();
            return Convert.ToBase64String(res);
        }

        public static string EncryptAA(string Message, string key, string IV)
        {
            //try
            //{

            //byte[] key1 = Encoding.ASCII.GetBytes(key);
            byte[] key1 = Convert.FromBase64String(key);
            byte[] desKey = new byte[24];
            key1.CopyTo(desKey, 0);


            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            byte[] tdesKey = hashmd5.ComputeHash(keyBytes);
            byte[] keyIV = Encoding.UTF8.GetBytes(IV);
            byte[] inputByteArray = Encoding.ASCII.GetBytes(Message);

            //DESCryptoServiceProvider desProvider = new DESCryptoServiceProvider();
            TripleDESCryptoServiceProvider desProvider = new TripleDESCryptoServiceProvider();
            //desProvider.KeySize = 128;

            // java 默认的是ECB模式，PKCS5padding；c#默认的CBC模式，PKCS7padding 所以这里我们默认使用ECB方式
            desProvider.Mode = CipherMode.ECB;
            desProvider.Padding = PaddingMode.PKCS7;
            MemoryStream memStream = new MemoryStream();
            CryptoStream crypStream = new CryptoStream(memStream, desProvider.CreateEncryptor(desKey, Keys), CryptoStreamMode.Write);

            crypStream.Write(inputByteArray, 0, inputByteArray.Length);
            crypStream.FlushFinalBlock();
            return Convert.ToBase64String(memStream.ToArray());

            //}
            //catch
            //{
            //    return "";
            //}

        }

        public static string Encrypt3DES(string a_strString, string a_strKey, string a_strIV)
        {
            System.Security.Cryptography.TripleDESCryptoServiceProvider des = new System.Security.Cryptography.TripleDESCryptoServiceProvider();
            byte[] inputByteArray = System.Text.Encoding.UTF8.GetBytes(a_strString);
            //des.Key = System.Text.Encoding.UTF8.GetBytes(a_strKey);
            byte[] _key = System.Text.Encoding.UTF8.GetBytes(a_strKey);
            //des.IV = System.Text.Encoding.UTF8.GetBytes(a_strIV);
            //des.IV = Keys;
            des.Mode = System.Security.Cryptography.CipherMode.CBC;
            des.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, des.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            //System.IO.StreamWriter swEncrypt = new System.IO.StreamWriter(cs);
            //swEncrypt.WriteLine(a_strString);
            //swEncrypt.Close();

            //把内存流转换成字节数组，内存流现在已经是密文了
            byte[] bytesCipher = ms.ToArray();
            //内存流关闭

            string base64String = System.Convert.ToBase64String(bytesCipher);
            //string by = "";
            //foreach (byte b in bytesCipher)
            //{
            //    by += b.ToString() + " ";
            //}
            //SbeLogger.info("【3DESBytes】" + by);
            //byte[] FromBase64String = Convert.FromBase64String(base64String);
            //ms = new MemoryStream(FromBase64String);
            //cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Read);
            //StreamReader sr = new StreamReader(cs);
            ////输出解密后的内容
            //string DecryptString = sr.ReadLine();

            //加密流关闭
            cs.Close();
            des.Clear();
            ms.Close();


            return base64String;
        }

        /// <summary>
        /// 16进字符串转字节数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace("   ", " ");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
        /// <summary>
        /// 16进字符串转字节数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static byte[] HexStringToByteArray2(string s)
        {
            byte[] buffer = new byte[s.Length / 2];
            var chars = s.ToCharArray();
            int j = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
                char c0 = chars[j++];
                char c1 = chars[j++];

                buffer[i] = (byte)(parse(c0) << 4 | parse(c1));
            }

            return buffer;
        }
        private static int parse(char c)
        {
            if (c >= 'a') return (c - 'a' + 10) & 0x0f;
            if (c >= 'A') return (c - 'A' + 10) & 0x0f;
            return (c - '0') & 0x0f;
        }
        public static string EncryptECB(string data, string key)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            var keyIv = HexStringToByteArray2(key);
            des.Mode = System.Security.Cryptography.CipherMode.ECB; // ECB 加密
            des.Padding = System.Security.Cryptography.PaddingMode.PKCS7;   // PKCS7 对应 Java PKCS5Padding
            des.Key = keyIv;
            des.IV = keyIv;

            MemoryStream mStream = new MemoryStream();
            // 构造加密流
            CryptoStream cStream = new CryptoStream(mStream, des.CreateEncryptor(), CryptoStreamMode.Write);
            // 将待加密的数据转换为字节数组
            byte[] inputByteArray = System.Text.UTF8Encoding.UTF8.GetBytes(data);
            // 加密数据流 
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();

            // 对加密数据进行base64编码
            return Convert.ToBase64String(mStream.ToArray());
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥</param>
        /// <returns>解密成功返回解密后的字符串,失败返源串</returns>
        public static string DecodeECB(string decryptString, string decryptKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();

            var keyIv = HexStringToByteArray2(decryptKey);

            byte[] inputByteArray = Convert.FromBase64String(decryptString);
            DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
            DCSP.Mode = CipherMode.ECB;
            DCSP.Padding = PaddingMode.PKCS7;

            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(keyIv, keyIv), CryptoStreamMode.Write);
            cStream.Write(inputByteArray, 0, inputByteArray.Length);
            cStream.FlushFinalBlock();
            return Encoding.UTF8.GetString(mStream.ToArray());

        }
    }
}
