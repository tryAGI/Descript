#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Descript
{
    /// <summary>
    /// Job result (only present when job_state is stopped)
    /// </summary>
    public readonly partial struct Result2 : global::System.IEquatable<Result2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatusResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// Result when media was imported (fully or partially)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.ImportSuccessResult? Success { get; init; }
#else
        public global::Descript.ImportSuccessResult? Success { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Descript.ImportSuccessResult? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportSuccessResult PickSuccess() => Success is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

        /// <summary>
        /// Result when job failed completely
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.ImportErrorResult? Error { get; init; }
#else
        public global::Descript.ImportErrorResult? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Descript.ImportErrorResult? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportErrorResult PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result2(global::Descript.ImportSuccessResult value) => new Result2((global::Descript.ImportSuccessResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Descript.ImportSuccessResult?(Result2 @this) => @this.Success;

        /// <summary>
        ///
        /// </summary>
        public Result2(global::Descript.ImportSuccessResult? value)
        {
            Success = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result2 FromSuccess(global::Descript.ImportSuccessResult? value) => new Result2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result2(global::Descript.ImportErrorResult value) => new Result2((global::Descript.ImportErrorResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Descript.ImportErrorResult?(Result2 @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public Result2(global::Descript.ImportErrorResult? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result2 FromError(global::Descript.ImportErrorResult? value) => new Result2(value);

        /// <summary>
        ///
        /// </summary>
        public Result2(
            global::Descript.ImportJobStatusResultDiscriminatorStatus? status,
            global::Descript.ImportSuccessResult? success,
            global::Descript.ImportErrorResult? error
            )
        {
            Status = status;

            Success = success;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            Success as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsError || !IsSuccess && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Descript.ImportSuccessResult, TResult>? success = null,
            global::System.Func<global::Descript.ImportErrorResult, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0 && success != null)
            {
                return success(__value0);
            }
            else if (Error is { } __value1 && error != null)
            {
                return error(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Descript.ImportSuccessResult>? success = null,

            global::System.Action<global::Descript.ImportErrorResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Descript.ImportSuccessResult>? success = null,
            global::System.Action<global::Descript.ImportErrorResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Success is { } __value0)
            {
                success?.Invoke(__value0);
            }
            else if (Error is { } __value1)
            {
                error?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::Descript.ImportSuccessResult),
                Error,
                typeof(global::Descript.ImportErrorResult),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(Result2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Descript.ImportSuccessResult?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Descript.ImportErrorResult?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Result2 obj1, Result2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Result2 obj1, Result2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result2 o && Equals(o);
        }
    }
}
