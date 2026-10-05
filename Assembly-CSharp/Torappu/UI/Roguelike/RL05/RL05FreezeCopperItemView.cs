using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200559E RID: 21918
	[Token(Token = "0x200559E")]
	public class RL05FreezeCopperItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602030B RID: 131851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602030B")]
		[Address(RVA = "0x1A52E20", Offset = "0x1A51A20", VA = "0x181A52E20")]
		public void Render(RoguelikePlayerCopperItemViewModel viewModel, bool isSelected, bool isMax, int sequenceNum)
		{
		}

		// Token: 0x0602030C RID: 131852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602030C")]
		[Address(RVA = "0x1A532D0", Offset = "0x1A51ED0", VA = "0x181A532D0")]
		public void ResetStatus()
		{
		}

		// Token: 0x0602030D RID: 131853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602030D")]
		[Address(RVA = "0x1A53360", Offset = "0x1A51F60", VA = "0x181A53360")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602030E RID: 131854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602030E")]
		[Address(RVA = "0x1A52D20", Offset = "0x1A51920", VA = "0x181A52D20")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602030F RID: 131855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602030F")]
		[Address(RVA = "0x1A53500", Offset = "0x1A52100", VA = "0x181A53500")]
		public RL05FreezeCopperItemView()
		{
		}

		// Token: 0x0402B838 RID: 178232
		[Token(Token = "0x402B838")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animSelected;

		// Token: 0x0402B839 RID: 178233
		[Token(Token = "0x402B839")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animDisabled;

		// Token: 0x0402B83A RID: 178234
		[Token(Token = "0x402B83A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _copperFrameItemHolder;

		// Token: 0x0402B83B RID: 178235
		[Token(Token = "0x402B83B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _copperLuckyIcon;

		// Token: 0x0402B83C RID: 178236
		[Token(Token = "0x402B83C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _copperName;

		// Token: 0x0402B83D RID: 178237
		[Token(Token = "0x402B83D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _isDrawn;

		// Token: 0x0402B83E RID: 178238
		[Token(Token = "0x402B83E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _countDownObj;

		// Token: 0x0402B83F RID: 178239
		[Token(Token = "0x402B83F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _countDownText;

		// Token: 0x0402B840 RID: 178240
		[Token(Token = "0x402B840")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _copperLayerDesc;

		// Token: 0x0402B841 RID: 178241
		[Token(Token = "0x402B841")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0402B842 RID: 178242
		[Token(Token = "0x402B842")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_selectTween;

		// Token: 0x0402B843 RID: 178243
		[Token(Token = "0x402B843")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_disableTween;

		// Token: 0x0402B844 RID: 178244
		[Token(Token = "0x402B844")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedInstId;

		// Token: 0x0402B845 RID: 178245
		[Token(Token = "0x402B845")]
		[FieldOffset(Offset = "0x90")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402B846 RID: 178246
		[Token(Token = "0x402B846")]
		[FieldOffset(Offset = "0xA0")]
		private RoguelikeCopperResHolder m_resHolder;

		// Token: 0x0402B847 RID: 178247
		[Token(Token = "0x402B847")]
		[FieldOffset(Offset = "0xA8")]
		private RL05CommonCopperItemWithFrameView m_copperFrameItemView;

		// Token: 0x0402B848 RID: 178248
		[Token(Token = "0x402B848")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedSequenceNum;

		// Token: 0x0402B849 RID: 178249
		[Token(Token = "0x402B849")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B84A RID: 178250
		[Token(Token = "0x402B84A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x0402B84B RID: 178251
		[Token(Token = "0x402B84B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B84C RID: 178252
		[Token(Token = "0x402B84C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0402B84D RID: 178253
		[Token(Token = "0x402B84D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
