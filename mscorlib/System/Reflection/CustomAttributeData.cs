using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class CustomAttributeData
	{
		// Token: 0x06002657 RID: 9815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CustomAttributeData()
		{
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x4C12610", Offset = "0x4C11210", VA = "0x184C12610")]
		internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, System.IntPtr data, uint data_length)
		{
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x4C126F0", Offset = "0x4C112F0", VA = "0x184C126F0")]
		internal CustomAttributeData(ConstructorInfo ctorInfo)
		{
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
		internal CustomAttributeData(ConstructorInfo ctorInfo, System.Collections.Generic.IList<CustomAttributeTypedArgument> ctorArgs, System.Collections.Generic.IList<CustomAttributeNamedArgument> namedArgs)
		{
		}

		// Token: 0x0600265B RID: 9819
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x4C11DA0", Offset = "0x4C109A0", VA = "0x184C11DA0")]
		[MethodImpl(4096)]
		private static extern void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, System.IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs);

		// Token: 0x0600265C RID: 9820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x4C11DB0", Offset = "0x4C109B0", VA = "0x184C11DB0")]
		private void ResolveArguments()
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700054D")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public virtual ConstructorInfo Constructor
		{
			[Token(Token = "0x600265D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700054E")]
		[System.Runtime.InteropServices.ComVisible(true)]
		public virtual System.Collections.Generic.IList<CustomAttributeTypedArgument> ConstructorArguments
		{
			[Token(Token = "0x600265E")]
			[Address(RVA = "0x4C127A0", Offset = "0x4C113A0", VA = "0x184C127A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700054F")]
		public virtual System.Collections.Generic.IList<CustomAttributeNamedArgument> NamedArguments
		{
			[Token(Token = "0x600265F")]
			[Address(RVA = "0x4C127C0", Offset = "0x4C113C0", VA = "0x184C127C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002660")]
		[Address(RVA = "0x4C118D0", Offset = "0x4C104D0", VA = "0x184C118D0")]
		public static System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(Assembly target)
		{
			return null;
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002661")]
		[Address(RVA = "0x4C11880", Offset = "0x4C10480", VA = "0x184C11880")]
		public static System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
		{
			return null;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002662")]
		[Address(RVA = "0x4C11790", Offset = "0x4C10390", VA = "0x184C11790")]
		internal static System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
		{
			return null;
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x4C117E0", Offset = "0x4C103E0", VA = "0x184C117E0")]
		public static System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(Module target)
		{
			return null;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x4C11830", Offset = "0x4C10430", VA = "0x184C11830")]
		public static System.Collections.Generic.IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
		{
			return null;
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06002665 RID: 9829 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000550")]
		public System.Type AttributeType
		{
			[Token(Token = "0x6002665")]
			[Address(RVA = "0x4BAB620", Offset = "0x4BAA220", VA = "0x184BAB620")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x4C11F00", Offset = "0x4C10B00", VA = "0x184C11F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002667")]
		private static T[] UnboxValues<T>(object[] values)
		{
			return null;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x4C113A0", Offset = "0x4C0FFA0", VA = "0x184C113A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x4C11920", Offset = "0x4C10520", VA = "0x184C11920", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ConstructorInfo ctorInfo;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.Collections.Generic.IList<CustomAttributeTypedArgument> ctorArgs;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Collections.Generic.IList<CustomAttributeNamedArgument> namedArgs;

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CustomAttributeData.LazyCAttrData lazyData;

		// Token: 0x0200052E RID: 1326
		[Token(Token = "0x200052E")]
		private class LazyCAttrData
		{
			// Token: 0x0600266A RID: 9834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600266A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LazyCAttrData()
			{
			}

			// Token: 0x040015F2 RID: 5618
			[Token(Token = "0x40015F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Assembly assembly;

			// Token: 0x040015F3 RID: 5619
			[Token(Token = "0x40015F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal System.IntPtr data;

			// Token: 0x040015F4 RID: 5620
			[Token(Token = "0x40015F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal uint data_length;
		}
	}
}
