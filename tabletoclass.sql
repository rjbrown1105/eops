declare @class varchar(max);

; with typemapping as (
 Select 'time' as DATA_TYPE, 'TimeSpan' ctype
 union
 Select 'date' as DATA_TYPE, 'DateTime' ctype
 union
 Select 'char' as DATA_TYPE, 'string' ctype
 union
 Select 'nvarchar' as DATA_TYPE, 'string' ctype
 union
 Select 'varchar' as DATA_TYPE, 'string' ctype
 union
 Select 'int', 'int'
)
select @class = isnull(@class + char(10), '') + 'public ' +
       tm.ctype +' ' + column_name +
       ' { get; set; }'
from information_schema.columns sc
   inner join typemapping tm on sc.data_type = tm.data_type
where table_name ='EventPrf'

print @class;