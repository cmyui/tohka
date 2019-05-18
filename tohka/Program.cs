using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static System.Text.Encoding;
using System.Runtime.Serialization;
using tohka.osu;
using tohka.Enums;
//using MiscUtil.Conversion;

namespace tohka
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener Server = null;
            try
            {
                Console.WriteLine("Tohka started");

                // Define IP Address and Port to be used to start the listener
                IPAddress IP_Addr = IPAddress.Parse("127.0.0.1");
                int Port = 980;

                Console.WriteLine("Network: " + IP_Addr + ":" + Port);

                // Define the Server
                Server = new TcpListener(IP_Addr, Port);

                // Start listening for client requests.
                Server.Start();

                // Buffer for reading data
                byte[] bytes = new byte[256];
                string data = null;

                // Enter the listening loop.
                while (true)
                {
                    Console.WriteLine("Tohka is ready for connections.");

                    // Perform a blocking call to accept requests.
                    // You could also user server.AcceptSocket() here.
                    TcpClient Client = Server.AcceptTcpClient();
                    //Console.WriteLine("Connected!");

                    data = null;

                    // Get a stream object for reading and writing
                    NetworkStream Stream = Client.GetStream();

                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = Stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data += System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    }

                    // Process the data sent by the client.

                    // If token is not set, process as a login
                    if (!data.Contains("osu-token")) {
                        Console.WriteLine("Packet contains no osu-token; treating this as a login request.");
                        byte[] output = HandlePacket(0, data);
                        Stream.Write(output, 0, output.Length);
                    }

                    //Byte[] ResponseData = BuildPacket()

                    // Send back a response.
                    //Stream.Write(asd, 0, msg.Length);
                    Console.WriteLine("\n\n\nSent: {0}\n\n\n", "no");

                    // Shutdown and end connection
                    Client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                Console.WriteLine("Shutting down Tohka..");
                Server.Stop();
            }
        }

        public static byte[] HandlePacket(int Handler, string data)
        {
            bool debug = false;
            switch (Handler)
            {
                case 0: // Login
                    byte[] ResponseData;
                    string ResponseTokenString = "No";
                    string[] LoginData  = data.Split("\n");
                    if (debug)
                    {
                        Console.WriteLine("\n\nSTART osuData");
                        for (int i = 0; i < LoginData.Length - 1; i++)
                        {
                            Console.WriteLine(i + " " + LoginData[i]);
                        }
                        Console.WriteLine("END osuData\n\n");
                    }

                    // TODO: List.Add(LoginData[i]); instead of string[11] shit
                    string[] Headers    = new string[11];
                    for (int i = 0; i < Headers.Length; i++)
                    {
                        Headers[i] = LoginData[i];
                    }

                    string[] osuData    = LoginData[13].Split("|");

                    string osuVersion = osuData[0];
                    // TODO: TryParse or im fucked if someone abuses
                    int TimeOffset = Int32.Parse(osuData[1]);
                    string[] ClientData = osuData[3].Split(":");
                    if (ClientData.Length < 4)
                    {
                        // TODO: force update client
                    }

                    string Username     = LoginData[11];
                    string Password     = LoginData[12];

                    // TODO: userID
                    
                    // TODO: properly handle and create token rather than just spaghetti
                    ResponseTokenString = Guid.NewGuid().ToString();

                    byte[] outAttempt = BuildPacket((short)PacketIDs.Server_LoginResponse, new byte[] { 1 });
                    return outAttempt;
                default:
                    return new byte[] { (byte)0 };
            }
            return new byte[] { (byte)'n' };
        }

        public static byte[] BuildPacket(short PacketID, byte[] _PacketData)
        {
            if (_PacketData == null)
            {
                // TODO: FUCK
            }

            byte[] PacketData = new byte[3];
            byte[] PacketBytes = new byte[] {};

            using (MemoryStream stream = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(PacketID);
                    writer.Write(false);
                    writer.Write(-1.ToString().Length);
                    writer.Write(-1);
                }
                stream.Flush();
                byte[] bytes = stream.GetBuffer();
                return bytes;
            }
        }
    }
}