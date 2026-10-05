using System;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200035C RID: 860
	[Token(Token = "0x200035C")]
	[System.Serializable]
	internal class ChannelInfo : IChannelInfo
	{
		// Token: 0x06001C5A RID: 7258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C5A")]
		[Address(RVA = "0x4B53470", Offset = "0x4B52070", VA = "0x184B53470")]
		public ChannelInfo()
		{
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C5B")]
		[Address(RVA = "0x4B534D0", Offset = "0x4B520D0", VA = "0x184B534D0")]
		public ChannelInfo(object remoteChannelData)
		{
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000333")]
		public object[] ChannelData
		{
			[Token(Token = "0x6001C5C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x10")]
		private object[] channelData;
	}
}
