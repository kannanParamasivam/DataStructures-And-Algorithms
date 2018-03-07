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
| 7 | [Shell Sort](#shell-sort)
| 8 | [Merge Sort](#merge-sort)
| 9 | [Quick Sort](#quick-sort)
| 10 | [Binary Search](#binary-search)
| 11 | [Binary Tree](#binary-tree)
| 12 | [Binary Search Tree](#binary-search-tree)
| 13 | [Heap](#heap)
| 14 | [Heap Sort](#heap-sort)
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
## Shell Sort
> Pick and start element and interval and apply insertion sort for those elements. Keep decrementing the increment till 1
* It is not possible to find complexity of ShellShort but it it better than Insertion Sort
<br>[Back to Top](#table-of-content)
## Merge Sort
>Divide and Conqure mechanism. If less contraint on space and high constraint on time.
* Merge sort is better than above sorts
* Time Complexity is **O(NLogN)**
* Space Complexity is **O(N)**
### Pros
* Complexity **O(NlogN)** which is less than selection, Bubble, Insertion and Shell sort
* Can not break out the sorting ealry
* **Stable Sort**
### Cons
* **Not Adaptive**
* **Not InPlace** takes O(N) extra space
<br>[Back to Top](#table-of-content)
## Quick Sort
>Divide and Conqure as MergeSort. **Prefered** sorting methodology when want sorting to be quick. Better for sorting In-Memory elements. If fewer contraint on space and high constraint on time.
* **Standard sorting methodology** in many libraries such as C and C++ standard library
* **Divide by pivot** instead of length. Elements smaller than Pivot goes to one array and larger than Pivot goes to another array
* Usually first or last element of the lilst is choosen as Pivot. It can be random.
* Time Complexity is **O(NLogN)** and Space Complexity is O(LogN)
### Pros
### Cons
* **Not Adaptive** (No way to know whether the list is already sorted)
* **Not In-Place** as it takes O(LogN) for call stack.
* **Not Stable** as it does not preserve the position of equal elements (???)
<br>[Back to Top](#table-of-content)
## Binary Search
>Works on sorted list. Find mid point and compare.
### Pros
* Way **Faster** than linear search
* Complexity of linear search is O(N) were in Binary Search it is **O(LogN)**
<br>[Back to Top](#table-of-content)
## Binary Tree
>It is hirarichal data strucrture

|Terminology | Desc.|
| --- | --- |
| Root | Node at the begining of the tree which has no parents |
| EDGE | Relationship between parent and child node. Pictorially arrow between two nodes |
| LEAF | Nodes in bottom level of the tree which doesnt have any child |
| SIBLINGS | Nodes in same level of the tree |
| TRAVERSE | Visiting the nodes of a tree |

* Each node can have 0, 1 or 2 children
* There are many ways in visiting the nodes of a tree
* Two common ways of **Traversing** tree are
    * Breadth First
        >Visiting elements level by level (i.e., All siblings should be processed before going to next level of siblings)
    * Depth First
        >Visiting elements vertical by vertical
        * Pre-Order 
            >Root -> Left SubTree -> Right SubTree
        * In-Order
            >Left SubTree -> Root -> Right Subtree
        * Post-Order
            >Left Subtree -> Right Subtree -> Root

[Back to Top](#table-of-content)
## Binary Search Tree
>Binary search tree is another variation of Binary Tree. It is also called as **Ordered Binary Tree**

* Left node contains value <= value of node
* Right node contains value > value of node
* Average complexity for **Insertion / Lookup** is **O(LogN)**
* When Tree is **Skewed** to one side because the root is smalest or largest element, complexity is **O(N)**
### Pros
* Extremely Fast **Insertion / Lookup**
### Cons
### Problems Using Binary Tree
* Find Min / Max value
* Find depth of a tree

[Back to Top](#table-of-content)
## Heap
> Processing the elements which has highest weightage first
* Internal data container can be any linear data structure. Most commonly Array
* Operations are **Insertion** and **Access / Remove Element of High Priority**
* **Scheduling of Threads** is one of the application
* Heap Property and Shape Property
* Minimum Heap and Maximum Heap
* Heapifying element
    * Shift down
    * Shift up
* Insertion O(LogN)
* Access highest priority element O(1)
* Remove highest priority element O(LogN)

[Back to Top](#table-of-content)
## Heap Sort
> Heapify the elements and Sort it.

* Time Complexity is **O(NLogN)**
* **Not Adaptive**. If data is already sorted it wont breakout early
* **Not Stable Sort**. If two elements with same value, that order wont be taken care.
* **In Place Sorting**. Space complexity is **O(1)** which means no additional space is needed to sort.

[Back to Top](#table-of-content)
## Questions
* **QuickSort workout and code**
* **```yield```** keywor in C#
* Inner list in table of MD script
* Practice Binary Tree Problems from http://cslibrary.stanford.edu/110/binarytrees.pdf


