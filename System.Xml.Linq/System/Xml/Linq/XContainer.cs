using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml.Linq
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public abstract class XContainer : XNode
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal XContainer()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4F89750", Offset = "0x4F88350", VA = "0x184F89750")]
		internal XContainer(XContainer other)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public XNode LastNode
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x4F89910", Offset = "0x4F88510", VA = "0x184F89910")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4F87FB0", Offset = "0x4F86BB0", VA = "0x184F87FB0")]
		public void Add(object content)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4F88D80", Offset = "0x4F87980", VA = "0x184F88D80")]
		public IEnumerable<XNode> Nodes()
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4F89130", Offset = "0x4F87D30", VA = "0x184F89130")]
		public void RemoveNodes()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		internal virtual void AddAttribute(XAttribute a)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		internal virtual void AddAttributeSkipNotify(XAttribute a)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4F87170", Offset = "0x4F85D70", VA = "0x184F87170")]
		internal void AddContentSkipNotify(object content)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4F87940", Offset = "0x4F86540", VA = "0x184F87940")]
		internal void AddNode(XNode n)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4F87870", Offset = "0x4F86470", VA = "0x184F87870")]
		internal void AddNodeSkipNotify(XNode n)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4F87B90", Offset = "0x4F86790", VA = "0x184F87B90")]
		internal void AddString(string s)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4F87A10", Offset = "0x4F86610", VA = "0x184F87A10")]
		internal void AddStringSkipNotify(string s)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4F88560", Offset = "0x4F87160", VA = "0x184F88560")]
		internal void AppendNode(XNode n)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4F88420", Offset = "0x4F87020", VA = "0x184F88420")]
		internal void AppendNodeSkipNotify(XNode n)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4F88690", Offset = "0x4F87290", VA = "0x184F88690", Slot = "6")]
		internal override void AppendText(StringBuilder sb)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4F887D0", Offset = "0x4F873D0", VA = "0x184F887D0")]
		internal void ConvertTextToNode()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4F88910", Offset = "0x4F87510", VA = "0x184F88910")]
		internal static string GetStringValue(object value)
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4F88E00", Offset = "0x4F87A00", VA = "0x184F88E00")]
		internal void RemoveNode(XNode n)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4F89040", Offset = "0x4F87C40", VA = "0x184F89040")]
		private void RemoveNodesSkipNotify()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		internal virtual void ValidateNode(XNode node, XNode previous)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		internal virtual void ValidateString(string s)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4F895B0", Offset = "0x4F881B0", VA = "0x184F895B0")]
		internal void WriteContentTo(XmlWriter writer)
		{
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		internal object content;
	}
}
