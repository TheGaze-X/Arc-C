using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004561 RID: 17761
	[Token(Token = "0x2004561")]
	[CreateAssetMenu(menuName = "Torappu/Roguelike/MonthModeStyle")]
	public class RoguelikeTopicMonthModelStyle : RoguelikeTopicStyle
	{
		// Token: 0x1700407E RID: 16510
		// (get) Token: 0x0601B112 RID: 110866 RVA: 0x000A4268 File Offset: 0x000A2468
		[Token(Token = "0x1700407E")]
		public Color bkgArchiveColor
		{
			[Token(Token = "0x601B112")]
			[Address(RVA = "0x143C130", Offset = "0x143AD30", VA = "0x18143C130")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700407F RID: 16511
		// (get) Token: 0x0601B113 RID: 110867 RVA: 0x000A4280 File Offset: 0x000A2480
		[Token(Token = "0x1700407F")]
		public Color bkgAwardColor
		{
			[Token(Token = "0x601B113")]
			[Address(RVA = "0x143C1B0", Offset = "0x143ADB0", VA = "0x18143C1B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0601B114 RID: 110868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B114")]
		[Address(RVA = "0x143C090", Offset = "0x143AC90", VA = "0x18143C090")]
		public RoguelikeTopicMonthModelStyle()
		{
		}

		// Token: 0x04022C9A RID: 142490
		[Token(Token = "0x4022C9A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Month Squad")]
		private Color _bkgArchiveColor;

		// Token: 0x04022C9B RID: 142491
		[Token(Token = "0x4022C9B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Month Squad")]
		private Color _bkgAwardColor;

		// Token: 0x04022C9C RID: 142492
		[Token(Token = "0x4022C9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bkgArchiveColor;

		// Token: 0x04022C9D RID: 142493
		[Token(Token = "0x4022C9D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_bkgAwardColor;

		// Token: 0x04022C9E RID: 142494
		[Token(Token = "0x4022C9E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
