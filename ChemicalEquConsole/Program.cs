using Newtonsoft.Json.Linq;

string json = File.ReadAllText("shortThermo.json");
JObject jObj = JObject.Parse(json);

// define filter parameter as a lambda expression
Func<JToken, bool> filter = r => (string)r["reactant"] == "ALC";

// apply the filter to the JObject and get the filtered records as a JArray
JArray filtered = new JArray(jObj["shortThermo"].Where(filter));

Console.WriteLine(filtered);

Console.WriteLine("Hello, World!");
