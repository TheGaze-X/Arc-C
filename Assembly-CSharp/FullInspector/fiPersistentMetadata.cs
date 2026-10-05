using System;
using FullInspector.Internal;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007C01 RID: 31745
	[Token(Token = "0x2007C01")]
	public static class fiPersistentMetadata
	{
		// Token: 0x0602C69E RID: 181918 RVA: 0x000E0058 File Offset: 0x000DE258
		[Token(Token = "0x602C69E")]
		[Address(RVA = "0x286C5D0", Offset = "0x286B1D0", VA = "0x18286C5D0")]
		public static bool HasMetadata(fiUnityObjectReference target)
		{
			return default(bool);
		}

		// Token: 0x0602C69F RID: 181919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C69F")]
		[Address(RVA = "0x286C280", Offset = "0x286AE80", VA = "0x18286C280")]
		public static fiGraphMetadata GetMetadataFor(UnityEngine.Object target)
		{
			return null;
		}

		// Token: 0x0602C6A0 RID: 181920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C6A0")]
		[Address(RVA = "0x286C310", Offset = "0x286AF10", VA = "0x18286C310")]
		public static fiGraphMetadata GetMetadataFor(fiUnityObjectReference target)
		{
			return null;
		}

		// Token: 0x0602C6A1 RID: 181921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C6A1")]
		[Address(RVA = "0x286C650", Offset = "0x286B250", VA = "0x18286C650")]
		public static void Reset(fiUnityObjectReference target)
		{
		}

		// Token: 0x040402A7 RID: 262823
		[Token(Token = "0x40402A7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly fiIPersistentMetadataProvider[] s_providers;

		// Token: 0x040402A8 RID: 262824
		[Token(Token = "0x40402A8")]
		[FieldOffset(Offset = "0x8")]
		private static fiArrayDictionary<fiUnityObjectReference, fiGraphMetadata> s_metadata;
	}
}
