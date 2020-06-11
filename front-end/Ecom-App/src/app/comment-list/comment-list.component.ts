import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-comment-list',
  templateUrl: './comment-list.component.html',
  styleUrls: ['./comment-list.component.css']
})
export class CommentListComponent implements OnInit {

  listComment = [
    {
      'CommentId' : 1, 
      'IsChild' : false,
      'IsLike' : false,
      'LikeAmount' : 40,
      'AuthorAvatar' : '',
      'AuthorName' : 'Tran The Nam',
      'CommentContent': 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using "Content here, content here", making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for "lorem ipsum" will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).',
      'CommentParent': -1,
      'CommentTime' : "3 days ago",
      'IsShow' : true
    },
    {
      'CommentId' : 3, 
      'IsChild' : true,
      'IsLike' : false,
      'LikeAmount' : 40,
      'AuthorAvatar' : '',
      'AuthorName' : 'Tran The Nam',
      'CommentContent': 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using "Content here, content here", making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for "lorem ipsum" will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).',
      'CommentParent': 1,
      'CommentTime' : "5 days ago",
      'IsShow' : false
    },
    {
      'CommentId' : 4, 
      'IsChild' : true,
      'IsLike' : false,
      'LikeAmount' : 40,
      'AuthorAvatar' : '',
      'AuthorName' : 'Tran The Nam',
      'CommentContent': 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using "Content here, content here", making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for "lorem ipsum" will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).',
      'CommentParent': 1,
      'CommentTime' : "6 days ago",
      'IsShow' : false
    },
    {
      'CommentId' : 5, 
      'IsChild' : true,
      'IsLike' : false,
      'LikeAmount' : 40,
      'AuthorAvatar' : '',
      'AuthorName' : 'Tran The Nam',
      'CommentContent': 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using "Content here, content here", making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for "lorem ipsum" will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).',
      'CommentParent': 1,
      'CommentTime' : "7 days ago",
      'IsShow' : false
    },
    {
      'CommentId' : 2, 
      'IsChild' : false,
      'IsLike' : false,
      'LikeAmount' : 40,
      'AuthorAvatar' : '',
      'AuthorName' : 'Tran The Nam',
      'CommentContent': 'It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using "Content here, content here", making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for "lorem ipsum" will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).',
      'CommentParent': -1,
      'CommentTime' : "4 days ago",
      'IsShow' : true
    }
  ];
  constructor() { }

  ngOnInit(): void {
    
  }

  ShowComment(number:number){
    let amountComment = this.listComment.length;
    for(let i = 0; i < amountComment; i++){
      if(this.listComment[i].CommentParent == number){
        this.listComment[i].IsShow = true;
      }
    }
  }
}
