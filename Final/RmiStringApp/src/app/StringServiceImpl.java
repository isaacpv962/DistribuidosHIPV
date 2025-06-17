package app;

import shared.StringService;
import java.rmi.server.UnicastRemoteObject;
import java.rmi.RemoteException;

public class StringServiceImpl extends UnicastRemoteObject implements StringService {
    private String frase = "";   // cadena interna

    protected StringServiceImpl() throws RemoteException {
        super();
    }

    @Override
    public synchronized boolean guardarFrase(String frase) throws RemoteException {
        this.frase = frase;
        return true;
    }

    @Override
    public synchronized String convertirMayusculas() throws RemoteException {
        return frase.toUpperCase();
    }

    @Override
    public synchronized String duplicarEspacios(int veces) throws RemoteException {
        StringBuilder sb = new StringBuilder();
        for (char c : frase.toCharArray()) {
            if (c == ' ') {
                for (int i = 0; i < veces; i++) sb.append(' ');
            } else {
                sb.append(c);
            }
        }
        return sb.toString();
    }

    @Override
    public synchronized String concatenar(String extra) throws RemoteException {
        return frase + extra;
    }
}
