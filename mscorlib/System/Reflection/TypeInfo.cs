using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	public abstract class TypeInfo : System.Type, IReflectableType
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x4BEAD80", Offset = "0x4BE9980", VA = "0x184BEAD80")]
		protected TypeInfo()
		{
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "136")]
		private TypeInfo GetTypeInfo()
		{
			return null;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000537")]
		public virtual System.Collections.Generic.IEnumerable<System.Type> ImplementedInterfaces
		{
			[Token(Token = "0x60025DA")]
			[Address(RVA = "0x4BEADD0", Offset = "0x4BE99D0", VA = "0x184BEADD0", Slot = "137")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001570 RID: 5488
		[Token(Token = "0x4001570")]
		private const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
	}
}
