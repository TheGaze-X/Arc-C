using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013A9 RID: 5033
	[Token(Token = "0x20013A9")]
	[Serializable]
	public class DynamicAbilityData
	{
		// Token: 0x06007394 RID: 29588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007394")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DynamicAbilityData()
		{
		}

		// Token: 0x04006FE6 RID: 28646
		[Token(Token = "0x4006FE6")]
		[FieldOffset(Offset = "0x10")]
		public bool atRoot;

		// Token: 0x04006FE7 RID: 28647
		[Token(Token = "0x4006FE7")]
		[FieldOffset(Offset = "0x18")]
		public string prefabKey;

		// Token: 0x04006FE8 RID: 28648
		[Token(Token = "0x4006FE8")]
		[FieldOffset(Offset = "0x20")]
		public Blackboard blackboard;
	}
}
