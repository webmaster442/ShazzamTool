// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <author name="Daniel Grunwald"/>
//     <version>$Revision$</version>
// </file>

using ICSharpCode.TextEditor.Document;
using System;
using NUnit.Framework;

namespace ICSharpCode.TextEditor.Tests
{
	[TestFixture]
	public class TextMarkerTests
	{
		IDocument document;
		TextMarker marker;
		
		[SetUp]
		public void SetUp()
		{
			document = new DocumentFactory().CreateDocument();
			document.TextContent = "0123456789";
			marker = new TextMarker(3, 3, TextMarkerType.Underlined);
			document.MarkerStrategy.AddMarker(marker);
		}
		
		[Test]
		public void RemoveTextBeforeMarker()
		{
			document.Remove(1, 1);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
		
		[Test]
		public void RemoveTextImmediatelyBeforeMarker()
		{
			document.Remove(2, 1);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
		
		[Test]
		public void RemoveTextBeforeMarkerIntoMarker()
		{
			document.Remove(2, 2);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("45"));
		}
		
		[Test]
		public void RemoveTextBeforeMarkerUntilMarkerEnd()
		{
			document.Remove(2, 4);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(0));
		}
		
		[Test]
		public void RemoveTextBeforeMarkerOverMarkerEnd()
		{
			document.Remove(2, 5);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(0));
		}
		
		[Test]
		public void RemoveTextFromMarkerStartIntoMarker()
		{
			document.Remove(3, 1);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("45"));
		}
		
		[Test]
		public void RemoveTextFromMarkerStartUntilMarkerEnd()
		{
			document.Remove(3, 3);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(0));
		}
		
		[Test]
		public void RemoveTextFromMarkerStartOverMarkerEnd()
		{
			document.Remove(3, 4);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(0));
		}
		
		[Test]
		public void RemoveTextInsideMarker()
		{
			document.Remove(4, 1);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("35"));
		}
		
		[Test]
		public void RemoveTextInsideMarkerUntilMarkerEnd()
		{
			document.Remove(4, 2);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("3"));
		}
		
		[Test]
		public void RemoveTextInsideMarkerOverMarkerEnd()
		{
			document.Remove(4, 3);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("3"));
		}
		
		[Test]
		public void RemoveTextImmediatelyAfterMarker()
		{
			document.Remove(6, 1);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
		
		[Test]
		public void RemoveTextAfterMarker()
		{
			document.Remove(7, 1);
			Assert.That(document.MarkerStrategy.GetMarkers(0, document.TextLength).Count, Is.EqualTo(1));
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
		
		[Test]
		public void InsertTextBeforeMarker()
		{
			document.Insert(1, "ab");
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
		
		[Test]
		public void InsertTextImmediatelyBeforeMarker()
		{
			document.Insert(3, "ab");
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
		
		[Test]
		public void InsertTextInsideMarker()
		{
			document.Insert(4, "ab");
			Assert.That(document.GetText(marker), Is.EqualTo("3ab45"));
		}
		
		[Test]
		public void InsertTextImmediatelyAfterMarker()
		{
			document.Insert(6, "ab");
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
		
		[Test]
		public void InsertTextAfterMarker()
		{
			document.Insert(7, "ab");
			Assert.That(document.GetText(marker), Is.EqualTo("345"));
		}
	}
}
