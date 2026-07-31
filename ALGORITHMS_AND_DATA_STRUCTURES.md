# Algorithms and Data Structures — Definitions

This document defines the API, behavior, complexity, and CLI conventions for every data structure and algorithm in the study repository.

It applies to **all language implementations** unless a language-specific note says otherwise.

## Principles

- **Numbers only**: all keys, values, set elements, graph weights, and array items are `int`.
- **Core + CLI separation**: pure logic lives in a core module/file; a CLI runner demonstrates usage.
- **Clarity over optimization**: code should be readable and correct first.
- **Consistent API**: equivalent operations across languages use the same names and semantics.

---

## Phase 1 Scope

### Data Structures (11)

| # | Data Structure | Notes |
|---|----------------|-------|
| 1 | Stack | Existing |
| 2 | Queue | Existing |
| 3 | Linked List | Singly linked; existing |
| 4 | Binary Tree | Existing |
| 5 | Dynamic Array | Resizable array |
| 6 | Doubly Linked List | Two-way links |
| 7 | Hash Map | Separate chaining with linked list; `int` keys and values |
| 8 | Set | `int` elements |
| 9 | Binary Search Tree | Ordered tree with insert/delete/search/traverse |
| 10 | Min Heap | Binary heap; also powers Heap Sort |
| 11 | Graph | Adjacency list; directed/undirected support |

### Algorithms

| Category | Algorithms |
|----------|------------|
| Sorting (10) | Bubble Sort, Selection Sort, Insertion Sort, Shell Sort, Merge Sort, Quick Sort, Heap Sort, Counting Sort, Radix Sort, Bucket Sort |
| Searching (1) | Binary Search |
| Graph (2) | BFS, DFS |
| Dynamic Programming (1) | Fibonacci |

### Phase 2 Backlog (out of scope for now)

- Deque, Hash Map variants (BST chaining, open addressing), AVL Tree, Red-Black Tree, Max Heap, Trie, LRU Cache, Bloom Filter, Disjoint Set.
- Linear Search, Interpolation Search, Dijkstra, Bellman-Ford, A*, Topological Sort, Kruskal, Prim.
- Knapsack, Coin Change, LCS, Edit Distance.
- KMP, Rabin-Karp.
- N-Queens, Subsets, Permutations, Combinations.

---

## Data Structures

### 1. Stack

**Purpose**: LIFO collection.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `push(value)` | Add `value` to the top | O(1) |
| `pop()` | Remove and return the top value | O(1) |
| `peek()` / `top()` | Return the top value without removing it | O(1) |
| `is_empty()` | Return true if stack has no elements | O(1) |

**Behavior**
- `pop()` or `peek()` on an empty stack raises an error or returns a sentinel (language-dependent; document the choice).

**CLI demo**: push a sequence of integers, then pop until empty.

---

### 2. Queue

**Purpose**: FIFO collection.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `enqueue(value)` | Add `value` to the back | O(1) |
| `dequeue()` | Remove and return the front value | O(1) |
| `peek()` / `front()` | Return the front value without removing it | O(1) |
| `is_empty()` | Return true if queue has no elements | O(1) |

**Behavior**
- `dequeue()` or `peek()` on an empty queue raises an error.

**CLI demo**: enqueue a sequence, then dequeue until empty.

---

### 3. Linked List (Singly Linked)

**Purpose**: Sequential collection of nodes linked in one direction.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `prepend(value)` | Insert at the head | O(1) |
| `append(value)` | Insert at the tail | O(n) unless tail pointer is kept |
| `delete(value)` | Remove first occurrence of `value` | O(n) |
| `find(value)` | Return true if `value` exists | O(n) |
| `to_list()` / `print()` | Return/print all values in order | O(n) |

**Behavior**
- Empty list operations return an error or sentinel where appropriate.

**CLI demo**: prepend/append values, then print the list.

---

### 4. Binary Tree

**Purpose**: Hierarchical structure where each node has at most two children.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `insert(value)` | Add a node preserving the tree shape (e.g., level-order insertion) | O(n) for naive shape insertion |
| `traverse(order)` | Return values in pre-order, in-order, or post-order | O(n) |
| `height()` | Return the height of the tree | O(n) |
| `search(value)` | Return true if `value` exists | O(n) |

