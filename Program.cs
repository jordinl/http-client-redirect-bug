var client = new HttpClient();

string[] urls = ["https://google.com", "https://verizon.com"];

foreach (var url in urls)
{
    var response = await client.GetAsync(url);
    var status = response.StatusCode.GetHashCode();
    var responseUrl = response.RequestMessage!.RequestUri!.ToString();
    var locationHeader = response.Headers.Location;
    Console.WriteLine($"{url}: Status {status}; Response URL: {responseUrl}; Location header: {locationHeader}");
}