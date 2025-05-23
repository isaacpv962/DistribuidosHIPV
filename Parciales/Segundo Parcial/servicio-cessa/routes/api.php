<?php
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\Api\FacturaController;

Route::get   ('/facturas',       [FacturaController::class, 'index']);
Route::get   ('/facturas/{id}',  [FacturaController::class, 'show']);
Route::post  ('/facturas',       [FacturaController::class, 'store']);
Route::put   ('/facturas/{id}',  [FacturaController::class, 'update']);
Route::delete('/facturas/{id}',  [FacturaController::class, 'destroy']);
