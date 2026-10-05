using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200605B RID: 24667
	[Token(Token = "0x200605B")]
	public class CarvingMainCardDetailView : DataBinder<CarvingMainProperty>
	{
		// Token: 0x06023AAD RID: 146093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AAD")]
		[Address(RVA = "0x1E4BB90", Offset = "0x1E4A790", VA = "0x181E4BB90", Slot = "7")]
		public override void OnValueChanged(CarvingMainProperty property)
		{
		}

		// Token: 0x06023AAE RID: 146094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AAE")]
		[Address(RVA = "0x1E4C110", Offset = "0x1E4AD10", VA = "0x181E4C110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023AAF RID: 146095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AAF")]
		[Address(RVA = "0x1E4C250", Offset = "0x1E4AE50", VA = "0x181E4C250")]
		private void _RenderTargetTransfer(List<CarvingMainCardMaterialViewModel> inputMaterials, List<CarvingMainCardMaterialViewModel> outputMaterials, int selectSeqNum)
		{
		}

		// Token: 0x06023AB0 RID: 146096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AB0")]
		[Address(RVA = "0x1E4C4A0", Offset = "0x1E4B0A0", VA = "0x181E4C4A0")]
		public CarvingMainCardDetailView()
		{
		}

		// Token: 0x04031697 RID: 202391
		[Token(Token = "0x4031697")]
		private const string CARD_LEVEL_IMG = "level_{0}";

		// Token: 0x04031698 RID: 202392
		[Token(Token = "0x4031698")]
		private const string CARD_UPGRADE_LEVEL_IMAGE = "level_upgrade_{0}";

		// Token: 0x04031699 RID: 202393
		[Token(Token = "0x4031699")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animPanelSwitch;

		// Token: 0x0403169A RID: 202394
		[Token(Token = "0x403169A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _transferAnim;

		// Token: 0x0403169B RID: 202395
		[Token(Token = "0x403169B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0403169C RID: 202396
		[Token(Token = "0x403169C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _cardUpgradeNotice;

		// Token: 0x0403169D RID: 202397
		[Token(Token = "0x403169D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _bkgCardLevel;

		// Token: 0x0403169E RID: 202398
		[Token(Token = "0x403169E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _bkgCardFaceType;

		// Token: 0x0403169F RID: 202399
		[Token(Token = "0x403169F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _cardLevelToggle;

		// Token: 0x040316A0 RID: 202400
		[Token(Token = "0x40316A0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _cardLevel;

		// Token: 0x040316A1 RID: 202401
		[Token(Token = "0x40316A1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _cardUpgradeCurLevel;

		// Token: 0x040316A2 RID: 202402
		[Token(Token = "0x40316A2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _cardUpgradeNextLevel;

		// Token: 0x040316A3 RID: 202403
		[Token(Token = "0x40316A3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<CarvingMainCardTransferView> _cardTransfers;

		// Token: 0x040316A4 RID: 202404
		[Token(Token = "0x40316A4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _title;

		// Token: 0x040316A5 RID: 202405
		[Token(Token = "0x40316A5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _maxLevel;

		// Token: 0x040316A6 RID: 202406
		[Token(Token = "0x40316A6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _cardDesc;

		// Token: 0x040316A7 RID: 202407
		[Token(Token = "0x40316A7")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x040316A8 RID: 202408
		[Token(Token = "0x40316A8")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_panelSwitchTween;

		// Token: 0x040316A9 RID: 202409
		[Token(Token = "0x40316A9")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_transferTween;

		// Token: 0x040316AA RID: 202410
		[Token(Token = "0x40316AA")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedSelectSeqNum;

		// Token: 0x040316AB RID: 202411
		[Token(Token = "0x40316AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040316AC RID: 202412
		[Token(Token = "0x40316AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040316AD RID: 202413
		[Token(Token = "0x40316AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderTargetTransfer;

		// Token: 0x040316AE RID: 202414
		[Token(Token = "0x40316AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
