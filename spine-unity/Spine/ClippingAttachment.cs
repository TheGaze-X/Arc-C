using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class ClippingAttachment : VertexAttachment
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700005E")]
		public SlotData EndSlot
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4E43680", Offset = "0x4E42280", VA = "0x184E43680")]
		public ClippingAttachment(string name)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x4E435C0", Offset = "0x4E421C0", VA = "0x184E435C0", Slot = "4")]
		public override Attachment Copy()
		{
			return null;
		}

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x40")]
		internal SlotData endSlot;
	}
}
