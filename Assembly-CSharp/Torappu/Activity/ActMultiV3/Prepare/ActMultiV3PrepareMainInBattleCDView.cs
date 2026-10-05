using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007049 RID: 28745
	[Token(Token = "0x2007049")]
	public class ActMultiV3PrepareMainInBattleCDView : ActMultiV3PrepareMainFadeViewBase
	{
		// Token: 0x06028CEF RID: 167151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CEF")]
		[Address(RVA = "0x243A0E0", Offset = "0x2438CE0", VA = "0x18243A0E0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainViewModelProperty property)
		{
		}

		// Token: 0x06028CF0 RID: 167152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF0")]
		[Address(RVA = "0x243A210", Offset = "0x2438E10", VA = "0x18243A210")]
		public ActMultiV3PrepareMainInBattleCDView()
		{
		}

		// Token: 0x0403A329 RID: 238377
		[Token(Token = "0x403A329")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _cdAnim;

		// Token: 0x0403A32A RID: 238378
		[Token(Token = "0x403A32A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A32B RID: 238379
		[Token(Token = "0x403A32B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
