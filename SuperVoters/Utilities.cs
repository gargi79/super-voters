using NLog;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace SuperVoters
{
    class Utilities
    {

        public static bool IsAdmin = false;


        public static void OpenHelpFile(bool isAdmin)
        {
            string filename;

            if (isAdmin)
                filename = @"Usage Instructions For SuperVoters Admin.pdf";
            else
                filename = @"Usage Instructions For SuperVoters.pdf";

            string dir = Directory.GetCurrentDirectory();
            dir = dir.Replace(@"\bin\Debug", "");
            dir = dir.Replace(@"\bin\Release", "");
            string fullPath = dir + @"\Documents\" + filename;
            LogFactory.WriteLog(LogFactory.Level.Info, "Opened help file by " + (isAdmin ? "Admin" : "User"));
            System.Diagnostics.Process.Start(fullPath);
        }

        internal static void SendEmailToAdmin(string message)
        {
            try
            {
                var mm = new MailMessage
                {
                    From = new MailAddress("superVotersWSU@gmail.com"),
                    Subject = "Message from SuperVoters Application",
                    Body = message,
                    IsBodyHtml = true,
                 };
                mm.To.Add("superVotersWSU@gmail.com");

                SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
                sc.Credentials = new NetworkCredential("superVotersWSU", "oeugcvbrzwbgthpw"); // this is an app password generated from Google
                sc.EnableSsl = true;             
                sc.Send(mm);
            }
            catch (Exception ex)
            {
                LogFactory.WriteLog(LogFactory.Level.Error, "Error Sending email: " + ex.Message);
            }
        }

        internal static void LogTime(TimeSpan ts, string message)
        {
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            LogFactory.WriteLog(LogFactory.Level.Info, message + " took " + elapsedTime + " to complete.");
        }
    }
}
    


class LogFactory
{
    private static Logger _logger = LogManager.GetCurrentClassLogger();
    public enum Level
    {
       Error,
       Info,
       Warn,
       Debug,
       Trace
    }

    public static void WriteLog(Level level, string message)
    {
        string dir = Directory.GetCurrentDirectory();
        if (dir.Contains("Temp"))  // Identify tests and set loglevel to debug
            level = Level.Debug;

        _logger.Log(GetLogLevel(level), message);
    }

    private static LogLevel GetLogLevel(Level level)
    {
        switch (level)
        {
            case Level.Error:
                return LogLevel.Error;
            case Level.Info:
                return LogLevel.Info;
            case Level.Debug:
                return LogLevel.Debug;
            case Level.Warn:
                return LogLevel.Warn;
            case Level.Trace:
                return LogLevel.Trace;
            default:
                return LogLevel.Info;
        }
    }
}

