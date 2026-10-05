using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002137 RID: 8503
	[Token(Token = "0x2002137")]
	public class SleepTileSpineAnimatorEffect : SpineAnimatorEffect
	{
		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x0600D120 RID: 53536 RVA: 0x0004B630 File Offset: 0x00049830
		[Token(Token = "0x17001903")]
		public override SpineAnimatorEffectType EffectType
		{
			[Token(Token = "0x600D120")]
			[Address(RVA = "0x3537C80", Offset = "0x3536880", VA = "0x183537C80", Slot = "4")]
			get
			{
				return SpineAnimatorEffectType.NONE;
			}
		}

		// Token: 0x0600D121 RID: 53537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D121")]
		[Address(RVA = "0x35378F0", Offset = "0x35364F0", VA = "0x1835378F0", Slot = "5")]
		public override void Apply(SpineAnimator animator, IFaceConfiguration face, SpineAnimatorEffect.Param param)
		{
		}

		// Token: 0x0600D122 RID: 53538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D122")]
		[Address(RVA = "0x3537BC0", Offset = "0x35367C0", VA = "0x183537BC0")]
		public SleepTileSpineAnimatorEffect()
		{
		}

		// Token: 0x0400DF91 RID: 57233
		[Token(Token = "0x400DF91")]
		public const string PARAM_FADE_HEIGHT = "_FadeHeight";

		// Token: 0x0400DF92 RID: 57234
		[Token(Token = "0x400DF92")]
		public const string PARAM_ON_SLEEP_TILE = "_SpineOnSleepTile";

		// Token: 0x0400DF93 RID: 57235
		[Token(Token = "0x400DF93")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int FADE_HEIGHT_ID;

		// Token: 0x0400DF94 RID: 57236
		[Token(Token = "0x400DF94")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int ON_SLEEP_TILE_ID;

		// Token: 0x0400DF95 RID: 57237
		[Token(Token = "0x400DF95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_EffectType;

		// Token: 0x0400DF96 RID: 57238
		[Token(Token = "0x400DF96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x0400DF97 RID: 57239
		[Token(Token = "0x400DF97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
