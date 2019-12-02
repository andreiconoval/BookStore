import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { BookListComponent } from './book-list/book-list.component';
import { BookComponent } from './book/book.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'books', component: BookListComponent },
  { path: 'book/:id', component: BookComponent },

  {
    path: '',
    redirectTo: '/home',
    pathMatch: 'full'
  }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
