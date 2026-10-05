using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	public class XmlEntityReference : XmlLinkedNode
	{
		// Token: 0x0600055D RID: 1373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x4FCC1B0", Offset = "0x4FCADB0", VA = "0x184FCC1B0")]
		protected internal XmlEntityReference(string name, XmlDocument doc)
		{
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public override string Name
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		public override string LocalName
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000153")]
		public override string Value
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x4FCC560", Offset = "0x4FCB160", VA = "0x184FCC560", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x17000154")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x4FCBF10", Offset = "0x4FCAB10", VA = "0x184FCBF10", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x17000155")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x17000156")]
		internal override bool IsContainer
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x4FCC0A0", Offset = "0x4FCACA0", VA = "0x184FCC0A0", Slot = "39")]
		internal override void SetParent(XmlNode node)
		{
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x4FCC050", Offset = "0x4FCAC50", VA = "0x184FCC050", Slot = "40")]
		internal override void SetParentForLoad(XmlNode node)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000157")]
		internal override XmlLinkedNode LastNode
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x4FCB480", Offset = "0x4FCA080", VA = "0x184FCB480", Slot = "24")]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return default(bool);
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000158")]
		public override string BaseURI
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x4FCC360", Offset = "0x4FCAF60", VA = "0x184FCC360", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x4FCBF90", Offset = "0x4FCAB90", VA = "0x184FCBF90")]
		private string ConstructBaseURI(string baseURI, string systemId)
		{
			return null;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000159")]
		internal string ChildBaseURI
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x4FCC3D0", Offset = "0x4FCAFD0", VA = "0x184FCC3D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x28")]
		private XmlLinkedNode lastChild;
	}
}
