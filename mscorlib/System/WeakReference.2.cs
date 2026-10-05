using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	[System.Serializable]
	public sealed class WeakReference<T> : System.Runtime.Serialization.ISerializable where T : class
	{
		// Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F2")]
		public WeakReference(T target)
		{
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F3")]
		public WeakReference(T target, bool trackResurrection)
		{
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F4")]
		private WeakReference(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F5")]
		public void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F6")]
		public void SetTarget(T target)
		{
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0000DA70 File Offset: 0x0000BC70
		[Token(Token = "0x60010F7")]
		public bool TryGetTarget(out T target)
		{
			return default(bool);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F8")]
		protected override void Finalize()
		{
		}

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private System.Runtime.InteropServices.GCHandle handle;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool trackResurrection;
	}
}
