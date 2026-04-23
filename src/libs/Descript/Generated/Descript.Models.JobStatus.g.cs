#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Descript
{
    /// <summary>
    /// Status of an async job. The response structure varies based on the job type.<br/>
    /// Use the `job_type` field to determine which fields will be present.
    /// </summary>
    public readonly partial struct JobStatus : global::System.IEquatable<JobStatus>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Descript.JobStatusDiscriminatorJobType? JobType { get; }

        /// <summary>
        /// Status of an import job
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.ImportJobStatus? ImportProjectMedia { get; init; }
#else
        public global::Descript.ImportJobStatus? ImportProjectMedia { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImportProjectMedia))]
#endif
        public bool IsImportProjectMedia => ImportProjectMedia != null;

        /// <summary>
        /// Status of an Agent edit job
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.AgentJobStatus? Agent { get; init; }
#else
        public global::Descript.AgentJobStatus? Agent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;

        /// <summary>
        /// Status of a publish job
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.PublishJobStatus? Publish { get; init; }
#else
        public global::Descript.PublishJobStatus? Publish { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Publish))]
#endif
        public bool IsPublish => Publish != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobStatus(global::Descript.ImportJobStatus value) => new JobStatus((global::Descript.ImportJobStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Descript.ImportJobStatus?(JobStatus @this) => @this.ImportProjectMedia;

        /// <summary>
        /// 
        /// </summary>
        public JobStatus(global::Descript.ImportJobStatus? value)
        {
            ImportProjectMedia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobStatus(global::Descript.AgentJobStatus value) => new JobStatus((global::Descript.AgentJobStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Descript.AgentJobStatus?(JobStatus @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public JobStatus(global::Descript.AgentJobStatus? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator JobStatus(global::Descript.PublishJobStatus value) => new JobStatus((global::Descript.PublishJobStatus?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Descript.PublishJobStatus?(JobStatus @this) => @this.Publish;

        /// <summary>
        /// 
        /// </summary>
        public JobStatus(global::Descript.PublishJobStatus? value)
        {
            Publish = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public JobStatus(
            global::Descript.JobStatusDiscriminatorJobType? jobType,
            global::Descript.ImportJobStatus? importProjectMedia,
            global::Descript.AgentJobStatus? agent,
            global::Descript.PublishJobStatus? publish
            )
        {
            JobType = jobType;

            ImportProjectMedia = importProjectMedia;
            Agent = agent;
            Publish = publish;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Publish as object ??
            Agent as object ??
            ImportProjectMedia as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ImportProjectMedia?.ToString() ??
            Agent?.ToString() ??
            Publish?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsImportProjectMedia && !IsAgent && !IsPublish || !IsImportProjectMedia && IsAgent && !IsPublish || !IsImportProjectMedia && !IsAgent && IsPublish;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Descript.ImportJobStatus?, TResult>? importProjectMedia = null,
            global::System.Func<global::Descript.AgentJobStatus?, TResult>? agent = null,
            global::System.Func<global::Descript.PublishJobStatus?, TResult>? publish = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImportProjectMedia && importProjectMedia != null)
            {
                return importProjectMedia(ImportProjectMedia!);
            }
            else if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }
            else if (IsPublish && publish != null)
            {
                return publish(Publish!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Descript.ImportJobStatus?>? importProjectMedia = null,
            global::System.Action<global::Descript.AgentJobStatus?>? agent = null,
            global::System.Action<global::Descript.PublishJobStatus?>? publish = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImportProjectMedia)
            {
                importProjectMedia?.Invoke(ImportProjectMedia!);
            }
            else if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
            else if (IsPublish)
            {
                publish?.Invoke(Publish!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImportProjectMedia,
                typeof(global::Descript.ImportJobStatus),
                Agent,
                typeof(global::Descript.AgentJobStatus),
                Publish,
                typeof(global::Descript.PublishJobStatus),
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
        public bool Equals(JobStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Descript.ImportJobStatus?>.Default.Equals(ImportProjectMedia, other.ImportProjectMedia) &&
                global::System.Collections.Generic.EqualityComparer<global::Descript.AgentJobStatus?>.Default.Equals(Agent, other.Agent) &&
                global::System.Collections.Generic.EqualityComparer<global::Descript.PublishJobStatus?>.Default.Equals(Publish, other.Publish) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(JobStatus obj1, JobStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<JobStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(JobStatus obj1, JobStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is JobStatus o && Equals(o);
        }
    }
}
