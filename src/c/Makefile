
CC = gcc
CFLAGS = -Wall -Wextra -g -Iinclude

SRC_DIR = src
INC_DIR = include
OBJ_DIR = obj
BIN_DIR = bin

SRCS = $(shell find $(SRC_DIR) -name "*.c")
OBJS = $(patsubst $(SRC_DIR)/%.c, $(OBJ_DIR)/%.o, $(SRCS))

prepare:
	mkdir -p obj
	mkdir -p bin

default: clean prepare all

all: $(OBJS)
	$(CC) $(CFLAGS) -o $(BIN_DIR)/queue $(OBJ_DIR)/cli/queue_cli.o $(OBJ_DIR)/ds/queue.o
	$(CC) $(CFLAGS) -o $(BIN_DIR)/stack $(OBJ_DIR)/cli/stack_cli.o $(OBJ_DIR)/ds/stack.o

$(OBJ_DIR)/%.o: $(SRC_DIR)/%.c
	@mkdir -p $(dir $@)
	$(CC) $(CFLAGS) -c $< -o $@

clean:
	rm -rf obj/*
	rm -rf bin/*

format:
	clang-format -i $(shell find $(SRC_DIR) $(INC_DIR) -name '*.c' -o -name '*.h')

.PHONY: clean format
