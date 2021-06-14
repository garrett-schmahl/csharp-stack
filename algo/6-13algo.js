/**
 * Class to represent a stack using an array to store the stacked items.
 * Follows a LIFO (Last In First Out) order where new items are stacked on
 * top (back of array) and removed items are removed from the top / back.
 */
class Stack {
  /**
   * The constructor is executed when instantiating a new Stack() to construct
   * a new instance.
   * @returns {Stack} This new Stack instance is returned without having to
   *    explicitly write 'return' (implicit return).
   */
  constructor() {
    this.items = [];
  }

  /**
   * Adds a new given item to the top / back of this stack.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @param {any} item The new item to be added to the top / back.
   * @returns {number} The new length of this stack.
   */
  push(item) {
    this.items.push(item);
    return this.items.length;
  }

  /**
   * Removes the top / last item from this stack.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {any} The removed item or undefined if this stack was empty.
   */
  pop() {
    if (this.items) {
      return this.items.pop();
    }
    return undefined;
  }

  /**
   * Retrieves the top / last item from this stack without removing it.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {any} The top / last item of this stack.
   */
  peek() {
    if (this.items) {
      return this.items[this.items.length - 1];
    }
    return undefined;
  }

  /**
   * Returns whether or not this stack is empty.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {boolean}
   */
  isEmpty() {
    if (this.items.length > 0) {
      return false;
    }
    return true;
  }

  /**
   * Returns the size of this stack.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {number} The length.
   */
  size() {
    return this.items.length;
  }
}

const testList = new Stack();
testList.items = [1, 2, 3, 4, 5, 6];

const emptyList = new Stack();

console.log("push test");
testList.push(7);
console.log(testList.items);

emptyList.push(7);
console.log(emptyList.items);
emptyList.pop();

console.log("pop test");
console.log(testList.pop());
console.log(testList.items);

console.log(emptyList.pop());
console.log(emptyList.items);

console.log("peek test");
console.log(testList.peek());
console.log(emptyList.peek());

console.log("isempty test");
console.log(testList.isEmpty());
console.log(emptyList.isEmpty());



class Node {
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}

class LinkedListStack {
  constructor() {
    this.head = null;
    this.last = null;
    this.length = 1;
  }

  /**
   * Adds a new given item to the top / back of this stack.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @param {any} data The new item to be added to the top / back.
   * @returns {number} The new length of this stack.
   */
  push(data) {
    const newBack = new Node(data);

    if (this.isEmpty()) {
      this.last = newBack;
      this.head = newBack;
    } else {
      let tempData = this.head;
      this.head = newBack;
      this.head.next = tempData;
    }
    this.length++;
    return this.length;
  }

  /**
   * Removes the top / last item from this stack.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {any} The removed item or undefined if this stack was empty.
   */
  pop() {
    if (this.isEmpty()) {
      return undefined;
    }
    storedData = this.head;
    this.head = this.head.next;
    this.length--;
    return storedData;
  }

  /**
   * Retrieves the top / last item from this stack without removing it.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {any} The top / last item of this stack.
   */
  peek() {
    return this.last;
  }

  /**
   * Returns whether or not this stack is empty.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {boolean}
   */
  isEmpty() {
    if (this.head) {
      return false;
    }
    return true;
  }

  /**
   * Returns the size of this stack.
   * - Time: O(1) constant.
   * - Space: O(1) constant.
   * @returns {number} The length.
   */
  size() {
    return this.length;
  }
}
