using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	public abstract class EventBase<T> : EventBase where T : EventBase<T>, new()
	{
		// Token: 0x06000B45 RID: 2885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B45")]
		protected EventBase()
		{
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x6000B46")]
		public static long TypeId()
		{
			return 0L;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B47")]
		protected override void Init()
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B48")]
		public static T GetPooled()
		{
			return null;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B49")]
		internal static T GetPooled(EventBase e)
		{
			return null;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4A")]
		private static void ReleasePooled(T evt)
		{
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4B")]
		internal override void Acquire()
		{
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4C")]
		public sealed override void Dispose()
		{
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x1700027E")]
		public override long eventTypeId
		{
			[Token(Token = "0x6000B4D")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long s_TypeId;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<T> s_Pool;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x0")]
		private int m_RefCount;
	}
}
