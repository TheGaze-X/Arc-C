using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FF3 RID: 28659
	[Token(Token = "0x2006FF3")]
	public class ActMultiV3StageListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028B22 RID: 166690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B22")]
		[Address(RVA = "0x24100C0", Offset = "0x240ECC0", VA = "0x1824100C0")]
		public void Render(ActMultiV3StageItemViewModel viewModel, ActMultiV3StageListViewModel stageListViewModel)
		{
		}

		// Token: 0x06028B23 RID: 166691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B23")]
		[Address(RVA = "0x2410320", Offset = "0x240EF20", VA = "0x182410320")]
		private void _RenderStageInfo(ActMultiV3StageItemViewModel viewModel)
		{
		}

		// Token: 0x06028B24 RID: 166692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B24")]
		[Address(RVA = "0x24104D0", Offset = "0x240F0D0", VA = "0x1824104D0")]
		private void _UpdateLockInfo(ActMultiV3StageItemViewModel viewModel)
		{
		}

		// Token: 0x06028B25 RID: 166693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B25")]
		[Address(RVA = "0x240FFD0", Offset = "0x240EBD0", VA = "0x18240FFD0")]
		public void OnClicked()
		{
		}

		// Token: 0x06028B26 RID: 166694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B26")]
		[Address(RVA = "0x2410630", Offset = "0x240F230", VA = "0x182410630")]
		public ActMultiV3StageListItem()
		{
		}

		// Token: 0x04039FF6 RID: 237558
		[Token(Token = "0x4039FF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _stageCodeText;

		// Token: 0x04039FF7 RID: 237559
		[Token(Token = "0x4039FF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _stageImage;

		// Token: 0x04039FF8 RID: 237560
		[Token(Token = "0x4039FF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _cornerImage;

		// Token: 0x04039FF9 RID: 237561
		[Token(Token = "0x4039FF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlCorner;

		// Token: 0x04039FFA RID: 237562
		[Token(Token = "0x4039FFA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x04039FFB RID: 237563
		[Token(Token = "0x4039FFB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _imgLock;

		// Token: 0x04039FFC RID: 237564
		[Token(Token = "0x4039FFC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _imgLockPosWithText;

		// Token: 0x04039FFD RID: 237565
		[Token(Token = "0x4039FFD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _imgLockPosWithoutText;

		// Token: 0x04039FFE RID: 237566
		[Token(Token = "0x4039FFE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textOpenTime;

		// Token: 0x04039FFF RID: 237567
		[Token(Token = "0x4039FFF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _randomPanel;

		// Token: 0x0403A000 RID: 237568
		[Token(Token = "0x403A000")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _notRandomPanel;

		// Token: 0x0403A001 RID: 237569
		[Token(Token = "0x403A001")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3StageListItem.ModeViewConfig[] _modeViewConfigs;

		// Token: 0x0403A002 RID: 237570
		[Token(Token = "0x403A002")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _pnlSelected;

		// Token: 0x0403A003 RID: 237571
		[Token(Token = "0x403A003")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlTrackpoint;

		// Token: 0x0403A004 RID: 237572
		[Token(Token = "0x403A004")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A005 RID: 237573
		[Token(Token = "0x403A005")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedStageId;

		// Token: 0x0403A006 RID: 237574
		[Token(Token = "0x403A006")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A007 RID: 237575
		[Token(Token = "0x403A007")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderStageInfo;

		// Token: 0x0403A008 RID: 237576
		[Token(Token = "0x403A008")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateLockInfo;

		// Token: 0x0403A009 RID: 237577
		[Token(Token = "0x403A009")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0403A00A RID: 237578
		[Token(Token = "0x403A00A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FF4 RID: 28660
		[Token(Token = "0x2006FF4")]
		[Serializable]
		private struct ModeViewConfig
		{
			// Token: 0x0403A00B RID: 237579
			[Token(Token = "0x403A00B")]
			[FieldOffset(Offset = "0x0")]
			public List<ActMultiV3MapModeType> types;

			// Token: 0x0403A00C RID: 237580
			[Token(Token = "0x403A00C")]
			[FieldOffset(Offset = "0x8")]
			public ActMultiV3StageListItemModeView view;
		}
	}
}
