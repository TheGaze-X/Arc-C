using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.U2D
{
	// Token: 0x02000157 RID: 343
	[Token(Token = "0x2000157")]
	[StaticAccessor("GetSpriteAtlasManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
	[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	public class SpriteAtlasManager
	{
		// Token: 0x06000C0E RID: 3086 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x596CD50", Offset = "0x596B950", VA = "0x18596CD50")]
		[RequiredByNativeCode]
		private static bool RequestAtlas(string tag)
		{
			return default(bool);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000C0F RID: 3087 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C10 RID: 3088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000D")]
		public static event Action<SpriteAtlas> atlasRegistered
		{
			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x596CE10", Offset = "0x596BA10", VA = "0x18596CE10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x596CEF0", Offset = "0x596BAF0", VA = "0x18596CEF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x596CCB0", Offset = "0x596B8B0", VA = "0x18596CCB0")]
		[RequiredByNativeCode]
		private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas)
		{
		}

		// Token: 0x06000C12 RID: 3090
		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x596CD10", Offset = "0x596B910", VA = "0x18596CD10")]
		[MethodImpl(4096)]
		internal static extern void Register(SpriteAtlas spriteAtlas);

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<string, Action<SpriteAtlas>> atlasRequested;
	}
}
