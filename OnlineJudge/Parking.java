import java.util.*;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner input = new Scanner(System.in);
		int testcases = input.nextInt();
		while (testcases != 0) {
			int size = input.nextInt();
			Vector<Integer> positions = new Vector<>();
			for (int i = 1; i <= size; i++) {
				positions.add(input.nextInt());
			}
			System.out.println((Collections.max(positions) - Collections.min(positions)) * 2);
			positions.clear();
			testcases--;
		}
		input.close();
	}

}
