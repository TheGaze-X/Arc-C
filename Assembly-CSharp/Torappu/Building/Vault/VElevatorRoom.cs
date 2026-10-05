using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A4B RID: 6731
	[Token(Token = "0x2001A4B")]
	public class VElevatorRoom : VRoom
	{
		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x0600A8FA RID: 43258 RVA: 0x000417A8 File Offset: 0x0003F9A8
		[Token(Token = "0x170013A8")]
		public VElevatorRoom.ElevatorObj elevatorObj
		{
			[Token(Token = "0x600A8FA")]
			[Address(RVA = "0x3240CA0", Offset = "0x323F8A0", VA = "0x183240CA0")]
			get
			{
				return default(VElevatorRoom.ElevatorObj);
			}
		}

		// Token: 0x0600A8FB RID: 43259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8FB")]
		[Address(RVA = "0x32405A0", Offset = "0x323F1A0", VA = "0x1832405A0", Slot = "4")]
		public override void Init(VRoomSlot slot, RoomSlotModel model)
		{
		}

		// Token: 0x0600A8FC RID: 43260 RVA: 0x000417C0 File Offset: 0x0003F9C0
		[Token(Token = "0x600A8FC")]
		[Address(RVA = "0x3240740", Offset = "0x323F340", VA = "0x183240740")]
		private VElevatorRoom.LocationType _GetElevatorType()
		{
			return VElevatorRoom.LocationType.TOP;
		}

		// Token: 0x0600A8FD RID: 43261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8FD")]
		[Address(RVA = "0x3240AA0", Offset = "0x323F6A0", VA = "0x183240AA0")]
		private void _RefreshGraphic()
		{
		}

		// Token: 0x0600A8FE RID: 43262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8FE")]
		[Address(RVA = "0x32406A0", Offset = "0x323F2A0", VA = "0x1832406A0", Slot = "8")]
		public override void OnEnter()
		{
		}

		// Token: 0x0600A8FF RID: 43263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8FF")]
		[Address(RVA = "0x3240C20", Offset = "0x323F820", VA = "0x183240C20")]
		public VElevatorRoom()
		{
		}

		// Token: 0x0600A900 RID: 43264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A900")]
		[Address(RVA = "0x3240730", Offset = "0x323F330", VA = "0x183240730")]
		private void <>xLuaBaseProxy_Init(VRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600A901 RID: 43265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A901")]
		[Address(RVA = "0x323F7E0", Offset = "0x323E3E0", VA = "0x18323F7E0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400A10E RID: 41230
		[Token(Token = "0x400A10E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private VElevatorRoom.ObjectShowOrNot[] _objectsShowOrNot;

		// Token: 0x0400A10F RID: 41231
		[Token(Token = "0x400A10F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _elevatorObj;

		// Token: 0x0400A110 RID: 41232
		[Token(Token = "0x400A110")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _shellObj;

		// Token: 0x0400A111 RID: 41233
		[Token(Token = "0x400A111")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Material _topMaterial;

		// Token: 0x0400A112 RID: 41234
		[Token(Token = "0x400A112")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Material _normalMaterial;

		// Token: 0x0400A113 RID: 41235
		[Token(Token = "0x400A113")]
		[FieldOffset(Offset = "0xA8")]
		private VElevatorRoom.LocationType m_locationType;

		// Token: 0x0400A114 RID: 41236
		[Token(Token = "0x400A114")]
		[FieldOffset(Offset = "0xB0")]
		private VElevatorRoom.ElevatorObj m_elevatorObj;

		// Token: 0x0400A115 RID: 41237
		[Token(Token = "0x400A115")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_elevatorObj;

		// Token: 0x0400A116 RID: 41238
		[Token(Token = "0x400A116")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400A117 RID: 41239
		[Token(Token = "0x400A117")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetElevatorType;

		// Token: 0x0400A118 RID: 41240
		[Token(Token = "0x400A118")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshGraphic;

		// Token: 0x0400A119 RID: 41241
		[Token(Token = "0x400A119")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A11A RID: 41242
		[Token(Token = "0x400A11A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A4C RID: 6732
		[Token(Token = "0x2001A4C")]
		[Serializable]
		private struct ObjectShowOrNot
		{
			// Token: 0x0400A11B RID: 41243
			[Token(Token = "0x400A11B")]
			[FieldOffset(Offset = "0x0")]
			public VElevatorRoom.LocationType[] locationTypes;

			// Token: 0x0400A11C RID: 41244
			[Token(Token = "0x400A11C")]
			[FieldOffset(Offset = "0x8")]
			public GameObject obj;
		}

		// Token: 0x02001A4D RID: 6733
		[Token(Token = "0x2001A4D")]
		public struct ElevatorObj
		{
			// Token: 0x0400A11D RID: 41245
			[Token(Token = "0x400A11D")]
			[FieldOffset(Offset = "0x0")]
			public GameObject elevatorObj;

			// Token: 0x0400A11E RID: 41246
			[Token(Token = "0x400A11E")]
			[FieldOffset(Offset = "0x8")]
			public VElevatorRoom room;
		}

		// Token: 0x02001A4E RID: 6734
		[Token(Token = "0x2001A4E")]
		private enum LocationType
		{
			// Token: 0x0400A120 RID: 41248
			[Token(Token = "0x400A120")]
			TOP,
			// Token: 0x0400A121 RID: 41249
			[Token(Token = "0x400A121")]
			MID,
			// Token: 0x0400A122 RID: 41250
			[Token(Token = "0x400A122")]
			BOTTOM,
			// Token: 0x0400A123 RID: 41251
			[Token(Token = "0x400A123")]
			TOP_AND_BOT
		}
	}
}
