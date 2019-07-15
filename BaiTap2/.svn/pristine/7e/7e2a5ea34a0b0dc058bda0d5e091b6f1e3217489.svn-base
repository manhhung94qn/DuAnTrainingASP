-- Bai 3.	Lấy danh sách cửa hàng, có bán sản phẩm Xe đạp X (dựa vào product_id)
-- và số lượng tồn kho trên 10 sản phẩm.

-- Create more stores

-------------------------------------Start tast 3---------------------------------


BEGIN
	DECLARE @idXeCanTim AS INT;
	SET @idXeCanTim = 12; --Nhap id o day

	SELECT *
	FROM
		sales.stores AS st
	INNER JOIN
		sales.stocks AS stocks
	ON  
		stocks.product_id = @idXeCanTim AND
		stocks.quantity > 10 AND 
		stocks.store_id = st.store_id 
END


--------------------------------The end tast 3--------------------------------------------------


