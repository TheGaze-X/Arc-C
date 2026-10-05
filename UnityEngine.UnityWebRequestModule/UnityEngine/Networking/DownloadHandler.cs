using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Networking
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
	[StructLayout(0)]
	public class DownloadHandler : IDisposable
	{
		// Token: 0x06000066 RID: 102
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5B98EE0", Offset = "0x5B97AE0", VA = "0x185B98EE0")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern void Release();

		// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		[VisibleToOtherModules]
		internal DownloadHandler()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x5B98870", Offset = "0x5B97470", VA = "0x185B98870", Slot = "5")]
		public virtual void Dispose()
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x17000016")]
		public bool isDone
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x5B98E50", Offset = "0x5B97A50", VA = "0x185B98E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x5B98E50", Offset = "0x5B97A50", VA = "0x185B98E50")]
		[MethodImpl(4096)]
		private extern bool IsDone();

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000017")]
		public byte[] data
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x5959E70", Offset = "0x5958A70", VA = "0x185959E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public string text
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x5B98F20", Offset = "0x5B97B20", VA = "0x185B98F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x5949660", Offset = "0x5948260", VA = "0x185949660", Slot = "6")]
		protected virtual NativeArray<byte> GetNativeData()
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x5B98940", Offset = "0x5B97540", VA = "0x185B98940", Slot = "7")]
		protected virtual byte[] GetData()
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5B98BF0", Offset = "0x5B977F0", VA = "0x185B98BF0", Slot = "8")]
		protected virtual string GetText()
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5B989E0", Offset = "0x5B975E0", VA = "0x185B989E0")]
		private Encoding GetTextEncoder()
		{
			return null;
		}

		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5B98900", Offset = "0x5B97500", VA = "0x185B98900")]
		[MethodImpl(4096)]
		private extern string GetContentType();

		// Token: 0x06000073 RID: 115 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3E67470", Offset = "0x3E66070", VA = "0x183E67470", Slot = "9")]
		[RequiredByNativeCode]
		protected virtual bool ReceiveData(byte[] data, int dataLength)
		{
			return default(bool);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x5B98E90", Offset = "0x5B97A90", VA = "0x185B98E90", Slot = "10")]
		[RequiredByNativeCode]
		protected virtual void ReceiveContentLengthHeader(ulong contentLength)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		[Obsolete("Use ReceiveContentLengthHeader")]
		protected virtual void ReceiveContentLength(int contentLength)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		[RequiredByNativeCode]
		protected virtual void CompleteContent()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x592D910", Offset = "0x592C510", VA = "0x18592D910", Slot = "13")]
		[RequiredByNativeCode]
		protected virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000078")]
		protected static T GetCheckedDownloader<T>(UnityWebRequest www) where T : DownloadHandler
		{
			return null;
		}

		// Token: 0x06000079 RID: 121
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x5B98CE0", Offset = "0x5B978E0", VA = "0x185B98CE0")]
		[VisibleToOtherModules]
		[NativeThrows]
		[MethodImpl(4096)]
		internal unsafe static extern byte* InternalGetByteArray(DownloadHandler dh, out int length);

		// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5B98940", Offset = "0x5B97540", VA = "0x185B98940")]
		internal static byte[] InternalGetByteArray(DownloadHandler dh)
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5B98D30", Offset = "0x5B97930", VA = "0x185B98D30")]
		internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray)
		{
			return default(NativeArray<byte>);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x5B98830", Offset = "0x5B97430", VA = "0x185B98830")]
		internal static void DisposeNativeArray(ref NativeArray<byte> data)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5B987C0", Offset = "0x5B973C0", VA = "0x185B987C0")]
		internal unsafe static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length)
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[VisibleToOtherModules]
		[NonSerialized]
		internal IntPtr m_Ptr;
	}
}
