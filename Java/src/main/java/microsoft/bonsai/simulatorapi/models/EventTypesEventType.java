/**
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package microsoft.bonsai.simulatorapi.models;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Defines values for EventTypesEventType.
 */
public enum EventTypesEventType {
    /** Enum value Unspecified. */
    UNSPECIFIED("Unspecified"),

    /** Enum value EpisodeStart. */
    EPISODE_START("EpisodeStart"),

    /** Enum value EpisodeStep. */
    EPISODE_STEP("EpisodeStep"),

    /** Enum value EpisodeFinish. */
    EPISODE_FINISH("EpisodeFinish"),

    /** Enum value PlaybackStart. */
    PLAYBACK_START("PlaybackStart"),

    /** Enum value PlaybackStep. */
    PLAYBACK_STEP("PlaybackStep"),

    /** Enum value PlaybackFinish. */
    PLAYBACK_FINISH("PlaybackFinish"),

    /** Enum value Idle. */
    IDLE("Idle"),

    /** Enum value Registered. */
    REGISTERED("Registered"),

    /** Enum value Unregister. */
    UNREGISTER("Unregister");

    /** The actual serialized value for a EventTypesEventType instance. */
    private String value;

    EventTypesEventType(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a EventTypesEventType instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed EventTypesEventType object, or null if unable to parse.
     */
    @JsonCreator
    public static EventTypesEventType fromString(String value) {
        EventTypesEventType[] items = EventTypesEventType.values();
        for (EventTypesEventType item : items) {
            if (item.toString().equalsIgnoreCase(value)) {
                return item;
            }
        }
        return null;
    }

    @JsonValue
    @Override
    public String toString() {
        return this.value;
    }
}