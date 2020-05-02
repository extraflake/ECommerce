using ECommerce.Models;
using ECommerce.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services.Data
{
    public class NotificationService : GeneralService<Notification, NotificationRepository>
    {
        public NotificationService(NotificationRepository notificationRepository) : base(notificationRepository)
        {

        }
    }
}
