package Server;

import java.io.*;
import java.net.Socket;
import java.util.Scanner;

public class Client {
    // Host y puerto del servidor
    public static final String SERVER_HOST = "localhost";
    public static final int    SERVER_PORT = 12345;

    public static void main(String[] args) {
        try (
            Socket socket = new Socket(SERVER_HOST, SERVER_PORT);
            BufferedReader in = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter    out = new PrintWriter(socket.getOutputStream(), true);
            Scanner        sc = new Scanner(System.in);
        ) {
            System.out.println("Conectado a servidor en " + SERVER_HOST + ":" + SERVER_PORT);
            String linea;
            while (true) {
                System.out.print(">> ");
                linea = sc.nextLine().trim();
             
                if (linea.equalsIgnoreCase("salir")) {
                    System.out.println("Cerrando cliente.");
                    break;
                }
              
                out.println(linea);
                
                String respuesta = in.readLine();
                if (respuesta == null) {
                    System.out.println("Servidor desconectado.");
                    break;
                }
                System.out.println("Servidor: " + respuesta);
            }
        } catch (IOException ex) {
            ex.printStackTrace();
        }
    }
}
