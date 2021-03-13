using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using StardewModdingAPI;

namespace HeartEventTracker
{
    /// <summary>Get translations from the mod's <c>i18n</c> folder.</summary>
    /// <remarks>This is auto-generated from the <c>i18n/default.json</c> file when the T4 template is saved.</remarks>
    [GeneratedCode("TextTemplatingFileGenerator", "1.0.0")]
    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Deliberately named for consistency and to match translation conventions.")]
    internal static class I18n
    {
        /*********
        ** Fields
        *********/
        /// <summary>The mod's translation helper.</summary>
        private static ITranslationHelper Translations;


        /*********
        ** Public methods
        *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="translations">The mod's translation helper.</param>
        public static void Init(ITranslationHelper translations)
        {
            I18n.Translations = translations;
        }

        /// <summary>Get a translation equivalent to "yesterday".</summary>
        public static string Yesterday()
        {
            return I18n.GetByKey("yesterday");
        }

        /// <summary>Get a translation equivalent to "ready now!".</summary>
        public static string ReadyNow()
        {
            return I18n.GetByKey("ready-now");
        }

        /// <summary>Get a translation equivalent to "{{value}}%".</summary>
        /// <param name="value">The value to inject for the <c>{{value}}</c> token.</param>
        public static string Percentage(object value)
        {
            return I18n.GetByKey("percentage", new { value });
        }

        /// <summary>Get a translation equivalent to "Some text that\nhas newlines".</summary>
        public static string EdgeCases_TextWithNewlines()
        {
            return I18n.GetByKey("edge-cases.text-with-newlines");
        }

        /// <summary>Get a translation equivalent to "This is just an example of some very long translation text that could appear in some mod translation files, presumably for the mods to use in places where they need very long translation strings. One thing to keep in mind is that there's no real limit to the length that translation strings can reach, but we probably don't need the entire translation string added to the method's XML docs for IntelliSense. Instead we can just truncate at some reasonable text length, say 500 characters right abo...".</summary>
        public static string EdgeCases_VeryLongText()
        {
            return I18n.GetByKey("edge-cases.very-long-text");
        }

        /// <summary>Get a translation equivalent to "Enter Pierre's shop when she is there (except Saturdays).".</summary>
        public static string Abigail_2HeartsHint()
        {
            return I18n.GetByKey("Abigail.2HeartsHint");
        }

        /// <summary>Get a translation equivalent to "You enter Abigail's room and watch her get angry about a videogame. She asks for your help, and you play the console version of Journey of the Prairie King together. (This is just like the arcade version in The Stardrop Saloon, except that Abigail plays a second character and actively helps you). When you finish the level, she thanks you and the cutscene ends. If you fail, however, she will still thank you for trying.".</summary>
        public static string Abigail_2HeartsFullDesc()
        {
            return I18n.GetByKey("Abigail.2HeartsFullDesc");
        }


        /*********
        ** Private methods
        *********/
        /// <summary>Get a translation by its key.</summary>
        /// <param name="key">The translation key.</param>
        /// <param name="tokens">An object containing token key/value pairs. This can be an anonymous object (like <c>new { value = 42, name = "Cranberries" }</c>), a dictionary, or a class instance.</param>
        private static Translation GetByKey(string key, object tokens = null)
        {
            if (I18n.Translations == null)
                throw new InvalidOperationException($"You must call {nameof(I18n)}.{nameof(I18n.Init)} from the mod's entry method before reading translations.");
            return I18n.Translations.Get(key, tokens);
        }
    }
}

