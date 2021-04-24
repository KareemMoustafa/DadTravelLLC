import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CommentsComponent } from './comments/comments.component';
import { CommentsListComponent } from './comments/comments-list/comments-list.component';
import { CommentsService } from './shared/comments.service';
import { HttpClientModule } from '@angular/common/http';
import {TableModule} from 'primeng/table';

import { ButtonModule } from 'primeng/button';
import { RippleModule } from 'primeng/ripple';

@NgModule({
  declarations: [
    AppComponent,
    CommentsComponent,
    CommentsListComponent,
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    TableModule ,
    ButtonModule,
    RippleModule
  ],
  providers: [CommentsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
