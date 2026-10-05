using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	[Serializable]
	public struct SteamDatagramRelayAuthTicket
	{
		// Token: 0x06000A2D RID: 2605 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Clear()
		{
		}

		// Token: 0x04000ACF RID: 2767
		[Token(Token = "0x4000ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamNetworkingIdentity m_identityGameserver;

		// Token: 0x04000AD0 RID: 2768
		[Token(Token = "0x4000AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private SteamNetworkingIdentity m_identityAuthorizedClient;

		// Token: 0x04000AD1 RID: 2769
		[Token(Token = "0x4000AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private uint m_unPublicIP;

		// Token: 0x04000AD2 RID: 2770
		[Token(Token = "0x4000AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private RTime32 m_rtimeTicketExpiry;

		// Token: 0x04000AD3 RID: 2771
		[Token(Token = "0x4000AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private SteamDatagramHostedAddress m_routing;

		// Token: 0x04000AD4 RID: 2772
		[Token(Token = "0x4000AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private uint m_nAppID;

		// Token: 0x04000AD5 RID: 2773
		[Token(Token = "0x4000AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int m_nRestrictToVirtualPort;

		// Token: 0x04000AD6 RID: 2774
		[Token(Token = "0x4000AD6")]
		private const int k_nMaxExtraFields = 16;

		// Token: 0x04000AD7 RID: 2775
		[Token(Token = "0x4000AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private int m_nExtraFields;

		// Token: 0x04000AD8 RID: 2776
		[Token(Token = "0x4000AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private SteamDatagramRelayAuthTicket.ExtraField[] m_vecExtraFields;

		// Token: 0x020001BD RID: 445
		[Token(Token = "0x20001BD")]
		private struct ExtraField
		{
			// Token: 0x04000AD9 RID: 2777
			[Token(Token = "0x4000AD9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private SteamDatagramRelayAuthTicket.ExtraField.EType m_eType;

			// Token: 0x04000ADA RID: 2778
			[Token(Token = "0x4000ADA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private byte[] m_szName;

			// Token: 0x04000ADB RID: 2779
			[Token(Token = "0x4000ADB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SteamDatagramRelayAuthTicket.ExtraField.OptionValue m_val;

			// Token: 0x020001BE RID: 446
			[Token(Token = "0x20001BE")]
			private enum EType
			{
				// Token: 0x04000ADD RID: 2781
				[Token(Token = "0x4000ADD")]
				k_EType_String,
				// Token: 0x04000ADE RID: 2782
				[Token(Token = "0x4000ADE")]
				k_EType_Int,
				// Token: 0x04000ADF RID: 2783
				[Token(Token = "0x4000ADF")]
				k_EType_Fixed64
			}

			// Token: 0x020001BF RID: 447
			[Token(Token = "0x20001BF")]
			[StructLayout(2)]
			private struct OptionValue
			{
				// Token: 0x04000AE0 RID: 2784
				[Token(Token = "0x4000AE0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private byte[] m_szStringValue;

				// Token: 0x04000AE1 RID: 2785
				[Token(Token = "0x4000AE1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private long m_nIntValue;

				// Token: 0x04000AE2 RID: 2786
				[Token(Token = "0x4000AE2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private ulong m_nFixed64Value;
			}
		}
	}
}
