using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	[UsedByNativeCode]
	[StructLayout(0)]
	public class TrackedReference
	{
		// Token: 0x060009FC RID: 2556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TrackedReference()
		{
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x5972470", Offset = "0x5971070", VA = "0x185972470")]
		public static bool operator ==(TrackedReference x, TrackedReference y)
		{
			return default(bool);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x5972560", Offset = "0x5971160", VA = "0x185972560")]
		public static bool operator !=(TrackedReference x, TrackedReference y)
		{
			return default(bool);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x5972350", Offset = "0x5970F50", VA = "0x185972350", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x5972460", Offset = "0x5971060", VA = "0x185972460", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x5972500", Offset = "0x5971100", VA = "0x185972500")]
		public static implicit operator bool(TrackedReference exists)
		{
			return default(bool);
		}

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
