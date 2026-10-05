using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.PostEffect
{
	// Token: 0x02001457 RID: 5207
	[Token(Token = "0x2001457")]
	public abstract class PostEffectBaseE : PostEffectBase
	{
		// Token: 0x060078AE RID: 30894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AE")]
		[Address(RVA = "0x2642F30", Offset = "0x2641B30", VA = "0x182642F30", Slot = "8")]
		protected override void OnPreRender()
		{
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AF")]
		[Address(RVA = "0x2642ED0", Offset = "0x2641AD0", VA = "0x182642ED0", Slot = "9")]
		protected override void OnPostRender()
		{
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B0")]
		[Address(RVA = "0x2642F90", Offset = "0x2641B90", VA = "0x182642F90", Slot = "10")]
		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B1")]
		[Address(RVA = "0x2643190", Offset = "0x2641D90", VA = "0x182643190")]
		protected PostEffectBaseE()
		{
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B2")]
		[Address(RVA = "0x2643180", Offset = "0x2641D80", VA = "0x182643180")]
		private void <>xLuaBaseProxy_OnPreRender()
		{
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B3")]
		[Address(RVA = "0x2643070", Offset = "0x2641C70", VA = "0x182643070")]
		private void <>xLuaBaseProxy_OnPostRender()
		{
		}

		// Token: 0x0400769E RID: 30366
		[Token(Token = "0x400769E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPreRender;

		// Token: 0x0400769F RID: 30367
		[Token(Token = "0x400769F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPostRender;

		// Token: 0x040076A0 RID: 30368
		[Token(Token = "0x40076A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRenderImage;

		// Token: 0x040076A1 RID: 30369
		[Token(Token = "0x40076A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
