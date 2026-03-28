/*
order: 10
title: Status
slug: status

Check the Descript API status and validate authentication.
*/

namespace Descript.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task CheckApiStatus()
    {
        using var client = GetAuthenticatedClient();

        //// Check the Descript API availability and validate your authentication token.
        //// This is a lightweight call useful for verifying connectivity and credentials.
        var status = await client.ApiEndpoints.GetStatusAsync();

        status.Should().NotBeNull();

        Console.WriteLine($"API status: {status.Status}");
    }
}
