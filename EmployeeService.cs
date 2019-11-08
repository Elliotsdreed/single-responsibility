using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Threading.Tasks;


namespace single_responsidsoudyg
{
    public class EmployeeService
    {  
       public async Task EmployeeRegistration(Employee employee)  
        {  
            StaticData.Employees.Add(employee);  
            EmailService emailService = new EmailService();  
            await emailService.SendEmailAsync(employee.Email, "Registration", "Congratulation ! Your are successfully registered.");  
        }         
        
    }  
}  
