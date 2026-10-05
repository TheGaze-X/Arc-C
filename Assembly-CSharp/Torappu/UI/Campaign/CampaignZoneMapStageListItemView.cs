using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200613D RID: 24893
	[Token(Token = "0x200613D")]
	public class CampaignZoneMapStageListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023EFE RID: 147198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EFE")]
		[Address(RVA = "0x1E954D0", Offset = "0x1E940D0", VA = "0x181E954D0")]
		public void Render(int position, CampaignZoneMapStageViewModel model, string selectedStage, bool isTrainingAllOpen)
		{
		}

		// Token: 0x06023EFF RID: 147199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EFF")]
		[Address(RVA = "0x1E953F0", Offset = "0x1E93FF0", VA = "0x181E953F0")]
		public void EventOnItemClicked()
		{
		}

		// Token: 0x06023F00 RID: 147200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F00")]
		[Address(RVA = "0x1E95BE0", Offset = "0x1E947E0", VA = "0x181E95BE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023F01 RID: 147201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F01")]
		[Address(RVA = "0x1E95D40", Offset = "0x1E94940", VA = "0x181E95D40")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x06023F02 RID: 147202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F02")]
		[Address(RVA = "0x1E95E00", Offset = "0x1E94A00", VA = "0x181E95E00")]
		public CampaignZoneMapStageListItemView()
		{
		}

		// Token: 0x04031E44 RID: 204356
		[Token(Token = "0x4031E44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x04031E45 RID: 204357
		[Token(Token = "0x4031E45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgNormal;

		// Token: 0x04031E46 RID: 204358
		[Token(Token = "0x4031E46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelClosed;

		// Token: 0x04031E47 RID: 204359
		[Token(Token = "0x4031E47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04031E48 RID: 204360
		[Token(Token = "0x4031E48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUnlockTip;

		// Token: 0x04031E49 RID: 204361
		[Token(Token = "0x4031E49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelSpecialOpen;

		// Token: 0x04031E4A RID: 204362
		[Token(Token = "0x4031E4A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelRotate;

		// Token: 0x04031E4B RID: 204363
		[Token(Token = "0x4031E4B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelTraining;

		// Token: 0x04031E4C RID: 204364
		[Token(Token = "0x4031E4C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04031E4D RID: 204365
		[Token(Token = "0x4031E4D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x04031E4E RID: 204366
		[Token(Token = "0x4031E4E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04031E4F RID: 204367
		[Token(Token = "0x4031E4F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelRemainTime;

		// Token: 0x04031E50 RID: 204368
		[Token(Token = "0x4031E50")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x04031E51 RID: 204369
		[Token(Token = "0x4031E51")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICommonTrackPoint _trackPointReward;

		// Token: 0x04031E52 RID: 204370
		[Token(Token = "0x4031E52")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelHotSpot;

		// Token: 0x04031E53 RID: 204371
		[Token(Token = "0x4031E53")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04031E54 RID: 204372
		[Token(Token = "0x4031E54")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04031E55 RID: 204373
		[Token(Token = "0x4031E55")]
		[FieldOffset(Offset = "0xA0")]
		private CampaignZoneMapStageListItemView.Adapter m_adapter;

		// Token: 0x04031E56 RID: 204374
		[Token(Token = "0x4031E56")]
		[FieldOffset(Offset = "0xA8")]
		private List<CampaignBreakDetailItemViewModel> m_cachedBreakLadder;

		// Token: 0x04031E57 RID: 204375
		[Token(Token = "0x4031E57")]
		[FieldOffset(Offset = "0xB0")]
		private TrackPointViewProperty m_trackPointProperty;

		// Token: 0x04031E58 RID: 204376
		[Token(Token = "0x4031E58")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031E59 RID: 204377
		[Token(Token = "0x4031E59")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedStageId;

		// Token: 0x04031E5A RID: 204378
		[Token(Token = "0x4031E5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031E5B RID: 204379
		[Token(Token = "0x4031E5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnItemClicked;

		// Token: 0x04031E5C RID: 204380
		[Token(Token = "0x4031E5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031E5D RID: 204381
		[Token(Token = "0x4031E5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x04031E5E RID: 204382
		[Token(Token = "0x4031E5E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200613E RID: 24894
		[Token(Token = "0x200613E")]
		private class StageTrackPointModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x170054D8 RID: 21720
			// (get) Token: 0x06023F03 RID: 147203 RVA: 0x000C26E8 File Offset: 0x000C08E8
			// (set) Token: 0x06023F04 RID: 147204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170054D8")]
			public bool isShow
			{
				[Token(Token = "0x6023F03")]
				[Address(RVA = "0x1E9BFB0", Offset = "0x1E9ABB0", VA = "0x181E9BFB0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6023F04")]
				[Address(RVA = "0x1E9C010", Offset = "0x1E9AC10", VA = "0x181E9C010")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06023F05 RID: 147205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F05")]
			[Address(RVA = "0x1E9BE60", Offset = "0x1E9AA60", VA = "0x181E9BE60", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x06023F06 RID: 147206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F06")]
			[Address(RVA = "0x1E9BF50", Offset = "0x1E9AB50", VA = "0x181E9BF50")]
			public StageTrackPointModel()
			{
			}

			// Token: 0x04031E60 RID: 204384
			[Token(Token = "0x4031E60")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04031E61 RID: 204385
			[Token(Token = "0x4031E61")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x04031E62 RID: 204386
			[Token(Token = "0x4031E62")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04031E63 RID: 204387
			[Token(Token = "0x4031E63")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200613F RID: 24895
			[Token(Token = "0x200613F")]
			public class Input
			{
				// Token: 0x06023F07 RID: 147207 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6023F07")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Input()
				{
				}

				// Token: 0x04031E64 RID: 204388
				[Token(Token = "0x4031E64")]
				[FieldOffset(Offset = "0x10")]
				public bool isShow;
			}
		}

		// Token: 0x02006140 RID: 24896
		[Token(Token = "0x2006140")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x06023F08 RID: 147208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F08")]
			[Address(RVA = "0x1E82F00", Offset = "0x1E81B00", VA = "0x181E82F00")]
			public Adapter(CampaignZoneMapStageListItemView closure)
			{
			}

			// Token: 0x170054D9 RID: 21721
			// (get) Token: 0x06023F09 RID: 147209 RVA: 0x000C2700 File Offset: 0x000C0900
			[Token(Token = "0x170054D9")]
			public override int count
			{
				[Token(Token = "0x6023F09")]
				[Address(RVA = "0x1E830E0", Offset = "0x1E81CE0", VA = "0x181E830E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06023F0A RID: 147210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023F0A")]
			[Address(RVA = "0x1E82BD0", Offset = "0x1E817D0", VA = "0x181E82BD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04031E65 RID: 204389
			[Token(Token = "0x4031E65")]
			[FieldOffset(Offset = "0x20")]
			private CampaignZoneMapStageListItemView m_closure;

			// Token: 0x04031E66 RID: 204390
			[Token(Token = "0x4031E66")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031E67 RID: 204391
			[Token(Token = "0x4031E67")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04031E68 RID: 204392
			[Token(Token = "0x4031E68")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
