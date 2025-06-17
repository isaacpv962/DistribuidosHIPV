package Server;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {
    // Puerto de escucha
    public static final int PORT = 12345;

    public static void main(String[] args) {
        System.out.println("Iniciando servidor en el puerto " + PORT);
        try (ServerSocket serverSocket = new ServerSocket(PORT)) {
           
            while (true) {
                Socket clientSocket = serverSocket.accept();
                System.out.println("Cliente conectado desde " + clientSocket.getInetAddress());
               
                ClientHandler handler = new ClientHandler(clientSocket);
                new Thread(handler).start();
            }
        } catch (IOException ex) {
            ex.printStackTrace();
        }
    }
}
