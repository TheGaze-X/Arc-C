using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public class PathAttachment : VertexAttachment
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000079")]
		public float[] Lengths
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007A")]
		public bool Closed
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000299C File Offset: 0x00000B9C
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007B")]
		public bool ConstantSpeed
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x2033940", Offset = "0x2032540", VA = "0x182033940")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x20339F0", Offset = "0x20325F0", VA = "0x1820339F0")]
			set
			{
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x4E50E40", Offset = "0x4E4FA40", VA = "0x184E50E40")]
		public PathAttachment(string name)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x4E50C20", Offset = "0x4E4F820", VA = "0x184E50C20", Slot = "4")]
		public override Attachment Copy()
		{
			return null;
		}

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x40")]
		internal float[] lengths;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x48")]
		internal bool closed;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x49")]
		internal bool constantSpeed;
	}
}
