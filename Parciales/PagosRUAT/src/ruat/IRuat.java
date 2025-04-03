/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package ruat;

import common.Deuda;
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

public interface IRuat extends Remote {
    List<Deuda> buscar(String ci) throws RemoteException;
    boolean pagar(Deuda deuda) throws RemoteException;
}