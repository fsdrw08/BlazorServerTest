using System;
using System.Collections.Generic;

namespace BlazorServer.Data
{
    public class UnlockRespond
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Root    {
            public int job { get; set; } 
            public IgnoredFields ignored_fields { get; set; } 
            public int id { get; set; } 
            public string type { get; set; } 
            public string url { get; set; } 
            public Related related { get; set; } 
            public SummaryFields summary_fields { get; set; } 
            public DateTime created { get; set; } 
            public DateTime modified { get; set; } 
            public string name { get; set; } 
            public string description { get; set; } 
            public string job_type { get; set; } 
            public int inventory { get; set; } 
            public int project { get; set; } 
            public string playbook { get; set; } 
            public string scm_branch { get; set; } 
            public int forks { get; set; } 
            public string limit { get; set; } 
            public int verbosity { get; set; } 
            public string extra_vars { get; set; } 
            public string job_tags { get; set; } 
            public bool force_handlers { get; set; } 
            public string skip_tags { get; set; } 
            public string start_at_task { get; set; } 
            public int timeout { get; set; } 
            public bool use_fact_cache { get; set; } 
            public int unified_job_template { get; set; } 
            public string launch_type { get; set; } 
            public string status { get; set; } 
            public bool failed { get; set; } 
            public object started { get; set; } 
            public object finished { get; set; } 
            public object canceled_on { get; set; } 
            public double elapsed { get; set; } 
            public string job_args { get; set; } 
            public string job_cwd { get; set; } 
            public JobEnv job_env { get; set; } 
            public string job_explanation { get; set; } 
            public string execution_node { get; set; } 
            public string controller_node { get; set; } 
            public string result_traceback { get; set; } 
            public bool event_processing_finished { get; set; } 
            public int job_template { get; set; } 
            public List<object> passwords_needed_to_start { get; set; } 
            public bool allow_simultaneous { get; set; } 
            public Artifacts artifacts { get; set; } 
            public string scm_revision { get; set; } 
            public object instance_group { get; set; } 
            public bool diff_mode { get; set; } 
            public int job_slice_number { get; set; } 
            public int job_slice_count { get; set; } 
            public string webhook_service { get; set; } 
            public object webhook_credential { get; set; } 
            public string webhook_guid { get; set; } 
        }

        public class IgnoredFields    {
        }

        public class Related    {
            public string created_by { get; set; } 
            public string modified_by { get; set; } 
            public string labels { get; set; } 
            public string inventory { get; set; } 
            public string project { get; set; } 
            public string extra_credentials { get; set; } 
            public string credentials { get; set; } 
            public string unified_job_template { get; set; } 
            public string stdout { get; set; } 
            public string job_events { get; set; } 
            public string job_host_summaries { get; set; } 
            public string activity_stream { get; set; } 
            public string notifications { get; set; } 
            public string create_schedule { get; set; } 
            public string job_template { get; set; } 
            public string cancel { get; set; } 
            public string relaunch { get; set; } 
        }

        public class Inventory    {
            public int id { get; set; } 
            public string name { get; set; } 
            public string description { get; set; } 
            public bool has_active_failures { get; set; } 
            public int total_hosts { get; set; } 
            public int hosts_with_active_failures { get; set; } 
            public int total_groups { get; set; } 
            public bool has_inventory_sources { get; set; } 
            public int total_inventory_sources { get; set; } 
            public int inventory_sources_with_failures { get; set; } 
            public int organization_id { get; set; } 
            public string kind { get; set; } 
        }

        public class Project    {
            public int id { get; set; } 
            public string name { get; set; } 
            public string description { get; set; } 
            public string status { get; set; } 
            public string scm_type { get; set; } 
        }

        public class JobTemplate    {
            public int id { get; set; } 
            public string name { get; set; } 
            public string description { get; set; } 
        }

        public class UnifiedJobTemplate    {
            public int id { get; set; } 
            public string name { get; set; } 
            public string description { get; set; } 
            public string unified_job_type { get; set; } 
        }

        public class CreatedBy    {
            public int id { get; set; } 
            public string username { get; set; } 
            public string first_name { get; set; } 
            public string last_name { get; set; } 
        }

        public class ModifiedBy    {
            public int id { get; set; } 
            public string username { get; set; } 
            public string first_name { get; set; } 
            public string last_name { get; set; } 
        }

        public class UserCapabilities    {
            public bool delete { get; set; } 
            public bool start { get; set; } 
        }

        public class Labels    {
            public int count { get; set; } 
            public List<object> results { get; set; } 
        }

        public class Credential    {
            public int id { get; set; } 
            public string name { get; set; } 
            public string description { get; set; } 
            public string kind { get; set; } 
            public bool cloud { get; set; } 
        }

        public class SummaryFields    {
            public Inventory inventory { get; set; } 
            public Project project { get; set; } 
            public JobTemplate job_template { get; set; } 
            public UnifiedJobTemplate unified_job_template { get; set; } 
            public CreatedBy created_by { get; set; } 
            public ModifiedBy modified_by { get; set; } 
            public UserCapabilities user_capabilities { get; set; } 
            public Labels labels { get; set; } 
            public List<object> extra_credentials { get; set; } 
            public List<Credential> credentials { get; set; } 
        }

        public class JobEnv    {
        }

        public class Artifacts    {
        }




    }
}