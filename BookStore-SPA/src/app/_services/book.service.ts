import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from '../_models/book';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  baseUrl = 'http://localhost:5000/api/book';

  constructor(private http: HttpClient) { }

  AddOrUpdate(model: Book) {
    return this.http.post(this.baseUrl, model);
  }

  GetBooks() {
    return this.http.get(this.baseUrl);
  }

  GetBook(id: number) {
    return this.http.get(this.baseUrl + '/' + id);
  }


}
