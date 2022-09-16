int calculationOfTheNumberOfValues()
{
dataValidation: Console.Write("Сколько значений вы будете вводить?: ");
    string theNumberOfValuesString = string.Empty;
    int theNumberOfValues = 0;
    theNumberOfValuesString = Console.ReadLine()!;

    if (int.TryParse(theNumberOfValuesString, out int result) && result > 0)
    {
        theNumberOfValues = result;
    }
    else
    {
        goto dataValidation;
    }
    return theNumberOfValues;

}

string[] creationOfAnArray(int length)
{
    string introducedValue = string.Empty;
    string[] arrayWithAllElements = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите " + (i + 1) + " значение: ");
        introducedValue = Console.ReadLine()!;
        arrayWithAllElements[i] = introducedValue;
    }
    return arrayWithAllElements;
}
int calculatingTheNumberOfElementsWithALengthLessOrEqualToThree(string[] arrayWithAllElements)
{
    int numElementsNewArray = 0;
    string elementArray = string.Empty;
    for (int i = 0; i < arrayWithAllElements.Length; i++)
    {
        elementArray = arrayWithAllElements[i];
        if (elementArray.Length <= 3) numElementsNewArray++;
        else continue;
    }
    return numElementsNewArray;

}

string[] filterAndTheCreationOfAMassifWithALengthOfLinesSmallerOrEqualToThree(string[] arrayWithAllElements, int numElementsNewArray)
{
    string[] arrayWithElementsLessThanThreeCharacters = new string[numElementsNewArray];
    string elementArray = string.Empty;
    for (int i = 0, j = 0; i < arrayWithAllElements.Length; i++)
    {
        elementArray = arrayWithAllElements[i];
        if (elementArray.Length <= 3)
        {
            arrayWithElementsLessThanThreeCharacters[j] = elementArray;
            j++;
        }

        else continue;
    }
    return arrayWithElementsLessThanThreeCharacters;
}
void printArray(string[] arrayWithElementsLessThanThreeCharacters)
{
    string result = "Полученный массив [";
    for (int i = 0; i < arrayWithElementsLessThanThreeCharacters.Length; i++)
    {
        if (i < arrayWithElementsLessThanThreeCharacters.Length - 1)
        {
            result += arrayWithElementsLessThanThreeCharacters[i] + ", ";
        }
        else if (i == arrayWithElementsLessThanThreeCharacters.Length - 1)
        {
            result += arrayWithElementsLessThanThreeCharacters[i];

        }
    }
    result += "]";
    Console.WriteLine(result);
}
string[] arrayWithAllElements = creationOfAnArray(calculationOfTheNumberOfValues());
string[] arrayWithElementsLessThanThreeCharacters =
    filterAndTheCreationOfAMassifWithALengthOfLinesSmallerOrEqualToThree(arrayWithAllElements,
    calculatingTheNumberOfElementsWithALengthLessOrEqualToThree(arrayWithAllElements));
printArray(arrayWithElementsLessThanThreeCharacters);

