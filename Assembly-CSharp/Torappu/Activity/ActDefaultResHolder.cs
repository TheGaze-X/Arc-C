using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D46 RID: 27974
	[Token(Token = "0x2006D46")]
	public class ActDefaultResHolder : ActivityResHolder, IHotfixable
	{
		// Token: 0x17005E51 RID: 24145
		// (get) Token: 0x06027DFE RID: 163326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E51")]
		public override Sprite homeSprite
		{
			[Token(Token = "0x6027DFE")]
			[Address(RVA = "0x22EE3A0", Offset = "0x22ECFA0", VA = "0x1822EE3A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E52 RID: 24146
		// (get) Token: 0x06027DFF RID: 163327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E52")]
		public override Sprite homeSpriteMultiMode
		{
			[Token(Token = "0x6027DFF")]
			[Address(RVA = "0x22EE340", Offset = "0x22ECF40", VA = "0x1822EE340", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005E53 RID: 24147
		// (get) Token: 0x06027E00 RID: 163328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E53")]
		public override Sprite topbarSprite
		{
			[Token(Token = "0x6027E00")]
			[Address(RVA = "0x22EE400", Offset = "0x22ED000", VA = "0x1822EE400", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027E01 RID: 163329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E01")]
		[Address(RVA = "0x22EE2A0", Offset = "0x22ECEA0", VA = "0x1822EE2A0")]
		public ActDefaultResHolder()
		{
		}

		// Token: 0x06027E02 RID: 163330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E02")]
		[Address(RVA = "0x22EE240", Offset = "0x22ECE40", VA = "0x1822EE240")]
		private Sprite <>xLuaBaseProxy_get_homeSpriteMultiMode()
		{
			return null;
		}

		// Token: 0x0403885D RID: 231517
		[Token(Token = "0x403885D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeSprite;

		// Token: 0x0403885E RID: 231518
		[Token(Token = "0x403885E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeSpriteMultiMode;

		// Token: 0x0403885F RID: 231519
		[Token(Token = "0x403885F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _topbarSprite;

		// Token: 0x04038860 RID: 231520
		[Token(Token = "0x4038860")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_homeSprite;

		// Token: 0x04038861 RID: 231521
		[Token(Token = "0x4038861")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_homeSpriteMultiMode;

		// Token: 0x04038862 RID: 231522
		[Token(Token = "0x4038862")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topbarSprite;

		// Token: 0x04038863 RID: 231523
		[Token(Token = "0x4038863")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
