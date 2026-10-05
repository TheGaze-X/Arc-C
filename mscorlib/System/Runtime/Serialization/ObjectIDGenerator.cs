using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ObjectIDGenerator
	{
		// Token: 0x06001FCB RID: 8139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x4BA3710", Offset = "0x4BA2310", VA = "0x184BA3710")]
		public ObjectIDGenerator()
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x00013200 File Offset: 0x00011400
		[Token(Token = "0x6001FCC")]
		[Address(RVA = "0x4BA3020", Offset = "0x4BA1C20", VA = "0x184BA3020")]
		private int FindElement(object obj, out bool found)
		{
			return 0;
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0x4BA30E0", Offset = "0x4BA1CE0", VA = "0x184BA30E0", Slot = "4")]
		public virtual long GetId(object obj, out bool firstTime)
		{
			return 0L;
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x4BA3280", Offset = "0x4BA1E80", VA = "0x184BA3280", Slot = "5")]
		public virtual long HasId(object obj, out bool firstTime)
		{
			return 0L;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x4BA3360", Offset = "0x4BA1F60", VA = "0x184BA3360")]
		private void Rehash()
		{
		}

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int m_currentCount;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int m_currentSize;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal long[] m_ids;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal object[] m_objs;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] sizes;
	}
}
