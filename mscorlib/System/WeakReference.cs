using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001D7 RID: 471
	[Token(Token = "0x20001D7")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class WeakReference : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x4D603F0", Offset = "0x4D5EFF0", VA = "0x184D603F0")]
		private void AllocateHandle(object target)
		{
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected WeakReference()
		{
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x4D605C0", Offset = "0x4D5F1C0", VA = "0x184D605C0")]
		public WeakReference(object target)
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x4D60600", Offset = "0x4D5F200", VA = "0x184D60600")]
		public WeakReference(object target, bool trackResurrection)
		{
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x4D60650", Offset = "0x4D5F250", VA = "0x184D60650")]
		protected WeakReference(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x0000DA40 File Offset: 0x0000BC40
		[Token(Token = "0x17000186")]
		public virtual bool IsAlive
		{
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x4D60790", Offset = "0x4D5F390", VA = "0x184D60790", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000187")]
		public virtual object Target
		{
			[Token(Token = "0x60010ED")]
			[Address(RVA = "0x4D607D0", Offset = "0x4D5F3D0", VA = "0x184D607D0", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010EE")]
			[Address(RVA = "0x4D60800", Offset = "0x4D5F400", VA = "0x184D60800", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0000DA58 File Offset: 0x0000BC58
		[Token(Token = "0x17000188")]
		public virtual bool TrackResurrection
		{
			[Token(Token = "0x60010EF")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x4D60420", Offset = "0x4D5F020", VA = "0x184D60420", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x4D60480", Offset = "0x4D5F080", VA = "0x184D60480", Slot = "9")]
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isLongReference;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Runtime.InteropServices.GCHandle gcHandle;
	}
}
