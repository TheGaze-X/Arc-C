using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003210 RID: 12816
	[Token(Token = "0x2003210")]
	public class AnimatorTriggerSource : Effect.Behaviour, IHotfixable
	{
		// Token: 0x0601455E RID: 83294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601455E")]
		[Address(RVA = "0xC81610", Offset = "0xC80210", VA = "0x180C81610", Slot = "10")]
		public virtual string GetValueOnPlay()
		{
			return null;
		}

		// Token: 0x0601455F RID: 83295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601455F")]
		[Address(RVA = "0xC81670", Offset = "0xC80270", VA = "0x180C81670", Slot = "11")]
		public virtual string GetValue()
		{
			return null;
		}

		// Token: 0x06014560 RID: 83296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014560")]
		[Address(RVA = "0xC845A0", Offset = "0xC831A0", VA = "0x180C845A0")]
		public AnimatorTriggerSource()
		{
		}

		// Token: 0x04017FAA RID: 98218
		[Token(Token = "0x4017FAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FAB RID: 98219
		[Token(Token = "0x4017FAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FAC RID: 98220
		[Token(Token = "0x4017FAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
