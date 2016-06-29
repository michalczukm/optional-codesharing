using System;
using System.Collections.Generic;

public struct Optional<T> : IEquatable<Optional<T>>
    {
        private readonly T _value;
        private readonly bool _hasValue;

        private Optional(T value)
        {
            _value = value;
            _hasValue = true;
        }

        public T Value
        {
            get
            {
                if (HasValue)
                {
                    return _value;
                }
                else
                {
                    throw new InvalidOperationException("value is null");
                }
            }
        }

        public bool HasValue
        {
            get { return _hasValue; }
        }

        public bool IsAbsent
        {
            get { return !_hasValue; }
        }

        public static bool operator ==(Optional<T> left, Optional<T> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Optional<T> left, Optional<T> right)
        {
            return !left.Equals(right);
        }

        public static Optional<T> Absent()
        {
            return new Optional<T>();
        }

        public static Optional<T> Of(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            return new Optional<T>(value);
        }

        public override string ToString()
        {
            string value = HasValue ? string.Format("Of('{0}')", Value) : "Absent";
            return string.Format("Optional<{0}>{1}", typeof(T), value);
        }

        public bool Equals(Optional<T> other)
        {
            return HasValue.Equals(other.HasValue) && EqualityComparer<T>.Default.Equals(_value, other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Optional<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (EqualityComparer<T>.Default.GetHashCode(_value) * 397) ^ HasValue.GetHashCode();
            }
        }
    }

    public static class OptionalExtensions
    {
        public static Optional<T> ToOptional<T>(this T obj)
        {
            if (obj == null)
            {
                return Optional<T>.Absent();
            }
            return Optional<T>.Of(obj);
        }
    }