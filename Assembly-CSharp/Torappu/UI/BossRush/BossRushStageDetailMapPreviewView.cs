using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x020061BC RID: 25020
	[Token(Token = "0x20061BC")]
	public class BossRushStageDetailMapPreviewView : DataBinder<BossRushStageDetailProperty>, IHotfixable
	{
		// Token: 0x17005533 RID: 21811
		// (get) Token: 0x060241AC RID: 147884 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060241AD RID: 147885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005533")]
		public Action<int> onMapItemClick
		{
			[Token(Token = "0x60241AC")]
			[Address(RVA = "0x1EC82F0", Offset = "0x1EC6EF0", VA = "0x181EC82F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60241AD")]
			[Address(RVA = "0x1EC8430", Offset = "0x1EC7030", VA = "0x181EC8430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005534 RID: 21812
		// (get) Token: 0x060241AE RID: 147886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060241AF RID: 147887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005534")]
		public Action onHideMapClick
		{
			[Token(Token = "0x60241AE")]
			[Address(RVA = "0x1EC8290", Offset = "0x1EC6E90", VA = "0x181EC8290")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60241AF")]
			[Address(RVA = "0x1EC83B0", Offset = "0x1EC6FB0", VA = "0x181EC83B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005535 RID: 21813
		// (get) Token: 0x060241B0 RID: 147888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060241B1 RID: 147889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005535")]
		public Action<bool> onShowMapPreviewPanelClick
		{
			[Token(Token = "0x60241B0")]
			[Address(RVA = "0x1EC8350", Offset = "0x1EC6F50", VA = "0x181EC8350")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60241B1")]
			[Address(RVA = "0x1EC84B0", Offset = "0x1EC70B0", VA = "0x181EC84B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060241B2 RID: 147890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241B2")]
		[Address(RVA = "0x1EC7A30", Offset = "0x1EC6630", VA = "0x181EC7A30")]
		public void OnHideMapBtnClick()
		{
		}

		// Token: 0x060241B3 RID: 147891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241B3")]
		[Address(RVA = "0x1EC7B40", Offset = "0x1EC6740", VA = "0x181EC7B40", Slot = "7")]
		public override void OnValueChanged(BossRushStageDetailProperty property)
		{
		}

		// Token: 0x060241B4 RID: 147892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241B4")]
		[Address(RVA = "0x1EC8110", Offset = "0x1EC6D10", VA = "0x181EC8110")]
		private void _RenderMapView(float value)
		{
		}

		// Token: 0x060241B5 RID: 147893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241B5")]
		[Address(RVA = "0x1EC7FE0", Offset = "0x1EC6BE0", VA = "0x181EC7FE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060241B6 RID: 147894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60241B6")]
		[Address(RVA = "0x1EC8220", Offset = "0x1EC6E20", VA = "0x181EC8220")]
		public BossRushStageDetailMapPreviewView()
		{
		}

		// Token: 0x040322F3 RID: 205555
		[Token(Token = "0x40322F3")]
		private const float SPACING_NORMAL = -113f;

		// Token: 0x040322F4 RID: 205556
		[Token(Token = "0x40322F4")]
		private const float SPACING_HIDE = -156f;

		// Token: 0x040322F5 RID: 205557
		[Token(Token = "0x40322F5")]
		private const float MAP_TWEEN_FADETIME = 0.4f;

		// Token: 0x040322F6 RID: 205558
		[Token(Token = "0x40322F6")]
		private const float MAP_HIDE_POSITION = -0.5f;

		// Token: 0x040322F7 RID: 205559
		[Token(Token = "0x40322F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _mapContent;

		// Token: 0x040322F8 RID: 205560
		[Token(Token = "0x40322F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HorizontalLayoutGroup _layoutGroup;

		// Token: 0x040322F9 RID: 205561
		[Token(Token = "0x40322F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _hideMapButton;

		// Token: 0x040322FA RID: 205562
		[Token(Token = "0x40322FA")]
		[FieldOffset(Offset = "0x38")]
		private BossRushStageDetailMapPreviewView.BossRushStageDetailMapCache m_cacheData;

		// Token: 0x040322FB RID: 205563
		[Token(Token = "0x40322FB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x040322FC RID: 205564
		[Token(Token = "0x40322FC")]
		[FieldOffset(Offset = "0x68")]
		private BossRushStageDetailMapPreviewView.Adapter m_adapter;

		// Token: 0x040322FD RID: 205565
		[Token(Token = "0x40322FD")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween.TweenWrapper m_tweenWrapper;

		// Token: 0x040322FE RID: 205566
		[Token(Token = "0x40322FE")]
		[FieldOffset(Offset = "0x78")]
		private float m_currPosition;

		// Token: 0x04032302 RID: 205570
		[Token(Token = "0x4032302")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onMapItemClick;

		// Token: 0x04032303 RID: 205571
		[Token(Token = "0x4032303")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onMapItemClick;

		// Token: 0x04032304 RID: 205572
		[Token(Token = "0x4032304")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onHideMapClick;

		// Token: 0x04032305 RID: 205573
		[Token(Token = "0x4032305")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onHideMapClick;

		// Token: 0x04032306 RID: 205574
		[Token(Token = "0x4032306")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onShowMapPreviewPanelClick;

		// Token: 0x04032307 RID: 205575
		[Token(Token = "0x4032307")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onShowMapPreviewPanelClick;

		// Token: 0x04032308 RID: 205576
		[Token(Token = "0x4032308")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnHideMapBtnClick;

		// Token: 0x04032309 RID: 205577
		[Token(Token = "0x4032309")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403230A RID: 205578
		[Token(Token = "0x403230A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderMapView;

		// Token: 0x0403230B RID: 205579
		[Token(Token = "0x403230B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403230C RID: 205580
		[Token(Token = "0x403230C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061BD RID: 25021
		[Token(Token = "0x20061BD")]
		public struct BossRushStageDetailMapCache
		{
			// Token: 0x0403230D RID: 205581
			[Token(Token = "0x403230D")]
			[FieldOffset(Offset = "0x0")]
			public string stageGroupId;

			// Token: 0x0403230E RID: 205582
			[Token(Token = "0x403230E")]
			[FieldOffset(Offset = "0x8")]
			public int waveCount;

			// Token: 0x0403230F RID: 205583
			[Token(Token = "0x403230F")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04032310 RID: 205584
			[Token(Token = "0x4032310")]
			[FieldOffset(Offset = "0x18")]
			public List<List<string>> bossIdList;

			// Token: 0x04032311 RID: 205585
			[Token(Token = "0x4032311")]
			[FieldOffset(Offset = "0x20")]
			public int currIndex;
		}

		// Token: 0x020061BE RID: 25022
		[Token(Token = "0x20061BE")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x060241B8 RID: 147896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60241B8")]
			[Address(RVA = "0x1EB4400", Offset = "0x1EB3000", VA = "0x181EB4400")]
			public Adapter(BossRushStageDetailMapPreviewView clousre)
			{
			}

			// Token: 0x17005536 RID: 21814
			// (get) Token: 0x060241B9 RID: 147897 RVA: 0x000C3240 File Offset: 0x000C1440
			[Token(Token = "0x17005536")]
			public override int count
			{
				[Token(Token = "0x60241B9")]
				[Address(RVA = "0x1EB4570", Offset = "0x1EB3170", VA = "0x181EB4570", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060241BA RID: 147898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60241BA")]
			[Address(RVA = "0x1EB3E60", Offset = "0x1EB2A60", VA = "0x181EB3E60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04032312 RID: 205586
			[Token(Token = "0x4032312")]
			[FieldOffset(Offset = "0x20")]
			private BossRushStageDetailMapPreviewView m_closure;

			// Token: 0x04032313 RID: 205587
			[Token(Token = "0x4032313")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04032314 RID: 205588
			[Token(Token = "0x4032314")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04032315 RID: 205589
			[Token(Token = "0x4032315")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
