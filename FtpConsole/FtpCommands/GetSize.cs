using System;
using FtpLibrary;

namespace FtpConsole.FtpCommands
{
    public sealed class GetSize : IFtpCommand
    {
        public void Execute(string ftpUri, string path = null, string username = null, string password = null)
        {
            Console.WriteLine("Getting size...");
            try
            {
                using (var ftp = new FileTransferProtocol(ftpUri, path, username, password))
                {
                    ftp.GetSize();
                    Console.Write(ftp.RequestStatus);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{ftpUri} get size error -> {exception.Message}");
            }  
        }
    }
}