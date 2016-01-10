package bg.uni_sofia.fmi.moviemaniacs.models;

public class Movie {

    public int Id;
    public float Rank;
    public String ReleaseDate;
    public int Year;
    public String description;
    public String genre;
    public String imageurl;
    public String starring;
    public String title;

    @Override
    public String toString() {
        return "Movie{" +
                "Id=" + Id +
                ", Rank=" + Rank +
                ", ReleaseDate='" + ReleaseDate + '\'' +
                ", Year=" + Year +
                ", description='" + description + '\'' +
                ", genre='" + genre + '\'' +
                ", imageurl='" + imageurl + '\'' +
                ", starring='" + starring + '\'' +
                ", title='" + title + '\'' +
                '}';
    }
}
