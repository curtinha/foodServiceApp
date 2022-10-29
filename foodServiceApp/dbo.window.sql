CREATE TABLE [dbo].[Table]
(
	[foodID] INT NOT NULL PRIMARY KEY, 
    [foodName] VARCHAR(50) NOT NULL, 
    [foodType] NCHAR(10) NOT NULL, 
    [dateAdded] DATE NOT NULL, 
    [expiryDate] DATE NOT NULL
)
