package main

import "../datastructures/queue"
import "core:fmt"
import "core:math/rand"

Iterations :: 5

print_queue :: proc(q: ^queue.Queue) {
	if queue.is_empty(q) do fmt.println("<EMPTY>")

	fmt.print("START -> ")

	for node := q.head; node != nil; node = node.next {
		fmt.printf("%d -> ", node.value)
	}

	fmt.print("END\n")
}

main :: proc() {
	q := queue.Queue{}

	fmt.println("=== QUEUE ===")

	fmt.print("Adding values to the Queue\n")
	for i := 0; i < Iterations; i += 1 {
		n := rand.int_max(100)
		queue.enqueue(&q, n)
		fmt.printf("Adding %d - ", n)
		print_queue(&q)
	}

	fmt.println()

	fmt.print("Removing values from the Queue\n")
	for i := 0; i < Iterations; i += 1 {
		n := queue.dequeue(&q)
		fmt.printf("Dequeue %d - ", n)
		print_queue(&q)
	}

	queue.destroy_queue(&q)
}
