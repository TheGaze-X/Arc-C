using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public class XmlText : XmlCharacterData
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x4FD7460", Offset = "0x4FD6060", VA = "0x184FD7460")]
		internal XmlText(string strData)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x4FD7450", Offset = "0x4FD6050", VA = "0x184FD7450")]
		protected internal XmlText(string strData, XmlDocument doc)
		{
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019F")]
		public override string Name
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x4FD7470", Offset = "0x4FD6070", VA = "0x184FD7470", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A0")]
		public override string LocalName
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x4FD7470", Offset = "0x4FD6070", VA = "0x184FD7470", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x170001A1")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A2")]
		public override XmlNode ParentNode
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x4FA8530", Offset = "0x4FA7130", VA = "0x184FA8530", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x4FD73A0", Offset = "0x4FD5FA0", VA = "0x184FD73A0", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A3")]
		public override string Value
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x4FA8680", Offset = "0x4FA7280", VA = "0x184FA8680", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x4FD74C0", Offset = "0x4FD60C0", VA = "0x184FD74C0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x170001A4")]
		internal override bool IsText
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "45")]
			get
			{
				return default(bool);
			}
		}
	}
}
