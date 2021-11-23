CREATE DATABASE ERSystem;
GO
USE ERSystem;
GO
SET DATEFORMAT DMY;
GO

CREATE TABLE Staff
(
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL,
    sex INT NOT NULL,
    email NVARCHAR(100)
        UNIQUE,
    phone VARCHAR(10)
        UNIQUE,
    salary INT NOT NULL,
    position INT NOT NULL
        DEFAULT 0 -- 0: manager && 1: waiter && 2: chef
);
GO

CREATE TABLE Account
(
    id INT IDENTITY PRIMARY KEY,
    idStaff INT NOT NULL
        UNIQUE,
    userName VARCHAR(100)
        UNIQUE,
    passWord VARCHAR(1000) NOT NULL
        DEFAULT '2251022057731868917119086224872421513662' --PASSWORD: '123456' ENCODE

        FOREIGN KEY (idStaff) REFERENCES dbo.Staff (id)
);
GO

CREATE TABLE TableFood
(
    id INT IDENTITY PRIMARY KEY,
    name VARCHAR(100)
        UNIQUE NOT NULL
        DEFAULT N'No name',
    status VARCHAR(100) NOT NULL
        DEFAULT N'Empty' -- Empty || Using
);
GO

CREATE TABLE FoodCategory
(
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL
        DEFAULT N'No name'
);
GO

CREATE TABLE Food
(
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100)
        UNIQUE NOT NULL
        DEFAULT N'No name',
    idCategory INT NOT NULL,
    price FLOAT NOT NULL
        DEFAULT 0
);

ALTER TABLE dbo.Food ADD Orderquantity INT;

CREATE TABLE Bill
(
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATETIME NOT NULL
        DEFAULT GETDATE(),
    DateCheckOut DATETIME,
    idTable INT NOT NULL,
    discount INT
        DEFAULT 0,
    totalPrice FLOAT
        DEFAULT 0,
    status INT NOT NULL
        DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán	

        FOREIGN KEY (idTable) REFERENCES dbo.TableFood (id)
);
GO

CREATE TABLE BillInfo
(
    id INT IDENTITY PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    description NVARCHAR(100),
    count INT NOT NULL
        DEFAULT 0,
    status INT
        DEFAULT 0
        FOREIGN KEY (idBill) REFERENCES dbo.Bill (id),
    FOREIGN KEY (idFood) REFERENCES dbo.Food (id)
);
GO

--Thêm NV
INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Duy Phúc',              -- name - nvarchar(100)
    1,                        -- sex - bit
    '19522038@gm.uit.edu.vn', -- email - varchar(100)
    '1234',                   -- phone - varchar(100)
    10000,                    -- salary - int
    0                         -- position - int
    );
GO
INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Doãn Thịnh',        -- name - nvarchar(100)
    1,                    -- sex - bit
    '1952@gm.uit.edu.vn', -- email - varchar(100)
    '1351351',            -- phone - varchar(100)
    10000,                -- salary - int
    1                     -- position - int
    );
GO
INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Xuân Thái',              -- name - nvarchar(100)
    1,                         -- sex - bit
    '19wr23r52@gm.uit.edu.vn', -- email - varchar(100)
    '1232342',                 -- phone - varchar(100)
    10000,                     -- salary - int
    2                          -- position - int
    );
GO
INSERT INTO dbo.Staff
(
    name,
    sex,
    email,
    phone,
    salary,
    position
)
VALUES
(   N'Hữu Phát',             -- name - nvarchar(100)
    1,                       -- sex - bit
    '195r3r2@gm.uit.edu.vn', -- email - varchar(100)
    '122342334',             -- phone - varchar(100)
    10000,                   -- salary - int
    1                        -- position - int
    );
GO

--Thêm TK
INSERT INTO dbo.Account
(
    idStaff,
    userName
)
VALUES
(1, 'manager');
GO
INSERT INTO dbo.Account
(
    idStaff,
    userName
)
VALUES
(2, 'waiter');
GO
INSERT INTO dbo.Account
(
    idStaff,
    userName
)
VALUES
(3, 'chef');
GO

-- thêm category
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Súp');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Rau');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Nộm, Salad');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Thêm');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Gà');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Ba Ba');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Cá lăng');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Cá hồi');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Trâu');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Bò');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Dê');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Ếch');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Ốc');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Vịt');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Lẩu');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Bia');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Rượu');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Nước');
INSERT dbo.FoodCategory
(
    name
)
VALUES
(N'Tráng miệng');
GO

