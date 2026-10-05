using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005731 RID: 22321
	[Token(Token = "0x2005731")]
	public class RL02ChoiceDiceDecoView : RoguelikeChoiceLeftDecoView
	{
		// Token: 0x06020B75 RID: 134005 RVA: 0x000B6F40 File Offset: 0x000B5140
		[Token(Token = "0x6020B75")]
		[Address(RVA = "0x1B04C80", Offset = "0x1B03880", VA = "0x181B04C80")]
		private bool _LoadData(string topicId, RoguelikeGameChoiceData choiceData, out int diceFaceNum, out int minGoodNum)
		{
			return default(bool);
		}

		// Token: 0x06020B76 RID: 134006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B76")]
		[Address(RVA = "0x1B04F40", Offset = "0x1B03B40", VA = "0x181B04F40")]
		private void _Render(int diceFaceNum, int minGoodNum)
		{
		}

		// Token: 0x06020B77 RID: 134007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B77")]
		[Address(RVA = "0x1B04B90", Offset = "0x1B03790", VA = "0x181B04B90", Slot = "4")]
		public override void Render(string topicId, RoguelikeGameChoiceData choiceData, PlayerRoguelikePendingEvent.ChoiceAddition playerAdditionData)
		{
		}

		// Token: 0x06020B78 RID: 134008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B78")]
		[Address(RVA = "0x1B05190", Offset = "0x1B03D90", VA = "0x181B05190")]
		public RL02ChoiceDiceDecoView()
		{
		}

		// Token: 0x06020B79 RID: 134009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B79")]
		[Address(RVA = "0x18A7030", Offset = "0x18A5C30", VA = "0x1818A7030")]
		private void <>xLuaBaseProxy_Render(string P0, RoguelikeGameChoiceData P1, PlayerRoguelikePendingEvent.ChoiceAddition P2)
		{
		}

		// Token: 0x0402C681 RID: 181889
		[Token(Token = "0x402C681")]
		private const string DICE_FACE_PREFIX = "dice_{0}";

		// Token: 0x0402C682 RID: 181890
		[Token(Token = "0x402C682")]
		private const string DICE_NUM_PREFIX = "img_{0}";

		// Token: 0x0402C683 RID: 181891
		[Token(Token = "0x402C683")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402C684 RID: 181892
		[Token(Token = "0x402C684")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x0402C685 RID: 181893
		[Token(Token = "0x402C685")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgNum;

		// Token: 0x0402C686 RID: 181894
		[Token(Token = "0x402C686")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x0402C687 RID: 181895
		[Token(Token = "0x402C687")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402C688 RID: 181896
		[Token(Token = "0x402C688")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C689 RID: 181897
		[Token(Token = "0x402C689")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
