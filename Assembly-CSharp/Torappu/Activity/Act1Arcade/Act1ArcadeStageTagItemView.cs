using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200799A RID: 31130
	[Token(Token = "0x200799A")]
	public class Act1ArcadeStageTagItemView : DataBinder<Act1ArcadeStageSelectProperty>
	{
		// Token: 0x1700666E RID: 26222
		// (get) Token: 0x0602BAC4 RID: 178884 RVA: 0x000DCD28 File Offset: 0x000DAF28
		[Token(Token = "0x1700666E")]
		private bool m_isSelecting
		{
			[Token(Token = "0x602BAC4")]
			[Address(RVA = "0x27A6D20", Offset = "0x27A5920", VA = "0x1827A6D20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602BAC5 RID: 178885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAC5")]
		[Address(RVA = "0x27A6880", Offset = "0x27A5480", VA = "0x1827A6880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BAC6 RID: 178886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAC6")]
		[Address(RVA = "0x27A6180", Offset = "0x27A4D80", VA = "0x1827A6180")]
		public void InitView(Act1ArcadeSingleStageModel stageModel, bool isDefaultSelect)
		{
		}

		// Token: 0x0602BAC7 RID: 178887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAC7")]
		[Address(RVA = "0x27A67B0", Offset = "0x27A53B0", VA = "0x1827A67B0")]
		private void _InitAnim(UIAnimationLocation animationLocation, bool sampleAtBegin)
		{
		}

		// Token: 0x0602BAC8 RID: 178888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAC8")]
		[Address(RVA = "0x27A6300", Offset = "0x27A4F00", VA = "0x1827A6300", Slot = "7")]
		public override void OnValueChanged(Act1ArcadeStageSelectProperty property)
		{
		}

		// Token: 0x0602BAC9 RID: 178889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAC9")]
		[Address(RVA = "0x27A6AF0", Offset = "0x27A56F0", VA = "0x1827A6AF0")]
		private void _PlaySelectAnim(UIAnimationTween.Builder animBuilder, bool isSelecting)
		{
		}

		// Token: 0x0602BACA RID: 178890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BACA")]
		[Address(RVA = "0x27A6050", Offset = "0x27A4C50", VA = "0x1827A6050")]
		public void EventOnStageTagItemClicked()
		{
		}

		// Token: 0x0602BACB RID: 178891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BACB")]
		[Address(RVA = "0x27A6C60", Offset = "0x27A5860", VA = "0x1827A6C60")]
		public Act1ArcadeStageTagItemView()
		{
		}

		// Token: 0x0403F2EC RID: 258796
		[Token(Token = "0x403F2EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0403F2ED RID: 258797
		[Token(Token = "0x403F2ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNoInfo;

		// Token: 0x0403F2EE RID: 258798
		[Token(Token = "0x403F2EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403F2EF RID: 258799
		[Token(Token = "0x403F2EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgRank;

		// Token: 0x0403F2F0 RID: 258800
		[Token(Token = "0x403F2F0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animNormal;

		// Token: 0x0403F2F1 RID: 258801
		[Token(Token = "0x403F2F1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animNoInfo;

		// Token: 0x0403F2F2 RID: 258802
		[Token(Token = "0x403F2F2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403F2F3 RID: 258803
		[Token(Token = "0x403F2F3")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x0403F2F4 RID: 258804
		[Token(Token = "0x403F2F4")]
		[FieldOffset(Offset = "0x70")]
		private UIAnimationTween m_animTween;

		// Token: 0x0403F2F5 RID: 258805
		[Token(Token = "0x403F2F5")]
		[FieldOffset(Offset = "0x78")]
		private UIAnimationTween.Builder m_animNormalBuilder;

		// Token: 0x0403F2F6 RID: 258806
		[Token(Token = "0x403F2F6")]
		[FieldOffset(Offset = "0xA0")]
		private UIAnimationTween.Builder m_animNoInfoBuilder;

		// Token: 0x0403F2F7 RID: 258807
		[Token(Token = "0x403F2F7")]
		[FieldOffset(Offset = "0xC8")]
		private Act1ArcadeStageSelectViewModel m_stageSelectViewModel;

		// Token: 0x0403F2F8 RID: 258808
		[Token(Token = "0x403F2F8")]
		[FieldOffset(Offset = "0xD0")]
		private Act1ArcadeSingleStageModel m_stageModel;

		// Token: 0x0403F2F9 RID: 258809
		[Token(Token = "0x403F2F9")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isPrefSelecting;

		// Token: 0x0403F2FA RID: 258810
		[Token(Token = "0x403F2FA")]
		[FieldOffset(Offset = "0xE0")]
		private UIStateFinder m_finder;

		// Token: 0x0403F2FB RID: 258811
		[Token(Token = "0x403F2FB")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F2FC RID: 258812
		[Token(Token = "0x403F2FC")]
		[FieldOffset(Offset = "0x100")]
		private bool m_isInited;

		// Token: 0x0403F2FD RID: 258813
		[Token(Token = "0x403F2FD")]
		[FieldOffset(Offset = "0x108")]
		private Act1ArcadeStageTagItemView.StageTrackPointModel.UpdateParam m_trackPointParam;

		// Token: 0x0403F2FE RID: 258814
		[Token(Token = "0x403F2FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_isSelecting;

		// Token: 0x0403F2FF RID: 258815
		[Token(Token = "0x403F2FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F300 RID: 258816
		[Token(Token = "0x403F300")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0403F301 RID: 258817
		[Token(Token = "0x403F301")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitAnim;

		// Token: 0x0403F302 RID: 258818
		[Token(Token = "0x403F302")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F303 RID: 258819
		[Token(Token = "0x403F303")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlaySelectAnim;

		// Token: 0x0403F304 RID: 258820
		[Token(Token = "0x403F304")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnStageTagItemClicked;

		// Token: 0x0403F305 RID: 258821
		[Token(Token = "0x403F305")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200799B RID: 31131
		[Token(Token = "0x200799B")]
		private class StageTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x1700666F RID: 26223
			// (get) Token: 0x0602BACC RID: 178892 RVA: 0x000DCD40 File Offset: 0x000DAF40
			// (set) Token: 0x0602BACD RID: 178893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700666F")]
			public bool isShow
			{
				[Token(Token = "0x602BACC")]
				[Address(RVA = "0x27A98D0", Offset = "0x27A84D0", VA = "0x1827A98D0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602BACD")]
				[Address(RVA = "0x27A9930", Offset = "0x27A8530", VA = "0x1827A9930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602BACE RID: 178894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BACE")]
			[Address(RVA = "0x27A9740", Offset = "0x27A8340", VA = "0x1827A9740", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x0602BACF RID: 178895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BACF")]
			[Address(RVA = "0x27A9870", Offset = "0x27A8470", VA = "0x1827A9870")]
			public StageTrackPointModel()
			{
			}

			// Token: 0x0403F307 RID: 258823
			[Token(Token = "0x403F307")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x0403F308 RID: 258824
			[Token(Token = "0x403F308")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403F309 RID: 258825
			[Token(Token = "0x403F309")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x0403F30A RID: 258826
			[Token(Token = "0x403F30A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200799C RID: 31132
			[Token(Token = "0x200799C")]
			public class UpdateParam
			{
				// Token: 0x0602BAD0 RID: 178896 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602BAD0")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UpdateParam()
				{
				}

				// Token: 0x0403F30B RID: 258827
				[Token(Token = "0x403F30B")]
				[FieldOffset(Offset = "0x10")]
				public string actId;

				// Token: 0x0403F30C RID: 258828
				[Token(Token = "0x403F30C")]
				[FieldOffset(Offset = "0x18")]
				public string stageId;
			}
		}
	}
}
