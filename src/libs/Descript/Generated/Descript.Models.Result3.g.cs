#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Descript
{
    /// <summary>
    /// Job result (only present when job_state is stopped)
    /// </summary>
    public readonly partial struct Result3 : global::System.IEquatable<Result3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatusResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// Result when publish completed successfully
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.PublishSuccessResult? Success { get; init; }
#else
        public global::Descript.PublishSuccessResult? Success { get; }
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
            out global::Descript.PublishSuccessResult? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishSuccessResult PickSuccess() => IsSuccess
            ? Success!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

        /// <summary>
        /// Result when publish failed
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.PublishErrorResult? Error { get; init; }
#else
        public global::Descript.PublishErrorResult? Error { get; }
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
            out global::Descript.PublishErrorResult? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishErrorResult PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result3(global::Descript.PublishSuccessResult value) => new Result3((global::Descript.PublishSuccessResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Descript.PublishSuccessResult?(Result3 @this) => @this.Success;

        /// <summary>
        ///
        /// </summary>
        public Result3(global::Descript.PublishSuccessResult? value)
        {
            Success = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result3 FromSuccess(global::Descript.PublishSuccessResult? value) => new Result3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Result3(global::Descript.PublishErrorResult value) => new Result3((global::Descript.PublishErrorResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Descript.PublishErrorResult?(Result3 @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public Result3(global::Descript.PublishErrorResult? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Result3 FromError(global::Descript.PublishErrorResult? value) => new Result3(value);

        /// <summary>
        ///
        /// </summary>
        public Result3(
            global::Descript.PublishJobStatusResultDiscriminatorStatus? status,
            global::Descript.PublishSuccessResult? success,
            global::Descript.PublishErrorResult? error
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
            global::System.Func<global::Descript.PublishSuccessResult, TResult>? success = null,
            global::System.Func<global::Descript.PublishErrorResult, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Descript.PublishSuccessResult>? success = null,

            global::System.Action<global::Descript.PublishErrorResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Descript.PublishSuccessResult>? success = null,
            global::System.Action<global::Descript.PublishErrorResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
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
                typeof(global::Descript.PublishSuccessResult),
                Error,
                typeof(global::Descript.PublishErrorResult),
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
        public bool Equals(Result3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Descript.PublishSuccessResult?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Descript.PublishErrorResult?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Result3 obj1, Result3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Result3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Result3 obj1, Result3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Result3 o && Equals(o);
        }
    }
}
