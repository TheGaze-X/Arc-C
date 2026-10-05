using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200532B RID: 21291
	[Token(Token = "0x200532B")]
	public class RoguelikeMenuTaskWindow : RoguelikeMenuWindow<RoguelikeMenuTaskViewModel>
	{
		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x0601F679 RID: 128633 RVA: 0x000B1D08 File Offset: 0x000AFF08
		[Token(Token = "0x1700499C")]
		private bool canClick
		{
			[Token(Token = "0x601F679")]
			[Address(RVA = "0x1919850", Offset = "0x1918450", VA = "0x181919850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F67A RID: 128634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F67A")]
		[Address(RVA = "0x19195A0", Offset = "0x19181A0", VA = "0x1819195A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x0601F67B RID: 128635 RVA: 0x000B1D20 File Offset: 0x000AFF20
		[Token(Token = "0x1700499D")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F67B")]
			[Address(RVA = "0x19198E0", Offset = "0x19184E0", VA = "0x1819198E0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F67C RID: 128636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F67C")]
		[Address(RVA = "0x19191D0", Offset = "0x1917DD0", VA = "0x1819191D0", Slot = "8")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F67D RID: 128637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F67D")]
		[Address(RVA = "0x19192B0", Offset = "0x1917EB0", VA = "0x1819192B0", Slot = "10")]
		public override void Render(RoguelikeMenuTaskViewModel viewModel)
		{
		}

		// Token: 0x0601F67E RID: 128638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F67E")]
		[Address(RVA = "0x19196D0", Offset = "0x19182D0", VA = "0x1819196D0")]
		private void _SetButtonState(bool showConfirm, bool fastMode = false)
		{
		}

		// Token: 0x0601F67F RID: 128639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F67F")]
		[Address(RVA = "0x1919150", Offset = "0x1917D50", VA = "0x181919150")]
		public void OnBtnNormalClicked()
		{
		}

		// Token: 0x0601F680 RID: 128640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F680")]
		[Address(RVA = "0x1919060", Offset = "0x1917C60", VA = "0x181919060")]
		public void OnBtnConfirmClicked()
		{
		}

		// Token: 0x0601F681 RID: 128641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F681")]
		[Address(RVA = "0x19197E0", Offset = "0x19183E0", VA = "0x1819197E0")]
		public RoguelikeMenuTaskWindow()
		{
		}

		// Token: 0x0601F682 RID: 128642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F682")]
		[Address(RVA = "0x19153E0", Offset = "0x1913FE0", VA = "0x1819153E0")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0402A3B2 RID: 172978
		[Token(Token = "0x402A3B2")]
		private const string PROGRESS_FORMAT = "{0}/{1}";

		// Token: 0x0402A3B3 RID: 172979
		[Token(Token = "0x402A3B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTaskTitle;

		// Token: 0x0402A3B4 RID: 172980
		[Token(Token = "0x402A3B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTaskDesc;

		// Token: 0x0402A3B5 RID: 172981
		[Token(Token = "0x402A3B5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTaskProgress;

		// Token: 0x0402A3B6 RID: 172982
		[Token(Token = "0x402A3B6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _progressBar;

		// Token: 0x0402A3B7 RID: 172983
		[Token(Token = "0x402A3B7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _taskRarityIcon;

		// Token: 0x0402A3B8 RID: 172984
		[Token(Token = "0x402A3B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _taskRarityIconAtlas;

		// Token: 0x0402A3B9 RID: 172985
		[Token(Token = "0x402A3B9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string[] _taskRarityIconNames;

		// Token: 0x0402A3BA RID: 172986
		[Token(Token = "0x402A3BA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelIncomplete;

		// Token: 0x0402A3BB RID: 172987
		[Token(Token = "0x402A3BB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0402A3BC RID: 172988
		[Token(Token = "0x402A3BC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasNormal;

		// Token: 0x0402A3BD RID: 172989
		[Token(Token = "0x402A3BD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasConfirm;

		// Token: 0x0402A3BE RID: 172990
		[Token(Token = "0x402A3BE")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedTaskId;

		// Token: 0x0402A3BF RID: 172991
		[Token(Token = "0x402A3BF")]
		[FieldOffset(Offset = "0x88")]
		private FadeSwitchTween m_normalShowTween;

		// Token: 0x0402A3C0 RID: 172992
		[Token(Token = "0x402A3C0")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_confirmShowTween;

		// Token: 0x0402A3C1 RID: 172993
		[Token(Token = "0x402A3C1")]
		[FieldOffset(Offset = "0x98")]
		private bool m_init;

		// Token: 0x0402A3C2 RID: 172994
		[Token(Token = "0x402A3C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canClick;

		// Token: 0x0402A3C3 RID: 172995
		[Token(Token = "0x402A3C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A3C4 RID: 172996
		[Token(Token = "0x402A3C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A3C5 RID: 172997
		[Token(Token = "0x402A3C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A3C6 RID: 172998
		[Token(Token = "0x402A3C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A3C7 RID: 172999
		[Token(Token = "0x402A3C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetButtonState;

		// Token: 0x0402A3C8 RID: 173000
		[Token(Token = "0x402A3C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnNormalClicked;

		// Token: 0x0402A3C9 RID: 173001
		[Token(Token = "0x402A3C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnConfirmClicked;

		// Token: 0x0402A3CA RID: 173002
		[Token(Token = "0x402A3CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
