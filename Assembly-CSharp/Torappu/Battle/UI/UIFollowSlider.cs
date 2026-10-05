using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x02003382 RID: 13186
	[Token(Token = "0x2003382")]
	public class UIFollowSlider : UITextSlider
	{
		// Token: 0x06015084 RID: 86148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015084")]
		[Address(RVA = "0xD71B80", Offset = "0xD70780", VA = "0x180D71B80")]
		private void Update()
		{
		}

		// Token: 0x06015085 RID: 86149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015085")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public UIFollowSlider()
		{
		}

		// Token: 0x04019079 RID: 102521
		[Token(Token = "0x4019079")]
		private const float BACK_FOLLOW_THRESHOLD = 0.02f;

		// Token: 0x0401907A RID: 102522
		[Token(Token = "0x401907A")]
		private const float BACK_FOLLOW_SPEED = 5f;

		// Token: 0x0401907B RID: 102523
		[Token(Token = "0x401907B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _backSlider;

		// Token: 0x0401907C RID: 102524
		[Token(Token = "0x401907C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _appendBackSliderToEnd;

		// Token: 0x0401907D RID: 102525
		[Token(Token = "0x401907D")]
		[FieldOffset(Offset = "0x44")]
		private float m_backSliderActualValue;
	}
}
