using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002667 RID: 9831
	[Token(Token = "0x2002667")]
	public class MultiEventListener
	{
		// Token: 0x0601012F RID: 65839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601012F")]
		[Address(RVA = "0x7CD910", Offset = "0x7CC510", VA = "0x1807CD910")]
		public void Bind(Entity.Event ev, Entity owner)
		{
		}

		// Token: 0x06010130 RID: 65840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010130")]
		[Address(RVA = "0x7CDA80", Offset = "0x7CC680", VA = "0x1807CDA80")]
		public void Unbind()
		{
		}

		// Token: 0x06010131 RID: 65841 RVA: 0x00062268 File Offset: 0x00060468
		[Token(Token = "0x6010131")]
		[Address(RVA = "0x7CDA60", Offset = "0x7CC660", VA = "0x1807CDA60")]
		public bool CheckReceivedNext()
		{
			return default(bool);
		}

		// Token: 0x06010132 RID: 65842 RVA: 0x00062280 File Offset: 0x00060480
		[Token(Token = "0x6010132")]
		[Address(RVA = "0x7CDA50", Offset = "0x7CC650", VA = "0x1807CDA50")]
		public bool CheckNotReceivedNext()
		{
			return default(bool);
		}

		// Token: 0x06010133 RID: 65843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010133")]
		[Address(RVA = "0x7CDA70", Offset = "0x7CC670", VA = "0x1807CDA70")]
		public void ConsumeNext()
		{
		}

		// Token: 0x06010134 RID: 65844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010134")]
		[Address(RVA = "0x7CDA90", Offset = "0x7CC690", VA = "0x1807CDA90")]
		private void _ClearIfNot()
		{
		}

		// Token: 0x06010135 RID: 65845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010135")]
		[Address(RVA = "0x7CDBF0", Offset = "0x7CC7F0", VA = "0x1807CDBF0")]
		private void _OnReceiveEvent(object arg)
		{
		}

		// Token: 0x06010136 RID: 65846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010136")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MultiEventListener()
		{
		}

		// Token: 0x04011E0E RID: 73230
		[Token(Token = "0x4011E0E")]
		[FieldOffset(Offset = "0x10")]
		private Entity.Event m_cachedEv;

		// Token: 0x04011E0F RID: 73231
		[Token(Token = "0x4011E0F")]
		[FieldOffset(Offset = "0x18")]
		private ObjectPtr<Entity> m_cachedOwner;

		// Token: 0x04011E10 RID: 73232
		[Token(Token = "0x4011E10")]
		[FieldOffset(Offset = "0x28")]
		private int m_receivedEventCounter;

		// Token: 0x04011E11 RID: 73233
		[Token(Token = "0x4011E11")]
		[FieldOffset(Offset = "0x2C")]
		private int m_consumedEventCounter;
	}
}
