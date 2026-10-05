using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A0B RID: 27147
	[Token(Token = "0x2006A0B")]
	public class Main12RecordAllRewardsView : DataBinder<Main12ZoneRecordViewProperty>
	{
		// Token: 0x06026CFA RID: 158970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CFA")]
		[Address(RVA = "0x21D2770", Offset = "0x21D1370", VA = "0x1821D2770", Slot = "7")]
		public override void OnValueChanged(Main12ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026CFB RID: 158971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026CFB")]
		[Address(RVA = "0x21D2C10", Offset = "0x21D1810", VA = "0x1821D2C10")]
		public Main12RecordAllRewardsView()
		{
		}

		// Token: 0x04036D3A RID: 224570
		[Token(Token = "0x4036D3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main12RecordAllRewardAdapter _adapter;

		// Token: 0x04036D3B RID: 224571
		[Token(Token = "0x4036D3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelOutdate;

		// Token: 0x04036D3C RID: 224572
		[Token(Token = "0x4036D3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _timeDesc;

		// Token: 0x04036D3D RID: 224573
		[Token(Token = "0x4036D3D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036D3E RID: 224574
		[Token(Token = "0x4036D3E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
