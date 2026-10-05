using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Permissions
{
	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class SecurityPermission : CodeAccessPermission
	{
		// Token: 0x06001809 RID: 6153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001809")]
		[Address(RVA = "0x4B1B6B0", Offset = "0x4B1A2B0", VA = "0x184B1B6B0")]
		public SecurityPermission(PermissionState state)
		{
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180A")]
		[Address(RVA = "0x4B1B5E0", Offset = "0x4B1A1E0", VA = "0x184B1B5E0")]
		public SecurityPermission(SecurityPermissionFlag flag)
		{
		}

		// Token: 0x17000272 RID: 626
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public SecurityPermissionFlag Flags
		{
			[Token(Token = "0x600180B")]
			[Address(RVA = "0x4B1B6F0", Offset = "0x4B1A2F0", VA = "0x184B1B6F0")]
			set
			{
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000113A0 File Offset: 0x0000F5A0
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x4B1B4F0", Offset = "0x4B1A0F0", VA = "0x184B1B4F0", Slot = "10")]
		public bool IsUnrestricted()
		{
			return default(bool);
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x000113B8 File Offset: 0x0000F5B8
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x4B1B410", Offset = "0x4B1A010", VA = "0x184B1B410", Slot = "8")]
		public override bool IsSubsetOf(IPermission target)
		{
			return default(bool);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600180E")]
		[Address(RVA = "0x4B1B500", Offset = "0x4B1A100", VA = "0x184B1B500", Slot = "9")]
		public override SecurityElement ToXml()
		{
			return null;
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x000113D0 File Offset: 0x0000F5D0
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x9262F0", Offset = "0x924EF0", VA = "0x1809262F0")]
		private bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x4B1B370", Offset = "0x4B19F70", VA = "0x184B1B370")]
		private SecurityPermission Cast(IPermission target)
		{
			return null;
		}

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private SecurityPermissionFlag flags;
	}
}
