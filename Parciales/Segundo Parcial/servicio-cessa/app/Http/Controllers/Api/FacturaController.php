<?php

namespace App\Http\Controllers\Api;

use App\Http\Controllers\Controller;
use App\Models\Factura;
use Illuminate\Http\Request;

class FacturaController extends Controller
{
    // GET /api/facturas
    public function index()
    {
        return response()->json(Factura::all(), 200);
    }

    // GET /api/facturas/{id}
    public function show($id)
    {
        $factura = Factura::find($id);
        if (!$factura) {
            return response()->json(['message' => 'Factura no encontrada'], 404);
        }
        return response()->json($factura, 200);
    }

    // POST /api/facturas
    public function store(Request $request)
    {
        $data = $request->validate([
            'ci'       => 'required|string',
            'deudaId'  => 'required|integer',
            'concepto' => 'required|string',
            'monto'    => 'required|numeric',
            'fecha_pago' => 'required|date',
        ]);

        $factura = Factura::create($data);
        return response()->json($factura, 201);
    }

    // PUT /api/facturas/{id}
    public function update(Request $request, $id)
    {
        $factura = Factura::find($id);
        if (!$factura) {
            return response()->json(['message' => 'Factura no encontrada'], 404);
        }

        $data = $request->validate([
            'ci'       => 'sometimes|required|string',
            'deudaId'  => 'sometimes|required|integer',
            'concepto' => 'sometimes|required|string',
            'monto'    => 'sometimes|required|numeric',
            'fecha_pago' => 'sometimes|required|date',
        ]);

        $factura->update($data);
        return response()->json($factura, 200);
    }

    // DELETE /api/facturas/{id}
    public function destroy($id)
    {
        $deleted = Factura::destroy($id);
        if ($deleted) {
            return response()->json(null, 204);
        }
        return response()->json(['message' => 'Factura no encontrada'], 404);
    }
}
