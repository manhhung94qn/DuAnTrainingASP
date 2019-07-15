--9.	Lấy danh sách khách hàng có tổng số điểm mua sản phẩm cao nhất trong tháng vừa rồi. (Điều kiện đơn hàng đã shipped)
--	-	Quy tắc tính điểm: 1000đồng => 1điểm
--	-	Hiển thị: toàn bộ thông tin khách hàng, tổng số điểm, tổng số sản phẩm đã mua.



------------------------start task----------
SELECT 
	*,
	FORMAT(lectCustom.sumMoney/1000,'N1') AS N'Tổng điểm',
	lectCustom.sumQuantity AS N'Số lượng'
FROM sales.customers
INNER JOIN (
	SELECT customer_id, SUM(list_price)AS sumMoney, SUM(quantity) AS sumQuantity 
	FROM sales.orders
	INNER JOIN sales.order_item
	ON order_item.order_id = orders.order_id
	WHERE MONTH(shipped_date) = MONTH(CURRENT_TIMESTAMP)-1
	GROUP BY customer_id
) AS lectCustom
ON lectCustom.customer_id = customers.customer_id

------------------------end task-------------

