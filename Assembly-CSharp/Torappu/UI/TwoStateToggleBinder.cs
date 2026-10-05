using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039CE RID: 14798
	[Token(Token = "0x20039CE")]
	[RequireComponent(typeof(TwoStateToggle))]
	public class TwoStateToggleBinder : DataBinder<BoolProperty>
	{
		// Token: 0x06017605 RID: 95749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017605")]
		[Address(RVA = "0xFBA6E0", Offset = "0xFB92E0", VA = "0x180FBA6E0")]
		private void Awake()
		{
		}

		// Token: 0x06017606 RID: 95750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017606")]
		[Address(RVA = "0xFBA760", Offset = "0xFB9360", VA = "0x180FBA760", Slot = "7")]
		public override void OnValueChanged(BoolProperty property)
		{
		}

		// Token: 0x06017607 RID: 95751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017607")]
		[Address(RVA = "0xFBA800", Offset = "0xFB9400", VA = "0x180FBA800")]
		public TwoStateToggleBinder()
		{
		}

		// Token: 0x0401C3BF RID: 115647
		[Token(Token = "0x401C3BF")]
		[FieldOffset(Offset = "0x20")]
		private TwoStateToggle m_toggle;

		// Token: 0x0401C3C0 RID: 115648
		[Token(Token = "0x401C3C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401C3C1 RID: 115649
		[Token(Token = "0x401C3C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401C3C2 RID: 115650
		[Token(Token = "0x401C3C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
