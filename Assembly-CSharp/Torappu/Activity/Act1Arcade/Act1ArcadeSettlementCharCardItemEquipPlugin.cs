using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200796B RID: 31083
	[Token(Token = "0x200796B")]
	public class Act1ArcadeSettlementCharCardItemEquipPlugin : Act1ArcadeSettlementCharCardItemAdvanceInfoPlugin
	{
		// Token: 0x0602B9A5 RID: 178597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A5")]
		[Address(RVA = "0x277F1C0", Offset = "0x277DDC0", VA = "0x18277F1C0", Slot = "4")]
		public override void OnRender(bool isAssist, CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0602B9A6 RID: 178598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A6")]
		[Address(RVA = "0x277F4D0", Offset = "0x277E0D0", VA = "0x18277F4D0")]
		public Act1ArcadeSettlementCharCardItemEquipPlugin()
		{
		}

		// Token: 0x0403F132 RID: 258354
		[Token(Token = "0x403F132")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEquip;

		// Token: 0x0403F133 RID: 258355
		[Token(Token = "0x403F133")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEquipEmpty;

		// Token: 0x0403F134 RID: 258356
		[Token(Token = "0x403F134")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelDefaultEquip;

		// Token: 0x0403F135 RID: 258357
		[Token(Token = "0x403F135")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgEquip;

		// Token: 0x0403F136 RID: 258358
		[Token(Token = "0x403F136")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _equipLvGo;

		// Token: 0x0403F137 RID: 258359
		[Token(Token = "0x403F137")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEquipLv;

		// Token: 0x0403F138 RID: 258360
		[Token(Token = "0x403F138")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F139 RID: 258361
		[Token(Token = "0x403F139")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
