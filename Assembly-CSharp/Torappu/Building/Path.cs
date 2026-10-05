using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017E0 RID: 6112
	[Token(Token = "0x20017E0")]
	public struct Path
	{
		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06009A83 RID: 39555 RVA: 0x0003C060 File Offset: 0x0003A260
		[Token(Token = "0x170010D5")]
		public bool isValid
		{
			[Token(Token = "0x6009A83")]
			[Address(RVA = "0x3147B30", Offset = "0x3146730", VA = "0x183147B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06009A84 RID: 39556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D6")]
		public GridMap.Node startNode
		{
			[Token(Token = "0x6009A84")]
			[Address(RVA = "0x3147B70", Offset = "0x3146770", VA = "0x183147B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06009A85 RID: 39557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D7")]
		public GridMap.Node endNode
		{
			[Token(Token = "0x6009A85")]
			[Address(RVA = "0x3147AC0", Offset = "0x31466C0", VA = "0x183147AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A86")]
		[Address(RVA = "0x3147900", Offset = "0x3146500", VA = "0x183147900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040090D9 RID: 37081
		[Token(Token = "0x40090D9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Path NULL;

		// Token: 0x040090DA RID: 37082
		[Token(Token = "0x40090DA")]
		[FieldOffset(Offset = "0x0")]
		public int distance;

		// Token: 0x040090DB RID: 37083
		[Token(Token = "0x40090DB")]
		[FieldOffset(Offset = "0x8")]
		public GridMap.Node[] nodes;
	}
}
