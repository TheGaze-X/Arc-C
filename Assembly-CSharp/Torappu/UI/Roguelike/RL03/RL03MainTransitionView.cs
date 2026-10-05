using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005878 RID: 22648
	[Token(Token = "0x2005878")]
	public class RL03MainTransitionView : RoguelikeMainTransController
	{
		// Token: 0x06021125 RID: 135461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021125")]
		[Address(RVA = "0x1B5D450", Offset = "0x1B5C050", VA = "0x181B5D450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021126 RID: 135462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021126")]
		[Address(RVA = "0x1B5D160", Offset = "0x1B5BD60", VA = "0x181B5D160")]
		private void OnEnable()
		{
		}

		// Token: 0x06021127 RID: 135463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021127")]
		[Address(RVA = "0x1B5D1F0", Offset = "0x1B5BDF0", VA = "0x181B5D1F0", Slot = "4")]
		public override void Render(RoguelikeDungeonZoneViewProperty property)
		{
		}

		// Token: 0x06021128 RID: 135464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021128")]
		[Address(RVA = "0x1B5D540", Offset = "0x1B5C140", VA = "0x181B5D540")]
		private void _RenderMainTrans(RL03MainTransitionView.TransitionParam transitionParam)
		{
		}

		// Token: 0x06021129 RID: 135465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021129")]
		[Address(RVA = "0x1B5D360", Offset = "0x1B5BF60", VA = "0x181B5D360", Slot = "6")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x0602112A RID: 135466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602112A")]
		[Address(RVA = "0x1B5D2A0", Offset = "0x1B5BEA0", VA = "0x181B5D2A0", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x0602112B RID: 135467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602112B")]
		[Address(RVA = "0x1B5D920", Offset = "0x1B5C520", VA = "0x181B5D920")]
		private IEnumerator _WaitForNextClick()
		{
			return null;
		}

		// Token: 0x0602112C RID: 135468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602112C")]
		[Address(RVA = "0x1B5D100", Offset = "0x1B5BD00", VA = "0x181B5D100")]
		public void EventOnMainPanelClicked()
		{
		}

		// Token: 0x0602112D RID: 135469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602112D")]
		[Address(RVA = "0x1B5D9D0", Offset = "0x1B5C5D0", VA = "0x181B5D9D0")]
		public RL03MainTransitionView()
		{
		}

		// Token: 0x0402D044 RID: 184388
		[Token(Token = "0x402D044")]
		private const float HIDE_TWEEN_DURATION = 0.5f;

		// Token: 0x0402D045 RID: 184389
		[Token(Token = "0x402D045")]
		private const float AUTO_MAIN_TRANS_DUR = 1.5f;

		// Token: 0x0402D046 RID: 184390
		[Token(Token = "0x402D046")]
		private const string CHAOS_LEVEL_FORMAT = "LV.{0}";

		// Token: 0x0402D047 RID: 184391
		[Token(Token = "0x402D047")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelMainTrans;

		// Token: 0x0402D048 RID: 184392
		[Token(Token = "0x402D048")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClickPlayer _clickAudio;

		// Token: 0x0402D049 RID: 184393
		[Token(Token = "0x402D049")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402D04A RID: 184394
		[Token(Token = "0x402D04A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402D04B RID: 184395
		[Token(Token = "0x402D04B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgVisionBkg;

		// Token: 0x0402D04C RID: 184396
		[Token(Token = "0x402D04C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgVisionIcon;

		// Token: 0x0402D04D RID: 184397
		[Token(Token = "0x402D04D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textVisionStatus;

		// Token: 0x0402D04E RID: 184398
		[Token(Token = "0x402D04E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _zoneIcon;

		// Token: 0x0402D04F RID: 184399
		[Token(Token = "0x402D04F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _zoneIconSmall;

		// Token: 0x0402D050 RID: 184400
		[Token(Token = "0x402D050")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textChaosIncreaseNum;

		// Token: 0x0402D051 RID: 184401
		[Token(Token = "0x402D051")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textChaosLevelBefore;

		// Token: 0x0402D052 RID: 184402
		[Token(Token = "0x402D052")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textChaosLevelAfter;

		// Token: 0x0402D053 RID: 184403
		[Token(Token = "0x402D053")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RL03MainTransitionView.ChaosItem[] _chaosItems;

		// Token: 0x0402D054 RID: 184404
		[Token(Token = "0x402D054")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0402D055 RID: 184405
		[Token(Token = "0x402D055")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _chaosIncrease;

		// Token: 0x0402D056 RID: 184406
		[Token(Token = "0x402D056")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation[] _chaosIncreaseAndLevelUp;

		// Token: 0x0402D057 RID: 184407
		[Token(Token = "0x402D057")]
		[FieldOffset(Offset = "0xB0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402D058 RID: 184408
		[Token(Token = "0x402D058")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_enterTween;

		// Token: 0x0402D059 RID: 184409
		[Token(Token = "0x402D059")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_chaosTween;

		// Token: 0x0402D05A RID: 184410
		[Token(Token = "0x402D05A")]
		[FieldOffset(Offset = "0xD0")]
		private RL03MainTransitionView.TransitionParam m_cachedTransitionParam;

		// Token: 0x0402D05B RID: 184411
		[Token(Token = "0x402D05B")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_waitForNextClick;

		// Token: 0x0402D05C RID: 184412
		[Token(Token = "0x402D05C")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_isInited;

		// Token: 0x0402D05D RID: 184413
		[Token(Token = "0x402D05D")]
		[FieldOffset(Offset = "0xE0")]
		private FadeSwitchTween m_mainTransSwitch;

		// Token: 0x0402D05E RID: 184414
		[Token(Token = "0x402D05E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D05F RID: 184415
		[Token(Token = "0x402D05F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402D060 RID: 184416
		[Token(Token = "0x402D060")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402D061 RID: 184417
		[Token(Token = "0x402D061")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderMainTrans;

		// Token: 0x0402D062 RID: 184418
		[Token(Token = "0x402D062")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402D063 RID: 184419
		[Token(Token = "0x402D063")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402D064 RID: 184420
		[Token(Token = "0x402D064")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__WaitForNextClick;

		// Token: 0x0402D065 RID: 184421
		[Token(Token = "0x402D065")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnMainPanelClicked;

		// Token: 0x0402D066 RID: 184422
		[Token(Token = "0x402D066")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005879 RID: 22649
		[Token(Token = "0x2005879")]
		private class TransitionChaosItemData : IHotfixable
		{
			// Token: 0x06021130 RID: 135472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021130")]
			[Address(RVA = "0x1B6DF10", Offset = "0x1B6CB10", VA = "0x181B6DF10")]
			public void LoadData(string topicId, string chaosId)
			{
			}

			// Token: 0x06021131 RID: 135473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021131")]
			[Address(RVA = "0x1B6E0E0", Offset = "0x1B6CCE0", VA = "0x181B6E0E0")]
			public TransitionChaosItemData()
			{
			}

			// Token: 0x0402D067 RID: 184423
			[Token(Token = "0x402D067")]
			[FieldOffset(Offset = "0x10")]
			public string chaosId;

			// Token: 0x0402D068 RID: 184424
			[Token(Token = "0x402D068")]
			[FieldOffset(Offset = "0x18")]
			public string chaosName;

			// Token: 0x0402D069 RID: 184425
			[Token(Token = "0x402D069")]
			[FieldOffset(Offset = "0x20")]
			public string chaosIconId;

			// Token: 0x0402D06A RID: 184426
			[Token(Token = "0x402D06A")]
			[FieldOffset(Offset = "0x28")]
			public int sortId;

			// Token: 0x0402D06B RID: 184427
			[Token(Token = "0x402D06B")]
			[FieldOffset(Offset = "0x2C")]
			public int chaosLevel;

			// Token: 0x0402D06C RID: 184428
			[Token(Token = "0x402D06C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D06D RID: 184429
			[Token(Token = "0x402D06D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200587A RID: 22650
		[Token(Token = "0x200587A")]
		private class TransitionChaosData : IHotfixable
		{
			// Token: 0x06021132 RID: 135474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021132")]
			[Address(RVA = "0x1B6DA00", Offset = "0x1B6C600", VA = "0x181B6DA00")]
			public void LoadData(string topicId, PlayerRoguelikeV2.CurrentData.Module.ChaosZoneDelta playerDeltaChaos)
			{
			}

			// Token: 0x06021133 RID: 135475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021133")]
			[Address(RVA = "0x1B6DE60", Offset = "0x1B6CA60", VA = "0x181B6DE60")]
			public TransitionChaosData()
			{
			}

			// Token: 0x0402D06E RID: 184430
			[Token(Token = "0x402D06E")]
			[FieldOffset(Offset = "0x10")]
			public int chaosIncreaseNum;

			// Token: 0x0402D06F RID: 184431
			[Token(Token = "0x402D06F")]
			[FieldOffset(Offset = "0x14")]
			public int chaosLevelBefore;

			// Token: 0x0402D070 RID: 184432
			[Token(Token = "0x402D070")]
			[FieldOffset(Offset = "0x18")]
			public int chaosLevelAfter;

			// Token: 0x0402D071 RID: 184433
			[Token(Token = "0x402D071")]
			[FieldOffset(Offset = "0x20")]
			public List<RL03MainTransitionView.TransitionChaosItemData> chaosDelta;

			// Token: 0x0402D072 RID: 184434
			[Token(Token = "0x402D072")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D073 RID: 184435
			[Token(Token = "0x402D073")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200587C RID: 22652
		[Token(Token = "0x200587C")]
		private class TransitionVisionData : IHotfixable
		{
			// Token: 0x06021137 RID: 135479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021137")]
			[Address(RVA = "0x1B6E5F0", Offset = "0x1B6D1F0", VA = "0x181B6E5F0")]
			public void LoadData(string topicId, PlayerRoguelikeV2.CurrentData.Module.Vision playerVision)
			{
			}

			// Token: 0x06021138 RID: 135480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021138")]
			[Address(RVA = "0x1B6E830", Offset = "0x1B6D430", VA = "0x181B6E830")]
			public TransitionVisionData()
			{
			}

			// Token: 0x0402D076 RID: 184438
			[Token(Token = "0x402D076")]
			[FieldOffset(Offset = "0x10")]
			public int visionNum;

			// Token: 0x0402D077 RID: 184439
			[Token(Token = "0x402D077")]
			[FieldOffset(Offset = "0x18")]
			public string visionIconId;

			// Token: 0x0402D078 RID: 184440
			[Token(Token = "0x402D078")]
			[FieldOffset(Offset = "0x20")]
			public string visionDesc;

			// Token: 0x0402D079 RID: 184441
			[Token(Token = "0x402D079")]
			[FieldOffset(Offset = "0x28")]
			public string visionColorCode;

			// Token: 0x0402D07A RID: 184442
			[Token(Token = "0x402D07A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0402D07B RID: 184443
			[Token(Token = "0x402D07B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200587D RID: 22653
		[Token(Token = "0x200587D")]
		private class TransitionParam : IHotfixable
		{
			// Token: 0x06021139 RID: 135481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021139")]
			[Address(RVA = "0x1B6E140", Offset = "0x1B6CD40", VA = "0x181B6E140")]
			public static RL03MainTransitionView.TransitionParam Create(RoguelikeDungeonZoneViewModel zoneModel)
			{
				return null;
			}

			// Token: 0x0602113A RID: 135482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602113A")]
			[Address(RVA = "0x1B6E590", Offset = "0x1B6D190", VA = "0x181B6E590")]
			public TransitionParam()
			{
			}

			// Token: 0x0402D07C RID: 184444
			[Token(Token = "0x402D07C")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x0402D07D RID: 184445
			[Token(Token = "0x402D07D")]
			[FieldOffset(Offset = "0x18")]
			public bool isAutoTrans;

			// Token: 0x0402D07E RID: 184446
			[Token(Token = "0x402D07E")]
			[FieldOffset(Offset = "0x19")]
			public bool isManualTrans;

			// Token: 0x0402D07F RID: 184447
			[Token(Token = "0x402D07F")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeGameZoneData zoneData;

			// Token: 0x0402D080 RID: 184448
			[Token(Token = "0x402D080")]
			[FieldOffset(Offset = "0x28")]
			public RL03MainTransitionView.TransitionChaosData chaos;

			// Token: 0x0402D081 RID: 184449
			[Token(Token = "0x402D081")]
			[FieldOffset(Offset = "0x30")]
			public RL03MainTransitionView.TransitionVisionData vision;

			// Token: 0x0402D082 RID: 184450
			[Token(Token = "0x402D082")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x0402D083 RID: 184451
			[Token(Token = "0x402D083")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200587E RID: 22654
		[Token(Token = "0x200587E")]
		[Serializable]
		private class ChaosItem : IHotfixable
		{
			// Token: 0x0602113B RID: 135483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602113B")]
			[Address(RVA = "0x1B5B670", Offset = "0x1B5A270", VA = "0x181B5B670")]
			public void Render(string topicId, RL03MainTransitionView.TransitionChaosItemData chaosItemData, ILoadAsset assetLoader)
			{
			}

			// Token: 0x0602113C RID: 135484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602113C")]
			[Address(RVA = "0x1B5B860", Offset = "0x1B5A460", VA = "0x181B5B860")]
			public ChaosItem()
			{
			}

			// Token: 0x0402D084 RID: 184452
			[Token(Token = "0x402D084")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _root;

			// Token: 0x0402D085 RID: 184453
			[Token(Token = "0x402D085")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textChaosName;

			// Token: 0x0402D086 RID: 184454
			[Token(Token = "0x402D086")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image _imgChaosIcon;

			// Token: 0x0402D087 RID: 184455
			[Token(Token = "0x402D087")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UIAtlasImage _imgChaosLevel1;

			// Token: 0x0402D088 RID: 184456
			[Token(Token = "0x402D088")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private UIAtlasImage _imgChaosLevel2;

			// Token: 0x0402D089 RID: 184457
			[Token(Token = "0x402D089")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Color _colorLight;

			// Token: 0x0402D08A RID: 184458
			[Token(Token = "0x402D08A")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private Color _colorDark;

			// Token: 0x0402D08B RID: 184459
			[Token(Token = "0x402D08B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402D08C RID: 184460
			[Token(Token = "0x402D08C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
