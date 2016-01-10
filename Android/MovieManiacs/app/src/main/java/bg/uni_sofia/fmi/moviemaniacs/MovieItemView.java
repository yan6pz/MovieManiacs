package bg.uni_sofia.fmi.moviemaniacs;

import android.content.Context;
import android.widget.RelativeLayout;
import android.widget.TextView;

import org.androidannotations.annotations.EViewGroup;
import org.androidannotations.annotations.ViewById;

import bg.uni_sofia.fmi.moviemaniacs.models.Movie;

/**
 * Created by Hristo Borisov on 15.11.2015
 */
@EViewGroup(R.layout.list_item)
public class MovieItemView extends RelativeLayout {

//    @ViewById(R.id.discount_description)
//    TextView discountDescription;
//
//    @ViewById(R.id.discount_image)
//    ImageView discountImage;
//
//    @ViewById(R.id.discount_percentage)
//    TextView discountPercentage;

    @ViewById(R.id.movie_title)
    TextView movieTitle;

//    DisplayImageOptions displayImageOptions = new DisplayImageOptions.Builder()
//            .considerExifParams(true)
//            .cacheOnDisk(true)
//            .build();

    public MovieItemView(Context context) {
        super(context);
    }

    public void bind(Movie movie) {
        movieTitle.setText(movie.Description);

//        discountPercentage.setText(movie.movie);
//        ImageLoader.getInstance().displayImage(movie.image, discountImage, displayImageOptions);
    }
}
