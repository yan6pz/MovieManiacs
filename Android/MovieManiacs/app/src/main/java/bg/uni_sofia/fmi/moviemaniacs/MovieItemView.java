package bg.uni_sofia.fmi.moviemaniacs;

import android.content.Context;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;

import com.nostra13.universalimageloader.core.DisplayImageOptions;
import com.nostra13.universalimageloader.core.ImageLoader;

import org.androidannotations.annotations.EViewGroup;
import org.androidannotations.annotations.ViewById;

import bg.uni_sofia.fmi.moviemaniacs.models.Movie;

@EViewGroup(R.layout.list_item)
public class MovieItemView extends RelativeLayout {

    @ViewById(R.id.movie_image)
    ImageView movieImage;

    @ViewById(R.id.movie_title)
    TextView movieTitle;

    DisplayImageOptions displayImageOptions = new DisplayImageOptions.Builder()
            .considerExifParams(true)
            .cacheOnDisk(true)
            .build();

    public MovieItemView(Context context) {
        super(context);
    }

    public void bind(Movie movie) {
        movieTitle.setText(movie.title);

        ImageLoader.getInstance().displayImage(movie.imageurl.trim(), movieImage, displayImageOptions);
    }
}
