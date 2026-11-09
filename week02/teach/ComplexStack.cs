public static class ComplexStack {
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            // agregar al stack si el caracter es uno de eesos tres valores
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            // we ask if item is end of ) 
            else if (item is ')') {
                // if stack contains value, true, if stack .pop is different from ( true,  
                // false if stack is empty, false is stack.pop == ( 
                if (stack.Count == 0 || stack.Pop() != '(')
                    // and return false
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

// if program has (