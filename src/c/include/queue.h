#ifndef QUEUE_H
#define QUEUE_H

#include <stdbool.h>

typedef enum {
    OK
} queue_e;

typedef struct Node {
    int value;
    struct Node* next;
} Node;

typedef struct
{
    Node* first;
    Node* last;
} Queue;

bool isempty(Queue* q);

void enqueue(Queue* q, int value);

void dequeue(Queue* q, int* removed_value);

void destroy(Queue*);

#endif
