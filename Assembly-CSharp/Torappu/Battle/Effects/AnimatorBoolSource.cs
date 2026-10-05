using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200320E RID: 12814
	[Token(Token = "0x200320E")]
	public class AnimatorBoolSource : Effect.Behaviour
	{
		// Token: 0x06014558 RID: 83288 RVA: 0x00086880 File Offset: 0x00084A80
		[Token(Token = "0x6014558")]
		[Address(RVA = "0xC84340", Offset = "0xC82F40", VA = "0x180C84340", Slot = "10")]
		public virtual bool GetValueOnPlay()
		{
			return default(bool);
		}

		// Token: 0x06014559 RID: 83289 RVA: 0x00086898 File Offset: 0x00084A98
		[Token(Token = "0x6014559")]
		[Address(RVA = "0xC80FE0", Offset = "0xC7FBE0", VA = "0x180C80FE0", Slot = "11")]
		public virtual bool GetValue()
		{
			return default(bool);
		}

		// Token: 0x0601455A RID: 83290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601455A")]
		[Address(RVA = "0xC843A0", Offset = "0xC82FA0", VA = "0x180C843A0")]
		public AnimatorBoolSource()
		{
		}

		// Token: 0x04017FA4 RID: 98212
		[Token(Token = "0x4017FA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValueOnPlay;

		// Token: 0x04017FA5 RID: 98213
		[Token(Token = "0x4017FA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x04017FA6 RID: 98214
		[Token(Token = "0x4017FA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
