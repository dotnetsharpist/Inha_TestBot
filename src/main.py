from fastapi import FastAPI
from api.v1.SuppliersController import router as uzum_router
from api.v1 import SuppliersController


app = FastAPI()
app.include_router(uzum_router)
app.include_router(SuppliersController.router)