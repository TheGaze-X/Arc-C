using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044C6 RID: 17606
	[Token(Token = "0x20044C6")]
	public class RoguelikeTopicDifficultyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AE29 RID: 110121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE29")]
		[Address(RVA = "0x1409F20", Offset = "0x1408B20", VA = "0x181409F20")]
		public void Render(int position, RoguelikeTopicDifficultyItemModel itemModel)
		{
		}

		// Token: 0x0601AE2A RID: 110122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AE2A")]
		[Address(RVA = "0x140A460", Offset = "0x1409060", VA = "0x18140A460")]
		public RoguelikeTopicDifficultyItemView()
		{
		}

		// Token: 0x0402273F RID: 141119
		[Token(Token = "0x402273F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgTheme;

		// Token: 0x04022740 RID: 141120
		[Token(Token = "0x4022740")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _bgGo;

		// Token: 0x04022741 RID: 141121
		[Token(Token = "0x4022741")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04022742 RID: 141122
		[Token(Token = "0x4022742")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04022743 RID: 141123
		[Token(Token = "0x4022743")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgRelicIcon;

		// Token: 0x04022744 RID: 141124
		[Token(Token = "0x4022744")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgRelicEmpty;

		// Token: 0x04022745 RID: 141125
		[Token(Token = "0x4022745")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textFactor;

		// Token: 0x04022746 RID: 141126
		[Token(Token = "0x4022746")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _toggleUnlockItem;

		// Token: 0x04022747 RID: 141127
		[Token(Token = "0x4022747")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _toggleDoMonth;

		// Token: 0x04022748 RID: 141128
		[Token(Token = "0x4022748")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022749 RID: 141129
		[Token(Token = "0x4022749")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
