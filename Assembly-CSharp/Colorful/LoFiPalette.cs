using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CF4 RID: 31988
	[Token(Token = "0x2007CF4")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/lofi-palette.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Artistic Effects/LoFi Palette")]
	public class LoFiPalette : LookupFilter3D
	{
		// Token: 0x0602CA1A RID: 182810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA1A")]
		[Address(RVA = "0x287F1D0", Offset = "0x287DDD0", VA = "0x18287F1D0", Slot = "7")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA1B RID: 182811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA1B")]
		[Address(RVA = "0x287F350", Offset = "0x287DF50", VA = "0x18287F350", Slot = "8")]
		protected override void RenderLut2D(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA1C RID: 182812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA1C")]
		[Address(RVA = "0x287F620", Offset = "0x287E220", VA = "0x18287F620", Slot = "9")]
		protected override void RenderLut3D(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA1D RID: 182813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA1D")]
		[Address(RVA = "0x287F850", Offset = "0x287E450", VA = "0x18287F850")]
		public LoFiPalette()
		{
		}

		// Token: 0x040404D8 RID: 263384
		[Token(Token = "0x40404D8")]
		[FieldOffset(Offset = "0x60")]
		public LoFiPalette.Preset Palette;

		// Token: 0x040404D9 RID: 263385
		[Token(Token = "0x40404D9")]
		[FieldOffset(Offset = "0x64")]
		[Tooltip("Pixelize the display.")]
		public bool Pixelize;

		// Token: 0x040404DA RID: 263386
		[Token(Token = "0x40404DA")]
		[FieldOffset(Offset = "0x68")]
		[Tooltip("The display height in pixels.")]
		public float PixelSize;

		// Token: 0x040404DB RID: 263387
		[Token(Token = "0x40404DB")]
		[FieldOffset(Offset = "0x6C")]
		protected LoFiPalette.Preset m_CurrentPreset;

		// Token: 0x02007CF5 RID: 31989
		[Token(Token = "0x2007CF5")]
		public enum Preset
		{
			// Token: 0x040404DD RID: 263389
			[Token(Token = "0x40404DD")]
			None,
			// Token: 0x040404DE RID: 263390
			[Token(Token = "0x40404DE")]
			AmstradCPC = 2,
			// Token: 0x040404DF RID: 263391
			[Token(Token = "0x40404DF")]
			CGA,
			// Token: 0x040404E0 RID: 263392
			[Token(Token = "0x40404E0")]
			Commodore64,
			// Token: 0x040404E1 RID: 263393
			[Token(Token = "0x40404E1")]
			CommodorePlus,
			// Token: 0x040404E2 RID: 263394
			[Token(Token = "0x40404E2")]
			EGA,
			// Token: 0x040404E3 RID: 263395
			[Token(Token = "0x40404E3")]
			GameBoy,
			// Token: 0x040404E4 RID: 263396
			[Token(Token = "0x40404E4")]
			MacOS16,
			// Token: 0x040404E5 RID: 263397
			[Token(Token = "0x40404E5")]
			MacOS256,
			// Token: 0x040404E6 RID: 263398
			[Token(Token = "0x40404E6")]
			MasterSystem,
			// Token: 0x040404E7 RID: 263399
			[Token(Token = "0x40404E7")]
			RiscOS16,
			// Token: 0x040404E8 RID: 263400
			[Token(Token = "0x40404E8")]
			Teletex,
			// Token: 0x040404E9 RID: 263401
			[Token(Token = "0x40404E9")]
			Windows16,
			// Token: 0x040404EA RID: 263402
			[Token(Token = "0x40404EA")]
			Windows256,
			// Token: 0x040404EB RID: 263403
			[Token(Token = "0x40404EB")]
			ZXSpectrum,
			// Token: 0x040404EC RID: 263404
			[Token(Token = "0x40404EC")]
			Andrae = 17,
			// Token: 0x040404ED RID: 263405
			[Token(Token = "0x40404ED")]
			Anodomani,
			// Token: 0x040404EE RID: 263406
			[Token(Token = "0x40404EE")]
			Crayolo,
			// Token: 0x040404EF RID: 263407
			[Token(Token = "0x40404EF")]
			DB16,
			// Token: 0x040404F0 RID: 263408
			[Token(Token = "0x40404F0")]
			DB32,
			// Token: 0x040404F1 RID: 263409
			[Token(Token = "0x40404F1")]
			DJinn,
			// Token: 0x040404F2 RID: 263410
			[Token(Token = "0x40404F2")]
			DrazileA,
			// Token: 0x040404F3 RID: 263411
			[Token(Token = "0x40404F3")]
			DrazileB,
			// Token: 0x040404F4 RID: 263412
			[Token(Token = "0x40404F4")]
			DrazileC,
			// Token: 0x040404F5 RID: 263413
			[Token(Token = "0x40404F5")]
			Eggy,
			// Token: 0x040404F6 RID: 263414
			[Token(Token = "0x40404F6")]
			FinlalA,
			// Token: 0x040404F7 RID: 263415
			[Token(Token = "0x40404F7")]
			FinlalB,
			// Token: 0x040404F8 RID: 263416
			[Token(Token = "0x40404F8")]
			Hapiel,
			// Token: 0x040404F9 RID: 263417
			[Token(Token = "0x40404F9")]
			PavanzA,
			// Token: 0x040404FA RID: 263418
			[Token(Token = "0x40404FA")]
			PavanzB,
			// Token: 0x040404FB RID: 263419
			[Token(Token = "0x40404FB")]
			Peyton,
			// Token: 0x040404FC RID: 263420
			[Token(Token = "0x40404FC")]
			SpeedyCube
		}
	}
}
