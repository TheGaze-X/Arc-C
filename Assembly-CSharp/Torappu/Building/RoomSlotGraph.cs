using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001800 RID: 6144
	[Token(Token = "0x2001800")]
	public class RoomSlotGraph : IHotfixable
	{
		// Token: 0x06009B6A RID: 39786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B6A")]
		[Address(RVA = "0x3162CD0", Offset = "0x31618D0", VA = "0x183162CD0")]
		public void LoadData(List<RoomSlotModel> layout)
		{
		}

		// Token: 0x06009B6B RID: 39787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B6B")]
		[Address(RVA = "0x3162BA0", Offset = "0x31617A0", VA = "0x183162BA0")]
		public List<RoomSlotGraph.Edge> GetConnectedSlots(string slotId)
		{
			return null;
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x0003C7E0 File Offset: 0x0003A9E0
		[Token(Token = "0x6009B6C")]
		[Address(RVA = "0x3162C60", Offset = "0x3161860", VA = "0x183162C60")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B6D")]
		[Address(RVA = "0x3162B20", Offset = "0x3161720", VA = "0x183162B20")]
		public void Clear()
		{
		}

		// Token: 0x06009B6E RID: 39790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B6E")]
		[Address(RVA = "0x3163290", Offset = "0x3161E90", VA = "0x183163290")]
		private void _LoadDataInternal(List<RoomSlotModel> layout)
		{
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B6F")]
		[Address(RVA = "0x3163AF0", Offset = "0x31626F0", VA = "0x183163AF0")]
		private void _TryMakeConnection(RoomSlotModel slot, RoomSlotModel nextSlot, SharedConsts.Direction type)
		{
		}

		// Token: 0x06009B70 RID: 39792 RVA: 0x0003C7F8 File Offset: 0x0003A9F8
		[Token(Token = "0x6009B70")]
		[Address(RVA = "0x3163170", Offset = "0x3161D70", VA = "0x183163170")]
		private bool _IsRoomConnected(RoomSlotModel a, RoomSlotModel b, SharedConsts.Direction type)
		{
			return default(bool);
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B71")]
		[Address(RVA = "0x3162ED0", Offset = "0x3161AD0", VA = "0x183162ED0")]
		private void _AddEdge(string fromSlot, string toSlot, SharedConsts.Direction type)
		{
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B72")]
		[Address(RVA = "0x3162D90", Offset = "0x3161990", VA = "0x183162D90")]
		public void QueryConnection(string slotId, Action<string> action)
		{
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B73")]
		[Address(RVA = "0x3163CF0", Offset = "0x31628F0", VA = "0x183163CF0")]
		public RoomSlotGraph()
		{
		}

		// Token: 0x040091F2 RID: 37362
		[Token(Token = "0x40091F2")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary<string, List<RoomSlotGraph.Edge>> m_graph;

		// Token: 0x040091F3 RID: 37363
		[Token(Token = "0x40091F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040091F4 RID: 37364
		[Token(Token = "0x40091F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetConnectedSlots;

		// Token: 0x040091F5 RID: 37365
		[Token(Token = "0x40091F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x040091F6 RID: 37366
		[Token(Token = "0x40091F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x040091F7 RID: 37367
		[Token(Token = "0x40091F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadDataInternal;

		// Token: 0x040091F8 RID: 37368
		[Token(Token = "0x40091F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryMakeConnection;

		// Token: 0x040091F9 RID: 37369
		[Token(Token = "0x40091F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsRoomConnected;

		// Token: 0x040091FA RID: 37370
		[Token(Token = "0x40091FA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddEdge;

		// Token: 0x040091FB RID: 37371
		[Token(Token = "0x40091FB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_QueryConnection;

		// Token: 0x040091FC RID: 37372
		[Token(Token = "0x40091FC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001801 RID: 6145
		[Token(Token = "0x2001801")]
		public struct Edge
		{
			// Token: 0x040091FD RID: 37373
			[Token(Token = "0x40091FD")]
			[FieldOffset(Offset = "0x0")]
			public SharedConsts.Direction direction;

			// Token: 0x040091FE RID: 37374
			[Token(Token = "0x40091FE")]
			[FieldOffset(Offset = "0x8")]
			public string toSlot;
		}
	}
}
