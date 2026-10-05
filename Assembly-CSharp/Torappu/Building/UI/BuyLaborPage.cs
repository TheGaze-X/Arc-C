using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AE5 RID: 6885
	[Token(Token = "0x2001AE5")]
	public class BuyLaborPage : BuildingCommonPage
	{
		// Token: 0x0600AE03 RID: 44547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE03")]
		[Address(RVA = "0x3299F00", Offset = "0x3298B00", VA = "0x183299F00", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0600AE04 RID: 44548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE04")]
		[Address(RVA = "0x3299FC0", Offset = "0x3298BC0", VA = "0x183299FC0")]
		public BuyLaborPage()
		{
		}

		// Token: 0x0600AE06 RID: 44550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE06")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0400A65D RID: 42589
		[Token(Token = "0x400A65D")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0400A65E RID: 42590
		[Token(Token = "0x400A65E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0400A65F RID: 42591
		[Token(Token = "0x400A65F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
