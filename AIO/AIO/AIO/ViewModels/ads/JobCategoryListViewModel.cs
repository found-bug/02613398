using AIO.Models.Ad_Post;
using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.ads
{
    class JobCategoryListViewModel
    {
        public List<Job_Category_Model> _job_category_List = null;
        public List<salary_period_Model> salary_period_List = null;
        public List<job_position_type_Model> job_position_type_List = null;

        public JobCategoryListViewModel()
        {
            _job_category_List = new List<Job_Category_Model>()
            {
                new Job_Category_Model
                {
                    ID= 1,
                    Job_Category = "Data Entry & Back Office"
                },
                new Job_Category_Model
                {
                    ID= 2,
                    Job_Category = "Sales & Marketing"
                },
                new Job_Category_Model
                {
                    ID= 3,
                    Job_Category = "BPO & Telecaller"
                },
                new Job_Category_Model
                {
                    ID= 4,
                    Job_Category = "Driver"
                },
                new Job_Category_Model
                {
                    ID= 5,
                    Job_Category = "Office Assitant"
                },
                new Job_Category_Model
                {
                    ID= 6,
                    Job_Category = "Delivery & Collection"
                },
                new Job_Category_Model
                {
                    ID= 7,
                    Job_Category = "Teacher"
                },
                new Job_Category_Model
                {
                    ID= 8,
                    Job_Category = "Cook"
                },
                new Job_Category_Model
                {
                    ID= 9,
                    Job_Category = "Receptionist & Front Office"
                },
                new Job_Category_Model
                {
                    ID= 10,
                    Job_Category = "Operator & Technician"
                },
                new Job_Category_Model
                {
                    ID= 11,
                    Job_Category = "IT Engineer & Developer"
                },
                new Job_Category_Model
                {
                    ID= 12,
                    Job_Category = "Hotel & Ttravel Executive"
                },
                new Job_Category_Model
                {
                    ID= 13,
                    Job_Category = "Accountant"
                },
                new Job_Category_Model
                {
                    ID= 14,
                    Job_Category = "Designer"
                },
                new Job_Category_Model
                {
                    ID= 15,
                    Job_Category = "Other Jobs"
                },
            };

            salary_period_List = new List<salary_period_Model>()
            {
                new salary_period_Model
                {
                    ID= 1,
                    _salary_period_type = "Hourly"
                },
                new salary_period_Model
                {
                    ID= 2,
                    _salary_period_type = "Monthly"
                },
                new salary_period_Model
                {
                    ID= 3,
                    _salary_period_type = "Weekly"
                },
                new salary_period_Model
                {
                    ID= 4,
                    _salary_period_type = "Yearly"
                },
            };

            job_position_type_List = new List<job_position_type_Model>()
            {
                new job_position_type_Model
                {
                    ID= 1,
                    _position_type_type = "Hourly"
                },
                new job_position_type_Model
                {
                    ID= 2,
                    _position_type_type = "Monthly"
                },
                new job_position_type_Model
                {
                    ID= 3,
                    _position_type_type = "Weekly"
                },
                new job_position_type_Model
                {
                    ID= 4,
                    _position_type_type = "Yearly"
                }
            };
        }
    }
}
