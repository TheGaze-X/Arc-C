using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x0200468D RID: 18061
	[Token(Token = "0x200468D")]
	public class RoguelikeTopicEndingSPOperatorGainExpView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x0601B6A3 RID: 112291 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B6A4 RID: 112292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700414C")]
		public RoguelikeTopicEndingStyle style
		{
			[Token(Token = "0x601B6A3")]
			[Address(RVA = "0x14B6910", Offset = "0x14B5510", VA = "0x1814B6910")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B6A4")]
			[Address(RVA = "0x14B6970", Offset = "0x14B5570", VA = "0x1814B6970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B6A5 RID: 112293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A5")]
		[Address(RVA = "0x14B6620", Offset = "0x14B5220", VA = "0x1814B6620")]
		public void Render(RoguelikeTopicEndingSPOperatorViewModel model)
		{
		}

		// Token: 0x0601B6A6 RID: 112294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6A6")]
		[Address(RVA = "0x14B68B0", Offset = "0x14B54B0", VA = "0x1814B68B0")]
		public RoguelikeTopicEndingSPOperatorGainExpView()
		{
		}

		// Token: 0x0402374C RID: 145228
		[Token(Token = "0x402374C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x0402374D RID: 145229
		[Token(Token = "0x402374D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _gainExpText;

		// Token: 0x0402374F RID: 145231
		[Token(Token = "0x402374F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_style;

		// Token: 0x04023750 RID: 145232
		[Token(Token = "0x4023750")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_style;

		// Token: 0x04023751 RID: 145233
		[Token(Token = "0x4023751")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023752 RID: 145234
		[Token(Token = "0x4023752")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
