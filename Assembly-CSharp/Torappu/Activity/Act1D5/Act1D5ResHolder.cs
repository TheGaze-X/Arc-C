using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1D5
{
	// Token: 0x020078F8 RID: 30968
	[Token(Token = "0x20078F8")]
	public class Act1D5ResHolder : ActivityResHolder, IHotfixable
	{
		// Token: 0x170065B3 RID: 26035
		// (get) Token: 0x0602B6C7 RID: 177863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065B3")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x602B6C7")]
			[Address(RVA = "0x2754010", Offset = "0x2752C10", VA = "0x182754010", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170065B4 RID: 26036
		// (get) Token: 0x0602B6C8 RID: 177864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170065B4")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x602B6C8")]
			[Address(RVA = "0x2753FB0", Offset = "0x2752BB0", VA = "0x182753FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B6C9 RID: 177865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6C9")]
		[Address(RVA = "0x2753F50", Offset = "0x2752B50", VA = "0x182753F50")]
		public Act1D5ResHolder()
		{
		}

		// Token: 0x0403ECBE RID: 257214
		[Token(Token = "0x403ECBE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403ECBF RID: 257215
		[Token(Token = "0x403ECBF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0403ECC0 RID: 257216
		[Token(Token = "0x403ECC0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0403ECC1 RID: 257217
		[Token(Token = "0x403ECC1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
