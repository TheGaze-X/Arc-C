using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005815 RID: 22549
	[Token(Token = "0x2005815")]
	public class RL03VisionDecoView : RoguelikeChoiceLeftDecoView
	{
		// Token: 0x06020F3F RID: 134975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F3F")]
		[Address(RVA = "0x1B584F0", Offset = "0x1B570F0", VA = "0x181B584F0")]
		private RoguelikeVisionModuleData.VisionChoiceConfig _LoadData(string topicId, RoguelikeGameChoiceData choiceData)
		{
			return null;
		}

		// Token: 0x06020F40 RID: 134976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F40")]
		[Address(RVA = "0x1B58640", Offset = "0x1B57240", VA = "0x181B58640")]
		private void _Render(RoguelikeVisionModuleData.VisionChoiceConfig visionChoiceConfig)
		{
		}

		// Token: 0x06020F41 RID: 134977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F41")]
		[Address(RVA = "0x1B58260", Offset = "0x1B56E60", VA = "0x181B58260", Slot = "4")]
		public override void Render(string topicId, RoguelikeGameChoiceData choiceData, PlayerRoguelikePendingEvent.ChoiceAddition playerAdditionData)
		{
		}

		// Token: 0x06020F42 RID: 134978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F42")]
		[Address(RVA = "0x1B58740", Offset = "0x1B57340", VA = "0x181B58740")]
		public RL03VisionDecoView()
		{
		}

		// Token: 0x06020F43 RID: 134979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F43")]
		[Address(RVA = "0x18A7030", Offset = "0x18A5C30", VA = "0x1818A7030")]
		private void <>xLuaBaseProxy_Render(string P0, RoguelikeGameChoiceData P1, PlayerRoguelikePendingEvent.ChoiceAddition P2)
		{
		}

		// Token: 0x0402CCDC RID: 183516
		[Token(Token = "0x402CCDC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _pnlLower;

		// Token: 0x0402CCDD RID: 183517
		[Token(Token = "0x402CCDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlUpper;

		// Token: 0x0402CCDE RID: 183518
		[Token(Token = "0x402CCDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textVision;

		// Token: 0x0402CCDF RID: 183519
		[Token(Token = "0x402CCDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0402CCE0 RID: 183520
		[Token(Token = "0x402CCE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402CCE1 RID: 183521
		[Token(Token = "0x402CCE1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CCE2 RID: 183522
		[Token(Token = "0x402CCE2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
