<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
    Schema::create('facturas', function (Blueprint $table) {
    $table->id();
    $table->string('ci', 20);
    $table->unsignedInteger('deudaId');
    $table->string('concepto', 255);
    $table->decimal('monto', 10, 2);
    $table->date('fecha_pago');
    $table->timestamps();
    });
  
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('facturas');
    }
};
