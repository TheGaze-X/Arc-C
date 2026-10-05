using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
	[NativeHeader("Modules/Animation/AvatarMask.h")]
	[MovedFrom(true, "UnityEditor.Animations", "UnityEditor", null)]
	public sealed class AvatarMask : Object
	{
		// Token: 0x06000101 RID: 257
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x5918ED0", Offset = "0x5917AD0", VA = "0x185918ED0")]
		[NativeMethod("GetBodyPart")]
		[MethodImpl(4096)]
		public extern bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index);

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000102 RID: 258
		[Token(Token = "0x17000046")]
		public extern int transformCount { [Token(Token = "0x6000102")] [Address(RVA = "0x5918FE0", Offset = "0x5917BE0", VA = "0x185918FE0")] [MethodImpl(4096)] get; }

		// Token: 0x06000103 RID: 259
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x5918F60", Offset = "0x5917B60", VA = "0x185918F60")]
		[MethodImpl(4096)]
		public extern string GetTransformPath(int index);

		// Token: 0x06000104 RID: 260
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x5918FA0", Offset = "0x5917BA0", VA = "0x185918FA0")]
		[MethodImpl(4096)]
		private extern float GetTransformWeight(int index);

		// Token: 0x06000105 RID: 261 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x5918F10", Offset = "0x5917B10", VA = "0x185918F10")]
		public bool GetTransformActive(int index)
		{
			return default(bool);
		}
	}
}