-- thêm món ăn
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Súp cá hồi', 1, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Súp cua', 1, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Súp hải sản', 1, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Súp gà ngô kem', 1, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rau bí xào', 2, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rau muống xào', 2, 30000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Mùng tơi xào', 2, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rau lang xào', 2, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Ngọn su su xào', 2, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rau bí xào nấm tươi', 2, 70000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Nộm sứa phồng tôm', 3, 60000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Nộm củ quả (Dưa góp)', 3, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Nộm rau má', 3, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Nộm hoa chuối', 3, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Salad rau trộn cá ngừ', 3, 100000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Salad rau mầm', 3, 50000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Salad củ quả', 3, 100000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Chả ram bắp', 4, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Khoai tây chiên', 4, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Bánh bao chiên', 4, 30000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà nướng ngũ vị', 5, 350000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lườn gà xào nấm hương', 5, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà xào nấm tươi', 5, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà hấp lá chanh', 5, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà hầm thuốc bắc', 5, 270000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gỏi gà lá chanh chua ngọt', 5, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà nướng mật ong', 5, 350000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà nấu măng chua', 5, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà sốt dầu hào', 5, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà rang muối', 5, 200000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà đen H''Mông nướng mọi', 5, 500000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà đen H''Mông hấp', 5, 500000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gà đen H''Mông xào gừng', 5, 500000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu rượu vang', 6, 700000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Om chuối đậu', 6, 700000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rang muối', 6, 700000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Cá lăng rang muối', 7, 200000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Cá lăng nướng', 7, 200000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Cá lăng kho tộ', 7, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Cá lăng hấp', 7, 150000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Gỏi cá hồi', 8, 250000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Cá hồi sốt chanh leo', 8, 400000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Cá hồi nướng', 8, 400000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Bắp trâu rang muối', 9, 150000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Trâu xào cần', 9, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Trâu xào măng chua', 9, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Trâu xào lá lốt', 9, 150000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Trâu nướng tảng', 9, 150000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Bò xào lúc lắc', 10, 150000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Bò sốt tiêu đen', 10, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Bò kho bánh bao', 10, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Bò bít tết', 10, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Bò xào nấm tươi', 10, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Đuôi bò hầm thuốc bắc', 10, 270000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Đuôi bò thả lẩu', 10, 250000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Dê nướng tảng', 11, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Dê tái chanh', 11, 150000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Dê hấp tía tô', 11, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu dê', 11, 700000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Dê hầm hải sản', 11, 300000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Chân dê rang muối', 11, 160000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Chân dê hầm thuốc bắc', 11, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Dê xào lăn', 11, 180000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Ếch chiên bơ', 12, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Ếch xào lá lốt', 12, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Ếch rang muối', 12, 120000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Ốc hấp gừng', 13, 150000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Ốc xào chuối đậu', 13, 100000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Vịt rang muối', 14, 300000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Vịt quay', 14, 300000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Vịt nướng', 14, 300000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Vịt chiên cay', 14, 300000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Vịt om sấu', 14, 300000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu gà nấm tươi', 15, 550000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu gà đen', 15, 700000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu cua đồng', 15, 550000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu cá lăng', 15, 500000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu duôi bò', 15, 500000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu vịt măng cay', 15, 400000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu sườn', 15, 500000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu thập cẩm chua cay', 15, 700000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu cá chép', 15, 500000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu cá quả', 15, 400000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu cá tầm', 15, 700000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Lẩu ếch măng cay', 15, 400000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Sài Gòn', 16, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Heineken', 16, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'333', 16, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rượu gạo', 17, 30000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rượu ngô', 17, 40000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Rượu chuối hột', 17, 50000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Nước lọc', 18, 13000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Nước ngọt', 18, 15000);
INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(N'Trái cây theo mùa', 19, 30000);
GO

--Thêm bàn
DECLARE @i INT = 1;
WHILE @i <= 10
BEGIN
    INSERT dbo.TableFood
    (
        name
    )
    VALUES
    ('Table ' + CAST(@i AS NVARCHAR(100)));
    SET @i = @i + 1;
END;
GO

-- thêm bill
INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '01/01/2021', -- DateCheckIn - date
    '01/01/2021', -- DateCheckOut - date
    3,            -- idTable - int
    1             -- status - int
    );
INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '05/01/2021', -- DateCheckIn - date
    '05/01/2021', -- DateCheckOut - date
    2,            -- idTable - int
    1             -- status - int
    );
INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '01/02/2021', -- DateCheckIn - date
    '01/02/2021', -- DateCheckOut - date
    6,            -- idTable - int
    1             -- status - int
    );
INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '14/02/2001', -- DateCheckIn - date
    '14/02/2001', -- DateCheckOut - date
    3,            -- idTable - int
    1             -- status - int
    );
INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '01/03/2021', -- DateCheckIn - date
    '01/03/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '08/03/2021', -- DateCheckIn - date
    '08/03/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '01/04/2021', -- DateCheckIn - date
    '01/04/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '30/04/2021', -- DateCheckIn - date
    '30/04/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '01/05/2021', -- DateCheckIn - date
    '01/05/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '05/05/2021', -- DateCheckIn - date
    '05/05/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '01/06/2021', -- DateCheckIn - date
    '01/06/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '17/06/2021', -- DateCheckIn - date
    '17/06/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
	INSERT dbo.Bill
(
    DateCheckIn,
    DateCheckOut,
    idTable,
    status
)
VALUES
(   '01/07/2021', -- DateCheckIn - date
    '01/07/2021', -- DateCheckOut - date
    5,            -- idTable - int
    1             -- status - int
    );
GO

-- thêm bill info
INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    1, -- idFood - int
    2  -- count - int
    );
INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    3, -- idFood - int
    4  -- count - int
    );
INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   1, -- idBill - int
    5, -- idFood - int
    1  -- count - int
    );
INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   2, -- idBill - int
    1, -- idFood - int
    2  -- count - int
    );
INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   2, -- idBill - int
    6, -- idFood - int
    2  -- count - int
    );
INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   3, -- idBill - int
    5, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   4, -- idBill - int
    5, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   4, -- idBill - int
    15, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   5, -- idBill - int
    20, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   6, -- idBill - int
    5, -- idFood - int
    5  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   7, -- idBill - int
    17, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   7, -- idBill - int
    19, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   8, -- idBill - int
    21, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   9, -- idBill - int
    7, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   10, -- idBill - int
    17, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   11, -- idBill - int
    13, -- idFood - int
    3  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   12, -- idBill - int
    17, -- idFood - int
    2  -- count - int
    );
	INSERT dbo.BillInfo
(
    idBill,
    idFood,
    count
)
VALUES
(   13, -- idBill - int
    17, -- idFood - int
    2  -- count - int
    );
GO

--Procedure
CREATE PROC USP_Login
    @userName VARCHAR(100),
    @passWord VARCHAR(100)
AS
BEGIN
    SELECT *
    FROM dbo.Account
    WHERE userName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS
          AND passWord = @passWord COLLATE SQL_Latin1_General_CP1_CS_AS;
END;
GO


CREATE PROC USP_GetPositionByUserName @userName VARCHAR(100)
AS
BEGIN
    SELECT position
    FROM dbo.Account
        INNER JOIN dbo.Staff
            ON Staff.id = Account.idStaff
    WHERE userName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS;
END;
GO

CREATE PROC USP_InsertBill @idTable INT
AS
BEGIN
    INSERT dbo.Bill
    (
        DateCheckIn,
        DateCheckOut,
        idTable,
        status,
        discount
    )
    VALUES
    (GETDATE(), NULL, @idTable, 0, 0);
    UPDATE dbo.TableFood
    SET status = 'Using'
    WHERE id = @idTable;
END;
GO


CREATE PROC USP_InsertStaff
    @name NVARCHAR(100),
    @sex INT,
    @email NVARCHAR(100),
    @phone VARCHAR(10),
    @salary INT,
    @position INT
AS
BEGIN
    INSERT INTO dbo.Staff
    (
        name,
        sex,
        email,
        phone,
        salary,
        position
    )
    VALUES
    (@name, @sex, @email, @phone, @salary, @position);
END;
GO


CREATE PROC USP_InsertBillInfo
    @idBill INT,
    @idFood INT,
    @count INT,
    @des NVARCHAR(100)
AS
BEGIN

    DECLARE @isExistBillInfo INT;
    DECLARE @foodcount INT = 1;

    SELECT @isExistBillInfo = id,
           @foodcount = b.count
    FROM dbo.BillInfo AS b
    WHERE idBill = @idBill
          AND idFood = @idFood;

    IF (@isExistBillInfo > 0)
    BEGIN
        DECLARE @newCount INT = @foodcount + @count;
        IF (@newCount > 0)
        BEGIN
            UPDATE dbo.BillInfo
            SET count = @newCount
            WHERE idFood = @idFood;
            UPDATE dbo.BillInfo
            SET description = @des
            WHERE idFood = @idFood;
        END;
        ELSE
            DELETE dbo.BillInfo
            WHERE idBill = @idBill
                  AND idFood = @idFood;

    END;
    ELSE
    BEGIN
        INSERT dbo.BillInfo
        (
            idBill,
            idFood,
            count,
            description,
            status
        )
        VALUES
        (   @idBill, -- idBill - int
            @idFood, -- idFood - int
            @count,  -- count - int
            @des, 0);
    END;
END;
GO


CREATE PROC USP_SwitchTable
    @idTable1 INT,
    @idTable2 INT
