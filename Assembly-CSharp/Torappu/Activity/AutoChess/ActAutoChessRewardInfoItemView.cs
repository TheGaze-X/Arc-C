using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007131 RID: 28977
	[Token(Token = "0x2007131")]
	public class ActAutoChessRewardInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029251 RID: 168529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029251")]
		[Address(RVA = "0x248C490", Offset = "0x248B090", VA = "0x18248C490")]
		public void Render(ActAutoChessSingleRoundRewardModel model, bool isLast)
		{
		}

		// Token: 0x06029252 RID: 168530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029252")]
		[Address(RVA = "0x248C5D0", Offset = "0x248B1D0", VA = "0x18248C5D0")]
		public ActAutoChessRewardInfoItemView()
		{
		}

		// Token: 0x0403AC2D RID: 240685
		[Token(Token = "0x403AC2D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textRound;

		// Token: 0x0403AC2E RID: 240686
		[Token(Token = "0x403AC2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textReward;

		// Token: 0x0403AC2F RID: 240687
		[Token(Token = "0x403AC2F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x0403AC30 RID: 240688
		[Token(Token = "0x403AC30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AC31 RID: 240689
		[Token(Token = "0x403AC31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
