using System;
using System.ComponentModel.DataAnnotations;

public class BaseData
{
    //data info
    [MaxLength(2)]
    public DateTime CreatedAt { get; set; }
    [MaxLength(2)]
    public DateTime UpdateAt { get; set; }
    [MaxLength(2)]
    public DateTime? DeleteAt { get; set; }
    public bool? DeleteState { get; set; }
}