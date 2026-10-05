using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007132 RID: 28978
	[Token(Token = "0x2007132")]
	public class ActAutoChessRewardInfoModeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029253 RID: 168531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029253")]
		[Address(RVA = "0x248C630", Offset = "0x248B230", VA = "0x18248C630")]
		public void Render(ActAutoChessModeRewardModel model, bool isLast)
		{
		}

		// Token: 0x06029254 RID: 168532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029254")]
		[Address(RVA = "0x248C7A0", Offset = "0x248B3A0", VA = "0x18248C7A0")]
		public ActAutoChessRewardInfoModeItemView()
		{
		}

		// Token: 0x0403AC32 RID: 240690
		[Token(Token = "0x403AC32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActAutoChessRewardInfoModeItemView.ItemConfig[] _configList;

		// Token: 0x0403AC33 RID: 240691
		[Token(Token = "0x403AC33")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textFactor;

		// Token: 0x0403AC34 RID: 240692
		[Token(Token = "0x403AC34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSplit;

		// Token: 0x0403AC35 RID: 240693
		[Token(Token = "0x403AC35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AC36 RID: 240694
		[Token(Token = "0x403AC36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007133 RID: 28979
		[Token(Token = "0x2007133")]
		[Serializable]
		private struct ItemConfig
		{
			// Token: 0x0403AC37 RID: 240695
			[Token(Token = "0x403AC37")]
			[FieldOffset(Offset = "0x0")]
			public ActAutoChessModeType type;

			// Token: 0x0403AC38 RID: 240696
			[Token(Token = "0x403AC38")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}
	}
}
