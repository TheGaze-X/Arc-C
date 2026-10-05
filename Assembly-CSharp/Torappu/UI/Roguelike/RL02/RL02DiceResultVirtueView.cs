using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200573F RID: 22335
	[Token(Token = "0x200573F")]
	public class RL02DiceResultVirtueView : RoguelikeDiceResultView<RL02DiceResultVirtueViewModel>
	{
		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x06020BB2 RID: 134066 RVA: 0x000B7000 File Offset: 0x000B5200
		[Token(Token = "0x17004CC2")]
		public override DiceResultShowType diceResultShowType
		{
			[Token(Token = "0x6020BB2")]
			[Address(RVA = "0x1B08C10", Offset = "0x1B07810", VA = "0x181B08C10", Slot = "4")]
			get
			{
				return DiceResultShowType.RAW_TEXT;
			}
		}

		// Token: 0x06020BB3 RID: 134067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BB3")]
		[Address(RVA = "0x1B08990", Offset = "0x1B07590", VA = "0x181B08990", Slot = "7")]
		public override void OnRender(RL02DiceResultVirtueViewModel model)
		{
		}

		// Token: 0x06020BB4 RID: 134068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BB4")]
		[Address(RVA = "0x1B08BA0", Offset = "0x1B077A0", VA = "0x181B08BA0")]
		public RL02DiceResultVirtueView()
		{
		}

		// Token: 0x0402C6F0 RID: 182000
		[Token(Token = "0x402C6F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402C6F1 RID: 182001
		[Token(Token = "0x402C6F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402C6F2 RID: 182002
		[Token(Token = "0x402C6F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _tips;

		// Token: 0x0402C6F3 RID: 182003
		[Token(Token = "0x402C6F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diceResultShowType;

		// Token: 0x0402C6F4 RID: 182004
		[Token(Token = "0x402C6F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C6F5 RID: 182005
		[Token(Token = "0x402C6F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
