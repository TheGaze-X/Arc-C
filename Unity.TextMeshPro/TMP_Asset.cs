using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[Serializable]
	public abstract class TMP_Asset : ScriptableObject
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000023")]
		public int instanceID
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x5881D80", Offset = "0x5880980", VA = "0x185881D80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		protected TMP_Asset()
		{
		}

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x18")]
		private int m_InstanceID;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x1C")]
		public int hashCode;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x28")]
		public int materialHashCode;
	}
}
