import java.util.*;

public class Main {

	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner input = new Scanner(System.in);
		int testcases = input.nextInt();
		while (testcases != 0) {
			int A = input.nextInt();
			int B = input.nextInt();
			System.out.println(A > B ? ">" : A < B ? "<" : "=");
			testcases--;
		}
		input.close();
	}

}