**Behavior**
- This is a plain binary tree, not necessarily ordered.
- Traversal order must be one of: `preorder`, `inorder`, `postorder`.

**CLI demo**: build a tree by inserting values, then print traversals.

---

### 5. Dynamic Array

**Purpose**: Resizable array that grows and shrinks as elements are added or removed.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `add(value)` / `append(value)` | Add `value` to the end | O(1) amortized |
| `get(index)` | Return element at `index` | O(1) |
| `set(index, value)` | Set element at `index` | O(1) |
| `insert(index, value)` | Insert at `index`, shifting right | O(n) |
| `remove(index)` | Remove element at `index`, shifting left | O(n) |
| `size()` / `length()` | Return number of elements | O(1) |
| `capacity()` | Return current allocated capacity | O(1) |

**Behavior**
- Initial capacity is language-dependent (e.g., 4 or 8).
- Grow strategy: double capacity when full.
- Shrink strategy: halve capacity when usage drops below 25% (optional).
- Out-of-bounds access raises an error.

**CLI demo**: append values, print size/capacity, remove by index.

---

### 6. Doubly Linked List

**Purpose**: Sequential collection with bidirectional links.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `prepend(value)` | Insert at the head | O(1) |
| `append(value)` | Insert at the tail | O(1) |
| `delete(value)` | Remove first occurrence of `value` | O(n) |
| `find(value)` | Return true if `value` exists | O(n) |
| `print_forward()` | Print values head-to-tail | O(n) |
| `print_backward()` | Print values tail-to-head | O(n) |

**Behavior**
- Maintain both `head` and `tail` pointers.

**CLI demo**: append/prepend values, print forward and backward.

---

### 7. Hash Map (Separate Chaining with Linked List)

**Purpose**: Key-value map with average O(1) operations.

**Constraints**
- Keys and values are `int`.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `put(key, value)` | Insert or update mapping for `key` | O(1) average, O(n) worst |
| `get(key)` | Return value for `key` | O(1) average, O(n) worst |
| `remove(key)` | Delete mapping for `key` | O(1) average, O(n) worst |
| `contains_key(key)` | Return true if key exists | O(1) average |
| `size()` | Return number of entries | O(1) |

**Behavior**
- Hash function: `hash(key) = abs(key) % capacity`.
- Resize when load factor exceeds 0.75: double capacity and rehash all entries.
- `get()` or `remove()` on a missing key raises an error or returns a sentinel.

**CLI demo**: put key-value pairs, get values, remove keys.

---

### 8. Set

**Purpose**: Unordered collection of unique `int` elements.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `add(value)` | Insert `value` if not present | O(1) average |
| `remove(value)` | Delete `value` | O(1) average |
| `contains(value)` | Return true if `value` exists | O(1) average |
| `size()` | Return number of elements | O(1) |

**Behavior**
- Duplicates are ignored on `add`.
- `remove()` on a missing value raises an error or is a no-op (document choice).

**CLI demo**: add values, check membership, remove values.

---

### 9. Binary Search Tree

**Purpose**: Ordered binary tree supporting efficient search, insertion, and deletion.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `insert(value)` | Add `value` preserving BST order | O(h) average, O(n) worst |
| `delete(value)` | Remove `value` | O(h) average, O(n) worst |
| `search(value)` | Return true if `value` exists | O(h) average, O(n) worst |
| `min()` | Return smallest value | O(h) |
| `max()` | Return largest value | O(h) |
| `traverse(order)` | Return values in `inorder`, `preorder`, or `postorder` | O(n) |

**Behavior**
- BST invariant: left subtree < node < right subtree (no duplicates; duplicates ignored or handled consistently).
- `delete` must handle 0, 1, and 2 children correctly.
- `min()`/`max()` on empty tree raises an error.

**CLI demo**: insert values, print in-order traversal, delete values.

---

### 10. Min Heap

**Purpose**: Complete binary tree where each parent is ≤ its children; used as a priority queue.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `insert(value)` | Add `value` and restore heap property | O(log n) |
| `extract_min()` | Remove and return the minimum value | O(log n) |
| `peek_min()` | Return minimum without removing | O(1) |
| `size()` | Return number of elements | O(1) |
| `heapify(array)` | Build heap from an unsorted array | O(n) |

