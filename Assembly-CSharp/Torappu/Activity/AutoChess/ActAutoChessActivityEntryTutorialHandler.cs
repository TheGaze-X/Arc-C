using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070E1 RID: 28897
	[Token(Token = "0x20070E1")]
	public class ActAutoChessActivityEntryTutorialHandler : TemplateActivityEntryTutorialHandler, IHotfixable
	{
		// Token: 0x06029163 RID: 168291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029163")]
		[Address(RVA = "0x247D5B0", Offset = "0x247C1B0", VA = "0x18247D5B0", Slot = "4")]
		public override void RegisterTutorialGO()
		{
		}

		// Token: 0x06029164 RID: 168292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029164")]
		[Address(RVA = "0x247D680", Offset = "0x247C280", VA = "0x18247D680")]
		public ActAutoChessActivityEntryTutorialHandler()
		{
		}

		// Token: 0x0403AA1F RID: 240159
		[Token(Token = "0x403AA1F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelStart;

		// Token: 0x0403AA20 RID: 240160
		[Token(Token = "0x403AA20")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelShop;

		// Token: 0x0403AA21 RID: 240161
		[Token(Token = "0x403AA21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403AA22 RID: 240162
		[Token(Token = "0x403AA22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
