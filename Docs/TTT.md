
### SQL:
Общие:
- User (UserName, TG)
- Role (User(f), Role)
- Tokens (User(f), RefreshToken, AccessToken)
- Topic (Name, Description)
- TopicSubscriptions (User(f), Topic(f))
- Poster (Title, Description, Image, Media(f))
- News (Title, Content, SourceURL, PublishDate, Topic/Media(f))
- Media (Name, Description, Image, ReleaseDate, IsReleased, Genres)
Дополнительные:
- MovieDetails
- SeriesDetails
- GameDetails
- GameExpansionDetails
- SongDetails
- AlbumDetails