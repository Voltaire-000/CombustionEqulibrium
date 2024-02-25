using Newtonsoft.Json.Linq;

//string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "shortThermo.json");
string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "thermoINPjson.json");

string json = File.ReadAllText(path);
JObject jObj = JObject.Parse(json);

// define filter parameter as a lambda expression
//Func<JToken, bool> filter = r => (string)r["reactant"] == "ALC";
//Func<JToken, bool> filter = r => (bool)r[key: "gaseous"] == false;
//Func<JToken, bool> filter = r => (double)r[key: "molecularWeight"] <= 25.0;

// apply the filter to the JObject and get the filtered records as a JArray
JArray filtered = new JArray(jObj["thermo"].Where(filter));

Console.WriteLine(filtered);

Console.WriteLine("Hello, World!");
