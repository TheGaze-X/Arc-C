using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200628E RID: 25230
	[Token(Token = "0x200628E")]
	public class AutoChessBandChooseBandListView : DataBinder<AutoChessBandChooseProperty>, IHotfixable
	{
		// Token: 0x06024615 RID: 149013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024615")]
		[Address(RVA = "0x1F23C10", Offset = "0x1F22810", VA = "0x181F23C10", Slot = "7")]
		public override void OnValueChanged(AutoChessBandChooseProperty property)
		{
		}

		// Token: 0x06024616 RID: 149014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024616")]
		[Address(RVA = "0x1F23D50", Offset = "0x1F22950", VA = "0x181F23D50")]
		public AutoChessBandChooseBandListView()
		{
		}

		// Token: 0x040329A7 RID: 207271
		[Token(Token = "0x40329A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessBandChooseBandListAdapter _adapter;

		// Token: 0x040329A8 RID: 207272
		[Token(Token = "0x40329A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040329A9 RID: 207273
		[Token(Token = "0x40329A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
