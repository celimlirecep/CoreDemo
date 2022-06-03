
Create Trigger AddBogInRaytingTable
On Blogs 
After Insert
AS
Declare @ID int
Select @ID=BlogID from inserted
Insert Into BlogRaytings (BlogId,BlogTotalScore,BlogRaytingCount)
Values (@ID,0,0)