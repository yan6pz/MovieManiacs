package bg.uni_sofia.fmi.moviemaniacs;

import android.app.Activity;
import android.support.design.widget.CollapsingToolbarLayout;
import android.widget.ImageView;

import com.nostra13.universalimageloader.core.DisplayImageOptions;
import com.nostra13.universalimageloader.core.ImageLoader;

import org.androidannotations.annotations.AfterViews;
import org.androidannotations.annotations.EActivity;
import org.androidannotations.annotations.Extra;
import org.androidannotations.annotations.ViewById;

@EActivity(R.layout.activity_movie)
public class MovieActivity extends Activity {

    @Extra
    String imageUrl;

    @Extra
    String movieTitle;

    @ViewById(R.id.backdrop)
    ImageView movieImage;

    @ViewById(R.id.collapsing_toolbar)
    CollapsingToolbarLayout collapsingToolbar;

    DisplayImageOptions displayImageOptions = new DisplayImageOptions.Builder()
            .considerExifParams(true)
            .cacheOnDisk(true)
            .build();

    @AfterViews
    public void afterViews() {
        ImageLoader.getInstance().displayImage(imageUrl.trim(), movieImage, displayImageOptions);
        collapsingToolbar.setTitle(movieTitle);
    }

}
