using System;

namespace WebApiSample.Models;

public class Project
{
    public int ProjectId {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Decription {get; set;} = string.Empty;
    public DateTime CreateDate {get; set;}
    public ProjectStatus Status {get; set;}
    public DateTime? StartDate {get; set;}
    public DateTime? EndDate {get; set;}
}
