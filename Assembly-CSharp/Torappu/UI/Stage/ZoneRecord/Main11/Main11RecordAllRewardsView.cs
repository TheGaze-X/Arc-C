using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main11
{
	// Token: 0x02006A24 RID: 27172
	[Token(Token = "0x2006A24")]
	public class Main11RecordAllRewardsView : DataBinder<Main11ZoneRecordViewProperty>, IHotfixable
	{
		// Token: 0x06026D72 RID: 159090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D72")]
		[Address(RVA = "0x21EF7A0", Offset = "0x21EE3A0", VA = "0x1821EF7A0", Slot = "7")]
		public override void OnValueChanged(Main11ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026D73 RID: 159091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D73")]
		[Address(RVA = "0x21EF860", Offset = "0x21EE460", VA = "0x1821EF860")]
		public Main11RecordAllRewardsView()
		{
		}

		// Token: 0x04036E59 RID: 224857
		[Token(Token = "0x4036E59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main11RecordAllRewardAdapter _adapter;

		// Token: 0x04036E5A RID: 224858
		[Token(Token = "0x4036E5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036E5B RID: 224859
		[Token(Token = "0x4036E5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
