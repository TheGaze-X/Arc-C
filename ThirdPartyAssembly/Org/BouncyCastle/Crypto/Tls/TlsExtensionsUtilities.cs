using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000297 RID: 663
	[Token(Token = "0x2000297")]
	public abstract class TlsExtensionsUtilities
	{
		// Token: 0x06001630 RID: 5680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x526B480", Offset = "0x526A080", VA = "0x18526B480")]
		public static IDictionary EnsureExtensionsInitialised(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x526A750", Offset = "0x5269350", VA = "0x18526A750")]
		public static void AddEncryptThenMacExtension(IDictionary extensions)
		{
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x526A820", Offset = "0x5269420", VA = "0x18526A820")]
		public static void AddExtendedMasterSecretExtension(IDictionary extensions)
		{
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x526A8F0", Offset = "0x52694F0", VA = "0x18526A8F0")]
		public static void AddHeartbeatExtension(IDictionary extensions, HeartbeatExtension heartbeatExtension)
		{
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x526AA70", Offset = "0x5269670", VA = "0x18526AA70")]
		public static void AddMaxFragmentLengthExtension(IDictionary extensions, byte maxFragmentLength)
		{
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x526AB50", Offset = "0x5269750", VA = "0x18526AB50")]
		public static void AddPaddingExtension(IDictionary extensions, int dataLength)
		{
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x526AC40", Offset = "0x5269840", VA = "0x18526AC40")]
		public static void AddServerNameExtension(IDictionary extensions, ServerNameList serverNameList)
		{
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x526ADC0", Offset = "0x52699C0", VA = "0x18526ADC0")]
		public static void AddStatusRequestExtension(IDictionary extensions, CertificateStatusRequest statusRequest)
		{
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x526AF40", Offset = "0x5269B40", VA = "0x18526AF40")]
		public static void AddTruncatedHMacExtension(IDictionary extensions)
		{
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x526B4E0", Offset = "0x526A0E0", VA = "0x18526B4E0")]
		public static HeartbeatExtension GetHeartbeatExtension(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x526B670", Offset = "0x526A270", VA = "0x18526B670")]
		public static short GetMaxFragmentLengthExtension(IDictionary extensions)
		{
			return 0;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x526B7C0", Offset = "0x526A3C0", VA = "0x18526B7C0")]
		public static int GetPaddingExtension(IDictionary extensions)
		{
			return 0;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x526B920", Offset = "0x526A520", VA = "0x18526B920")]
		public static ServerNameList GetServerNameExtension(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x526BAB0", Offset = "0x526A6B0", VA = "0x18526BAB0")]
		public static CertificateStatusRequest GetStatusRequestExtension(IDictionary extensions)
		{
			return null;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x526BC40", Offset = "0x526A840", VA = "0x18526BC40")]
		public static bool HasEncryptThenMacExtension(IDictionary extensions)
		{
			return default(bool);
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x526BD80", Offset = "0x526A980", VA = "0x18526BD80")]
		public static bool HasExtendedMasterSecretExtension(IDictionary extensions)
		{
			return default(bool);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x6001640")]
		[Address(RVA = "0x526BEC0", Offset = "0x526AAC0", VA = "0x18526BEC0")]
		public static bool HasTruncatedHMacExtension(IDictionary extensions)
		{
			return default(bool);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x526B010", Offset = "0x5269C10", VA = "0x18526B010")]
		public static byte[] CreateEmptyExtensionData()
		{
			return null;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x526B060", Offset = "0x5269C60", VA = "0x18526B060")]
		public static byte[] CreateEncryptThenMacExtension()
		{
			return null;
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x526B060", Offset = "0x5269C60", VA = "0x18526B060")]
		public static byte[] CreateExtendedMasterSecretExtension()
		{
			return null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x526B0B0", Offset = "0x5269CB0", VA = "0x18526B0B0")]
		public static byte[] CreateHeartbeatExtension(HeartbeatExtension heartbeatExtension)
		{
			return null;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x526B1B0", Offset = "0x5269DB0", VA = "0x18526B1B0")]
		public static byte[] CreateMaxFragmentLengthExtension(byte maxFragmentLength)
		{
			return null;
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x526B210", Offset = "0x5269E10", VA = "0x18526B210")]
		public static byte[] CreatePaddingExtension(int dataLength)
		{
			return null;
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001647")]
		[Address(RVA = "0x526B280", Offset = "0x5269E80", VA = "0x18526B280")]
		public static byte[] CreateServerNameExtension(ServerNameList serverNameList)
		{
			return null;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001648")]
		[Address(RVA = "0x526B380", Offset = "0x5269F80", VA = "0x18526B380")]
		public static byte[] CreateStatusRequestExtension(CertificateStatusRequest statusRequest)
		{
			return null;
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001649")]
		[Address(RVA = "0x526B060", Offset = "0x5269C60", VA = "0x18526B060")]
		public static byte[] CreateTruncatedHMacExtension()
		{
			return null;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x526C000", Offset = "0x526AC00", VA = "0x18526C000")]
		private static bool ReadEmptyExtensionData(byte[] extensionData)
		{
			return default(bool);
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x526C000", Offset = "0x526AC00", VA = "0x18526C000")]
		public static bool ReadEncryptThenMacExtension(byte[] extensionData)
		{
			return default(bool);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x526C000", Offset = "0x526AC00", VA = "0x18526C000")]
		public static bool ReadExtendedMasterSecretExtension(byte[] extensionData)
		{
			return default(bool);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x526C0B0", Offset = "0x526ACB0", VA = "0x18526C0B0")]
		public static HeartbeatExtension ReadHeartbeatExtension(byte[] extensionData)
		{
			return null;
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x526C1B0", Offset = "0x526ADB0", VA = "0x18526C1B0")]
		public static short ReadMaxFragmentLengthExtension(byte[] extensionData)
		{
			return 0;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x526C260", Offset = "0x526AE60", VA = "0x18526C260")]
		public static int ReadPaddingExtension(byte[] extensionData)
		{
			return 0;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x526C340", Offset = "0x526AF40", VA = "0x18526C340")]
		public static ServerNameList ReadServerNameExtension(byte[] extensionData)
		{
			return null;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x526C440", Offset = "0x526B040", VA = "0x18526C440")]
		public static CertificateStatusRequest ReadStatusRequestExtension(byte[] extensionData)
		{
			return null;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x526C000", Offset = "0x526AC00", VA = "0x18526C000")]
		public static bool ReadTruncatedHMacExtension(byte[] extensionData)
		{
			return default(bool);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TlsExtensionsUtilities()
		{
		}
	}
}
