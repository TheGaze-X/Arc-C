using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200559A RID: 21914
	[Token(Token = "0x200559A")]
	public class RL05CopperExchangeDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060202F6 RID: 131830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202F6")]
		[Address(RVA = "0x1A49D60", Offset = "0x1A48960", VA = "0x181A49D60")]
		public void Render(RoguelikeCopperExchangeInfoViewModel model)
		{
		}

		// Token: 0x060202F7 RID: 131831 RVA: 0x000B4E28 File Offset: 0x000B3028
		[Token(Token = "0x60202F7")]
		[Address(RVA = "0x1A4A180", Offset = "0x1A48D80", VA = "0x181A4A180")]
		private Color _GetColorFromLucky(RoguelikeCopperLuckyLevel luckyLevel)
		{
			return default(Color);
		}

		// Token: 0x060202F8 RID: 131832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202F8")]
		[Address(RVA = "0x1A4A280", Offset = "0x1A48E80", VA = "0x181A4A280")]
		public RL05CopperExchangeDetailItemView()
		{
		}

		// Token: 0x0402B812 RID: 178194
		[Token(Token = "0x402B812")]
		private const string COLOR_FORMAT = "<color=#{0}>{1}</color>";

		// Token: 0x0402B813 RID: 178195
		[Token(Token = "0x402B813")]
		private const float OLD_COPPER_ALPHA = 0.3333f;

		// Token: 0x0402B814 RID: 178196
		[Token(Token = "0x402B814")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _containerOldCopper;

		// Token: 0x0402B815 RID: 178197
		[Token(Token = "0x402B815")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _containerNewCopper;

		// Token: 0x0402B816 RID: 178198
		[Token(Token = "0x402B816")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402B817 RID: 178199
		[Token(Token = "0x402B817")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeSwapCopperResultDialog.NameColorGroup[] _nameColorGroups;

		// Token: 0x0402B818 RID: 178200
		[Token(Token = "0x402B818")]
		[FieldOffset(Offset = "0x38")]
		private RL05CommonCopperItemWithFrameView m_oldCopper;

		// Token: 0x0402B819 RID: 178201
		[Token(Token = "0x402B819")]
		[FieldOffset(Offset = "0x40")]
		private RL05CommonCopperItemWithFrameView m_newCopper;

		// Token: 0x0402B81A RID: 178202
		[Token(Token = "0x402B81A")]
		[FieldOffset(Offset = "0x48")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402B81B RID: 178203
		[Token(Token = "0x402B81B")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeCopperResHolder m_resHolder;

		// Token: 0x0402B81C RID: 178204
		[Token(Token = "0x402B81C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B81D RID: 178205
		[Token(Token = "0x402B81D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetColorFromLucky;

		// Token: 0x0402B81E RID: 178206
		[Token(Token = "0x402B81E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
