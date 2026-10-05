using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public class FadeTranslationSwitchTween : UISwitchTween
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x5531050", Offset = "0x552FC50", VA = "0x185531050")]
		[HotfixIgnore]
		public void SetTargetPos(in Vector2 showPos, in Vector2 hidePos)
		{
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x5531220", Offset = "0x552FE20", VA = "0x185531220")]
		public FadeTranslationSwitchTween(CanvasGroup alphaHandler, RectTransform posHandler, Vector2 hidePos, Vector2 showPos, float duration = 0.16f, float hideDelay = 0f, float showDelay = 0f, Ease ease = Ease.OutQuad)
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x55309E0", Offset = "0x552F5E0", VA = "0x1855309E0", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x5530C00", Offset = "0x552F800", VA = "0x185530C00", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x5530960", Offset = "0x552F560", VA = "0x185530960", Slot = "6")]
		protected override void BeforeShowEffect()
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x55308E0", Offset = "0x552F4E0", VA = "0x1855308E0", Slot = "9")]
		protected override void AfterHideEffect()
		{
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x5530F60", Offset = "0x552FB60", VA = "0x185530F60", Slot = "10")]
		protected override void ResetToState(bool isShow)
		{
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000073C4 File Offset: 0x000055C4
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x5530E30", Offset = "0x552FA30", VA = "0x185530E30")]
		private float GetTargetAlpha(bool isShow)
		{
			return 0f;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000073DC File Offset: 0x000055DC
		[Token(Token = "0x6000930")]
		[Address(RVA = "0x5530EC0", Offset = "0x552FAC0", VA = "0x185530EC0")]
		private Vector2 GetTargetPos(bool isShow)
		{
			return default(Vector2);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x5531160", Offset = "0x552FD60", VA = "0x185531160")]
		private void <>xLuaBaseProxy_BeforeShowEffect()
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x5531100", Offset = "0x552FD00", VA = "0x185531100")]
		private void <>xLuaBaseProxy_AfterHideEffect()
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x55311C0", Offset = "0x552FDC0", VA = "0x1855311C0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x04000889 RID: 2185
		[Token(Token = "0x4000889")]
		private const float DEFAULT_TWEEN_DURATION = 0.16f;

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup m_alphaHandler;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_posHandler;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_hidePos;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_showPos;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0x68")]
		private float m_duration;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0x6C")]
		private float m_hideDelay;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x70")]
		private float m_showDelay;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0x74")]
		private Ease m_ease;

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate192 __Hotfix0_SetTargetPos;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate193 _c__Hotfix0_ctor;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate173 __Hotfix0_GenerateTweenOfHide;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate173 __Hotfix0_GenerateTweenOfShow;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0_BeforeShowEffect;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0_AfterHideEffect;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate6 __Hotfix0_ResetToState;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate194 __Hotfix0_GetTargetAlpha;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate195 __Hotfix0_GetTargetPos;

		// Token: 0x02000180 RID: 384
		[Token(Token = "0x2000180")]
		private class TweenHandler : UISwitchTween.ITweenHandler, IHotfixable
		{
			// Token: 0x06000934 RID: 2356 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x555D390", Offset = "0x555BF90", VA = "0x18555D390")]
			public TweenHandler(Tween alpha, Tween pos)
			{
			}

			// Token: 0x06000935 RID: 2357 RVA: 0x000073F4 File Offset: 0x000055F4
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x555D130", Offset = "0x555BD30", VA = "0x18555D130", Slot = "6")]
			public bool IsPlaying()
			{
				return default(bool);
			}

			// Token: 0x06000936 RID: 2358 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x555D1B0", Offset = "0x555BDB0", VA = "0x18555D1B0", Slot = "7")]
			public void KillIfNecessary()
			{
			}

			// Token: 0x06000937 RID: 2359 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x555D250", Offset = "0x555BE50", VA = "0x18555D250", Slot = "5")]
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback)
			{
				return null;
			}

			// Token: 0x06000938 RID: 2360 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x555D2E0", Offset = "0x555BEE0", VA = "0x18555D2E0", Slot = "4")]
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill)
			{
				return null;
			}

			// Token: 0x0400089B RID: 2203
			[Token(Token = "0x400089B")]
			[FieldOffset(Offset = "0x10")]
			private Tween m_alphaTweener;

			// Token: 0x0400089C RID: 2204
			[Token(Token = "0x400089C")]
			[FieldOffset(Offset = "0x18")]
			private Tween m_posTweener;

			// Token: 0x0400089D RID: 2205
			[Token(Token = "0x400089D")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate5 _c__Hotfix0_ctor;

			// Token: 0x0400089E RID: 2206
			[Token(Token = "0x400089E")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate21 __Hotfix0_IsPlaying;

			// Token: 0x0400089F RID: 2207
			[Token(Token = "0x400089F")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate1 __Hotfix0_KillIfNecessary;

			// Token: 0x040008A0 RID: 2208
			[Token(Token = "0x40008A0")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate175 __Hotfix0_OnComplete;

			// Token: 0x040008A1 RID: 2209
			[Token(Token = "0x40008A1")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate176 __Hotfix0_SetAutoKill;
		}
	}
}
