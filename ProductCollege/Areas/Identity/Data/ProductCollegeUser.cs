using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProductCollege.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ProductCollegeUser class
public class ProductCollegeUser : IdentityUser
{
    public String FirstName {  get; set; }  
    public String LastName { get; set; }
    public string MobileNo {  get; set; }   

}

