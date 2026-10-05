using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200796C RID: 31084
	[Token(Token = "0x200796C")]
	public class Act1ArcadeSettlementCharCardItemProfessionPlugin : Act1ArcadeSettlementCharCardItemAdvanceInfoPlugin
	{
		// Token: 0x0602B9A7 RID: 178599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A7")]
		[Address(RVA = "0x277F570", Offset = "0x277E170", VA = "0x18277F570", Slot = "4")]
		public override void OnRender(bool isAssist, CharacterCardViewModel cardViewModel)
		{
		}

		// Token: 0x0602B9A8 RID: 178600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B9A8")]
		[Address(RVA = "0x277F630", Offset = "0x277E230", VA = "0x18277F630")]
		public Act1ArcadeSettlementCharCardItemProfessionPlugin()
		{
		}

		// Token: 0x0403F13A RID: 258362
		[Token(Token = "0x403F13A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0403F13B RID: 258363
		[Token(Token = "0x403F13B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F13C RID: 258364
		[Token(Token = "0x403F13C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
