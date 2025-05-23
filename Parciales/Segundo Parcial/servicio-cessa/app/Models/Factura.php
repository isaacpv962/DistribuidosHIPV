<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Factura extends Model
{
    protected $fillable = [
        'ci',
        'deudaId',
        'concepto',
        'monto',
        'fecha_pago',
    ];
}
