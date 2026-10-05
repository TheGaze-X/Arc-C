using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Unity.Profiling
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[UsedByNativeCode]
	[StructLayout(2)]
	public readonly struct ProfilerCategory
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4EDD9F0", Offset = "0x4EDC5F0", VA = "0x184EDD9F0")]
		internal ProfilerCategory(ushort category)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000001")]
		public string Name
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x5936200", Offset = "0x5934E00", VA = "0x185936200")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59361F0", Offset = "0x5934DF0", VA = "0x1859361F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x17000002")]
		public static ProfilerCategory Scripts
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40")]
			get
			{
				return default(ProfilerCategory);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x5936350", Offset = "0x5934F50", VA = "0x185936350")]
		public static implicit operator ushort(ProfilerCategory category)
		{
			return 0;
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ushort m_CategoryId;
	}
}
