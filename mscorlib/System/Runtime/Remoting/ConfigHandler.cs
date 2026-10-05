using System;
using System.Collections;
using Il2CppDummyDll;
using Mono.Xml;

namespace System.Runtime.Remoting
{
	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	internal class ConfigHandler : SmallXmlParser.IContentHandler
	{
		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x4B5BBF0", Offset = "0x4B5A7F0", VA = "0x184B5BBF0")]
		public ConfigHandler(bool onlyDelayedChannels)
		{
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x4B5BB00", Offset = "0x4B5A700", VA = "0x184B5BB00")]
		private void ValidatePath(string element, params string[] paths)
		{
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x4B57E30", Offset = "0x4B56A30", VA = "0x184B57E30")]
		private bool CheckPath(string path)
		{
			return default(bool);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnStartParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public void OnProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public void OnIgnorableWhitespace(string s)
		{
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x4B58340", Offset = "0x4B56F40", VA = "0x184B58340", Slot = "6")]
		public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x4B584B0", Offset = "0x4B570B0", VA = "0x184B584B0")]
		public void ParseElement(string name, SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x4B58150", Offset = "0x4B56D50", VA = "0x184B58150", Slot = "7")]
		public void OnEndElement(string name)
		{
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x4B5A640", Offset = "0x4B59240", VA = "0x184B5A640")]
		private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x4B5AC80", Offset = "0x4B59880", VA = "0x184B5AC80")]
		private void ReadLifetine(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x4B59990", Offset = "0x4B58590", VA = "0x184B59990")]
		private System.TimeSpan ParseTime(string s)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x4B59D20", Offset = "0x4B58920", VA = "0x184B59D20")]
		private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x4B5B1B0", Offset = "0x4B59DB0", VA = "0x184B5B1B0")]
		private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			return null;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x4B5A280", Offset = "0x4B58E80", VA = "0x184B5A280")]
		private void ReadClientActivated(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x4B5B6E0", Offset = "0x4B5A2E0", VA = "0x184B5B6E0")]
		private void ReadServiceActivated(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x4B5A530", Offset = "0x4B59130", VA = "0x184B5A530")]
		private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x4B5B8F0", Offset = "0x4B5A4F0", VA = "0x184B5B8F0")]
		private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x4B5AAD0", Offset = "0x4B596D0", VA = "0x184B5AAD0")]
		private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement)
		{
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x4B5AFB0", Offset = "0x4B59BB0", VA = "0x184B5AFB0")]
		private void ReadPreload(SmallXmlParser.IAttrList attrs)
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x4B58060", Offset = "0x4B56C60", VA = "0x184B58060")]
		private string GetNotNull(SmallXmlParser.IAttrList attrs, string name)
		{
			return null;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x4B57F80", Offset = "0x4B56B80", VA = "0x184B57F80")]
		private string ExtractAssembly(ref string type)
		{
			return null;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void OnChars(string ch)
		{
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBD")]
		[Address(RVA = "0x4B58230", Offset = "0x4B56E30", VA = "0x184B58230", Slot = "5")]
		public void OnEndParsing(SmallXmlParser parser)
		{
		}

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.ArrayList typeEntries;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x18")]
		private System.Collections.ArrayList channelInstances;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x20")]
		private ChannelData currentChannel;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x28")]
		private System.Collections.Stack currentProviderData;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[FieldOffset(Offset = "0x30")]
		private string currentClientUrl;

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0x38")]
		private string appName;

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x40")]
		private string currentXmlPath;

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x48")]
		private bool onlyDelayedChannels;
	}
}
