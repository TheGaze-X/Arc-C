using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	public class ObjectTranslatorPool
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06003799 RID: 14233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000158")]
		public static ObjectTranslatorPool Instance
		{
			[Token(Token = "0x6003799")]
			[Address(RVA = "0x344C980", Offset = "0x344B580", VA = "0x18344C980")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379A")]
		[Address(RVA = "0x344C8F0", Offset = "0x344B4F0", VA = "0x18344C8F0")]
		public ObjectTranslatorPool()
		{
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379B")]
		[Address(RVA = "0x344C3D0", Offset = "0x344AFD0", VA = "0x18344C3D0")]
		public void Add(IntPtr L, ObjectTranslator translator)
		{
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600379C")]
		[Address(RVA = "0x344C510", Offset = "0x344B110", VA = "0x18344C510")]
		public ObjectTranslator Find(IntPtr L)
		{
			return null;
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600379D")]
		[Address(RVA = "0x344C7A0", Offset = "0x344B3A0", VA = "0x18344C7A0")]
		public void Remove(IntPtr L)
		{
		}

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<IntPtr, WeakReference> translators;

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr lastPtr;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x20")]
		private ObjectTranslator lastTranslator;
	}
}
