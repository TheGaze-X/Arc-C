using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	[AttributeUsage(AttributeTargets.Method)]
	public sealed class DataObjectMethodAttribute : Attribute
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x5141E40", Offset = "0x5140A40", VA = "0x185141E40")]
		public DataObjectMethodAttribute(DataObjectMethodType methodType)
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x5141E70", Offset = "0x5140A70", VA = "0x185141E70")]
		public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x170001FE")]
		public bool IsDefault
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x170001FF")]
		public DataObjectMethodType MethodType
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return DataObjectMethodType.Fill;
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x5141CB0", Offset = "0x51408B0", VA = "0x185141CB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x5141D40", Offset = "0x5140940", VA = "0x185141D40", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x5141DC0", Offset = "0x51409C0", VA = "0x185141DC0", Slot = "5")]
		public override bool Match(object obj)
		{
			return default(bool);
		}
	}
}
