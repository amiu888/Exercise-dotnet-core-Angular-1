import { Component, Inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Movie } from '../models/movie';
import { HttpHeaders } from '@angular/common/http';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { throwError } from 'rxjs';


 
 @Component({
  selector: 'app-movie-edit',
  templateUrl: '/movie-edit.component.html'
})
export class MovieEditComponent {
  
     http: HttpClient;
     baseUrl: string;

     title: string;
     releaseYear: string;

  public movies: Movie[];

     constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        
         this.http = http;
         this.baseUrl = baseUrl;
       
     }

     public editForm(formValues) {
         
         console.log(formValues);
         //create movie object and pass to api
         
         const httpOptions = {
             headers: new HttpHeaders({
                 'Content-Type': 'application/json'

             })
         };
         
         //use httpclient to post back the new movie back to api.
    
    }
  
}