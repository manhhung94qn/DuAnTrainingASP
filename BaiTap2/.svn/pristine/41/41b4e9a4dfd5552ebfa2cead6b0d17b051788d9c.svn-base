CREATE DATABASE BikeStores;
GO
USE BikeStores;
GO
CREATE SCHEMA sales;
GO
CREATE SCHEMA production;
GO
CREATE TABLE sales.stores(
	store_id INT IDENTITY (1,1) PRIMARY KEY,
	store_name NVARCHAR(255) NOT NULL,
	phone VARCHAR(25),
	email VARCHAR(255),
	street NVARCHAR(255),
	city NVARCHAR(255),
	zip_code VARCHAR(5)
);
GO
CREATE TABLE sales.staffs (
	staff_id INT IDENTITY (1,1) PRIMARY KEY,
	first_name NVARCHAR(50) NOT NULL,
	last_name NVARCHAR(50) NOT NULL,
	email VARCHAR(255) NOT NULL UNIQUE,
	phone VARCHAR(25),
	active TINYINT NOT NULL,
	store_id INT NOT NULL,
	manager_id INT,
	FOREIGN KEY (store_id)
		REFERENCES sales.stores (store_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (manager_id)
		REFERENCES sales.staffs
		ON DELETE NO ACTION ON UPDATE NO ACTION,
);
GO
CREATE TABLE production.categories(
	category_id INT IDENTITY (1,1) PRIMARY KEY,
	category_name VARCHAR(255) NOT NULL
);
GO 
CREATE TABLE production.brands (
	brand_id INT IDENTITY (1,1) PRIMARY KEY,
	brand_name VARCHAR(255) NOT NULL,
);
GO
CREATE TABLE production.products (
	product_id INT IDENTITY (1,1) PRIMARY KEY,
	product_name NVARCHAR(255) NOT NULL,
	brand_id INT NOT NULL,
	model_year SMALLINT NOT NULL,
	category_id int NOT NULL,
	list_price DECIMAL (10,2) NOT NULL,
	FOREIGN KEY (category_id) 
		REFERENCES production.categories (category_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (brand_id)
		REFERENCES production.brands (brand_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
);
GO
CREATE TABLE sales.customers (
	customer_id INT IDENTITY (1,1) PRIMARY KEY,
	first_name NVARCHAR(255) NOT NULL,
	last_name NVARCHAR(255) NOT NULL,
	phone VARCHAR(25),
	email VARCHAR(255) NOT NULL,
	street NVARCHAR(255),
	city NVARCHAR(255),
	zip_code VARCHAR(5)
);
GO
CREATE TABLE sales.orders (
	order_id INT IDENTITY (1,1) PRIMARY KEY,
	customer_id INT,
	order_status TINYINT NOT NULL,
	-- order status: 1 = Đang đợi; 2= đang sử lý; 3= từ chối, 4= đã giao
	oder_date DATE NOT NULL,
	required_date DATE NOT NULL,
	shipped_date DATE,
	store_id INT NOT NULL,
	staff_id INT NOT NULL,
	FOREIGN KEY (customer_id) 
		REFERENCES sales.customers(customer_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (store_id)
		REFERENCES sales.stores (store_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (staff_id)
		REFERENCES sales.staffs(staff_id)		
		ON DELETE NO ACTION ON UPDATE NO ACTION,
);
GO
CREATE TABLE sales.order_item(
	order_id INT,
	item_id INT IDENTITY,
	product_id INT NOT NULL,
	quantity INT NOT NULL,
	list_price DECIMAL (10,2) NOT NULL,
	PRIMARY KEY (order_id,item_id),
	FOREIGN KEY (order_id)
		REFERENCES sales.orders(order_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (product_id) 
		REFERENCES production.products(product_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
);

CREATE TABLE sales.stocks(
	store_id INT,
	product_id INT,
	quantity INT,
	PRIMARY KEY(store_id, product_id),
	FOREIGN KEY (store_id)
		REFERENCES sales.stores (store_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (product_id)
		REFERENCES production.products (product_id)
		ON DELETE CASCADE ON UPDATE CASCADE,
);

--Inset data for category
--Insert sigle row
INSERT INTO production.categories
        ( category_name )
VALUES  (
          'Children Bicycles'  -- category_name - varchar(255)
          )
--insert mutiple rows
INSERT INTO production.categories
        ( category_name )
VALUES  
		(
			'Comfort Bicycles'  -- category_name - varchar(255)
        ),
		(
			'Electronic Bicycles'
		);

-- insert data for brands

INSERT INTO production.brands
        ( brand_name )
VALUES  
		('Thong Nhat'),
		('Asama'),
		('Honda');

--Insert data for product

INSERT INTO production.products
        ( product_name ,
          brand_id ,
          model_year ,
          category_id ,
          list_price
        )
VALUES  (
			N'TRK FL2401',
			2,
			2019,
			2,
			2900000			
		),
		(
			N'Honda M8',
			3,
			2019,
			3,
			13590000
		)
		;
-- Add more one product of Vn
INSERT INTO production.products
        ( product_name ,
          brand_id ,
          model_year ,
          category_id ,
          list_price
        )
VALUES  (
          N'Thống Nhất GN06-26' , -- product_name - nvarchar(255)
          1 , -- brand_id - int
          2019 , -- model_year - smallint
          2 , -- category_id - int
          1950000  -- list_price - decimal
        )

-- Add store, Must have a new store to start selling and 
INSERT INTO sales.stores
        ( 
          store_name ,
          phone ,
          email ,
          street ,
          city ,
          zip_code
        )
VALUES  ( 
          N'Hùng King Tân Phú' , -- store_name - nvarchar(255)
          '0344895969' , -- phone - varchar(25)
          'manhhung94qn@gmail.com' , -- email - varchar(255)
          N'Hòa Bình' , -- street - nvarchar(255)
          N'Hồ Chí Minh' , -- city - nvarchar(255)
          '70000'  -- zip_code - varchar(5)
        ),
		( 
          N'Hùng King Bình Chánh' , -- store_name - nvarchar(255)
          '0344895969' , -- phone - varchar(25)
          'manhhung94qn@gmail.com' , -- email - varchar(255)
          N'Bình Chánh' , -- street - nvarchar(255)
          N'Hồ Chí Minh' , -- city - nvarchar(255)
          '70000'  -- zip_code - varchar(5)
        )

-- Now will add to staff to sell.
INSERT INTO sales.staffs
        ( 
          first_name ,
          last_name ,
          email ,
          phone ,
          active ,
          store_id ,
          manager_id
        )
VALUES  (
          N'Mạnh Hùng' , -- first_name - nvarchar(50)
          N'Đào' , -- last_name - nvarchar(50)
          'manhhung94qn@gmail.com' , -- email - varchar(255)
          '0344895969' , -- phone - varchar(25)
          10 , -- active - tinyint
          1 , -- store_id - int
          1  -- manager_id - int
        ),
		(
          N'Mạnh Khả' , -- first_name - nvarchar(50)
          N'Đào' , -- last_name - nvarchar(50)
          'manhkha94qn@gmail.com' , -- email - varchar(255)
          '0344895969' , -- phone - varchar(25)
          1 , -- active - tinyint
          2 , -- store_id - int
          1  -- manager_id - int
        )


-- Create a customer to have a buyer
INSERT INTO sales.customers
        ( 
          first_name ,
          last_name ,
          phone ,
          email ,
          street ,
          city ,
          zip_code
        )
VALUES  (
          N'Napoleon' , -- first_name - nvarchar(255)
          N'Bonaparte' , -- last_name - nvarchar(255)
          '0999999999' , -- Số của chú thì phải đẹp ko là ko được với chú nha
          'napoleon@gmail.com' , -- email chính chủ nè
          N'Tô Ký' , -- Dưới chân cầu vượt quan trung :))))
          N'Hồ Chí Minh' , -- Mới dọn qua ở VN
          '70000'  -- zip_code - varchar(5)
        ),
		(
          N'Leonardo' , -- first_name - nvarchar(255)
          N'Da Vinci' , -- last_name - nvarchar(255)
          '0111111111' , -- Số của họa sỹ thì phải đẹp ko được kém số của vua nhé
          'leonardo@gmail.com' , -- email chính chủ nè
          N'Hòa Bình' , 
          N'Hồ Chí Minh' , -- Mới dọn qua ở VN
          '70000'  -- zip_code - varchar(5)
        );

-- Now add a stock to container product
INSERT INTO sales.stocks
        ( store_id,product_id, quantity )
VALUES  (	1, -- Container at Tan Phu
			1, -- product_id - int
			5  -- quantity - int, xe asama dang ban chay nen cho sap het hang :)))
          ),
		  (
			1,
		    2, -- product_id - int
            20  -- quantity - int
          ),
		  (
			1,
			3, -- product_id - int
			1  -- quantity - int, xe Vn nen uu tien 
          );

SELECT * FROM production.brands;
SELECT * FROM production.categories;
SELECT * FROM production.products;
-- Show customers
SELECT last_name AS N'Họ', first_name AS N'Tên' FROM sales.customers;

-- Sho manager
SELECT * FROM sales.staffs WHERE staff_id=manager_id;

--add two customers at Ha Noi
INSERT INTO sales.customers
        ( 
          first_name ,
          last_name ,
          phone ,
          email ,
          street ,
          city ,
          zip_code
        )
VALUES  (
          N'Thị C' , -- first_name - nvarchar(255)
          N'Nguyễn' , -- last_name - nvarchar(255)
          '030300300' , -- Số của chú thì phải đẹp ko là ko được với chú nha
          'nguyenthic@gmail.com' , -- email chính chủ nè
          N'Hùng Vương' , -- Dưới chân cầu vượt quan trung :))))
          N'Hà Nội' , -- Mới dọn qua ở VN
          '80000'  -- zip_code - varchar(5)
        ),
		(
          N'Van A' , -- first_name - nvarchar(255)
          N'Le' , -- last_name - nvarchar(255)
          '0101010101' , -- Số của họa sỹ thì phải đẹp ko được kém số của vua nhé
          'levana@gmail.com' , -- email chính chủ nè
          N'Đống Đa' , 
          N'Hà Nội' , -- Mới dọn qua ở VN
          '80000'  -- zip_code - varchar(5)
        ),
		(
          N'Thu Ha' , -- first_name - nvarchar(255)
          N'Mai' , -- last_name - nvarchar(255)
          '030300300' , -- Số của chú thì phải đẹp ko là ko được với chú nha
          'maithuha@gmail.com' , -- email chính chủ nè
          N'Hùng Vương' , -- Dưới chân cầu vượt quan trung :))))
          N'Hà Nội' , -- Mới dọn qua ở VN
          '80000'  -- zip_code - varchar(5)
        ),
		(
          N'Đông Xuân' , -- first_name - nvarchar(255)
          N'Lê' , -- last_name - nvarchar(255)
          '0101010101' , -- Số của họa sỹ thì phải đẹp ko được kém số của vua nhé
          'ledongxuan@gmail.com' , -- email chính chủ nè
          N'Đống Đa' , 
          N'Đà Nẵng' , -- Mới dọn qua ở VN
          '60000'  -- zip_code - varchar(5)
        );

