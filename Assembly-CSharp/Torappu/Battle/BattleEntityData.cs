using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002635 RID: 9781
	[Token(Token = "0x2002635")]
	[Serializable]
	public class BattleEntityData
	{
		// Token: 0x06010015 RID: 65557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010015")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06010016 RID: 65558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010016")]
		[Address(RVA = "0x778510", Offset = "0x777110", VA = "0x180778510")]
		public BattleEntityData()
		{
		}

		// Token: 0x04011C75 RID: 72821
		[Token(Token = "0x4011C75")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04011C76 RID: 72822
		[Token(Token = "0x4011C76")]
		[FieldOffset(Offset = "0x18")]
		public string alias;

		// Token: 0x04011C77 RID: 72823
		[Token(Token = "0x4011C77")]
		[FieldOffset(Offset = "0x20")]
		public string tmplId;

		// Token: 0x04011C78 RID: 72824
		[Token(Token = "0x4011C78")]
		[FieldOffset(Offset = "0x28")]
		public string nameCn;

		// Token: 0x04011C79 RID: 72825
		[Token(Token = "0x4011C79")]
		[FieldOffset(Offset = "0x30")]
		public string nameEn;

		// Token: 0x04011C7A RID: 72826
		[Token(Token = "0x4011C7A")]
		[FieldOffset(Offset = "0x38")]
		public AttributesData attributes;
	}
}
