CREATE PROCEDURE [dbo].[UpdateEmployeeDetails]

      @p_name1 varchar(20),

       @p_id1 int
AS

BEGIN

    

      UPDATE  member SET member_name = @p_name1

      WHERE member_id=@p_id1

END