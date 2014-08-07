IlluminateSupport_dev
=====================

Exports Support site in an xml format

Commands to run on the support database before running:
use IlluminateSupport_dev
go

create procedure getPoints @pointID varchar (10),@pointIDnum varchar (3)
as
begin
select Point.PointNumber, Point.Description, Point.Solution, Point.VersionOn AS UpdateTime, PointPriorityLib.Name AS PriorityName, PointTypeLib.Name AS TypeName, PointStateLib.Name AS StateName, Organization.Name, Point.PointPriorityID,PointHistory.VersionOn as createdDate
from Point
inner Join PointPriorityLib
on PointPriorityLib.PointPriorityID = Point.PointPriorityID
inner Join PointStateLib
on PointStateLib.PointStateID = Point.PointStateID
inner Join PointTypeLib
on PointTypeLib.PointTypeID = Point.PointTypeID
inner Join Organization
on Organization.OrganizationID = Point.OrganizationDiscovererID
inner Join PointHistory
on PointHistory.Version = '1' and PointHistory.PointID = @pointIDnum
where Point.PointNumber = @pointID
end
go

create procedure getNotes @pointID nvarchar (10)
as
begin
select PointNote.PointID, PointNote.Description, PointNote.PointNoteID,PointNote.VersionOn as dateNoteMade, UserInfo.FirstName, UserInfo.LastName
from Point
inner join PointNote
on PointNote.PointID = Point.PointID
inner join UserInfo
on UserInfo.UserID = PointNote.VersionBy
where Point.PointNumber = @pointID
end
go

create procedure getListOfPoints
as
begin
select Point.PointNumber, Point.Subject
from Point
end
go

create procedure getFilteredList @pointType varchar(10),@pointState varchar (10),@pointPriority varchar(10),@list 
as
begin
select Point.PointNumber, Point.Subject
from Point
where @pointType | Point.PointPriorityID = @pointType and @pointState | Point.PointStateID = @pointState and @pointPriority | Point.PointPriorityID = @pointPriority 
end
go
