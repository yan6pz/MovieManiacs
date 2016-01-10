package bg.uni_sofia.fmi.moviemaniacs;

import android.content.Context;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;

import org.androidannotations.annotations.EBean;
import org.androidannotations.annotations.RootContext;

import java.util.List;

import bg.uni_sofia.fmi.moviemaniacs.models.Movie;

/**
 * Created by Hristo Borisov on 15.11.2015
 */
@EBean
public class MoviesAdapter extends BaseAdapter {

    private List<Movie> movies;

    @RootContext
    Context context;

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {

        MovieItemView movieItemView;
        if (convertView == null) {
            movieItemView = MovieItemView_.build(context);
        } else {
            movieItemView = (MovieItemView) convertView;
        }

        movieItemView.bind(getItem(position));

        return movieItemView;
    }

    @Override
    public int getCount() {
        return movies.size();
    }

    @Override
    public Movie getItem(int position) {
        return movies.get(position);
    }

    @Override
    public long getItemId(int position) {
        return position;
    }

    public void setData(List<Movie> data) {
        this.movies = data;
    }
}
