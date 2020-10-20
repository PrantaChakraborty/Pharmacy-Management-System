CREATE TABLE [dbo].[Table]
(
	[user_name] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [password] VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([user_name]), 
    CONSTRAINT [PK_Table] PRIMARY KEY ([user_name])
)
