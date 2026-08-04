#include "stack.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define ITERATIONS 10

void print_stack(Stack* q)
{
    if (is_empty(q)) {
        printf("<EMPTY>\n");
        return;
    }

    printf("START -> ");
    Node* node;

    for (node = q->top; node != NULL; node = (Node*)node->next) {
        printf("%d -> ", node->value);
    }

    printf("END\n");
}

int main()
{
    Stack q = { 0 };
    int n = 0;
    srand(time(NULL));

    printf("=== STACK ===\n");

    printf("Adding items to the Stack\n");
    for (int i = 0; i < ITERATIONS; i++) {
        n = rand() % 100;
        push(&q, n);

        printf("Push %d - ", n);
        print_stack(&q);
    }

    printf("\n");

    printf("Removing items from the Stack\n");
    for (int i = 0; i < ITERATIONS; i++) {
        pop(&q, &n);
        printf("Pop %d - ", n);
        print_stack(&q);
    }

    return 0;
}
