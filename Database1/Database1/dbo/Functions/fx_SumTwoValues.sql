﻿CREATE FUNCTION fx_SumTwoValues
( @Val1 int, @Val2 int )
RETURNS int
AS
BEGIN
  RETURN (@Val1+@Val2)
END