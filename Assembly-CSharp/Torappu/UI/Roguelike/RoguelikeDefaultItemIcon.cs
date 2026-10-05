using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051CF RID: 20943
	[Token(Token = "0x20051CF")]
	public class RoguelikeDefaultItemIcon : RoguelikeCustomizableItemIcon
	{
		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x0601EEF0 RID: 126704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700483B")]
		public override Graphic graphic
		{
			[Token(Token = "0x601EEF0")]
			[Address(RVA = "0x18B1870", Offset = "0x18B0470", VA = "0x1818B1870", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EEF1 RID: 126705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF1")]
		[Address(RVA = "0x18B16A0", Offset = "0x18B02A0", VA = "0x1818B16A0", Slot = "5")]
		public override void Render(string topicId, string itemId, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x0601EEF2 RID: 126706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EEF2")]
		[Address(RVA = "0x18B17D0", Offset = "0x18B03D0", VA = "0x1818B17D0")]
		public RoguelikeDefaultItemIcon()
		{
		}

		// Token: 0x0402981C RID: 170012
		[Token(Token = "0x402981C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _itemIconImage;

		// Token: 0x0402981D RID: 170013
		[Token(Token = "0x402981D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0402981E RID: 170014
		[Token(Token = "0x402981E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402981F RID: 170015
		[Token(Token = "0x402981F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
