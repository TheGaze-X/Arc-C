using System;
using Il2CppDummyDll;

namespace Torappu.UI.Squad
{
	// Token: 0x02003DF9 RID: 15865
	[Token(Token = "0x2003DF9")]
	public class SquadGroupConstrainPolicy
	{
		// Token: 0x06018AE8 RID: 101096 RVA: 0x0009B448 File Offset: 0x00099648
		[Token(Token = "0x6018AE8")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
		public virtual bool CheckIfAssistLocked()
		{
			return default(bool);
		}

		// Token: 0x06018AE9 RID: 101097 RVA: 0x0009B460 File Offset: 0x00099660
		[Token(Token = "0x6018AE9")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "5")]
		public virtual bool CheckIfSquadSlotLocked(SquadViewModel squad, int index)
		{
			return default(bool);
		}

		// Token: 0x06018AEA RID: 101098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018AEA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SquadGroupConstrainPolicy()
		{
		}
	}
}
