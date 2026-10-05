using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F00 RID: 16128
	[Token(Token = "0x2003F00")]
	public class SiracusaMapStageStoryPreviewView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x17003BCF RID: 15311
		// (get) Token: 0x060190A2 RID: 102562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BCF")]
		private UISwitchTween previewFadeTween
		{
			[Token(Token = "0x60190A2")]
			[Address(RVA = "0x11C0CA0", Offset = "0x11BF8A0", VA = "0x1811C0CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BD0 RID: 15312
		// (get) Token: 0x060190A3 RID: 102563 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060190A4 RID: 102564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BD0")]
		public Action<SiracusaMapStageDetailInfoViewModel> eventPlayStory
		{
			[Token(Token = "0x60190A3")]
			[Address(RVA = "0x11C0C40", Offset = "0x11BF840", VA = "0x1811C0C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60190A4")]
			[Address(RVA = "0x11C0D80", Offset = "0x11BF980", VA = "0x1811C0D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060190A5 RID: 102565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190A5")]
		[Address(RVA = "0x11C0880", Offset = "0x11BF480", VA = "0x1811C0880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060190A6 RID: 102566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190A6")]
		[Address(RVA = "0x11C08F0", Offset = "0x11BF4F0", VA = "0x1811C08F0")]
		private void _Render(SiracusaMapStageDetailInfoViewModel stageModel)
		{
		}

		// Token: 0x060190A7 RID: 102567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190A7")]
		[Address(RVA = "0x11C06F0", Offset = "0x11BF2F0", VA = "0x1811C06F0", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x060190A8 RID: 102568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190A8")]
		[Address(RVA = "0x11C0620", Offset = "0x11BF220", VA = "0x1811C0620")]
		public void OnStartPlayStory()
		{
		}

		// Token: 0x060190A9 RID: 102569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190A9")]
		[Address(RVA = "0x11C0BD0", Offset = "0x11BF7D0", VA = "0x1811C0BD0")]
		public SiracusaMapStageStoryPreviewView()
		{
		}

		// Token: 0x0401EF65 RID: 126821
		[Token(Token = "0x401EF65")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtStageName;

		// Token: 0x0401EF66 RID: 126822
		[Token(Token = "0x401EF66")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtStageCode;

		// Token: 0x0401EF67 RID: 126823
		[Token(Token = "0x401EF67")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtAvgType;

		// Token: 0x0401EF68 RID: 126824
		[Token(Token = "0x401EF68")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtAvgDesc;

		// Token: 0x0401EF69 RID: 126825
		[Token(Token = "0x401EF69")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ScrollRect _scrollBriefAvgDesc;

		// Token: 0x0401EF6A RID: 126826
		[Token(Token = "0x401EF6A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _storyPreviewCanvasGroup;

		// Token: 0x0401EF6B RID: 126827
		[Token(Token = "0x401EF6B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401EF6C RID: 126828
		[Token(Token = "0x401EF6C")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedStoryId;

		// Token: 0x0401EF6D RID: 126829
		[Token(Token = "0x401EF6D")]
		[FieldOffset(Offset = "0x60")]
		private SiracusaMapStageDetailInfoViewModel m_cachedViewModel;

		// Token: 0x0401EF6E RID: 126830
		[Token(Token = "0x401EF6E")]
		[FieldOffset(Offset = "0x68")]
		private SiracusaMapStageDetailInfoViewModel m_sharedDetailInst;

		// Token: 0x0401EF6F RID: 126831
		[Token(Token = "0x401EF6F")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_previewFadeTween;

		// Token: 0x0401EF71 RID: 126833
		[Token(Token = "0x401EF71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_previewFadeTween;

		// Token: 0x0401EF72 RID: 126834
		[Token(Token = "0x401EF72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_eventPlayStory;

		// Token: 0x0401EF73 RID: 126835
		[Token(Token = "0x401EF73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_eventPlayStory;

		// Token: 0x0401EF74 RID: 126836
		[Token(Token = "0x401EF74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EF75 RID: 126837
		[Token(Token = "0x401EF75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401EF76 RID: 126838
		[Token(Token = "0x401EF76")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EF77 RID: 126839
		[Token(Token = "0x401EF77")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnStartPlayStory;

		// Token: 0x0401EF78 RID: 126840
		[Token(Token = "0x401EF78")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
