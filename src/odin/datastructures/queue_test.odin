package datastructures

import "core:testing"

@(test)
queue_basic_operations :: proc(t: ^testing.T) {
	q := Queue{}
	testing.expect(t, is_empty(&q), "new queue should be empty")

	enqueue(&q, 1)
	enqueue(&q, 2)
	enqueue(&q, 3)

	testing.expect(t, !is_empty(&q), "queue with items should not be empty")
	testing.expect_value(t, dequeue(&q), 1)
	testing.expect_value(t, dequeue(&q), 2)
	testing.expect_value(t, dequeue(&q), 3)
	testing.expect(t, is_empty(&q), "queue should be empty after dequeuing all items")
}

@(test)
queue_dequeue_empty_returns_zero :: proc(t: ^testing.T) {
	q: Queue
	testing.expect_value(t, dequeue(&q), 0)
}
