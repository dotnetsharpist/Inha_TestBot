-- Role table
CREATE TABLE roles (
    id INT PRIMARY KEY,
    name TEXT NOT NULL
);

INSERT INTO roles (id, name) VALUES
(1, 'Admin'),
(2, 'UzAutoMotors'),
(3, 'Supplier');

-- Status table
CREATE TABLE statuses (
    id INT PRIMARY KEY,
    name TEXT NOT NULL
);

INSERT INTO statuses (id, name) VALUES
(1, 'Created'),
(2, 'Accepted'),
(3, 'OnDelivery'),
(4, 'Delivered'),
(5, 'Completed'),
(6, 'Rejected');

-- Location tables
CREATE TABLE countries (
    id INT PRIMARY KEY,
    name TEXT NOT NULL
);

INSERT INTO countries (id, name) 
VALUES
(1, 'Ubzekistan')

CREATE TABLE regions (
    id INT PRIMARY KEY,
    name TEXT NOT NULL,
    country_id INT NOT NULL REFERENCES countries(id)
);

insert into regions(id, name, country_id)
VALUES
(1, 'Toshkent shahri', 1)


CREATE TABLE areas (
    id INT PRIMARY KEY,
    name TEXT NOT NULL,
    region_id INT NOT NULL REFERENCES regions(id)
);

insert into areas(id, name, region_id)
VALUES
(1, 'Shayhontohur tumani', 1)


-- Risk levels
CREATE TABLE risk_levels (
    id INT PRIMARY KEY,
    name TEXT NOT NULL
);

INSERT INTO risk_levels (id, name) VALUES
(1, 'Low'),
(2, 'Medium'),
(3, 'High');

-- Users
CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    full_name TEXT NOT NULL,
    email VARCHAR(256),
    role_id INT NOT NULL REFERENCES roles(id),
    phone_number VARCHAR(50),
    password_hash TEXT not null,
    created_at TIMESTAMP NOT NULL DEFAULT NOW()
);

-- Suppliers
CREATE TABLE suppliers (
    id SERIAL PRIMARY KEY,
    name TEXT NOT NULL,
    email TEXT,
    phone TEXT, 
    address TEXT,
    country_id INT NOT NULL REFERENCES countries(id),
    region_id INT NOT NULL REFERENCES regions(id),
    area_id INT NOT NULL REFERENCES areas(id),
    longitude DECIMAL,
    latitude DECIMAL,
    user_id INT NOT NULL REFERENCES users(id),
    is_active BOOLEAN DEFAULT TRUE,
    created_at TIMESTAMP NOT NULL DEFAULT NOW()
);

-- Warehouses
CREATE TABLE warehouses (
    id SERIAL PRIMARY KEY,
    name TEXT NOT NULL,
    country_id INT NOT NULL REFERENCES countries(id),
    region_id INT NOT NULL REFERENCES regions(id),
    area_id INT NOT NULL REFERENCES areas(id),
    longitude DECIMAL,
    latitude DECIMAL,
    created_at TIMESTAMP NOT NULL DEFAULT NOW()
);

-- Products
CREATE TABLE products (
    id SERIAL PRIMARY KEY,
    code VARCHAR(50) NOT NULL,
    name TEXT NOT NULL,
    description TEXT,
    created_at TIMESTAMP DEFAULT NOW()
);

-- Contracts
CREATE TABLE contracts (
    id SERIAL PRIMARY KEY,
    supplier_id INT NOT NULL REFERENCES suppliers(id),
    delivery_terms TEXT,
    penalty_conditions TEXT,
    created_at TIMESTAMP DEFAULT NOW()
);

-- Order Products (Product inside contract)
CREATE TABLE contract_products (
    id SERIAL PRIMARY KEY,
    contract_id INT NOT NULL REFERENCES contracts(id) ON DELETE CASCADE,
    product_id INT NOT NULL REFERENCES products(id) ON DELETE CASCADE,
    expected_quantity INT NOT NULL,
    UNIQUE (contract_id, product_id)
);

-- Shipments
CREATE TABLE shipments (
    id SERIAL PRIMARY KEY,
    supplier_id INT NOT NULL REFERENCES suppliers(id),
    warehouse_id INT NOT NULL REFERENCES warehouses(id),
    contract_id INT NOT NULL REFERENCES contracts(id),
    details TEXT,
    status_id INT NOT NULL REFERENCES statuses(id),
    accepted_at TIMESTAMP NOT NULL,
    delivery_started_at TIMESTAMP NOT NULL,
    estimated_delivery_at TIMESTAMP NOT NULL,
    risk_level_id INT REFERENCES risk_levels(id) DEFAULT 1
);

-- Contract problems
CREATE TABLE contract_issues (
    id SERIAL PRIMARY KEY,
    contract_id INT NOT NULL REFERENCES contracts(id),
    reason TEXT NOT NULL,
    estimated_delay_minutes INT NOT NULL DEFAULT 0
);

-- Shipment problems
CREATE TABLE shipment_issues (
    id SERIAL PRIMARY KEY,
    shipment_id INT NOT NULL REFERENCES shipments(id),
    reason TEXT NOT NULL,
    estimated_delay_minutes INT NOT NULL DEFAULT 0
);