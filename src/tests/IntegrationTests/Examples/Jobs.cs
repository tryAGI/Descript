/*
order: 20
title: Jobs
slug: jobs

List and retrieve job statuses for import and agent edit operations.
*/

namespace Descript.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task ListJobs()
    {
        using var client = GetAuthenticatedClient();

        //// List recent jobs across your Descript account.
        //// By default, jobs created within the last 7 days are returned.
        //// Supports pagination via cursor and filtering by project or job type.
        var response = await client.ApiEndpoints.ListJobsAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();
        response.Pagination.Should().NotBeNull();

        Console.WriteLine($"Jobs found: {response.Data.Count}");

        foreach (var job in response.Data)
        {
            Console.WriteLine($"  Job type: {job.JobType}");
        }
    }

    [TestMethod]
    public async Task ListJobsByType()
    {
        using var client = GetAuthenticatedClient();

        //// Filter jobs by type to see only import or agent edit operations.
        //// This is useful when you want to track the status of a specific
        //// category of async operations.
        var response = await client.ApiEndpoints.ListJobsAsync(
            type: ListJobsType.Agent,
            limit: 5);

        response.Should().NotBeNull();
        response.Data.Should().NotBeNull();

        Console.WriteLine($"Agent jobs found: {response.Data.Count}");
    }
}
