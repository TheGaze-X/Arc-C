using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x020017B8 RID: 6072
	[Token(Token = "0x20017B8")]
	public abstract class AbstractRoomSlot : MonoBehaviour, RoomSlotModel.IListener
	{
		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x06009980 RID: 39296
		// (set) Token: 0x06009981 RID: 39297
		[Token(Token = "0x17001086")]
		public abstract bool isOn { [Token(Token = "0x6009980")] get; [Token(Token = "0x6009981")] set; }

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x06009982 RID: 39298 RVA: 0x0003BA78 File Offset: 0x00039C78
		[Token(Token = "0x17001087")]
		public GridPosition offset
		{
			[Token(Token = "0x6009982")]
			[Address(RVA = "0x3135A70", Offset = "0x3134670", VA = "0x183135A70")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06009983 RID: 39299 RVA: 0x0003BA90 File Offset: 0x00039C90
		[Token(Token = "0x17001088")]
		public GridPosition size
		{
			[Token(Token = "0x6009983")]
			[Address(RVA = "0x3135B40", Offset = "0x3134740", VA = "0x183135B40")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06009984 RID: 39300 RVA: 0x0003BAA8 File Offset: 0x00039CA8
		[Token(Token = "0x17001089")]
		public GridPosition rightBottomOffset
		{
			[Token(Token = "0x6009984")]
			[Address(RVA = "0x3135A90", Offset = "0x3134690", VA = "0x183135A90")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06009985 RID: 39301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108A")]
		public RoomSlotModel model
		{
			[Token(Token = "0x6009985")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06009986 RID: 39302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108B")]
		protected BuildingData.RoomData data
		{
			[Token(Token = "0x6009986")]
			[Address(RVA = "0x3135A50", Offset = "0x3134650", VA = "0x183135A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06009987 RID: 39303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108C")]
		protected BuildingData.LayoutData.RoomSlot slot
		{
			[Token(Token = "0x6009987")]
			[Address(RVA = "0x3135B60", Offset = "0x3134760", VA = "0x183135B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x06009988 RID: 39304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700108D")]
		protected BuildingData.IRoomBean bean
		{
			[Token(Token = "0x6009988")]
			[Address(RVA = "0x3135A30", Offset = "0x3134630", VA = "0x183135A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009989")]
		[Address(RVA = "0x31359D0", Offset = "0x31345D0", VA = "0x1831359D0")]
		public void Register(RoomSlotModel model)
		{
		}

		// Token: 0x0600998A RID: 39306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998A")]
		[Address(RVA = "0x3104A50", Offset = "0x3103650", VA = "0x183104A50", Slot = "9")]
		protected virtual void Init()
		{
		}

		// Token: 0x0600998B RID: 39307
		[Token(Token = "0x600998B")]
		protected abstract void OnInit();

		// Token: 0x0600998C RID: 39308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998C")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "11")]
		public virtual void OnRegister(RoomSlotModel model)
		{
		}

		// Token: 0x0600998D RID: 39309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public virtual void OnContentChange(RoomSlotModel model)
		{
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		public virtual void OnPostLayoutContentChanged()
		{
		}

		// Token: 0x0600998F RID: 39311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998F")]
		[Address(RVA = "0x31359B0", Offset = "0x31345B0", VA = "0x1831359B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009990")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected AbstractRoomSlot()
		{
		}

		// Token: 0x04008FB2 RID: 36786
		[Token(Token = "0x4008FB2")]
		[FieldOffset(Offset = "0x18")]
		private RoomSlotModel m_model;
	}
}
