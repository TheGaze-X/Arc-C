using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055A1 RID: 21921
	[Token(Token = "0x20055A1")]
	public class RL05FreezeCopperListView : DataBinder<RL05FreezeCopperProperty>, IHotfixable
	{
		// Token: 0x0602031C RID: 131868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602031C")]
		[Address(RVA = "0x1A53CC0", Offset = "0x1A528C0", VA = "0x181A53CC0", Slot = "7")]
		public override void OnValueChanged(RL05FreezeCopperProperty property)
		{
		}

		// Token: 0x0602031D RID: 131869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602031D")]
		[Address(RVA = "0x1A53F10", Offset = "0x1A52B10", VA = "0x181A53F10")]
		public RL05FreezeCopperListView()
		{
		}

		// Token: 0x0402B85D RID: 178269
		[Token(Token = "0x402B85D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL05FreezeCopperListLoopAdapter _adapter;

		// Token: 0x0402B85E RID: 178270
		[Token(Token = "0x402B85E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0402B85F RID: 178271
		[Token(Token = "0x402B85F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x0402B860 RID: 178272
		[Token(Token = "0x402B860")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402B861 RID: 178273
		[Token(Token = "0x402B861")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
