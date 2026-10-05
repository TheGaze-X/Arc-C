using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FDD RID: 28637
	[Token(Token = "0x2006FDD")]
	public class ActMultiV3StageDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028AC5 RID: 166597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AC5")]
		[Address(RVA = "0x23FE640", Offset = "0x23FD240", VA = "0x1823FE640")]
		public void Render(ActMultiV3StageDetailViewModel viewModel, bool isStageDetailState = false)
		{
		}

		// Token: 0x06028AC6 RID: 166598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AC6")]
		[Address(RVA = "0x23FF1E0", Offset = "0x23FDDE0", VA = "0x1823FF1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028AC7 RID: 166599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AC7")]
		[Address(RVA = "0x23FEFE0", Offset = "0x23FDBE0", VA = "0x1823FEFE0")]
		private void _AdjustViewCount(int viewCnt)
		{
		}

		// Token: 0x06028AC8 RID: 166600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AC8")]
		[Address(RVA = "0x23FE400", Offset = "0x23FD000", VA = "0x1823FE400")]
		public Tween BuildInAnimTween(bool isInverse = false)
		{
			return null;
		}

		// Token: 0x06028AC9 RID: 166601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AC9")]
		[Address(RVA = "0x23FE520", Offset = "0x23FD120", VA = "0x1823FE520")]
		public Tween BuildOutAnimTween(bool isInverse = false)
		{
			return null;
		}

		// Token: 0x06028ACA RID: 166602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ACA")]
		[Address(RVA = "0x23FF490", Offset = "0x23FE090", VA = "0x1823FF490")]
		public ActMultiV3StageDetailView()
		{
		}

		// Token: 0x04039F35 RID: 237365
		[Token(Token = "0x4039F35")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActMultiV3StageDetailView.ModeConfig[] _modeConfigs;

		// Token: 0x04039F36 RID: 237366
		[Token(Token = "0x4039F36")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _stageCodeTxt;

		// Token: 0x04039F37 RID: 237367
		[Token(Token = "0x4039F37")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _modeNameCodeTxt;

		// Token: 0x04039F38 RID: 237368
		[Token(Token = "0x4039F38")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3DifficultyIconView _diffIconViewPrefab;

		// Token: 0x04039F39 RID: 237369
		[Token(Token = "0x4039F39")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _diffIconViewContainer;

		// Token: 0x04039F3A RID: 237370
		[Token(Token = "0x4039F3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _diffScale;

		// Token: 0x04039F3B RID: 237371
		[Token(Token = "0x4039F3B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _stageDetailTxt;

		// Token: 0x04039F3C RID: 237372
		[Token(Token = "0x4039F3C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3StageDetailViewGoalItem _goalItemPrefab;

		// Token: 0x04039F3D RID: 237373
		[Token(Token = "0x4039F3D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _goalItemContainer;

		// Token: 0x04039F3E RID: 237374
		[Token(Token = "0x4039F3E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text[] _recordScoreTexts;

		// Token: 0x04039F3F RID: 237375
		[Token(Token = "0x4039F3F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent[] _recordStarContents;

		// Token: 0x04039F40 RID: 237376
		[Token(Token = "0x4039F40")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _titleModeIconImg;

		// Token: 0x04039F41 RID: 237377
		[Token(Token = "0x4039F41")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _seasonIcon;

		// Token: 0x04039F42 RID: 237378
		[Token(Token = "0x4039F42")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _stageBigPreviewImg;

		// Token: 0x04039F43 RID: 237379
		[Token(Token = "0x4039F43")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pnlSeasonIcon;

		// Token: 0x04039F44 RID: 237380
		[Token(Token = "0x4039F44")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _inAnim;

		// Token: 0x04039F45 RID: 237381
		[Token(Token = "0x4039F45")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _outAnim;

		// Token: 0x04039F46 RID: 237382
		[Token(Token = "0x4039F46")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039F47 RID: 237383
		[Token(Token = "0x4039F47")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x04039F48 RID: 237384
		[Token(Token = "0x4039F48")]
		[FieldOffset(Offset = "0xC8")]
		private ActMultiV3DifficultyIconView m_diffIconView;

		// Token: 0x04039F49 RID: 237385
		[Token(Token = "0x4039F49")]
		[FieldOffset(Offset = "0xD0")]
		private ActMultiV3StageDetailViewModel m_viewModel;

		// Token: 0x04039F4A RID: 237386
		[Token(Token = "0x4039F4A")]
		[FieldOffset(Offset = "0xD8")]
		private List<ActMultiV3StageDetailView.StarAdapter> m_starAdapters;

		// Token: 0x04039F4B RID: 237387
		[Token(Token = "0x4039F4B")]
		[FieldOffset(Offset = "0xE0")]
		private string m_actId;

		// Token: 0x04039F4C RID: 237388
		[Token(Token = "0x4039F4C")]
		[FieldOffset(Offset = "0xE8")]
		private List<ActMultiV3StageDetailViewGoalItem> m_goalItems;

		// Token: 0x04039F4D RID: 237389
		[Token(Token = "0x4039F4D")]
		[FieldOffset(Offset = "0xF0")]
		private Sprite m_cacheGoalItemIconSprite;

		// Token: 0x04039F4E RID: 237390
		[Token(Token = "0x4039F4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039F4F RID: 237391
		[Token(Token = "0x4039F4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039F50 RID: 237392
		[Token(Token = "0x4039F50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AdjustViewCount;

		// Token: 0x04039F51 RID: 237393
		[Token(Token = "0x4039F51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BuildInAnimTween;

		// Token: 0x04039F52 RID: 237394
		[Token(Token = "0x4039F52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BuildOutAnimTween;

		// Token: 0x04039F53 RID: 237395
		[Token(Token = "0x4039F53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FDE RID: 28638
		[Token(Token = "0x2006FDE")]
		[Serializable]
		private class ModeConfig
		{
			// Token: 0x06028ACB RID: 166603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028ACB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ModeConfig()
			{
			}

			// Token: 0x04039F54 RID: 237396
			[Token(Token = "0x4039F54")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public ActMultiV3MapModeType _modeType;

			// Token: 0x04039F55 RID: 237397
			[Token(Token = "0x4039F55")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public GameObject _recordObj;

			// Token: 0x04039F56 RID: 237398
			[Token(Token = "0x4039F56")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public GameObject _noRecordObj;

			// Token: 0x04039F57 RID: 237399
			[Token(Token = "0x4039F57")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public GameObject _recordContentObj;

			// Token: 0x04039F58 RID: 237400
			[Token(Token = "0x4039F58")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public GameObject _exRecordNumObj;
		}

		// Token: 0x02006FDF RID: 28639
		[Token(Token = "0x2006FDF")]
		[Serializable]
		private class StarAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06028ACC RID: 166604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028ACC")]
			[Address(RVA = "0x2403A70", Offset = "0x2402670", VA = "0x182403A70")]
			public StarAdapter(ActMultiV3StageDetailView view)
			{
			}

			// Token: 0x17006005 RID: 24581
			// (get) Token: 0x06028ACD RID: 166605 RVA: 0x000D2A08 File Offset: 0x000D0C08
			[Token(Token = "0x17006005")]
			public override int count
			{
				[Token(Token = "0x6028ACD")]
				[Address(RVA = "0x2403AF0", Offset = "0x24026F0", VA = "0x182403AF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028ACE RID: 166606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028ACE")]
			[Address(RVA = "0x2403860", Offset = "0x2402460", VA = "0x182403860", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039F59 RID: 237401
			[Token(Token = "0x4039F59")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3StageDetailView m_view;

			// Token: 0x04039F5A RID: 237402
			[Token(Token = "0x4039F5A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039F5B RID: 237403
			[Token(Token = "0x4039F5B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039F5C RID: 237404
			[Token(Token = "0x4039F5C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
