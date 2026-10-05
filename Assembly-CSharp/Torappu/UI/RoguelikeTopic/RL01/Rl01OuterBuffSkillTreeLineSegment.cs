using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004656 RID: 18006
	[Token(Token = "0x2004656")]
	public class Rl01OuterBuffSkillTreeLineSegment : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x0601B571 RID: 111985 RVA: 0x000A4E50 File Offset: 0x000A3050
		// (set) Token: 0x0601B572 RID: 111986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700411A")]
		public Rl01OuterBuffSkillTreeLineType lineType
		{
			[Token(Token = "0x601B571")]
			[Address(RVA = "0x14A6DF0", Offset = "0x14A59F0", VA = "0x1814A6DF0")]
			private get
			{
				return Rl01OuterBuffSkillTreeLineType.HORIZONTAL;
			}
			[Token(Token = "0x601B572")]
			[Address(RVA = "0x14A6F40", Offset = "0x14A5B40", VA = "0x1814A6F40")]
			set
			{
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x0601B573 RID: 111987 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B574 RID: 111988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700411B")]
		public Image lineImg
		{
			[Token(Token = "0x601B573")]
			[Address(RVA = "0x14A6D90", Offset = "0x14A5990", VA = "0x1814A6D90")]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B574")]
			[Address(RVA = "0x14A6EC0", Offset = "0x14A5AC0", VA = "0x1814A6EC0")]
			set
			{
			}
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x0601B575 RID: 111989 RVA: 0x000A4E68 File Offset: 0x000A3068
		// (set) Token: 0x0601B576 RID: 111990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700411C")]
		public int length
		{
			[Token(Token = "0x601B575")]
			[Address(RVA = "0x14A6D30", Offset = "0x14A5930", VA = "0x1814A6D30")]
			private get
			{
				return 0;
			}
			[Token(Token = "0x601B576")]
			[Address(RVA = "0x14A6E50", Offset = "0x14A5A50", VA = "0x1814A6E50")]
			set
			{
			}
		}

		// Token: 0x0601B577 RID: 111991 RVA: 0x000A4E80 File Offset: 0x000A3080
		[Token(Token = "0x601B577")]
		[Address(RVA = "0x14A6780", Offset = "0x14A5380", VA = "0x1814A6780")]
		public float SetShow(bool show, float delay, bool isInit)
		{
			return 0f;
		}

		// Token: 0x0601B578 RID: 111992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B578")]
		[Address(RVA = "0x14A6AD0", Offset = "0x14A56D0", VA = "0x1814A6AD0")]
		private Tween _GenerateTween(float delay)
		{
			return null;
		}

		// Token: 0x0601B579 RID: 111993 RVA: 0x000A4E98 File Offset: 0x000A3098
		[Token(Token = "0x601B579")]
		[Address(RVA = "0x14A66B0", Offset = "0x14A52B0", VA = "0x1814A66B0")]
		public float GetDelay()
		{
			return 0f;
		}

		// Token: 0x0601B57A RID: 111994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B57A")]
		[Address(RVA = "0x14A6CD0", Offset = "0x14A58D0", VA = "0x1814A6CD0")]
		public Rl01OuterBuffSkillTreeLineSegment()
		{
		}

		// Token: 0x04023528 RID: 144680
		[Token(Token = "0x4023528")]
		private const int LINE_WIDTH = 5;

		// Token: 0x04023529 RID: 144681
		[Token(Token = "0x4023529")]
		private const float LINE_VELOCITY = 1487.5f;

		// Token: 0x0402352A RID: 144682
		[Token(Token = "0x402352A")]
		private const float POINT_LIGHT_DURATION = 0.02f;

		// Token: 0x0402352B RID: 144683
		[Token(Token = "0x402352B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rl01OuterBuffSkillTreeLineType _lineType;

		// Token: 0x0402352C RID: 144684
		[Token(Token = "0x402352C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _lineImg;

		// Token: 0x0402352D RID: 144685
		[Token(Token = "0x402352D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _length;

		// Token: 0x0402352E RID: 144686
		[Token(Token = "0x402352E")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_cachedShow;

		// Token: 0x0402352F RID: 144687
		[Token(Token = "0x402352F")]
		[FieldOffset(Offset = "0x30")]
		private Tween m_tween;

		// Token: 0x04023530 RID: 144688
		[Token(Token = "0x4023530")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lineType;

		// Token: 0x04023531 RID: 144689
		[Token(Token = "0x4023531")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_lineType;

		// Token: 0x04023532 RID: 144690
		[Token(Token = "0x4023532")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lineImg;

		// Token: 0x04023533 RID: 144691
		[Token(Token = "0x4023533")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_lineImg;

		// Token: 0x04023534 RID: 144692
		[Token(Token = "0x4023534")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_length;

		// Token: 0x04023535 RID: 144693
		[Token(Token = "0x4023535")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_length;

		// Token: 0x04023536 RID: 144694
		[Token(Token = "0x4023536")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x04023537 RID: 144695
		[Token(Token = "0x4023537")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateTween;

		// Token: 0x04023538 RID: 144696
		[Token(Token = "0x4023538")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetDelay;

		// Token: 0x04023539 RID: 144697
		[Token(Token = "0x4023539")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
