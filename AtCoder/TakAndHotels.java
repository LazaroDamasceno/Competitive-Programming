import java.util.*;

public class Main {
	
	public static void main(String[] args) {
		Locale.setDefault(Locale.US);
		Scanner scanner = new Scanner(System.in);
		int N = scanner.nextInt();
		int K = scanner.nextInt();
		int X = scanner.nextInt();
		int Y = scanner.nextInt();
		System.out.println(N > K ? (K * X) + ((N - K) * Y) : N * X);
		scanner.close();
	}
	
}
