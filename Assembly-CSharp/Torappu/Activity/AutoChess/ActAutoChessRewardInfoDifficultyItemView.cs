using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200712F RID: 28975
	[Token(Token = "0x200712F")]
	public class ActAutoChessRewardInfoDifficultyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602924F RID: 168527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602924F")]
		[Address(RVA = "0x248C2C0", Offset = "0x248AEC0", VA = "0x18248C2C0")]
		public void Render(ActAutoChessDifficultyRewardModel model, bool isLast)
		{
		}

		// Token: 0x06029250 RID: 168528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029250")]
		[Address(RVA = "0x248C430", Offset = "0x248B030", VA = "0x18248C430")]
		public ActAutoChessRewardInfoDifficultyItemView()
		{
		}

		// Token: 0x0403AC26 RID: 240678
		[Token(Token = "0x403AC26")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActAutoChessRewardInfoDifficultyItemView.ItemConfig[] _configList;

		// Token: 0x0403AC27 RID: 240679
		[Token(Token = "0x403AC27")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textFactor;

		// Token: 0x0403AC28 RID: 240680
		[Token(Token = "0x403AC28")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x0403AC29 RID: 240681
		[Token(Token = "0x403AC29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AC2A RID: 240682
		[Token(Token = "0x403AC2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007130 RID: 28976
		[Token(Token = "0x2007130")]
		[Serializable]
		private struct ItemConfig
		{
			// Token: 0x0403AC2B RID: 240683
			[Token(Token = "0x403AC2B")]
			[FieldOffset(Offset = "0x0")]
			public ActAutoChessModeDifficultyType type;

			// Token: 0x0403AC2C RID: 240684
			[Token(Token = "0x403AC2C")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}
	}
}
