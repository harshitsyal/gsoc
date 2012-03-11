// This example demonstrates how to encode string
// features efficiently by creating a more compactly encoded
// bit-string from StringCharFeatures.
// For instance, when working with the DNA alphabet {A,T,G,C}
// using 1 char = 1 byte per symbol would be wasteful, as we
// can encode 4 symbols using 2 bits only.
// Here, this is done in junks of 64bit (ulong).

import org.shogun.*;
import org.jblas.*;
import static org.shogun.EAlphabet.RAWBYTE;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class features_string_ulong_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		boolean rev = false;
		int start = 0;
		int order = 2;
		int gap = 0;
		StringCharFeatures cf = new StringCharFeatures(new String[] { "hey", "guys", "string"}, RAWBYTE);
		StringUlongFeatures uf = new StringUlongFeatures(RAWBYTE);

		uf.obtain_from_char(cf, start,order,gap,rev);
		uf.set_feature_vector(new DoubleMatrix(new double[][] {{1,2,3,4,5}}), 0);

		modshogun.exit_shogun();
	}
}
