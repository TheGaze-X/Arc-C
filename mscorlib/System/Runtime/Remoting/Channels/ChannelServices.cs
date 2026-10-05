using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Channels
{
	// Token: 0x0200039A RID: 922
	[Token(Token = "0x200039A")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class ChannelServices
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000379")]
		internal static CrossContextChannel CrossContextChannel
		{
			[Token(Token = "0x6001DC9")]
			[Address(RVA = "0x4B766C0", Offset = "0x4B752C0", VA = "0x184B766C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x4B73B80", Offset = "0x4B72780", VA = "0x184B73B80")]
		internal static System.Runtime.Remoting.Messaging.IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri)
		{
			return null;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DCB")]
		[Address(RVA = "0x4B73A70", Offset = "0x4B72670", VA = "0x184B73A70")]
		internal static System.Runtime.Remoting.Messaging.IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri)
		{
			return null;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCC")]
		[Address(RVA = "0x4B76320", Offset = "0x4B74F20", VA = "0x184B76320")]
		[System.Obsolete("Use RegisterChannel(IChannel,Boolean)")]
		public static void RegisterChannel(IChannel chnl)
		{
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCD")]
		[Address(RVA = "0x4B75C70", Offset = "0x4B74870", VA = "0x184B75C70")]
		public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
		{
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DCE")]
		[Address(RVA = "0x4B74AF0", Offset = "0x4B736F0", VA = "0x184B74AF0")]
		internal static void RegisterChannelConfig(ChannelData channel)
		{
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DCF")]
		[Address(RVA = "0x4B743B0", Offset = "0x4B72FB0", VA = "0x184B743B0")]
		private static object CreateProvider(ProviderData prov)
		{
			return null;
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DD0")]
		[Address(RVA = "0x4B76370", Offset = "0x4B74F70", VA = "0x184B76370")]
		public static System.Runtime.Remoting.Messaging.IMessage SyncDispatchMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DD1")]
		[Address(RVA = "0x4B736D0", Offset = "0x4B722D0", VA = "0x184B736D0")]
		private static System.Runtime.Remoting.Messaging.ReturnMessage CheckIncomingMessage(System.Runtime.Remoting.Messaging.IMessage msg)
		{
			return null;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x4B738F0", Offset = "0x4B724F0", VA = "0x184B738F0")]
		internal static System.Runtime.Remoting.Messaging.IMessage CheckReturnMessage(System.Runtime.Remoting.Messaging.IMessage callMsg, System.Runtime.Remoting.Messaging.IMessage retMsg)
		{
			return null;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00012C90 File Offset: 0x00010E90
		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private static bool IsLocalCall(System.Runtime.Remoting.Messaging.IMessage callMsg)
		{
			return default(bool);
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0x4B74700", Offset = "0x4B73300", VA = "0x184B74700")]
		internal static object[] GetCurrentChannelInfo()
		{
			return null;
		}

		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Collections.ArrayList registeredChannels;

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static System.Collections.ArrayList delayedClientChannels;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CrossContextChannel _crossContextSink;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static string CrossContextUrl;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static System.Collections.IList oldStartModeTypes;
	}
}
