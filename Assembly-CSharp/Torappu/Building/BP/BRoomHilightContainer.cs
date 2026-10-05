using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.BP
{
	// Token: 0x02001AC1 RID: 6849
	[Token(Token = "0x2001AC1")]
	[RequireComponent(typeof(RectTransform))]
	public class BRoomHilightContainer : MonoBehaviour
	{
		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x0600AD01 RID: 44289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147D")]
		protected RectTransform rectTrans
		{
			[Token(Token = "0x600AD01")]
			[Address(RVA = "0x3274A90", Offset = "0x3273690", VA = "0x183274A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x0600AD02 RID: 44290 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AD03 RID: 44291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700147E")]
		public string slotId
		{
			[Token(Token = "0x600AD02")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600AD03")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD04")]
		[Address(RVA = "0x32744C0", Offset = "0x32730C0", VA = "0x1832744C0")]
		public static BRoomHilightContainer WrapBRoomSlot(SafeParentComponent targetRoomContainer, BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
			return null;
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD05")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		protected virtual void OnRoomSlotWrapped(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x00042B28 File Offset: 0x00040D28
		[Token(Token = "0x600AD06")]
		[Address(RVA = "0x32743E0", Offset = "0x3272FE0", VA = "0x1832743E0")]
		public bool UnwrapBRoomSlot(SafeParentComponent targetRoomContainer)
		{
			return default(bool);
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD07")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BRoomHilightContainer()
		{
		}

		// Token: 0x0400A53C RID: 42300
		[Token(Token = "0x400A53C")]
		[FieldOffset(Offset = "0x18")]
		private RectTransform m_rectTrans;

		// Token: 0x0400A53D RID: 42301
		[Token(Token = "0x400A53D")]
		[FieldOffset(Offset = "0x20")]
		private BRoomHilightContainer.WrapContext m_wrapContext;

		// Token: 0x02001AC2 RID: 6850
		[Token(Token = "0x2001AC2")]
		private struct WrapContext
		{
			// Token: 0x0600AD08 RID: 44296 RVA: 0x00042B40 File Offset: 0x00040D40
			[Token(Token = "0x600AD08")]
			[Address(RVA = "0x3288500", Offset = "0x3287100", VA = "0x183288500")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600AD09 RID: 44297 RVA: 0x00042B58 File Offset: 0x00040D58
			[Token(Token = "0x600AD09")]
			[Address(RVA = "0x3288340", Offset = "0x3286F40", VA = "0x183288340")]
			public static BRoomHilightContainer.WrapContext Create(BRoomSlot roomSlot)
			{
				return default(BRoomHilightContainer.WrapContext);
			}

			// Token: 0x0600AD0A RID: 44298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD0A")]
			[Address(RVA = "0x3288550", Offset = "0x3287150", VA = "0x183288550")]
			public void RevertRoomProp(SafeParentComponent parent)
			{
			}

			// Token: 0x0600AD0B RID: 44299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD0B")]
			[Address(RVA = "0x3288690", Offset = "0x3287290", VA = "0x183288690")]
			private void _SetRoomProp(Transform trans)
			{
			}

			// Token: 0x0400A53F RID: 42303
			[Token(Token = "0x400A53F")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform roomTrans;

			// Token: 0x0400A540 RID: 42304
			[Token(Token = "0x400A540")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 anchorPos;

			// Token: 0x0400A541 RID: 42305
			[Token(Token = "0x400A541")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 pivot;

			// Token: 0x0400A542 RID: 42306
			[Token(Token = "0x400A542")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 scale;

			// Token: 0x0400A543 RID: 42307
			[Token(Token = "0x400A543")]
			[FieldOffset(Offset = "0x24")]
			public Vector2 anchorMin;

			// Token: 0x0400A544 RID: 42308
			[Token(Token = "0x400A544")]
			[FieldOffset(Offset = "0x2C")]
			public Vector2 anchorMax;
		}
	}
}
