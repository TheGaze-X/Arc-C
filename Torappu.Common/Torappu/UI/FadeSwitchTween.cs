using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.DynTargetTween;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	public class FadeSwitchTween : DynTargetSwitchTween<CanvasGroup>
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00007184 File Offset: 0x00005384
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000D9")]
		private protected Ease ease
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x55304F0", Offset = "0x552F0F0", VA = "0x1855304F0")]
			[CompilerGenerated]
			protected get
			{
				return Ease.Unset;
			}
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x5530870", Offset = "0x552F470", VA = "0x185530870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0000719C File Offset: 0x0000539C
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000DA")]
		private protected bool dontDisableGameObject
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x5530430", Offset = "0x552F030", VA = "0x185530430")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x5530790", Offset = "0x552F390", VA = "0x185530790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000071B4 File Offset: 0x000053B4
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000DB")]
		private protected FadeSwitchTween.ControlRaycastMode controlBlockRaycast
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x55303D0", Offset = "0x552EFD0", VA = "0x1855303D0")]
			[CompilerGenerated]
			protected get
			{
				return FadeSwitchTween.ControlRaycastMode.NONE;
			}
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x5530720", Offset = "0x552F320", VA = "0x185530720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000071CC File Offset: 0x000053CC
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000DC")]
		private protected UISwitchTween.Durations complexDuration
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x5530360", Offset = "0x552EF60", VA = "0x185530360")]
			[CompilerGenerated]
			protected get
			{
				return default(UISwitchTween.Durations);
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x55306A0", Offset = "0x552F2A0", VA = "0x1855306A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000071E4 File Offset: 0x000053E4
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000DD")]
		public float duration
		{
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x5530490", Offset = "0x552F090", VA = "0x185530490")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x5530800", Offset = "0x552F400", VA = "0x185530800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000071FC File Offset: 0x000053FC
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000DE")]
		public float activeAlpha
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x5530300", Offset = "0x552EF00", VA = "0x185530300")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x5530550", Offset = "0x552F150", VA = "0x185530550")]
			set
			{
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x55300F0", Offset = "0x552ECF0", VA = "0x1855300F0")]
		public FadeSwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale)
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x5530190", Offset = "0x552ED90", VA = "0x185530190")]
		public FadeSwitchTween(CanvasGroup alphaHandler, float duration = 0.16f, bool ignoreTimeScale = true)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x552F8A0", Offset = "0x552E4A0", VA = "0x18552F8A0", Slot = "19")]
		protected override Tween PrepareTweenOfHide(RefTuple<CanvasGroup> targets, ref DynTargetSwitchTween.TweenMeta meta)
		{
			return null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x552F9B0", Offset = "0x552E5B0", VA = "0x18552F9B0", Slot = "18")]
		protected override Tween PrepareTweenOfShow(RefTuple<CanvasGroup> targets, ref DynTargetSwitchTween.TweenMeta meta)
		{
			return null;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x552FD10", Offset = "0x552E910", VA = "0x18552FD10")]
		private Tween _PrepareTweenImpl(RefTuple<CanvasGroup> targets, ref DynTargetSwitchTween.TweenMeta meta, float fromAlpha, float toAlpha, float duration)
		{
			return null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x552FAC0", Offset = "0x552E6C0", VA = "0x18552FAC0", Slot = "16")]
		protected override void ResetBeforeTweening()
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x552FB30", Offset = "0x552E730", VA = "0x18552FB30", Slot = "17")]
		protected override void ResetWhenStable()
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x552FF40", Offset = "0x552EB40", VA = "0x18552FF40")]
		private void _ResetCanvasGroupProperty(bool isActive, bool isStable)
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x552FBE0", Offset = "0x552E7E0", VA = "0x18552FBE0", Slot = "20")]
		protected virtual void SetObjectActive(CanvasGroup alphaHandler, bool isActive)
		{
		}

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		public const float DEFAULT_TWEEN_DURATION = 0.16f;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x58")]
		private bool m_ignoreTimeScale;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x5C")]
		private float m_activeAlpha;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x78")]
		private CanvasGroupAlphaTweener m_tweener;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate177 __Hotfix0_get_ease;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate178 __Hotfix0_set_ease;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_dontDisableGameObject;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_dontDisableGameObject;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate179 __Hotfix0_get_controlBlockRaycast;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate180 __Hotfix0_set_controlBlockRaycast;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate181 __Hotfix0_get_complexDuration;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate182 __Hotfix0_set_complexDuration;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_duration;

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate24 __Hotfix0_set_duration;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate23 __Hotfix0_get_activeAlpha;

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate24 __Hotfix0_set_activeAlpha;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate183 _c__Hotfix0_ctor;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate184 _c__Hotfix1_ctor;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ResetBeforeTweening;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ResetWhenStable;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate185 __Hotfix0__ResetCanvasGroupProperty;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate183 __Hotfix0_SetObjectActive;

		// Token: 0x0200016F RID: 367
		[Token(Token = "0x200016F")]
		public enum ControlRaycastMode
		{
			// Token: 0x0400082E RID: 2094
			[Token(Token = "0x400082E")]
			NONE,
			// Token: 0x0400082F RID: 2095
			[Token(Token = "0x400082F")]
			ENABLE_WHEN_ACTIVE,
			// Token: 0x04000830 RID: 2096
			[Token(Token = "0x4000830")]
			ENABLE_WHEN_STABLE
		}

		// Token: 0x02000170 RID: 368
		[Token(Token = "0x2000170")]
		public struct Builder
		{
			// Token: 0x170000DF RID: 223
			// (set) Token: 0x060008E5 RID: 2277 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000DF")]
			[Obsolete("Use \"ControlRaycastAndKeepActive\" instead.")]
			public bool controlBlockRaycast
			{
				[Token(Token = "0x60008E5")]
				[Address(RVA = "0x552F000", Offset = "0x552DC00", VA = "0x18552F000")]
				set
				{
				}
			}

			// Token: 0x060008E6 RID: 2278 RVA: 0x00007214 File Offset: 0x00005414
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x552EF90", Offset = "0x552DB90", VA = "0x18552EF90")]
			public FadeSwitchTween.Builder ControlRaycastAndKeepActive(bool useStableRaycast = false)
			{
				return default(FadeSwitchTween.Builder);
			}

			// Token: 0x060008E7 RID: 2279 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x552EFE0", Offset = "0x552DBE0", VA = "0x18552EFE0")]
			public Builder(FadeSwitchTween.Builder other)
			{
			}

			// Token: 0x060008E8 RID: 2280 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x552EC90", Offset = "0x552D890", VA = "0x18552EC90")]
			public FadeSwitchTween Build()
			{
				return null;
			}

			// Token: 0x060008E9 RID: 2281 RVA: 0x0000722C File Offset: 0x0000542C
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x552EFC0", Offset = "0x552DBC0", VA = "0x18552EFC0")]
			public static FadeSwitchTween.Builder Default4Button()
			{
				return default(FadeSwitchTween.Builder);
			}

			// Token: 0x04000831 RID: 2097
			[Token(Token = "0x4000831")]
			[FieldOffset(Offset = "0x0")]
			public CanvasGroup alphaHandler;

			// Token: 0x04000832 RID: 2098
			[Token(Token = "0x4000832")]
			[FieldOffset(Offset = "0x8")]
			public bool useTimeScale;

			// Token: 0x04000833 RID: 2099
			[Token(Token = "0x4000833")]
			[FieldOffset(Offset = "0x9")]
			public bool dontDisableGameObject;

			// Token: 0x04000834 RID: 2100
			[Token(Token = "0x4000834")]
			[FieldOffset(Offset = "0xC")]
			public FadeSwitchTween.ControlRaycastMode controlRaycastMode;

			// Token: 0x04000835 RID: 2101
			[Token(Token = "0x4000835")]
			[FieldOffset(Offset = "0x10")]
			public float duration;

			// Token: 0x04000836 RID: 2102
			[Token(Token = "0x4000836")]
			[FieldOffset(Offset = "0x14")]
			public UISwitchTween.Durations complexDuration;

			// Token: 0x04000837 RID: 2103
			[Token(Token = "0x4000837")]
			[FieldOffset(Offset = "0x1C")]
			public Ease ease;
		}
	}
}
