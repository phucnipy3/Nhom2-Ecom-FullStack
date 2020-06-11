import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-comment',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.css']
})
export class CommentComponent implements OnInit {
  // Infor comment
  @Input() id:number = 1;
  @Input() isChild:boolean = false;
  @Input() parent:number = -1;
  @Input() isLike:boolean = false;
  @Input() likeAmount:number = 10;
  @Input() authorAvatar:string = "";
  @Input() authorName:string = "Tran Le Anh Vu"
  @Input() commentContent:string = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quae vero, iure laborum placeat, non alias distinctio enim qui rem quod! Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quae vero, iure laborum placeat, non alias distinctio enim qui rem quod!";
  @Input() commentTime:string = "3 days ago";

  @Output() public ShowComment = new EventEmitter<number>();
  constructor() { }

  ngOnInit(): void {
  }

  ngAfterViewInit(){

  }

  ChangeLike(){
    this.isLike = !this.isLike;

    if(this.isLike){
      this.likeAmount++;
    }else{
      this.likeAmount--;
    }
  }

  FormatAvatarName(){
    let avatarNameArr = this.authorName.split(' ');
    let avatarName = "";
    let lengthName  = avatarNameArr.length;
    if(lengthName > 1){
      let i = lengthName - 2;
      for(i; i < lengthName; i++){
        avatarName += avatarNameArr[i].charAt(0);
      }
    }else{
      avatarName += avatarNameArr[0].charAt(0);
    }
    
    return avatarName;
  }

  ShowCommentChild(id){
    this.ShowComment.emit(id);
  }

}
