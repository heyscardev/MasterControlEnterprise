﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Notification
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Message { get; set; }
        [MaxLength(150)]
        public string SolutionMessage { get; set; }
        public NotificationType NotificationType { get; set; }
        public NotificationState NotificationState { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        // relations
        public virtual ICollection<NotificationUser> Sales { get; private set; } = new ObservableCollection<NotificationUser>();
    }
    public enum NotificationType
    {
        GERENTIAL,
        SELLER,
        ADMIN,
        GLOBAL
    }
    public enum NotificationState
    {
        SOLVENT,
        PENDING,
    }
}