**Behavior**
- Use a dynamic array as the backing store.
- `extract_min()` on an empty heap raises an error.

**CLI demo**: insert values, print min, extract min repeatedly.

**Note**: Heap Sort can reuse this heap implementation or be self-contained.

---

### 11. Graph

**Purpose**: Collection of vertices and edges for graph algorithms.

**Representation**: Adjacency list.

**API**

| Operation | Description | Complexity |
|-----------|-------------|------------|
| `add_vertex(v)` | Add vertex `v` | O(1) |
| `add_edge(u, v)` | Add undirected edge `(u, v)` | O(1) |
| `add_directed_edge(u, v)` | Add directed edge `u → v` | O(1) |
| `neighbors(v)` | Return list of neighbors of `v` | O(degree(v)) |
| `has_edge(u, v)` | Return true if edge exists | O(degree(u)) |
| `vertices()` | Return all vertices | O(V) |

**Behavior**
- Vertices are `int`.
- For simplicity, assume unweighted edges for BFS/DFS.
- If Dijkstra is added later, edges will need weights.

**CLI demo**: build a graph from edges, print adjacency list, run BFS/DFS from a start vertex.

---

## Algorithms

### Sorting

All sorting algorithms operate on an array (or list) of `int` and return the sorted array in non-decreasing order.

#### Bubble Sort

- **Idea**: Repeatedly swap adjacent out-of-order elements.
- **Time**: O(n²) worst/average, O(n) best if optimized with a swapped flag.
- **Space**: O(1).
- **Stable**: Yes.
- **In-place**: Yes.

#### Selection Sort

- **Idea**: Select the minimum element and swap it into place.
- **Time**: O(n²) always.
- **Space**: O(1).
- **Stable**: No (unless implemented carefully).
- **In-place**: Yes.

#### Insertion Sort

- **Idea**: Build a sorted prefix by inserting each new element into its correct position.
- **Time**: O(n²) worst/average, O(n) best.
- **Space**: O(1).
- **Stable**: Yes.
- **In-place**: Yes.

#### Shell Sort

- **Idea**: Generalized insertion sort with a gap sequence.
- **Time**: Depends on gap sequence; commonly O(n log² n) or O(n^(3/2)).
- **Space**: O(1).
- **Stable**: No.
- **In-place**: Yes.
- **Gap sequence**: Use a simple sequence such as `n/2, n/4, ..., 1` or Knuth's `3k + 1`.

#### Merge Sort

- **Idea**: Divide the array in half, sort each half, merge.
- **Time**: O(n log n) always.
- **Space**: O(n) auxiliary.
- **Stable**: Yes.
- **In-place**: No.
- **Variant**: Top-down recursive is the default.

#### Quick Sort

- **Idea**: Pick a pivot, partition into elements ≤ pivot and > pivot, recurse.
- **Time**: O(n log n) average, O(n²) worst.
- **Space**: O(log n) stack average, O(n) worst.
- **Stable**: No.
- **In-place**: Yes.
- **Variant**: Use Hoare's partition scheme. Pivot strategy: first element or random for simplicity.

#### Heap Sort

- **Idea**: Build a max heap, repeatedly extract the maximum.
- **Time**: O(n log n) always.
- **Space**: O(1) if in-place.
- **Stable**: No.
- **In-place**: Yes.

#### Counting Sort

- **Idea**: Count occurrences of each integer, then reconstruct the sorted array.
- **Time**: O(n + k), where `k = max - min + 1`.
- **Space**: O(k).
- **Stable**: Yes.
- **Constraints**: Input integers must have a bounded range.

#### Radix Sort

- **Idea**: Sort digit by digit, typically using counting sort as a subroutine.
- **Time**: O(d · (n + b)), where `d` is number of digits and `b` is base.
- **Space**: O(n + b).
- **Stable**: Yes.
- **Constraints**: Non-negative integers by default; handle negatives separately if desired.
- **Variant**: LSD (least significant digit) radix sort.

#### Bucket Sort

