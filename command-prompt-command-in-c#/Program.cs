
using System.Diagnostics;
while (true)
{

    #region Run As Administrator
    Process p = new Process();
    p.StartInfo.FileName = "cmd.exe";
    p.StartInfo.Arguments = "/k Del C:\\test\\x-ui.db";
    //p.StartInfo.UseShellExecute = false;
    //p.StartInfo.CreateNoWindow = true;
    //p.StartInfo.RedirectStandardOutput = true;
    p.StartInfo.Verb = "runas";
    p.Start();
    #endregion

    //Dowload Wget.exe and paste to C:\Windows\System32
    Process.Start("cmd.exe", "/k wget -P C:\\test http://10.10.10.10/x-ui.db");

    //ProcessStartInfo info = new ProcessStartInfo("cmd.exe");
    //info.Arguments = "/K cd C:\\test && curl -O http://12.12.12.12/x-ui.db";
    //Process.Start(info);


    System.Threading.Thread.Sleep(30000);
}
