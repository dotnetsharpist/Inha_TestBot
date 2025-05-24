from fastapi import APIRouter, Depends, HTTPException
from sqlalchemy.orm import Session
from services import supplier_service as crud
from database.deps import get_db
from schemas.supplier import SupplierCreate, SupplierUpdate, SupplierOut
from typing import List

router = APIRouter(prefix="/suppliers", tags=["Suppliers"])


@router.get("/", response_model=List[SupplierOut])
def list_suppliers(db: Session = Depends(get_db)):
    return crud.get_all_suppliers(db)


@router.get("/{supplier_id}", response_model=SupplierOut)
def get_supplier(supplier_id: int, db: Session = Depends(get_db)):
    supplier = crud.get_supplier_by_id(db, supplier_id)
    if not supplier:
        raise HTTPException(status_code=404, detail="Supplier not found")
    return supplier


@router.post("/", response_model=SupplierOut)
def create_supplier(supplier: SupplierCreate, db: Session = Depends(get_db)):
    print(supplier.area_id)
    return crud.create_supplier(db, supplier)


@router.put("/{supplier_id}", response_model=SupplierOut)
def update_supplier(supplier_id: int, supplier: SupplierUpdate, db: Session = Depends(get_db)):
    updated = crud.update_supplier(db, supplier_id, supplier)
    if not updated:
        raise HTTPException(status_code=404, detail="Supplier not found")
    return updated


@router.delete("/{supplier_id}", response_model=SupplierOut)
def delete_supplier(supplier_id: int, db: Session = Depends(get_db)):
    deleted = crud.delete_supplier(db, supplier_id)
    if not deleted:
        raise HTTPException(status_code=404, detail="Supplier not found")
    return deleted
