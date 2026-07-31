# Data Structures and Algorithms

Personal study repository focused on implementing classic data structures and algorithms from scratch across multiple languages.

For detailed API definitions, complexity analysis, and CLI conventions, see [`ALGORITHMS_AND_DATA_STRUCTURES.md`](ALGORITHMS_AND_DATA_STRUCTURES.md).


## Principles

- **Core + CLI separation**: each language has a core library with the pure logic and a CLI runner to execute it.
- **Numbers only**: implementations focus on integers (`int`) to keep the code simple and avoid generics/functors/traits complexity.
- **CLI-driven**: every data structure and algorithm must be runnable from a CLI program.
- **Study purpose**: prioritize clarity and correctness over production-grade optimizations.

## Languages

| Language | Status |
|-|-|
| C# | In progress (to refactor) |
| C | Planned |
| Python | Planned |
| Zig | Planned |
| Go | Planned |
| OCaml | Planned |
| Haskell | Planned |
| Common Lisp | Planned |
| Odin | Planned |

## Data Structures

| Data Structure | C# | C | Python | Zig | Go | OCaml | Haskell | Common Lisp | Odin |
|-|-|-|-|-|-|-|-|-|-|
| Dynamic Array | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Linked List | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Doubly Linked List | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Stack | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Queue | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Hash Map — Separate Chaining (Linked List) | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Set | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Binary Tree | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Binary Search Tree | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Min Heap | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Graph | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |

## Algorithms

### Sorting

| Algorithm | C# | C | Python | Zig | Go | OCaml | Haskell | Common Lisp | Odin |
|-|-|-|-|-|-|-|-|-|-|
| Bubble Sort | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Selection Sort | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Insertion Sort | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Shell Sort | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Merge Sort | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Quick Sort | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Heap Sort | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Counting Sort | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Radix Sort | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| Bucket Sort | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |

### Searching

| Algorithm | C# | C | Python | Zig | Go | OCaml | Haskell | Common Lisp | Odin |
|-|-|-|-|-|-|-|-|-|-|
| Binary Search | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |

### Graph

| Algorithm | C# | C | Python | Zig | Go | OCaml | Haskell | Common Lisp | Odin |
|-|-|-|-|-|-|-|-|-|-|
| BFS — Breadth First Search | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |
| DFS — Depth First Search | ✅ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |

### Dynamic Programming

| Algorithm | C# | C | Python | Zig | Go | OCaml | Haskell | Common Lisp | Odin |
|-|-|-|-|-|-|-|-|-|-|
| Fibonacci | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ | ⬜ |

## Project Structure

```
src/
  csharp/       → C# implementations
  c/            → C implementations
  python/       → Python implementations
  zig/          → Zig implementations
  go/           → Go implementations
  ocaml/        → OCaml implementations
  haskell/      → Haskell implementations
  common-lisp/  → Common Lisp implementations
  odin/         → Odin implementations
```

Each language folder keeps data structures and algorithms side by side, with the core logic and CLI runner co-located:

```
language/
  data_structures/
    linked_list.{ext}
    linked_list_cli.{ext}
    hash_map_linked_list.{ext}
    hash_map_linked_list_cli.{ext}
  algorithms/
    quick_sort.{ext}
    quick_sort_cli.{ext}
    binary_search.{ext}
    binary_search_cli.{ext}
```
