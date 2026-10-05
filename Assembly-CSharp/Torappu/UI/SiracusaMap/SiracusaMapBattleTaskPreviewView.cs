using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Resource;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F4F RID: 16207
	[Token(Token = "0x2003F4F")]
	public class SiracusaMapBattleTaskPreviewView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x06019288 RID: 103048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019288")]
		[Address(RVA = "0x11D26C0", Offset = "0x11D12C0", VA = "0x1811D26C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019289 RID: 103049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019289")]
		[Address(RVA = "0x11D1D90", Offset = "0x11D0990", VA = "0x1811D1D90", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x0601928A RID: 103050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601928A")]
		[Address(RVA = "0x11D2350", Offset = "0x11D0F50", VA = "0x1811D2350")]
		public void OpenMapTips()
		{
		}

		// Token: 0x0601928B RID: 103051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601928B")]
		[Address(RVA = "0x11D2900", Offset = "0x11D1500", VA = "0x1811D2900")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x0601928C RID: 103052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601928C")]
		[Address(RVA = "0x11D2830", Offset = "0x11D1430", VA = "0x1811D2830")]
		private void _OnCleanMapPreview()
		{
		}

		// Token: 0x0601928D RID: 103053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601928D")]
		[Address(RVA = "0x11D2590", Offset = "0x11D1190", VA = "0x1811D2590")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x0601928E RID: 103054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601928E")]
		[Address(RVA = "0x11D2A80", Offset = "0x11D1680", VA = "0x1811D2A80")]
		public SiracusaMapBattleTaskPreviewView()
		{
		}

		// Token: 0x0401F2F8 RID: 127736
		[Token(Token = "0x401F2F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0401F2F9 RID: 127737
		[Token(Token = "0x401F2F9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itaName;

		// Token: 0x0401F2FA RID: 127738
		[Token(Token = "0x401F2FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _missionDetail;

		// Token: 0x0401F2FB RID: 127739
		[Token(Token = "0x401F2FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stageDesc;

		// Token: 0x0401F2FC RID: 127740
		[Token(Token = "0x401F2FC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _missionFormatColor;

		// Token: 0x0401F2FD RID: 127741
		[Token(Token = "0x401F2FD")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public GameObject mapTips;

		// Token: 0x0401F2FE RID: 127742
		[Token(Token = "0x401F2FE")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Image previewImg;

		// Token: 0x0401F2FF RID: 127743
		[Token(Token = "0x401F2FF")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Image backTips;

		// Token: 0x0401F300 RID: 127744
		[Token(Token = "0x401F300")]
		[FieldOffset(Offset = "0x68")]
		private StageViewModel m_selectViewModel;

		// Token: 0x0401F301 RID: 127745
		[Token(Token = "0x401F301")]
		[FieldOffset(Offset = "0x70")]
		private DirectAssetLoader m_stagePreviewMapLoader;

		// Token: 0x0401F302 RID: 127746
		[Token(Token = "0x401F302")]
		[FieldOffset(Offset = "0x78")]
		private Sprite m_mapPreviewSprite;

		// Token: 0x0401F303 RID: 127747
		[Token(Token = "0x401F303")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401F304 RID: 127748
		[Token(Token = "0x401F304")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F305 RID: 127749
		[Token(Token = "0x401F305")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F306 RID: 127750
		[Token(Token = "0x401F306")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenMapTips;

		// Token: 0x0401F307 RID: 127751
		[Token(Token = "0x401F307")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x0401F308 RID: 127752
		[Token(Token = "0x401F308")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCleanMapPreview;

		// Token: 0x0401F309 RID: 127753
		[Token(Token = "0x401F309")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x0401F30A RID: 127754
		[Token(Token = "0x401F30A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
