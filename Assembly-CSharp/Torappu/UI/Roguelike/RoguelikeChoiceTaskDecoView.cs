using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051C2 RID: 20930
	[Token(Token = "0x20051C2")]
	public class RoguelikeChoiceTaskDecoView : RoguelikeChoiceLeftDecoView
	{
		// Token: 0x0601EEA6 RID: 126630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEA6")]
		[Address(RVA = "0x18A6DF0", Offset = "0x18A59F0", VA = "0x1818A6DF0", Slot = "4")]
		public override void Render(string topicId, RoguelikeGameChoiceData choiceData, PlayerRoguelikePendingEvent.ChoiceAddition playerAdditionData)
		{
		}

		// Token: 0x0601EEA7 RID: 126631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEA7")]
		[Address(RVA = "0x18A7040", Offset = "0x18A5C40", VA = "0x1818A7040")]
		public RoguelikeChoiceTaskDecoView()
		{
		}

		// Token: 0x0601EEA8 RID: 126632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEA8")]
		[Address(RVA = "0x18A7030", Offset = "0x18A5C30", VA = "0x1818A7030")]
		private void <>xLuaBaseProxy_Render(string P0, RoguelikeGameChoiceData P1, PlayerRoguelikePendingEvent.ChoiceAddition P2)
		{
		}

		// Token: 0x0402978E RID: 169870
		[Token(Token = "0x402978E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402978F RID: 169871
		[Token(Token = "0x402978F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x04029790 RID: 169872
		[Token(Token = "0x4029790")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029791 RID: 169873
		[Token(Token = "0x4029791")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
