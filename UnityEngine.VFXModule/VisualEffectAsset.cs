using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	[UsedByNativeCode]
	[NativeHeader("VFXScriptingClasses.h")]
	public class VisualEffectAsset : VisualEffectObject
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5BA12D0", Offset = "0x5B9FED0", VA = "0x185BA12D0")]
		public VisualEffectAsset()
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int PlayEventID;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int StopEventID;
	}
}
