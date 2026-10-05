using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004396 RID: 17302
	[Token(Token = "0x2004396")]
	public class SandboxV2RiftTeamSelectView : DataBinder<SandboxV2RiftTeamSelectProperty>
	{
		// Token: 0x0601A908 RID: 108808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A908")]
		[Address(RVA = "0x13B9DB0", Offset = "0x13B89B0", VA = "0x1813B9DB0", Slot = "7")]
		public override void OnValueChanged(SandboxV2RiftTeamSelectProperty property)
		{
		}

		// Token: 0x0601A909 RID: 108809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A909")]
		[Address(RVA = "0x13BA1C0", Offset = "0x13B8DC0", VA = "0x1813BA1C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A90A RID: 108810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A90A")]
		[Address(RVA = "0x13BA620", Offset = "0x13B9220", VA = "0x1813BA620")]
		private void _RenderBgPart()
		{
		}

		// Token: 0x0601A90B RID: 108811 RVA: 0x000A25D0 File Offset: 0x000A07D0
		[Token(Token = "0x601A90B")]
		[Address(RVA = "0x13BA090", Offset = "0x13B8C90", VA = "0x1813BA090")]
		private bool _HasBgChanged()
		{
			return default(bool);
		}

		// Token: 0x0601A90C RID: 108812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A90C")]
		[Address(RVA = "0x13BA9C0", Offset = "0x13B95C0", VA = "0x1813BA9C0")]
		private void _RenderTitlePart()
		{
		}

		// Token: 0x0601A90D RID: 108813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A90D")]
		[Address(RVA = "0x13BA800", Offset = "0x13B9400", VA = "0x1813BA800")]
		private void _RenderDescPart()
		{
		}

		// Token: 0x0601A90E RID: 108814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A90E")]
		[Address(RVA = "0x13B9D20", Offset = "0x13B8920", VA = "0x1813B9D20")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0601A90F RID: 108815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A90F")]
		[Address(RVA = "0x13BAC50", Offset = "0x13B9850", VA = "0x1813BAC50")]
		public SandboxV2RiftTeamSelectView()
		{
		}

		// Token: 0x04021D4F RID: 138575
		[Token(Token = "0x4021D4F")]
		private const string NO_TEAM_LEVEL_TEXT = "0";

		// Token: 0x04021D50 RID: 138576
		[Token(Token = "0x4021D50")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Background")]
		private Image _background;

		// Token: 0x04021D51 RID: 138577
		[Token(Token = "0x4021D51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Background")]
		private CanvasGroup _backgroundCanvasGroup;

		// Token: 0x04021D52 RID: 138578
		[Token(Token = "0x4021D52")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Background")]
		private float _backgroundFadeTime;

		// Token: 0x04021D53 RID: 138579
		[Token(Token = "0x4021D53")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Title")]
		private Image _teamBigIcon;

		// Token: 0x04021D54 RID: 138580
		[Token(Token = "0x4021D54")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Title")]
		private Text _teamName;

		// Token: 0x04021D55 RID: 138581
		[Token(Token = "0x4021D55")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Title")]
		private GameObject _teamLevelObject;

		// Token: 0x04021D56 RID: 138582
		[Token(Token = "0x4021D56")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Title")]
		private Text _teamLevel;

		// Token: 0x04021D57 RID: 138583
		[Token(Token = "0x4021D57")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Title")]
		private Text _teamDesc;

		// Token: 0x04021D58 RID: 138584
		[Token(Token = "0x4021D58")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Buff Desc")]
		private TwoStateToggle _teamBuffDescToggle;

		// Token: 0x04021D59 RID: 138585
		[Token(Token = "0x4021D59")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Buff Desc")]
		private SimpleLayoutContent _teamBuffDescContent;

		// Token: 0x04021D5A RID: 138586
		[Token(Token = "0x4021D5A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Buff Desc")]
		private GameObject _teamBuffDescTipObject;

		// Token: 0x04021D5B RID: 138587
		[Token(Token = "0x4021D5B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Buff Desc")]
		private CanvasGroup _teamBuffDescCanvasGroup;

		// Token: 0x04021D5C RID: 138588
		[Token(Token = "0x4021D5C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Buff Desc")]
		private float _teamBuffDescFadeTime;

		// Token: 0x04021D5D RID: 138589
		[Token(Token = "0x4021D5D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _teamButtonContent;

		// Token: 0x04021D5E RID: 138590
		[Token(Token = "0x4021D5E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _backPressArea;

		// Token: 0x04021D5F RID: 138591
		[Token(Token = "0x4021D5F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _titleAnim;

		// Token: 0x04021D60 RID: 138592
		[Token(Token = "0x4021D60")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x04021D61 RID: 138593
		[Token(Token = "0x4021D61")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2RiftTeamSelectViewModel m_cachedViewModel;

		// Token: 0x04021D62 RID: 138594
		[Token(Token = "0x4021D62")]
		[FieldOffset(Offset = "0xB8")]
		private List<string> m_cachedTeamDesc;

		// Token: 0x04021D63 RID: 138595
		[Token(Token = "0x4021D63")]
		[FieldOffset(Offset = "0xC0")]
		private SandboxV2RiftTeamSelectView.TeamDescAdapter m_teamDescAdapter;

		// Token: 0x04021D64 RID: 138596
		[Token(Token = "0x4021D64")]
		[FieldOffset(Offset = "0xC8")]
		private SandboxV2RiftTeamSelectView.TeamButtonAdapter m_teamButtonAdapter;

		// Token: 0x04021D65 RID: 138597
		[Token(Token = "0x4021D65")]
		[FieldOffset(Offset = "0xD0")]
		private UISwitchTween m_titleTween;

		// Token: 0x04021D66 RID: 138598
		[Token(Token = "0x4021D66")]
		[FieldOffset(Offset = "0xD8")]
		private UISwitchTween m_buffDescTween;

		// Token: 0x04021D67 RID: 138599
		[Token(Token = "0x4021D67")]
		[FieldOffset(Offset = "0xE0")]
		private UISwitchTween m_backgroundTween;

		// Token: 0x04021D68 RID: 138600
		[Token(Token = "0x4021D68")]
		[FieldOffset(Offset = "0xE8")]
		private string m_cachedBgId;

		// Token: 0x04021D69 RID: 138601
		[Token(Token = "0x4021D69")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04021D6A RID: 138602
		[Token(Token = "0x4021D6A")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04021D6B RID: 138603
		[Token(Token = "0x4021D6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021D6C RID: 138604
		[Token(Token = "0x4021D6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021D6D RID: 138605
		[Token(Token = "0x4021D6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBgPart;

		// Token: 0x04021D6E RID: 138606
		[Token(Token = "0x4021D6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HasBgChanged;

		// Token: 0x04021D6F RID: 138607
		[Token(Token = "0x4021D6F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTitlePart;

		// Token: 0x04021D70 RID: 138608
		[Token(Token = "0x4021D70")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderDescPart;

		// Token: 0x04021D71 RID: 138609
		[Token(Token = "0x4021D71")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04021D72 RID: 138610
		[Token(Token = "0x4021D72")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004397 RID: 17303
		[Token(Token = "0x2004397")]
		private class TeamDescAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A910 RID: 108816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A910")]
			[Address(RVA = "0x13BBED0", Offset = "0x13BAAD0", VA = "0x1813BBED0")]
			public TeamDescAdapter(SandboxV2RiftTeamSelectView closure)
			{
			}

			// Token: 0x17003EFB RID: 16123
			// (get) Token: 0x0601A911 RID: 108817 RVA: 0x000A25E8 File Offset: 0x000A07E8
			[Token(Token = "0x17003EFB")]
			public override int count
			{
				[Token(Token = "0x601A911")]
				[Address(RVA = "0x13BBF50", Offset = "0x13BAB50", VA = "0x1813BBF50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A912 RID: 108818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A912")]
			[Address(RVA = "0x13BBC30", Offset = "0x13BA830", VA = "0x1813BBC30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021D73 RID: 138611
			[Token(Token = "0x4021D73")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RiftTeamSelectView m_closure;

			// Token: 0x04021D74 RID: 138612
			[Token(Token = "0x4021D74")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021D75 RID: 138613
			[Token(Token = "0x4021D75")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021D76 RID: 138614
			[Token(Token = "0x4021D76")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004398 RID: 17304
		[Token(Token = "0x2004398")]
		private class TeamButtonAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A913 RID: 108819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A913")]
			[Address(RVA = "0x13BBB10", Offset = "0x13BA710", VA = "0x1813BBB10")]
			public TeamButtonAdapter(SandboxV2RiftTeamSelectView closure)
			{
			}

			// Token: 0x17003EFC RID: 16124
			// (get) Token: 0x0601A914 RID: 108820 RVA: 0x000A2600 File Offset: 0x000A0800
			[Token(Token = "0x17003EFC")]
			public override int count
			{
				[Token(Token = "0x601A914")]
				[Address(RVA = "0x13BBB90", Offset = "0x13BA790", VA = "0x1813BBB90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A915 RID: 108821 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A915")]
			[Address(RVA = "0x13BB8F0", Offset = "0x13BA4F0", VA = "0x1813BB8F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021D77 RID: 138615
			[Token(Token = "0x4021D77")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RiftTeamSelectView m_closure;

			// Token: 0x04021D78 RID: 138616
			[Token(Token = "0x4021D78")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021D79 RID: 138617
			[Token(Token = "0x4021D79")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021D7A RID: 138618
			[Token(Token = "0x4021D7A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
