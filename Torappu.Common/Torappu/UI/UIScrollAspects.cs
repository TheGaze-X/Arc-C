using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	public class UIScrollAspects : ScrollAspects, IHotfixable
	{
		// Token: 0x0600094C RID: 2380 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x555F9B0", Offset = "0x555E5B0", VA = "0x18555F9B0", Slot = "4")]
		public override void OnEnable(ScrollRect scrollRect)
		{
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x555FC00", Offset = "0x555E800", VA = "0x18555FC00", Slot = "6")]
		public override void OnScrollEvent(PointerEventData data, ScrollRect scrollRect)
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x555FD10", Offset = "0x555E910", VA = "0x18555FD10", Slot = "7")]
		public override void OnScrollHandle(Vector2 scrollDelta, ScrollRect scrollRect)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x555FDD0", Offset = "0x555E9D0", VA = "0x18555FDD0", Slot = "5")]
		public override void OnUpdate(float deltaTime, ScrollRect scrollRect)
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x555F870", Offset = "0x555E470", VA = "0x18555F870")]
		public static void BindToUGUI()
		{
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x555F710", Offset = "0x555E310", VA = "0x18555F710")]
		public void BindListener(ScrollWheelHandler handler, ScrollRect scrollRect)
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x555FED0", Offset = "0x555EAD0", VA = "0x18555FED0")]
		public UIScrollAspects()
		{
		}

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0x0")]
		public static UIScrollAspects s_instance;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate0 __Hotfix0_OnEnable;

		// Token: 0x040008AD RID: 2221
		[Token(Token = "0x40008AD")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate5 __Hotfix0_OnScrollEvent;

		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x40008AE")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate196 __Hotfix0_OnScrollHandle;

		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x40008AF")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate197 __Hotfix0_OnUpdate;

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate14 __Hotfix0_BindToUGUI;

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate5 __Hotfix0_BindListener;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
