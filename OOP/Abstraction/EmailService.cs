﻿namespace OOP.Abstraction;
public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authenticate();
        Console.WriteLine("Sending email...");
        Disconnect();
    }

    private void Connect() => Console.WriteLine("Connecting to email server...");
    private void Authenticate() => Console.WriteLine("Authenticating...");
    private void Disconnect() => Console.WriteLine("Disconnecting from email server...");
}

public static class EmailServiceExample
{
    public static void Main()
    {
        try
        {
            var emailService = new EmailService();
            emailService.SendEmail();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program completed.");
        }
    }
}