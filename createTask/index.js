module.exports = function (context, req) {
  context.log('JavaScript HTTP trigger function processed a request.');

  var task = {
    user: req.body.user,
    task: req.body.task,
    time: req.body.time,
    tags: req.body.tags,
  }
  context.log('req' + JSON.stringify(req))
  context.log('req.body:' + JSON.stringify(req.body))
  context.log('created task:' + JSON.stringify(task))

  context.bindings.outputTask = task
  context.res = {
    status: 200,
    body: "created task " + JSON.stringify(task),
  };
  context.done();
};
