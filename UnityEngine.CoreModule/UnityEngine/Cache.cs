using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[StaticAccessor("CacheWrapper", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Misc/Cache.h")]
	public struct Cache : IEquatable<Cache>
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x1700002E")]
		internal int handle
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x59211B0", Offset = "0x591FDB0", VA = "0x1859211B0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5921240", Offset = "0x591FE40", VA = "0x185921240", Slot = "4")]
		public bool Equals(Cache other)
		{
			return default(bool);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700002F")]
		public string path
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x5921250", Offset = "0x591FE50", VA = "0x185921250")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000EF RID: 239
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5921170", Offset = "0x591FD70", VA = "0x185921170")]
		[NativeThrows]
		[MethodImpl(4096)]
		internal static extern string Cache_GetPath(int handle);

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		private int m_Handle;
	}
}
