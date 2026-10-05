using System;
using Il2CppDummyDll;

namespace System.Net.NetworkInformation
{
	// Token: 0x02000368 RID: 872
	[Token(Token = "0x2000368")]
	public abstract class NetworkInterface
	{
		// Token: 0x06001842 RID: 6210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x509E100", Offset = "0x509CD00", VA = "0x18509E100")]
		public static NetworkInterface[] GetAllNetworkInterfaces()
		{
			return null;
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000556")]
		public virtual string Description
		{
			[Token(Token = "0x6001843")]
			[Address(RVA = "0x509E1E0", Offset = "0x509CDE0", VA = "0x18509E1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x509E140", Offset = "0x509CD40", VA = "0x18509E140", Slot = "5")]
		public virtual IPInterfaceProperties GetIPProperties()
		{
			return null;
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x17000557")]
		public virtual OperationalStatus OperationalStatus
		{
			[Token(Token = "0x6001845")]
			[Address(RVA = "0x509E280", Offset = "0x509CE80", VA = "0x18509E280", Slot = "6")]
			get
			{
				return (OperationalStatus)0;
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x509E190", Offset = "0x509CD90", VA = "0x18509E190", Slot = "7")]
		public virtual PhysicalAddress GetPhysicalAddress()
		{
			return null;
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x17000558")]
		public virtual NetworkInterfaceType NetworkInterfaceType
		{
			[Token(Token = "0x6001847")]
			[Address(RVA = "0x509E230", Offset = "0x509CE30", VA = "0x18509E230", Slot = "8")]
			get
			{
				return (NetworkInterfaceType)0;
			}
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected NetworkInterface()
		{
		}
	}
}
