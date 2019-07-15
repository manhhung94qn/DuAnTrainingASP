-- 7.	Lấy duy nhất 1 nhân viên đã bán được nhiều sản phẩm nhất và có tổng tiền bán sản phẩm cao nhất.

-------------------------------begin task-------------------------------------

BEGIN
	SELECT * FROM sales.staffs
	WHERE staff_id IN 
	(
		SELECT TOP 1 orders.staff_id 
		FROM sales.orders AS orders 
		INNER JOIN sales.order_item AS item 
		ON item.order_id = orders.order_id 
		GROUP BY orders.staff_id
		ORDER BY SUM(item.quantity) DESC, SUM(item.list_price) DESC
	)
END



-----------------------------------End task---------------------------------------


