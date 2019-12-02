import { Component, OnInit } from '@angular/core';
import { Book } from '../_models/book';
import { BookService } from '../_services/book.service';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  bookList: Book[] = [];

  strin = 'asasd';

  selectedBook: Book;

  constructor(private bookService: BookService) { }

  ngOnInit() {
    this.bookService.GetBooks().subscribe((books: Book[]) => {
      this.bookList = books;
      this.selectedBook = this.bookList[0];
    });
  }


  changeBook(e) {
    this.strin = e.target.value;
    const dotNumber = this.strin.indexOf(':');

    console.log(this.strin.slice(0, dotNumber));
  }

}
