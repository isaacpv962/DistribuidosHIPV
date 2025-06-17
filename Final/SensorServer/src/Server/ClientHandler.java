package Server;

import java.io.*;
import java.net.Socket;
import java.util.LinkedHashMap;
import java.util.Map;

public class ClientHandler implements Runnable {
    private Socket socket;

    // Para almacenar estado de sensores de este cliente:
    private Map<String, String> sensorStates = new LinkedHashMap<>();

    public ClientHandler(Socket socket) {
        this.socket = socket;
    }

    @Override
    public void run() {
        try (
            BufferedReader in  = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter    out = new PrintWriter(socket.getOutputStream(), true);
        ) {
            String line;
            while ((line = in.readLine()) != null) {
                if (line.equalsIgnoreCase("reporte")) {
                   
                    String reporteId = "Ninguno";
                    boolean foundMedio = false;

                    for (Map.Entry<String, String> entry : sensorStates.entrySet()) {
                        String estado = entry.getValue().toLowerCase();
                        if (estado.equals("alto")) {
                            reporteId = entry.getKey();
                            break; 
                        } else if (estado.equals("medio") && !foundMedio) {
                            reporteId = entry.getKey();
                            foundMedio = true;
                           
                        } else if (estado.equals("bajo") && !foundMedio && reporteId.equals("Ninguno")) {
                            reporteId = entry.getKey();
                        }
                    }

                    out.println("Reporte: " + reporteId);
                }
                else {
                    String[] parts = line.split("\\s+");
                    if (parts.length == 2) {
                        String id     = parts[0];
                        String estado = parts[1];
                        sensorStates.put(id, estado);
                        out.println(estado + " OK");
                    } else {
                        out.println("Error: formato inválido");
                    }
                }
            }
        } catch (IOException ex) {
            System.err.println("Conexión cerrada: " + ex.getMessage());
        }
    }
}
