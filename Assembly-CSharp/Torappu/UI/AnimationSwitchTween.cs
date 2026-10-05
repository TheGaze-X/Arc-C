using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036F4 RID: 14068
	[Token(Token = "0x20036F4")]
	public class AnimationSwitchTween : UISwitchTween
	{
		// Token: 0x0601656C RID: 91500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601656C")]
		[Address(RVA = "0xEC0970", Offset = "0xEBF570", VA = "0x180EC0970")]
		public AnimationSwitchTween(UIAnimationLocation location, GameObject targetObject, float duration = -1f)
		{
		}

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0601656D RID: 91501 RVA: 0x00090A08 File Offset: 0x0008EC08
		// (set) Token: 0x0601656E RID: 91502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035A7")]
		public float duration
		{
			[Token(Token = "0x601656D")]
			[Address(RVA = "0xEC0B80", Offset = "0xEBF780", VA = "0x180EC0B80")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601656E")]
			[Address(RVA = "0xEC0C40", Offset = "0xEBF840", VA = "0x180EC0C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0601656F RID: 91503 RVA: 0x00090A20 File Offset: 0x0008EC20
		// (set) Token: 0x06016570 RID: 91504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035A8")]
		public bool inactivateTargetIfHide
		{
			[Token(Token = "0x601656F")]
			[Address(RVA = "0xEC0BE0", Offset = "0xEBF7E0", VA = "0x180EC0BE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016570")]
			[Address(RVA = "0xEC0CB0", Offset = "0xEBF8B0", VA = "0x180EC0CB0")]
			set
			{
			}
		}

		// Token: 0x06016571 RID: 91505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016571")]
		[Address(RVA = "0xEC02E0", Offset = "0xEBEEE0", VA = "0x180EC02E0", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x06016572 RID: 91506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016572")]
		[Address(RVA = "0xEC0500", Offset = "0xEBF100", VA = "0x180EC0500", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x06016573 RID: 91507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016573")]
		[Address(RVA = "0xEC0200", Offset = "0xEBEE00", VA = "0x180EC0200", Slot = "6")]
		protected override void BeforeShowEffect()
		{
		}

		// Token: 0x06016574 RID: 91508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016574")]
		[Address(RVA = "0xEC0180", Offset = "0xEBED80", VA = "0x180EC0180", Slot = "9")]
		protected override void AfterHideEffect()
		{
		}

		// Token: 0x06016575 RID: 91509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016575")]
		[Address(RVA = "0xEC0730", Offset = "0xEBF330", VA = "0x180EC0730", Slot = "10")]
		protected override void ResetToState(bool isShow)
		{
		}

		// Token: 0x06016576 RID: 91510 RVA: 0x00090A38 File Offset: 0x0008EC38
		[Token(Token = "0x6016576")]
		[Address(RVA = "0xEC07F0", Offset = "0xEBF3F0", VA = "0x180EC07F0")]
		private bool _ResetTargetDisplayStatus(bool isShow)
		{
			return default(bool);
		}

		// Token: 0x06016577 RID: 91511 RVA: 0x00090A50 File Offset: 0x0008EC50
		[Token(Token = "0x6016577")]
		[Address(RVA = "0xEC0880", Offset = "0xEBF480", VA = "0x180EC0880")]
		private bool _UseLastStopPos(UISwitchTween.TweenContext context)
		{
			return default(bool);
		}

		// Token: 0x06016578 RID: 91512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016578")]
		[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
		private void <>xLuaBaseProxy_BeforeShowEffect()
		{
		}

		// Token: 0x06016579 RID: 91513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016579")]
		[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
		private void <>xLuaBaseProxy_AfterHideEffect()
		{
		}

		// Token: 0x0601657A RID: 91514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601657A")]
		[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x0401ADE2 RID: 110050
		[Token(Token = "0x401ADE2")]
		[FieldOffset(Offset = "0x48")]
		private UIAnimationLocation m_animLocation;

		// Token: 0x0401ADE3 RID: 110051
		[Token(Token = "0x401ADE3")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_targetObject;

		// Token: 0x0401ADE4 RID: 110052
		[Token(Token = "0x401ADE4")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inactivateTargetIfHide;

		// Token: 0x0401ADE5 RID: 110053
		[Token(Token = "0x401ADE5")]
		[FieldOffset(Offset = "0x61")]
		private bool m_tweenFromStart;

		// Token: 0x0401ADE6 RID: 110054
		[Token(Token = "0x401ADE6")]
		[FieldOffset(Offset = "0x64")]
		private Ease m_ease;

		// Token: 0x0401ADE7 RID: 110055
		[Token(Token = "0x401ADE7")]
		[FieldOffset(Offset = "0x68")]
		private bool m_ignoreTimeScale;

		// Token: 0x0401ADE9 RID: 110057
		[Token(Token = "0x401ADE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401ADEA RID: 110058
		[Token(Token = "0x401ADEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_duration;

		// Token: 0x0401ADEB RID: 110059
		[Token(Token = "0x401ADEB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_duration;

		// Token: 0x0401ADEC RID: 110060
		[Token(Token = "0x401ADEC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_inactivateTargetIfHide;

		// Token: 0x0401ADED RID: 110061
		[Token(Token = "0x401ADED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_inactivateTargetIfHide;

		// Token: 0x0401ADEE RID: 110062
		[Token(Token = "0x401ADEE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

		// Token: 0x0401ADEF RID: 110063
		[Token(Token = "0x401ADEF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

		// Token: 0x0401ADF0 RID: 110064
		[Token(Token = "0x401ADF0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_BeforeShowEffect;

		// Token: 0x0401ADF1 RID: 110065
		[Token(Token = "0x401ADF1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AfterHideEffect;

		// Token: 0x0401ADF2 RID: 110066
		[Token(Token = "0x401ADF2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401ADF3 RID: 110067
		[Token(Token = "0x401ADF3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetTargetDisplayStatus;

		// Token: 0x0401ADF4 RID: 110068
		[Token(Token = "0x401ADF4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UseLastStopPos;

		// Token: 0x020036F5 RID: 14069
		[Token(Token = "0x20036F5")]
		public class AnimTweenWrapper : UISwitchTween.TweenWrapper, UISwitchTween.ITweenProgress, IHotfixable
		{
			// Token: 0x0601657B RID: 91515 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601657B")]
			[Address(RVA = "0xEC0090", Offset = "0xEBEC90", VA = "0x180EC0090")]
			public AnimTweenWrapper(UIAnimationTween tween)
			{
			}

			// Token: 0x0601657C RID: 91516 RVA: 0x00090A68 File Offset: 0x0008EC68
			[Token(Token = "0x601657C")]
			[Address(RVA = "0xEBFFD0", Offset = "0xEBEBD0", VA = "0x180EBFFD0", Slot = "8")]
			public float GetCurrPos()
			{
				return 0f;
			}

			// Token: 0x0401ADF5 RID: 110069
			[Token(Token = "0x401ADF5")]
			[FieldOffset(Offset = "0x18")]
			private UIAnimationTween m_animTween;

			// Token: 0x0401ADF6 RID: 110070
			[Token(Token = "0x401ADF6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401ADF7 RID: 110071
			[Token(Token = "0x401ADF7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetCurrPos;
		}

		// Token: 0x020036F6 RID: 14070
		[Token(Token = "0x20036F6")]
		public struct Builder
		{
			// Token: 0x0601657D RID: 91517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601657D")]
			[Address(RVA = "0xEC12D0", Offset = "0xEBFED0", VA = "0x180EC12D0")]
			public Builder(UIAnimationLocation location)
			{
			}

			// Token: 0x0601657E RID: 91518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601657E")]
			[Address(RVA = "0xEC0D20", Offset = "0xEBF920", VA = "0x180EC0D20")]
			public AnimationSwitchTween Build()
			{
				return null;
			}

			// Token: 0x0401ADF8 RID: 110072
			[Token(Token = "0x401ADF8")]
			[FieldOffset(Offset = "0x0")]
			private UIAnimationLocation m_location;

			// Token: 0x0401ADF9 RID: 110073
			[Token(Token = "0x401ADF9")]
			[FieldOffset(Offset = "0x10")]
			public float duration;

			// Token: 0x0401ADFA RID: 110074
			[Token(Token = "0x401ADFA")]
			[FieldOffset(Offset = "0x14")]
			public bool tweenFromStart;

			// Token: 0x0401ADFB RID: 110075
			[Token(Token = "0x401ADFB")]
			[FieldOffset(Offset = "0x18")]
			public GameObject target;

			// Token: 0x0401ADFC RID: 110076
			[Token(Token = "0x401ADFC")]
			[FieldOffset(Offset = "0x20")]
			public Ease ease;

			// Token: 0x0401ADFD RID: 110077
			[Token(Token = "0x401ADFD")]
			[FieldOffset(Offset = "0x24")]
			public bool inactivateTargetIfHide;

			// Token: 0x0401ADFE RID: 110078
			[Token(Token = "0x401ADFE")]
			[FieldOffset(Offset = "0x25")]
			public bool ignoreTimeScale;
		}
	}
}
