from fastapi import APIRouter, HTTPException
from typing import List, Optional
from pydantic import BaseModel
from datetime import datetime

# USER CONTROLLER
user_router = APIRouter(prefix="/user", tags=["User"])

class User(BaseModel):
    id: int
    full_name: str
    email: Optional[str] = None
    role_id: int
    phone_number: Optional[str] = None
    created_at: datetime = datetime.now()

users: List[User] = []

@user_router.post("/", response_model=User)
async def create_user(user: User):
    users.append(user)
    return user

@user_router.get("/", response_model=List[User])
async def list_users():
    return users

@user_router.get("/{user_id}", response_model=User)
async def get_user(user_id: int):
    for user in users:
        if user.id == user_id:
            return user
    raise HTTPException(status_code=404, detail="User not found")

@user_router.put("/{user_id}", response_model=User)
async def update_user(user_id: int, updated: User):
    for i, user in enumerate(users):
        if user.id == user_id:
            users[i] = updated
            return updated
    raise HTTPException(status_code=404, detail="User not found")

@user_router.delete("/{user_id}")
async def delete_user(user_id: int):
    for i, user in enumerate(users):
        if user.id == user_id:
            del users[i]
            return {"detail": "User deleted"}
    raise HTTPException(status_code=404, detail="User not found")


# You can copy-paste this template and change for:
# - Country
# - Region
# - Area
# - Supplier
# Let me know if you want me to auto-generate those too and combine them into this file.
