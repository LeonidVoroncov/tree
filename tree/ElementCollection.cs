using System;

public class ElementCollection
{
    private Element _first;
    public int Count { get; private set; }

    public ElementCollection()
    {
        _first = new Element
        {
            Value = 0,
            Counter = 1,
            Left = null,
            Right = null          
        };
        Count = 0;
    }

    public void AddElement(int value)
    {
        if (Count == 0)
        {
            _first.Value = value;
            Count++;
        }
        else
        {
            var current = _first;
            var score = true;

            while (score)
            {
                if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        var newElement = new Element
                        {
                            Value = value,
                            Counter = 1,
                            Right = null,
                            Left = null
                        };
                        current.Right = newElement;
                        score = false;
                    }
                    else
                    {
                        current = current.Right;
                    }

                }
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        var newElement = new Element
                        {
                            Value = value,
                            Counter = 1,
                            Right = null,
                            Left = null
                        };
                        current.Left = newElement;
                        score = false;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                if (value == current.Value)
                {
                    current.Counter++;
                    score = false;
                }
            }
        }        
    }

    public void Get(out int Counter, int value, out bool checkElement)
    {
        var current = _first;
        var score = true;
        Counter = 1;
        checkElement = false;

        while (score)
        {
            if (value > current.Value)
            {
                if (current.Right == null)
                {
                    score = false;
                }
                else
                {
                    current = current.Right;
                }

            }
            if (value < current.Value)
            {
                if (current.Left == null)
                {
                    score = false;
                }
                else
                {
                    current = current.Left;
                }
            }
            if (value == current.Value)
            {
                Counter = current.Counter;
                checkElement = true;
                score = false;
            }
        }
    }
}
