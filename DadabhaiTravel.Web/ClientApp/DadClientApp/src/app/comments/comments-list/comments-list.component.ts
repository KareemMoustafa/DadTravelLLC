import { Component, OnInit } from '@angular/core';
import { CommentsService } from 'src/app/shared/comments.service'


@Component({
  selector: 'app-comments-list',
  templateUrl: './comments-list.component.html',
  styleUrls: ['./comments-list.component.css']
})
export class CommentsListComponent implements OnInit {

  constructor(public Service : CommentsService) { }

  ngOnInit(): void {
    this.Service.GetAllListComments();
   
  }

  
}
