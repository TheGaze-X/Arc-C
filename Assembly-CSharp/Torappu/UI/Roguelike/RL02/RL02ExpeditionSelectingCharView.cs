using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005782 RID: 22402
	[Token(Token = "0x2005782")]
	public class RL02ExpeditionSelectingCharView : RoguelikeExpeditionSelectingCharView
	{
		// Token: 0x06020C87 RID: 134279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C87")]
		[Address(RVA = "0x1B22430", Offset = "0x1B21030", VA = "0x181B22430", Slot = "4")]
		protected override void RenderChar(RoguelikeExpeditionModel expeditionModel, bool isAfter)
		{
		}

		// Token: 0x06020C88 RID: 134280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C88")]
		[Address(RVA = "0x1B226B0", Offset = "0x1B212B0", VA = "0x181B226B0")]
		public RL02ExpeditionSelectingCharView()
		{
		}

		// Token: 0x0402C869 RID: 182377
		[Token(Token = "0x402C869")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelmutationAfter;

		// Token: 0x0402C86A RID: 182378
		[Token(Token = "0x402C86A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelOtherBuff;

		// Token: 0x0402C86B RID: 182379
		[Token(Token = "0x402C86B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _mutationBeforeBg;

		// Token: 0x0402C86C RID: 182380
		[Token(Token = "0x402C86C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _evolutionBg;

		// Token: 0x0402C86D RID: 182381
		[Token(Token = "0x402C86D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtBuffName;

		// Token: 0x0402C86E RID: 182382
		[Token(Token = "0x402C86E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _buffIcon;

		// Token: 0x0402C86F RID: 182383
		[Token(Token = "0x402C86F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _upgradeObj;

		// Token: 0x0402C870 RID: 182384
		[Token(Token = "0x402C870")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _portraitGrayMask;

		// Token: 0x0402C871 RID: 182385
		[Token(Token = "0x402C871")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402C872 RID: 182386
		[Token(Token = "0x402C872")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
