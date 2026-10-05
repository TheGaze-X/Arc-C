using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B54 RID: 31572
	[Token(Token = "0x2007B54")]
	public class ActivityFirstResHolder : ActivityResHolder
	{
		// Token: 0x17006787 RID: 26503
		// (get) Token: 0x0602C325 RID: 181029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006787")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x602C325")]
			[Address(RVA = "0x281E9A0", Offset = "0x281D5A0", VA = "0x18281E9A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006788 RID: 26504
		// (get) Token: 0x0602C326 RID: 181030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006788")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x602C326")]
			[Address(RVA = "0x281E940", Offset = "0x281D540", VA = "0x18281E940", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C327 RID: 181031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C327")]
		[Address(RVA = "0x281E8E0", Offset = "0x281D4E0", VA = "0x18281E8E0")]
		public ActivityFirstResHolder()
		{
		}

		// Token: 0x0404010A RID: 262410
		[Token(Token = "0x404010A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0404010B RID: 262411
		[Token(Token = "0x404010B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x0404010C RID: 262412
		[Token(Token = "0x404010C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x0404010D RID: 262413
		[Token(Token = "0x404010D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
