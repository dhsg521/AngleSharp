﻿namespace AngleSharp.Parser.Css
{
    /// <summary>
    /// An enumeration with possible CSS combinator values.
    /// </summary>
    enum CssCombinator
    {
        /// <summary>
        /// The child operator (>).
        /// </summary>
        Child,
        /// <summary>
        /// The descendent operator (space).
        /// </summary>
        Descendent,
        /// <summary>
        /// The adjacent sibling combinator +.
        /// </summary>
        AdjacentSibling,
        /// <summary>
        /// The sibling combinator ~.
        /// </summary>
        Sibling,
        /// <summary>
        /// The namespace combinator |.
        /// </summary>
        Namespace,
        /// <summary>
        /// The column combinator ||.
        /// </summary>
        Column
    }
}
