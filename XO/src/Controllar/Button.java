package Controllar;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import Engine.XO;
import GUI.Gui;
import GUI.Players;

public class Button implements ActionListener{
Players p;
public Button(Players p){
	this.p=p;
}
	public void actionPerformed(ActionEvent e) {
		
		// TODO Auto-generated method stub
		p.setVisible(false);
		XO xo=new XO();
		new Gui(xo,p);
		
	}

}
