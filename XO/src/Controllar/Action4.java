package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JOptionPane;

import Engine.XO;
import GUI.Gui;

public class Action4 implements ActionListener{
	
	Gui g;
	XO xo;
	int count;
	public int getCount() {
		return count;
	}
	public Action4(Gui g,XO xo){
		this.g=g;
		this.xo=xo;
	}
	public void actionPerformed(ActionEvent e) {
		xo.insert(1,0);
		count++;
		g.buttons();
		
	}
}
