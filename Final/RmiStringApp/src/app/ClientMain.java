package app;

import shared.StringService;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.util.Scanner;

public class ClientMain {
    public static final String HOST = "localhost";
    public static final int    PORT = 1099;
    public static final String BIND_NAME = "StringService";

    public static void main(String[] args) {
        try {
            // Conectar al registro RMI
            Registry registry = LocateRegistry.getRegistry(HOST, PORT);
            StringService service = (StringService) registry.lookup(BIND_NAME);

            Scanner sc = new Scanner(System.in);
            String opcion, entrada;
            do {
                // Mostrar menú
                System.out.println("\n--- Menú de Operaciones ---");
                System.out.println("1) guardarFrase");
                System.out.println("2) convertirMayusculas");
                System.out.println("3) duplicarEspacios");
                System.out.println("4) concatenar");
                System.out.println("0) Salir");
                System.out.print("Elige opción: ");
                opcion = sc.nextLine().trim();

                switch (opcion) {
                    case "1":
                        System.out.print("Frase a guardar: ");
                        entrada = sc.nextLine();
                        boolean ok = service.guardarFrase(entrada);
                        System.out.println("Resultado: " + ok);
                        break;
                    case "2":
                        System.out.println("En mayúsculas: " + service.convertirMayusculas());
                        break;
                    case "3":
                        System.out.print("¿Cuántas repeticiones de espacio?: ");
                        int veces = Integer.parseInt(sc.nextLine());
                        System.out.println("Resultado: " + service.duplicarEspacios(veces));
                        break;
                    case "4":
                        System.out.print("Cadena extra a concatenar: ");
                        entrada = sc.nextLine();
                        System.out.println("Resultado: " + service.concatenar(entrada));
                        break;
                    case "0":
                        System.out.println("Saliendo.");
                        break;
                    default:
                        System.out.println("Opción inválida.");
                }
            } while (!opcion.equals("0"));

            sc.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
