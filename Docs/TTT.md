
### SQL:
Общие:
- User (UserName, TG, Token(f))
- Role (RoleName)
- UserRole (User(f), Role(f))
- Tokens (RefreshToken, AccessToken)
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