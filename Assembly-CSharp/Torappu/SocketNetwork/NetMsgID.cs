using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork
{
	// Token: 0x02001498 RID: 5272
	[Token(Token = "0x2001498")]
	public struct NetMsgID : IEquatable<NetMsgID>
	{
		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x00036A50 File Offset: 0x00034C50
		// (set) Token: 0x060079D8 RID: 31192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E8D")]
		public uint value
		{
			[Token(Token = "0x60079D7")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60079D8")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060079D9 RID: 31193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D9")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public NetMsgID(uint id)
		{
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00036A68 File Offset: 0x00034C68
		[Token(Token = "0x60079DA")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static implicit operator NetMsgID(uint v)
		{
			return default(NetMsgID);
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x00036A80 File Offset: 0x00034C80
		[Token(Token = "0x60079DB")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		public static implicit operator uint(NetMsgID id)
		{
			return 0U;
		}

		// Token: 0x060079DC RID: 31196 RVA: 0x00036A98 File Offset: 0x00034C98
		[Token(Token = "0x60079DC")]
		[Address(RVA = "0x263CA50", Offset = "0x263B650", VA = "0x18263CA50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x00036AB0 File Offset: 0x00034CB0
		[Token(Token = "0x60079DD")]
		[Address(RVA = "0x263CAE0", Offset = "0x263B6E0", VA = "0x18263CAE0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x00036AC8 File Offset: 0x00034CC8
		[Token(Token = "0x60079DE")]
		[Address(RVA = "0x1DE9950", Offset = "0x1DE8550", VA = "0x181DE9950")]
		public static bool operator ==(NetMsgID lh, NetMsgID rh)
		{
			return default(bool);
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x00036AE0 File Offset: 0x00034CE0
		[Token(Token = "0x60079DF")]
		[Address(RVA = "0x263CB30", Offset = "0x263B730", VA = "0x18263CB30")]
		public static bool operator !=(NetMsgID lh, NetMsgID rh)
		{
			return default(bool);
		}

		// Token: 0x060079E0 RID: 31200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079E0")]
		[Address(RVA = "0x263CB00", Offset = "0x263B700", VA = "0x18263CB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079E1 RID: 31201 RVA: 0x00036AF8 File Offset: 0x00034CF8
		[Token(Token = "0x60079E1")]
		[Address(RVA = "0x263CAD0", Offset = "0x263B6D0", VA = "0x18263CAD0", Slot = "4")]
		public bool Equals(NetMsgID other)
		{
			return default(bool);
		}
	}
}
