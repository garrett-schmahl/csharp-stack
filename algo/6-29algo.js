class Node {
  constructor(data) {
    this.data = data;
    this.next = null;
    this.prev = null;
  }
}

class DoublyLinkedList {
  constructor() {
    this.head = null;
    this.last = null;
    this.length = 0;
  }

  isEmpty() {
    return this.head === null;
  }

  insertAtBack(data) {
    const newBack = new Node(data);
    this.length++;
    if (this.isEmpty()) {
      this.head = newBack;
      this.last = newBack;
      return this;
    }
    this.last.next = newBack;
    newBack.prev = this.last;
    this.last = newBack;
    return this;
  }

  insertAtFront(data) {
    const newHead = new Node(data);
    this.length++;
    if (this.isEmpty()) {
      this.head = newHead;
      this.last = newHead;
      return this;
    }
    newHead.next = this.head;
    this.head.prev = newHead;
    this.head = newHead;
    return this;
  }

  seedFromArr(arr) {
    for (let i in arr) {
      this.insertAtBack(arr[i]);
    }
    return this;
  }

  seedFrontFromArr(arr) {
    for (let i in arr) {
      this.insertAtFront(arr[i]);
    }
    return this;
  }

  printList() {
    if (this.isEmpty()) {
      return null;
    }
    let runner = this.head;
    while (runner !== null) {
      console.log(runner.data);
      runner = runner.next;
    }
  }
}

const doubleLinkListOne = new DoublyLinkedList().seedFromArr([1, 2, 3, 4, 5]);
const doubleLinkListTwo = new DoublyLinkedList().seedFrontFromArr([
  1, 2, 3, 4, 5,
]);
doubleLinkListTwo.printList();
