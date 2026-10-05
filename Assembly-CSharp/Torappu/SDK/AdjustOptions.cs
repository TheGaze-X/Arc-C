using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x020014FF RID: 5375
	[Token(Token = "0x20014FF")]
	[Serializable]
	public class AdjustOptions
	{
		// Token: 0x06007BA6 RID: 31654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BA6")]
		[Address(RVA = "0x2735CB0", Offset = "0x27348B0", VA = "0x182735CB0")]
		public AdjustOptions()
		{
		}

		// Token: 0x04007A14 RID: 31252
		[Token(Token = "0x4007A14")]
		[FieldOffset(Offset = "0x10")]
		public string appId;

		// Token: 0x04007A15 RID: 31253
		[Token(Token = "0x4007A15")]
		[FieldOffset(Offset = "0x18")]
		public AdjustOptions.EventTokens tokens;

		// Token: 0x02001500 RID: 5376
		[Token(Token = "0x2001500")]
		[Serializable]
		public struct StageIdAndEvTokenPair
		{
			// Token: 0x06007BA7 RID: 31655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007BA7")]
			[Address(RVA = "0x2745DD0", Offset = "0x27449D0", VA = "0x182745DD0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04007A16 RID: 31254
			[Token(Token = "0x4007A16")]
			[FieldOffset(Offset = "0x0")]
			public string stageId;

			// Token: 0x04007A17 RID: 31255
			[Token(Token = "0x4007A17")]
			[FieldOffset(Offset = "0x8")]
			public string eventToken;
		}

		// Token: 0x02001501 RID: 5377
		[Token(Token = "0x2001501")]
		[Serializable]
		public class EventTokens
		{
			// Token: 0x06007BA8 RID: 31656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BA8")]
			[Address(RVA = "0x273AC60", Offset = "0x2739860", VA = "0x18273AC60")]
			public EventTokens()
			{
			}

			// Token: 0x04007A18 RID: 31256
			[Token(Token = "0x4007A18")]
			[FieldOffset(Offset = "0x10")]
			public string init;

			// Token: 0x04007A19 RID: 31257
			[Token(Token = "0x4007A19")]
			[FieldOffset(Offset = "0x18")]
			public string register;

			// Token: 0x04007A1A RID: 31258
			[Token(Token = "0x4007A1A")]
			[FieldOffset(Offset = "0x20")]
			public string login;

			// Token: 0x04007A1B RID: 31259
			[Token(Token = "0x4007A1B")]
			[FieldOffset(Offset = "0x28")]
			public string newGuest;

			// Token: 0x04007A1C RID: 31260
			[Token(Token = "0x4007A1C")]
			[FieldOffset(Offset = "0x30")]
			public string createRole;

			// Token: 0x04007A1D RID: 31261
			[Token(Token = "0x4007A1D")]
			[FieldOffset(Offset = "0x38")]
			public string pay;

			// Token: 0x04007A1E RID: 31262
			[Token(Token = "0x4007A1E")]
			[FieldOffset(Offset = "0x40")]
			public string createOrder;

			// Token: 0x04007A1F RID: 31263
			[Token(Token = "0x4007A1F")]
			[FieldOffset(Offset = "0x48")]
			public string hotUpdateFinished;

			// Token: 0x04007A20 RID: 31264
			[Token(Token = "0x4007A20")]
			[FieldOffset(Offset = "0x50")]
			public List<AdjustOptions.StageIdAndEvTokenPair> stageIdToEvTokens;
		}
	}
}
