-- 5.	Viết stored procedure,
-- Tìm kiếm sản phẩm dự vào các điều kiện sau:
-- -	Tên sản phẩm ( like )
-- -	Tên chi nhánh (like)
-- -	Tên loại sp (like)
-- -	Năm sản xuất (from~to)
-- -	Giá bán (from~to)
-- -	Tổng số lượng tồn kho (from~to)
-- Chú ý: Nếu không nhập điều kiện XYZ, thì xem như không tìm theo điều kiện đó.

EXEC TestFindProduct @nameProduct= N'Thống', @nameStore = N'Quận'
-------------------------Tạo Proreduce
ALTER PROCEDURE TestFindProduct(
		@nameProduct AS NVARCHAR(MAX) = NULL,
		@nameStore AS NVARCHAR(MAX) = NULL,
		@nameCate AS NVARCHAR(MAX) = NULL,
		@minYear AS INT = NULL,
		@maxYear AS INT = NULL,
		@minPrice AS INT = NULL,
		@maxPrice AS INT = NULL,
		@minQuantity AS INT = NULL,
		@maxQuantity AS INT = NULL
		)
AS BEGIN
		DECLARE @res NVARCHAR(MAX) ='SELECT * FROM production.products AS Pro
									INNER JOIN production.categories AS Cate
									ON Cate.category_id = Pro.category_id
									INNER JOIN production.brands AS Bra
									ON Bra.brand_id = Pro.brand_id
									INNER JOIN sales.stocks AS Stoc
									ON Stoc.product_id = Pro.product_id
									INNER JOIN sales.stores AS Stor
									ON Stor.store_id = Stoc.store_id
									WHERE 1=1'
		BEGIN
			IF @nameProduct IS NOT NULL
			BEGIN
				SET @res += N'AND Pro.product_name LIKE N'+ CHAR(39) + N'%' + @nameProduct + N'%' + CHAR(39)
			END
			IF @nameStore IS NOT NULL
			BEGIN
				SET @res += N' AND Stor.store_name LIKE N'+ CHAR(39) + N'%' + @nameStore + N'%' + CHAR(39)
			END
			IF @nameCate IS NOT NULL
			BEGIN
				SET @res += N' AND cate.category_name LIKE N'+ CHAR(39) + N'%' + @nameCate + N'%' + CHAR(39)
			END
			IF @minYear IS NOT NULL
			BEGIN
				SET @res += N' AND Pro.model_year >= '+ STR(@minYear)
			END
			IF @maxYear IS NOT NULL
			BEGIN
				SET @res += N' AND Pro.model_year <= '+ STR(@maxYear)
			END
			IF @minPrice IS NOT NULL
			BEGIN
				SET @res += N' AND Pro.list_price >= '+ STR(@minPrice)
			END
			IF @maxPrice IS NOT NULL
			BEGIN
				SET @res += N' AND Pro.list_price <= '+ STR(@maxPrice)
			END
			IF @minQuantity IS NOT NULL
			BEGIN
				SET @res += N' AND Stoc.quantity >= '+ STR(@minQuantity)
			END
			IF @maxQuantity IS NOT NULL
			BEGIN
				SET @res += N' AND Stoc.quantity <= '+ STR(@maxQuantity)
			END
		END
		EXEC (@res)
END;




















