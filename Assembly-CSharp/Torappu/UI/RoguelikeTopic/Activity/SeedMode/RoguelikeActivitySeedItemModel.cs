using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046AC RID: 18092
	[Token(Token = "0x20046AC")]
	public abstract class RoguelikeActivitySeedItemModel : IHotfixable
	{
		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x0601B71B RID: 112411
		[Token(Token = "0x1700414F")]
		public abstract long sortId { [Token(Token = "0x601B71B")] get; }

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x0601B71C RID: 112412
		[Token(Token = "0x17004150")]
		public abstract SeedItemType seedItemType { [Token(Token = "0x601B71C")] get; }

		// Token: 0x0601B71D RID: 112413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B71D")]
		[Address(RVA = "0x14D3A00", Offset = "0x14D2600", VA = "0x1814D3A00")]
		protected RoguelikeActivitySeedItemModel()
		{
		}

		// Token: 0x04023849 RID: 145481
		[Token(Token = "0x4023849")]
		[FieldOffset(Offset = "0x10")]
		public string seed;

		// Token: 0x0402384A RID: 145482
		[Token(Token = "0x402384A")]
		[FieldOffset(Offset = "0x18")]
		public bool isEmpty;

		// Token: 0x0402384B RID: 145483
		[Token(Token = "0x402384B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
