-- 2.	Lấy danh sách sản phẩm thuộc phân loại sản phẩm là Xe đạp điện (tùy dữ liệu DB), của thương hiệu Suzuki.



---------------------------Begin task-------------------

SELECT * 
FROM
	production.products AS pro
	INNER JOIN
		production.categories AS cate
	ON
		cate.category_name = 'Electronic Bicycles' AND 
		cate.category_id = pro.category_id 
	INNER JOIN production.brands
	ON
		brand_name = 'Suzuki' AND 
		brands.brand_id = pro.brand_id

-------------------------------End task----------------------------