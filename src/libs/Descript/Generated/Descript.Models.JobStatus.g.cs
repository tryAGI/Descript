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
        ///
        /// </summary>
        public bool TryPickImportProjectMedia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Descript.ImportJobStatus? value)
        {
            value = ImportProjectMedia;
            return IsImportProjectMedia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.ImportJobStatus PickImportProjectMedia() => ImportProjectMedia is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImportProjectMedia' but the value was {ToString()}.");

        /// <summary>
        /// Job status for a drive media import job.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Descript.DriveMediaImportJobStatus? ImportDriveMedia { get; init; }
#else
        public global::Descript.DriveMediaImportJobStatus? ImportDriveMedia { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImportDriveMedia))]
#endif
        public bool IsImportDriveMedia => ImportDriveMedia != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImportDriveMedia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Descript.DriveMediaImportJobStatus? value)
        {
            value = ImportDriveMedia;
            return IsImportDriveMedia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.DriveMediaImportJobStatus PickImportDriveMedia() => ImportDriveMedia is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImportDriveMedia' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickAgent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Descript.AgentJobStatus? value)
        {
            value = Agent;
            return IsAgent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.AgentJobStatus PickAgent() => Agent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Agent' but the value was {ToString()}.");

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
        public bool TryPickPublish(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Descript.PublishJobStatus? value)
        {
            value = Publish;
            return IsPublish;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Descript.PublishJobStatus PickPublish() => Publish is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Publish' but the value was {ToString()}.");
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
        public static JobStatus FromImportProjectMedia(global::Descript.ImportJobStatus? value) => new JobStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator JobStatus(global::Descript.DriveMediaImportJobStatus value) => new JobStatus((global::Descript.DriveMediaImportJobStatus?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Descript.DriveMediaImportJobStatus?(JobStatus @this) => @this.ImportDriveMedia;

        /// <summary>
        ///
        /// </summary>
        public JobStatus(global::Descript.DriveMediaImportJobStatus? value)
        {
            ImportDriveMedia = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static JobStatus FromImportDriveMedia(global::Descript.DriveMediaImportJobStatus? value) => new JobStatus(value);

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
        public static JobStatus FromAgent(global::Descript.AgentJobStatus? value) => new JobStatus(value);

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
        public static JobStatus FromPublish(global::Descript.PublishJobStatus? value) => new JobStatus(value);

        /// <summary>
        ///
        /// </summary>
        public JobStatus(
            global::Descript.JobStatusDiscriminatorJobType? jobType,
            global::Descript.ImportJobStatus? importProjectMedia,
            global::Descript.DriveMediaImportJobStatus? importDriveMedia,
            global::Descript.AgentJobStatus? agent,
            global::Descript.PublishJobStatus? publish
            )
        {
            JobType = jobType;

            ImportProjectMedia = importProjectMedia;
            ImportDriveMedia = importDriveMedia;
            Agent = agent;
            Publish = publish;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Publish as object ??
            Agent as object ??
            ImportDriveMedia as object ??
            ImportProjectMedia as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ImportProjectMedia?.ToString() ??
            ImportDriveMedia?.ToString() ??
            Agent?.ToString() ??
            Publish?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImportProjectMedia && !IsImportDriveMedia && !IsAgent && !IsPublish || !IsImportProjectMedia && IsImportDriveMedia && !IsAgent && !IsPublish || !IsImportProjectMedia && !IsImportDriveMedia && IsAgent && !IsPublish || !IsImportProjectMedia && !IsImportDriveMedia && !IsAgent && IsPublish;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Descript.ImportJobStatus, TResult>? importProjectMedia = null,
            global::System.Func<global::Descript.DriveMediaImportJobStatus, TResult>? importDriveMedia = null,
            global::System.Func<global::Descript.AgentJobStatus, TResult>? agent = null,
            global::System.Func<global::Descript.PublishJobStatus, TResult>? publish = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImportProjectMedia is { } __value0 && importProjectMedia != null)
            {
                return importProjectMedia(__value0);
            }
            else if (ImportDriveMedia is { } __value1 && importDriveMedia != null)
            {
                return importDriveMedia(__value1);
            }
            else if (Agent is { } __value2 && agent != null)
            {
                return agent(__value2);
            }
            else if (Publish is { } __value3 && publish != null)
            {
                return publish(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Descript.ImportJobStatus>? importProjectMedia = null,

            global::System.Action<global::Descript.DriveMediaImportJobStatus>? importDriveMedia = null,

            global::System.Action<global::Descript.AgentJobStatus>? agent = null,

            global::System.Action<global::Descript.PublishJobStatus>? publish = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImportProjectMedia is { } __value0)
            {
                importProjectMedia?.Invoke(__value0);
            }
            else if (ImportDriveMedia is { } __value1)
            {
                importDriveMedia?.Invoke(__value1);
            }
            else if (Agent is { } __value2)
            {
                agent?.Invoke(__value2);
            }
            else if (Publish is { } __value3)
            {
                publish?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Descript.ImportJobStatus>? importProjectMedia = null,
            global::System.Action<global::Descript.DriveMediaImportJobStatus>? importDriveMedia = null,
            global::System.Action<global::Descript.AgentJobStatus>? agent = null,
            global::System.Action<global::Descript.PublishJobStatus>? publish = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ImportProjectMedia is { } __value0)
            {
                importProjectMedia?.Invoke(__value0);
            }
            else if (ImportDriveMedia is { } __value1)
            {
                importDriveMedia?.Invoke(__value1);
            }
            else if (Agent is { } __value2)
            {
                agent?.Invoke(__value2);
            }
            else if (Publish is { } __value3)
            {
                publish?.Invoke(__value3);
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
                ImportDriveMedia,
                typeof(global::Descript.DriveMediaImportJobStatus),
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
                global::System.Collections.Generic.EqualityComparer<global::Descript.DriveMediaImportJobStatus?>.Default.Equals(ImportDriveMedia, other.ImportDriveMedia) &&
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
