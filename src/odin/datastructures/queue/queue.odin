package queue

Queue :: struct {
	head: ^Node,
	tail: ^Node,
}

is_empty :: proc(q: ^Queue) -> bool {
	return q == nil || (q.head == nil && q.tail == nil)
}

enqueue :: proc(q: ^Queue, value: int) {
	if q == nil do return

	node := new(Node)
	node.value = value

	if q.head == nil {
		q.head = node
		q.tail = q.head
	} else {
		q.tail.next = node
		q.tail = q.tail.next
	}

	q.tail.next = nil
}

dequeue :: proc(q: ^Queue) -> int {
	if q == nil || q.head == nil do return 0

	node := q.head
	value := node.value
	q.head = node.next

	if q.head == nil {
		q.tail = nil
	}

	free(node)
	return value
}

destroy_queue :: proc(q: ^Queue) {
	if q == nil do return

	for q.head != nil {
		node := q.head
		q.head = node.next
		free(node)
	}

	q.tail = nil
}
