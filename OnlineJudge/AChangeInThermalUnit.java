import java.util.*;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner input = new Scanner(System.in);
		int counter = 1;
		int testcases = input.nextInt();
		while (testcases != 0) {
			int initialC = input.nextInt();
			int increaseF = input.nextInt();
			double fromCtoF = ((9.0/5) * initialC) + 32;
			fromCtoF += increaseF;
			double finalC = ((fromCtoF - 32) * 5.0)/ 9.0;
			System.out.printf("Case %d: %.2f\n", counter++, finalC);
			testcases--;
		}
		input.close();
	}

}
