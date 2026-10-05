using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033E2 RID: 13282
	[Token(Token = "0x20033E2")]
	public class UICooperateHintPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015341 RID: 86849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015341")]
		[Address(RVA = "0xDA6010", Offset = "0xDA4C10", VA = "0x180DA6010")]
		public void OnInit()
		{
		}

		// Token: 0x06015342 RID: 86850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015342")]
		[Address(RVA = "0xDA6580", Offset = "0xDA5180", VA = "0x180DA6580")]
		private void Update()
		{
		}

		// Token: 0x06015343 RID: 86851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015343")]
		[Address(RVA = "0xDA6670", Offset = "0xDA5270", VA = "0x180DA6670")]
		private void _ActiveHint(UICooperateHintPanel.HintOptions option)
		{
		}

		// Token: 0x06015344 RID: 86852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015344")]
		[Address(RVA = "0xDA6360", Offset = "0xDA4F60", VA = "0x180DA6360")]
		public void ShowHint(UICooperateHintPanel.HintType type)
		{
		}

		// Token: 0x06015345 RID: 86853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015345")]
		[Address(RVA = "0xDA5E80", Offset = "0xDA4A80", VA = "0x180DA5E80")]
		public void HideHint(UICooperateHintPanel.HintType type)
		{
		}

		// Token: 0x06015346 RID: 86854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015346")]
		[Address(RVA = "0xDA68B0", Offset = "0xDA54B0", VA = "0x180DA68B0")]
		public UICooperateHintPanel()
		{
		}

		// Token: 0x040194E9 RID: 103657
		[Token(Token = "0x40194E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _hintRect;

		// Token: 0x040194EA RID: 103658
		[Token(Token = "0x40194EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _hintText;

		// Token: 0x040194EB RID: 103659
		[Token(Token = "0x40194EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _infoText;

		// Token: 0x040194EC RID: 103660
		[Token(Token = "0x40194EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _targetPosOffset;

		// Token: 0x040194ED RID: 103661
		[Token(Token = "0x40194ED")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _infoPosOffset;

		// Token: 0x040194EE RID: 103662
		[Token(Token = "0x40194EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<UICooperateHintPanel.HintOptions> _hints;

		// Token: 0x040194EF RID: 103663
		[Token(Token = "0x40194EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<UICooperateHintPanel.HintStyleRect> _hintStyles;

		// Token: 0x040194F0 RID: 103664
		[Token(Token = "0x40194F0")]
		[FieldOffset(Offset = "0x48")]
		private UICooperateHintPanel.HintType m_curHint;

		// Token: 0x040194F1 RID: 103665
		[Token(Token = "0x40194F1")]
		[FieldOffset(Offset = "0x4C")]
		private float m_curDuration;

		// Token: 0x040194F2 RID: 103666
		[Token(Token = "0x40194F2")]
		[FieldOffset(Offset = "0x50")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x040194F3 RID: 103667
		[Token(Token = "0x40194F3")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_originPos;

		// Token: 0x040194F4 RID: 103668
		[Token(Token = "0x40194F4")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_fixPos;

		// Token: 0x040194F5 RID: 103669
		[Token(Token = "0x40194F5")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_fixInfoPos;

		// Token: 0x040194F6 RID: 103670
		[Token(Token = "0x40194F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040194F7 RID: 103671
		[Token(Token = "0x40194F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040194F8 RID: 103672
		[Token(Token = "0x40194F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ActiveHint;

		// Token: 0x040194F9 RID: 103673
		[Token(Token = "0x40194F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowHint;

		// Token: 0x040194FA RID: 103674
		[Token(Token = "0x40194FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideHint;

		// Token: 0x040194FB RID: 103675
		[Token(Token = "0x40194FB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020033E3 RID: 13283
		[Token(Token = "0x20033E3")]
		public enum HintType
		{
			// Token: 0x040194FD RID: 103677
			[Token(Token = "0x40194FD")]
			NONE,
			// Token: 0x040194FE RID: 103678
			[Token(Token = "0x40194FE")]
			PAUSE_WAIT,
			// Token: 0x040194FF RID: 103679
			[Token(Token = "0x40194FF")]
			PAUSE_REFUSE,
			// Token: 0x04019500 RID: 103680
			[Token(Token = "0x4019500")]
			PAUSE_IGNORE,
			// Token: 0x04019501 RID: 103681
			[Token(Token = "0x4019501")]
			PAUSE_REQUEST,
			// Token: 0x04019502 RID: 103682
			[Token(Token = "0x4019502")]
			MATE_OFFLINE,
			// Token: 0x04019503 RID: 103683
			[Token(Token = "0x4019503")]
			MATE_TIME_OUT,
			// Token: 0x04019504 RID: 103684
			[Token(Token = "0x4019504")]
			MATE_RECONNECT,
			// Token: 0x04019505 RID: 103685
			[Token(Token = "0x4019505")]
			MATE_EXIT
		}

		// Token: 0x020033E4 RID: 13284
		[Token(Token = "0x20033E4")]
		public enum HintStyle
		{
			// Token: 0x04019507 RID: 103687
			[Token(Token = "0x4019507")]
			NONE,
			// Token: 0x04019508 RID: 103688
			[Token(Token = "0x4019508")]
			RED,
			// Token: 0x04019509 RID: 103689
			[Token(Token = "0x4019509")]
			BLACK,
			// Token: 0x0401950A RID: 103690
			[Token(Token = "0x401950A")]
			GREY
		}

		// Token: 0x020033E5 RID: 13285
		[Token(Token = "0x20033E5")]
		[Serializable]
		public struct HintStyleRect
		{
			// Token: 0x0401950B RID: 103691
			[Token(Token = "0x401950B")]
			[FieldOffset(Offset = "0x0")]
			public UICooperateHintPanel.HintStyle style;

			// Token: 0x0401950C RID: 103692
			[Token(Token = "0x401950C")]
			[FieldOffset(Offset = "0x8")]
			public RectTransform rect;
		}

		// Token: 0x020033E6 RID: 13286
		[Token(Token = "0x20033E6")]
		[Serializable]
		private class HintOptions
		{
			// Token: 0x06015347 RID: 86855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015347")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HintOptions()
			{
			}

			// Token: 0x0401950D RID: 103693
			[Token(Token = "0x401950D")]
			[FieldOffset(Offset = "0x10")]
			public UICooperateHintPanel.HintType type;

			// Token: 0x0401950E RID: 103694
			[Token(Token = "0x401950E")]
			[FieldOffset(Offset = "0x14")]
			public UICooperateHintPanel.HintStyle hintStyle;

			// Token: 0x0401950F RID: 103695
			[Token(Token = "0x401950F")]
			[FieldOffset(Offset = "0x18")]
			public UICooperateHintPanel.HintStyle infoStyle;

			// Token: 0x04019510 RID: 103696
			[Token(Token = "0x4019510")]
			[FieldOffset(Offset = "0x1C")]
			public float duration;

			// Token: 0x04019511 RID: 103697
			[Token(Token = "0x4019511")]
			[FieldOffset(Offset = "0x20")]
			public string hintTextMap;

			// Token: 0x04019512 RID: 103698
			[Token(Token = "0x4019512")]
			[FieldOffset(Offset = "0x28")]
			public string infoTextMap;

			// Token: 0x04019513 RID: 103699
			[Token(Token = "0x4019513")]
			[FieldOffset(Offset = "0x30")]
			public string hintText;

			// Token: 0x04019514 RID: 103700
			[Token(Token = "0x4019514")]
			[FieldOffset(Offset = "0x38")]
			public string infoText;
		}
	}
}
