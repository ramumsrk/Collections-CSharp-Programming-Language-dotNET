System.Collections.Generic.List<int> _listOfNumbers = [
  1,
  2,
  3,
];

foreach (System.Int32 _number in _listOfNumbers)
{
  System.Console.WriteLine(
    $"{Environment.NewLine}Number is: {_number}"
  );
}

System.Collections.Generic.Dictionary<int,string> _serialNumberToSubjects = new System.Collections.Generic.Dictionary<int,string>() {
  {1, "EEE"},
  {2, "CSE"},
  {3, "ICT"},
  {4, "ECE"},
};

foreach (var _serialNumberToSubject in _serialNumberToSubjects)
{
  System.Console.WriteLine(
    $"{Environment.NewLine}Key: {_serialNumberToSubject.Key} and Value: {_serialNumberToSubject.Value}"
  );
}

System.Collections.Generic.HashSet<int> _hashSetOfNumbers = [
  1,
  2,
  3,
  3,
];
foreach (var _number in _hashSetOfNumbers)
{
  System.Console.WriteLine(
    $"{Environment.NewLine}Number: {_number}"
  );
}

System.Collections.Generic.Queue<string> _stringsQueue = new System.Collections.Generic.Queue<string>();

_stringsQueue.Enqueue("first");
_stringsQueue.Enqueue("second");
_stringsQueue.Enqueue("third");

while (_stringsQueue.Count > 0)
{
  System.Console.WriteLine(
    $"{Environment.NewLine}Element: '{_stringsQueue.Dequeue()}'"
  );
}

System.Collections.Generic.Stack<string> _stringsStack = new System.Collections.Generic.Stack<string>();

_stringsStack.Push("First");
_stringsStack.Push("Second");
_stringsStack.Push("Third");

while (_stringsStack.Count > 0)
{
  System.Console.WriteLine(
    $"{Environment.NewLine}Element: {_stringsStack.Pop()}"
  );
}