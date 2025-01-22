using System;
using System.Collections.Generic;

namespace approve_console
{
    internal class ApiService
    {
        public void FetchAndDisplayData()
        {
            try
            {
                // Hardcoded data with 15 dummy records
                var apiResponses = new List<ApiResponse>
                {
                    new ApiResponse { Id = 1, Name = "Request 1", Status = "Approved", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User1", RequestType = "TypeA", AccessType = "Read", RequestId = 1001, BulkRequestId = 2001, RequestStatus = "Pending", AccType = "Admin", ApplicationName = "App1", Env = "dev", Role = 1, Group = "Group1" },
                    new ApiResponse { Id = 2, Name = "Request 2", Status = "Rejected", Timestamp = DateTime.UtcNow, IsChecked = true, RequestDate = DateTime.UtcNow.Date, RequestFor = "User2", RequestType = "TypeB", AccessType = "Write", RequestId = 1002, BulkRequestId = 2002, RequestStatus = "Completed", AccType = "User", ApplicationName = "App2", Env = "prod", Role = 2, Group = "Group2" },
                    new ApiResponse { Id = 3, Name = "Request 3", Status = "Pending", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User3", RequestType = "TypeC", AccessType = "Read", RequestId = 1003, BulkRequestId = 2003, RequestStatus = "In Progress", AccType = "Guest", ApplicationName = "App3", Env = "test", Role = 3, Group = "Group3" },
                    new ApiResponse { Id = 4, Name = "Request 4", Status = "Approved", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User4", RequestType = "TypeD", AccessType = "Write", RequestId = 1004, BulkRequestId = 2004, RequestStatus = "Pending", AccType = "Admin", ApplicationName = "App4", Env = "dev", Role = 4, Group = "Group4" },
                    new ApiResponse { Id = 5, Name = "Request 5", Status = "Rejected", Timestamp = DateTime.UtcNow, IsChecked = true, RequestDate = DateTime.UtcNow.Date, RequestFor = "User5", RequestType = "TypeA", AccessType = "Read", RequestId = 1005, BulkRequestId = 2005, RequestStatus = "Completed", AccType = "User", ApplicationName = "App5", Env = "prod", Role = 5, Group = "Group5" },
                    new ApiResponse { Id = 6, Name = "Request 6", Status = "Approved", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User6", RequestType = "TypeB", AccessType = "Write", RequestId = 1006, BulkRequestId = 2006, RequestStatus = "Pending", AccType = "Guest", ApplicationName = "App6", Env = "test", Role = 6, Group = "Group6" },
                    new ApiResponse { Id = 7, Name = "Request 7", Status = "Pending", Timestamp = DateTime.UtcNow, IsChecked = true, RequestDate = DateTime.UtcNow.Date, RequestFor = "User7", RequestType = "TypeC", AccessType = "Read", RequestId = 1007, BulkRequestId = 2007, RequestStatus = "In Progress", AccType = "Admin", ApplicationName = "App7", Env = "dev", Role = 7, Group = "Group7" },
                    new ApiResponse { Id = 8, Name = "Request 8", Status = "Rejected", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User8", RequestType = "TypeD", AccessType = "Write", RequestId = 1008, BulkRequestId = 2008, RequestStatus = "Completed", AccType = "User", ApplicationName = "App8", Env = "prod", Role = 8, Group = "Group8" },
                    new ApiResponse { Id = 9, Name = "Request 9", Status = "Approved", Timestamp = DateTime.UtcNow, IsChecked = true, RequestDate = DateTime.UtcNow.Date, RequestFor = "User9", RequestType = "TypeA", AccessType = "Read", RequestId = 1009, BulkRequestId = 2009, RequestStatus = "Pending", AccType = "Guest", ApplicationName = "App9", Env = "test", Role = 9, Group = "Group9" },
                    new ApiResponse { Id = 10, Name = "Request 10", Status = "Pending", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User10", RequestType = "TypeB", AccessType = "Write", RequestId = 1010, BulkRequestId = 2010, RequestStatus = "In Progress", AccType = "Admin", ApplicationName = "App10", Env = "dev", Role = 10, Group = "Group10" },
                    new ApiResponse { Id = 11, Name = "Request 11", Status = "Rejected", Timestamp = DateTime.UtcNow, IsChecked = true, RequestDate = DateTime.UtcNow.Date, RequestFor = "User11", RequestType = "TypeC", AccessType = "Read", RequestId = 1011, BulkRequestId = 2011, RequestStatus = "Completed", AccType = "User", ApplicationName = "App11", Env = "prod", Role = 11, Group = "Group11" },
                    new ApiResponse { Id = 12, Name = "Request 12", Status = "Approved", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User12", RequestType = "TypeD", AccessType = "Write", RequestId = 1012, BulkRequestId = 2012, RequestStatus = "Pending", AccType = "Guest", ApplicationName = "App12", Env = "test", Role = 12, Group = "Group12" },
                    new ApiResponse { Id = 13, Name = "Request 13", Status = "Pending", Timestamp = DateTime.UtcNow, IsChecked = true, RequestDate = DateTime.UtcNow.Date, RequestFor = "User13", RequestType = "TypeA", AccessType = "Read", RequestId = 1013, BulkRequestId = 2013, RequestStatus = "In Progress", AccType = "Admin", ApplicationName = "App13", Env = "dev", Role = 13, Group = "Group13" },
                    new ApiResponse { Id = 14, Name = "Request 14", Status = "Rejected", Timestamp = DateTime.UtcNow, IsChecked = false, RequestDate = DateTime.UtcNow.Date, RequestFor = "User14", RequestType = "TypeB", AccessType = "Write", RequestId = 1014, BulkRequestId = 2014, RequestStatus = "Completed", AccType = "User", ApplicationName = "App14", Env = "prod", Role = 14, Group = "Group14" },
                    new ApiResponse { Id = 15, Name = "Request 15", Status = "Approved", Timestamp = DateTime.UtcNow, IsChecked = true, RequestDate = DateTime.UtcNow.Date, RequestFor = "User15", RequestType = "TypeC", AccessType = "Read", RequestId = 1015, BulkRequestId = 2015, RequestStatus = "Pending", AccType = "Guest", ApplicationName = "App15", Env = "test", Role = 15, Group = "Group15" },
                };

                foreach (var item in apiResponses)
                {
                    Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Status: {item.Status}, Timestamp: {item.Timestamp}, IsChecked: {item.IsChecked}");
                    Console.WriteLine($"RequestDate: {item.RequestDate}, RequestFor: {item.RequestFor}, RequestType: {item.RequestType}, AccessType: {item.AccessType}");
                    Console.WriteLine($"RequestId: {item.RequestId}, BulkRequestId: {item.BulkRequestId}, RequestStatus: {item.RequestStatus}");
                    Console.WriteLine($"AccType: {item.AccType}, ApplicationName: {item.ApplicationName}, Env: {item.Env}");
                    Console.WriteLine($"Role: {item.Role}, Group: {item.Group}");
                    Console.WriteLine("------------------------------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
