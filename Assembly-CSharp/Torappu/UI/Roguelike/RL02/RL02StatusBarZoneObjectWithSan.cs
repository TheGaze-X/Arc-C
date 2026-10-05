using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200578F RID: 22415
	[Token(Token = "0x200578F")]
	public class RL02StatusBarZoneObjectWithSan : RoguelikeMenuObject<RL02ZoneWithSanViewModel>
	{
		// Token: 0x06020CA4 RID: 134308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CA4")]
		[Address(RVA = "0x1B27B10", Offset = "0x1B26710", VA = "0x181B27B10", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06020CA5 RID: 134309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CA5")]
		[Address(RVA = "0x1B278A0", Offset = "0x1B264A0", VA = "0x181B278A0", Slot = "14")]
		public override List<RoguelikeMenuEffect> CollectMenuEffectPrefabs()
		{
			return null;
		}

		// Token: 0x06020CA6 RID: 134310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CA6")]
		[Address(RVA = "0x1B27980", Offset = "0x1B26580", VA = "0x181B27980", Slot = "15")]
		public override void DispatchMenuEffects(List<RoguelikeMenuEffect> instanceList)
		{
		}

		// Token: 0x17004CE1 RID: 19681
		// (get) Token: 0x06020CA7 RID: 134311 RVA: 0x000B74C8 File Offset: 0x000B56C8
		[Token(Token = "0x17004CE1")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020CA7")]
			[Address(RVA = "0x1B29BD0", Offset = "0x1B287D0", VA = "0x181B29BD0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020CA8 RID: 134312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CA8")]
		[Address(RVA = "0x1B28C70", Offset = "0x1B27870", VA = "0x181B28C70")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x06020CA9 RID: 134313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CA9")]
		[Address(RVA = "0x1B28A40", Offset = "0x1B27640", VA = "0x181B28A40")]
		private void _RenderSan(int value, bool fastMode)
		{
		}

		// Token: 0x06020CAA RID: 134314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CAA")]
		[Address(RVA = "0x1B28940", Offset = "0x1B27540", VA = "0x181B28940")]
		private void _RenderSanEmpty(bool show, bool fastMode)
		{
		}

		// Token: 0x06020CAB RID: 134315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CAB")]
		[Address(RVA = "0x1B28680", Offset = "0x1B27280", VA = "0x181B28680")]
		private void _RenderSanBkg(bool show, bool fastMode)
		{
		}

		// Token: 0x06020CAC RID: 134316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CAC")]
		[Address(RVA = "0x1B287D0", Offset = "0x1B273D0", VA = "0x181B287D0")]
		private void _RenderSanEffectRank(SanEffectRank rank, bool fastMode)
		{
		}

		// Token: 0x06020CAD RID: 134317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CAD")]
		[Address(RVA = "0x1B28D90", Offset = "0x1B27990", VA = "0x181B28D90")]
		private void _RenderZoneAndVariation(string zoneId, bool fastMode)
		{
		}

		// Token: 0x06020CAE RID: 134318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CAE")]
		[Address(RVA = "0x1B295E0", Offset = "0x1B281E0", VA = "0x181B295E0")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x06020CAF RID: 134319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CAF")]
		[Address(RVA = "0x1B29190", Offset = "0x1B27D90", VA = "0x181B29190")]
		private void _Render(bool fastMode, bool isFromAdapterChange)
		{
		}

		// Token: 0x06020CB0 RID: 134320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CB0")]
		[Address(RVA = "0x1B28330", Offset = "0x1B26F30", VA = "0x181B28330", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x06020CB1 RID: 134321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CB1")]
		[Address(RVA = "0x1B284C0", Offset = "0x1B270C0", VA = "0x181B284C0", Slot = "16")]
		public override void Render(RL02ZoneWithSanViewModel viewModel)
		{
		}

		// Token: 0x06020CB2 RID: 134322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CB2")]
		[Address(RVA = "0x1B29AF0", Offset = "0x1B286F0", VA = "0x181B29AF0")]
		public RL02StatusBarZoneObjectWithSan()
		{
		}

		// Token: 0x06020CBA RID: 134330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CBA")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x06020CBB RID: 134331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020CBB")]
		[Address(RVA = "0x1B28660", Offset = "0x1B27260", VA = "0x181B28660")]
		private List<RoguelikeMenuEffect> <>xLuaBaseProxy_CollectMenuEffectPrefabs()
		{
			return null;
		}

		// Token: 0x06020CBC RID: 134332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CBC")]
		[Address(RVA = "0x1B28670", Offset = "0x1B27270", VA = "0x181B28670")]
		private void <>xLuaBaseProxy_DispatchMenuEffects(List<RoguelikeMenuEffect> P0)
		{
		}

		// Token: 0x06020CBD RID: 134333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CBD")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0402C8B4 RID: 182452
		[Token(Token = "0x402C8B4")]
		private const float SAN_CHANGE_TWEEN_DURATION = 0.16f;

		// Token: 0x0402C8B5 RID: 182453
		[Token(Token = "0x402C8B5")]
		private const int SAN_MASK_BAR_WIDTH = 186;

		// Token: 0x0402C8B6 RID: 182454
		[Token(Token = "0x402C8B6")]
		private const int SAN_MASK_BAR_HEIGHT = 129;

		// Token: 0x0402C8B7 RID: 182455
		[Token(Token = "0x402C8B7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color SAN_TEXT_COLOR;

		// Token: 0x0402C8B8 RID: 182456
		[Token(Token = "0x402C8B8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402C8B9 RID: 182457
		[Token(Token = "0x402C8B9")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Type[] STATES_SAN_BKG_SHOW;

		// Token: 0x0402C8BA RID: 182458
		[Token(Token = "0x402C8BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlContent;

		// Token: 0x0402C8BB RID: 182459
		[Token(Token = "0x402C8BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _btnDetail;

		// Token: 0x0402C8BC RID: 182460
		[Token(Token = "0x402C8BC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textZoneName;

		// Token: 0x0402C8BD RID: 182461
		[Token(Token = "0x402C8BD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imageZoneNum;

		// Token: 0x0402C8BE RID: 182462
		[Token(Token = "0x402C8BE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasObject _imageZoneNumAtlas;

		// Token: 0x0402C8BF RID: 182463
		[Token(Token = "0x402C8BF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RL02StatusBarZoneObjectWithSan.AtlasConfig[] _zoneNumAtlasConfigs;

		// Token: 0x0402C8C0 RID: 182464
		[Token(Token = "0x402C8C0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelVariation;

		// Token: 0x0402C8C1 RID: 182465
		[Token(Token = "0x402C8C1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RL02StatusBarZoneObjectWithSan.VariationItem[] _variationItems;

		// Token: 0x0402C8C2 RID: 182466
		[Token(Token = "0x402C8C2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelSan;

		// Token: 0x0402C8C3 RID: 182467
		[Token(Token = "0x402C8C3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasSanBkg;

		// Token: 0x0402C8C4 RID: 182468
		[Token(Token = "0x402C8C4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasSanEmpty;

		// Token: 0x0402C8C5 RID: 182469
		[Token(Token = "0x402C8C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textSanNum;

		// Token: 0x0402C8C6 RID: 182470
		[Token(Token = "0x402C8C6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _maskSan;

		// Token: 0x0402C8C7 RID: 182471
		[Token(Token = "0x402C8C7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RL02StatusBarSanEffect _effectPrefab;

		// Token: 0x0402C8C8 RID: 182472
		[Token(Token = "0x402C8C8")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<string, string> m_zoneNumAtlasNameDict;

		// Token: 0x0402C8C9 RID: 182473
		[Token(Token = "0x402C8C9")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_sanTween;

		// Token: 0x0402C8CA RID: 182474
		[Token(Token = "0x402C8CA")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_sanBkgShowTween;

		// Token: 0x0402C8CB RID: 182475
		[Token(Token = "0x402C8CB")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_sanEmptyShowTween;

		// Token: 0x0402C8CC RID: 182476
		[Token(Token = "0x402C8CC")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeStatusBarTextTweener m_sanTextTweener;

		// Token: 0x0402C8CD RID: 182477
		[Token(Token = "0x402C8CD")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402C8CE RID: 182478
		[Token(Token = "0x402C8CE")]
		[FieldOffset(Offset = "0xC8")]
		private RoguelikeMenuViewRenderer<string> m_zoneRenderer;

		// Token: 0x0402C8CF RID: 182479
		[Token(Token = "0x402C8CF")]
		[FieldOffset(Offset = "0xD0")]
		private List<IRoguelikeMenuViewRenderer> m_renderers;

		// Token: 0x0402C8D0 RID: 182480
		[Token(Token = "0x402C8D0")]
		[FieldOffset(Offset = "0xD8")]
		private RL02ZoneWithSanViewModel m_cachedModel;

		// Token: 0x0402C8D1 RID: 182481
		[Token(Token = "0x402C8D1")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_cachedStateShow;

		// Token: 0x0402C8D2 RID: 182482
		[Token(Token = "0x402C8D2")]
		[FieldOffset(Offset = "0xE1")]
		private bool m_cachedSanBkgShowStatus;

		// Token: 0x0402C8D3 RID: 182483
		[Token(Token = "0x402C8D3")]
		[FieldOffset(Offset = "0xE8")]
		private RL02StatusBarSanEffect m_effect;

		// Token: 0x0402C8D4 RID: 182484
		[Token(Token = "0x402C8D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C8D5 RID: 182485
		[Token(Token = "0x402C8D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CollectMenuEffectPrefabs;

		// Token: 0x0402C8D6 RID: 182486
		[Token(Token = "0x402C8D6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DispatchMenuEffects;

		// Token: 0x0402C8D7 RID: 182487
		[Token(Token = "0x402C8D7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402C8D8 RID: 182488
		[Token(Token = "0x402C8D8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402C8D9 RID: 182489
		[Token(Token = "0x402C8D9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderSan;

		// Token: 0x0402C8DA RID: 182490
		[Token(Token = "0x402C8DA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderSanEmpty;

		// Token: 0x0402C8DB RID: 182491
		[Token(Token = "0x402C8DB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderSanBkg;

		// Token: 0x0402C8DC RID: 182492
		[Token(Token = "0x402C8DC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__RenderSanEffectRank;

		// Token: 0x0402C8DD RID: 182493
		[Token(Token = "0x402C8DD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderZoneAndVariation;

		// Token: 0x0402C8DE RID: 182494
		[Token(Token = "0x402C8DE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402C8DF RID: 182495
		[Token(Token = "0x402C8DF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402C8E0 RID: 182496
		[Token(Token = "0x402C8E0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402C8E1 RID: 182497
		[Token(Token = "0x402C8E1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C8E2 RID: 182498
		[Token(Token = "0x402C8E2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005790 RID: 22416
		[Token(Token = "0x2005790")]
		[Serializable]
		private struct AtlasConfig
		{
			// Token: 0x0402C8E3 RID: 182499
			[Token(Token = "0x402C8E3")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x0402C8E4 RID: 182500
			[Token(Token = "0x402C8E4")]
			[FieldOffset(Offset = "0x8")]
			public string atlasName;
		}

		// Token: 0x02005791 RID: 22417
		[Token(Token = "0x2005791")]
		[Serializable]
		private class VariationItem : IHotfixable
		{
			// Token: 0x06020CBE RID: 134334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CBE")]
			[Address(RVA = "0x1B2C770", Offset = "0x1B2B370", VA = "0x181B2C770")]
			public void Render(string topicId, RoguelikeVariationModel model)
			{
			}

			// Token: 0x06020CBF RID: 134335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CBF")]
			[Address(RVA = "0x1B2C910", Offset = "0x1B2B510", VA = "0x181B2C910")]
			public VariationItem()
			{
			}

			// Token: 0x0402C8E5 RID: 182501
			[Token(Token = "0x402C8E5")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panelVariation;

			// Token: 0x0402C8E6 RID: 182502
			[Token(Token = "0x402C8E6")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Image _imageVariation;

			// Token: 0x0402C8E7 RID: 182503
			[Token(Token = "0x402C8E7")]
			[FieldOffset(Offset = "0x20")]
			private string m_cachedVariationId;

			// Token: 0x0402C8E8 RID: 182504
			[Token(Token = "0x402C8E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402C8E9 RID: 182505
			[Token(Token = "0x402C8E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
