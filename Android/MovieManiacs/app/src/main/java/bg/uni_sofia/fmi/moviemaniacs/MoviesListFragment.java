package bg.uni_sofia.fmi.moviemaniacs;

import android.app.Fragment;
import android.util.Log;
import android.widget.ListView;

import org.androidannotations.annotations.AfterViews;
import org.androidannotations.annotations.Background;
import org.androidannotations.annotations.Bean;
import org.androidannotations.annotations.EFragment;
import org.androidannotations.annotations.ItemClick;
import org.androidannotations.annotations.UiThread;
import org.androidannotations.annotations.ViewById;

import java.util.List;

import bg.uni_sofia.fmi.moviemaniacs.models.Movie;

@EFragment(R.layout.fragment_movies_list)
public class MoviesListFragment extends Fragment {

    @ViewById(R.id.movies_list)
    ListView moviesList;

    @Bean
    MoviesAdapter adapter;

    @AfterViews
    public void afterViews() {
        retrieveMovies();
    }

    @Background
    public void retrieveMovies() {
        try {
            List<Movie> movies = MovieManiacsApplication.restAdapter.create(MovieManiacsService.class)
                    .getAllMovies();
            Log.d(MovieManiacsApplication.TAG, "retrieved movies " + movies);
            populateList(movies);
        } catch (Throwable t) {
            Log.e(MovieManiacsApplication.TAG, "can't retrieve movies", t);
        }

    }

    @UiThread
    void populateList(List<Movie> discounts) {
        adapter.setData(discounts);
        moviesList.setAdapter(adapter);
    }

    @ItemClick(R.id.movies_list)
    void discountClicked(Movie movie) {
        MovieActivity_.intent(this).year(movie.Year).imageUrl(movie.imageurl).movieTitle(movie.title).description(movie.description).starring(movie.starring).genre(movie.genre).rank(movie.Rank).start();
    }

}
