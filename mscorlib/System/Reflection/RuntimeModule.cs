using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200053A RID: 1338
	[Token(Token = "0x200053A")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
	[System.Runtime.InteropServices.ComDefaultInterface(typeof(System.Runtime.InteropServices._Module))]
	[System.Serializable]
	[StructLayout(0)]
	internal class RuntimeModule : Module
	{
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000585")]
		public override Assembly Assembly
		{
			[Token(Token = "0x600272D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000586")]
		public override string ScopeName
		{
			[Token(Token = "0x600272E")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x00015900 File Offset: 0x00013B00
		[Token(Token = "0x17000587")]
		public override System.Guid ModuleVersionId
		{
			[Token(Token = "0x600272F")]
			[Address(RVA = "0x4C24BF0", Offset = "0x4C237F0", VA = "0x184C24BF0", Slot = "10")]
			get
			{
				return default(System.Guid);
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000588")]
		public override string FullyQualifiedName
		{
			[Token(Token = "0x6002730")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00015918 File Offset: 0x00013B18
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "12")]
		public override bool IsResource()
		{
			return default(bool);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x4C24840", Offset = "0x4C23440", VA = "0x184C24840", Slot = "14")]
		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x4C247D0", Offset = "0x4C233D0", VA = "0x184C247D0", Slot = "15")]
		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00015930 File Offset: 0x00013B30
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x4C24B30", Offset = "0x4C23730", VA = "0x184C24B30", Slot = "13")]
		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return default(bool);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002735")]
		[Address(RVA = "0x4C24920", Offset = "0x4C23520", VA = "0x184C24920", Slot = "16")]
		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x4C24A80", Offset = "0x4C23680", VA = "0x184C24A80")]
		internal RuntimeAssembly GetRuntimeAssembly()
		{
			return null;
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00015948 File Offset: 0x00013B48
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x4C248A0", Offset = "0x4C234A0", VA = "0x184C248A0", Slot = "17")]
		internal override System.Guid GetModuleVersionId()
		{
			return default(System.Guid);
		}

		// Token: 0x06002738 RID: 10040
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x4AEF1B0", Offset = "0x4AEDDB0", VA = "0x184AEF1B0")]
		[MethodImpl(4096)]
		private static extern void GetGuidInternal(System.IntPtr module, byte[] guid);

		// Token: 0x06002739 RID: 10041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x4C24BA0", Offset = "0x4C237A0", VA = "0x184C24BA0")]
		public RuntimeModule()
		{
		}

		// Token: 0x04001624 RID: 5668
		[Token(Token = "0x4001624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal System.IntPtr _impl;

		// Token: 0x04001625 RID: 5669
		[Token(Token = "0x4001625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal Assembly assembly;

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal string fqname;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string name;

		// Token: 0x04001628 RID: 5672
		[Token(Token = "0x4001628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string scopename;

		// Token: 0x04001629 RID: 5673
		[Token(Token = "0x4001629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal bool is_resource;

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal int token;
	}
}
