using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.UI
{
	// Token: 0x02003385 RID: 13189
	[Token(Token = "0x2003385")]
	public class UIHueGradientFollowSlider : UIFollowSlider
	{
		// Token: 0x06015090 RID: 86160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015090")]
		[Address(RVA = "0xD77270", Offset = "0xD75E70", VA = "0x180D77270", Slot = "4")]
		public override void SetSliderColorByProgress(float progress)
		{
		}

		// Token: 0x06015091 RID: 86161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015091")]
		[Address(RVA = "0xD77510", Offset = "0xD76110", VA = "0x180D77510")]
		public UIHueGradientFollowSlider()
		{
		}

		// Token: 0x04019088 RID: 102536
		[Token(Token = "0x4019088")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<UIHueGradientFollowSlider.keyColor> keyColors;

		// Token: 0x02003386 RID: 13190
		[Token(Token = "0x2003386")]
		[Serializable]
		private struct keyColor
		{
			// Token: 0x04019089 RID: 102537
			[Token(Token = "0x4019089")]
			[FieldOffset(Offset = "0x0")]
			public float progress;

			// Token: 0x0401908A RID: 102538
			[Token(Token = "0x401908A")]
			[FieldOffset(Offset = "0x4")]
			public Color color;
		}
	}
}
