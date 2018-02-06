# ds_and_algorithms_safaribooks

## Difference between LinkedList and Array
Linked List | Array
--- | --- |
Size is dynamic | Size is fixed
Insertion / Deletion is optimal and matter of **changing ref pointers** | Insertion / Deletion involve copying and moving rest of the element which is **tedious**
**Accessing** random element costs **O(N)** | If you know index of the element it is **O(1)**
**Additional space** needed for next pointer | **No additional space** is needed
Not suitable for data caching | **Suitable for data caching** because need lesser space and O(1) accessing
Suitable for data **frequently insert/delete** and **unknow size** | Suitable for read operations to be quick


