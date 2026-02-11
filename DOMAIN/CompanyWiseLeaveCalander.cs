using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
    public class CompanyWiseLeaveCalander
    {
    public int Id {get;set;}	 
	 public int CompanyId {get;set;}	
	 public int FinancialYear {get;set;}	
	 public int LeaveTypeId {get;set;}	
	 public int LeaveUnitId {get;set;}	
	 public DateTime Date {get;set;}	
	 public string Remark {get;set;}	
	 public int IsActive {get;set;}
     public int UserId { get; set; }	
    }
}
