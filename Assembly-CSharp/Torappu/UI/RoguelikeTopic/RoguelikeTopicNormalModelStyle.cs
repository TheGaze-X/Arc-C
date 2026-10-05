using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004562 RID: 17762
	[Token(Token = "0x2004562")]
	[CreateAssetMenu(menuName = "Torappu/Roguelike/NormalModeStyle")]
	public class RoguelikeTopicNormalModelStyle : RoguelikeTopicStyle
	{
		// Token: 0x17004080 RID: 16512
		// (get) Token: 0x0601B115 RID: 110869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004080")]
		public Sprite easyDiffRelicIcon
		{
			[Token(Token = "0x601B115")]
			[Address(RVA = "0x143D720", Offset = "0x143C320", VA = "0x18143D720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004081 RID: 16513
		// (get) Token: 0x0601B116 RID: 110870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004081")]
		public Sprite normalDiffRelicIcon
		{
			[Token(Token = "0x601B116")]
			[Address(RVA = "0x143D7E0", Offset = "0x143C3E0", VA = "0x18143D7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004082 RID: 16514
		// (get) Token: 0x0601B117 RID: 110871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004082")]
		public Sprite hardDiffRelicIcon
		{
			[Token(Token = "0x601B117")]
			[Address(RVA = "0x143D780", Offset = "0x143C380", VA = "0x18143D780")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B118 RID: 110872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B118")]
		[Address(RVA = "0x143D680", Offset = "0x143C280", VA = "0x18143D680")]
		public RoguelikeTopicNormalModelStyle()
		{
		}

		// Token: 0x04022C9F RID: 142495
		[Token(Token = "0x4022C9F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Difficulty Detail")]
		private Sprite _easyDiffRelicIcon;

		// Token: 0x04022CA0 RID: 142496
		[Token(Token = "0x4022CA0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Difficulty Detail")]
		private Sprite _normalDiffRelicIcon;

		// Token: 0x04022CA1 RID: 142497
		[Token(Token = "0x4022CA1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Difficulty Detail")]
		private Sprite _hardDiffRelicIcon;

		// Token: 0x04022CA2 RID: 142498
		[Token(Token = "0x4022CA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_easyDiffRelicIcon;

		// Token: 0x04022CA3 RID: 142499
		[Token(Token = "0x4022CA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_normalDiffRelicIcon;

		// Token: 0x04022CA4 RID: 142500
		[Token(Token = "0x4022CA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hardDiffRelicIcon;

		// Token: 0x04022CA5 RID: 142501
		[Token(Token = "0x4022CA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
