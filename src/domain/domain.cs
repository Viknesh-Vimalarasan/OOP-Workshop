namespace Workshop.Domain {

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

	}