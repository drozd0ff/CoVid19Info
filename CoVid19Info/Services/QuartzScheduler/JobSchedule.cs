﻿using System;

namespace CoVid19Info.Services.QuartzScheduler
{
    public class JobSchedule
    {
        public Type JobType { get; set; }
        public string CronExpression { get; set; }

        public JobSchedule(Type jobType, string cronExpression)
        {
            JobType = jobType;
            CronExpression = cronExpression;
        }
    }
}
