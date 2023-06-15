CREATE TABLE [dbo].[Table] (
    [Registration number] INT          NOT NULL,
    [Student name]        VARCHAR (50) NULL,
    [Date of birth]       DATETIME     NULL,
    [Gender]              CHAR (1)     NULL,
    [Contact number ]     VARCHAR (10) NULL,
    [Course enrolled in]  VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Registration number] ASC)
);

