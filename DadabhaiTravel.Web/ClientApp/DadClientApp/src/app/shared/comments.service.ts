import { Injectable } from '@angular/core';
import {  HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CommentsService {
  list: any = [];
  readonly rootURL ='http://localhost:3072/api'
  constructor(private http : HttpClient) { 

  }

  GetAllListComments (){
   this.http.get(this.rootURL +'/values/GetTodos')
   .subscribe(result => {
    this.list = result ;
}, error => console.error(error)); ;
  
  }
}
