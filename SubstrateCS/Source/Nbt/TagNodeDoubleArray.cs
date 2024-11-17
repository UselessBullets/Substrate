
namespace Substrate.Nbt {
    public sealed class TagNodeDoubleArray : TagNode {
        private double[] _data = null;

        /// <summary>
        /// Converts the node to itself.
        /// </summary>
        /// <returns>A reference to itself.</returns>
        public override TagNodeDoubleArray ToTagDoubleArray() {
            return this;
        }

        /// <summary>
        /// Gets the tag type of the node.
        /// </summary>
        /// <returns>The TAG_LONG_ARRAY tag type.</returns>
        public override TagType GetTagType() {
            return TagType.TAG_DOUBLE_ARRAY;
        }

        /// <summary>
        /// Gets or sets an double array of tag data.
        /// </summary>
        public double[] Data {
            get { return _data; }
            set { _data = value; }
        }

        /// <summary>
        /// Gets the length of the stored byte array.
        /// </summary>
        public int Length {
            get { return _data.Length; }
        }

        /// <summary>
        /// Constructs a new byte array node with a null data value.
        /// </summary>
        public TagNodeDoubleArray() { }

        /// <summary>
        /// Constructs a new byte array node.
        /// </summary>
        /// <param name="d">The value to set the node's tag data value.</param>
        public TagNodeDoubleArray(double[] d) {
            _data = d;
        }

        /// <summary>
        /// Makes a deep copy of the node.
        /// </summary>
        /// <returns>A new double array node representing the same data.</returns>
        public override TagNode Copy() {
            double[] arr = new double[_data.Length];
            _data.CopyTo(arr, 0);

            return new TagNodeDoubleArray(arr);
        }

        /// <summary>
        /// Gets a string representation of the node's data.
        /// </summary>
        /// <returns>String representation of the node's data.</returns>
        public override string ToString() {
            return _data.ToString();
        }

        /// <summary>
        /// Gets or sets a single double at the specified index.
        /// </summary>
        /// <param name="index">Valid index within stored double array.</param>
        /// <returns>The double value at the given index of the stored byte array.</returns>
        public double this[int index] {
            get { return _data[index]; }
            set { _data[index] = value; }
        }

        /// <summary>
        /// Converts a system double array to a double array node representing the same data.
        /// </summary>
        /// <param name="i">A double array.</param>
        /// <returns>A new double array node containing the given value.</returns>
        public static implicit operator TagNodeDoubleArray(double[] i) {
            return new TagNodeDoubleArray(i);
        }

        /// <summary>
        /// Converts an double array node to a system double array representing the same data.
        /// </summary>
        /// <param name="i">An double array node.</param>
        /// <returns>A system double array set to the node's data.</returns>
        public static implicit operator double[](TagNodeDoubleArray i) {
            return i._data;
        }
    }
}
