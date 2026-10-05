using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.Bindings
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	[VisibleToOtherModules]
	internal class NativeMethodAttribute : Attribute
	{
		// Token: 0x17000009 RID: 9
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public string Name
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public bool IsThreadSafe
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		public bool IsFreeFunction
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public bool ThrowsException
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2205340", Offset = "0x2203F40", VA = "0x182205340", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public bool HasExplicitThis
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x56CEED0", Offset = "0x56CDAD0", VA = "0x1856CEED0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public NativeMethodAttribute()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x59CBB80", Offset = "0x59CA780", VA = "0x1859CBB80")]
		public NativeMethodAttribute(string name)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x59CBCA0", Offset = "0x59CA8A0", VA = "0x1859CBCA0")]
		public NativeMethodAttribute(string name, bool isFreeFunction)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x59CBB40", Offset = "0x59CA740", VA = "0x1859CBB40")]
		public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
		{
		}
	}
}
