using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when the value is unexpectedly of the exact given type.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors")]
    [Serializable]
    public class IsNotTypeException : AssertActualExpectedException
    {
        /// <summary>
        /// Creates a new instance of the <see cref="IsNotTypeException"/> class.
        /// </summary>
        /// <param name="expected">The expected type</param>
        /// <param name="actual">The actual object value</param>
        public IsNotTypeException(Type expected, object actual)
            : base(expected, actual == null ? null : actual.GetType(), "Assert.IsNotType() Failure") { }

        /// <inheritdoc/>
        protected IsNotTypeException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}