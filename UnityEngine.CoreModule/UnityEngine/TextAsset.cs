using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	[NativeHeader("Runtime/Scripting/TextAsset.h")]
	public class TextAsset : Object
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060009ED RID: 2541
		[Token(Token = "0x17000206")]
		public extern byte[] bytes { [Token(Token = "0x60009ED")] [Address(RVA = "0x5970FB0", Offset = "0x596FBB0", VA = "0x185970FB0")] [MethodImpl(4096)] get; }

		// Token: 0x060009EE RID: 2542
		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x5970D10", Offset = "0x596F910", VA = "0x185970D10")]
		[MethodImpl(4096)]
		private extern byte[] GetPreviewBytes(int maxByteCount);

		// Token: 0x060009EF RID: 2543
		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x5970DA0", Offset = "0x596F9A0", VA = "0x185970DA0")]
		[MethodImpl(4096)]
		private static extern void Internal_CreateInstance([Writable] TextAsset self, string text);

		// Token: 0x060009F0 RID: 2544
		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x5970C90", Offset = "0x596F890", VA = "0x185970C90")]
		[MethodImpl(4096)]
		private extern IntPtr GetDataPtr();

		// Token: 0x060009F1 RID: 2545
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x5970CD0", Offset = "0x596F8D0", VA = "0x185970CD0")]
		[MethodImpl(4096)]
		private extern long GetDataSize();

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000207")]
		public string text
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x5970DF0", Offset = "0x596F9F0", VA = "0x185970DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x17000208")]
		public long dataSize
		{
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x5970CD0", Offset = "0x596F8D0", VA = "0x185970CD0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x5970DF0", Offset = "0x596F9F0", VA = "0x185970DF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x5970E30", Offset = "0x596FA30", VA = "0x185970E30")]
		public TextAsset()
		{
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x5970EA0", Offset = "0x596FAA0", VA = "0x185970EA0")]
		public TextAsset(string text)
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x5970F20", Offset = "0x596FB20", VA = "0x185970F20")]
		internal TextAsset(TextAsset.CreateOptions options, string text)
		{
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x60009F8")]
		public NativeArray<T> GetData<T>() where T : struct
		{
			return default(NativeArray<T>);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x5970D50", Offset = "0x596F950", VA = "0x185970D50")]
		internal string GetPreview(int maxChars)
		{
			return null;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x5970A40", Offset = "0x596F640", VA = "0x185970A40")]
		internal static string DecodeString(byte[] bytes)
		{
			return null;
		}

		// Token: 0x02000118 RID: 280
		[Token(Token = "0x2000118")]
		internal enum CreateOptions
		{
			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40004B2")]
			None,
			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40004B3")]
			CreateNativeObject
		}

		// Token: 0x02000119 RID: 281
		[Token(Token = "0x2000119")]
		private static class EncodingUtility
		{
			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly Encoding targetEncoding;
		}
	}
}
