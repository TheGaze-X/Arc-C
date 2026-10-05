using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006695 RID: 26261
	[Token(Token = "0x2006695")]
	public class HandBookInfoStageDetailView : DataBinder<HandBookInfoStageProperty>
	{
		// Token: 0x06025B92 RID: 154514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B92")]
		[Address(RVA = "0x20A63B0", Offset = "0x20A4FB0", VA = "0x1820A63B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025B93 RID: 154515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B93")]
		[Address(RVA = "0x20A5970", Offset = "0x20A4570", VA = "0x1820A5970", Slot = "7")]
		public override void OnValueChanged(HandBookInfoStageProperty prop)
		{
		}

		// Token: 0x06025B94 RID: 154516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B94")]
		[Address(RVA = "0x20A60A0", Offset = "0x20A4CA0", VA = "0x1820A60A0")]
		public void OpenMapTips()
		{
		}

		// Token: 0x06025B95 RID: 154517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B95")]
		[Address(RVA = "0x20A5720", Offset = "0x20A4320", VA = "0x1820A5720")]
		public void CloseMapTips()
		{
		}

		// Token: 0x06025B96 RID: 154518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B96")]
		[Address(RVA = "0x20A6710", Offset = "0x20A5310", VA = "0x1820A6710")]
		private void _UnloadStagePreviewMap()
		{
		}

		// Token: 0x06025B97 RID: 154519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B97")]
		[Address(RVA = "0x20A64E0", Offset = "0x20A50E0", VA = "0x1820A64E0")]
		private void _LoadStagePreviewMap(string stageId)
		{
		}

		// Token: 0x06025B98 RID: 154520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B98")]
		[Address(RVA = "0x20A62A0", Offset = "0x20A4EA0", VA = "0x1820A62A0")]
		private void _ClearBlurSprite()
		{
		}

		// Token: 0x06025B99 RID: 154521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B99")]
		[Address(RVA = "0x20A66A0", Offset = "0x20A52A0", VA = "0x1820A66A0")]
		private void _ShotBlurredSprite()
		{
		}

		// Token: 0x06025B9A RID: 154522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B9A")]
		[Address(RVA = "0x20A58D0", Offset = "0x20A44D0", VA = "0x1820A58D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06025B9B RID: 154523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B9B")]
		[Address(RVA = "0x20A6820", Offset = "0x20A5420", VA = "0x1820A6820")]
		public HandBookInfoStageDetailView()
		{
		}

		// Token: 0x04034FF5 RID: 217077
		[Token(Token = "0x4034FF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _campImage;

		// Token: 0x04034FF6 RID: 217078
		[Token(Token = "0x4034FF6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x04034FF7 RID: 217079
		[Token(Token = "0x4034FF7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _charName;

		// Token: 0x04034FF8 RID: 217080
		[Token(Token = "0x4034FF8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _charEnglishName;

		// Token: 0x04034FF9 RID: 217081
		[Token(Token = "0x4034FF9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _title;

		// Token: 0x04034FFA RID: 217082
		[Token(Token = "0x4034FFA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _detail;

		// Token: 0x04034FFB RID: 217083
		[Token(Token = "0x4034FFB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _finishedToggle;

		// Token: 0x04034FFC RID: 217084
		[Token(Token = "0x4034FFC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _rewardToggle;

		// Token: 0x04034FFD RID: 217085
		[Token(Token = "0x4034FFD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _rewardCountText;

		// Token: 0x04034FFE RID: 217086
		[Token(Token = "0x4034FFE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imageMapPreview;

		// Token: 0x04034FFF RID: 217087
		[Token(Token = "0x4034FFF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imageMapTip;

		// Token: 0x04035000 RID: 217088
		[Token(Token = "0x4035000")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _mapPreview;

		// Token: 0x04035001 RID: 217089
		[Token(Token = "0x4035001")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _backTips;

		// Token: 0x04035002 RID: 217090
		[Token(Token = "0x4035002")]
		[FieldOffset(Offset = "0x88")]
		private Sprite m_stagePreviewMap;

		// Token: 0x04035003 RID: 217091
		[Token(Token = "0x4035003")]
		[FieldOffset(Offset = "0x90")]
		private DirectAssetLoader m_stagePreviewMapLoader;

		// Token: 0x04035004 RID: 217092
		[Token(Token = "0x4035004")]
		[FieldOffset(Offset = "0x98")]
		private UICharacterIllust m_illust;

		// Token: 0x04035005 RID: 217093
		[Token(Token = "0x4035005")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04035006 RID: 217094
		[Token(Token = "0x4035006")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_enterAnim;

		// Token: 0x04035007 RID: 217095
		[Token(Token = "0x4035007")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04035008 RID: 217096
		[Token(Token = "0x4035008")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035009 RID: 217097
		[Token(Token = "0x4035009")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403500A RID: 217098
		[Token(Token = "0x403500A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenMapTips;

		// Token: 0x0403500B RID: 217099
		[Token(Token = "0x403500B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CloseMapTips;

		// Token: 0x0403500C RID: 217100
		[Token(Token = "0x403500C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UnloadStagePreviewMap;

		// Token: 0x0403500D RID: 217101
		[Token(Token = "0x403500D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadStagePreviewMap;

		// Token: 0x0403500E RID: 217102
		[Token(Token = "0x403500E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearBlurSprite;

		// Token: 0x0403500F RID: 217103
		[Token(Token = "0x403500F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShotBlurredSprite;

		// Token: 0x04035010 RID: 217104
		[Token(Token = "0x4035010")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04035011 RID: 217105
		[Token(Token = "0x4035011")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
