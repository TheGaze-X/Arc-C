using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class PointAttachment : Attachment
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000029B4 File Offset: 0x00000BB4
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007C")]
		public float X
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
			set
			{
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000029CC File Offset: 0x00000BCC
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007D")]
		public float Y
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
			set
			{
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000029E4 File Offset: 0x00000BE4
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700007E")]
		public float Rotation
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x73B900", Offset = "0x73A500", VA = "0x18073B900")]
			set
			{
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4E54090", Offset = "0x4E52C90", VA = "0x184E54090")]
		public PointAttachment(string name)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x4E53E20", Offset = "0x4E52A20", VA = "0x184E53E20")]
		public void ComputeWorldPosition(Bone bone, out float ox, out float oy)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x4E53E80", Offset = "0x4E52A80", VA = "0x184E53E80")]
		public float ComputeWorldRotation(Bone bone)
		{
			return 0f;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4E54010", Offset = "0x4E52C10", VA = "0x184E54010", Slot = "4")]
		public override Attachment Copy()
		{
			return null;
		}

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x18")]
		internal float x;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x1C")]
		internal float y;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x20")]
		internal float rotation;
	}
}
