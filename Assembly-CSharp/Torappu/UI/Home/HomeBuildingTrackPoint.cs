using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C05 RID: 19461
	[Token(Token = "0x2004C05")]
	public class HomeBuildingTrackPoint : DataBinder<TrackPointViewProperty>
	{
		// Token: 0x0601D3BF RID: 119743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3BF")]
		[Address(RVA = "0x16C9BB0", Offset = "0x16C87B0", VA = "0x1816C9BB0", Slot = "7")]
		public override void OnValueChanged(TrackPointViewProperty property)
		{
		}

		// Token: 0x0601D3C0 RID: 119744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C0")]
		[Address(RVA = "0x16C9D40", Offset = "0x16C8940", VA = "0x1816C9D40")]
		private static void _UpdateNotifyView(int count, GameObject panel, Text text)
		{
		}

		// Token: 0x0601D3C1 RID: 119745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3C1")]
		[Address(RVA = "0x16C9E10", Offset = "0x16C8A10", VA = "0x1816C9E10")]
		public HomeBuildingTrackPoint()
		{
		}

		// Token: 0x040266BC RID: 157372
		[Token(Token = "0x40266BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotify;

		// Token: 0x040266BD RID: 157373
		[Token(Token = "0x40266BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textNotify;

		// Token: 0x040266BE RID: 157374
		[Token(Token = "0x40266BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelEmer;

		// Token: 0x040266BF RID: 157375
		[Token(Token = "0x40266BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEmer;

		// Token: 0x040266C0 RID: 157376
		[Token(Token = "0x40266C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040266C1 RID: 157377
		[Token(Token = "0x40266C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateNotifyView;

		// Token: 0x040266C2 RID: 157378
		[Token(Token = "0x40266C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
