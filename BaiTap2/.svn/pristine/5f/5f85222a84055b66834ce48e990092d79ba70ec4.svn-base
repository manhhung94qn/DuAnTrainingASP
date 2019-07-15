--8.	Viết câu truy vấn đánh giá nhân viên theo doanh số bán hàng theo từng tháng.
--	-	Bán trên 1000 sp : NV Xuất sắc
--	-	Bán trên 500 sp: NV TB
--	-	Bán dưới 500 sp: NV Kém



------------------------Begin task--------------------
SELECT * FROM sales.staffs AS staff
INNER JOIN
	(SELECT orders.staff_id, dbo.rateStaff(SUM(item.quantity)) AS SumQuatity
	FROM sales.orders AS orders 
	INNER JOIN sales.order_item AS item 
	ON item.order_id = orders.order_id AND MONTH(orders.shipped_date) = 6
	GROUP BY orders.staff_id
	) AS rate
ON rate.staff_id = staff.staff_id
--------------------------finish task------------------------




------------------------create function-----------------------

ALTER FUNCTION [dbo].[rateStaff](@numberProd INT)
RETURNS NVARCHAR(255) 
AS BEGIN
	DECLARE @res AS NVARCHAR(255)
	IF(@numberProd > 1000)
	BEGIN
	    SET @res = N'Xuất sắc'
	END	
	ELSE IF(@numberProd >500)
	BEGIN
		SET @res = N'Khá'
	END
	ELSE SET @res = N'Kém'
	RETURN @res
END;
--------------------end function------------------




