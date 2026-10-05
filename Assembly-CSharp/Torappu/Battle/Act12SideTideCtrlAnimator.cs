using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002128 RID: 8488
	[Token(Token = "0x2002128")]
	public class Act12SideTideCtrlAnimator : MeshAnimator
	{
		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x0600D07C RID: 53372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170018EC")]
		protected override Animation animation
		{
			[Token(Token = "0x600D07C")]
			[Address(RVA = "0x3508470", Offset = "0x3507070", VA = "0x183508470", Slot = "47")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D07D RID: 53373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D07D")]
		[Address(RVA = "0x3507670", Offset = "0x3506270", VA = "0x183507670", Slot = "21")]
		public override void Init(Unit host)
		{
		}

		// Token: 0x0600D07E RID: 53374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D07E")]
		[Address(RVA = "0x3507700", Offset = "0x3506300", VA = "0x183507700", Slot = "27")]
		public override void OnFinish()
		{
		}

		// Token: 0x0600D07F RID: 53375 RVA: 0x0004B2A0 File Offset: 0x000494A0
		[Token(Token = "0x600D07F")]
		[Address(RVA = "0x3508090", Offset = "0x3506C90", VA = "0x183508090")]
		private bool _InitSceneAnimation()
		{
			return default(bool);
		}

		// Token: 0x0600D080 RID: 53376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D080")]
		[Address(RVA = "0x3507DA0", Offset = "0x35069A0", VA = "0x183507DA0")]
		private void _CacheFirstAnimation()
		{
		}

		// Token: 0x0600D081 RID: 53377 RVA: 0x0004B2B8 File Offset: 0x000494B8
		[Token(Token = "0x600D081")]
		[Address(RVA = "0x3507460", Offset = "0x3506060", VA = "0x183507460", Slot = "41")]
		protected override bool ContainsAnimationInternal(string animKey, bool allowEmpty)
		{
			return default(bool);
		}

		// Token: 0x0600D082 RID: 53378 RVA: 0x0004B2D0 File Offset: 0x000494D0
		[Token(Token = "0x600D082")]
		[Address(RVA = "0x35075C0", Offset = "0x35061C0", VA = "0x1835075C0", Slot = "42")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time)
		{
			return default(bool);
		}

		// Token: 0x0600D083 RID: 53379 RVA: 0x0004B2E8 File Offset: 0x000494E8
		[Token(Token = "0x600D083")]
		[Address(RVA = "0x3507510", Offset = "0x3506110", VA = "0x183507510", Slot = "43")]
		protected override bool GetAnimationTimeInternal(string animKey, out float time, out float speed)
		{
			return default(bool);
		}

		// Token: 0x0600D084 RID: 53380 RVA: 0x0004B300 File Offset: 0x00049500
		[Token(Token = "0x600D084")]
		[Address(RVA = "0x35077F0", Offset = "0x35063F0", VA = "0x1835077F0", Slot = "40")]
		protected override float PlayAnimationInternal(string animKey, bool forceFromStart, float speed)
		{
			return 0f;
		}

		// Token: 0x0600D085 RID: 53381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D085")]
		[Address(RVA = "0x35082C0", Offset = "0x3506EC0", VA = "0x1835082C0")]
		private IEnumerator _PlayCrossFadeAnimation(MeshAnimator.AnimationData transitionAnim, MeshAnimator.AnimationData animData, bool forceFromStart, float speed)
		{
			return null;
		}

		// Token: 0x0600D086 RID: 53382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D086")]
		[Address(RVA = "0x3507F70", Offset = "0x3506B70", VA = "0x183507F70")]
		private Act12SideTideCtrlAnimator.AnimationTransitionData _GetTransitionData(string from, string to)
		{
			return null;
		}

		// Token: 0x0600D087 RID: 53383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D087")]
		[Address(RVA = "0x35083E0", Offset = "0x3506FE0", VA = "0x1835083E0")]
		public Act12SideTideCtrlAnimator()
		{
		}

		// Token: 0x0600D088 RID: 53384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D088")]
		[Address(RVA = "0x3507D40", Offset = "0x3506940", VA = "0x183507D40")]
		private Animation <>xLuaBaseProxy_get_animation()
		{
			return null;
		}

		// Token: 0x0600D089 RID: 53385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D089")]
		[Address(RVA = "0x3507C60", Offset = "0x3506860", VA = "0x183507C60")]
		private void <>xLuaBaseProxy_Init(Unit P0)
		{
		}

		// Token: 0x0600D08A RID: 53386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D08A")]
		[Address(RVA = "0x3507C70", Offset = "0x3506870", VA = "0x183507C70")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600D08B RID: 53387 RVA: 0x0004B318 File Offset: 0x00049518
		[Token(Token = "0x600D08B")]
		[Address(RVA = "0x3507C30", Offset = "0x3506830", VA = "0x183507C30")]
		private bool <>xLuaBaseProxy_ContainsAnimationInternal(string P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600D08C RID: 53388 RVA: 0x0004B330 File Offset: 0x00049530
		[Token(Token = "0x600D08C")]
		[Address(RVA = "0x3507C50", Offset = "0x3506850", VA = "0x183507C50")]
		private bool <>xLuaBaseProxy_GetAnimationTimeInternal(string P0, out float P1)
		{
			return default(bool);
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x0004B348 File Offset: 0x00049548
		[Token(Token = "0x600D08D")]
		[Address(RVA = "0x3507C40", Offset = "0x3506840", VA = "0x183507C40")]
		private bool <>xLuaBaseProxy_GetAnimationTimeInternal(string P0, out float P1, out float P2)
		{
			return default(bool);
		}

		// Token: 0x0600D08E RID: 53390 RVA: 0x0004B360 File Offset: 0x00049560
		[Token(Token = "0x600D08E")]
		[Address(RVA = "0x3507C80", Offset = "0x3506880", VA = "0x183507C80")]
		private float <>xLuaBaseProxy_PlayAnimationInternal(string P0, bool P1, float P2)
		{
			return 0f;
		}

		// Token: 0x0400DEE2 RID: 57058
		[Token(Token = "0x400DEE2")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Inspect(Priority = 10)]
		private Act12SideTideCtrlAnimator.AnimationTransitionData[] _transitions;

		// Token: 0x0400DEE3 RID: 57059
		[Token(Token = "0x400DEE3")]
		[FieldOffset(Offset = "0x178")]
		private bool m_hasAnimation;

		// Token: 0x0400DEE4 RID: 57060
		[Token(Token = "0x400DEE4")]
		[FieldOffset(Offset = "0x180")]
		private Animation m_sceneAnimation;

		// Token: 0x0400DEE5 RID: 57061
		[Token(Token = "0x400DEE5")]
		[FieldOffset(Offset = "0x188")]
		private bool m_animationInit;

		// Token: 0x0400DEE6 RID: 57062
		[Token(Token = "0x400DEE6")]
		[FieldOffset(Offset = "0x190")]
		private string m_cachedAnimationKey;

		// Token: 0x0400DEE7 RID: 57063
		[Token(Token = "0x400DEE7")]
		[FieldOffset(Offset = "0x198")]
		private CoroutineId m_transitionCoroutine;

		// Token: 0x0400DEE8 RID: 57064
		[Token(Token = "0x400DEE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animation;

		// Token: 0x0400DEE9 RID: 57065
		[Token(Token = "0x400DEE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DEEA RID: 57066
		[Token(Token = "0x400DEEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400DEEB RID: 57067
		[Token(Token = "0x400DEEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitSceneAnimation;

		// Token: 0x0400DEEC RID: 57068
		[Token(Token = "0x400DEEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CacheFirstAnimation;

		// Token: 0x0400DEED RID: 57069
		[Token(Token = "0x400DEED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ContainsAnimationInternal;

		// Token: 0x0400DEEE RID: 57070
		[Token(Token = "0x400DEEE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetAnimationTimeInternal;

		// Token: 0x0400DEEF RID: 57071
		[Token(Token = "0x400DEEF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_GetAnimationTimeInternal;

		// Token: 0x0400DEF0 RID: 57072
		[Token(Token = "0x400DEF0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PlayAnimationInternal;

		// Token: 0x0400DEF1 RID: 57073
		[Token(Token = "0x400DEF1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PlayCrossFadeAnimation;

		// Token: 0x0400DEF2 RID: 57074
		[Token(Token = "0x400DEF2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetTransitionData;

		// Token: 0x0400DEF3 RID: 57075
		[Token(Token = "0x400DEF3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002129 RID: 8489
		[Token(Token = "0x2002129")]
		[Serializable]
		public class AnimationTransitionData
		{
			// Token: 0x0600D08F RID: 53391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D08F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AnimationTransitionData()
			{
			}

			// Token: 0x0400DEF4 RID: 57076
			[Token(Token = "0x400DEF4")]
			[FieldOffset(Offset = "0x10")]
			public string fromKey;

			// Token: 0x0400DEF5 RID: 57077
			[Token(Token = "0x400DEF5")]
			[FieldOffset(Offset = "0x18")]
			public string toKey;

			// Token: 0x0400DEF6 RID: 57078
			[Token(Token = "0x400DEF6")]
			[FieldOffset(Offset = "0x20")]
			public string animKey;
		}
	}
}
