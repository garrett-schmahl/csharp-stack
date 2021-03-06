/**
 * Class to represent a queue using an array to store the queued items.
 * Follows a FIFO (First In First Out) order where new items are added to the
 * back and items are removed from the front.
 */

class Node {
  constructor(data) {
    this.data = data;
    this.next = null;
  }
}
class Queue {
  /**
   * The constructor is executed when instantiating a new Queue() to construct
   * a new instance.
   * @returns {Queue} This new Queue instance is returned without having to
   *    explicitly write 'return' (implicit return).
   */
  constructor() {
    this.head = null;
    this.last = null;
    this.items = [];
  }

  // methods go here
  addQueue(data) {
    const newItem = new Node(data);
    if (this.items.length > 0) {
      this.last.next = newItem;
      this.last = newItem;
    } else {
      this.head = newItem;
    }
  }

  processQueue() {
    if (this.items.length > 0) {
      let papersPlease = this.head;
      this.head = this.head.next;
      return papersPlease.data;
    }
    return undefined;
  }
}
