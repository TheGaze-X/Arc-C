using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Google.FlatBuffers
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	public abstract class ByteBufferAllocator
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008F")]
		public byte[] Buffer
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000090")]
		public int Length
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060004FE RID: 1278
		[Token(Token = "0x60004FE")]
		public abstract void GrowFront(int newSize);

		// Token: 0x060004FF RID: 1279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ByteBufferAllocator()
		{
		}
	}
}
