using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[NativeHeader("Modules/UnityWebRequestTexture/Public/DownloadHandlerTexture.h")]
	[StructLayout(0)]
	public sealed class DownloadHandlerTexture : DownloadHandler
	{
		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5B9F7E0", Offset = "0x5B9E3E0", VA = "0x185B9F7E0")]
		[MethodImpl(4096)]
		private static extern IntPtr Create(DownloadHandlerTexture obj, bool readable);

		// Token: 0x06000004 RID: 4 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5B9F8E0", Offset = "0x5B9E4E0", VA = "0x185B9F8E0")]
		private void InternalCreateTexture(bool readable)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5B9FB80", Offset = "0x5B9E780", VA = "0x185B9FB80")]
		public DownloadHandlerTexture(bool readable)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5B9F8B0", Offset = "0x5B9E4B0", VA = "0x185B9F8B0", Slot = "6")]
		protected override NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5B9F830", Offset = "0x5B9E430", VA = "0x185B9F830", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public Texture2D texture
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5B9FBE0", Offset = "0x5B9E7E0", VA = "0x185B9FBE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5B9F970", Offset = "0x5B9E570", VA = "0x185B9F970")]
		private Texture2D InternalGetTexture()
		{
			return null;
		}

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x5B9F930", Offset = "0x5B9E530", VA = "0x185B9F930")]
		[NativeThrows]
		[MethodImpl(4096)]
		private extern Texture2D InternalGetTextureNative();

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x5B9F7A0", Offset = "0x5B9E3A0", VA = "0x185B9F7A0")]
		[MethodImpl(4096)]
		private extern void ClearNativeTexture();

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5B9F860", Offset = "0x5B9E460", VA = "0x185B9F860")]
		public static Texture2D GetContent(UnityWebRequest www)
		{
			return null;
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private NativeArray<byte> m_NativeData;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Texture2D mTexture;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool mHasTexture;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool mNonReadable;
	}
}
