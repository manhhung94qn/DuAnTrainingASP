-- 1.	Lấy danh sách tất cả sản phẩm bao gồm các thông tin sau:
-- Mã SP, Tên sản phẩm, Tên Thương Hiệu, Loại sản phẩm, Năm sản xuất, Đơn giá.

SELECT 
	pro.product_id AS N'Mã sản phẩm',
	pro.product_name AS N'Tên sản phẩm',
	br.brand_name AS N'Thương hiệu',
	cate.category_name AS N'Loại sản phẩm',
	pro.model_year AS N'Năm sản xuất',
	pro.list_price AS N'Giá'
FROM 
	production.products AS pro
	INNER JOIN 
		production.brands AS br
	ON 
		pro.brand_id = br.brand_id
	INNER JOIN 
		production.categories AS cate
	ON 
		cate.category_id = pro.category_id