-- Bây giờ sẽ chọn điếm xem mỗi thành phố có bao nhiêu khách hàng.

SELECT city AS N'Thành Phố', COUNT(*) AS N'Số Lượng'
FROM
	sales.customers
GROUP BY
	city
;
-- In ra xem thành phố nào có nhiều hơn 1 khách hàng và sắp theo so luong
SELECT city AS N'Thành Phố', COUNT(*) AS N'Số lượng'
FROM sales.customers
GROUP BY city
HAVING COUNT(*)>1
ORDER BY COUNT(*);

SELECT  last_name + ' ' + first_name  AS N'Ten', phone AS N'SDT', street AS 'Dia Chi', city AS 'TP'
FROM sales.customers
ORDER BY
	city,
	first_name DESC;

SELECT * 
FROM sales.customers
ORDER BY 
	LEN(last_name);
-- in ra h ten va sap theo thu tu thanh pho tang dan nhung ho thi giam dan
SELECT last_name,first_name,city
FROM sales.customers
ORDER BY
	3 ASC,
	1 DESC;

SELECT 
	pro.product_id AS N'Mã sản phẩm', 
	pro.product_name AS N'Tên sản phẩm',
	br.brand_name AS N'Tên thương hiệu',
	cate.category_name AS N'Loại sản phẩm',
	pro.model_year AS N'Năm sản xuất',
	pro.list_price AS N'Đơn giá'
FROM 
	production.products AS pro, 
	production.brands AS br, 
	production.categories AS cate
WHERE
	(pro.product_id = br.brand_id) AND (pro.category_id = cate.category_id);
	
