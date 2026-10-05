using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B7 RID: 6583
	[Token(Token = "0x20019B7")]
	public class FurnitureItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000050 RID: 80
		// (add) Token: 0x0600A55B RID: 42331 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A55C RID: 42332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000050")]
		public event Action<DIYItemViewData, FurnitureItemView> buttonPressed
		{
			[Token(Token = "0x600A55B")]
			[Address(RVA = "0x31FDB10", Offset = "0x31FC710", VA = "0x1831FDB10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A55C")]
			[Address(RVA = "0x31FDF90", Offset = "0x31FCB90", VA = "0x1831FDF90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x0600A55D RID: 42333 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A55E RID: 42334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000051")]
		public event Action<DIYItemViewData, FurnitureItemView> subButtonPressed
		{
			[Token(Token = "0x600A55D")]
			[Address(RVA = "0x31FDE70", Offset = "0x31FCA70", VA = "0x1831FDE70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A55E")]
			[Address(RVA = "0x31FE2F0", Offset = "0x31FCEF0", VA = "0x1831FE2F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x0600A55F RID: 42335 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A560 RID: 42336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000052")]
		public event Action<DIYItemViewData, FurnitureItemView> renameButtonPressed
		{
			[Token(Token = "0x600A55F")]
			[Address(RVA = "0x31FDD50", Offset = "0x31FC950", VA = "0x1831FDD50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A560")]
			[Address(RVA = "0x31FE1D0", Offset = "0x31FCDD0", VA = "0x1831FE1D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x0600A561 RID: 42337 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600A562 RID: 42338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000053")]
		public event Action<DIYItemViewData, FurnitureItemView> infoButtonPressed
		{
			[Token(Token = "0x600A561")]
			[Address(RVA = "0x31FDC30", Offset = "0x31FC830", VA = "0x1831FDC30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600A562")]
			[Address(RVA = "0x31FE0B0", Offset = "0x31FCCB0", VA = "0x1831FE0B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600A563 RID: 42339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A563")]
		[Address(RVA = "0x31FD8E0", Offset = "0x31FC4E0", VA = "0x1831FD8E0")]
		private void _SetupIcon(Image img, Sprite sp)
		{
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A564")]
		[Address(RVA = "0x31FCCC0", Offset = "0x31FB8C0", VA = "0x1831FCCC0")]
		public void Setup(DIYItemViewData data)
		{
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x00040158 File Offset: 0x0003E358
		[Token(Token = "0x600A565")]
		[Address(RVA = "0x31FC830", Offset = "0x31FB430", VA = "0x1831FC830")]
		public int GetViewIndex()
		{
			return 0;
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A566")]
		[Address(RVA = "0x31FCC30", Offset = "0x31FB830", VA = "0x1831FCC30")]
		public void SetViewIndex(int index)
		{
		}

		// Token: 0x0600A567 RID: 42343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A567")]
		[Address(RVA = "0x31FC8A0", Offset = "0x31FB4A0", VA = "0x1831FC8A0")]
		public void OnButtonPressed()
		{
		}

		// Token: 0x0600A568 RID: 42344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A568")]
		[Address(RVA = "0x31FCB70", Offset = "0x31FB770", VA = "0x1831FCB70")]
		public void OnSubButtonPressed()
		{
		}

		// Token: 0x0600A569 RID: 42345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A569")]
		[Address(RVA = "0x31FCAB0", Offset = "0x31FB6B0", VA = "0x1831FCAB0")]
		public void OnRenameButtonPressed()
		{
		}

		// Token: 0x0600A56A RID: 42346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A56A")]
		[Address(RVA = "0x31FCA10", Offset = "0x31FB610", VA = "0x1831FCA10")]
		public void OnInfoButtonPressed()
		{
		}

		// Token: 0x0600A56B RID: 42347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A56B")]
		[Address(RVA = "0x31FC960", Offset = "0x31FB560", VA = "0x1831FC960")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A56C RID: 42348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A56C")]
		[Address(RVA = "0x31FDA90", Offset = "0x31FC690", VA = "0x1831FDA90")]
		public FurnitureItemView()
		{
		}

		// Token: 0x04009CF6 RID: 40182
		[Token(Token = "0x4009CF6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x04009CF7 RID: 40183
		[Token(Token = "0x4009CF7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_DISABLED;

		// Token: 0x04009CF8 RID: 40184
		[Token(Token = "0x4009CF8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04009CF9 RID: 40185
		[Token(Token = "0x4009CF9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _countTextRoot;

		// Token: 0x04009CFA RID: 40186
		[Token(Token = "0x4009CFA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _countTextCornerRoot;

		// Token: 0x04009CFB RID: 40187
		[Token(Token = "0x4009CFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _countText;

		// Token: 0x04009CFC RID: 40188
		[Token(Token = "0x4009CFC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _countCornerText;

		// Token: 0x04009CFD RID: 40189
		[Token(Token = "0x4009CFD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _button;

		// Token: 0x04009CFE RID: 40190
		[Token(Token = "0x4009CFE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _upperInfoButton;

		// Token: 0x04009CFF RID: 40191
		[Token(Token = "0x4009CFF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _lowerInfoButton;

		// Token: 0x04009D00 RID: 40192
		[Token(Token = "0x4009D00")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _renameButton;

		// Token: 0x04009D01 RID: 40193
		[Token(Token = "0x4009D01")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _bigIcon;

		// Token: 0x04009D02 RID: 40194
		[Token(Token = "0x4009D02")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _smallIcon;

		// Token: 0x04009D03 RID: 40195
		[Token(Token = "0x4009D03")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObjectArrayCountControl _starArray;

		// Token: 0x04009D04 RID: 40196
		[Token(Token = "0x4009D04")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _meetingOnlyIcon;

		// Token: 0x04009D05 RID: 40197
		[Token(Token = "0x4009D05")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _comfortPanel;

		// Token: 0x04009D06 RID: 40198
		[Token(Token = "0x4009D06")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _comfortLabel;

		// Token: 0x04009D07 RID: 40199
		[Token(Token = "0x4009D07")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _selectedMark;

		// Token: 0x04009D08 RID: 40200
		[Token(Token = "0x4009D08")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04009D09 RID: 40201
		[Token(Token = "0x4009D09")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _disableAlpha;

		// Token: 0x04009D0A RID: 40202
		[Token(Token = "0x4009D0A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _newMark;

		// Token: 0x04009D0B RID: 40203
		[Token(Token = "0x4009D0B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _pnlInvalidMask;

		// Token: 0x04009D0C RID: 40204
		[Token(Token = "0x4009D0C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textInvalid;

		// Token: 0x04009D0D RID: 40205
		[Token(Token = "0x4009D0D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _disableMask;

		// Token: 0x04009D0E RID: 40206
		[Token(Token = "0x4009D0E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Graphic _disableGraphic;

		// Token: 0x04009D0F RID: 40207
		[Token(Token = "0x4009D0F")]
		[FieldOffset(Offset = "0xD0")]
		private DIYItemViewData m_itemData;

		// Token: 0x04009D10 RID: 40208
		[Token(Token = "0x4009D10")]
		[FieldOffset(Offset = "0xD8")]
		private int m_viewIndex;

		// Token: 0x04009D15 RID: 40213
		[Token(Token = "0x4009D15")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_add_buttonPressed;

		// Token: 0x04009D16 RID: 40214
		[Token(Token = "0x4009D16")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_remove_buttonPressed;

		// Token: 0x04009D17 RID: 40215
		[Token(Token = "0x4009D17")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_add_subButtonPressed;

		// Token: 0x04009D18 RID: 40216
		[Token(Token = "0x4009D18")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_remove_subButtonPressed;

		// Token: 0x04009D19 RID: 40217
		[Token(Token = "0x4009D19")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_add_renameButtonPressed;

		// Token: 0x04009D1A RID: 40218
		[Token(Token = "0x4009D1A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_remove_renameButtonPressed;

		// Token: 0x04009D1B RID: 40219
		[Token(Token = "0x4009D1B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_add_infoButtonPressed;

		// Token: 0x04009D1C RID: 40220
		[Token(Token = "0x4009D1C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_remove_infoButtonPressed;

		// Token: 0x04009D1D RID: 40221
		[Token(Token = "0x4009D1D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SetupIcon;

		// Token: 0x04009D1E RID: 40222
		[Token(Token = "0x4009D1E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009D1F RID: 40223
		[Token(Token = "0x4009D1F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetViewIndex;

		// Token: 0x04009D20 RID: 40224
		[Token(Token = "0x4009D20")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SetViewIndex;

		// Token: 0x04009D21 RID: 40225
		[Token(Token = "0x4009D21")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnButtonPressed;

		// Token: 0x04009D22 RID: 40226
		[Token(Token = "0x4009D22")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnSubButtonPressed;

		// Token: 0x04009D23 RID: 40227
		[Token(Token = "0x4009D23")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnRenameButtonPressed;

		// Token: 0x04009D24 RID: 40228
		[Token(Token = "0x4009D24")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnInfoButtonPressed;

		// Token: 0x04009D25 RID: 40229
		[Token(Token = "0x4009D25")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04009D26 RID: 40230
		[Token(Token = "0x4009D26")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
