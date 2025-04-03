/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package alcaldia;

import java.net.DatagramPacket;
import java.net.DatagramSocket;

public class servidorAlcaldia {
    public static void main(String[] args) {
        try {
            DatagramSocket socket = new DatagramSocket(9876);
            System.out.println("Servidor Alcaldía UDP iniciado...");
            
            while (true) {
                byte[] receiveData = new byte[1024];
                DatagramPacket receivePacket = new DatagramPacket(receiveData, receiveData.length);
                socket.receive(receivePacket);
                
                String mensaje = new String(receivePacket.getData(), 0, receivePacket.getLength());
                System.out.println("Consulta recibida: " + mensaje);
                
                String[] partes = mensaje.split(":");
                String ci = partes[1];
                
               
                boolean respuesta = !ci.equals("1234567");
                
                byte[] sendData = String.valueOf(respuesta).getBytes();
                DatagramPacket sendPacket = new DatagramPacket(
                    sendData, 
                    sendData.length, 
                    receivePacket.getAddress(), 
                    receivePacket.getPort()
                );
                socket.send(sendPacket);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}


