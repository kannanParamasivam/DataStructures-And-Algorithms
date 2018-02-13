# ds_and_algorithms_safaribooks
## Table of Content
# | Topic
| --- | --- |
| 1 | [LinkedList](#difference-between-linkedlist-and-array)
| 2 | [Stack](#stack)
| 3 | [Queue](#queue)
| 4 | [Selection Sort](#selection-sort)
| 5 | [Bubble Sort](#bubble-sort)
| 6 | [Insertion Sort](#insertion-sort)
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
[Back to Top](#table-of-content) 
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

[Back to Top](#table-of-content)
## Queue
>Queue is **First In First Out** (FIFO) data structure
* Elements **added at the end** of the queue
* Elements **removed from beginning** of the queue
### Actions on Queue
| Action | Description | Complexity |
| --- | --- | --- |
| **ENQUEUE** | Adding new element to he end of the queue | O(1)
| **DEQUEUE** | Removing an element from the begining of the queue | O(1)
| **PEEK** | See element at the head of the queue | O(1)
| **OFFER** | **ENQUEUE** an element if space available | O(1)
* Enqueueing to the the full queue and dequeueing from empty queue throws exception
* **Underlying datastructure** for Queue implementation is **Circular Queue** (Circualar Array)
* HEAD = -1 in an empty queue
* Space complexity is O(N)
### Application of Queues
* **Hotline** customer care service
* Queueing jobs in **prtinter**
* Transaction system in bank
* Inventory management
<br>[Back to Top](#table-of-content)
## Selection Sort
> Every element typically compared to every other
* Time complexity is **O(N^2)**
* Space complexity is ) **O(1)** (No extra space for sorting which is known as **In-Place sorting**)
* **Not stable sort** as the equal elements might be rearranged
* This is typically not used anywhere as it is worst way of sorting
* Advantage is it **does not use extra space** and **simple to use**
* Already **Sorted list** also will take O(N)
<br>[Back to Top](#table-of-content)
## Bubble Sort
>It allows smallest element to bubble up to begining of the collection
* Time complexity is O(N^2)
### Pros
* Can break out from looping when there is no swap happened
* If list is **already sorted** it wont be processed
* **Stable sort** (equal elements order wont be changed)
* **In-Place** sorting
* O(N^2) comparitions and O(N^2) sortings
### Cons
* Number of swaps are higher than selection sort
<br>[Back to Top](#table-of-content)
## Insertion Sort
>Create new sublist with 1 element which is sorted and add elements and keep it sorted
* Time complexity is **O(N^2)**
* Space complexity is **O(1)**
* N^2 Comparitions and N^2 Swaps
### pros
* Inplace sort
* Stable sort
* Adaptive (When the elements are partially sorted it will adopt it)
* When comparition with last element is ok, break the inner iteration
* Fewer comparitions than Bubble sort
<br>[Back to Top](#table-of-content)
## Questions
* **```yield```** keywor in C#

