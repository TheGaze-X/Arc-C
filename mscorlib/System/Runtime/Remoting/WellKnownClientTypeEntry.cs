using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000379 RID: 889
	[Token(Token = "0x2000379")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class WellKnownClientTypeEntry : TypeEntry
	{
		// Token: 0x06001D2A RID: 7466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2A")]
		[Address(RVA = "0x4B92B80", Offset = "0x4B91780", VA = "0x184B92B80")]
		public WellKnownClientTypeEntry(string typeName, string assemblyName, string objectUrl)
		{
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000359")]
		public string ApplicationUrl
		{
			[Token(Token = "0x6001D2B")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700035A")]
		public System.Type ObjectType
		{
			[Token(Token = "0x6001D2C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700035B")]
		public string ObjectUrl
		{
			[Token(Token = "0x6001D2D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x4B92B40", Offset = "0x4B91740", VA = "0x184B92B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Type obj_type;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string obj_url;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string app_url;
	}
}
