using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	public sealed class ConnectionManagementSection : ConfigurationSection
	{
		// Token: 0x06001B1F RID: 6943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x50BBC10", Offset = "0x50BA810", VA = "0x1850BBC10")]
		public ConnectionManagementSection()
		{
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000601")]
		public ConnectionManagementElementCollection ConnectionManagement
		{
			[Token(Token = "0x6001B20")]
			[Address(RVA = "0x50BBC40", Offset = "0x50BA840", VA = "0x1850BBC40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000602")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B21")]
			[Address(RVA = "0x50BBC70", Offset = "0x50BA870", VA = "0x1850BBC70", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
