#include "queue.h"
#include <stdlib.h>

bool isempty(Queue* q)
{
    return q->first == NULL;
};

void enqueue(Queue* q, int value)
{
    if (!q)
        return;

    Node* node = malloc(sizeof(Node));
    node->value = value;

    if (q->first == NULL) {
        q->first = node;
        q->last = q->first;
    } else {
        q->last->next = node;
        q->last = q->last->next;
    }

    q->last->next = NULL;
}

void dequeue(Queue* q, int* removed_value)
{
    if (!q || isempty(q)) {
        return;
    }

    Node* aux = q->first;
    q->first = q->first->next;
    if (removed_value != NULL) {
        *removed_value = aux->value;
    }
    free(aux);
}

void destroy(Queue* q)
{
    if (!q)
        return;

    Node* aux = q->first;
    while (aux != NULL) {
        struct Node* next = aux->next;
        free(aux);
        aux = next;
    }

    q->first = q->last = NULL;
}
