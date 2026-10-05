using System;
using System.Diagnostics;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	public abstract class UISwitchTween : IHotfixable, ILuaCallCSharp
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x000072BC File Offset: 0x000054BC
		[Token(Token = "0x170000E1")]
		protected bool isReleased
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x55489B0", Offset = "0x55475B0", VA = "0x1855489B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x000072D4 File Offset: 0x000054D4
		[Token(Token = "0x170000E2")]
		protected UISwitchTween.ResetStage resetStage
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x5548B00", Offset = "0x5547700", VA = "0x185548B00")]
			get
			{
				return UISwitchTween.ResetStage.NONE;
			}
		}

		// Token: 0x060008FD RID: 2301
		[Token(Token = "0x60008FD")]
		protected abstract UISwitchTween.ITweenHandler GenerateTweenOfShow();

		// Token: 0x060008FE RID: 2302
		[Token(Token = "0x60008FE")]
		protected abstract UISwitchTween.ITweenHandler GenerateTweenOfHide();

		// Token: 0x060008FF RID: 2303 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x5531160", Offset = "0x552FD60", VA = "0x185531160", Slot = "6")]
		protected virtual void BeforeShowEffect()
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x5547C30", Offset = "0x5546830", VA = "0x185547C30", Slot = "7")]
		protected virtual void BeforeHideEffect()
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x5547BD0", Offset = "0x55467D0", VA = "0x185547BD0", Slot = "8")]
		protected virtual void AfterShowEffect()
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x5531100", Offset = "0x552FD00", VA = "0x185531100", Slot = "9")]
		protected virtual void AfterHideEffect()
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x55311C0", Offset = "0x552FDC0", VA = "0x1855311C0", Slot = "10")]
		protected virtual void ResetToState(bool isShow)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x552F3A0", Offset = "0x552DFA0", VA = "0x18552F3A0", Slot = "11")]
		protected virtual void OnResetOperation(UISwitchTween.ResetStage stage)
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x5547F20", Offset = "0x5546B20", VA = "0x185547F20", Slot = "12")]
		protected virtual void OnRelease()
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x55484A0", Offset = "0x55470A0", VA = "0x1855484A0")]
		public void Show()
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x5547D20", Offset = "0x5546920", VA = "0x185547D20")]
		public void Hide()
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x5548410", Offset = "0x5547010", VA = "0x185548410")]
		public void SetOptions(UISwitchTween.Options options)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x000072EC File Offset: 0x000054EC
		[Token(Token = "0x170000E3")]
		public bool isTweening
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x5548A70", Offset = "0x5547670", VA = "0x185548A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x55480F0", Offset = "0x5546CF0", VA = "0x1855480F0")]
		public void ResetOrTween(bool isShow)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x00007304 File Offset: 0x00005504
		// (set) Token: 0x0600090C RID: 2316 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000E4")]
		public bool isShow
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x5548A10", Offset = "0x5547610", VA = "0x185548A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x5548B60", Offset = "0x5547760", VA = "0x185548B60")]
			set
			{
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x55482D0", Offset = "0x5546ED0", VA = "0x1855482D0")]
		public void Reset(bool isShow)
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x5548060", Offset = "0x5546C60", VA = "0x185548060")]
		public void Release()
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0000731C File Offset: 0x0000551C
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
		protected UISwitchTween.TweenContext GetContext()
		{
			return default(UISwitchTween.TweenContext);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x5547C90", Offset = "0x5546890", VA = "0x185547C90")]
		protected void ClearTween()
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x55487D0", Offset = "0x55473D0", VA = "0x1855487D0")]
		private void _ClearTweenInternal(bool isReset)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x5548890", Offset = "0x5547490", VA = "0x185548890")]
		private void _TriggerResetOperation(UISwitchTween.ResetStage stage)
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00007334 File Offset: 0x00005534
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x5547F80", Offset = "0x5546B80", VA = "0x185547F80")]
		protected float ReadLastPosIfInterrupted(float defaultVal)
		{
			return 0f;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x5548740", Offset = "0x5547340", VA = "0x185548740")]
		[Conditional("UNITY_EDITOR")]
		protected static void UnitTestMarkTweenInvalid(Tween tween)
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x5548940", Offset = "0x5547540", VA = "0x185548940")]
		protected UISwitchTween()
		{
		}

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x10")]
		private UISwitchTween.Options m_options;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x30")]
		private UISwitchTween.ITweenHandler m_tween;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isShowing;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x3A")]
		private bool m_isReleased;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x3C")]
		private UISwitchTween.ResetStage m_resetStage;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween.TweenContext m_context;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isReleased;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate190 __Hotfix0_get_resetStage;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_BeforeShowEffect;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_BeforeHideEffect;

		// Token: 0x04000860 RID: 2144
		[Token(Token = "0x4000860")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate1 __Hotfix0_AfterShowEffect;

		// Token: 0x04000861 RID: 2145
		[Token(Token = "0x4000861")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0_AfterHideEffect;

		// Token: 0x04000862 RID: 2146
		[Token(Token = "0x4000862")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate6 __Hotfix0_ResetToState;

		// Token: 0x04000863 RID: 2147
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate174 __Hotfix0_OnResetOperation;

		// Token: 0x04000864 RID: 2148
		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnRelease;

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Show;

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Hide;

		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate191 __Hotfix0_SetOptions;

		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isTweening;

		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate6 __Hotfix0_ResetOrTween;

		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isShow;

		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate6 __Hotfix0_set_isShow;

		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate6 __Hotfix0_Reset;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Release;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ClearTween;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate6 __Hotfix0__ClearTweenInternal;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate174 __Hotfix0__TriggerResetOperation;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		[FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate115 __Hotfix0_ReadLastPosIfInterrupted;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_UnitTestMarkTweenInvalid;

		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		[FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000178 RID: 376
		[Token(Token = "0x2000178")]
		public struct Options
		{
			// Token: 0x04000874 RID: 2164
			[Token(Token = "0x4000874")]
			[FieldOffset(Offset = "0x0")]
			public Action afterShowEffect;

			// Token: 0x04000875 RID: 2165
			[Token(Token = "0x4000875")]
			[FieldOffset(Offset = "0x8")]
			public Action afterHideEffect;

			// Token: 0x04000876 RID: 2166
			[Token(Token = "0x4000876")]
			[FieldOffset(Offset = "0x10")]
			public Action<bool> onStateChanged;

			// Token: 0x04000877 RID: 2167
			[Token(Token = "0x4000877")]
			[FieldOffset(Offset = "0x18")]
			public Action<UISwitchTween.ResetStage> onResetOperation;
		}

		// Token: 0x02000179 RID: 377
		[Token(Token = "0x2000179")]
		protected struct TweenContext : IHotfixable
		{
			// Token: 0x06000918 RID: 2328 RVA: 0x0000734C File Offset: 0x0000554C
			[Token(Token = "0x6000918")]
			[Address(RVA = "0x5536C80", Offset = "0x5535880", VA = "0x185536C80")]
			public bool IsInterrupted()
			{
				return default(bool);
			}

			// Token: 0x06000919 RID: 2329 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000919")]
			[Address(RVA = "0x3EE1D70", Offset = "0x3EE0970", VA = "0x183EE1D70")]
			public void OnReset()
			{
			}

			// Token: 0x0600091A RID: 2330 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600091A")]
			[Address(RVA = "0x5536CE0", Offset = "0x55358E0", VA = "0x185536CE0")]
			public void OnTweenStop(UISwitchTween.ITweenProgress tweenProgress)
			{
			}

			// Token: 0x04000878 RID: 2168
			[Token(Token = "0x4000878")]
			[FieldOffset(Offset = "0x0")]
			public float lastStopPos;
		}

		// Token: 0x0200017A RID: 378
		[Token(Token = "0x200017A")]
		public interface ITweenHandler : IHotfixable
		{
			// Token: 0x0600091B RID: 2331
			[Token(Token = "0x600091B")]
			UISwitchTween.ITweenHandler SetAutoKill(bool autoKill);

			// Token: 0x0600091C RID: 2332
			[Token(Token = "0x600091C")]
			UISwitchTween.ITweenHandler OnComplete(TweenCallback callback);

			// Token: 0x0600091D RID: 2333
			[Token(Token = "0x600091D")]
			bool IsPlaying();

			// Token: 0x0600091E RID: 2334
			[Token(Token = "0x600091E")]
			void KillIfNecessary();
		}

		// Token: 0x0200017B RID: 379
		[Token(Token = "0x200017B")]
		public interface ITweenProgress : IHotfixable
		{
			// Token: 0x0600091F RID: 2335
			[Token(Token = "0x600091F")]
			float GetCurrPos();
		}

		// Token: 0x0200017C RID: 380
		[Token(Token = "0x200017C")]
		public enum ResetStage
		{
			// Token: 0x0400087A RID: 2170
			[Token(Token = "0x400087A")]
			NONE,
			// Token: 0x0400087B RID: 2171
			[Token(Token = "0x400087B")]
			BEFORE_SHOW_EFFECT,
			// Token: 0x0400087C RID: 2172
			[Token(Token = "0x400087C")]
			AFTER_SHOW_EFFECT,
			// Token: 0x0400087D RID: 2173
			[Token(Token = "0x400087D")]
			BEFORE_HIDE_EFFECT,
			// Token: 0x0400087E RID: 2174
			[Token(Token = "0x400087E")]
			AFTER_HIDE_EFFECT,
			// Token: 0x0400087F RID: 2175
			[Token(Token = "0x400087F")]
			RESET_TO_STATE
		}

		// Token: 0x0200017D RID: 381
		[Token(Token = "0x200017D")]
		public class TweenWrapper : UISwitchTween.ITweenHandler, IHotfixable
		{
			// Token: 0x06000920 RID: 2336 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x55373F0", Offset = "0x5535FF0", VA = "0x1855373F0")]
			public TweenWrapper(Tween tween)
			{
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x00007364 File Offset: 0x00005564
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x5537160", Offset = "0x5535D60", VA = "0x185537160")]
			public bool IsActive()
			{
				return default(bool);
			}

			// Token: 0x06000922 RID: 2338 RVA: 0x0000737C File Offset: 0x0000557C
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x55371D0", Offset = "0x5535DD0", VA = "0x1855371D0", Slot = "6")]
			public bool IsPlaying()
			{
				return default(bool);
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x5537240", Offset = "0x5535E40", VA = "0x185537240", Slot = "7")]
			public void KillIfNecessary()
			{
			}

			// Token: 0x06000924 RID: 2340 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x55372C0", Offset = "0x5535EC0", VA = "0x1855372C0", Slot = "5")]
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback)
			{
				return null;
			}

			// Token: 0x06000925 RID: 2341 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x5537350", Offset = "0x5535F50", VA = "0x185537350", Slot = "4")]
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill)
			{
				return null;
			}

			// Token: 0x04000880 RID: 2176
			[Token(Token = "0x4000880")]
			[FieldOffset(Offset = "0x10")]
			private Tween m_tween;

			// Token: 0x04000881 RID: 2177
			[Token(Token = "0x4000881")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate0 _c__Hotfix0_ctor;

			// Token: 0x04000882 RID: 2178
			[Token(Token = "0x4000882")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate21 __Hotfix0_IsActive;

			// Token: 0x04000883 RID: 2179
			[Token(Token = "0x4000883")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate21 __Hotfix0_IsPlaying;

			// Token: 0x04000884 RID: 2180
			[Token(Token = "0x4000884")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate1 __Hotfix0_KillIfNecessary;

			// Token: 0x04000885 RID: 2181
			[Token(Token = "0x4000885")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate175 __Hotfix0_OnComplete;

			// Token: 0x04000886 RID: 2182
			[Token(Token = "0x4000886")]
			[FieldOffset(Offset = "0x28")]
			private static __XLua_Gen_Delegate176 __Hotfix0_SetAutoKill;
		}

		// Token: 0x0200017E RID: 382
		[Token(Token = "0x200017E")]
		public struct Durations
		{
			// Token: 0x06000926 RID: 2342 RVA: 0x00007394 File Offset: 0x00005594
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x552F890", Offset = "0x552E490", VA = "0x18552F890")]
			public float GetShowDuration(float defaultDuration)
			{
				return 0f;
			}

			// Token: 0x06000927 RID: 2343 RVA: 0x000073AC File Offset: 0x000055AC
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x552F880", Offset = "0x552E480", VA = "0x18552F880")]
			public float GetHideDuration(float defaultDuration)
			{
				return 0f;
			}

			// Token: 0x04000887 RID: 2183
			[Token(Token = "0x4000887")]
			[FieldOffset(Offset = "0x0")]
			public float show;

			// Token: 0x04000888 RID: 2184
			[Token(Token = "0x4000888")]
			[FieldOffset(Offset = "0x4")]
			public float hide;
		}
	}
}
