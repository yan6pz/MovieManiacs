package bg.uni_sofia.fmi.moviemaniacs;

import java.util.List;

import bg.uni_sofia.fmi.moviemaniacs.models.Movie;
import retrofit.http.Body;
import retrofit.http.GET;
import retrofit.http.POST;

public interface MovieManiacsService {

    @GET("/api/movies/all")
    List<Movie> getAllMovies();

    @POST("/api/movie/new")
    String createMovie(@Body Movie movie);

}
