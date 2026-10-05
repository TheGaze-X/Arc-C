using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004222 RID: 16930
	[Token(Token = "0x2004222")]
	public class SandboxV2OtherTrackerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A1DC RID: 106972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1DC")]
		[Address(RVA = "0x130A790", Offset = "0x1309390", VA = "0x18130A790")]
		public void Render(string topicId, SandboxV2OtherTrackerItemViewModel viewModel, bool isSelected, int enterSeq)
		{
		}

		// Token: 0x0601A1DD RID: 106973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1DD")]
		[Address(RVA = "0x130AD20", Offset = "0x1309920", VA = "0x18130AD20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1DE RID: 106974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1DE")]
		[Address(RVA = "0x130A6A0", Offset = "0x13092A0", VA = "0x18130A6A0")]
		public void OnClick()
		{
		}

		// Token: 0x0601A1DF RID: 106975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1DF")]
		[Address(RVA = "0x130AF30", Offset = "0x1309B30", VA = "0x18130AF30")]
		public SandboxV2OtherTrackerItemView()
		{
		}

		// Token: 0x04020F38 RID: 134968
		[Token(Token = "0x4020F38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04020F39 RID: 134969
		[Token(Token = "0x4020F39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04020F3A RID: 134970
		[Token(Token = "0x4020F3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgHp;

		// Token: 0x04020F3B RID: 134971
		[Token(Token = "0x4020F3B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgShadow;

		// Token: 0x04020F3C RID: 134972
		[Token(Token = "0x4020F3C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _badgeDeco;

		// Token: 0x04020F3D RID: 134973
		[Token(Token = "0x4020F3D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgOutline1;

		// Token: 0x04020F3E RID: 134974
		[Token(Token = "0x4020F3E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgOutline2;

		// Token: 0x04020F3F RID: 134975
		[Token(Token = "0x4020F3F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04020F40 RID: 134976
		[Token(Token = "0x4020F40")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x04020F41 RID: 134977
		[Token(Token = "0x4020F41")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _unselectedColor;

		// Token: 0x04020F42 RID: 134978
		[Token(Token = "0x4020F42")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIColorGraphic _selectOutline;

		// Token: 0x04020F43 RID: 134979
		[Token(Token = "0x4020F43")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04020F44 RID: 134980
		[Token(Token = "0x4020F44")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x04020F45 RID: 134981
		[Token(Token = "0x4020F45")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04020F46 RID: 134982
		[Token(Token = "0x4020F46")]
		[FieldOffset(Offset = "0xA4")]
		private int m_cachedEnterSeq;

		// Token: 0x04020F47 RID: 134983
		[Token(Token = "0x4020F47")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedFloatId;

		// Token: 0x04020F48 RID: 134984
		[Token(Token = "0x4020F48")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020F49 RID: 134985
		[Token(Token = "0x4020F49")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020F4A RID: 134986
		[Token(Token = "0x4020F4A")]
		[FieldOffset(Offset = "0xD0")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04020F4B RID: 134987
		[Token(Token = "0x4020F4B")]
		[FieldOffset(Offset = "0xD8")]
		private SandboxV2DungeonViewConfig m_cachedDungeonViewConfig;

		// Token: 0x04020F4C RID: 134988
		[Token(Token = "0x4020F4C")]
		[FieldOffset(Offset = "0xE0")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x04020F4D RID: 134989
		[Token(Token = "0x4020F4D")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_loopTween;

		// Token: 0x04020F4E RID: 134990
		[Token(Token = "0x4020F4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020F4F RID: 134991
		[Token(Token = "0x4020F4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F50 RID: 134992
		[Token(Token = "0x4020F50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04020F51 RID: 134993
		[Token(Token = "0x4020F51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
