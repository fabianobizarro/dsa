#ifndef STACK_H
#define STACK_H

#include <stdbool.h>

typedef struct {
    int value;
    struct Node* next;
} Node;

typedef struct {
    Node* bottom;
    Node* top;
} Stack;

bool is_empty(Stack* stack);

void push(Stack* stack, int value);

void pop(Stack* stack, int* value);

#endif
