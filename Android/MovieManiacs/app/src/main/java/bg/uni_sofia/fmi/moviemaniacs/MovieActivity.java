package bg.uni_sofia.fmi.moviemaniacs;

import android.app.Activity;
import android.graphics.Color;
import android.graphics.PorterDuff;
import android.graphics.drawable.LayerDrawable;
import android.support.design.widget.CollapsingToolbarLayout;
import android.util.Log;
import android.widget.ImageView;
import android.widget.RatingBar;
import android.widget.TextView;

import com.nostra13.universalimageloader.core.DisplayImageOptions;
import com.nostra13.universalimageloader.core.ImageLoader;

import org.androidannotations.annotations.AfterViews;
import org.androidannotations.annotations.EActivity;
import org.androidannotations.annotations.Extra;
import org.androidannotations.annotations.ViewById;
import org.w3c.dom.Text;

@EActivity(R.layout.activity_movie)
public class MovieActivity extends Activity {

    @Extra
    String imageUrl;

    @Extra
    String movieTitle;

    @Extra
    String description;

    @Extra
    String starring;

    @Extra
    String genre;

    @Extra
    int year;

    @Extra
    float rank;

    @ViewById(R.id.backdrop)
    ImageView movieImage;

    @ViewById(R.id.movie_description)
    TextView movieDescription;

    @ViewById(R.id.movie_actors)
    TextView movieActors;

    @ViewById(R.id.movie_genre)
    TextView movieGenre;

    @ViewById(R.id.rating_bar)
    RatingBar ratingBar;

    @ViewById(R.id.collapsing_toolbar)
    CollapsingToolbarLayout collapsingToolbar;

    @ViewById(R.id.movie_year)
    TextView movieYear;

    DisplayImageOptions displayImageOptions = new DisplayImageOptions.Builder()
            .considerExifParams(true)
            .cacheOnDisk(true)
            .build();

    @AfterViews
    public void afterViews() {
        ImageLoader.getInstance().displayImage(imageUrl.trim(), movieImage, displayImageOptions);
        collapsingToolbar.setTitle(movieTitle);
        movieDescription.setText(description.trim());
        movieActors.setText(starring.trim());
        movieGenre.setText(genre.trim());
        Log.i(MovieManiacsApplication.TAG, "rank: " + rank);
        ratingBar.setRating(rank / 2);
        movieYear.setText(Integer.toString(year));
    }

}
