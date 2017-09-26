module.exports = function (context, req) {
  context.log('JavaScript HTTP trigger function processed a request.');

  var task = {
    user: req.body.user,
    task: req.body.task,
    time: req.body.time,
    tag: req.body.tag,
  }
  console.log('created task:' + JSON.strigify(task)))

  context.outputTask = task
  context.res = {
    status: 200,
    body: "created task " + JSON.strigify(task),
  };
  context.done();
};
