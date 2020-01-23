--Не запускал, ибо нет развернутого MS SQL под рукой
CREATE TABLE Article
(
    Id int NOT NULL PRIMARY KEY,
    Title VARCHAR(1000) NOT NULL
);

CREATE TABLE Tag
(
    Id int NOT NULL PRIMARY KEY,
    Description VARCHAR(1000) NOT NULL
);

CREATE TABLE ArticleTag
(
    ArticleId int NOT NULL REFERENCES Article(Id),
    TagId int NOT NULL REFERENCES Tag(Id),
    CONSTRAINT PK_ArticleTag
           PRIMARY KEY (ArticleId, TagId)
);

SELECT
    Article.Title,
    Tag.Description
FROM Article
    LEFT JOIN ArticleTag on ArticleTag.ArticleId = Article.Id
    LEFT JOIN Tag on Tag.Id = ArticleTag.TagId
