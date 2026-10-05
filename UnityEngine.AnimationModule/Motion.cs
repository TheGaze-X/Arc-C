using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[NativeHeader("Modules/Animation/Motion.h")]
	public class Motion : Object
	{
		// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x5919B20", Offset = "0x5918720", VA = "0x185919B20")]
		protected Motion()
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000108 RID: 264
		[Token(Token = "0x17000047")]
		public extern bool isLooping { [Token(Token = "0x6000108")] [Address(RVA = "0x5919B70", Offset = "0x5918770", VA = "0x185919B70")] [NativeMethod("IsLooping")] [MethodImpl(4096)] get; }
	}
}
