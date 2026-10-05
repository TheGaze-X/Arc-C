using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200796E RID: 31086
	[Token(Token = "0x200796E")]
	public class Act1ArcadeSettlementCharCardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B9AB RID: 178603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9AB")]
		[Address(RVA = "0x277FA10", Offset = "0x277E610", VA = "0x18277FA10")]
		public void ApplyData(bool isAssist, SquadItemStruct squadItemStruct)
		{
		}

		// Token: 0x0602B9AC RID: 178604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9AC")]
		[Address(RVA = "0x277FBF0", Offset = "0x277E7F0", VA = "0x18277FBF0")]
		private void _SetPanelsStatus(GameObject[] panels, bool isShow)
		{
		}

		// Token: 0x0602B9AD RID: 178605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9AD")]
		[Address(RVA = "0x277FCB0", Offset = "0x277E8B0", VA = "0x18277FCB0")]
		public Act1ArcadeSettlementCharCardItemView()
		{
		}

		// Token: 0x0403F144 RID: 258372
		[Token(Token = "0x403F144")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0403F145 RID: 258373
		[Token(Token = "0x403F145")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelWithInfo;

		// Token: 0x0403F146 RID: 258374
		[Token(Token = "0x403F146")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _normalCardShowOnlyPanels;

		// Token: 0x0403F147 RID: 258375
		[Token(Token = "0x403F147")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _assistCardShowOnlyPanels;

		// Token: 0x0403F148 RID: 258376
		[Token(Token = "0x403F148")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act1ArcadeSettlementCharCardItemAdvanceInfoPlugin[] _plugins;

		// Token: 0x0403F149 RID: 258377
		[Token(Token = "0x403F149")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403F14A RID: 258378
		[Token(Token = "0x403F14A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetPanelsStatus;

		// Token: 0x0403F14B RID: 258379
		[Token(Token = "0x403F14B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
