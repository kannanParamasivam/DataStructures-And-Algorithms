# ds_and_algorithms_safaribooks

## Difference between LinkedList and Array
Linked List | Array
--- | --- |
Size is dynamic | Size is fixed
Insertion / Deletion is optimal and matter of **changing ref pointers** | Insertion / Deletion involve copying and moving rest of the element which is **tedious**
**Accessing** random element costs **O(N)** | If you know index of the element it is **O(1)**
**Additional space** needed for next pointer | **No additional space** is needed
Not suitable for data caching | **Suitable for data caching** because need lesser space and O(1) accessing
Suitable for data **frequently insert/delete (modified)** and **unknow size** | Suitable for read operations to be quick
No Spatial locality | **Spatial locality**  
## Stack
>It is **Last In First Out** (LIFO) datastructure.
* Always actions performed one end of the statck which is **top**
* All the elements below top would be hidden away
* **POP/PEEK in empty** (StackUnderFlow Exception) stack and **PUSH in full** (StackOverFlow Exception)) stack is **ERROR**, need to throw exception
* Perfect fit for **underlying data structure** of stack is **LinkedList** as it is less complex to remove and add head element
* **Space complexity** of stack is **O(N)** as space occupied grows proportionally to the number of elements. 
### Operations in Stack
Action | Description | Complexity
| --- | --- | --- |
**PUSH** | Adding new element to the top | O(1) 
**POP** | Referencing and Removing element from top | O(1)
**PEEK** | Just referencing the top element without removing | O(1)
**ISEMPTY** | Check whether any element present in the stack | O(1)
**ISFULL** | Check whether a stack is full | O(1)
**SIZE** | Gets size of the stack | O(1)
### Real world applications
* **Undo** operations in applications
* **Back Button** in web browser
* Holding the memory for **Recursive Calls**
* **Infix and Postfix expressions** in programming languages
## Questions
* **```yield```** keywor in C#

