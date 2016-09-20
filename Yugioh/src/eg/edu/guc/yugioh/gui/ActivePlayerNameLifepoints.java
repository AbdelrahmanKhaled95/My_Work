package eg.edu.guc.yugioh.gui;

import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;

import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.SwingConstants;

import eg.edu.guc.yugioh.cards.Card;

public class ActivePlayerNameLifepoints extends JPanel{
	JLabel namee;
	JLabel lifepoints;
	HomeScreen x;
	
	public ActivePlayerNameLifepoints(HomeScreen x){
		this.x=x;
		 namee=new JLabel(""+ x.getS(),SwingConstants.CENTER);
		 viewlifepoints( x);
		
		
	}
	public void viewlifepoints(HomeScreen x){
		this.removeAll();
		setLayout(new GridLayout(2,1));
		setBackground(Color.black);
		setBounds(100, 510, 200, 190);
		 lifepoints=new JLabel(""+ Card.getBoard().getActivePlayer().getLifePoints()+"",SwingConstants.CENTER);
		add(namee);
		add(lifepoints);
		namee.setFont(new Font("Serif", Font.BOLD, 30));
		lifepoints.setFont(new Font("Serif", Font.BOLD, 30));
		lifepoints.setForeground(Color.RED);
		namee.setForeground(Color.RED);
		setVisible(true);
		updateUI();
	}

	

	


	public JLabel getNamee() {
		return namee;
	}






	public JLabel getLifepoints() {
		return lifepoints;
	}

}
