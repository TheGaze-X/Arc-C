using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036F0 RID: 14064
	[Token(Token = "0x20036F0")]
	public class UIAnimationTween : IHotfixable, ILuaCallCSharp
	{
		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0601655B RID: 91483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035A6")]
		public Tween handler
		{
			[Token(Token = "0x601655B")]
			[Address(RVA = "0xECE4F0", Offset = "0xECD0F0", VA = "0x180ECE4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601655C RID: 91484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601655C")]
		[Address(RVA = "0xECE0D0", Offset = "0xECCCD0", VA = "0x180ECE0D0")]
		private UIAnimationTween(GameObject target, AnimationClip clip, float duration, UIAnimationTween.Options options)
		{
		}

		// Token: 0x0601655D RID: 91485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601655D")]
		[Address(RVA = "0xECDF10", Offset = "0xECCB10", VA = "0x180ECDF10")]
		public UIAnimationTween(GameObject target, UIAnimationLocation anim)
		{
		}

		// Token: 0x0601655E RID: 91486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601655E")]
		[Address(RVA = "0xECE1F0", Offset = "0xECCDF0", VA = "0x180ECE1F0")]
		public UIAnimationTween(GameObject target, UIAnimationLocation anim, float duration)
		{
		}

		// Token: 0x0601655F RID: 91487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601655F")]
		[Address(RVA = "0xECE3B0", Offset = "0xECCFB0", VA = "0x180ECE3B0")]
		public UIAnimationTween(GameObject target, UIAnimationLocation anim, float duration, UIAnimationTween.Options options)
		{
		}

		// Token: 0x06016560 RID: 91488 RVA: 0x000909C0 File Offset: 0x0008EBC0
		[Token(Token = "0x6016560")]
		[Address(RVA = "0xECCE60", Offset = "0xECBA60", VA = "0x180ECCE60")]
		public float GetValue()
		{
			return 0f;
		}

		// Token: 0x06016561 RID: 91489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016561")]
		[Address(RVA = "0xECD420", Offset = "0xECC020", VA = "0x180ECD420")]
		private void _ConstructorImpl(GameObject target, AnimationWrapper.AnimationHandler handler, float duration, UIAnimationTween.Options options)
		{
		}

		// Token: 0x06016562 RID: 91490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016562")]
		[Address(RVA = "0xECD220", Offset = "0xECBE20", VA = "0x180ECD220")]
		private static List<AnimationEvent> _CollectEventsToFire(AnimationWrapper.AnimationHandler handler)
		{
			return null;
		}

		// Token: 0x06016563 RID: 91491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016563")]
		[Address(RVA = "0xECDBB0", Offset = "0xECC7B0", VA = "0x180ECDBB0")]
		private void _TryFireAnimationEvents(GameObject target, bool isLoopCrossing, bool isDirSwitched, float fromLerp, float toLerp, float clipLength)
		{
		}

		// Token: 0x06016564 RID: 91492 RVA: 0x000909D8 File Offset: 0x0008EBD8
		[Token(Token = "0x6016564")]
		[Address(RVA = "0xECD070", Offset = "0xECBC70", VA = "0x180ECD070")]
		private bool _CheckLoopCrossing(int prevLoop, int currLoop)
		{
			return default(bool);
		}

		// Token: 0x06016565 RID: 91493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016565")]
		[Address(RVA = "0xECD140", Offset = "0xECBD40", VA = "0x180ECD140")]
		private void _ClearEventRecord()
		{
		}

		// Token: 0x06016566 RID: 91494 RVA: 0x000909F0 File Offset: 0x0008EBF0
		[Token(Token = "0x6016566")]
		[Address(RVA = "0xECCED0", Offset = "0xECBAD0", VA = "0x180ECCED0")]
		private bool _CheckInTimeSpan(bool isLoopCrossing, bool isDirSwitched, float evtTime, float fromTime, float toTime)
		{
			return default(bool);
		}

		// Token: 0x06016567 RID: 91495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016567")]
		[Address(RVA = "0xECD740", Offset = "0xECC340", VA = "0x180ECD740")]
		private void _FireAnimationEvent(GameObject target, AnimationEvent evt)
		{
		}

		// Token: 0x06016568 RID: 91496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016568")]
		[Address(RVA = "0xECD960", Offset = "0xECC560", VA = "0x180ECD960")]
		private void _SetValue(float value)
		{
		}

		// Token: 0x0401ADC1 RID: 110017
		[Token(Token = "0x401ADC1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIAnimationTween.Options DEFAULT_OPTION;

		// Token: 0x0401ADC2 RID: 110018
		[Token(Token = "0x401ADC2")]
		[FieldOffset(Offset = "0x10")]
		private Tween m_handler;

		// Token: 0x0401ADC3 RID: 110019
		[Token(Token = "0x401ADC3")]
		[FieldOffset(Offset = "0x18")]
		private float m_tweenValue;

		// Token: 0x0401ADC4 RID: 110020
		[Token(Token = "0x401ADC4")]
		[FieldOffset(Offset = "0x1C")]
		private int m_tweenLoop;

		// Token: 0x0401ADC5 RID: 110021
		[Token(Token = "0x401ADC5")]
		[FieldOffset(Offset = "0x20")]
		private bool m_tweenBackward;

		// Token: 0x0401ADC6 RID: 110022
		[Token(Token = "0x401ADC6")]
		[FieldOffset(Offset = "0x28")]
		private AnimationWrapper.AnimationHandler m_animationHandler;

		// Token: 0x0401ADC7 RID: 110023
		[Token(Token = "0x401ADC7")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_animTarget;

		// Token: 0x0401ADC8 RID: 110024
		[Token(Token = "0x401ADC8")]
		[FieldOffset(Offset = "0x38")]
		private List<AnimationEvent> m_eventsToFire;

		// Token: 0x0401ADC9 RID: 110025
		[Token(Token = "0x401ADC9")]
		[FieldOffset(Offset = "0x40")]
		private int[] m_eventsConsumed;

		// Token: 0x0401ADCA RID: 110026
		[Token(Token = "0x401ADCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x0401ADCB RID: 110027
		[Token(Token = "0x401ADCB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401ADCC RID: 110028
		[Token(Token = "0x401ADCC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0401ADCD RID: 110029
		[Token(Token = "0x401ADCD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix2_ctor;

		// Token: 0x0401ADCE RID: 110030
		[Token(Token = "0x401ADCE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix3_ctor;

		// Token: 0x0401ADCF RID: 110031
		[Token(Token = "0x401ADCF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0401ADD0 RID: 110032
		[Token(Token = "0x401ADD0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ConstructorImpl;

		// Token: 0x0401ADD1 RID: 110033
		[Token(Token = "0x401ADD1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CollectEventsToFire;

		// Token: 0x0401ADD2 RID: 110034
		[Token(Token = "0x401ADD2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryFireAnimationEvents;

		// Token: 0x0401ADD3 RID: 110035
		[Token(Token = "0x401ADD3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckLoopCrossing;

		// Token: 0x0401ADD4 RID: 110036
		[Token(Token = "0x401ADD4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearEventRecord;

		// Token: 0x0401ADD5 RID: 110037
		[Token(Token = "0x401ADD5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckInTimeSpan;

		// Token: 0x0401ADD6 RID: 110038
		[Token(Token = "0x401ADD6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__FireAnimationEvent;

		// Token: 0x0401ADD7 RID: 110039
		[Token(Token = "0x401ADD7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetValue;

		// Token: 0x020036F1 RID: 14065
		[Token(Token = "0x20036F1")]
		public struct Options
		{
			// Token: 0x0401ADD8 RID: 110040
			[Token(Token = "0x401ADD8")]
			[FieldOffset(Offset = "0x0")]
			public bool isInverse;

			// Token: 0x0401ADD9 RID: 110041
			[Token(Token = "0x401ADD9")]
			[FieldOffset(Offset = "0x4")]
			public float startPosition;

			// Token: 0x0401ADDA RID: 110042
			[Token(Token = "0x401ADDA")]
			[FieldOffset(Offset = "0x8")]
			public bool enableEvents;
		}

		// Token: 0x020036F2 RID: 14066
		[Token(Token = "0x20036F2")]
		public struct Builder
		{
			// Token: 0x0601656A RID: 91498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601656A")]
			[Address(RVA = "0xEC0FF0", Offset = "0xEBFBF0", VA = "0x180EC0FF0")]
			public UIAnimationTween Build()
			{
				return null;
			}

			// Token: 0x0401ADDB RID: 110043
			[Token(Token = "0x401ADDB")]
			[FieldOffset(Offset = "0x0")]
			public UIAnimationTween.Options options;

			// Token: 0x0401ADDC RID: 110044
			[Token(Token = "0x401ADDC")]
			[FieldOffset(Offset = "0x10")]
			public UIAnimationLocation animLocation;

			// Token: 0x0401ADDD RID: 110045
			[Token(Token = "0x401ADDD")]
			[FieldOffset(Offset = "0x20")]
			public float duration;
		}

		// Token: 0x020036F3 RID: 14067
		[Token(Token = "0x20036F3")]
		public struct ClipBuilder
		{
			// Token: 0x0601656B RID: 91499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601656B")]
			[Address(RVA = "0xEC1580", Offset = "0xEC0180", VA = "0x180EC1580")]
			public UIAnimationTween Build()
			{
				return null;
			}

			// Token: 0x0401ADDE RID: 110046
			[Token(Token = "0x401ADDE")]
			[FieldOffset(Offset = "0x0")]
			public UIAnimationTween.Options options;

			// Token: 0x0401ADDF RID: 110047
			[Token(Token = "0x401ADDF")]
			[FieldOffset(Offset = "0x10")]
			public AnimationClip clip;

			// Token: 0x0401ADE0 RID: 110048
			[Token(Token = "0x401ADE0")]
			[FieldOffset(Offset = "0x18")]
			public GameObject target;

			// Token: 0x0401ADE1 RID: 110049
			[Token(Token = "0x401ADE1")]
			[FieldOffset(Offset = "0x20")]
			public float duration;
		}
	}
}
