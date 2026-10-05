using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
	[NativeHeader("Modules/TextRendering/Public/Font.h")]
	[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
	[NativeClass("TextRendering::Font")]
	public sealed class Font : Object
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000024 RID: 36 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x06000025 RID: 37 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000001")]
		public static event Action<Font> textureRebuilt
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x5A02D80", Offset = "0x5A01980", VA = "0x185A02D80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x5A02F20", Offset = "0x5A01B20", VA = "0x185A02F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000026 RID: 38
		[Token(Token = "0x17000008")]
		public extern Material material { [Token(Token = "0x6000026")] [Address(RVA = "0x5A02EE0", Offset = "0x5A01AE0", VA = "0x185A02EE0")] [MethodImpl(4096)] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000027 RID: 39
		[Token(Token = "0x17000009")]
		public extern bool dynamic { [Token(Token = "0x6000027")] [Address(RVA = "0x5A02E60", Offset = "0x5A01A60", VA = "0x185A02E60")] [MethodImpl(4096)] get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40
		[Token(Token = "0x1700000A")]
		public extern int fontSize { [Token(Token = "0x6000028")] [Address(RVA = "0x5A02EA0", Offset = "0x5A01AA0", VA = "0x185A02EA0")] [MethodImpl(4096)] get; }

		// Token: 0x06000029 RID: 41 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5A02D10", Offset = "0x5A01910", VA = "0x185A02D10")]
		public Font()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5A02C90", Offset = "0x5A01890", VA = "0x185A02C90")]
		[RequiredByNativeCode]
		internal static void InvokeTextureRebuilt_Internal(Font font)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5A02BB0", Offset = "0x5A017B0", VA = "0x185A02BB0")]
		public bool HasCharacter(char c)
		{
			return default(bool);
		}

		// Token: 0x0600002C RID: 44
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5A02C00", Offset = "0x5A01800", VA = "0x185A02C00")]
		[MethodImpl(4096)]
		private extern bool HasCharacter(int c);

		// Token: 0x0600002D RID: 45
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5A02C40", Offset = "0x5A01840", VA = "0x185A02C40")]
		[MethodImpl(4096)]
		private static extern void Internal_CreateFont([Writable] Font self, string name);

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback;

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600002F RID: 47
		[Token(Token = "0x200000E")]
		public delegate void FontTextureRebuildCallback();
	}
}
