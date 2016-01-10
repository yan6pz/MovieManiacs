package bg.uni_sofia.fmi.moviemaniacs;

import java.util.List;

import bg.uni_sofia.fmi.moviemaniacs.models.Movie;
import retrofit.http.GET;

public interface MovieManiacsService {

    @GET("/api/movies/all")
    List<Movie> getAllMovies();

}
