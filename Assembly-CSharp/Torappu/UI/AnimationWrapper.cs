using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036C9 RID: 14025
	[Token(Token = "0x20036C9")]
	[RequireComponent(typeof(Animation))]
	public sealed class AnimationWrapper : MonoBehaviour, IHotfixable, ILuaCallCSharp
	{
		// Token: 0x0601648E RID: 91278 RVA: 0x00090540 File Offset: 0x0008E740
		[Token(Token = "0x601648E")]
		[Address(RVA = "0xEA6D00", Offset = "0xEA5900", VA = "0x180EA6D00")]
		public static bool IsMaintainedEvent(string evtName)
		{
			return default(bool);
		}

		// Token: 0x0601648F RID: 91279 RVA: 0x00090558 File Offset: 0x0008E758
		[Token(Token = "0x601648F")]
		[Address(RVA = "0xEA7150", Offset = "0xEA5D50", VA = "0x180EA7150")]
		public bool Play(string stateName, AnimationOptions option)
		{
			return default(bool);
		}

		// Token: 0x06016490 RID: 91280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016490")]
		[Address(RVA = "0xEA6F70", Offset = "0xEA5B70", VA = "0x180EA6F70")]
		public Tween PlayWithTween(string stateName, [Optional] TweenCallback onComplete, bool enableEvents = false)
		{
			return null;
		}

		// Token: 0x06016491 RID: 91281 RVA: 0x00090570 File Offset: 0x0008E770
		[Token(Token = "0x6016491")]
		[Address(RVA = "0xEA7300", Offset = "0xEA5F00", VA = "0x180EA7300")]
		public bool Play(string stateName)
		{
			return default(bool);
		}

		// Token: 0x06016492 RID: 91282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016492")]
		[Address(RVA = "0xEA7A00", Offset = "0xEA6600", VA = "0x180EA7A00")]
		public void Stop(string name, bool triggerEnd)
		{
		}

		// Token: 0x06016493 RID: 91283 RVA: 0x00090588 File Offset: 0x0008E788
		[Token(Token = "0x6016493")]
		[Address(RVA = "0xEA6DA0", Offset = "0xEA59A0", VA = "0x180EA6DA0")]
		public bool IsPlaying(string name)
		{
			return default(bool);
		}

		// Token: 0x06016494 RID: 91284 RVA: 0x000905A0 File Offset: 0x0008E7A0
		[Token(Token = "0x6016494")]
		[Address(RVA = "0xEA6BD0", Offset = "0xEA57D0", VA = "0x180EA6BD0")]
		public float GetClipLength(string name)
		{
			return 0f;
		}

		// Token: 0x06016495 RID: 91285 RVA: 0x000905B8 File Offset: 0x0008E7B8
		[Token(Token = "0x6016495")]
		[Address(RVA = "0xEA77F0", Offset = "0xEA63F0", VA = "0x180EA77F0")]
		public bool SampleClip(string name, float position)
		{
			return default(bool);
		}

		// Token: 0x06016496 RID: 91286 RVA: 0x000905D0 File Offset: 0x0008E7D0
		[Token(Token = "0x6016496")]
		[Address(RVA = "0xEA73C0", Offset = "0xEA5FC0", VA = "0x180EA73C0")]
		public bool SampleClipAtBegin(string name)
		{
			return default(bool);
		}

		// Token: 0x06016497 RID: 91287 RVA: 0x000905E8 File Offset: 0x0008E7E8
		[Token(Token = "0x6016497")]
		[Address(RVA = "0xEA7620", Offset = "0xEA6220", VA = "0x180EA7620")]
		public bool SampleClipAtEnd(string name)
		{
			return default(bool);
		}

		// Token: 0x06016498 RID: 91288 RVA: 0x00090600 File Offset: 0x0008E800
		[Token(Token = "0x6016498")]
		[Address(RVA = "0xEA7440", Offset = "0xEA6040", VA = "0x180EA7440")]
		public bool SampleClipAtEndEPS(string name)
		{
			return default(bool);
		}

		// Token: 0x06016499 RID: 91289 RVA: 0x00090618 File Offset: 0x0008E818
		[Token(Token = "0x6016499")]
		[Address(RVA = "0xEA6AC0", Offset = "0xEA56C0", VA = "0x180EA6AC0")]
		public AnimationWrapper.AnimationHandler GetClipHandler(string name)
		{
			return default(AnimationWrapper.AnimationHandler);
		}

		// Token: 0x0601649A RID: 91290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601649A")]
		[Address(RVA = "0xEA6CA0", Offset = "0xEA58A0", VA = "0x180EA6CA0")]
		public void InitIfNot()
		{
		}

		// Token: 0x0601649B RID: 91291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601649B")]
		[Address(RVA = "0xEA6A60", Offset = "0xEA5660", VA = "0x180EA6A60")]
		private void Awake()
		{
		}

		// Token: 0x0601649C RID: 91292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601649C")]
		[Address(RVA = "0xEA6E20", Offset = "0xEA5A20", VA = "0x180EA6E20")]
		private void OnDisable()
		{
		}

		// Token: 0x0601649D RID: 91293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601649D")]
		[Address(RVA = "0xEA88E0", Offset = "0xEA74E0", VA = "0x180EA88E0")]
		private void _OnAnimStart(string stateName)
		{
		}

		// Token: 0x0601649E RID: 91294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601649E")]
		[Address(RVA = "0xEA8450", Offset = "0xEA7050", VA = "0x180EA8450")]
		private void _OnAnimEnd(string stateName)
		{
		}

		// Token: 0x0601649F RID: 91295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601649F")]
		[Address(RVA = "0xEA8040", Offset = "0xEA6C40", VA = "0x180EA8040")]
		private void _FinishAnimation(AnimationWrapper.AnimationRuntime runtime, bool isTriggerEnd)
		{
		}

		// Token: 0x060164A0 RID: 91296 RVA: 0x00090630 File Offset: 0x0008E830
		[Token(Token = "0x60164A0")]
		[Address(RVA = "0xEA9370", Offset = "0xEA7F70", VA = "0x180EA9370")]
		private bool _SyncAnimatingStatus(string name)
		{
			return default(bool);
		}

		// Token: 0x060164A1 RID: 91297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164A1")]
		[Address(RVA = "0xEA8F70", Offset = "0xEA7B70", VA = "0x180EA8F70")]
		private AnimationWrapper.AnimationRuntime _SetupOnAnimationStart(string stateName, AnimationOptions option)
		{
			return null;
		}

		// Token: 0x060164A2 RID: 91298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164A2")]
		[Address(RVA = "0xEA7F80", Offset = "0xEA6B80", VA = "0x180EA7F80")]
		private void _CleanOnAnimationEnd(string name)
		{
		}

		// Token: 0x060164A3 RID: 91299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164A3")]
		[Address(RVA = "0xEA7E60", Offset = "0xEA6A60", VA = "0x180EA7E60")]
		private void _CleanAllAnimOnDisable()
		{
		}

		// Token: 0x060164A4 RID: 91300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164A4")]
		[Address(RVA = "0xEA92A0", Offset = "0xEA7EA0", VA = "0x180EA92A0")]
		private void _StopTargetAnimation(string name)
		{
		}

		// Token: 0x060164A5 RID: 91301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164A5")]
		[Address(RVA = "0xEA97F0", Offset = "0xEA83F0", VA = "0x180EA97F0")]
		private void _TranverseTargetStates(Action<AnimationState> onState)
		{
		}

		// Token: 0x060164A6 RID: 91302 RVA: 0x00090648 File Offset: 0x0008E848
		[Token(Token = "0x60164A6")]
		[Address(RVA = "0xEA83B0", Offset = "0xEA6FB0", VA = "0x180EA83B0")]
		private bool _IsValidAnimation(string stateName)
		{
			return default(bool);
		}

		// Token: 0x060164A7 RID: 91303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164A7")]
		[Address(RVA = "0xEA9AB0", Offset = "0xEA86B0", VA = "0x180EA9AB0")]
		private void _WrapAnimationComponentIfNot()
		{
		}

		// Token: 0x060164A8 RID: 91304 RVA: 0x00090660 File Offset: 0x0008E860
		[Token(Token = "0x60164A8")]
		[Address(RVA = "0xEA8300", Offset = "0xEA6F00", VA = "0x180EA8300")]
		private bool _IsAnimFinishEvent(AnimationWrapper.AnimationRuntime runtime, bool isEndCallback)
		{
			return default(bool);
		}

		// Token: 0x060164A9 RID: 91305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164A9")]
		[Address(RVA = "0xEA8D70", Offset = "0xEA7970", VA = "0x180EA8D70")]
		private void _SampleClipAtEnd(AnimationWrapper.AnimationRuntime runtime)
		{
		}

		// Token: 0x060164AA RID: 91306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164AA")]
		[Address(RVA = "0xEA8E40", Offset = "0xEA7A40", VA = "0x180EA8E40")]
		private void _SampleClipAtLength(AnimationWrapper.AnimationRuntime runtime, float position)
		{
		}

		// Token: 0x060164AB RID: 91307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164AB")]
		[Address(RVA = "0xEA68E0", Offset = "0xEA54E0", VA = "0x180EA68E0")]
		public List<string> AchieveSelectableAnimList()
		{
			return null;
		}

		// Token: 0x060164AC RID: 91308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164AC")]
		[Address(RVA = "0xEA9C10", Offset = "0xEA8810", VA = "0x180EA9C10")]
		public AnimationWrapper()
		{
		}

		// Token: 0x0401ACD5 RID: 109781
		[Token(Token = "0x401ACD5")]
		public const string ON_ANIM_START = "_OnAnimStart";

		// Token: 0x0401ACD6 RID: 109782
		[Token(Token = "0x401ACD6")]
		public const string ON_ANIM_END = "_OnAnimEnd";

		// Token: 0x0401ACD7 RID: 109783
		[Token(Token = "0x401ACD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animation m_target;

		// Token: 0x0401ACD8 RID: 109784
		[Token(Token = "0x401ACD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, AnimationWrapper.AnimationRuntime> m_animPool;

		// Token: 0x0401ACD9 RID: 109785
		[Token(Token = "0x401ACD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isWrapped;

		// Token: 0x0401ACDA RID: 109786
		[Token(Token = "0x401ACDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_timeAccum;

		// Token: 0x0401ACDB RID: 109787
		[Token(Token = "0x401ACDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_beginWatchTime;

		// Token: 0x0401ACDC RID: 109788
		[Token(Token = "0x401ACDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsMaintainedEvent;

		// Token: 0x0401ACDD RID: 109789
		[Token(Token = "0x401ACDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0401ACDE RID: 109790
		[Token(Token = "0x401ACDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayWithTween;

		// Token: 0x0401ACDF RID: 109791
		[Token(Token = "0x401ACDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_Play;

		// Token: 0x0401ACE0 RID: 109792
		[Token(Token = "0x401ACE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0401ACE1 RID: 109793
		[Token(Token = "0x401ACE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsPlaying;

		// Token: 0x0401ACE2 RID: 109794
		[Token(Token = "0x401ACE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetClipLength;

		// Token: 0x0401ACE3 RID: 109795
		[Token(Token = "0x401ACE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SampleClip;

		// Token: 0x0401ACE4 RID: 109796
		[Token(Token = "0x401ACE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SampleClipAtBegin;

		// Token: 0x0401ACE5 RID: 109797
		[Token(Token = "0x401ACE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SampleClipAtEnd;

		// Token: 0x0401ACE6 RID: 109798
		[Token(Token = "0x401ACE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SampleClipAtEndEPS;

		// Token: 0x0401ACE7 RID: 109799
		[Token(Token = "0x401ACE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetClipHandler;

		// Token: 0x0401ACE8 RID: 109800
		[Token(Token = "0x401ACE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0401ACE9 RID: 109801
		[Token(Token = "0x401ACE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401ACEA RID: 109802
		[Token(Token = "0x401ACEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401ACEB RID: 109803
		[Token(Token = "0x401ACEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnAnimStart;

		// Token: 0x0401ACEC RID: 109804
		[Token(Token = "0x401ACEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnAnimEnd;

		// Token: 0x0401ACED RID: 109805
		[Token(Token = "0x401ACED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__FinishAnimation;

		// Token: 0x0401ACEE RID: 109806
		[Token(Token = "0x401ACEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SyncAnimatingStatus;

		// Token: 0x0401ACEF RID: 109807
		[Token(Token = "0x401ACEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SetupOnAnimationStart;

		// Token: 0x0401ACF0 RID: 109808
		[Token(Token = "0x401ACF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CleanOnAnimationEnd;

		// Token: 0x0401ACF1 RID: 109809
		[Token(Token = "0x401ACF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CleanAllAnimOnDisable;

		// Token: 0x0401ACF2 RID: 109810
		[Token(Token = "0x401ACF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__StopTargetAnimation;

		// Token: 0x0401ACF3 RID: 109811
		[Token(Token = "0x401ACF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TranverseTargetStates;

		// Token: 0x0401ACF4 RID: 109812
		[Token(Token = "0x401ACF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__IsValidAnimation;

		// Token: 0x0401ACF5 RID: 109813
		[Token(Token = "0x401ACF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__WrapAnimationComponentIfNot;

		// Token: 0x0401ACF6 RID: 109814
		[Token(Token = "0x401ACF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__IsAnimFinishEvent;

		// Token: 0x0401ACF7 RID: 109815
		[Token(Token = "0x401ACF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__SampleClipAtEnd;

		// Token: 0x0401ACF8 RID: 109816
		[Token(Token = "0x401ACF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SampleClipAtLength;

		// Token: 0x0401ACF9 RID: 109817
		[Token(Token = "0x401ACF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_AchieveSelectableAnimList;

		// Token: 0x0401ACFA RID: 109818
		[Token(Token = "0x401ACFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020036CA RID: 14026
		[Token(Token = "0x20036CA")]
		private class AnimationRuntime
		{
			// Token: 0x060164AD RID: 91309 RVA: 0x00090678 File Offset: 0x0008E878
			[Token(Token = "0x60164AD")]
			[Address(RVA = "0xEA6830", Offset = "0xEA5430", VA = "0x180EA6830")]
			public float GetClipLength()
			{
				return 0f;
			}

			// Token: 0x060164AE RID: 91310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60164AE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AnimationRuntime()
			{
			}

			// Token: 0x0401ACFB RID: 109819
			[Token(Token = "0x401ACFB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AnimationOptions option;

			// Token: 0x0401ACFC RID: 109820
			[Token(Token = "0x401ACFC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationState state;

			// Token: 0x0401ACFD RID: 109821
			[Token(Token = "0x401ACFD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool isPlaying;
		}

		// Token: 0x020036CB RID: 14027
		[Token(Token = "0x20036CB")]
		public struct AnimationHandler : ILuaCallCSharp
		{
			// Token: 0x060164AF RID: 91311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60164AF")]
			[Address(RVA = "0xEA6750", Offset = "0xEA5350", VA = "0x180EA6750")]
			public AnimationHandler(AnimationState animState)
			{
			}

			// Token: 0x060164B0 RID: 91312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60164B0")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			public AnimationHandler(AnimationClip animClip)
			{
			}

			// Token: 0x060164B1 RID: 91313 RVA: 0x00090690 File Offset: 0x0008E890
			[Token(Token = "0x60164B1")]
			[Address(RVA = "0xEA6620", Offset = "0xEA5220", VA = "0x180EA6620")]
			public float GetClipLength()
			{
				return 0f;
			}

			// Token: 0x060164B2 RID: 91314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60164B2")]
			[Address(RVA = "0xEA6720", Offset = "0xEA5320", VA = "0x180EA6720")]
			public void SampleClip(GameObject target, float clipPos)
			{
			}

			// Token: 0x060164B3 RID: 91315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60164B3")]
			[Address(RVA = "0xEA6650", Offset = "0xEA5250", VA = "0x180EA6650")]
			public AnimationEvent[] GetEvents()
			{
				return null;
			}

			// Token: 0x060164B4 RID: 91316 RVA: 0x000906A8 File Offset: 0x0008E8A8
			[Token(Token = "0x60164B4")]
			[Address(RVA = "0xEA66D0", Offset = "0xEA52D0", VA = "0x180EA66D0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0401ACFE RID: 109822
			[Token(Token = "0x401ACFE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private AnimationClip m_animClip;
		}
	}
}
