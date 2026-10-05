using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[Preserve]
	public class XmlNodeConverter : JsonConverter
	{
		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000229")]
		public string DeserializeRootElementName
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00005FE8 File Offset: 0x000041E8
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700022A")]
		public bool WriteArrayAttribute
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00006000 File Offset: 0x00004200
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700022B")]
		public bool OmitRootObject
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x4DFB690", Offset = "0x4DFA290", VA = "0x184DFB690", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x4DFB450", Offset = "0x4DFA050", VA = "0x184DFB450")]
		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x4DF87C0", Offset = "0x4DF73C0", VA = "0x184DF87C0")]
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x4DF9F80", Offset = "0x4DF8B80", VA = "0x184DF9F80")]
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x4DF8130", Offset = "0x4DF6D30", VA = "0x184DF8130")]
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x4DF84B0", Offset = "0x4DF70B0", VA = "0x184DF84B0")]
		private bool IsArray(IXmlNode node)
		{
			return default(bool);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x4DFA160", Offset = "0x4DF8D60", VA = "0x184DFA160")]
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x4DFA640", Offset = "0x4DF9240", VA = "0x184DFA640")]
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x4DF5C80", Offset = "0x4DF4880", VA = "0x184DF5C80")]
		private static bool AllSameName(IXmlNode node)
		{
			return default(bool);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x4DF9940", Offset = "0x4DF8540", VA = "0x184DF9940", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x4DF7DA0", Offset = "0x4DF69A0", VA = "0x184DF7DA0")]
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x4DF9670", Offset = "0x4DF8270", VA = "0x184DF9670")]
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x4DF6A00", Offset = "0x4DF5600", VA = "0x184DF6A00")]
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues)
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x4DF5830", Offset = "0x4DF4430", VA = "0x184DF5830")]
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string attributeName, XmlNamespaceManager manager, string attributePrefix)
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x4DF5F30", Offset = "0x4DF4B30", VA = "0x184DF5F30")]
		private string ConvertTokenToXmlValue(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x4DF8CA0", Offset = "0x4DF78A0", VA = "0x184DF8CA0")]
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x4DF5A30", Offset = "0x4DF4630", VA = "0x184DF5A30")]
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x4DF8F90", Offset = "0x4DF7B90", VA = "0x184DF8F90")]
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x4DF7070", Offset = "0x4DF5C70", VA = "0x184DF7070")]
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x4DF6630", Offset = "0x4DF5230", VA = "0x184DF6630")]
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x4DF6F40", Offset = "0x4DF5B40", VA = "0x184DF6F40")]
		private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x4DF7430", Offset = "0x4DF6030", VA = "0x184DF7430")]
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x4DF86D0", Offset = "0x4DF72D0", VA = "0x184DF86D0")]
		private bool IsNamespaceAttribute(string attributeName, out string prefix)
		{
			return default(bool);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x4DFB2F0", Offset = "0x4DF9EF0", VA = "0x184DFB2F0")]
		private bool ValueAttributes(List<IXmlNode> c)
		{
			return default(bool);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x4DF5E10", Offset = "0x4DF4A10", VA = "0x184DF5E10", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public XmlNodeConverter()
		{
		}

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		private const string TextName = "#text";

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		private const string CommentName = "#comment";

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		private const string CDataName = "#cdata-section";

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		private const string WhitespaceName = "#whitespace";

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		private const string SignificantWhitespaceName = "#significant-whitespace";

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		private const string DeclarationName = "?xml";

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	}
}
