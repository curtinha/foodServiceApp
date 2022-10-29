CREATE TABLE [dbo].[window]
(
	[foodID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [foodName] VARCHAR(50) NOT NULL, 
    [foodType] NCHAR(10) NOT NULL, 
    [dateAdded] DATE NOT NULL, 
    [expiryDate] DATE NOT NULL
)
