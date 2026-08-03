package datastructures

import "core:fmt"

main :: proc() {
	q := Queue{}

	enqueue(&q, 10)
	enqueue(&q, 20)
	enqueue(&q, 30)

	fmt.println("Queue empty:", is_empty(&q))

	for !is_empty(&q) {
		fmt.println("dequeued:", dequeue(&q))
	}

	fmt.println("Queue empty:", is_empty(&q))

	destroy_queue(&q)
}
