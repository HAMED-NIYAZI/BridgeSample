// See https://aka.ms/new-console-template for more information
using BridgeSample.MailService;

 
RefinedMailService mailService = new RefinedMailService();
mailService.Send(new EmailInforMationDto {
Message="message",
Reciver="reciver",
Title = "title"
});

Console.ReadKey();
 


