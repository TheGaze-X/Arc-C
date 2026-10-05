using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Obsolete("This class is not used anymore. See AnimatorOverrideController.GetOverrides() and AnimatorOverrideController.ApplyOverrides()")]
	[Serializable]
	[StructLayout(0)]
	public class AnimationClipPair
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AnimationClipPair()
		{
		}

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationClip originalClip;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationClip overrideClip;
	}
}