AS
BEGIN

    DECLARE @idFirstBill INT;
    DECLARE @idSecondBill INT;

    DECLARE @isFirstTablEmpty INT = 1;
    DECLARE @isSecondTablEmpty INT = 1;

    DECLARE @discountTbl1 INT = 0;
    DECLARE @discountTbl2 INT = 0;

    SELECT @idSecondBill = id
    FROM dbo.Bill
    WHERE idTable = @idTable2
          AND status = 0;
    SELECT @idFirstBill = id
    FROM dbo.Bill
    WHERE idTable = @idTable1
          AND status = 0;

    SELECT @discountTbl1 = discount
    FROM dbo.Bill
    WHERE idTable = @idTable1
          AND status = 0;
    SELECT @discountTbl2 = discount
    FROM dbo.Bill
    WHERE idTable = @idTable2
          AND status = 0;

    PRINT @idFirstBill;
    PRINT @idSecondBill;
    PRINT '----------1';

    IF (@idFirstBill IS NULL)
    BEGIN
        PRINT '0000001';
        INSERT dbo.Bill
        (
            DateCheckIn,
            DateCheckOut,
            idTable,
            status,
            discount
        )
        VALUES
        (   GETDATE(), -- DateCheckIn - date
            NULL,      -- DateCheckOut - date
            @idTable1, -- idTable - int
            0, 0);

        SELECT @idFirstBill = MAX(id)
        FROM dbo.Bill
        WHERE idTable = @idTable1
              AND status = 0;

    END;

    SELECT @isFirstTablEmpty = COUNT(*)
    FROM dbo.BillInfo
    WHERE idBill = @idFirstBill;

    PRINT @idFirstBill;
    PRINT @idSecondBill;
    PRINT '----------2';

    IF (@idSecondBill IS NULL)
    BEGIN
        PRINT '0000002';
        INSERT dbo.Bill
        (
            DateCheckIn,
            DateCheckOut,
            idTable,
            status,
            discount
        )
        VALUES
        (   GETDATE(), -- DateCheckIn - date
            NULL,      -- DateCheckOut - date
            @idTable2, -- idTable - int
            0, 0);
        SELECT @idSecondBill = MAX(id)
        FROM dbo.Bill
        WHERE idTable = @idTable2
              AND status = 0;

    END;

    SELECT @isSecondTablEmpty = COUNT(*)
    FROM dbo.BillInfo
    WHERE idBill = @idSecondBill;

    PRINT @idFirstBill;
    PRINT @idSecondBill;
    PRINT '----------3';

    SELECT id
    INTO IDBillInfoTable
    FROM dbo.BillInfo
    WHERE idBill = @idSecondBill;

    UPDATE dbo.BillInfo
    SET idBill = @idSecondBill
    WHERE idBill = @idFirstBill;

    UPDATE dbo.BillInfo
    SET idBill = @idFirstBill
    WHERE id IN
          (
              SELECT * FROM IDBillInfoTable
          );

    UPDATE dbo.Bill
    SET discount = @discountTbl2
    WHERE id = @idFirstBill;

    UPDATE dbo.Bill
    SET discount = @discountTbl1
    WHERE id = @idSecondBill;

    DROP TABLE IDBillInfoTable;

    PRINT @isFirstTablEmpty;
    PRINT @isSecondTablEmpty;
    PRINT @discountTbl1;
    PRINT @discountTbl2;
    PRINT '----------4';
    IF (@isFirstTablEmpty = 0)
    BEGIN
        PRINT '1';
        DELETE dbo.Bill
        WHERE idTable = @idTable2;
        UPDATE dbo.TableFood
        SET status = N'Empty'
        WHERE id = @idTable2;
    END;
    IF (@isSecondTablEmpty = 0)
    BEGIN
        PRINT '2';
        DELETE dbo.Bill
        WHERE idTable = @idTable1;
        UPDATE dbo.TableFood
        SET status = N'Empty'
        WHERE id = @idTable1;
    END;
END;
GO


CREATE PROC USP_CheckOutBill
    @idTable INT,
    @totalPrice INT,
    @discount INT
AS
BEGIN
    UPDATE dbo.Bill
    SET DateCheckOut = GETDATE(),
        status = 1,
        totalPrice = @totalPrice,
        discount = @discount
    WHERE idTable = @idTable
          AND status = 0;

    UPDATE dbo.TableFood
    SET status = 'Empty'
    WHERE id = @idTable;
END;
GO

CREATE PROC USP_GetIdByUserName @userName VARCHAR(100)
AS
BEGIN
    SELECT Staff.id
    FROM dbo.Account
        INNER JOIN dbo.Staff
            ON Staff.id = Account.idStaff
    WHERE userName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS;
END;
GO