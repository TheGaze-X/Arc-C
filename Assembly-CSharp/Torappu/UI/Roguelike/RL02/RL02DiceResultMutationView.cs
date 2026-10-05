using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200573D RID: 22333
	[Token(Token = "0x200573D")]
	public class RL02DiceResultMutationView : RoguelikeDiceResultView<RL02DiceResultMutationViewModel>
	{
		// Token: 0x17004CBD RID: 19645
		// (get) Token: 0x06020BA6 RID: 134054 RVA: 0x000B6FE8 File Offset: 0x000B51E8
		[Token(Token = "0x17004CBD")]
		public override DiceResultShowType diceResultShowType
		{
			[Token(Token = "0x6020BA6")]
			[Address(RVA = "0x1B082D0", Offset = "0x1B06ED0", VA = "0x181B082D0", Slot = "4")]
			get
			{
				return DiceResultShowType.RAW_TEXT;
			}
		}

		// Token: 0x06020BA7 RID: 134055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BA7")]
		[Address(RVA = "0x1B07F70", Offset = "0x1B06B70", VA = "0x181B07F70", Slot = "7")]
		public override void OnRender(RL02DiceResultMutationViewModel model)
		{
		}

		// Token: 0x06020BA8 RID: 134056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BA8")]
		[Address(RVA = "0x1B08260", Offset = "0x1B06E60", VA = "0x181B08260")]
		public RL02DiceResultMutationView()
		{
		}

		// Token: 0x0402C6DC RID: 181980
		[Token(Token = "0x402C6DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _contentPanel;

		// Token: 0x0402C6DD RID: 181981
		[Token(Token = "0x402C6DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0402C6DE RID: 181982
		[Token(Token = "0x402C6DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0402C6DF RID: 181983
		[Token(Token = "0x402C6DF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402C6E0 RID: 181984
		[Token(Token = "0x402C6E0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _tips;

		// Token: 0x0402C6E1 RID: 181985
		[Token(Token = "0x402C6E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diceResultShowType;

		// Token: 0x0402C6E2 RID: 181986
		[Token(Token = "0x402C6E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C6E3 RID: 181987
		[Token(Token = "0x402C6E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
