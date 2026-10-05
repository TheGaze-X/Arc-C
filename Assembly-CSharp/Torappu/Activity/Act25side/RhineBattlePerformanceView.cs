using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007522 RID: 29986
	[Token(Token = "0x2007522")]
	public class RhineBattlePerformanceView : DataBinder<RhineBattlePerformanceProperty>
	{
		// Token: 0x0602A40F RID: 173071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A40F")]
		[Address(RVA = "0x25EFDF0", Offset = "0x25EE9F0", VA = "0x1825EFDF0", Slot = "7")]
		public override void OnValueChanged(RhineBattlePerformanceProperty property)
		{
		}

		// Token: 0x0602A410 RID: 173072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A410")]
		[Address(RVA = "0x25EFFC0", Offset = "0x25EEBC0", VA = "0x1825EFFC0")]
		public RhineBattlePerformanceView()
		{
		}

		// Token: 0x0403CBF1 RID: 248817
		[Token(Token = "0x403CBF1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<RhineBattlePerformanceItemView> _itemViews;

		// Token: 0x0403CBF2 RID: 248818
		[Token(Token = "0x403CBF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CBF3 RID: 248819
		[Token(Token = "0x403CBF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
