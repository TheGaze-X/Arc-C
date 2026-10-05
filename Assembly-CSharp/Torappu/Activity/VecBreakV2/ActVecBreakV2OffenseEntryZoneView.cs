using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E3B RID: 28219
	[Token(Token = "0x2006E3B")]
	public class ActVecBreakV2OffenseEntryZoneView : ActVecBreakV2EntryZoneView
	{
		// Token: 0x0602829B RID: 164507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602829B")]
		[Address(RVA = "0x2377340", Offset = "0x2375F40", VA = "0x182377340", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x0602829C RID: 164508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602829C")]
		[Address(RVA = "0x23772B0", Offset = "0x2375EB0", VA = "0x1823772B0")]
		public void EventOnBtnOffenseZoneClick()
		{
		}

		// Token: 0x0602829D RID: 164509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602829D")]
		[Address(RVA = "0x2377500", Offset = "0x2376100", VA = "0x182377500")]
		public ActVecBreakV2OffenseEntryZoneView()
		{
		}

		// Token: 0x0602829E RID: 164510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602829E")]
		[Address(RVA = "0x2375530", Offset = "0x2374130", VA = "0x182375530")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x04039094 RID: 233620
		[Token(Token = "0x4039094")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textCurrent;

		// Token: 0x04039095 RID: 233621
		[Token(Token = "0x4039095")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textTotal;

		// Token: 0x04039096 RID: 233622
		[Token(Token = "0x4039096")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _emptyProgressGO;

		// Token: 0x04039097 RID: 233623
		[Token(Token = "0x4039097")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _normalProgressGO;

		// Token: 0x04039098 RID: 233624
		[Token(Token = "0x4039098")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04039099 RID: 233625
		[Token(Token = "0x4039099")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnOffenseZoneClick;

		// Token: 0x0403909A RID: 233626
		[Token(Token = "0x403909A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
