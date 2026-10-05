using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Permissions
{
	// Token: 0x020002D3 RID: 723
	[Token(Token = "0x20002D3")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class ReflectionPermission : CodeAccessPermission
	{
		// Token: 0x06001802 RID: 6146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001802")]
		[Address(RVA = "0x4B16B70", Offset = "0x4B15770", VA = "0x184B16B70")]
		public ReflectionPermission(ReflectionPermissionFlag flag)
		{
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00011358 File Offset: 0x0000F558
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000271")]
		public ReflectionPermissionFlag Flags
		{
			[Token(Token = "0x6001803")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return ReflectionPermissionFlag.NoFlags;
			}
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x4B16C40", Offset = "0x4B15840", VA = "0x184B16C40")]
			set
			{
			}
		}

		// Token: 0x06001805 RID: 6149 RVA: 0x00011370 File Offset: 0x0000F570
		[Token(Token = "0x6001805")]
		[Address(RVA = "0x4B168C0", Offset = "0x4B154C0", VA = "0x184B168C0", Slot = "8")]
		public override bool IsSubsetOf(IPermission target)
		{
			return default(bool);
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x00011388 File Offset: 0x0000F588
		[Token(Token = "0x6001806")]
		[Address(RVA = "0x4B169A0", Offset = "0x4B155A0", VA = "0x184B169A0", Slot = "10")]
		public bool IsUnrestricted()
		{
			return default(bool);
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001807")]
		[Address(RVA = "0x4B169B0", Offset = "0x4B155B0", VA = "0x184B169B0", Slot = "9")]
		public override SecurityElement ToXml()
		{
			return null;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001808")]
		[Address(RVA = "0x4B16820", Offset = "0x4B15420", VA = "0x184B16820")]
		private ReflectionPermission Cast(IPermission target)
		{
			return null;
		}

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ReflectionPermissionFlag flags;
	}
}
