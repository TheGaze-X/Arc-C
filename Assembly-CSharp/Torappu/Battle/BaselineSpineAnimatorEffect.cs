using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002135 RID: 8501
	[Token(Token = "0x2002135")]
	public class BaselineSpineAnimatorEffect : SpineAnimatorEffect
	{
		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x0600D118 RID: 53528 RVA: 0x0004B600 File Offset: 0x00049800
		[Token(Token = "0x17001901")]
		public override SpineAnimatorEffectType EffectType
		{
			[Token(Token = "0x600D118")]
			[Address(RVA = "0x3533270", Offset = "0x3531E70", VA = "0x183533270", Slot = "4")]
			get
			{
				return SpineAnimatorEffectType.NONE;
			}
		}

		// Token: 0x0600D119 RID: 53529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D119")]
		[Address(RVA = "0x3532F70", Offset = "0x3531B70", VA = "0x183532F70", Slot = "5")]
		public override void Apply(SpineAnimator animator, IFaceConfiguration face, SpineAnimatorEffect.Param param)
		{
		}

		// Token: 0x0600D11A RID: 53530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D11A")]
		[Address(RVA = "0x35331B0", Offset = "0x3531DB0", VA = "0x1835331B0")]
		public BaselineSpineAnimatorEffect()
		{
		}

		// Token: 0x0400DF85 RID: 57221
		[Token(Token = "0x400DF85")]
		public const string PARAM_BASELINE_Z = "_BaselineZ";

		// Token: 0x0400DF86 RID: 57222
		[Token(Token = "0x400DF86")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BASELINE_Z_ID;

		// Token: 0x0400DF87 RID: 57223
		[Token(Token = "0x400DF87")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_EffectType;

		// Token: 0x0400DF88 RID: 57224
		[Token(Token = "0x400DF88")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x0400DF89 RID: 57225
		[Token(Token = "0x400DF89")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
