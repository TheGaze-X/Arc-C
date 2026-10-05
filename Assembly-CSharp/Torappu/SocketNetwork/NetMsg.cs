using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.ObjectPool;

namespace Torappu.SocketNetwork
{
	// Token: 0x02001496 RID: 5270
	[Token(Token = "0x2001496")]
	public class NetMsg : IReusable
	{
		// Token: 0x060079C3 RID: 31171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079C3")]
		[Address(RVA = "0x263CC50", Offset = "0x263B850", VA = "0x18263CC50")]
		public static NetMsg Create()
		{
			return null;
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079C4")]
		[Address(RVA = "0x263CBD0", Offset = "0x263B7D0", VA = "0x18263CBD0")]
		public static NetMsg Create(NetMsgID pid)
		{
			return null;
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079C5")]
		[Address(RVA = "0x263CFE0", Offset = "0x263BBE0", VA = "0x18263CFE0")]
		public static NetMsg Recycle(NetMsg msg)
		{
			return null;
		}

		// Token: 0x060079C6 RID: 31174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C6")]
		[Address(RVA = "0x263CB40", Offset = "0x263B740", VA = "0x18263CB40")]
		public static void ClearPool()
		{
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x060079C7 RID: 31175 RVA: 0x00036A08 File Offset: 0x00034C08
		[Token(Token = "0x17000E89")]
		public static int allAllocatedCnt
		{
			[Token(Token = "0x60079C7")]
			[Address(RVA = "0x263D2C0", Offset = "0x263BEC0", VA = "0x18263D2C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x060079C8 RID: 31176 RVA: 0x00036A20 File Offset: 0x00034C20
		[Token(Token = "0x17000E8A")]
		public static int unusedCnt
		{
			[Token(Token = "0x60079C8")]
			[Address(RVA = "0x263D360", Offset = "0x263BF60", VA = "0x18263D360")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x060079C9 RID: 31177 RVA: 0x00036A38 File Offset: 0x00034C38
		// (set) Token: 0x060079CA RID: 31178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E8B")]
		public NetMsgID id
		{
			[Token(Token = "0x60079C9")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return default(NetMsgID);
			}
			[Token(Token = "0x60079CA")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x060079CB RID: 31179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060079CC RID: 31180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E8C")]
		public ByteArray data
		{
			[Token(Token = "0x60079CB")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60079CC")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CD")]
		[Address(RVA = "0x263D200", Offset = "0x263BE00", VA = "0x18263D200")]
		private NetMsg()
		{
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079CE")]
		[Address(RVA = "0x263D130", Offset = "0x263BD30", VA = "0x18263D130")]
		public void Reset(NetMsgID protocolID)
		{
		}

		// Token: 0x060079CF RID: 31183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079CF")]
		public T ToProtocol<T>() where T : Protocol, new()
		{
			return null;
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D0")]
		[Address(RVA = "0x263CF40", Offset = "0x263BB40", VA = "0x18263CF40")]
		public void Fill(NetMsgID pid, byte[] data, int offset, int len)
		{
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x060079D2 RID: 31186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079D2")]
		[Address(RVA = "0x263CFB0", Offset = "0x263BBB0", VA = "0x18263CFB0", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x040077E0 RID: 30688
		[Token(Token = "0x40077E0")]
		[FieldOffset(Offset = "0x0")]
		private static object s_rsync_obj;

		// Token: 0x040077E1 RID: 30689
		[Token(Token = "0x40077E1")]
		[FieldOffset(Offset = "0x8")]
		private static ObjectPool<NetMsg> s_pool;

		// Token: 0x040077E2 RID: 30690
		[Token(Token = "0x40077E2")]
		[FieldOffset(Offset = "0x10")]
		public static int DEFAULT_MSG_DATA_CAPACITY;

		// Token: 0x040077E3 RID: 30691
		[Token(Token = "0x40077E3")]
		public const int LEN_SIZE = 4;

		// Token: 0x040077E4 RID: 30692
		[Token(Token = "0x40077E4")]
		public const int ID_SIZE = 4;

		// Token: 0x040077E5 RID: 30693
		[Token(Token = "0x40077E5")]
		public const int HEAD_SIZE = 8;
	}
}
