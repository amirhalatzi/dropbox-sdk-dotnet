// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The thumbnail arg object</para>
    /// </summary>
    public class ThumbnailArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ThumbnailArg> Encoder = new ThumbnailArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ThumbnailArg> Decoder = new ThumbnailArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ThumbnailArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path to the image file you want to thumbnail.</param>
        /// <param name="format">The format for the thumbnail image, jpeg (default) or png. For
        /// images that are photos, jpeg should be preferred, while png is  better for
        /// screenshots and digital arts.</param>
        /// <param name="size">The size for the thumbnail image.</param>
        public ThumbnailArg(string path,
                            ThumbnailFormat format = null,
                            ThumbnailSize size = null)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"\A(?:((/|id:).*)|(rev:[0-9a-f]{9,}))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            if (format == null)
            {
                format = ThumbnailFormat.Jpeg.Instance;
            }

            if (size == null)
            {
                size = ThumbnailSize.W64h64.Instance;
            }

            this.Path = path;
            this.Format = format;
            this.Size = size;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ThumbnailArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ThumbnailArg()
        {
            this.Format = ThumbnailFormat.Jpeg.Instance;
            this.Size = ThumbnailSize.W64h64.Instance;
        }

        /// <summary>
        /// <para>The path to the image file you want to thumbnail.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>The format for the thumbnail image, jpeg (default) or png. For  images that
        /// are photos, jpeg should be preferred, while png is  better for screenshots and
        /// digital arts.</para>
        /// </summary>
        public ThumbnailFormat Format { get; protected set; }

        /// <summary>
        /// <para>The size for the thumbnail image.</para>
        /// </summary>
        public ThumbnailSize Size { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ThumbnailArg" />.</para>
        /// </summary>
        private class ThumbnailArgEncoder : enc.StructEncoder<ThumbnailArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ThumbnailArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteProperty("format", value.Format, writer, ThumbnailFormat.Encoder);
                WriteProperty("size", value.Size, writer, ThumbnailSize.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ThumbnailArg" />.</para>
        /// </summary>
        private class ThumbnailArgDecoder : enc.StructDecoder<ThumbnailArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ThumbnailArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ThumbnailArg Create()
            {
                return new ThumbnailArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ThumbnailArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "format":
                        value.Format = ThumbnailFormat.Decoder.Decode(reader);
                        break;
                    case "size":
                        value.Size = ThumbnailSize.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
