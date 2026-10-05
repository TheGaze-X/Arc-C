using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007613 RID: 30227
	[Token(Token = "0x2007613")]
	public class Act24sideStageMapPreviewPluginView : StageMapPreviewPluginView
	{
		// Token: 0x0602A8DF RID: 174303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8DF")]
		[Address(RVA = "0x2661260", Offset = "0x265FE60", VA = "0x182661260", Slot = "4")]
		public override void Show(string actId, StageData stageData, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0602A8E0 RID: 174304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8E0")]
		[Address(RVA = "0x2661190", Offset = "0x265FD90", VA = "0x182661190", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0602A8E1 RID: 174305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8E1")]
		[Address(RVA = "0x2661BC0", Offset = "0x26607C0", VA = "0x182661BC0")]
		private void _RenderSinglePreview()
		{
		}

		// Token: 0x0602A8E2 RID: 174306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8E2")]
		[Address(RVA = "0x2661A20", Offset = "0x2660620", VA = "0x182661A20")]
		private void _RenderMultiplePreview(List<string> previewList)
		{
		}

		// Token: 0x0602A8E3 RID: 174307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8E3")]
		[Address(RVA = "0x26616A0", Offset = "0x26602A0", VA = "0x1826616A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A8E4 RID: 174308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8E4")]
		[Address(RVA = "0x2661960", Offset = "0x2660560", VA = "0x182661960")]
		private void _OnPageIndexUpdate(int currentIdx)
		{
		}

		// Token: 0x0602A8E5 RID: 174309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8E5")]
		[Address(RVA = "0x26611F0", Offset = "0x265FDF0", VA = "0x1826611F0")]
		public void Hide()
		{
		}

		// Token: 0x0602A8E6 RID: 174310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A8E6")]
		[Address(RVA = "0x2661CE0", Offset = "0x26608E0", VA = "0x182661CE0")]
		public Act24sideStageMapPreviewPluginView()
		{
		}

		// Token: 0x0403D439 RID: 250937
		[Token(Token = "0x403D439")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _previewPartToggle;

		// Token: 0x0403D43A RID: 250938
		[Token(Token = "0x403D43A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Single")]
		private Act24sideStageMapPreviewItemView _previewItemPrefab;

		// Token: 0x0403D43B RID: 250939
		[Token(Token = "0x403D43B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Single")]
		private RectTransform _singlePreviewParent;

		// Token: 0x0403D43C RID: 250940
		[Token(Token = "0x403D43C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Multiple")]
		private UIBlurFloatPanel _blurPanel;

		// Token: 0x0403D43D RID: 250941
		[Token(Token = "0x403D43D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Multiple")]
		private SimpleLayoutContent _previewList;

		// Token: 0x0403D43E RID: 250942
		[Token(Token = "0x403D43E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Multiple")]
		private ScrollViewPager _scrollPager;

		// Token: 0x0403D43F RID: 250943
		[Token(Token = "0x403D43F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Multiple")]
		private Text _textCurrent;

		// Token: 0x0403D440 RID: 250944
		[Token(Token = "0x403D440")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Multiple")]
		private Text _textTotal;

		// Token: 0x0403D441 RID: 250945
		[Token(Token = "0x403D441")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform[] _btnBackRtList;

		// Token: 0x0403D442 RID: 250946
		[Token(Token = "0x403D442")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403D443 RID: 250947
		[Token(Token = "0x403D443")]
		[FieldOffset(Offset = "0x68")]
		private Act24sideStageMapPreviewPluginView.PreviewListAdapter m_previewListAdapter;

		// Token: 0x0403D444 RID: 250948
		[Token(Token = "0x403D444")]
		[FieldOffset(Offset = "0x70")]
		private Act24sideStageMapPreviewItemView m_singlePreviewItem;

		// Token: 0x0403D445 RID: 250949
		[Token(Token = "0x403D445")]
		[FieldOffset(Offset = "0x78")]
		private StageData m_stageData;

		// Token: 0x0403D446 RID: 250950
		[Token(Token = "0x403D446")]
		[FieldOffset(Offset = "0x80")]
		private Act24SideData m_actData;

		// Token: 0x0403D447 RID: 250951
		[Token(Token = "0x403D447")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403D448 RID: 250952
		[Token(Token = "0x403D448")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0403D449 RID: 250953
		[Token(Token = "0x403D449")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderSinglePreview;

		// Token: 0x0403D44A RID: 250954
		[Token(Token = "0x403D44A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderMultiplePreview;

		// Token: 0x0403D44B RID: 250955
		[Token(Token = "0x403D44B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D44C RID: 250956
		[Token(Token = "0x403D44C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPageIndexUpdate;

		// Token: 0x0403D44D RID: 250957
		[Token(Token = "0x403D44D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403D44E RID: 250958
		[Token(Token = "0x403D44E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007614 RID: 30228
		[Token(Token = "0x2007614")]
		private class PreviewListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700641F RID: 25631
			// (get) Token: 0x0602A8E7 RID: 174311 RVA: 0x000D8F78 File Offset: 0x000D7178
			[Token(Token = "0x1700641F")]
			public override int count
			{
				[Token(Token = "0x602A8E7")]
				[Address(RVA = "0x26651C0", Offset = "0x2663DC0", VA = "0x1826651C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17006420 RID: 25632
			// (get) Token: 0x0602A8E8 RID: 174312 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0602A8E9 RID: 174313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006420")]
			public List<string> previewList
			{
				[Token(Token = "0x602A8E8")]
				[Address(RVA = "0x2665280", Offset = "0x2663E80", VA = "0x182665280")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x602A8E9")]
				[Address(RVA = "0x26652E0", Offset = "0x2663EE0", VA = "0x1826652E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0602A8EA RID: 174314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A8EA")]
			[Address(RVA = "0x2664F80", Offset = "0x2663B80", VA = "0x182664F80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602A8EB RID: 174315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A8EB")]
			[Address(RVA = "0x2665160", Offset = "0x2663D60", VA = "0x182665160")]
			public PreviewListAdapter()
			{
			}

			// Token: 0x0403D450 RID: 250960
			[Token(Token = "0x403D450")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D451 RID: 250961
			[Token(Token = "0x403D451")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_previewList;

			// Token: 0x0403D452 RID: 250962
			[Token(Token = "0x403D452")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_previewList;

			// Token: 0x0403D453 RID: 250963
			[Token(Token = "0x403D453")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403D454 RID: 250964
			[Token(Token = "0x403D454")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
