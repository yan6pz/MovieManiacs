package bg.uni_sofia.fmi.moviemaniacs;

import android.app.Application;
import android.util.Log;

import com.nostra13.universalimageloader.core.ImageLoader;
import com.nostra13.universalimageloader.core.ImageLoaderConfiguration;

import org.androidannotations.annotations.EApplication;

import retrofit.RestAdapter;

@EApplication
public class MovieManiacsApplication extends Application {

    public static final String TAG = "MovieManiacs";

    public static RestAdapter restAdapter;

    @Override
    public void onCreate() {
        super.onCreate();
        Log.i(TAG, "application started");
        restAdapter = new RestAdapter.Builder()
                .setLogLevel(RestAdapter.LogLevel.FULL)
                .setEndpoint("http://192.168.1.100:6969")
                .build();

        ImageLoaderConfiguration config = new ImageLoaderConfiguration.Builder(this)
                .build();

        ImageLoader.getInstance().init(config);
    }

}
