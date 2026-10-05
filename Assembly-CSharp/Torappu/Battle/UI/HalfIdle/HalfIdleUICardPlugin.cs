using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.HalfIdle
{
	// Token: 0x02003422 RID: 13346
	[Token(Token = "0x2003422")]
	public class HalfIdleUICardPlugin : BattleReusableUI, UICard.IUICardPlugin, IReusableObject, IReusable, IPtrObject
	{
		// Token: 0x17003285 RID: 12933
		// (get) Token: 0x06015589 RID: 87433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003285")]
		public string pluginId
		{
			[Token(Token = "0x6015589")]
			[Address(RVA = "0xDCFD90", Offset = "0xDCE990", VA = "0x180DCFD90", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0601558A RID: 87434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003286")]
		private GameModeFactory.HalfIdleGameMode gameMode
		{
			[Token(Token = "0x601558A")]
			[Address(RVA = "0xDCFC80", Offset = "0xDCE880", VA = "0x180DCFC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601558B RID: 87435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601558B")]
		[Address(RVA = "0xDCF190", Offset = "0xDCDD90", VA = "0x180DCF190", Slot = "12")]
		public void OnAppearanceRefresh(UICard card)
		{
		}

		// Token: 0x0601558C RID: 87436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601558C")]
		[Address(RVA = "0xDCF380", Offset = "0xDCDF80", VA = "0x180DCF380")]
		private void OnDisable()
		{
		}

		// Token: 0x0601558D RID: 87437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601558D")]
		[Address(RVA = "0xDCF3E0", Offset = "0xDCDFE0", VA = "0x180DCF3E0", Slot = "14")]
		public void OnInit(UICard uiCard)
		{
		}

		// Token: 0x0601558E RID: 87438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601558E")]
		[Address(RVA = "0xDCF590", Offset = "0xDCE190", VA = "0x180DCF590", Slot = "13")]
		public void OnRender(UICard card)
		{
		}

		// Token: 0x0601558F RID: 87439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601558F")]
		[Address(RVA = "0xDCF130", Offset = "0xDCDD30", VA = "0x180DCF130", Slot = "16")]
		public MonoBehaviour GetRootMono()
		{
			return null;
		}

		// Token: 0x06015590 RID: 87440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015590")]
		[Address(RVA = "0xDCF280", Offset = "0xDCDE80", VA = "0x180DCF280", Slot = "15")]
		public void OnBlink(UICard uiCard)
		{
		}

		// Token: 0x06015591 RID: 87441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015591")]
		[Address(RVA = "0xDCFAF0", Offset = "0xDCE6F0", VA = "0x180DCFAF0")]
		private void _Reset()
		{
		}

		// Token: 0x06015592 RID: 87442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015592")]
		[Address(RVA = "0xDCF790", Offset = "0xDCE390", VA = "0x180DCF790")]
		private void _InitIfNot(UICard uiCard)
		{
		}

		// Token: 0x06015593 RID: 87443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015593")]
		[Address(RVA = "0xDCFC20", Offset = "0xDCE820", VA = "0x180DCFC20")]
		public HalfIdleUICardPlugin()
		{
		}

		// Token: 0x0401988C RID: 104588
		[Token(Token = "0x401988C")]
		private const string PLUGIN_ID = "HalfIdleUICardPlugin";

		// Token: 0x0401988D RID: 104589
		[Token(Token = "0x401988D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pluginRoot;

		// Token: 0x0401988E RID: 104590
		[Token(Token = "0x401988E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _trapFullImg;

		// Token: 0x0401988F RID: 104591
		[Token(Token = "0x401988F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _gainNewCardAnim;

		// Token: 0x04019890 RID: 104592
		[Token(Token = "0x4019890")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _cardNumMaxAnim;

		// Token: 0x04019891 RID: 104593
		[Token(Token = "0x4019891")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _cardNumIncreaseAnim;

		// Token: 0x04019892 RID: 104594
		[Token(Token = "0x4019892")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<HalfIdleUICardPlugin.HalfIdlePlotIconData> _plotCardIcons;

		// Token: 0x04019893 RID: 104595
		[Token(Token = "0x4019893")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedCardNum;

		// Token: 0x04019894 RID: 104596
		[Token(Token = "0x4019894")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_isCardNumIncreaseTween;

		// Token: 0x04019895 RID: 104597
		[Token(Token = "0x4019895")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_isCardFullTween;

		// Token: 0x04019896 RID: 104598
		[Token(Token = "0x4019896")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04019897 RID: 104599
		[Token(Token = "0x4019897")]
		[FieldOffset(Offset = "0x81")]
		private bool m_isTrapCard;

		// Token: 0x04019898 RID: 104600
		[Token(Token = "0x4019898")]
		[FieldOffset(Offset = "0x84")]
		private uint m_cachedCardUid;

		// Token: 0x04019899 RID: 104601
		[Token(Token = "0x4019899")]
		[FieldOffset(Offset = "0x88")]
		private bool m_cachedIsFull;

		// Token: 0x0401989A RID: 104602
		[Token(Token = "0x401989A")]
		[FieldOffset(Offset = "0x90")]
		private HalfIdleUICardPlugin.HalfIdlePlotIconData m_cachedPlotIconData;

		// Token: 0x0401989B RID: 104603
		[Token(Token = "0x401989B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginId;

		// Token: 0x0401989C RID: 104604
		[Token(Token = "0x401989C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x0401989D RID: 104605
		[Token(Token = "0x401989D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAppearanceRefresh;

		// Token: 0x0401989E RID: 104606
		[Token(Token = "0x401989E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401989F RID: 104607
		[Token(Token = "0x401989F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040198A0 RID: 104608
		[Token(Token = "0x40198A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040198A1 RID: 104609
		[Token(Token = "0x40198A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetRootMono;

		// Token: 0x040198A2 RID: 104610
		[Token(Token = "0x40198A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBlink;

		// Token: 0x040198A3 RID: 104611
		[Token(Token = "0x40198A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x040198A4 RID: 104612
		[Token(Token = "0x40198A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040198A5 RID: 104613
		[Token(Token = "0x40198A5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003423 RID: 13347
		[Token(Token = "0x2003423")]
		[Serializable]
		private class HalfIdlePlotIconData
		{
			// Token: 0x06015594 RID: 87444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015594")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HalfIdlePlotIconData()
			{
			}

			// Token: 0x040198A6 RID: 104614
			[Token(Token = "0x40198A6")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdlePlotType type;

			// Token: 0x040198A7 RID: 104615
			[Token(Token = "0x40198A7")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x040198A8 RID: 104616
			[Token(Token = "0x40198A8")]
			[FieldOffset(Offset = "0x20")]
			public Color color;
		}
	}
}
