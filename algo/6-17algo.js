class Node {
  constructor(data, priority) {
    this.data = data;
    this.priority = priority;
    this.next = null;
  }
}

class SinglyLinkedList {
  constructor() {
    this.head = null;
  }

  seedFromArr(vals) {
    for (const item of vals) {
      this.queueItem(item[0], item[1]);
    }
    return this;
  }

  queueItem(data, priority) {
    const newNode = new Node(data, priority);
    if (!this.head) {
      this.head = newNode;
      return newNode;
    } else if (this.head.priority > newNode.priority) {
      newNode.next = this.head;
      this.head = newNode;
      return newNode;
    }
    let runner = this.head;
    while (runner.next !== null) {
      if (runner.next.priority > newNode.priority) {
        //continues while the following
        break;
      }
      runner = runner.next;
    }

    newNode.next = runner.next; //runner.next is now the follow up node to both the list and newNode
    runner.next = newNode; //overwrites the list

    return newNode;
  }

  deQueue() {
    if (!this.head) {
      return null;
    }
    const processData = this.head;
    this.head = this.head.next;
    return processData.data;
  }
}

const firstThreeList = new SinglyLinkedList().seedFromArr([
  [1, 3],
  [2, 1],
  [3, 2],
  [4, 1],
  [5, 2],
  [6, 3],
  [7, 2],
  [8, 3],
]);

console.log(firstThreeList.deQueue());
console.log(firstThreeList.deQueue());
console.log(firstThreeList.deQueue());
console.log(firstThreeList.deQueue());
console.log(firstThreeList.deQueue());
console.log(firstThreeList.deQueue());
console.log(firstThreeList.deQueue());
console.log(firstThreeList.deQueue());
