using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class NamedPermissionSet : PermissionSet
	{
		// Token: 0x06001794 RID: 6036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001794")]
		[Address(RVA = "0x4B11B40", Offset = "0x4B10740", VA = "0x184B11B40")]
		internal NamedPermissionSet()
		{
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001795")]
		[Address(RVA = "0x4B11B90", Offset = "0x4B10790", VA = "0x184B11B90")]
		public NamedPermissionSet(string name, System.Security.Permissions.PermissionState state)
		{
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001796")]
		[Address(RVA = "0x4B11A30", Offset = "0x4B10630", VA = "0x184B11A30")]
		public NamedPermissionSet(string name)
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000260")]
		public string Name
		{
			[Token(Token = "0x6001797")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001798")]
			[Address(RVA = "0x4B11CB0", Offset = "0x4B108B0", VA = "0x184B11CB0")]
			set
			{
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001799")]
		[Address(RVA = "0x4B11990", Offset = "0x4B10590", VA = "0x184B11990", Slot = "13")]
		public override SecurityElement ToXml()
		{
			return null;
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000110E8 File Offset: 0x0000F2E8
		[Token(Token = "0x600179A")]
		[Address(RVA = "0x4B11870", Offset = "0x4B10470", VA = "0x184B11870", Slot = "0")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00011100 File Offset: 0x0000F300
		[Token(Token = "0x600179B")]
		[Address(RVA = "0x4B118F0", Offset = "0x4B104F0", VA = "0x184B118F0", Slot = "2")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000CBD RID: 3261
		[Token(Token = "0x4000CBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string name;

		// Token: 0x04000CBE RID: 3262
		[Token(Token = "0x4000CBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string description;
	}
}
