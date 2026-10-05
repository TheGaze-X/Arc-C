using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F02 RID: 20226
	[Token(Token = "0x2004F02")]
	public class FifthAnnivExploreMissionView : DataBinder<FifthAnnivExploreMissionProperty>, IHotfixable
	{
		// Token: 0x0601E276 RID: 123510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E276")]
		[Address(RVA = "0x17D6860", Offset = "0x17D5460", VA = "0x1817D6860")]
		public void Render(FifthAnnivExploreMissionViewModel viewModel)
		{
		}

		// Token: 0x0601E277 RID: 123511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E277")]
		[Address(RVA = "0x17D6780", Offset = "0x17D5380", VA = "0x1817D6780", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreMissionProperty property)
		{
		}

		// Token: 0x0601E278 RID: 123512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E278")]
		[Address(RVA = "0x17D6900", Offset = "0x17D5500", VA = "0x1817D6900")]
		public FifthAnnivExploreMissionView()
		{
		}

		// Token: 0x04028240 RID: 164416
		[Token(Token = "0x4028240")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FifthAnnivExploreMissionGroupAdapter m_adapter;

		// Token: 0x04028241 RID: 164417
		[Token(Token = "0x4028241")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028242 RID: 164418
		[Token(Token = "0x4028242")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028243 RID: 164419
		[Token(Token = "0x4028243")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
