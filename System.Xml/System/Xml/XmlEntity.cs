using System;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public class XmlEntity : XmlNode
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x4FCC660", Offset = "0x4FCB260", VA = "0x184FCC660")]
		internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc)
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x4FCC5D0", Offset = "0x4FCB1D0", VA = "0x184FCC5D0", Slot = "27")]
		public override XmlNode CloneNode(bool deep)
		{
			return null;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x17000147")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000148")]
		public override string Name
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		public override string LocalName
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014A")]
		public override string InnerText
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x4FCBB20", Offset = "0x4FCA720", VA = "0x184FCBB20", Slot = "33")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x4FCC8D0", Offset = "0x4FCB4D0", VA = "0x184FCC8D0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x1700014B")]
		internal override bool IsContainer
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014C")]
		internal override XmlLinkedNode LastNode
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x4FCC7C0", Offset = "0x4FCB3C0", VA = "0x184FCC7C0", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x4FCC640", Offset = "0x4FCB240", VA = "0x184FCC640", Slot = "24")]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return default(bool);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x1700014D")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x54BA20", Offset = "0x54A620", VA = "0x18054BA20", Slot = "9")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014E")]
		public string SystemId
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014F")]
		public override string InnerXml
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x4FCC940", Offset = "0x4FCB540", VA = "0x184FCC940", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000150")]
		public override string BaseURI
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
		internal void SetBaseURI(string inBaseURI)
		{
		}

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x18")]
		private string publicId;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x20")]
		private string systemId;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x28")]
		private string notationName;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x30")]
		private string name;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x38")]
		private string unparsedReplacementStr;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x40")]
		private string baseURI;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x48")]
		private XmlLinkedNode lastChild;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x50")]
		private bool childrenFoliating;
	}
}
