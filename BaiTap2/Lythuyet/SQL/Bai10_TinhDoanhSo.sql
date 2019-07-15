--10.	Viết store procedure,
--	Hiển thị doanh số bán hàng của các strore (theo tỉ lệ %)
--	Store có doanh số cao nhất sẽ là 100%.
--	Các store còn lại được tính theo tỉ lệ (Doanh số bán của store / Doanh số bán của store bán nhiều nhất) * 100


ALTER PROCEDURE calculatorSales
AS BEGIN 
	SELECT *, 100*Fitter.SumPrice/(
		SELECT MAX(SumPrice) 
		FROM(
		SELECT SUM(Item.list_price) AS SumPrice
		FROM sales.stores AS Sto 
		INNER JOIN sales.orders AS Ord 
		ON Ord.store_id = Sto.store_id 
		INNER JOIN sales.order_item AS Item 
		ON Item.order_id = Ord.order_id 
		GROUP BY Sto.store_id) AS Fiiter
	) 
	FROM sales.stores
	INNER JOIN 
	(SELECT Sto.store_id AS Id, SUM(Item.list_price) AS SumPrice
	FROM sales.stores AS Sto 
	INNER JOIN sales.orders AS Ord 
	ON Ord.store_id = Sto.store_id 
	INNER JOIN sales.order_item AS Item 
	ON Item.order_id = Ord.order_id 
	GROUP BY Sto.store_id) AS Fitter
	ON Fitter.Id= stores.store_id
END 


EXEC dbo.calculatorSales






