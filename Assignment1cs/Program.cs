using Assignment1cs;

var bisection = new Bisection();
var falsePosition = new FalsePositionsMethod();
var secant = new Secant();
var iteration = new Iteration();

TestCaseRunner.Run(iteration);

//TaskC();
void TaskC()
{
    var func = (double x) => Math.Pow(x, 10) - 1;
    Console.WriteLine("Bisection. a=1.1, b=0. Root: " + bisection.Run(1.1, 0, func));
    Console.WriteLine("False position. a=1.1, b=0. Root: " + falsePosition.Run(1.1, 0, func));
}
