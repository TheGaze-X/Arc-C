using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act0D5
{
	// Token: 0x02007B61 RID: 31585
	[Token(Token = "0x2007B61")]
	public class Activity0D5ResHolder : ActivityResHolder
	{
		// Token: 0x17006790 RID: 26512
		// (get) Token: 0x0602C358 RID: 181080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006790")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x602C358")]
			[Address(RVA = "0x281BC30", Offset = "0x281A830", VA = "0x18281BC30", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006791 RID: 26513
		// (get) Token: 0x0602C359 RID: 181081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006791")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x602C359")]
			[Address(RVA = "0x281BBD0", Offset = "0x281A7D0", VA = "0x18281BBD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C35A RID: 181082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C35A")]
		[Address(RVA = "0x281BB70", Offset = "0x281A770", VA = "0x18281BB70")]
		public Activity0D5ResHolder()
		{
		}

		// Token: 0x04040176 RID: 262518
		[Token(Token = "0x4040176")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x04040177 RID: 262519
		[Token(Token = "0x4040177")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x04040178 RID: 262520
		[Token(Token = "0x4040178")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x04040179 RID: 262521
		[Token(Token = "0x4040179")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
