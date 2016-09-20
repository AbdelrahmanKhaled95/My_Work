package eg.edu.guc.yugioh.gui;

import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JPanel;

import eg.edu.guc.yugioh.listeners.ActivePhaseListener;

public class ActivePlayerPhase extends JPanel {
	JPanel ActivePlayerPhase;
	private JButton mainphase;
	

	public JButton getMainphase() {
		return mainphase;
	}

	public void setMainphase(JButton mainphase) {
		this.mainphase = mainphase;
	}

	public void setActivePlayerPhase(JPanel activePlayerPhase) {
		ActivePlayerPhase = activePlayerPhase;
	}

	public JPanel getActivePlayerPhase() {
		return ActivePlayerPhase;
	}

	public ActivePlayerPhase() {
		ActivePlayerPhase = new JPanel();
		mainphase = new JButton("End Phase");
		

		ActivePlayerPhase.setLayout(new GridLayout(1, 1));
		ActivePlayerPhase.setBounds(360, 540, 120, 50);
		ActivePlayerPhase.add(mainphase);
		
}
}