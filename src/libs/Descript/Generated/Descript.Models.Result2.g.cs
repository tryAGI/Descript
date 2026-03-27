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
        public global::Descript.AgentJobStatusResultDiscriminatorStatus? Status { get; }

        /// <summary>
        /// Result when Agent edit completed successfully
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.AgentSuccessResult? Success { get; init; }
#else
        public global::Descript.AgentSuccessResult? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// Result when Agent edit failed
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.AgentErrorResult? Error { get; init; }
#else
        public global::Descript.AgentErrorResult? Error { get; }
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
        public static implicit operator Result2(global::Descript.AgentSuccessResult value) => new Result2((global::Descript.AgentSuccessResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Descript.AgentSuccessResult?(Result2 @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::Descript.AgentSuccessResult? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Result2(global::Descript.AgentErrorResult value) => new Result2((global::Descript.AgentErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Descript.AgentErrorResult?(Result2 @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public Result2(global::Descript.AgentErrorResult? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Result2(
            global::Descript.AgentJobStatusResultDiscriminatorStatus? status,
            global::Descript.AgentSuccessResult? success,
            global::Descript.AgentErrorResult? error
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
            global::System.Func<global::Descript.AgentSuccessResult?, TResult>? success = null,
            global::System.Func<global::Descript.AgentErrorResult?, TResult>? error = null,
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
            global::System.Action<global::Descript.AgentSuccessResult?>? success = null,
            global::System.Action<global::Descript.AgentErrorResult?>? error = null,
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
                typeof(global::Descript.AgentSuccessResult),
                Error,
                typeof(global::Descript.AgentErrorResult),
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
                global::System.Collections.Generic.EqualityComparer<global::Descript.AgentSuccessResult?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::Descript.AgentErrorResult?>.Default.Equals(Error, other.Error) 
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
