import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movie } from '../models/movie';


@Component({
  selector: 'app-movie-listr-component',
  templateUrl: './movie-list.component.html'
})
export class MovielistComponent {
  

  public movies: Movie[];
 
    //use httpclient to get the movie data from api.
    //ref - http://www.projectcodify.com/angular-set-base-url-dynamically
    //      This template already implemented Base URLusing Dependency Injection
    // api url (baseUrl + 'movie')

  
}

