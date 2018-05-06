-- Generated by Oracle SQL Developer Data Modeler 18.1.0.082.1035
--   at:        2018-04-13 20:44:37 EEST
--   site:      SQL Server 2012
--   type:      SQL Server 2012



CREATE TABLE brand (
    brand_id     INTEGER identity(1,1) NOT NULL,
    brand_name   VARCHAR(20) NOT NULL
)
       go

ALTER TABLE Brand ADD constraint brand_pk PRIMARY KEY CLUSTERED (Brand_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
        
    GO
    ALTER TABLE brand add constraint key_2 unique nonclustered(brand_name)
        go

CREATE TABLE category (
    category_id     INTEGER identity(1,1) NOT NULL,
    category_name   VARCHAR(10) NOT NULL
)
       go

ALTER TABLE Category ADD constraint category_pk PRIMARY KEY CLUSTERED (Category_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
        
    GO
    ALTER TABLE category add constraint categoryname_uk unique nonclustered(category_name)
        go

CREATE TABLE color (
    color_id     INTEGER identity(1,1) NOT NULL,
    color_code   VARCHAR(10) NOT NULL,
    color_name   VARCHAR(10) NOT NULL
)
       go

ALTER TABLE Color ADD constraint color_pk PRIMARY KEY CLUSTERED (Color_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
        
    GO
    ALTER TABLE color add constraint colorcode_uk unique nonclustered(color_code)
        go

CREATE TABLE images (
    image_url    VARCHAR(100) NOT NULL,
    product_id   INTEGER NOT NULL
)
       go

CREATE TABLE products (
    product_id     INTEGER identity(1,1) NOT NULL,
    name           VARCHAR(20) NOT NULL,
    price          DECIMAL(28) NOT NULL,
    size           VARCHAR(4),
    discount       INTEGER,
    for_what_age   INTEGER,
    second_hand    bit DEFAULT 1,
    user_id        INTEGER NOT NULL,
    category_id    INTEGER NOT NULL,
    color_id       INTEGER NOT NULL,
    brand_id       INTEGER NOT NULL
)
       go

ALTER TABLE Products ADD constraint products_pk PRIMARY KEY CLUSTERED (Product_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
        go

CREATE TABLE shopping_cart (
    user_id      INTEGER NOT NULL,
    product_id   INTEGER NOT NULL
)
       go

CREATE TABLE user_details (
    user_id         INTEGER NOT NULL,
    gender          CHAR,
    country         VARCHAR(20),
    city            VARCHAR(20),
    shoes_size      INTEGER,
    clothes_size    VARCHAR(4),
    balance         DECIMAL(28),
    phone_number    VARCHAR,
    date_of_birth   DATE
)
      
GO 

    


CREATE UNIQUE NONCLUSTERED INDEX 
    User_Details__IDX ON user_details ( user_id ) 
       go

CREATE TABLE users (
    user_id         INTEGER identity(1,1) NOT NULL,
    email_address   VARCHAR(20) NOT NULL,
    password        VARCHAR(20) NOT NULL,
    fisrt_name      VARCHAR(20) NOT NULL,
    last_name       VARCHAR(20) NOT NULL,
    administrator   bit DEFAULT 0
)
       go

ALTER TABLE Users ADD constraint users_pk PRIMARY KEY CLUSTERED (User_ID)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )
        
    GO
    ALTER TABLE users add constraint emailaddress_uk unique nonclustered(email_address)
        go

ALTER TABLE users
ADD CONSTRAINT minpasswordlength CHECK (DATALENGTH(password) >= 6)

ALTER TABLE Products
    ADD CONSTRAINT brandproductrelation FOREIGN KEY ( brand_id )
        REFERENCES brand ( brand_id )
ON DELETE NO ACTION 
       go

ALTER TABLE Products
    ADD CONSTRAINT categoryproductrelation FOREIGN KEY ( category_id )
        REFERENCES category ( category_id )
ON DELETE NO ACTION 
       go

ALTER TABLE Products
    ADD CONSTRAINT colorproductrelation FOREIGN KEY ( color_id )
        REFERENCES color ( color_id )
ON DELETE NO ACTION 
       go

ALTER TABLE Images
    ADD CONSTRAINT productimagesrelation FOREIGN KEY ( product_id )
        REFERENCES products ( product_id )
ON DELETE NO ACTION 
       go

ALTER TABLE Shopping_cart
    ADD CONSTRAINT productshoppingcartrelation FOREIGN KEY ( product_id )
        REFERENCES products ( product_id )
ON DELETE NO ACTION 
       go

ALTER TABLE Products
    ADD CONSTRAINT userproductrelation FOREIGN KEY ( user_id )
        REFERENCES users ( user_id )
ON DELETE NO ACTION 
       go

ALTER TABLE User_Details
    ADD CONSTRAINT userrelation FOREIGN KEY ( user_id )
        REFERENCES users ( user_id )
ON DELETE NO ACTION 
       go

ALTER TABLE Shopping_cart
    ADD CONSTRAINT usershoppingcart FOREIGN KEY ( user_id )
        REFERENCES users ( user_id )
ON DELETE NO ACTION 
       go