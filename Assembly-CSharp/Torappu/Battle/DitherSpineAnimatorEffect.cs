using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002136 RID: 8502
	[Token(Token = "0x2002136")]
	public class DitherSpineAnimatorEffect : SpineAnimatorEffect
	{
		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x0600D11C RID: 53532 RVA: 0x0004B618 File Offset: 0x00049818
		[Token(Token = "0x17001902")]
		public override SpineAnimatorEffectType EffectType
		{
			[Token(Token = "0x600D11C")]
			[Address(RVA = "0x3536340", Offset = "0x3534F40", VA = "0x183536340", Slot = "4")]
			get
			{
				return SpineAnimatorEffectType.NONE;
			}
		}

		// Token: 0x0600D11D RID: 53533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D11D")]
		[Address(RVA = "0x3535F70", Offset = "0x3534B70", VA = "0x183535F70", Slot = "5")]
		public override void Apply(SpineAnimator animator, IFaceConfiguration face, SpineAnimatorEffect.Param param)
		{
		}

		// Token: 0x0600D11E RID: 53534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D11E")]
		[Address(RVA = "0x3536280", Offset = "0x3534E80", VA = "0x183536280")]
		public DitherSpineAnimatorEffect()
		{
		}

		// Token: 0x0400DF8A RID: 57226
		[Token(Token = "0x400DF8A")]
		public const string PARAM_USE_DITHER = "_UseDither";

		// Token: 0x0400DF8B RID: 57227
		[Token(Token = "0x400DF8B")]
		public const string PARAM_DITHER_INTENSITY = "_DitherIntensity";

		// Token: 0x0400DF8C RID: 57228
		[Token(Token = "0x400DF8C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int USE_DITHER_ID;

		// Token: 0x0400DF8D RID: 57229
		[Token(Token = "0x400DF8D")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int DITHER_INTENSITY_ID;

		// Token: 0x0400DF8E RID: 57230
		[Token(Token = "0x400DF8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_EffectType;

		// Token: 0x0400DF8F RID: 57231
		[Token(Token = "0x400DF8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x0400DF90 RID: 57232
		[Token(Token = "0x400DF90")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
