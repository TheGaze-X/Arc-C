using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004225 RID: 16933
	[Token(Token = "0x2004225")]
	public class SandboxV2QuestTrackerItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A1E6 RID: 106982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1E6")]
		[Address(RVA = "0x130CA80", Offset = "0x130B680", VA = "0x18130CA80")]
		public void Render(string topicId, SandboxV2QuestTrackerItemViewModel viewModel, bool isSelected, int enterSeq)
		{
		}

		// Token: 0x0601A1E7 RID: 106983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1E7")]
		[Address(RVA = "0x130D090", Offset = "0x130BC90", VA = "0x18130D090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1E8 RID: 106984 RVA: 0x000A04B8 File Offset: 0x0009E6B8
		[Token(Token = "0x601A1E8")]
		[Address(RVA = "0x130CE40", Offset = "0x130BA40", VA = "0x18130CE40")]
		private float _GetTextHeight(Text text, string content)
		{
			return 0f;
		}

		// Token: 0x0601A1E9 RID: 106985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1E9")]
		[Address(RVA = "0x130C990", Offset = "0x130B590", VA = "0x18130C990")]
		public void OnClick()
		{
		}

		// Token: 0x0601A1EA RID: 106986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1EA")]
		[Address(RVA = "0x130D340", Offset = "0x130BF40", VA = "0x18130D340")]
		public SandboxV2QuestTrackerItemView()
		{
		}

		// Token: 0x04020F5E RID: 135006
		[Token(Token = "0x4020F5E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _badgeIcon;

		// Token: 0x04020F5F RID: 135007
		[Token(Token = "0x4020F5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _title;

		// Token: 0x04020F60 RID: 135008
		[Token(Token = "0x4020F60")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04020F61 RID: 135009
		[Token(Token = "0x4020F61")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _targetDesc;

		// Token: 0x04020F62 RID: 135010
		[Token(Token = "0x4020F62")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x04020F63 RID: 135011
		[Token(Token = "0x4020F63")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _foldHeight;

		// Token: 0x04020F64 RID: 135012
		[Token(Token = "0x4020F64")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _expandDuration;

		// Token: 0x04020F65 RID: 135013
		[Token(Token = "0x4020F65")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _expandPadding;

		// Token: 0x04020F66 RID: 135014
		[Token(Token = "0x4020F66")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelGo;

		// Token: 0x04020F67 RID: 135015
		[Token(Token = "0x4020F67")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelSwitch;

		// Token: 0x04020F68 RID: 135016
		[Token(Token = "0x4020F68")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelGoOrSwitch;

		// Token: 0x04020F69 RID: 135017
		[Token(Token = "0x4020F69")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x04020F6A RID: 135018
		[Token(Token = "0x4020F6A")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x04020F6B RID: 135019
		[Token(Token = "0x4020F6B")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedQuestId;

		// Token: 0x04020F6C RID: 135020
		[Token(Token = "0x4020F6C")]
		[FieldOffset(Offset = "0x88")]
		private int m_cachedEnterSeq;

		// Token: 0x04020F6D RID: 135021
		[Token(Token = "0x4020F6D")]
		[FieldOffset(Offset = "0x8C")]
		private float m_cachedExpandHeight;

		// Token: 0x04020F6E RID: 135022
		[Token(Token = "0x4020F6E")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04020F6F RID: 135023
		[Token(Token = "0x4020F6F")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04020F70 RID: 135024
		[Token(Token = "0x4020F70")]
		[FieldOffset(Offset = "0xB0")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04020F71 RID: 135025
		[Token(Token = "0x4020F71")]
		[FieldOffset(Offset = "0xB8")]
		private SandboxV2DungeonViewConfig m_cachedDungeonViewConfig;

		// Token: 0x04020F72 RID: 135026
		[Token(Token = "0x4020F72")]
		[FieldOffset(Offset = "0xC0")]
		private AnimationSwitchTween m_selectAnimTween;

		// Token: 0x04020F73 RID: 135027
		[Token(Token = "0x4020F73")]
		[FieldOffset(Offset = "0xC8")]
		private SandboxV2QuestTrackerItemView.SelectTween m_selectTween;

		// Token: 0x04020F74 RID: 135028
		[Token(Token = "0x4020F74")]
		[FieldOffset(Offset = "0xD0")]
		private TextGenerator m_textGenerator;

		// Token: 0x04020F75 RID: 135029
		[Token(Token = "0x4020F75")]
		[FieldOffset(Offset = "0xD8")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x04020F76 RID: 135030
		[Token(Token = "0x4020F76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020F77 RID: 135031
		[Token(Token = "0x4020F77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F78 RID: 135032
		[Token(Token = "0x4020F78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetTextHeight;

		// Token: 0x04020F79 RID: 135033
		[Token(Token = "0x4020F79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04020F7A RID: 135034
		[Token(Token = "0x4020F7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004226 RID: 16934
		[Token(Token = "0x2004226")]
		private class SelectTween : UISwitchTween
		{
			// Token: 0x0601A1EB RID: 106987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A1EB")]
			[Address(RVA = "0x13122D0", Offset = "0x1310ED0", VA = "0x1813122D0")]
			public SelectTween(SandboxV2QuestTrackerItemView closure)
			{
			}

			// Token: 0x0601A1EC RID: 106988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A1EC")]
			[Address(RVA = "0x1311F10", Offset = "0x1310B10", VA = "0x181311F10", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601A1ED RID: 106989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A1ED")]
			[Address(RVA = "0x1311D00", Offset = "0x1310900", VA = "0x181311D00", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601A1EE RID: 106990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A1EE")]
			[Address(RVA = "0x1312120", Offset = "0x1310D20", VA = "0x181312120", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601A1F3 RID: 106995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A1F3")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04020F7B RID: 135035
			[Token(Token = "0x4020F7B")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2QuestTrackerItemView m_closure;

			// Token: 0x04020F7C RID: 135036
			[Token(Token = "0x4020F7C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020F7D RID: 135037
			[Token(Token = "0x4020F7D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04020F7E RID: 135038
			[Token(Token = "0x4020F7E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04020F7F RID: 135039
			[Token(Token = "0x4020F7F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
