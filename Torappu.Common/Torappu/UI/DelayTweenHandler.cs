using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	public class DelayTweenHandler : UISwitchTween.ITweenHandler, IHotfixable
	{
		// Token: 0x060008CA RID: 2250 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x552F780", Offset = "0x552E380", VA = "0x18552F780")]
		public DelayTweenHandler(float delay)
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0000716C File Offset: 0x0000536C
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x552F4B0", Offset = "0x552E0B0", VA = "0x18552F4B0", Slot = "6")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x552F510", Offset = "0x552E110", VA = "0x18552F510", Slot = "7")]
		public void KillIfNecessary()
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x552F5A0", Offset = "0x552E1A0", VA = "0x18552F5A0", Slot = "5")]
		public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback)
		{
			return null;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x552F620", Offset = "0x552E220", VA = "0x18552F620", Slot = "4")]
		public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill)
		{
			return null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x552F6A0", Offset = "0x552E2A0", VA = "0x18552F6A0")]
		private void _OnDelayComplete()
		{
		}

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x10")]
		private int m_delayTimer;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x18")]
		private TweenCallback m_onComplete;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate24 _c__Hotfix0_ctor;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_IsPlaying;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_KillIfNecessary;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate175 __Hotfix0_OnComplete;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate176 __Hotfix0_SetAutoKill;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0__OnDelayComplete;
	}
}
