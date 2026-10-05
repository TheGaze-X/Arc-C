using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D0F RID: 32015
	[Token(Token = "0x2007D0F")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Vintage (Deprecated)")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/vintage.html")]
	public class Vintage : LookupFilter
	{
		// Token: 0x0602CA68 RID: 182888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA68")]
		[Address(RVA = "0x2883820", Offset = "0x2882420", VA = "0x182883820", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA69 RID: 182889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA69")]
		[Address(RVA = "0xFD3E40", Offset = "0xFD2A40", VA = "0x180FD3E40")]
		public Vintage()
		{
		}

		// Token: 0x04040564 RID: 263524
		[Token(Token = "0x4040564")]
		[FieldOffset(Offset = "0x38")]
		public Vintage.InstragramFilter Filter;

		// Token: 0x04040565 RID: 263525
		[Token(Token = "0x4040565")]
		[FieldOffset(Offset = "0x3C")]
		protected Vintage.InstragramFilter m_CurrentFilter;

		// Token: 0x02007D10 RID: 32016
		[Token(Token = "0x2007D10")]
		public enum InstragramFilter
		{
			// Token: 0x04040567 RID: 263527
			[Token(Token = "0x4040567")]
			None,
			// Token: 0x04040568 RID: 263528
			[Token(Token = "0x4040568")]
			F1977,
			// Token: 0x04040569 RID: 263529
			[Token(Token = "0x4040569")]
			Aden,
			// Token: 0x0404056A RID: 263530
			[Token(Token = "0x404056A")]
			Amaro,
			// Token: 0x0404056B RID: 263531
			[Token(Token = "0x404056B")]
			Brannan,
			// Token: 0x0404056C RID: 263532
			[Token(Token = "0x404056C")]
			Crema,
			// Token: 0x0404056D RID: 263533
			[Token(Token = "0x404056D")]
			Earlybird,
			// Token: 0x0404056E RID: 263534
			[Token(Token = "0x404056E")]
			Hefe,
			// Token: 0x0404056F RID: 263535
			[Token(Token = "0x404056F")]
			Hudson,
			// Token: 0x04040570 RID: 263536
			[Token(Token = "0x4040570")]
			Inkwell,
			// Token: 0x04040571 RID: 263537
			[Token(Token = "0x4040571")]
			Juno,
			// Token: 0x04040572 RID: 263538
			[Token(Token = "0x4040572")]
			Kelvin,
			// Token: 0x04040573 RID: 263539
			[Token(Token = "0x4040573")]
			Lark,
			// Token: 0x04040574 RID: 263540
			[Token(Token = "0x4040574")]
			LoFi,
			// Token: 0x04040575 RID: 263541
			[Token(Token = "0x4040575")]
			Ludwig,
			// Token: 0x04040576 RID: 263542
			[Token(Token = "0x4040576")]
			Mayfair,
			// Token: 0x04040577 RID: 263543
			[Token(Token = "0x4040577")]
			Nashville,
			// Token: 0x04040578 RID: 263544
			[Token(Token = "0x4040578")]
			Perpetua,
			// Token: 0x04040579 RID: 263545
			[Token(Token = "0x4040579")]
			Reyes,
			// Token: 0x0404057A RID: 263546
			[Token(Token = "0x404057A")]
			Rise,
			// Token: 0x0404057B RID: 263547
			[Token(Token = "0x404057B")]
			Sierra,
			// Token: 0x0404057C RID: 263548
			[Token(Token = "0x404057C")]
			Slumber,
			// Token: 0x0404057D RID: 263549
			[Token(Token = "0x404057D")]
			Sutro,
			// Token: 0x0404057E RID: 263550
			[Token(Token = "0x404057E")]
			Toaster,
			// Token: 0x0404057F RID: 263551
			[Token(Token = "0x404057F")]
			Valencia,
			// Token: 0x04040580 RID: 263552
			[Token(Token = "0x4040580")]
			Walden,
			// Token: 0x04040581 RID: 263553
			[Token(Token = "0x4040581")]
			Willow,
			// Token: 0x04040582 RID: 263554
			[Token(Token = "0x4040582")]
			XProII
		}
	}
}
