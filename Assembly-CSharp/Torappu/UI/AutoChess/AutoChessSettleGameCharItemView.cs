using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062EB RID: 25323
	[Token(Token = "0x20062EB")]
	public class AutoChessSettleGameCharItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060247FC RID: 149500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247FC")]
		[Address(RVA = "0x1F552E0", Offset = "0x1F53EE0", VA = "0x181F552E0")]
		public void Render(AutoChessSettleGamePersonalCharItemViewModel model)
		{
		}

		// Token: 0x060247FD RID: 149501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247FD")]
		[Address(RVA = "0x1F55890", Offset = "0x1F54490", VA = "0x181F55890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060247FE RID: 149502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247FE")]
		[Address(RVA = "0x1F559B0", Offset = "0x1F545B0", VA = "0x181F559B0")]
		public AutoChessSettleGameCharItemView()
		{
		}

		// Token: 0x04032DBB RID: 208315
		[Token(Token = "0x4032DBB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _chessLevelRoot;

		// Token: 0x04032DBC RID: 208316
		[Token(Token = "0x4032DBC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessComLevel _comLevelPrefab;

		// Token: 0x04032DBD RID: 208317
		[Token(Token = "0x4032DBD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _evolvePhaseIconImage;

		// Token: 0x04032DBE RID: 208318
		[Token(Token = "0x4032DBE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x04032DBF RID: 208319
		[Token(Token = "0x4032DBF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _levelGoldenColor;

		// Token: 0x04032DC0 RID: 208320
		[Token(Token = "0x4032DC0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _levelNormalColor;

		// Token: 0x04032DC1 RID: 208321
		[Token(Token = "0x4032DC1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _portraitImage;

		// Token: 0x04032DC2 RID: 208322
		[Token(Token = "0x4032DC2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _isAssistPanel;

		// Token: 0x04032DC3 RID: 208323
		[Token(Token = "0x4032DC3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _isBackUpPanel;

		// Token: 0x04032DC4 RID: 208324
		[Token(Token = "0x4032DC4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _isPresetPanel;

		// Token: 0x04032DC5 RID: 208325
		[Token(Token = "0x4032DC5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AutoChessSettleGameEquipItemView[] _equipItems;

		// Token: 0x04032DC6 RID: 208326
		[Token(Token = "0x4032DC6")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04032DC7 RID: 208327
		[Token(Token = "0x4032DC7")]
		[FieldOffset(Offset = "0x88")]
		private ILoadAsset m_loadAsset;

		// Token: 0x04032DC8 RID: 208328
		[Token(Token = "0x4032DC8")]
		[FieldOffset(Offset = "0x90")]
		private AutoChessComLevel m_levelView;

		// Token: 0x04032DC9 RID: 208329
		[Token(Token = "0x4032DC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04032DCA RID: 208330
		[Token(Token = "0x4032DCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032DCB RID: 208331
		[Token(Token = "0x4032DCB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
