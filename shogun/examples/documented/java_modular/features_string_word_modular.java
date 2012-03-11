// This example demonstrates how to encode string
// features efficiently by creating a more compactly encoded
// bit-string from StringCharFeatures.
// For instance, when working with the DNA alphabet {A,T,G,C}
// using 1 char = 1 byte per symbol would be wasteful, as we
// can encode 4 symbols using 2 bits only.
// Here, this is done in junks of 16bit (word).

import org.shogun.*;
import org.jblas.*;
import static org.shogun.EAlphabet.RAWBYTE;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class features_string_word_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		String[] strings = new String[] { "hey", "guys", "string"};
		StringCharFeatures cf = new StringCharFeatures(strings, RAWBYTE);
		StringWordFeatures wf = new StringWordFeatures(RAWBYTE);
		wf.obtain_from_char(cf, 0, 2, 0, false);
		wf.set_feature_vector(new DoubleMatrix(new double[][] {{1,2,3,4,5}}), 0);

		modshogun.exit_shogun();
	}
}
