using System;
using System.Text;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.UI;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A0E RID: 10766
	[Token(Token = "0x2002A0E")]
	public class UIBattleLegionWidgetsPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011DBA RID: 73146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DBA")]
		[Address(RVA = "0x9BD0E0", Offset = "0x9BBCE0", VA = "0x1809BD0E0")]
		public void OnInit(LegionUIPlugin legion)
		{
		}

		// Token: 0x06011DBB RID: 73147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DBB")]
		[Address(RVA = "0x9BD740", Offset = "0x9BC340", VA = "0x1809BD740")]
		public void UpdateGameInfo()
		{
		}

		// Token: 0x06011DBC RID: 73148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DBC")]
		[Address(RVA = "0x9BCEC0", Offset = "0x9BBAC0", VA = "0x1809BCEC0")]
		public void OnDrawNextCard()
		{
		}

		// Token: 0x06011DBD RID: 73149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DBD")]
		[Address(RVA = "0x9BD620", Offset = "0x9BC220", VA = "0x1809BD620")]
		public void OnShowPendingCard()
		{
		}

		// Token: 0x06011DBE RID: 73150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DBE")]
		[Address(RVA = "0x9BD6B0", Offset = "0x9BC2B0", VA = "0x1809BD6B0")]
		public void OnShowUsedCard()
		{
		}

		// Token: 0x06011DBF RID: 73151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DBF")]
		[Address(RVA = "0x9BE440", Offset = "0x9BD040", VA = "0x1809BE440")]
		private void _ShowHandCardFullTipsTween()
		{
		}

		// Token: 0x06011DC0 RID: 73152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC0")]
		[Address(RVA = "0x9BE360", Offset = "0x9BCF60", VA = "0x1809BE360")]
		private void _ShowHandCardFullTipsTween(LegionModeOnCardFullParam param)
		{
		}

		// Token: 0x06011DC1 RID: 73153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC1")]
		[Address(RVA = "0x9BDE90", Offset = "0x9BCA90", VA = "0x1809BDE90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06011DC2 RID: 73154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC2")]
		[Address(RVA = "0x9BE1D0", Offset = "0x9BCDD0", VA = "0x1809BE1D0")]
		private void _ResetData()
		{
		}

		// Token: 0x06011DC3 RID: 73155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC3")]
		[Address(RVA = "0x9BE2A0", Offset = "0x9BCEA0", VA = "0x1809BE2A0")]
		private void _ResetReshuffleBeforePlay()
		{
		}

		// Token: 0x06011DC4 RID: 73156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC4")]
		[Address(RVA = "0x9BEE20", Offset = "0x9BDA20", VA = "0x1809BEE20")]
		private void _UpdateReshufflePart()
		{
		}

		// Token: 0x06011DC5 RID: 73157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC5")]
		[Address(RVA = "0x9BF070", Offset = "0x9BDC70", VA = "0x1809BF070")]
		private void _UpdateUsedCardPart(int targetUsedCardCount)
		{
		}

		// Token: 0x06011DC6 RID: 73158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC6")]
		[Address(RVA = "0x9BECC0", Offset = "0x9BD8C0", VA = "0x1809BECC0")]
		private void _UpdateRemainCardPart(int targetRemainNum)
		{
		}

		// Token: 0x06011DC7 RID: 73159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC7")]
		[Address(RVA = "0x9BE960", Offset = "0x9BD560", VA = "0x1809BE960")]
		private void _UpdateGoldDrawPart(int targetGoldNum, int drawNeedGoldPrice, bool isCardFull)
		{
		}

		// Token: 0x06011DC8 RID: 73160 RVA: 0x0006D3C8 File Offset: 0x0006B5C8
		[Token(Token = "0x6011DC8")]
		[Address(RVA = "0x9BDD40", Offset = "0x9BC940", VA = "0x1809BDD40")]
		private UIBattleLegionWidgetsPanel.GOLD_DRAW_STATE _GetDrawState(bool glowing, bool isCardFull)
		{
			return UIBattleLegionWidgetsPanel.GOLD_DRAW_STATE.NONE;
		}

		// Token: 0x06011DC9 RID: 73161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DC9")]
		[Address(RVA = "0x9BE610", Offset = "0x9BD210", VA = "0x1809BE610")]
		private void _UpdateGoldDrawPartText(UIBattleLegionWidgetsPanel.GOLD_DRAW_STATE drawState, bool glowing, int targetGoldNum, int drawNeedGoldPrice)
		{
		}

		// Token: 0x06011DCA RID: 73162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DCA")]
		[Address(RVA = "0x9BE4E0", Offset = "0x9BD0E0", VA = "0x1809BE4E0")]
		private void _UpdateGoldDrawPartState(UIBattleLegionWidgetsPanel.GOLD_DRAW_STATE drawState)
		{
		}

		// Token: 0x06011DCB RID: 73163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DCB")]
		[Address(RVA = "0x9BDBF0", Offset = "0x9BC7F0", VA = "0x1809BDBF0")]
		private void _CardFullPutToUsed(LegionModeOnCardFullParam param)
		{
		}

		// Token: 0x06011DCC RID: 73164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DCC")]
		[Address(RVA = "0x9BCD50", Offset = "0x9BB950", VA = "0x1809BCD50")]
		public void OnDestroy()
		{
		}

		// Token: 0x06011DCD RID: 73165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DCD")]
		[Address(RVA = "0x9BF290", Offset = "0x9BDE90", VA = "0x1809BF290")]
		public UIBattleLegionWidgetsPanel()
		{
		}

		// Token: 0x04014160 RID: 82272
		[Token(Token = "0x4014160")]
		private const string ANIM_RESHUFFLE_CARD_TIPS = "reshuffle_card_tips";

		// Token: 0x04014161 RID: 82273
		[Token(Token = "0x4014161")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("DrawCard")]
		private GameObject _objBgCanDraw;

		// Token: 0x04014162 RID: 82274
		[Token(Token = "0x4014162")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("DrawCard")]
		private UIAtlasImage _imgBgCanDraw;

		// Token: 0x04014163 RID: 82275
		[Token(Token = "0x4014163")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("DrawCard")]
		private GameObject _objDrawIcon;

		// Token: 0x04014164 RID: 82276
		[Token(Token = "0x4014164")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("DrawCard")]
		private Image _imgDrawIcon;

		// Token: 0x04014165 RID: 82277
		[Token(Token = "0x4014165")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("DrawCard")]
		private Image _igmDrawDown;

		// Token: 0x04014166 RID: 82278
		[Token(Token = "0x4014166")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("DrawCard")]
		private GameObject _objDrawBgDownGray;

		// Token: 0x04014167 RID: 82279
		[Token(Token = "0x4014167")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("DrawCard")]
		private GameObject _objDrawBgDown;

		// Token: 0x04014168 RID: 82280
		[Token(Token = "0x4014168")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("DrawCard")]
		private RectTransform _transGoldPart;

		// Token: 0x04014169 RID: 82281
		[Token(Token = "0x4014169")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("DrawCard")]
		private Text _drawNextGoldText;

		// Token: 0x0401416A RID: 82282
		[Token(Token = "0x401416A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("DrawCard")]
		private Button _btnDrawCard;

		// Token: 0x0401416B RID: 82283
		[Token(Token = "0x401416B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Pending")]
		private RectTransform _transPendingCardTips;

		// Token: 0x0401416C RID: 82284
		[Token(Token = "0x401416C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Pending")]
		private Text _remainingCardCountText;

		// Token: 0x0401416D RID: 82285
		[Token(Token = "0x401416D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Used")]
		private RectTransform _transUsedCardTips;

		// Token: 0x0401416E RID: 82286
		[Token(Token = "0x401416E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Used")]
		private Text _usedCardCountText;

		// Token: 0x0401416F RID: 82287
		[Token(Token = "0x401416F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Used")]
		private CanvasGroup _canvasUsedBtn;

		// Token: 0x04014170 RID: 82288
		[Token(Token = "0x4014170")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("CardFull")]
		private CanvasGroup _canvasHandCardFullTips;

		// Token: 0x04014171 RID: 82289
		[Token(Token = "0x4014171")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("CardFull")]
		private RectTransform _transHandCardFullTips;

		// Token: 0x04014172 RID: 82290
		[Token(Token = "0x4014172")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("CardFull")]
		private CanvasGroup _canvasCardFullImg;

		// Token: 0x04014173 RID: 82291
		[Token(Token = "0x4014173")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Reshuffle")]
		private Text _textAddPrice;

		// Token: 0x04014174 RID: 82292
		[Token(Token = "0x4014174")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Reshuffle")]
		private GameObject _objGoldFull;

		// Token: 0x04014175 RID: 82293
		[Token(Token = "0x4014175")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Reshuffle")]
		private GameObject _objGoldNotFull;

		// Token: 0x04014176 RID: 82294
		[Token(Token = "0x4014176")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Reshuffle")]
		private AnimationWrapper _reshuffleAnim;

		// Token: 0x04014177 RID: 82295
		[Token(Token = "0x4014177")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Effect")]
		private LegionUIBlastCardEffectHolder _blastEffectHolder;

		// Token: 0x04014178 RID: 82296
		[Token(Token = "0x4014178")]
		[FieldOffset(Offset = "0xD0")]
		private GameModeFactory.LegionGameMode m_manager;

		// Token: 0x04014179 RID: 82297
		[Token(Token = "0x4014179")]
		[FieldOffset(Offset = "0xD8")]
		private LegionUIPlugin m_plugin;

		// Token: 0x0401417A RID: 82298
		[Token(Token = "0x401417A")]
		[FieldOffset(Offset = "0xE0")]
		private int m_cachedCurrentGoldNum;

		// Token: 0x0401417B RID: 82299
		[Token(Token = "0x401417B")]
		[FieldOffset(Offset = "0xE4")]
		private int m_cachedUsedCardCount;

		// Token: 0x0401417C RID: 82300
		[Token(Token = "0x401417C")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cacaheRemainCardCount;

		// Token: 0x0401417D RID: 82301
		[Token(Token = "0x401417D")]
		[FieldOffset(Offset = "0xF0")]
		private UIBattleLegionWidgetsPanel.DrawCardTween m_drawCardTween;

		// Token: 0x0401417E RID: 82302
		[Token(Token = "0x401417E")]
		[FieldOffset(Offset = "0xF8")]
		private UIBattleLegionWidgetsPanel.HandCardFullTipsTween m_handCardFullTipsTween;

		// Token: 0x0401417F RID: 82303
		[Token(Token = "0x401417F")]
		[FieldOffset(Offset = "0x100")]
		private UIBattleLegionWidgetsPanel.PendingCardNumChangeTween m_pendingCardNumChangeTween;

		// Token: 0x04014180 RID: 82304
		[Token(Token = "0x4014180")]
		[FieldOffset(Offset = "0x108")]
		private UIBattleLegionWidgetsPanel.UsedCardNumChangeTween m_usedCardNumChangeTween;

		// Token: 0x04014181 RID: 82305
		[Token(Token = "0x4014181")]
		private const string COLOR_TYPE_GOLD_CUR_GLOWING = "<color=#FFFFFFFF><size=32>{0}</size></color>";

		// Token: 0x04014182 RID: 82306
		[Token(Token = "0x4014182")]
		private const string COLOR_TYPE_GOLD_CUR_CAN_DRAW = "<color=#EA6718FF><size=32>{0}</size></color>";

		// Token: 0x04014183 RID: 82307
		[Token(Token = "0x4014183")]
		private const string COLOR_TYPE_GOLD_CUR_FULL = "<color=#FFFFFF4D><size=32>{0}</size></color>";

		// Token: 0x04014184 RID: 82308
		[Token(Token = "0x4014184")]
		private const string COLOR_TYPE_GOLD_NEED_CAN_DRAW = "<color=#FFFFFFFF><size=22>/{0}</size></color>";

		// Token: 0x04014185 RID: 82309
		[Token(Token = "0x4014185")]
		private const string COLOR_TYPE_GOLD_NEED = "<color=#FFFFFF4D><size=22>/{0}</size></color>";

		// Token: 0x04014186 RID: 82310
		[Token(Token = "0x4014186")]
		[FieldOffset(Offset = "0x110")]
		private UIBattleLegionWidgetsPanel.GOLD_DRAW_STATE m_cachedDrawState;

		// Token: 0x04014187 RID: 82311
		[Token(Token = "0x4014187")]
		private const float USED_CARD_EMPTY_ALPHA = 0.3f;

		// Token: 0x04014188 RID: 82312
		[Token(Token = "0x4014188")]
		[FieldOffset(Offset = "0x114")]
		private bool m_hasInited;

		// Token: 0x04014189 RID: 82313
		[Token(Token = "0x4014189")]
		[FieldOffset(Offset = "0x115")]
		private bool m_playingGoldGlowTween;

		// Token: 0x0401418A RID: 82314
		[Token(Token = "0x401418A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly StringBuilder m_goldTextBuilder;

		// Token: 0x0401418B RID: 82315
		[Token(Token = "0x401418B")]
		[FieldOffset(Offset = "0x118")]
		private int m_cachedGoldNum;

		// Token: 0x0401418C RID: 82316
		[Token(Token = "0x401418C")]
		[FieldOffset(Offset = "0x11C")]
		private int m_cachedNeedGoldNum;

		// Token: 0x0401418D RID: 82317
		[Token(Token = "0x401418D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401418E RID: 82318
		[Token(Token = "0x401418E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0401418F RID: 82319
		[Token(Token = "0x401418F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDrawNextCard;

		// Token: 0x04014190 RID: 82320
		[Token(Token = "0x4014190")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnShowPendingCard;

		// Token: 0x04014191 RID: 82321
		[Token(Token = "0x4014191")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnShowUsedCard;

		// Token: 0x04014192 RID: 82322
		[Token(Token = "0x4014192")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowHandCardFullTipsTween;

		// Token: 0x04014193 RID: 82323
		[Token(Token = "0x4014193")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1__ShowHandCardFullTipsTween;

		// Token: 0x04014194 RID: 82324
		[Token(Token = "0x4014194")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04014195 RID: 82325
		[Token(Token = "0x4014195")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetData;

		// Token: 0x04014196 RID: 82326
		[Token(Token = "0x4014196")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ResetReshuffleBeforePlay;

		// Token: 0x04014197 RID: 82327
		[Token(Token = "0x4014197")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateReshufflePart;

		// Token: 0x04014198 RID: 82328
		[Token(Token = "0x4014198")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateUsedCardPart;

		// Token: 0x04014199 RID: 82329
		[Token(Token = "0x4014199")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateRemainCardPart;

		// Token: 0x0401419A RID: 82330
		[Token(Token = "0x401419A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateGoldDrawPart;

		// Token: 0x0401419B RID: 82331
		[Token(Token = "0x401419B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetDrawState;

		// Token: 0x0401419C RID: 82332
		[Token(Token = "0x401419C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateGoldDrawPartText;

		// Token: 0x0401419D RID: 82333
		[Token(Token = "0x401419D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateGoldDrawPartState;

		// Token: 0x0401419E RID: 82334
		[Token(Token = "0x401419E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CardFullPutToUsed;

		// Token: 0x0401419F RID: 82335
		[Token(Token = "0x401419F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040141A0 RID: 82336
		[Token(Token = "0x40141A0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A0F RID: 10767
		[Token(Token = "0x2002A0F")]
		private enum GOLD_DRAW_STATE
		{
			// Token: 0x040141A2 RID: 82338
			[Token(Token = "0x40141A2")]
			NONE,
			// Token: 0x040141A3 RID: 82339
			[Token(Token = "0x40141A3")]
			GLOWING,
			// Token: 0x040141A4 RID: 82340
			[Token(Token = "0x40141A4")]
			CAN_DRAW,
			// Token: 0x040141A5 RID: 82341
			[Token(Token = "0x40141A5")]
			CARD_FULL
		}

		// Token: 0x02002A10 RID: 10768
		[Token(Token = "0x2002A10")]
		private class DrawCardTween : IHotfixable
		{
			// Token: 0x06011DCF RID: 73167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DCF")]
			[Address(RVA = "0x9ABF50", Offset = "0x9AAB50", VA = "0x1809ABF50")]
			public DrawCardTween(UIBattleLegionWidgetsPanel closure)
			{
			}

			// Token: 0x06011DD0 RID: 73168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DD0")]
			[Address(RVA = "0x9AB230", Offset = "0x9A9E30", VA = "0x1809AB230")]
			public void PlayGoldGlowTween(int curNum, int targetNum, int drawNeedGoldPrice, bool isCardFull)
			{
			}

			// Token: 0x06011DD1 RID: 73169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DD1")]
			[Address(RVA = "0x9AAF20", Offset = "0x9A9B20", VA = "0x1809AAF20")]
			public void PlayCanDrawTwinkLoopTween()
			{
			}

			// Token: 0x06011DD2 RID: 73170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DD2")]
			[Address(RVA = "0x9AB850", Offset = "0x9AA450", VA = "0x1809AB850")]
			public void PlayUseGoldNumDownTween()
			{
			}

			// Token: 0x06011DD3 RID: 73171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DD3")]
			[Address(RVA = "0x9ABB60", Offset = "0x9AA760", VA = "0x1809ABB60")]
			public void ResetToState(UIBattleLegionWidgetsPanel.GOLD_DRAW_STATE state)
			{
			}

			// Token: 0x06011DD4 RID: 73172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DD4")]
			[Address(RVA = "0x9AAEA0", Offset = "0x9A9AA0", VA = "0x1809AAEA0")]
			public void KillTween()
			{
			}

			// Token: 0x040141A6 RID: 82342
			[Token(Token = "0x40141A6")]
			[FieldOffset(Offset = "0x10")]
			private UIBattleLegionWidgetsPanel m_closure;

			// Token: 0x040141A7 RID: 82343
			[Token(Token = "0x40141A7")]
			[FieldOffset(Offset = "0x18")]
			private UISwitchTween.TweenWrapper m_tween;

			// Token: 0x040141A8 RID: 82344
			[Token(Token = "0x40141A8")]
			private const float GOLD_PER_NUM_GLOWING_DUR = 0.1f;

			// Token: 0x040141A9 RID: 82345
			[Token(Token = "0x40141A9")]
			private const float GOLD_NUM_LIMIT_MAX_GLOWING_DUR = 0.5f;

			// Token: 0x040141AA RID: 82346
			[Token(Token = "0x40141AA")]
			private const float GOLD_TEXT_GLOWING_START_SIZE = 1.5f;

			// Token: 0x040141AB RID: 82347
			[Token(Token = "0x40141AB")]
			private const float GOLD_TEXT_UP_DUR = 0.17f;

			// Token: 0x040141AC RID: 82348
			[Token(Token = "0x40141AC")]
			private const float CAN_DRAW_BG_BLINK_ALPHA = 0.3f;

			// Token: 0x040141AD RID: 82349
			[Token(Token = "0x40141AD")]
			private const float CAN_DRAW_BG_BLINK_DUR = 1f;

			// Token: 0x040141AE RID: 82350
			[Token(Token = "0x40141AE")]
			private const float CAN_DRAW_BG_BLINK_END = 2.3f;

			// Token: 0x040141AF RID: 82351
			[Token(Token = "0x40141AF")]
			private const float CAN_DRAW_FADE_OUT_DUR = 0.06f;

			// Token: 0x040141B0 RID: 82352
			[Token(Token = "0x40141B0")]
			private const float GOLD_TEXT_DOWN_START = 0.1f;

			// Token: 0x040141B1 RID: 82353
			[Token(Token = "0x40141B1")]
			private const float GOLD_TEXT_DOWN_DUR = 0.17f;

			// Token: 0x040141B2 RID: 82354
			[Token(Token = "0x40141B2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 GOLD_TEXT_GLOWING_START_POS;

			// Token: 0x040141B3 RID: 82355
			[Token(Token = "0x40141B3")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 GOLD_TEXT_GLOWING_END_POS;

			// Token: 0x040141B4 RID: 82356
			[Token(Token = "0x40141B4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040141B5 RID: 82357
			[Token(Token = "0x40141B5")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayGoldGlowTween;

			// Token: 0x040141B6 RID: 82358
			[Token(Token = "0x40141B6")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_PlayCanDrawTwinkLoopTween;

			// Token: 0x040141B7 RID: 82359
			[Token(Token = "0x40141B7")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_PlayUseGoldNumDownTween;

			// Token: 0x040141B8 RID: 82360
			[Token(Token = "0x40141B8")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x040141B9 RID: 82361
			[Token(Token = "0x40141B9")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_KillTween;
		}

		// Token: 0x02002A13 RID: 10771
		[Token(Token = "0x2002A13")]
		private class HandCardFullTipsTween : IHotfixable
		{
			// Token: 0x06011DDF RID: 73183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DDF")]
			[Address(RVA = "0x9AC690", Offset = "0x9AB290", VA = "0x1809AC690")]
			public HandCardFullTipsTween(UIBattleLegionWidgetsPanel closure)
			{
			}

			// Token: 0x06011DE0 RID: 73184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DE0")]
			[Address(RVA = "0x9ABFE0", Offset = "0x9AABE0", VA = "0x1809ABFE0")]
			public void PlayTween(bool showBlastEffect)
			{
			}

			// Token: 0x06011DE1 RID: 73185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DE1")]
			[Address(RVA = "0x9AC470", Offset = "0x9AB070", VA = "0x1809AC470")]
			public void ResetToState(bool isShow)
			{
			}

			// Token: 0x040141C3 RID: 82371
			[Token(Token = "0x40141C3")]
			[FieldOffset(Offset = "0x10")]
			private UIBattleLegionWidgetsPanel m_closure;

			// Token: 0x040141C4 RID: 82372
			[Token(Token = "0x40141C4")]
			[FieldOffset(Offset = "0x18")]
			private UISwitchTween.TweenWrapper m_tween;

			// Token: 0x040141C5 RID: 82373
			[Token(Token = "0x40141C5")]
			private const float CARD_FULL_TIPS_FADE_IN_START_TIME = 0.2f;

			// Token: 0x040141C6 RID: 82374
			[Token(Token = "0x40141C6")]
			private const float CARD_FULL_TIPS_FADE_DUR = 0.12f;

			// Token: 0x040141C7 RID: 82375
			[Token(Token = "0x40141C7")]
			private const float CARD_FULL_TIPS_SHAKE_START_TIME = 0.26f;

			// Token: 0x040141C8 RID: 82376
			[Token(Token = "0x40141C8")]
			private const float CARD_FULL_TIPS_SHAKE_PER_DUR = 0.08f;

			// Token: 0x040141C9 RID: 82377
			[Token(Token = "0x40141C9")]
			private const int CARD_FULL_TIPS_SHAKE_TIMES = 4;

			// Token: 0x040141CA RID: 82378
			[Token(Token = "0x40141CA")]
			private const float CARD_FULL_TIPS_EFFECT_START_TIME = 0.6f;

			// Token: 0x040141CB RID: 82379
			[Token(Token = "0x40141CB")]
			private const float CARD_FULL_TIPS_FADE_OUT_START_TIME = 1.5f;

			// Token: 0x040141CC RID: 82380
			[Token(Token = "0x40141CC")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 CARD_FULL_TIPS_SHAKE_START;

			// Token: 0x040141CD RID: 82381
			[Token(Token = "0x40141CD")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 CARD_FULL_TIPS_SHAKE_END;

			// Token: 0x040141CE RID: 82382
			[Token(Token = "0x40141CE")]
			[FieldOffset(Offset = "0x20")]
			public Action tweenEndCallBack;

			// Token: 0x040141CF RID: 82383
			[Token(Token = "0x40141CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040141D0 RID: 82384
			[Token(Token = "0x40141D0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayTween;

			// Token: 0x040141D1 RID: 82385
			[Token(Token = "0x40141D1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02002A15 RID: 10773
		[Token(Token = "0x2002A15")]
		private class PendingCardNumChangeTween : UISwitchTween
		{
			// Token: 0x06011DE6 RID: 73190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DE6")]
			[Address(RVA = "0x9B3930", Offset = "0x9B2530", VA = "0x1809B3930")]
			public PendingCardNumChangeTween(UIBattleLegionWidgetsPanel closure)
			{
			}

			// Token: 0x06011DE7 RID: 73191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011DE7")]
			[Address(RVA = "0x9B3570", Offset = "0x9B2170", VA = "0x1809B3570", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06011DE8 RID: 73192 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011DE8")]
			[Address(RVA = "0x9B33F0", Offset = "0x9B1FF0", VA = "0x1809B33F0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06011DE9 RID: 73193 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DE9")]
			[Address(RVA = "0x9B36F0", Offset = "0x9B22F0", VA = "0x1809B36F0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06011DEB RID: 73195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DEB")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040141D5 RID: 82389
			[Token(Token = "0x40141D5")]
			[FieldOffset(Offset = "0x48")]
			private UIBattleLegionWidgetsPanel m_closure;

			// Token: 0x040141D6 RID: 82390
			[Token(Token = "0x40141D6")]
			private const float TIPS_MOVE_START = 0.1f;

			// Token: 0x040141D7 RID: 82391
			[Token(Token = "0x40141D7")]
			private const float TIPS_MOVE_DUR = 0.4f;

			// Token: 0x040141D8 RID: 82392
			[Token(Token = "0x40141D8")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 CARD_GET_TIPS_START;

			// Token: 0x040141D9 RID: 82393
			[Token(Token = "0x40141D9")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 CARD_GET_TIPS_END;

			// Token: 0x040141DA RID: 82394
			[Token(Token = "0x40141DA")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Quaternion CARD_END_REVERSE_ROTATION;

			// Token: 0x040141DB RID: 82395
			[Token(Token = "0x40141DB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040141DC RID: 82396
			[Token(Token = "0x40141DC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040141DD RID: 82397
			[Token(Token = "0x40141DD")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040141DE RID: 82398
			[Token(Token = "0x40141DE")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02002A16 RID: 10774
		[Token(Token = "0x2002A16")]
		private class UsedCardNumChangeTween : UISwitchTween
		{
			// Token: 0x06011DEC RID: 73196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DEC")]
			[Address(RVA = "0x9BFBE0", Offset = "0x9BE7E0", VA = "0x1809BFBE0")]
			public UsedCardNumChangeTween(UIBattleLegionWidgetsPanel closure)
			{
			}

			// Token: 0x06011DED RID: 73197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011DED")]
			[Address(RVA = "0x9BF830", Offset = "0x9BE430", VA = "0x1809BF830", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06011DEE RID: 73198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011DEE")]
			[Address(RVA = "0x9BF6B0", Offset = "0x9BE2B0", VA = "0x1809BF6B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06011DEF RID: 73199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DEF")]
			[Address(RVA = "0x9BF9B0", Offset = "0x9BE5B0", VA = "0x1809BF9B0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06011DF1 RID: 73201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DF1")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040141DF RID: 82399
			[Token(Token = "0x40141DF")]
			[FieldOffset(Offset = "0x48")]
			private UIBattleLegionWidgetsPanel m_closure;

			// Token: 0x040141E0 RID: 82400
			[Token(Token = "0x40141E0")]
			private const float TIPS_MOVE_START = 0.1f;

			// Token: 0x040141E1 RID: 82401
			[Token(Token = "0x40141E1")]
			private const float TIPS_MOVE_DUR = 0.4f;

			// Token: 0x040141E2 RID: 82402
			[Token(Token = "0x40141E2")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 CARD_GET_TIPS_START;

			// Token: 0x040141E3 RID: 82403
			[Token(Token = "0x40141E3")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 CARD_GET_TIPS_END;

			// Token: 0x040141E4 RID: 82404
			[Token(Token = "0x40141E4")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Quaternion CARD_END_REVERSE_ROTATION;

			// Token: 0x040141E5 RID: 82405
			[Token(Token = "0x40141E5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040141E6 RID: 82406
			[Token(Token = "0x40141E6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040141E7 RID: 82407
			[Token(Token = "0x40141E7")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040141E8 RID: 82408
			[Token(Token = "0x40141E8")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
