from sqlalchemy.orm import Session
from models.models import Supplier
from schemas.supplier import SupplierCreate, SupplierUpdate


def get_all_suppliers(db: Session):
    return db.query(Supplier).all()


def get_supplier_by_id(db: Session, supplier_id: int):
    return db.query(Supplier).filter(Supplier.id == supplier_id).first()


def create_supplier(db: Session, supplier_data: SupplierCreate):
    supplier = Supplier(**supplier_data.dict())
    db.add(supplier)
    db.commit()
    db.refresh(supplier)
    return supplier


def update_supplier(db: Session, supplier_id: int, supplier_data: SupplierUpdate):
    supplier = db.query(Supplier).filter(Supplier.id == supplier_id).first()
    if not supplier:
        return None
    for key, value in supplier_data.dict().items():
        setattr(supplier, key, value)
    db.commit()
    db.refresh(supplier)
    return supplier


def delete_supplier(db: Session, supplier_id: int):
    supplier = db.query(Supplier).filter(Supplier.id == supplier_id).first()
    if not supplier:
        return None
    db.delete(supplier)
    db.commit()
    return supplier
