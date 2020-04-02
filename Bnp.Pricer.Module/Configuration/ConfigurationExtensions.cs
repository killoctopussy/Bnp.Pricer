using System;
using System.Xml;

namespace Bnp.Pricer.Configuration
{
	/// <summary>
	/// Represent a configuration extensions helpers
	/// </summary>
	internal static class ConfigurationExtensions
	{
		/// <summary>
		/// Read the attribute value
		/// </summary>
		/// <param name="node">the node</param>
		/// <param name="attributeName">the attribute name</param>
		/// <returns>Returns an attribute</returns>
		/// <exception cref="ArgumentNullException"/>
		/// <exception cref="ArgumentException"/>
		public static string ReadAttribute( this XmlNode node , string attributeName )
		{
			if ( null == node )
			{
				throw new ArgumentNullException( nameof( node ) );
			}

			if ( string.IsNullOrWhiteSpace( attributeName ) )
			{
				throw new ArgumentException( nameof( attributeName ) );
			}
			
			var attributes = node.Attributes;

			if ( null == attributes || attributes.Count <= 0 )
			{
				return string.Empty;
			}

			var attribute = attributes[ attributeName ];

			if ( null == attribute )
			{
				return string.Empty;
			}
			
			return attribute.Value ?? string.Empty;
		}

		/// <summary>
		/// Write the attribute value
		/// </summary>
		/// <param name="node">the node</param>
		/// <param name="attributeName">the attribute name</param>
		/// <param name="attributeValue">the attribute value</param>
		/// <exception cref="ArgumentNullException"/>
		/// <exception cref="ArgumentException"/>
		public static void WriteAttribute( this XmlNode node , string attributeName , string attributeValue )
		{
			if ( null == node )
			{
				throw new ArgumentNullException( nameof( node ) );
			}

			if ( string.IsNullOrWhiteSpace( attributeName ) )
			{
				throw new ArgumentException( nameof( attributeName ) );
			}

			var document = node.OwnerDocument;

			if ( null == document )
			{
				return;
			}

			var attribue = document.CreateAttribute( attributeName );
			
			if ( null == attribue )
			{
				return;
			}

			attribue.Value = attributeValue ?? string.Empty;

			var attributes = node.Attributes;

			if ( null == attributes )
			{
				return;
			}

			attributes.Append( attribue );
		}

		/// <summary>
		/// Append a new node
		/// </summary>
		/// <param name="document">the document</param>
		/// <param name="nodeName">the node name</param>
		/// <returns>returns an instance</returns>
		/// <exception cref="ArgumentException"/>
		/// <exception cref="ArgumentNullException"/>
		public static XmlNode AppendNode( this XmlDocument document , string nodeName )
		{
			if ( null == document )
			{
				throw new ArgumentNullException( nameof( document ) );
			}

			if ( string.IsNullOrWhiteSpace( nodeName ) )
			{
				throw new ArgumentException( nameof( nodeName ) );
			}
			
			return document.AppendChild( document.CreateNode( XmlNodeType.Element , nodeName , string.Empty ) );
		}

		/// <summary>
		/// Append a new node
		/// </summary>
		/// <param name="node">the document</param>
		/// <param name="nodeName">the node name</param>
		/// <returns>returns an instance</returns>
		/// <exception cref="ArgumentException"/>
		/// <exception cref="ArgumentNullException"/>
		public static XmlNode AppendNode( this XmlNode node , string nodeName )
		{
			if ( null == node )
			{
				throw new ArgumentNullException( nameof( node ) );
			}

			if ( string.IsNullOrWhiteSpace( nodeName ) )
			{
				throw new ArgumentException( nameof( nodeName ) );
			}
			
			return node.AppendChild( node.OwnerDocument.CreateNode( XmlNodeType.Element , nodeName , string.Empty ) );
		}
	}
}
