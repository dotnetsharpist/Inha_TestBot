from pydantic import BaseModel
from typing import Optional
from datetime import datetime

class SupplierBase(BaseModel):
    name: str
    email: Optional[str] = None
    phone: Optional[str] = None
    address: Optional[str] = None
    country_id: int
    region_id: int
    area_id: int
    longitude: Optional[float] = None
    latitude: Optional[float] = None
    user_id: int
    is_active: Optional[bool] = True


class SupplierCreate(SupplierBase):
    pass


class SupplierUpdate(SupplierBase):
    pass


class SupplierOut(SupplierBase):
    id: int
    created_at: datetime

    class Config:
        orm_mode = True
