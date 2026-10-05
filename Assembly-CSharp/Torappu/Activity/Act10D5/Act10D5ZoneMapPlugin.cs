using System;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B22 RID: 31522
	[Token(Token = "0x2007B22")]
	public class Act10D5ZoneMapPlugin : StageZoneMapStatePlugin
	{
		// Token: 0x0602C219 RID: 180761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C219")]
		[Address(RVA = "0x280F490", Offset = "0x280E090", VA = "0x18280F490", Slot = "4")]
		public override void UpdateStatus(string actId, StagePage page, ZoneViewProperty zoneProp)
		{
		}

		// Token: 0x0602C21A RID: 180762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C21A")]
		[Address(RVA = "0x280F6E0", Offset = "0x280E2E0", VA = "0x18280F6E0")]
		public Act10D5ZoneMapPlugin()
		{
		}

		// Token: 0x0403FF98 RID: 262040
		[Token(Token = "0x403FF98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _viewRoot;

		// Token: 0x0403FF99 RID: 262041
		[Token(Token = "0x403FF99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x0403FF9A RID: 262042
		[Token(Token = "0x403FF9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateStatus;

		// Token: 0x0403FF9B RID: 262043
		[Token(Token = "0x403FF9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
