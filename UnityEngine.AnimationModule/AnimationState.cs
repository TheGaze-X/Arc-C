using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[NativeHeader("Modules/Animation/AnimationState.h")]
	[UsedByNativeCode]
	public sealed class AnimationState : TrackedReference
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000050 RID: 80
		// (set) Token: 0x06000051 RID: 81
		[Token(Token = "0x1700000B")]
		public extern float time { [Token(Token = "0x6000050")] [Address(RVA = "0x5915840", Offset = "0x5914440", VA = "0x185915840")] [MethodImpl(4096)] get; [Token(Token = "0x6000051")] [Address(RVA = "0x5915960", Offset = "0x5914560", VA = "0x185915960")] [MethodImpl(4096)] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000052 RID: 82
		// (set) Token: 0x06000053 RID: 83
		[Token(Token = "0x1700000C")]
		public extern float normalizedTime { [Token(Token = "0x6000052")] [Address(RVA = "0x59157C0", Offset = "0x59143C0", VA = "0x1859157C0")] [MethodImpl(4096)] get; [Token(Token = "0x6000053")] [Address(RVA = "0x59158C0", Offset = "0x59144C0", VA = "0x1859158C0")] [MethodImpl(4096)] set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000054 RID: 84
		// (set) Token: 0x06000055 RID: 85
		[Token(Token = "0x1700000D")]
		public extern float speed { [Token(Token = "0x6000054")] [Address(RVA = "0x5915800", Offset = "0x5914400", VA = "0x185915800")] [MethodImpl(4096)] get; [Token(Token = "0x6000055")] [Address(RVA = "0x5915910", Offset = "0x5914510", VA = "0x185915910")] [MethodImpl(4096)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000056 RID: 86
		[Token(Token = "0x1700000E")]
		public extern float length { [Token(Token = "0x6000056")] [Address(RVA = "0x5915740", Offset = "0x5914340", VA = "0x185915740")] [MethodImpl(4096)] get; }

		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000057 RID: 87
		[Token(Token = "0x1700000F")]
		public extern int layer { [Token(Token = "0x6000057")] [Address(RVA = "0x5915880", Offset = "0x5914480", VA = "0x185915880")] [MethodImpl(4096)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000058 RID: 88
		[Token(Token = "0x17000010")]
		public extern AnimationClip clip { [Token(Token = "0x6000058")] [Address(RVA = "0x5915700", Offset = "0x5914300", VA = "0x185915700")] [MethodImpl(4096)] get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000059 RID: 89
		[Token(Token = "0x17000011")]
		public extern string name { [Token(Token = "0x6000059")] [Address(RVA = "0x5915780", Offset = "0x5914380", VA = "0x185915780")] [MethodImpl(4096)] get; }

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public AnimationState()
		{
		}
	}
}
