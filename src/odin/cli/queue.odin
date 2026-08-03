package cli

import "core:fmt"
import "core:math/rand"
import "ds:datastructures"

Iterations :: 5

print_queue :: proc(q: ^datastructures.Queue) {
	if datastructures.is_empty(q) do fmt.println("<EMPTY>")

	fmt.print("START -> ")
	node: ^datastructures.Node

	for node = q.head; node != nil; node = node.next {
		fmt.printf("%d -> ", node.value)
	}

	fmt.print("END\n")
}

main :: proc() {
	q := datastructures.Queue{}

	fmt.println("=== QUEUE ===")

	fmt.print("Adding values to the Queue\n")
	for i := 0; i < Iterations; i += 1 {
		n := rand.int_max(100)
		datastructures.enqueue(&q, n)
		fmt.printf("Adding %d - ", n)
		print_queue(&q)
	}

	fmt.println()

	fmt.print("Removing values from the Queue\n")
	for i := 0; i < Iterations; i += 1 {
		n := datastructures.dequeue(&q)
		fmt.printf("Dequeue %d - ", n)
		print_queue(&q)
	}

	datastructures.destroy_queue(&q)
}
