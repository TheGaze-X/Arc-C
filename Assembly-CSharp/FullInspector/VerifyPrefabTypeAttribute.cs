using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BED RID: 31725
	[Token(Token = "0x2007BED")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class VerifyPrefabTypeAttribute : Attribute
	{
		// Token: 0x0602C656 RID: 181846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C656")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public VerifyPrefabTypeAttribute(VerifyPrefabTypeFlags prefabType)
		{
		}

		// Token: 0x04040286 RID: 262790
		[Token(Token = "0x4040286")]
		[FieldOffset(Offset = "0x10")]
		public VerifyPrefabTypeFlags PrefabType;
	}
}
