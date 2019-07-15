--4.	Insert đồng thời 10 dòng dữ liệu products.
--(Dữ liệu tùy ý)

INSERT production.products
(
    product_name,
    brand_id,
    model_year,
    category_id,
    list_price
)
VALUES
(   N'Honda EB 19', -- product_name - nvarchar(255)
    3,   -- brand_id - int
    2019,   -- model_year - smallint
    4,   -- category_id - int
    12000000 -- list_price - decimal(10, 2)
    ),
	(   N'Suzuki EB 19', -- product_name - nvarchar(255)
    4,   -- brand_id - int
    2019,   -- model_year - smallint
    4,   -- category_id - int
    11250000 -- list_price - decimal(10, 2)
    ),
	(   N'Bicycles Children 2019', -- product_name - nvarchar(255)
    1,   -- brand_id - int
    2019,   -- model_year - smallint
    1,   -- category_id - int
    1000000 -- list_price - decimal(10, 2)
    ),
	(   N'Asama CB 19', -- product_name - nvarchar(255)
    2,   -- brand_id - int
    2019,   -- model_year - smallint
    2,   -- category_id - int
    1950000 -- list_price - decimal(10, 2)
    ),
	(   N'Asama CB 18', -- product_name - nvarchar(255)
    2,   -- brand_id - int
    2018,   -- model_year - smallint
    2,   -- category_id - int
    1800000 -- list_price - decimal(10, 2)
    ),
	(   N'Asama EL 19', -- product_name - nvarchar(255)
    2,   -- brand_id - int
    2019,   -- model_year - smallint
    4,   -- category_id - int
    10000000 -- list_price - decimal(10, 2)
    ),
	(   N'Asama EL 18', -- product_name - nvarchar(255)
    4,   -- brand_id - int
    2018,   -- model_year - smallint
    4,   -- category_id - int
    9500000 -- list_price - decimal(10, 2)
    ),
	(   N'Suzuki CB 19', -- product_name - nvarchar(255)
    4,   -- brand_id - int
    2019,   -- model_year - smallint
    2,   -- category_id - int
    2500000 -- list_price - decimal(10, 2)
    ),
	(   N'Suzuki CB 18', -- product_name - nvarchar(255)
    4,   -- brand_id - int
    2018,   -- model_year - smallint
    4,   -- category_id - int
    2000000 -- list_price - decimal(10, 2)
    ),
	(   N'Thong Nhat EB 19', -- product_name - nvarchar(255)
    1,   -- brand_id - int
    2019,   -- model_year - smallint
    4,   -- category_id - int
    11250000 -- list_price - decimal(10, 2)
    )
