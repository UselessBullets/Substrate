﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substrate.Nbt {
    /// <summary>
    /// A concrete <see cref="SchemaNode"/> representing a <see cref="TagNodeDoubleArray"/>.
    /// </summary>
    public sealed class SchemaNodeDoubleArray : SchemaNode {
        private int _length;

        /// <summary>
        /// Gets the expected length of the corresponding double array.
        /// </summary>
        public int Length {
            get { return _length; }
        }

        /// <summary>
        /// Indicates whether there is an expected length of the corresponding int array.
        /// </summary>
        public bool HasExpectedLength {
            get { return _length > 0; }
        }

        /// <summary>
        /// Constructs a new <see cref="SchemaNodeDoubleArray"/> representing a <see cref="TagNodeDoubleArray"/> named <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the corresponding <see cref="TagNodeIntArray"/>.</param>
        public SchemaNodeDoubleArray(string name)
            : base(name) {
            _length = 0;
        }

        /// <summary>
        /// Constructs a new <see cref="SchemaNodeDoubleArray"/> with additional options.
        /// </summary>
        /// <param name="name">The name of the corresponding <see cref="TagNodeDoubleArray"/>.</param>
        /// <param name="options">One or more option flags modifying the processing of this node.</param>
        public SchemaNodeDoubleArray(string name, SchemaOptions options)
            : base(name, options) {
            _length = 0;
        }

        /// <summary>
        /// Constructs a new <see cref="SchemaNodeDoubleArray"/> representing a <see cref="TagNodeDoubleArray"/> named <paramref name="name"/> with expected length <paramref name="length"/>.
        /// </summary>
        /// <param name="name">The name of the corresponding <see cref="TagNodeIntArray"/>.</param>
        /// <param name="length">The expected length of corresponding byte array.</param>
        public SchemaNodeDoubleArray(string name, int length)
            : base(name) {
            _length = length;
        }

        /// <summary>
        /// Constructs a new <see cref="SchemaNodeDoubleArray"/> with additional options.
        /// </summary>
        /// <param name="name">The name of the corresponding <see cref="TagNodeDoubleArray"/>.</param>
        /// <param name="length">The expected length of corresponding byte array.</param>
        /// <param name="options">One or more option flags modifying the processing of this node.</param>
        public SchemaNodeDoubleArray(string name, int length, SchemaOptions options)
            : base(name, options) {
            _length = length;
        }

        /// <summary>
        /// Constructs a default <see cref="TagNodeDoubleArray"/> satisfying the constraints of this node.
        /// </summary>
        /// <returns>A <see cref="TagNodeString"/> with a sensible default value.</returns>
        public override TagNode BuildDefaultTree() {
            return new TagNodeDoubleArray(new double[_length]);
        }
    }
}

