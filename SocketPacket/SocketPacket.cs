using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Packet
{
    [Serializable]
    public class SocketPacket : ISerializable
    {
        public PacketType packetType { get; set; }
        public string SenderIP { get; set; }
        public int SenderPort { get; set; }
        public string ReceiverIP { get; set; }
        public int ReceiverPort { get; set; }
        public string Message { get; set; }
        public Bitmap image { get; set; }
        
        public SocketPacket()
        {
            packetType = PacketType.NONE;
            SenderIP = "";
            ReceiverIP = "";
            SenderPort = 0;
            ReceiverPort = 0;
            Message = "";
            image = new Bitmap(1, 1);
        }
        /// <summary>
        /// Initialize a message packet
        /// </summary>
        /// <param name="Type">Type of packet</param>
        /// <param name="sip">Sender IP</param>
        /// <param name="rip">Receiver Port</param>
        /// <param name="sport">Sender Port</param>
        /// <param name="rport">Receiver Port</param>
        /// <param name="message">Message</param>
        public SocketPacket(PacketType Type, string sip, string rip, int sport, int rport, string message)
        {
            packetType = Type;
            SenderIP = sip;
            ReceiverIP = rip;
            SenderPort = sport;
            ReceiverPort = rport;
            Message = message;
        }
        /// <summary>
        /// Initialize a packet
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="sip"></param>
        /// <param name="rip"></param>
        /// <param name="sport"></param>
        /// <param name="rport"></param>
        public SocketPacket(PacketType Type, string sip, string rip, int sport, int rport)
        {
            packetType = Type;
            SenderIP = sip;
            ReceiverIP = rip;
            SenderPort = sport;
            ReceiverPort = rport;
        }
        /// <summary>
        /// Initialize a image packet
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="sip"></param>
        /// <param name="rip"></param>
        /// <param name="sport"></param>
        /// <param name="rport"></param>
        /// <param name="bitmap"></param>
        public SocketPacket(PacketType Type, string sip, string rip, int sport, int rport, Bitmap bitmap)
        {
            packetType = Type;
            SenderIP = sip;
            ReceiverIP = rip;
            SenderPort = sport;
            ReceiverPort = rport;
            image = bitmap;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("PacketType", packetType, typeof(PacketType));
            switch(packetType)
            {
                case PacketType.MESSAGE:case PacketType.REQCON:
                case PacketType.REQFRIEND:
                    info.AddValue("Msg", Message, typeof(string));
                    break;
                case PacketType.IMG:
                    info.AddValue("Image", image, typeof(Bitmap));
                    break;
                default: break;
            }

            info.AddValue("SenderIP", SenderIP, typeof(string));
            info.AddValue("ReceiverIP", ReceiverIP, typeof(string));
            info.AddValue("SenderPort", SenderPort, typeof(int));
            info.AddValue("ReceiverPort", ReceiverPort, typeof(int));
        }
        public SocketPacket(SerializationInfo info, StreamingContext context)
        {
            packetType = (PacketType)info.GetValue("PacketType", typeof(PacketType));
            SenderIP = (string)info.GetValue("SenderIP", typeof(string));
            ReceiverIP = (string)info.GetValue("ReceiverIP", typeof(string));
            SenderPort = (int)info.GetValue("SenderPort", typeof(int));
            ReceiverPort = (int)info.GetValue("ReceiverPort", typeof(int));
            switch (packetType)
            {
                case PacketType.MESSAGE: case PacketType.REQCON:
                case PacketType.REQFRIEND:
                    Message = (string)info.GetValue("Msg", typeof(string));
                    break;
                case PacketType.IMG:
                    image = (Bitmap)info.GetValue("Image", typeof(Bitmap));
                    break;
                default: break;
            }
        }
        public static byte[] SerializedItem(SocketPacket packet)
        {
            MemoryStream str = new MemoryStream();
            BinaryFormatter bformat = new BinaryFormatter();
            bformat.Serialize(str, packet);
            byte[] data = new byte[str.Length];
            data = str.ToArray();
            return data;
        }
        public static SocketPacket DeSerializedItem(byte[] data)
        {
            SocketPacket packet = new SocketPacket();
            MemoryStream str = new MemoryStream(data);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            packet = (SocketPacket)binaryFormatter.Deserialize(str);
            return packet;
        }
        public override string ToString()
        {
            string st = "From IP :" + SenderIP + " To IP:" + ReceiverIP;
            return st;
        }
    }
    public enum PacketType
    {
        REQCON,
        REQFRIEND,
        MESSAGE,
        IMG,
        DISCON,
        NONE
    }
}
