using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200421F RID: 16927
	[Token(Token = "0x200421F")]
	public class SandboxV2EnemyRushTrackerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A1D2 RID: 106962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D2")]
		[Address(RVA = "0x1303270", Offset = "0x1301E70", VA = "0x181303270")]
		public void Render(string topicId, SandboxV2TrackerEnemyRushViewModel viewModel, bool isSelected, int enterSeq)
		{
		}

		// Token: 0x0601A1D3 RID: 106963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D3")]
		[Address(RVA = "0x1303840", Offset = "0x1302440", VA = "0x181303840")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1D4 RID: 106964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D4")]
		[Address(RVA = "0x1303180", Offset = "0x1301D80", VA = "0x181303180")]
		public void OnClick()
		{
		}

		// Token: 0x0601A1D5 RID: 106965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D5")]
		[Address(RVA = "0x1303A50", Offset = "0x1302650", VA = "0x181303A50")]
		public SandboxV2EnemyRushTrackerItemView()
		{
		}

		// Token: 0x04020F12 RID: 134930
		[Token(Token = "0x4020F12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04020F13 RID: 134931
		[Token(Token = "0x4020F13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04020F14 RID: 134932
		[Token(Token = "0x4020F14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgHp;

		// Token: 0x04020F15 RID: 134933
		[Token(Token = "0x4020F15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgShadow;

		// Token: 0x04020F16 RID: 134934
		[Token(Token = "0x4020F16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bkgDeco;

		// Token: 0x04020F17 RID: 134935
		[Token(Token = "0x4020F17")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _badgeDeco;

		// Token: 0x04020F18 RID: 134936
		[Token(Token = "0x4020F18")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04020F19 RID: 134937
		[Token(Token = "0x4020F19")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _outline1;

		// Token: 0x04020F1A RID: 134938
		[Token(Token = "0x4020F1A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _outline2;

		// Token: 0x04020F1B RID: 134939
		[Token(Token = "0x4020F1B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIColorGraphic _selectOutline;

		// Token: 0x04020F1C RID: 134940
		[Token(Token = "0x4020F1C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04020F1D RID: 134941
		[Token(Token = "0x4020F1D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x04020F1E RID: 134942
		[Token(Token = "0x4020F1E")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04020F1F RID: 134943
		[Token(Token = "0x4020F1F")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedEnemeRushId;

		// Token: 0x04020F20 RID: 134944
		[Token(Token = "0x4020F20")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedEnterSeq;

		// Token: 0x04020F21 RID: 134945
		[Token(Token = "0x4020F21")]
		[FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020F22 RID: 134946
		[Token(Token = "0x4020F22")]
		[FieldOffset(Offset = "0xB0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020F23 RID: 134947
		[Token(Token = "0x4020F23")]
		[FieldOffset(Offset = "0xC0")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04020F24 RID: 134948
		[Token(Token = "0x4020F24")]
		[FieldOffset(Offset = "0xC8")]
		private SandboxV2DungeonViewConfig m_cachedDungeonViewConfig;

		// Token: 0x04020F25 RID: 134949
		[Token(Token = "0x4020F25")]
		[FieldOffset(Offset = "0xD0")]
		private AnimationSwitchTween m_selectTween;

		// Token: 0x04020F26 RID: 134950
		[Token(Token = "0x4020F26")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_loopTween;

		// Token: 0x04020F27 RID: 134951
		[Token(Token = "0x4020F27")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020F28 RID: 134952
		[Token(Token = "0x4020F28")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F29 RID: 134953
		[Token(Token = "0x4020F29")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04020F2A RID: 134954
		[Token(Token = "0x4020F2A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
