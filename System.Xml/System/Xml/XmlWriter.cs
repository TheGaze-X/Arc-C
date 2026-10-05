using System;
using System.IO;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	public abstract class XmlWriter : IDisposable
	{
		// Token: 0x0600041A RID: 1050
		[Token(Token = "0x600041A")]
		public abstract void WriteStartDocument();

		// Token: 0x0600041B RID: 1051
		[Token(Token = "0x600041B")]
		public abstract void WriteStartDocument(bool standalone);

		// Token: 0x0600041C RID: 1052
		[Token(Token = "0x600041C")]
		public abstract void WriteEndDocument();

		// Token: 0x0600041D RID: 1053
		[Token(Token = "0x600041D")]
		public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

		// Token: 0x0600041E RID: 1054
		[Token(Token = "0x600041E")]
		public abstract void WriteStartElement(string prefix, string localName, string ns);

		// Token: 0x0600041F RID: 1055
		[Token(Token = "0x600041F")]
		public abstract void WriteEndElement();

		// Token: 0x06000420 RID: 1056
		[Token(Token = "0x6000420")]
		public abstract void WriteFullEndElement();

		// Token: 0x06000421 RID: 1057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4FBCC00", Offset = "0x4FBB800", VA = "0x184FBCC00")]
		public void WriteAttributeString(string prefix, string localName, string ns, string value)
		{
		}

		// Token: 0x06000422 RID: 1058
		[Token(Token = "0x6000422")]
		public abstract void WriteStartAttribute(string prefix, string localName, string ns);

		// Token: 0x06000423 RID: 1059
		[Token(Token = "0x6000423")]
		public abstract void WriteEndAttribute();

		// Token: 0x06000424 RID: 1060
		[Token(Token = "0x6000424")]
		public abstract void WriteCData(string text);

		// Token: 0x06000425 RID: 1061
		[Token(Token = "0x6000425")]
		public abstract void WriteComment(string text);

		// Token: 0x06000426 RID: 1062
		[Token(Token = "0x6000426")]
		public abstract void WriteProcessingInstruction(string name, string text);

		// Token: 0x06000427 RID: 1063
		[Token(Token = "0x6000427")]
		public abstract void WriteEntityRef(string name);

		// Token: 0x06000428 RID: 1064
		[Token(Token = "0x6000428")]
		public abstract void WriteCharEntity(char ch);

		// Token: 0x06000429 RID: 1065
		[Token(Token = "0x6000429")]
		public abstract void WriteWhitespace(string ws);

		// Token: 0x0600042A RID: 1066
		[Token(Token = "0x600042A")]
		public abstract void WriteString(string text);

		// Token: 0x0600042B RID: 1067
		[Token(Token = "0x600042B")]
		public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

		// Token: 0x0600042C RID: 1068
		[Token(Token = "0x600042C")]
		public abstract void WriteChars(char[] buffer, int index, int count);

		// Token: 0x0600042D RID: 1069
		[Token(Token = "0x600042D")]
		public abstract void WriteRaw(char[] buffer, int index, int count);

		// Token: 0x0600042E RID: 1070
		[Token(Token = "0x600042E")]
		public abstract void WriteRaw(string data);

		// Token: 0x0600042F RID: 1071
		[Token(Token = "0x600042F")]
		public abstract void WriteBase64(byte[] buffer, int index, int count);

		// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x4FBCCC0", Offset = "0x4FBB8C0", VA = "0x184FBCCC0", Slot = "26")]
		public virtual void WriteBinHex(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000431 RID: 1073
		[Token(Token = "0x170000C8")]
		public abstract WriteState WriteState { [Token(Token = "0x6000431")] get; }

		// Token: 0x06000432 RID: 1074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "28")]
		public virtual void Close()
		{
		}

		// Token: 0x06000433 RID: 1075
		[Token(Token = "0x6000433")]
		public abstract void Flush();

		// Token: 0x06000434 RID: 1076
		[Token(Token = "0x6000434")]
		public abstract string LookupPrefix(string ns);

		// Token: 0x06000435 RID: 1077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x4FBCCF0", Offset = "0x4FBB8F0", VA = "0x184FBCCF0", Slot = "31")]
		public virtual void WriteValue(string value)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x4FBCBC0", Offset = "0x4FBB7C0", VA = "0x184FBCBC0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x4FBCB50", Offset = "0x4FBB750", VA = "0x184FBCB50", Slot = "32")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x4FBCA70", Offset = "0x4FBB670", VA = "0x184FBCA70")]
		public static XmlWriter Create(Stream output, XmlWriterSettings settings)
		{
			return null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x4FBCAE0", Offset = "0x4FBB6E0", VA = "0x184FBCAE0")]
		public static XmlWriter Create(TextWriter output, XmlWriterSettings settings)
		{
			return null;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected XmlWriter()
		{
		}
	}
}
