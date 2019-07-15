-- 6.	Lấy sanh sách tất cả nhân viên, đã bán được trên 1000 sản phẩm trong tháng trước.



-------------------Begin task---------------

BEGIN
	SELECT * FROM sales.staffs
	WHERE staff_id IN 
	(
		SELECT orders.staff_id 
		FROM sales.orders AS orders 
		INNER JOIN sales.order_item AS item 
		ON item.order_id = orders.order_id 
		WHERE MONTH(orders.required_date) = MONTH(CURRENT_TIMESTAMP) - 1
		GROUP BY orders.staff_id 
		HAVING SUM(item.quantity)>=1000
	)
END


-------------------End task------------------

