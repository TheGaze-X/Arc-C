using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200320F RID: 12815
	[Token(Token = "0x200320F")]
	public class AnimatorFloatSource : Effect.Behaviour
	{
		// Token: 0x0601455B RID: 83291 RVA: 0x000868B0 File Offset: 0x00084AB0
		[Token(Token = "0x601455B")]
		[Address(RVA = "0xC84440", Offset = "0xC83040", VA = "0x180C84440", Slot = "10")]
		public virtual float GetValueOnPlay()
		{
			return 0f;
		}

		// Token: 0x0601455C RID: 83292 RVA: 0x000868C8 File Offset: 0x00084AC8
		[Token(Token = "0x601455C")]
		[Address(RVA = "0xC844A0", Offset = "0xC830A0", VA = "0x180C844A0", Slot = "11")]
		public virtual float GetValue()
		{
			return 0f;
		}

		// Token: 0x0601455D RID: 83293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601455D")]
		[Address(RVA = "0xC84500", Offset = "0xC83100", VA = "0x180C84500")]
		public AnimatorFloatSource()
		{
		}

		// Token: 0x04017FA7 RID: 98215
		[Token(Token = "0x4017FA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FA8 RID: 98216
		[Token(Token = "0x4017FA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FA9 RID: 98217
		[Token(Token = "0x4017FA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
