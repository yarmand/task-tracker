using System.Net;

public static HttpResponseMessage Run(HttpRequestMessage req, out object taskDocument, TraceWriter log)
{
    string user = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "user", true) == 0)
        .Value;

    string task = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "task", true) == 0)
        .Value;

    string time = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "time", true) == 0)
        .Value;

    string tags = req.GetQueryNameValuePairs()
        .FirstOrDefault(q => string.Compare(q.Key, "tags", true) == 0)
        .Value;

    taskDocument = new {
        user = user,
        task = task,
        time = time.ToString(),
        tags = tags        
    };

    if (user != "" && task != "") {
        return req.CreateResponse(HttpStatusCode.OK);
    }
    else {
        return req.CreateResponse(HttpStatusCode.BadRequest);
    }
}