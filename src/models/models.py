from sqlalchemy import Column, Integer, String, Text, Boolean, ForeignKey, DateTime, Numeric, UniqueConstraint
from sqlalchemy.ext.declarative import declarative_base
from sqlalchemy.orm import relationship
from datetime import datetime

Base = declarative_base()


class User(Base):
    __tablename__ = "users"

    id = Column(Integer, primary_key=True)
    full_name = Column(Text, nullable=False)
    email = Column(String(256))
    role_id = Column(Integer, ForeignKey("roles.id"), nullable=False)
    phone_number = Column(String(50))


class Supplier(Base):
    __tablename__ = "suppliers"

    id = Column(Integer, primary_key=True)
    name = Column(Text, nullable=False)
    email = Column(Text)
    phone = Column(Text)
    address = Column(Text)
    country_id = Column(Integer, ForeignKey("countries.id"), nullable=False)
    region_id = Column(Integer, ForeignKey("regions.id"), nullable=False)
    area_id = Column(Integer, ForeignKey("areas.id"), nullable=False)
    longitude = Column(Numeric)
    latitude = Column(Numeric)
    user_id = Column(Integer, ForeignKey("users.id"), nullable=False)
    is_active = Column(Boolean, default=True)


class Warehouse(Base):
    __tablename__ = "warehouses"

    id = Column(Integer, primary_key=True)
    name = Column(Text, nullable=False)
    country_id = Column(Integer, ForeignKey("countries.id"), nullable=False)
    region_id = Column(Integer, ForeignKey("regions.id"), nullable=False)
    area_id = Column(Integer, ForeignKey("areas.id"), nullable=False)
    longitude = Column(Numeric)
    latitude = Column(Numeric)


class Product(Base):
    __tablename__ = "products"

    id = Column(Integer, primary_key=True)
    code = Column(String(50), nullable=False)
    name = Column(Text, nullable=False)
    description = Column(Text)


class Contract(Base):
    __tablename__ = "contracts"

    id = Column(Integer, primary_key=True)
    supplier_id = Column(Integer, ForeignKey("suppliers.id"), nullable=False)
    delivery_terms = Column(Text)
    penalty_conditions = Column(Text)
    created_at = Column(DateTime, default=datetime.utcnow)


class ContractProduct(Base):
    __tablename__ = "contract_products"
    __table_args__ = (UniqueConstraint("contract_id", "product_id"),)

    id = Column(Integer, primary_key=True)
    contract_id = Column(Integer, ForeignKey("contracts.id", ondelete="CASCADE"), nullable=False)
    product_id = Column(Integer, ForeignKey("products.id", ondelete="CASCADE"), nullable=False)
    expected_quantity = Column(Integer, nullable=False)


class Shipment(Base):
    __tablename__ = "shipments"

    id = Column(Integer, primary_key=True)
    supplier_id = Column(Integer, ForeignKey("suppliers.id"), nullable=False)
    warehouse_id = Column(Integer, ForeignKey("warehouses.id"), nullable=False)
    contract_id = Column(Integer, ForeignKey("contracts.id"), nullable=False)
    details = Column(Text)
    status_id = Column(Integer, ForeignKey("statuses.id"), nullable=False)
    accepted_at = Column(DateTime, nullable=False)
    delivery_started_at = Column(DateTime, nullable=False)
    estimated_delivery_at = Column(DateTime, nullable=False)
    risk_level_id = Column(Integer, ForeignKey("risk_levels.id"), default=1)


class ContractIssue(Base):
    __tablename__ = "contract_issues"

    id = Column(Integer, primary_key=True)
    contract_id = Column(Integer, ForeignKey("contracts.id"), nullable=False)
    reason = Column(Text, nullable=False)
    estimated_delay_minutes = Column(Integer, default=0)


class ShipmentIssue(Base):
    __tablename__ = "shipment_issues"

    id = Column(Integer, primary_key=True)
    shipment_id = Column(Integer, ForeignKey("shipments.id"), nullable=False)
    reason = Column(Text, nullable=False)
    estimated_delay_minutes = Column(Integer, default=0)

class Country(Base):
    __tablename__ = "countries"
    id = Column(Integer, primary_key=True)

class Region(Base):
    __tablename__ = "regions"
    id = Column(Integer, primary_key=True)

class Area(Base):
    __tablename__ = "areas"
    id = Column(Integer, primary_key=True)

class Role(Base):
    __tablename__ = "roles"
    id = Column(Integer, primary_key=True)

class Status(Base):
    __tablename__ = "statuses"
    id = Column(Integer, primary_key=True)

class RiskLevel(Base):
    __tablename__ = "risk_levels"
    id = Column(Integer, primary_key=True)
