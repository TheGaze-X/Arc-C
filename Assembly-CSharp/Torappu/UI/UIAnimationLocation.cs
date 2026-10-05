using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036DE RID: 14046
	[Token(Token = "0x20036DE")]
	[Serializable]
	public struct UIAnimationLocation
	{
		// Token: 0x06016508 RID: 91400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016508")]
		[Address(RVA = "0xD6AD60", Offset = "0xD69960", VA = "0x180D6AD60")]
		public UIAnimationLocation(AnimationWrapper pAnimWrapper, string pAnimName)
		{
		}

		// Token: 0x06016509 RID: 91401 RVA: 0x00090810 File Offset: 0x0008EA10
		[Token(Token = "0x6016509")]
		[Address(RVA = "0xECC6F0", Offset = "0xECB2F0", VA = "0x180ECC6F0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0401AD6C RID: 109932
		[Token(Token = "0x401AD6C")]
		[FieldOffset(Offset = "0x0")]
		public AnimationWrapper animationWrapper;

		// Token: 0x0401AD6D RID: 109933
		[Token(Token = "0x401AD6D")]
		[FieldOffset(Offset = "0x8")]
		public string animationName;
	}
}
