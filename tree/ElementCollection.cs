using System;

public class BinarySearchTree
{
    private Element _firstElement;

    public void AddElement(int value)
    {
        if (_firstElement == null)
        {
            var newElement = new Element
            {
                Value = value,
                Counter = 1,
                Right = null,
                Left = null
            };
            _firstElement = newElement;
        }
        else
        {
            var current = _firstElement;
            AddElement( value, current);
        }
    }

    public void AddElement(int value, Element current)
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
                return;
            }
            else
            {
                current = current.Right;
                AddElement(value, current);
            }

        }
        else if (value < current.Value)
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
                return;
            }
            else
            {
                current = current.Left;
                AddElement(value, current);
            }
        }
        else
        {
            current.Counter++;
            return;
        }
    }



    public bool Check(int value, out int counter)
    {
        counter = 0;
        var current = _firstElement;

        return Check(value, out counter, current);
    }

    public bool Check(int value, out int counter, Element current)
    {
        counter = 0;

        if (value > current.Value)
        {
            if (current.Right == null)
            {               
                return false;
            }
            else
            {
                current = current.Right;
                return Check(value, out counter, current);
            }

        }
        else if (value < current.Value)
        {
            if (current.Left == null)
            {
                return false;
            }
            else
            {
                current = current.Left;
                return Check(value, out counter, current);
            }
        }
        else
        {
            counter = current.Counter;
            return true;
        }
    }
}
