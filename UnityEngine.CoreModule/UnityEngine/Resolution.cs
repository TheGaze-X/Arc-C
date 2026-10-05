using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	[RequiredByNativeCode]
	public struct Resolution
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00002FD0 File Offset: 0x000011D0
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C1")]
		public int width
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			set
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00002FE8 File Offset: 0x000011E8
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C2")]
		public int height
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x566210", Offset = "0x564E10", VA = "0x180566210")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			set
			{
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00003000 File Offset: 0x00001200
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		public int refreshRate
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			set
			{
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x593FDE0", Offset = "0x593E9E0", VA = "0x18593FDE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x0")]
		private int m_Width;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x4")]
		private int m_Height;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x8")]
		private int m_RefreshRate;
	}
}
