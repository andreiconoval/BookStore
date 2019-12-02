import { Component, OnInit } from '@angular/core';
import { Book } from '../_models/book';
import { BookService } from '../_services/book.service';
import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {

  book: Book = new Book();
  id: number = 0;
  private sub: any;


  constructor(private bookService: BookService, private location: Location, private route: ActivatedRoute) { }

  ngOnInit() {
    this.sub = this.route.params.subscribe(params => {
      this.id = +params['id']; // (+) converts string 'id' to a number
      if (this.id > 0) { this.GetBook(this.id); }
    });
  }

  AddOrUpdate() {
    this.bookService.AddOrUpdate(this.book).subscribe((value: Book) => {
      this.book = value;
      console.log(this.book);
      console.log('book has been added');
    }, error => {
      console.log(error);
    });
  }

  GetBook(id: number) {
    this.bookService.GetBook(id).subscribe((value: Book) => {
      this.book = value;
    }, error => {
      console.log(error);
    });
  }

  GoBack() {
    this.location.back();
  }

}
