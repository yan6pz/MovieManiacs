package bg.uni_sofia.fmi.moviemaniacs;

import android.app.Activity;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.util.Log;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import org.androidannotations.annotations.AfterViews;
import org.androidannotations.annotations.Background;
import org.androidannotations.annotations.Click;
import org.androidannotations.annotations.EActivity;
import org.androidannotations.annotations.ViewById;
import org.w3c.dom.Text;

import java.util.List;

import bg.uni_sofia.fmi.moviemaniacs.models.Movie;

@EActivity(R.layout.activity_create_movie)
public class CreateMovieActivity extends AppCompatActivity {

    @ViewById(R.id.toolbar)
    Toolbar toolbar;

    @ViewById
    EditText movieTitle;

    @ViewById
    EditText movieDescription;

    @ViewById
    EditText movieActors;

    @ViewById
    EditText movieGenre;

    @ViewById
    EditText movieYear;

    @ViewById
    EditText movieRating;

    @ViewById
    EditText movieUrl;

    @Click(R.id.sendBtn)
    public void createMovie() {
        Movie movie = new Movie();
        movie.description = movieDescription.getText().toString();
        movie.genre = movieGenre.getText().toString();
        movie.imageurl = movieUrl.getText().toString();
        movie.Rank = Float.parseFloat(movieRating.getText().toString());
        movie.Year = Integer.parseInt(movieYear.getText().toString());
        movie.title = movieTitle.getText().toString();
        movie.starring = movieActors.getText().toString();
//        Log.i(MovieManiacsApplication.TAG, "Movie: " + movie);
        createMovie(movie);
    }


    @Background
    public void createMovie(Movie movie) {
        try {
            String result = MovieManiacsApplication.restAdapter.create(MovieManiacsService.class)
                    .createMovie(movie);
            Log.d(MovieManiacsApplication.TAG, "created movie result" + result);
//            populateList(movies);
        } catch (Throwable t) {
            Log.e(MovieManiacsApplication.TAG, "can't create movie", t);
        }

    }

    @AfterViews
    public void afterViews(){
        setSupportActionBar(toolbar);
    }

}

