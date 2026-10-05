using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main10
{
	// Token: 0x02006A39 RID: 27193
	[Token(Token = "0x2006A39")]
	public class Main10ZoneRecordAllRewardView : DataBinder<Main10ZoneRecordViewProperty>, IHotfixable
	{
		// Token: 0x06026DDA RID: 159194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DDA")]
		[Address(RVA = "0x21EA510", Offset = "0x21E9110", VA = "0x1821EA510", Slot = "7")]
		public override void OnValueChanged(Main10ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026DDB RID: 159195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026DDB")]
		[Address(RVA = "0x21EA670", Offset = "0x21E9270", VA = "0x1821EA670")]
		public Main10ZoneRecordAllRewardView()
		{
		}

		// Token: 0x04036F42 RID: 225090
		[Token(Token = "0x4036F42")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main10ZoneRecordAllRewardAdapter _adapter;

		// Token: 0x04036F43 RID: 225091
		[Token(Token = "0x4036F43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036F44 RID: 225092
		[Token(Token = "0x4036F44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
