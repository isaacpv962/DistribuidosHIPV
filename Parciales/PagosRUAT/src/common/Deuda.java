package common;

import java.io.Serializable;

public class Deuda implements Serializable {
    private String ci;
    private int año;
    private String impuesto;
    private double monto;

    public Deuda(String ci, int año, String impuesto, double monto) {
        this.ci = ci;
        this.año = año;
        this.impuesto = impuesto;
        this.monto = monto;
    }

 
    public String getCi() { return ci; }
    public int getAño() { return año; }
    public String getImpuesto() { return impuesto; }
    public double getMonto() { return monto; }

    @Override
    public String toString() {
        return "Deuda{" +
                "ci='" + ci + '\'' +
                ", año=" + año +
                ", impuesto='" + impuesto + '\'' +
                ", monto=" + monto +
                '}';
    }
}