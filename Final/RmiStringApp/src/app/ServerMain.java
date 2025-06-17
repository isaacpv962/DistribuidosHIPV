package app;

import shared.StringService;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class ServerMain {
    public static final String BIND_NAME = "StringService";

    public static void main(String[] args) {
        try {
            
            Registry registry = LocateRegistry.createRegistry(1099);
            
            StringService service = new StringServiceImpl();
            
            registry.rebind(BIND_NAME, service);
            System.out.println("Servidor RMI listo, servicio '" + BIND_NAME + "' registrado.");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
