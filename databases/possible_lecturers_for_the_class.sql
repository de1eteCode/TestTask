select 
	s."Name",
	l."Name" 
from "Staff" as s
left join "LectorLessons" as ll
on s."Uid" = ll."LectorUid" 
inner join "Lessons" as l
on l."Uid" = ll."LessonUid" 