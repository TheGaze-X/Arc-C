using System;
using Il2CppDummyDll;
using UnityEngine.Rendering.PostProcessing;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
public class HGDevPostProcessLayer : PostProcessLayer
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000029 RID: 41 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x1700000D")]
	public override bool hgDither
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x1700000E")]
	public override bool hgVignette
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600002B RID: 43 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x1700000F")]
	public override bool hgBloom
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x508E60", Offset = "0x507A60", VA = "0x180508E60")]
	public HGDevPostProcessLayer()
	{
	}
}
