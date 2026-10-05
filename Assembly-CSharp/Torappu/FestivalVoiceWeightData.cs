using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F89 RID: 3977
	[Token(Token = "0x2000F89")]
	public class FestivalVoiceWeightData : IItemWithWeight
	{
		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06006CCA RID: 27850 RVA: 0x00031A28 File Offset: 0x0002FC28
		[Token(Token = "0x17000D11")]
		public float weightValue
		{
			[Token(Token = "0x6006CCA")]
			[Address(RVA = "0x4F1EB0", Offset = "0x4F0AB0", VA = "0x1804F1EB0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CCB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FestivalVoiceWeightData()
		{
		}

		// Token: 0x0400547F RID: 21631
		[Token(Token = "0x400547F")]
		[FieldOffset(Offset = "0x10")]
		public CharWordShowType showType;

		// Token: 0x04005480 RID: 21632
		[Token(Token = "0x4005480")]
		[FieldOffset(Offset = "0x14")]
		public float weight;

		// Token: 0x04005481 RID: 21633
		[Token(Token = "0x4005481")]
		[FieldOffset(Offset = "0x18")]
		public int priority;
	}
}
