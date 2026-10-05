using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007399 RID: 29593
	[Token(Token = "0x2007399")]
	public class Act42d0ChallengeAreaGroupView : DataBinder<Act42D0ChallengeStageGroupProperty>
	{
		// Token: 0x06029D4D RID: 171341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D4D")]
		[Address(RVA = "0x257AD70", Offset = "0x2579970", VA = "0x18257AD70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D4E RID: 171342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D4E")]
		[Address(RVA = "0x257AED0", Offset = "0x2579AD0", VA = "0x18257AED0")]
		private void _RenderChanllengeStages(Act42D0ChallengeStageGroupViewModel viewModel)
		{
		}

		// Token: 0x06029D4F RID: 171343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029D4F")]
		[Address(RVA = "0x257AC50", Offset = "0x2579850", VA = "0x18257AC50")]
		private AnimationSwitchTween _EnsureSwitchTween()
		{
			return null;
		}

		// Token: 0x06029D50 RID: 171344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D50")]
		[Address(RVA = "0x257ABB0", Offset = "0x25797B0", VA = "0x18257ABB0", Slot = "7")]
		public override void OnValueChanged(Act42D0ChallengeStageGroupProperty property)
		{
		}

		// Token: 0x06029D51 RID: 171345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D51")]
		[Address(RVA = "0x257B210", Offset = "0x2579E10", VA = "0x18257B210")]
		public Act42d0ChallengeAreaGroupView()
		{
		}

		// Token: 0x0403BEB1 RID: 245425
		[Token(Token = "0x403BEB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act42d0ChallengeAreaButtonHolder[] _btnHolders;

		// Token: 0x0403BEB2 RID: 245426
		[Token(Token = "0x403BEB2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _hideSwitchAnim;

		// Token: 0x0403BEB3 RID: 245427
		[Token(Token = "0x403BEB3")]
		[FieldOffset(Offset = "0x38")]
		private AnimationSwitchTween m_switchTw;

		// Token: 0x0403BEB4 RID: 245428
		[Token(Token = "0x403BEB4")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x0403BEB5 RID: 245429
		[Token(Token = "0x403BEB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BEB6 RID: 245430
		[Token(Token = "0x403BEB6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderChanllengeStages;

		// Token: 0x0403BEB7 RID: 245431
		[Token(Token = "0x403BEB7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EnsureSwitchTween;

		// Token: 0x0403BEB8 RID: 245432
		[Token(Token = "0x403BEB8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BEB9 RID: 245433
		[Token(Token = "0x403BEB9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
