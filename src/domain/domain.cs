namespace Domain {

        class IDomain {
            
        }

        class DomainInterface {
            IData dataLayer;
            IPresentation presentationLayer;
            bool isAuthenticated;

        }

        class IDownloadable {
            public Download();
        }

        class Review {
            
        }

        class Product {
	        public int id;
	        public string title;
            bool isAvailable;
			Review[] reviews;
        }

        class Movie {
	        string director;
	        string genres;
	        int releaseYear;
	        string language;
	        double duration;
        }

        class EBook {
	        string author;
	        string language;
	        int numberOfPages;
	        int releaseYear;
	        int ISBN;
        }

        class Image {
	        string resolution;
	        string fileFormat;
	        int fileSize;
	        DateTime dateTaken;
        }

        class Podcast {
	        int releaseYear;
	        string host;
	        string guest;
	        int episodeNumber;
	        string language;
        }

        class App {
	        string version;
	        string publisher;
	        string supportedPlatforms;
	        int fileSize;
        }

        class VideoGame {
	        string genre;
	        string publisher;
	        int releaseYear;
	        string supportedPlatforms;
        }

        class Song {
	        string composer;
	        string singer;
	        string genre;
	        string fileType;
	        int duration;
	        string language;
	        string releaseYear;
        }

        class User {
	        int id;
	        string firstname;
	        string lastname;
	        string cpr;
	        string username;
	        string password;
        }

        class Borrower {
        }

        class Employee {
	        bool can_add;
            bool can_remove;
        }

        class Admin {
        }

	}