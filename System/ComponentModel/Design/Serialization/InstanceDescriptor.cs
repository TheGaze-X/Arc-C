using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel.Design.Serialization
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	public sealed class InstanceDescriptor
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x517F620", Offset = "0x517E220", VA = "0x18517F620")]
		public InstanceDescriptor(MemberInfo member, ICollection arguments)
		{
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x517F640", Offset = "0x517E240", VA = "0x18517F640")]
		public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
		{
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000314")]
		public ICollection Arguments
		{
			[Token(Token = "0x6000F8B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000315")]
		public MemberInfo MemberInfo
		{
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x517EEF0", Offset = "0x517DAF0", VA = "0x18517EEF0")]
		public object Invoke()
		{
			return null;
		}
	}
}
