using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class WellKnownServiceTypeEntry : TypeEntry
	{
		// Token: 0x06001D2F RID: 7471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x4B92F20", Offset = "0x4B91B20", VA = "0x184B92F20")]
		public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
		{
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00012A38 File Offset: 0x00010C38
		[Token(Token = "0x1700035C")]
		public WellKnownObjectMode Mode
		{
			[Token(Token = "0x6001D30")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return (WellKnownObjectMode)0;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700035D")]
		public System.Type ObjectType
		{
			[Token(Token = "0x6001D31")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700035E")]
		public string ObjectUri
		{
			[Token(Token = "0x6001D32")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x4B92D10", Offset = "0x4B91910", VA = "0x184B92D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Type obj_type;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string obj_uri;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WellKnownObjectMode obj_mode;
	}
}
