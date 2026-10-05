using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200799D RID: 31133
	[Token(Token = "0x200799D")]
	public class Act1ArcadeStageZoneEntryItemView : DataBinder<Act1ArcadeStageSelectProperty>
	{
		// Token: 0x17006670 RID: 26224
		// (get) Token: 0x0602BAD1 RID: 178897 RVA: 0x000DCD58 File Offset: 0x000DAF58
		[Token(Token = "0x17006670")]
		private bool m_isSelecting
		{
			[Token(Token = "0x602BAD1")]
			[Address(RVA = "0x27A7970", Offset = "0x27A6570", VA = "0x1827A7970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BAD2 RID: 178898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAD2")]
		[Address(RVA = "0x27A7300", Offset = "0x27A5F00", VA = "0x1827A7300")]
		private void _InitIfNot(Act1ArcadeSingleZoneModel zoneModel)
		{
		}

		// Token: 0x0602BAD3 RID: 178899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAD3")]
		[Address(RVA = "0x27A6ED0", Offset = "0x27A5AD0", VA = "0x1827A6ED0")]
		public void InitView(Act1ArcadeSingleZoneModel zoneModel, bool isDefaultSelect)
		{
		}

		// Token: 0x0602BAD4 RID: 178900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAD4")]
		[Address(RVA = "0x27A7050", Offset = "0x27A5C50", VA = "0x1827A7050", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeStageSelectProperty property)
		{
		}

		// Token: 0x0602BAD5 RID: 178901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAD5")]
		[Address(RVA = "0x27A7640", Offset = "0x27A6240", VA = "0x1827A7640")]
		private void _PlaySelectAnim(UIAnimationTween.Builder animBuilder, bool isSelecting)
		{
		}

		// Token: 0x0602BAD6 RID: 178902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAD6")]
		[Address(RVA = "0x27A7590", Offset = "0x27A6190", VA = "0x1827A7590")]
		private IEnumerator _PlayItemSelectLightPartical()
		{
			return null;
		}

		// Token: 0x0602BAD7 RID: 178903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAD7")]
		[Address(RVA = "0x27A6DB0", Offset = "0x27A59B0", VA = "0x1827A6DB0")]
		public void EventOnZoneEntryItemClick()
		{
		}

		// Token: 0x0602BAD8 RID: 178904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAD8")]
		[Address(RVA = "0x27A78B0", Offset = "0x27A64B0", VA = "0x1827A78B0")]
		public Act1ArcadeStageZoneEntryItemView()
		{
		}

		// Token: 0x0403F30D RID: 258829
		[Token(Token = "0x403F30D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _zoneItemSelectAnim;

		// Token: 0x0403F30E RID: 258830
		[Token(Token = "0x403F30E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _zoneItemSelectLightAnim;

		// Token: 0x0403F30F RID: 258831
		[Token(Token = "0x403F30F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIParticle _zoneItemSelectLightPartical;

		// Token: 0x0403F310 RID: 258832
		[Token(Token = "0x403F310")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _itemStatusTog;

		// Token: 0x0403F311 RID: 258833
		[Token(Token = "0x403F311")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imgLock;

		// Token: 0x0403F312 RID: 258834
		[Token(Token = "0x403F312")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgNormal;

		// Token: 0x0403F313 RID: 258835
		[Token(Token = "0x403F313")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textUnlockDes;

		// Token: 0x0403F314 RID: 258836
		[Token(Token = "0x403F314")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403F315 RID: 258837
		[Token(Token = "0x403F315")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _zoneItemSelectParticalDelay;

		// Token: 0x0403F316 RID: 258838
		[Token(Token = "0x403F316")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0403F317 RID: 258839
		[Token(Token = "0x403F317")]
		[FieldOffset(Offset = "0x80")]
		private UIAnimationTween m_zoneItemSelectTween;

		// Token: 0x0403F318 RID: 258840
		[Token(Token = "0x403F318")]
		[FieldOffset(Offset = "0x88")]
		private UIAnimationTween.Builder m_animBuilder;

		// Token: 0x0403F319 RID: 258841
		[Token(Token = "0x403F319")]
		[FieldOffset(Offset = "0xB0")]
		private Act1ArcadeStageSelectViewModel m_stageSelectModel;

		// Token: 0x0403F31A RID: 258842
		[Token(Token = "0x403F31A")]
		[FieldOffset(Offset = "0xB8")]
		private Act1ArcadeSingleZoneModel m_zoneModel;

		// Token: 0x0403F31B RID: 258843
		[Token(Token = "0x403F31B")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isPrefSelecting;

		// Token: 0x0403F31C RID: 258844
		[Token(Token = "0x403F31C")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_finder;

		// Token: 0x0403F31D RID: 258845
		[Token(Token = "0x403F31D")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F31E RID: 258846
		[Token(Token = "0x403F31E")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x0403F31F RID: 258847
		[Token(Token = "0x403F31F")]
		[FieldOffset(Offset = "0xF0")]
		private Act1ArcadeStageZoneEntryItemView.ZoneTrackPointModel.UpdateParam m_trackPointParam;

		// Token: 0x0403F320 RID: 258848
		[Token(Token = "0x403F320")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_isSelecting;

		// Token: 0x0403F321 RID: 258849
		[Token(Token = "0x403F321")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F322 RID: 258850
		[Token(Token = "0x403F322")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0403F323 RID: 258851
		[Token(Token = "0x403F323")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F324 RID: 258852
		[Token(Token = "0x403F324")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySelectAnim;

		// Token: 0x0403F325 RID: 258853
		[Token(Token = "0x403F325")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayItemSelectLightPartical;

		// Token: 0x0403F326 RID: 258854
		[Token(Token = "0x403F326")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnZoneEntryItemClick;

		// Token: 0x0403F327 RID: 258855
		[Token(Token = "0x403F327")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200799E RID: 31134
		[Token(Token = "0x200799E")]
		private class ZoneTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x17006671 RID: 26225
			// (get) Token: 0x0602BAD9 RID: 178905 RVA: 0x000DCD70 File Offset: 0x000DAF70
			// (set) Token: 0x0602BADA RID: 178906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17006671")]
			public bool isShow
			{
				[Token(Token = "0x602BAD9")]
				[Address(RVA = "0x27AAAC0", Offset = "0x27A96C0", VA = "0x1827AAAC0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602BADA")]
				[Address(RVA = "0x27AAB20", Offset = "0x27A9720", VA = "0x1827AAB20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602BADB RID: 178907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BADB")]
			[Address(RVA = "0x27AA930", Offset = "0x27A9530", VA = "0x1827AA930", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602BADC RID: 178908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BADC")]
			[Address(RVA = "0x27AAA60", Offset = "0x27A9660", VA = "0x1827AAA60")]
			public ZoneTrackPointModel()
			{
			}

			// Token: 0x0403F329 RID: 258857
			[Token(Token = "0x403F329")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403F32A RID: 258858
			[Token(Token = "0x403F32A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403F32B RID: 258859
			[Token(Token = "0x403F32B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403F32C RID: 258860
			[Token(Token = "0x403F32C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200799F RID: 31135
			[Token(Token = "0x200799F")]
			public class UpdateParam
			{
				// Token: 0x0602BADD RID: 178909 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602BADD")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UpdateParam()
				{
				}

				// Token: 0x0403F32D RID: 258861
				[Token(Token = "0x403F32D")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0403F32E RID: 258862
				[Token(Token = "0x403F32E")]
				[FieldOffset(Offset = "0x18")]
				public string zoneId;
			}
		}
	}
}
