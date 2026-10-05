using System;
using Il2CppDummyDll;

namespace AdvancedInspector
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class NoPicker : Attribute, IPicker, IListAttribute
	{
		// Token: 0x0600012E RID: 302 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
		public bool IsPickingAvailable(object[] instances, object[] values)
		{
			return default(bool);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public NoPicker()
		{
		}
	}
}
