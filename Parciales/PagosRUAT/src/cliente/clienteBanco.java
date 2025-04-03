/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package cliente;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.Socket;
import java.util.Scanner;

public class clienteBanco {
    private static final String HOST = "localhost";
    private static final int PORT = 12345;

    public static void main(String[] args) {
        try (Socket socket = new Socket(HOST, PORT);
             PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
             BufferedReader in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
             Scanner scanner = new Scanner(System.in)) {
            
            System.out.println("Conectado al banco.");
            System.out.print("Ingrese su CI: ");
            String ci = scanner.nextLine();
            
            while (true) {
                System.out.println("\nOpciones para CI " + ci + ":");
                System.out.println("1. Consultar deudas");
                System.out.println("2. Pagar deuda");
                System.out.println("3. Salir");
                System.out.print("Seleccione opción: ");
                
                String opcion = scanner.nextLine();
                
                if (opcion.equals("3")) {
                    break;
                } 
                
                if (opcion.equals("1")) {
                    out.println("Deuda:" + ci);
                    
                    String respuesta = in.readLine();
                    if (respuesta.startsWith("Deuda:")) {
                        String[] deudas = respuesta.substring(6).split(";");
                        if (deudas[0].isEmpty()) {
                            System.out.println("No se encontraron deudas para este CI.");
                        } else {
                            System.out.println("\nDeudas encontradas:");
                            for (String deudaStr : deudas) {
                                String[] partes = deudaStr.split(",");
                                System.out.printf("Año: %s, Impuesto: %s, Monto: %s%n", 
                                    partes[0], partes[1], partes[2]);
                            }
                        }
                    }
                } else if (opcion.equals("2")) {
                    
                    out.println("Deuda:" + ci);
                    String respuestaDeudas = in.readLine();
                    
                    if (respuestaDeudas.startsWith("Deuda:")) {
                        String[] deudas = respuestaDeudas.substring(6).split(";");
                        if (deudas[0].isEmpty()) {
                            System.out.println("No hay deudas para pagar.");
                            continue;
                        }
                        
                        System.out.println("\nDeudas disponibles para pago:");
                        for (int i = 0; i < deudas.length; i++) {
                            String[] partes = deudas[i].split(",");
                            System.out.printf("%d. Año: %s, Impuesto: %s, Monto: %s%n", 
                                i+1, partes[0], partes[1], partes[2]);
                        }
                        
                        System.out.print("Seleccione el número de deuda a pagar: ");
                        int seleccion = Integer.parseInt(scanner.nextLine()) - 1;
                        
                        if (seleccion >= 0 && seleccion < deudas.length) {
                            String[] deudaSeleccionada = deudas[seleccion].split(",");
                            String año = deudaSeleccionada[0];
                            String impuesto = deudaSeleccionada[1];
                            String monto = deudaSeleccionada[2];
                            
                            out.println("Pagar:" + ci + ":" + año + ":" + impuesto + ":" + monto);
                            String respuestaPago = in.readLine();
                            
                            if (respuestaPago.startsWith("Pagar:")) {
                                boolean exito = Boolean.parseBoolean(respuestaPago.substring(6));
                                System.out.println(exito ? "Pago realizado con éxito" : "No se pudo realizar el pago (CI con observaciones)");
                            }
                        } else {
                            System.out.println("Selección inválida.");
                        }
                    }
                }
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}