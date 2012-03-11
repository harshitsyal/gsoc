// In this example, we demonstrate how to obtain string features
// by using a sliding window in a memory-efficient way. Instead of copying
// the string for each position of the sliding window, we only store a reference
// with respect to the complete string. This is particularly useful, when working
// with genomic data, where storing all explicitly copied strings in memory
// quickly becomes infeasible. In addition to a sliding window (of a particular
// length) over all position, we also support defining a custom position
// list.

import org.shogun.*;
import org.jblas.*;
import static org.shogun.EAlphabet.DNA;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class features_string_sliding_window_modular {
	static {
		System.loadLibrary("modshogun");
	}

	public static void main(String argv[]) {
		modshogun.init_shogun_with_defaults();
		String[] strings = new String[] {"AAAAAAAAAACCCCCCCCCCGGGGGGGGGGTTTTTTTTTT"};
		StringCharFeatures f = new StringCharFeatures(strings, DNA);
		f.obtain_by_sliding_window(5,1);

		DynamicIntArray positions = new DynamicIntArray();
		positions.append_element(0);
		positions.append_element(6);
		positions.append_element(16);
		positions.append_element(25);

		//f.obtain_by_position_list(8,positions);

		modshogun.exit_shogun();
	}
}
