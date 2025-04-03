/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package banco;

import common.Deuda;
import ruat.IRuat;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.util.List;

public class servidorBanco {
    private static final int PORT = 12345;
    private static IRuat ruat;

    public static void main(String[] args) {
        try {
           
            Registry registry = LocateRegistry.getRegistry("localhost", 1099);
            ruat = (IRuat) registry.lookup("RUAT");
            
            
            try (ServerSocket serverSocket = new ServerSocket(PORT)) {
                System.out.println("Servidor Banco TCP iniciado en puerto " + PORT);
                
                while (true) {
                    new ClientHandler(serverSocket.accept()).start();
                }
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static class ClientHandler extends Thread {
        private Socket clientSocket;
        private PrintWriter out;
        private BufferedReader in;

        public ClientHandler(Socket socket) {
            this.clientSocket = socket;
        }

        public void run() {
            try {
                out = new PrintWriter(clientSocket.getOutputStream(), true);
                in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
                
                String inputLine;
                while ((inputLine = in.readLine()) != null) {
                    System.out.println("Comando recibido: " + inputLine);
                    String[] partes = inputLine.split(":");
                    String comando = partes[0];
                    
                    if (comando.equals("Deuda")) {
                        String ci = partes[1];
                        List<Deuda> deudas = ruat.buscar(ci);
                        StringBuilder respuesta = new StringBuilder("Deuda:");
                        for (Deuda deuda : deudas) {
                            respuesta.append(deuda.getAño()).append(",")
                                    .append(deuda.getImpuesto()).append(",")
                                    .append(deuda.getMonto()).append(";");
                        }
                        out.println(respuesta.toString());
                    } else if (comando.equals("Pagar")) {
                        String ci = partes[1];
                        int año = Integer.parseInt(partes[2]);
                        String impuesto = partes[3];
                        double monto = Double.parseDouble(partes[4]);
                        
                        Deuda deuda = new Deuda(ci, año, impuesto, monto);
                        boolean resultado = ruat.pagar(deuda);
                        out.println("Pagar:" + resultado);
                    }
                }
            } catch (IOException e) {
                e.printStackTrace();
            } finally {
                try {
                    in.close();
                    out.close();
                    clientSocket.close();
                } catch (IOException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}