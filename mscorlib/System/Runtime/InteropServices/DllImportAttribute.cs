using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	[System.AttributeUsage(System.AttributeTargets.Method, Inherited = false)]
	[ComVisible(true)]
	public sealed class DllImportAttribute : System.Attribute
	{
		// Token: 0x0600222D RID: 8749 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600222D")]
		[Address(RVA = "0x4BB49A0", Offset = "0x4BB35A0", VA = "0x184BB49A0")]
		internal static System.Attribute GetCustomAttribute(RuntimeMethodInfo method)
		{
			return null;
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[Token(Token = "0x600222E")]
		[Address(RVA = "0x4BB4C20", Offset = "0x4BB3820", VA = "0x184BB4C20")]
		internal static bool IsDefined(RuntimeMethodInfo method)
		{
			return default(bool);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600222F")]
		[Address(RVA = "0x4BB4C70", Offset = "0x4BB3870", VA = "0x184BB4C70")]
		internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
		{
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002230")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public DllImportAttribute(string dllName)
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06002231 RID: 8753 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700046B")]
		public string Value
		{
			[Token(Token = "0x6002231")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04001396 RID: 5014
		[Token(Token = "0x4001396")]
		[FieldOffset(Offset = "0x10")]
		internal string _val;

		// Token: 0x04001397 RID: 5015
		[Token(Token = "0x4001397")]
		[FieldOffset(Offset = "0x18")]
		public string EntryPoint;

		// Token: 0x04001398 RID: 5016
		[Token(Token = "0x4001398")]
		[FieldOffset(Offset = "0x20")]
		public CharSet CharSet;

		// Token: 0x04001399 RID: 5017
		[Token(Token = "0x4001399")]
		[FieldOffset(Offset = "0x24")]
		public bool SetLastError;

		// Token: 0x0400139A RID: 5018
		[Token(Token = "0x400139A")]
		[FieldOffset(Offset = "0x25")]
		public bool ExactSpelling;

		// Token: 0x0400139B RID: 5019
		[Token(Token = "0x400139B")]
		[FieldOffset(Offset = "0x26")]
		public bool PreserveSig;

		// Token: 0x0400139C RID: 5020
		[Token(Token = "0x400139C")]
		[FieldOffset(Offset = "0x28")]
		public CallingConvention CallingConvention;

		// Token: 0x0400139D RID: 5021
		[Token(Token = "0x400139D")]
		[FieldOffset(Offset = "0x2C")]
		public bool BestFitMapping;

		// Token: 0x0400139E RID: 5022
		[Token(Token = "0x400139E")]
		[FieldOffset(Offset = "0x2D")]
		public bool ThrowOnUnmappableChar;
	}
}
