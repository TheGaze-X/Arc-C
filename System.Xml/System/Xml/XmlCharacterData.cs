using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	public abstract class XmlCharacterData : XmlLinkedNode
	{
		// Token: 0x0600049C RID: 1180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x4FA84A0", Offset = "0x4FA70A0", VA = "0x184FA84A0")]
		protected internal XmlCharacterData(string data, XmlDocument doc)
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FB")]
		public override string Value
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x4FA8680", Offset = "0x4FA7280", VA = "0x184FA8680", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x4FA8840", Offset = "0x4FA7440", VA = "0x184FA8840", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FC")]
		public override string InnerText
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x4C2D0B0", Offset = "0x4C2BCB0", VA = "0x184C2D0B0", Slot = "33")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x4FA87F0", Offset = "0x4FA73F0", VA = "0x184FA87F0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FD")]
		public virtual string Data
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x4FA8630", Offset = "0x4FA7230", VA = "0x184FA8630", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x4FA86C0", Offset = "0x4FA72C0", VA = "0x184FA86C0", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4FA8600", Offset = "0x4FA7200", VA = "0x184FA8600")]
		internal bool CheckOnData(string data)
		{
			return default(bool);
		}

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x20")]
		private string data;
	}
}
