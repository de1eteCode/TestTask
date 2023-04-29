select 
	les."Name",
	classes."Time",
	classes."Date",
	(select g."Name" as "Group" from "Groups" as g where g."Uid" = gthc."GroupUid"),
	(select s."Name" as "Lector name" from "Staff" as s where s."Uid" = classes."LectorUid")
from "HeldClasses" as classes
left join "Lessons" as les
on classes."LessonUid" = les."Uid" 
left join "GroupToHeldClasses" as gthc 
on classes."Uid" = gthc."HeldClassUid" 
order by classes."Date", classes."Time" 