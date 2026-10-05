using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x020032E0 RID: 13024
	[Token(Token = "0x20032E0")]
	public class UIBattleLoading : MonoBehaviour, IHotfixable
	{
		// Token: 0x06014B4B RID: 84811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B4B")]
		[Address(RVA = "0xD20D80", Offset = "0xD1F980", VA = "0x180D20D80")]
		public void SetData(BattleStageInfo stageInfo)
		{
		}

		// Token: 0x06014B4C RID: 84812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014B4C")]
		[Address(RVA = "0xD217B0", Offset = "0xD203B0", VA = "0x180D217B0")]
		private UIBattleLoadingDecor _LoadLoadingDecor(string loadingPicId)
		{
			return null;
		}

		// Token: 0x06014B4D RID: 84813 RVA: 0x000880C8 File Offset: 0x000862C8
		[Token(Token = "0x6014B4D")]
		[Address(RVA = "0xD213F0", Offset = "0xD1FFF0", VA = "0x180D213F0")]
		public float StartSwitchScene()
		{
			return 0f;
		}

		// Token: 0x06014B4E RID: 84814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B4E")]
		[Address(RVA = "0xD215E0", Offset = "0xD201E0", VA = "0x180D215E0")]
		private void Update()
		{
		}

		// Token: 0x06014B4F RID: 84815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B4F")]
		[Address(RVA = "0xD20CF0", Offset = "0xD1F8F0", VA = "0x180D20CF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014B50 RID: 84816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014B50")]
		[Address(RVA = "0xD21940", Offset = "0xD20540", VA = "0x180D21940")]
		public UIBattleLoading()
		{
		}

		// Token: 0x04018970 RID: 100720
		[Token(Token = "0x4018970")]
		private const string DEFAULT_LOADING_PIC = "default";

		// Token: 0x04018971 RID: 100721
		[Token(Token = "0x4018971")]
		private const int DOT_CNT = 3;

		// Token: 0x04018972 RID: 100722
		[Token(Token = "0x4018972")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Time")]
		private float _fadeTime;

		// Token: 0x04018973 RID: 100723
		[Token(Token = "0x4018973")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Group("Time")]
		private float _loadingDotTime;

		// Token: 0x04018974 RID: 100724
		[Token(Token = "0x4018974")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _loadingLabel;

		// Token: 0x04018975 RID: 100725
		[Token(Token = "0x4018975")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x04018976 RID: 100726
		[Token(Token = "0x4018976")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _backgroundCover;

		// Token: 0x04018977 RID: 100727
		[Token(Token = "0x4018977")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIStageInfo _stageInfo;

		// Token: 0x04018978 RID: 100728
		[Token(Token = "0x4018978")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UITipsHolderForBattle _tipsHolder;

		// Token: 0x04018979 RID: 100729
		[Token(Token = "0x4018979")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _decorContainer;

		// Token: 0x0401897A RID: 100730
		[Token(Token = "0x401897A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelOriginDecors;

		// Token: 0x0401897B RID: 100731
		[Token(Token = "0x401897B")]
		[FieldOffset(Offset = "0x58")]
		private float m_accumTime;

		// Token: 0x0401897C RID: 100732
		[Token(Token = "0x401897C")]
		[FieldOffset(Offset = "0x60")]
		private UIBattleLoadingDecor m_decor;

		// Token: 0x0401897D RID: 100733
		[Token(Token = "0x401897D")]
		[FieldOffset(Offset = "0x68")]
		private DirectAssetLoader m_assetLoader;

		// Token: 0x0401897E RID: 100734
		[Token(Token = "0x401897E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401897F RID: 100735
		[Token(Token = "0x401897F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadLoadingDecor;

		// Token: 0x04018980 RID: 100736
		[Token(Token = "0x4018980")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartSwitchScene;

		// Token: 0x04018981 RID: 100737
		[Token(Token = "0x4018981")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018982 RID: 100738
		[Token(Token = "0x4018982")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018983 RID: 100739
		[Token(Token = "0x4018983")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
