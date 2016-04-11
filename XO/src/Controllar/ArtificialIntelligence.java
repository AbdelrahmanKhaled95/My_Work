package Controllar;

import Engine.XO;

public class ArtificialIntelligence implements Runnable{

	XO xo;
	public ArtificialIntelligence(XO xo){
		this.xo=xo;
	}
	public void run() {
		// TODO Auto-generated method stub
		xo.AI();
		
	}

}
