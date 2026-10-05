using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200415F RID: 16735
	[Token(Token = "0x200415F")]
	public class SandboxV2DungeonLodAnim : SandboxV2DungeonLodElement
	{
		// Token: 0x06019D5E RID: 105822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D5E")]
		[Address(RVA = "0x12B2D00", Offset = "0x12B1900", VA = "0x1812B2D00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019D5F RID: 105823 RVA: 0x0009F738 File Offset: 0x0009D938
		[Token(Token = "0x6019D5F")]
		[Address(RVA = "0x12B2C00", Offset = "0x12B1800", VA = "0x1812B2C00")]
		private float _GetAnimProgress()
		{
			return 0f;
		}

		// Token: 0x06019D60 RID: 105824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D60")]
		[Address(RVA = "0x12B2DA0", Offset = "0x12B19A0", VA = "0x1812B2DA0")]
		private void _SetAnimProgress(float value)
		{
		}

		// Token: 0x06019D61 RID: 105825 RVA: 0x0009F750 File Offset: 0x0009D950
		[Token(Token = "0x6019D61")]
		[Address(RVA = "0x12B2C60", Offset = "0x12B1860", VA = "0x1812B2C60")]
		private float _GetTweenValue(SandboxV2DungeonLodRank lodRank)
		{
			return 0f;
		}

		// Token: 0x06019D62 RID: 105826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D62")]
		[Address(RVA = "0x12B2B80", Offset = "0x12B1780", VA = "0x1812B2B80")]
		private void _ClearTween()
		{
		}

		// Token: 0x06019D63 RID: 105827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D63")]
		[Address(RVA = "0x12B27E0", Offset = "0x12B13E0", VA = "0x1812B27E0", Slot = "5")]
		public override void UpdateLod(float lod, SandboxV2DungeonLodRank lodRank, bool fastMode = false)
		{
		}

		// Token: 0x06019D64 RID: 105828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D64")]
		[Address(RVA = "0x12B2E50", Offset = "0x12B1A50", VA = "0x1812B2E50")]
		public SandboxV2DungeonLodAnim()
		{
		}

		// Token: 0x04020726 RID: 132902
		[Token(Token = "0x4020726")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animTrans;

		// Token: 0x04020727 RID: 132903
		[Token(Token = "0x4020727")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _tweenMiddleValue;

		// Token: 0x04020728 RID: 132904
		[Token(Token = "0x4020728")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x04020729 RID: 132905
		[Token(Token = "0x4020729")]
		[FieldOffset(Offset = "0x38")]
		private AnimationWrapper.AnimationHandler m_animHandler;

		// Token: 0x0402072A RID: 132906
		[Token(Token = "0x402072A")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2DungeonLodRank m_lodRank;

		// Token: 0x0402072B RID: 132907
		[Token(Token = "0x402072B")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_tween;

		// Token: 0x0402072C RID: 132908
		[Token(Token = "0x402072C")]
		[FieldOffset(Offset = "0x50")]
		private float m_tweenValue;

		// Token: 0x0402072D RID: 132909
		[Token(Token = "0x402072D")]
		[FieldOffset(Offset = "0x54")]
		private bool m_inited;

		// Token: 0x0402072E RID: 132910
		[Token(Token = "0x402072E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402072F RID: 132911
		[Token(Token = "0x402072F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetAnimProgress;

		// Token: 0x04020730 RID: 132912
		[Token(Token = "0x4020730")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetAnimProgress;

		// Token: 0x04020731 RID: 132913
		[Token(Token = "0x4020731")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTweenValue;

		// Token: 0x04020732 RID: 132914
		[Token(Token = "0x4020732")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearTween;

		// Token: 0x04020733 RID: 132915
		[Token(Token = "0x4020733")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateLod;

		// Token: 0x04020734 RID: 132916
		[Token(Token = "0x4020734")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
