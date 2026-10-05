using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200143E RID: 5182
	[Token(Token = "0x200143E")]
	public struct ShopComplexPriceOptions
	{
		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x060077D8 RID: 30680 RVA: 0x00035C58 File Offset: 0x00033E58
		// (set) Token: 0x060077D9 RID: 30681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E58")]
		public bool overrideColor
		{
			[Token(Token = "0x60077D8")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60077D9")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060077DA RID: 30682 RVA: 0x00035C70 File Offset: 0x00033E70
		// (set) Token: 0x060077DB RID: 30683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E59")]
		public Color color
		{
			[Token(Token = "0x60077DA")]
			[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60077DB")]
			[Address(RVA = "0x253ECB0", Offset = "0x253D8B0", VA = "0x18253ECB0")]
			set
			{
			}
		}

		// Token: 0x0400756F RID: 30063
		[Token(Token = "0x400756F")]
		[FieldOffset(Offset = "0x0")]
		private Color m_color;

		// Token: 0x04007571 RID: 30065
		[Token(Token = "0x4007571")]
		[FieldOffset(Offset = "0x18")]
		public ShopCashInfo cashInfo;

		// Token: 0x04007572 RID: 30066
		[Token(Token = "0x4007572")]
		[FieldOffset(Offset = "0x28")]
		public Sprite sprite;
	}
}
