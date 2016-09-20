package eg.edu.guc.yugioh.gui;

import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class HomeScreen extends JFrame {
	private JButton buttonEnter1;
	private JTextField PlayerNameBox;
	private JFrame homeWindow;
	private String s;
	private int count=0;

	// ---------------------------------------------------------------------------

	public String getS() {
		return s;
	}

	public  JTextField getPlayerNameBox() {

		if(count==0){
			s=PlayerNameBox.getText();
			count++;
		}
		return PlayerNameBox;
	}

	public  void setPlayerNameBox(JTextField player) {
		PlayerNameBox = player;
	}

	public HomeScreen() {

		homeWindow = new JFrame();


		homeWindow.setTitle("Yu Gi Oh - Dark Edition");
		homeWindow.setVisible(true);
		homeWindow.setSize(1280, 720);

		backGroundLoad();

		buttonEnter1 = new JButton("Enter Player 1 Name");

		loadPlayerName();

		homeWindow.setVisible(true);

	}

	// ---------------------------------------------------------------------------

	public  JButton getButtonEnter() {
		return buttonEnter1;
	}

	public  void setButtonEnter1(JButton buttonEnter1) {
		this.buttonEnter1 = buttonEnter1;
	}

	public  JFrame getHomeWindow() {
		return homeWindow;
	}

	public  void setHomeWindow(JFrame homeWindow) {
		this.homeWindow = homeWindow;
	}

	// ---------------------------------------------------------------------------

	public  void backGroundLoad() {

		homeWindow.setContentPane(new JLabel(new ImageIcon("Credits.png")));

	}

	// ---------------------------------------------------------------------------

	public  void loadPlayerName() {
		PlayerNameBox = new JTextField();
		PlayerNameBox.setBounds(110, 300, 200, 50);
		buttonEnter1.setBounds(110, 380, 200, 30);

		homeWindow.getContentPane().add(PlayerNameBox);
		homeWindow.getContentPane().add(buttonEnter1);


	}

	// ---------------------------------------------------------------------------

	public static void main(String[] args) {

		HomeScreen x = new HomeScreen();

		x.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);


	}
}
