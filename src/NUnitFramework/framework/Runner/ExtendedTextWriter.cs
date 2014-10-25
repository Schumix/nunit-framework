﻿// ***********************************************************************
// Copyright (c) 2014 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace NUnitLite.Runner
{
    /// <summary>
    /// ExtendedTextWriter is a TextWriter that supports 
    /// color display when used with the Console.
    /// </summary>
    public class ExtendedTextWriter : TextWriter
    {
        private TextWriter _writer;

        /// <summary>
        /// Construct an ExtendedTestWriter with output
        /// going to a specified TextWriter.
        /// </summary>
        /// <param name="writer">The TextWriter to receive output</param>
        public ExtendedTextWriter(TextWriter writer)
        {
            _writer = writer;
        }

        #region TextWriter Overrides

        /// <summary>
        /// Write a single char value
        /// </summary>
        public override void Write(char value)
        {
            _writer.Write(value);
        }

        /// <summary>
        /// Write a string value
        /// </summary>
        public override void Write(string value)
        {
            _writer.Write(value);
        }

        /// <summary>
        /// Write a string value followed by a NewLine
        /// </summary>
        public override void WriteLine(string value)
        {
            _writer.WriteLine(value);
        }

        /// <summary>
        /// Gets the encoding for this ExtendedTextWriter
        /// </summary>
        public override Encoding Encoding
        {
#if SILVERLIGHT
            get { return Encoding.UTF8; }
#else
            get { return _writer.Encoding; }
#endif
        }

        /// <summary>
        /// Close the ExtendedTextWriter
        /// </summary>
        public override void Close()
        {
            _writer.Close();
        }

        #endregion

        #region Extended Methods
        /// <summary>
        /// Writes the value with the specified style.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="value">The value.</param>
        public void Write(ColorStyle style, string value)
        {
            using (new ColorConsole(style))
            {
                _writer.Write(value);
            }
        }

        /// <summary>
        /// Writes the value with the specified style.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <param name="value">The value.</param>
        public void WriteLine(ColorStyle style, string value)
        {
            using (new ColorConsole(style))
            {
                _writer.WriteLine(value);
            }
        }

        /// <summary>
        /// Writes the label and the option that goes with it.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="option">The option.</param>
        public void WriteLabel(string label, object option)
        {
            WriteLabel(label, option, ColorStyle.Value);
        }

        /// <summary>
        /// Writes the label and the option that goes with it followed by a new line.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="option">The option.</param>
        public void WriteLabelLine(string label, object option)
        {
            WriteLabelLine(label, option, ColorStyle.Value);
        }

        /// <summary>
        /// Writes the label and the option that goes with it and optionally writes a new line.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="option">The option.</param>
        /// <param name="valueStyle">The color to display the value with</param>
        public void WriteLabel(string label, object option, ColorStyle valueStyle)
        {
            Write(ColorStyle.Label, label);
            Write(valueStyle, option.ToString());
        }

        /// <summary>
        /// Writes the label and the option that goes with it followed by a new line.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="option">The option.</param>
        /// <param name="valueStyle">The color to display the value with</param>
        public void WriteLabelLine(string label, object option, ColorStyle valueStyle)
        {
            WriteLabel(label, option, valueStyle);
            _writer.WriteLine();
        }

        #endregion
    }
}
