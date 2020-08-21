// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bonsai.SimulatorApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RL action returned by bonsai platform when it got new state from
    /// simulator session.
    /// </summary>
    public partial class EventModel
    {
        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        public EventModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventModel class.
        /// </summary>
        /// <param name="type">Possible values include: 'Unspecified',
        /// 'EpisodeStart', 'EpisodeStep', 'EpisodeFinish', 'Idle',
        /// 'Unregister'</param>
        /// <param name="sessionId">unique session id.</param>
        /// <param name="sequenceId">Always startes with 1, and Bonsai platform
        /// increment it at each Step event in advance operation.static
        /// Always just return the sequenceId returned by previous advance
        /// operation response.</param>
        public EventModel(EventType type, string sessionId, int sequenceId, EpisodeStart episodeStart = default(EpisodeStart), EpisodeStep episodeStep = default(EpisodeStep), EpisodeFinish episodeFinish = default(EpisodeFinish), Idle idle = default(Idle), Unregister unregister = default(Unregister))
        {
            Type = type;
            SessionId = sessionId;
            SequenceId = sequenceId;
            EpisodeStart = episodeStart;
            EpisodeStep = episodeStep;
            EpisodeFinish = episodeFinish;
            Idle = idle;
            Unregister = unregister;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Unspecified',
        /// 'EpisodeStart', 'EpisodeStep', 'EpisodeFinish', 'Idle',
        /// 'Unregister'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public EventType Type { get; set; }

        /// <summary>
        /// Gets or sets unique session id.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

        /// <summary>
        /// Gets or sets always startes with 1, and Bonsai platform increment
        /// it at each Step event in advance operation.static
        /// Always just return the sequenceId returned by previous advance
        /// operation response.
        /// </summary>
        [JsonProperty(PropertyName = "sequenceId")]
        public int SequenceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "episodeStart")]
        public EpisodeStart EpisodeStart { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "episodeStep")]
        public EpisodeStep EpisodeStep { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "episodeFinish")]
        public EpisodeFinish EpisodeFinish { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "idle")]
        public Idle Idle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "unregister")]
        public Unregister Unregister { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SessionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SessionId");
            }
        }
    }
}