using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E62 RID: 3682
	[Token(Token = "0x2000E62")]
	public class ActVecBreakV2BossData
	{
		// Token: 0x06006B2F RID: 27439 RVA: 0x00031248 File Offset: 0x0002F448
		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0x1FF9BF0", Offset = "0x1FF87F0", VA = "0x181FF9BF0")]
		public bool ShouldSerializelevelDecoFigureId()
		{
			return default(bool);
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x00031260 File Offset: 0x0002F460
		[Token(Token = "0x6006B30")]
		[Address(RVA = "0x1FFA6F0", Offset = "0x1FF92F0", VA = "0x181FFA6F0")]
		public bool ShouldSerializelevelDecoSignId()
		{
			return default(bool);
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B31")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2BossData()
		{
		}

		// Token: 0x04004D12 RID: 19730
		[Token(Token = "0x4004D12")]
		[FieldOffset(Offset = "0x10")]
		public string enemyId;

		// Token: 0x04004D13 RID: 19731
		[Token(Token = "0x4004D13")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04004D14 RID: 19732
		[Token(Token = "0x4004D14")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x04004D15 RID: 19733
		[Token(Token = "0x4004D15")]
		[FieldOffset(Offset = "0x28")]
		public int level;

		// Token: 0x04004D16 RID: 19734
		[Token(Token = "0x4004D16")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x04004D17 RID: 19735
		[Token(Token = "0x4004D17")]
		[FieldOffset(Offset = "0x38")]
		public string levelDecoFigureId;

		// Token: 0x04004D18 RID: 19736
		[Token(Token = "0x4004D18")]
		[FieldOffset(Offset = "0x40")]
		public string levelDecoSignId;

		// Token: 0x04004D19 RID: 19737
		[Token(Token = "0x4004D19")]
		[FieldOffset(Offset = "0x48")]
		public string decoId;
	}
}
