#include "stack.h"
#include <stdlib.h>

bool is_empty(Stack* stack)
{
    return stack == NULL
        || stack->top == NULL;
}

void push(Stack* stack, int value)
{
    if (!stack)
        return;

    Node* node = (Node*)malloc(sizeof(Node));
    node->value = value;
    node->next = (struct Node*)stack->top;

    stack->top = node;
}

void pop(Stack* stack, int* value)
{
    if (is_empty(stack))
        return;

    Node* aux = stack->top;

    stack->top = (Node*)aux->next;
    *value = aux->value;

    free(aux);
}
