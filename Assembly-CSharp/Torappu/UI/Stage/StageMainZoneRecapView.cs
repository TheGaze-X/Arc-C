using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200696D RID: 26989
	[Token(Token = "0x200696D")]
	public class StageMainZoneRecapView : DataBinder<ZoneViewProperty>
	{
		// Token: 0x060269F9 RID: 158201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269F9")]
		[Address(RVA = "0x21ADC30", Offset = "0x21AC830", VA = "0x1821ADC30", Slot = "7")]
		public override void OnValueChanged(ZoneViewProperty property)
		{
		}

		// Token: 0x060269FA RID: 158202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269FA")]
		[Address(RVA = "0x21ADD50", Offset = "0x21AC950", VA = "0x1821ADD50")]
		public StageMainZoneRecapView()
		{
		}

		// Token: 0x04036825 RID: 223269
		[Token(Token = "0x4036825")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _buttonPanel;

		// Token: 0x04036826 RID: 223270
		[Token(Token = "0x4036826")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _recapText;

		// Token: 0x04036827 RID: 223271
		[Token(Token = "0x4036827")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036828 RID: 223272
		[Token(Token = "0x4036828")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
