/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package ruat;

import common.Deuda;
import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;
import java.util.List;

public class servidorRuat extends UnicastRemoteObject implements IRuat {
    private static final String ALCALDIA_HOST = "localhost";
    private static final int ALCALDIA_PORT = 9876;
    
   
    private List<Deuda> deudas = new ArrayList<>();
    
    public servidorRuat() throws RemoteException {
        super();
        
        deudas.add(new Deuda("1234567", 2022, "Vehículo", 2451));
        deudas.add(new Deuda("1234567", 2022, "Casa", 2500));
        deudas.add(new Deuda("555587", 2021, "Vehículo", 5000));
        deudas.add(new Deuda("333357", 2023, "Casa", 24547));
    }

    @Override
    public List<Deuda> buscar(String ci) throws RemoteException {
        List<Deuda> resultado = new ArrayList<>();
        for (Deuda deuda : deudas) {
            if (deuda.getCi().equals(ci)) {
                resultado.add(deuda);
            }
        }
        return resultado;
    }

    @Override
    public boolean pagar(Deuda deuda) throws RemoteException {
        try {
            
            DatagramSocket socket = new DatagramSocket();
            InetAddress ipAddress = InetAddress.getByName(ALCALDIA_HOST);
            
            String mensaje = "consulta:" + deuda.getCi();
            byte[] sendData = mensaje.getBytes();
            DatagramPacket sendPacket = new DatagramPacket(sendData, sendData.length, ipAddress, ALCALDIA_PORT);
            socket.send(sendPacket);
            
            byte[] receiveData = new byte[1024];
            DatagramPacket receivePacket = new DatagramPacket(receiveData, receiveData.length);
            socket.receive(receivePacket);
            
            String respuesta = new String(receivePacket.getData(), 0, receivePacket.getLength());
            socket.close();
            
            return Boolean.parseBoolean(respuesta);
        } catch (IOException e) {
            e.printStackTrace();
            return false;
        }
    }
    
    public static void main(String[] args) {
        try {
            java.rmi.registry.LocateRegistry.createRegistry(1099);
            IRuat ruat = new servidorRuat();
            java.rmi.Naming.rebind("RUAT", ruat);
            System.out.println("Servidor RUAT listo...");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}