using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004633 RID: 17971
	[Token(Token = "0x2004633")]
	public class RL01CurrentDifficultyView : RoguelikeTopicCurrentDifficultyBaseView
	{
		// Token: 0x0601B4BA RID: 111802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4BA")]
		[Address(RVA = "0x1499B60", Offset = "0x1498760", VA = "0x181499B60", Slot = "5")]
		protected override void OnRender(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601B4BB RID: 111803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4BB")]
		[Address(RVA = "0x1499A70", Offset = "0x1498670", VA = "0x181499A70", Slot = "6")]
		protected override void OnRenderDifficulty(RoguelikeTopicDifficultyViewModel diffModel)
		{
		}

		// Token: 0x0601B4BC RID: 111804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4BC")]
		[Address(RVA = "0x1499C80", Offset = "0x1498880", VA = "0x181499C80")]
		public RL01CurrentDifficultyView()
		{
		}

		// Token: 0x0601B4BD RID: 111805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4BD")]
		[Address(RVA = "0x142FAD0", Offset = "0x142E6D0", VA = "0x18142FAD0")]
		private void <>xLuaBaseProxy_OnRenderDifficulty(RoguelikeTopicDifficultyViewModel P0)
		{
		}

		// Token: 0x040233EA RID: 144362
		[Token(Token = "0x40233EA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _gradeGO;

		// Token: 0x040233EB RID: 144363
		[Token(Token = "0x40233EB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _gradeText;

		// Token: 0x040233EC RID: 144364
		[Token(Token = "0x40233EC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x040233ED RID: 144365
		[Token(Token = "0x40233ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040233EE RID: 144366
		[Token(Token = "0x40233EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderDifficulty;

		// Token: 0x040233EF RID: 144367
		[Token(Token = "0x40233EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
