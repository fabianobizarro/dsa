#include "queue.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define ITERATIONS 10

void print_stack(Queue* q)
{
    if (isempty(q)) {
        printf("<EMPTY>\n");
        return;
    }

    printf("START -> ");
    Node* node;

    for (node = q->first; node != NULL; node = node->next) {
        printf("%d -> ", node->value);
    }

    printf("END\n");
}

int main()
{
    Queue q = { 0 };
    int n = 0;
    srand(time(NULL));

    printf("=== QUEUE ===\n");

    printf("Adding items to the Queue\n");
    for (int i = 0; i < ITERATIONS; i++) {
        n = rand() % 100;
        enqueue(&q, n);

        printf("Adding %d - ", n);
        print_stack(&q);
    }

    printf("\n");

    printf("Removing items from the Queue\n");
    for (int i = 0; i < ITERATIONS; i++) {
        dequeue(&q, &n);
        printf("Dequeued %d - ", n);
        print_stack(&q);
    }

    destroy(&q);

    return 0;
}
