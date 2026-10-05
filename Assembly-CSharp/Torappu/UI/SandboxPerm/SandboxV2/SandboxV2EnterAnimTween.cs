using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200429C RID: 17052
	[Token(Token = "0x200429C")]
	public class SandboxV2EnterAnimTween : UISwitchTween
	{
		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0601A439 RID: 107577 RVA: 0x000A09C8 File Offset: 0x0009EBC8
		// (set) Token: 0x0601A43A RID: 107578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E54")]
		public float duration
		{
			[Token(Token = "0x601A439")]
			[Address(RVA = "0x133E810", Offset = "0x133D410", VA = "0x18133E810")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601A43A")]
			[Address(RVA = "0x133E940", Offset = "0x133D540", VA = "0x18133E940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0601A43B RID: 107579 RVA: 0x000A09E0 File Offset: 0x0009EBE0
		// (set) Token: 0x0601A43C RID: 107580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E55")]
		public float delay
		{
			[Token(Token = "0x601A43B")]
			[Address(RVA = "0x133E7B0", Offset = "0x133D3B0", VA = "0x18133E7B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x601A43C")]
			[Address(RVA = "0x133E8D0", Offset = "0x133D4D0", VA = "0x18133E8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0601A43D RID: 107581 RVA: 0x000A09F8 File Offset: 0x0009EBF8
		// (set) Token: 0x0601A43E RID: 107582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E56")]
		public Ease ease
		{
			[Token(Token = "0x601A43D")]
			[Address(RVA = "0x133E870", Offset = "0x133D470", VA = "0x18133E870")]
			[CompilerGenerated]
			get
			{
				return Ease.Unset;
			}
			[Token(Token = "0x601A43E")]
			[Address(RVA = "0x133E9B0", Offset = "0x133D5B0", VA = "0x18133E9B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A43F RID: 107583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A43F")]
		[Address(RVA = "0x133E720", Offset = "0x133D320", VA = "0x18133E720")]
		public SandboxV2EnterAnimTween(UIAnimationLocation enterAnim)
		{
		}

		// Token: 0x0601A440 RID: 107584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A440")]
		[Address(RVA = "0x133E360", Offset = "0x133CF60", VA = "0x18133E360", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x0601A441 RID: 107585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A441")]
		[Address(RVA = "0x133E0C0", Offset = "0x133CCC0", VA = "0x18133E0C0", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x0601A442 RID: 107586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A442")]
		[Address(RVA = "0x133E670", Offset = "0x133D270", VA = "0x18133E670", Slot = "10")]
		protected override void ResetToState(bool isShow)
		{
		}

		// Token: 0x0601A443 RID: 107587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A443")]
		[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x04021429 RID: 136233
		[Token(Token = "0x4021429")]
		[FieldOffset(Offset = "0x48")]
		private UIAnimationLocation m_enterAnim;

		// Token: 0x0402142D RID: 136237
		[Token(Token = "0x402142D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_duration;

		// Token: 0x0402142E RID: 136238
		[Token(Token = "0x402142E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_duration;

		// Token: 0x0402142F RID: 136239
		[Token(Token = "0x402142F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_delay;

		// Token: 0x04021430 RID: 136240
		[Token(Token = "0x4021430")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_delay;

		// Token: 0x04021431 RID: 136241
		[Token(Token = "0x4021431")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ease;

		// Token: 0x04021432 RID: 136242
		[Token(Token = "0x4021432")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_ease;

		// Token: 0x04021433 RID: 136243
		[Token(Token = "0x4021433")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04021434 RID: 136244
		[Token(Token = "0x4021434")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

		// Token: 0x04021435 RID: 136245
		[Token(Token = "0x4021435")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

		// Token: 0x04021436 RID: 136246
		[Token(Token = "0x4021436")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ResetToState;
	}
}