- **Idea**: Distribute values into buckets, sort each bucket (e.g., with insertion sort), concatenate.
- **Time**: O(n + k) average when input is uniformly distributed.
- **Space**: O(n + k).
- **Stable**: Depends on bucket sort; typically yes if insertion sort is used.
- **Constraints**: Assumes values are roughly uniformly distributed over a known range.

---

### Searching

#### Binary Search

- **Input**: Sorted array of `int`, target `int`.
- **Output**: Index of target, or a sentinel (e.g., -1) if not found.
- **Idea**: Compare target to middle element, eliminate half the array, repeat.
- **Time**: O(log n).
- **Space**: O(1) iterative, O(log n) recursive.
- **Requirement**: Input array must be sorted in non-decreasing order.

---

### Graph Algorithms

#### BFS — Breadth First Search

- **Input**: Graph, start vertex `s`.
- **Output**: Vertices in the order they are visited.
- **Idea**: Explore all neighbors at the present depth before moving to the next level.
- **Time**: O(V + E).
- **Space**: O(V).
- **Use cases**: Shortest path in unweighted graphs, connectivity, level-order traversal.

#### DFS — Depth First Search

- **Input**: Graph, start vertex `s`.
- **Output**: Vertices in the order they are visited.
- **Idea**: Explore as far as possible along each branch before backtracking.
- **Time**: O(V + E).
- **Space**: O(V).
- **Variant**: Recursive (default) or explicit-stack iterative.
- **Use cases**: Path finding, connectivity, cycle detection.

---

### Dynamic Programming

#### Fibonacci

- **Input**: Non-negative integer `n`.
- **Output**: The `n`-th Fibonacci number.
- **Sequence**: F(0) = 0, F(1) = 1, F(n) = F(n-1) + F(n-2).
- **Approaches**:
  1. Recursive with memoization — O(n) time, O(n) space.
  2. Bottom-up iterative — O(n) time, O(1) space.
  3. Naive recursive — O(2^n) time (use only to illustrate the need for DP).
- **Recommended implementation**: bottom-up iterative as the primary version; optionally show memoized recursive for comparison.

---

## CLI Conventions

Every implementation should be runnable from a CLI program. Use consistent patterns:

### Sorting
```
sort 64 34 25 12 22 11 90
# Output: 11 12 22 25 34 64 90
```

### Binary Search
```
binary_search 11 12 22 25 34 64 90
# Output: 11 found at index 0
```

### Data structure demos
Use a small interactive or argument-driven script:
```
stack push 1 push 2 push 3 pop pop
# Output: 3 2
```

### Graph demos
```
graph 0-1 0-2 1-3 2-3 bfs 0
# Output: 0 1 2 3
```

---

## Testing Invariants

Every implementation should satisfy these baseline checks:

### Sorting
- Empty array → empty array.
- Single element → same array.
- Already sorted → sorted.
- Reverse sorted → sorted.
- Duplicates handled correctly.
- Output length equals input length.

### Data Structures
- Stack: push order is reverse of pop order.
- Queue: enqueue order equals dequeue order.
- Linked List: forward traversal matches insertion order for appends.
- Dynamic Array: capacity ≥ size; capacity doubles on growth.
- Hash Map: put then get returns the same value; remove then get fails.
- Set: add duplicate does not increase size.
- BST: in-order traversal yields sorted values.
- Min Heap: extract_min returns values in non-decreasing order.
- Graph: add_edge(u, v) makes v a neighbor of u (and u a neighbor of v for undirected).

### Algorithms
- Binary Search: returns correct index for existing values, sentinel for missing values.
- BFS/DFS: visits all reachable vertices exactly once.
- Fibonacci: F(0) = 0, F(1) = 1, F(10) = 55.

---

## Language Notes

| Language | Notes |
|----------|-------|
| C# | Reference implementation; use `int` everywhere. |
| C | Manual memory management; document ownership. |
| Python | Use built-in lists for arrays; avoid `numpy`. |
| Zig | Explicit allocators; show allocator usage. |
| Go | Slices for dynamic arrays; no generics needed for `int`. |
| OCaml | Lists for linked structures; arrays for sorting. |
| Haskell | Pure functions preferred; show recursive patterns. |
| Common Lisp | Use lists and arrays naturally. |
