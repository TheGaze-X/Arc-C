using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005468 RID: 21608
	[Token(Token = "0x2005468")]
	public abstract class RoguelikeCharCardDecoPanelPluginBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004A98 RID: 19096
		// (get) Token: 0x0601FCE6 RID: 130278
		[Token(Token = "0x17004A98")]
		public abstract RoguelikeCharCardDecoPanelPluginBase.DecoLayer decoLayer { [Token(Token = "0x601FCE6")] get; }

		// Token: 0x0601FCE7 RID: 130279
		[Token(Token = "0x601FCE7")]
		public abstract void Render(string topicId, RoguelikeCharCardDecoPanelPluginBase.RoguelikeCharCardDecoInput decoInput);

		// Token: 0x0601FCE8 RID: 130280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FCE8")]
		[Address(RVA = "0x19E74F0", Offset = "0x19E60F0", VA = "0x1819E74F0")]
		protected RoguelikeCharCardDecoPanelPluginBase()
		{
		}

		// Token: 0x0402ADBB RID: 175547
		[Token(Token = "0x402ADBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005469 RID: 21609
		[Token(Token = "0x2005469")]
		public class RoguelikeCharCardDecoInput : IHotfixable
		{
			// Token: 0x0601FCE9 RID: 130281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FCE9")]
			[Address(RVA = "0x19E7490", Offset = "0x19E6090", VA = "0x1819E7490")]
			public RoguelikeCharCardDecoInput()
			{
			}

			// Token: 0x0402ADBC RID: 175548
			[Token(Token = "0x402ADBC")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeCharCardViewModel charCardViewModel;

			// Token: 0x0402ADBD RID: 175549
			[Token(Token = "0x402ADBD")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeCharSelectStateBean.ShowConfig showConfig;

			// Token: 0x0402ADBE RID: 175550
			[Token(Token = "0x402ADBE")]
			[FieldOffset(Offset = "0x1A")]
			public bool isSelect;

			// Token: 0x0402ADBF RID: 175551
			[Token(Token = "0x402ADBF")]
			[FieldOffset(Offset = "0x1C")]
			public int selectIndex;

			// Token: 0x0402ADC0 RID: 175552
			[Token(Token = "0x402ADC0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200546A RID: 21610
		[Token(Token = "0x200546A")]
		public enum DecoLayer
		{
			// Token: 0x0402ADC2 RID: 175554
			[Token(Token = "0x402ADC2")]
			NONE,
			// Token: 0x0402ADC3 RID: 175555
			[Token(Token = "0x402ADC3")]
			BOTTOM = 100,
			// Token: 0x0402ADC4 RID: 175556
			[Token(Token = "0x402ADC4")]
			UPTYPE = 800,
			// Token: 0x0402ADC5 RID: 175557
			[Token(Token = "0x402ADC5")]
			TOP = 1000
		}
	}
}
