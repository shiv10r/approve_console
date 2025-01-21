using System;

namespace approve_console
{
    public class ApiResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public bool IsChecked { get; set; }

        // New columns
        public DateTime RequestDate { get; set; }
        public string RequestFor { get; set; } = string.Empty;
        public string RequestType { get; set; } = string.Empty;
        public string AccessType { get; set; } = string.Empty;
        public long RequestId { get; set; }
        public long BulkRequestId { get; set; }
        public string RequestStatus { get; set; } = string.Empty;
        public string AccType { get; set; } = string.Empty;
        public string ApplicationName { get; set; } = string.Empty;
        public string Env { get; set; } = "dev";
        public long Role { get; set; }
        public string Group { get; set; } = string.Empty;
    }
}
