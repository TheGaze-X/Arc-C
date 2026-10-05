using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using Torappu.GraphicEffect.Reflection;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A46 RID: 6726
	[Token(Token = "0x2001A46")]
	public class VDIYRoom : VRoom, DIYRoom.IListener
	{
		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x0600A8CF RID: 43215 RVA: 0x00041730 File Offset: 0x0003F930
		[Token(Token = "0x170013A6")]
		public int roomIndex
		{
			[Token(Token = "0x600A8CF")]
			[Address(RVA = "0x32404E0", Offset = "0x323F0E0", VA = "0x1832404E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013A7")]
		public List<VFurnitureEntity> vFurnitureList
		{
			[Token(Token = "0x600A8D0")]
			[Address(RVA = "0x3240540", Offset = "0x323F140", VA = "0x183240540")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A8D1 RID: 43217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D1")]
		[Address(RVA = "0x323F060", Offset = "0x323DC60", VA = "0x18323F060", Slot = "6")]
		protected override void OnPreInit()
		{
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D2")]
		[Address(RVA = "0x323EFF0", Offset = "0x323DBF0", VA = "0x18323EFF0", Slot = "7")]
		protected override void OnPostInit()
		{
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D3")]
		[Address(RVA = "0x323E5A0", Offset = "0x323D1A0", VA = "0x18323E5A0")]
		public void EnableVFurnitureOutline(bool value)
		{
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D4")]
		[Address(RVA = "0x323E480", Offset = "0x323D080", VA = "0x18323E480")]
		public void EnableFurnitureOutlineBySubType(bool value, BuildingData.FurnitureSubType subType)
		{
		}

		// Token: 0x0600A8D5 RID: 43221 RVA: 0x00041748 File Offset: 0x0003F948
		[Token(Token = "0x600A8D5")]
		[Address(RVA = "0x323E400", Offset = "0x323D000", VA = "0x18323E400")]
		public bool CheckHasInteractFurniture()
		{
			return default(bool);
		}

		// Token: 0x0600A8D6 RID: 43222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D6")]
		[Address(RVA = "0x323F590", Offset = "0x323E190", VA = "0x18323F590")]
		public void StopAllMusicInteractFurniture()
		{
		}

		// Token: 0x0600A8D7 RID: 43223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D7")]
		[Address(RVA = "0x323FC70", Offset = "0x323E870", VA = "0x18323FC70")]
		private void _RefreshFurnitureBridge()
		{
		}

		// Token: 0x0600A8D8 RID: 43224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D8")]
		[Address(RVA = "0x323E9B0", Offset = "0x323D5B0", VA = "0x18323E9B0", Slot = "8")]
		public override void OnEnter()
		{
		}

		// Token: 0x0600A8D9 RID: 43225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8D9")]
		[Address(RVA = "0x323FA60", Offset = "0x323E660", VA = "0x18323FA60", Slot = "11")]
		protected override void UpdateVFurniture(VRoom.Object obj)
		{
		}

		// Token: 0x0600A8DA RID: 43226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DA")]
		[Address(RVA = "0x323E860", Offset = "0x323D460", VA = "0x18323E860", Slot = "12")]
		protected override void OnDestroyRoom()
		{
		}

		// Token: 0x0600A8DB RID: 43227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A8DB")]
		[Address(RVA = "0x323E690", Offset = "0x323D290", VA = "0x18323E690", Slot = "15")]
		protected override BuildingData.ObstacleRect[] GenerateDynamicObstacles(GridPosition gridSize)
		{
			return null;
		}

		// Token: 0x0600A8DC RID: 43228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DC")]
		[Address(RVA = "0x323F3C0", Offset = "0x323DFC0", VA = "0x18323F3C0", Slot = "13")]
		protected override void OnVCharacterUpdated(VCharacter vc)
		{
		}

		// Token: 0x0600A8DD RID: 43229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DD")]
		[Address(RVA = "0x323F270", Offset = "0x323DE70", VA = "0x18323F270", Slot = "14")]
		protected override void OnVCharacterToDestroy(VCharacter vc)
		{
		}

		// Token: 0x0600A8DE RID: 43230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DE")]
		[Address(RVA = "0x323FF40", Offset = "0x323EB40", VA = "0x18323FF40")]
		private void _SetupInternalDIYRoom()
		{
		}

		// Token: 0x0600A8DF RID: 43231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8DF")]
		[Address(RVA = "0x323F0D0", Offset = "0x323DCD0", VA = "0x18323F0D0", Slot = "5")]
		public override void OnSelectChanged(bool isOn)
		{
		}

		// Token: 0x0600A8E0 RID: 43232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E0")]
		[Address(RVA = "0x323F210", Offset = "0x323DE10", VA = "0x18323F210", Slot = "16")]
		public void OnSetup()
		{
		}

		// Token: 0x0600A8E1 RID: 43233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E1")]
		[Address(RVA = "0x323EAC0", Offset = "0x323D6C0", VA = "0x18323EAC0", Slot = "17")]
		public void OnFurnitureRegistered(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600A8E2 RID: 43234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E2")]
		[Address(RVA = "0x323ED10", Offset = "0x323D910", VA = "0x18323ED10", Slot = "18")]
		public void OnFurnitureUnregistered(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600A8E3 RID: 43235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E3")]
		[Address(RVA = "0x323EA40", Offset = "0x323D640", VA = "0x18323EA40", Slot = "19")]
		public void OnFloorModifierChanged(DIYRoomModifier pre, DIYRoomModifier post)
		{
		}

		// Token: 0x0600A8E4 RID: 43236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E4")]
		[Address(RVA = "0x323F510", Offset = "0x323E110", VA = "0x18323F510", Slot = "20")]
		public void OnWallModifierChanged(DIYRoomModifier pre, DIYRoomModifier post)
		{
		}

		// Token: 0x0600A8E5 RID: 43237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E5")]
		[Address(RVA = "0x323EF90", Offset = "0x323DB90", VA = "0x18323EF90", Slot = "21")]
		public void OnIntersectionStateChanged(bool intersect)
		{
		}

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E6")]
		[Address(RVA = "0x32403A0", Offset = "0x323EFA0", VA = "0x1832403A0")]
		public VDIYRoom()
		{
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E7")]
		[Address(RVA = "0x323F860", Offset = "0x323E460", VA = "0x18323F860")]
		private void <>xLuaBaseProxy_OnPreInit()
		{
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E8")]
		[Address(RVA = "0x323F7F0", Offset = "0x323E3F0", VA = "0x18323F7F0")]
		private void <>xLuaBaseProxy_OnPostInit()
		{
		}

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8E9")]
		[Address(RVA = "0x323F7E0", Offset = "0x323E3E0", VA = "0x18323F7E0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8EA")]
		[Address(RVA = "0x323FA50", Offset = "0x323E650", VA = "0x18323FA50")]
		private void <>xLuaBaseProxy_UpdateVFurniture(VRoom.Object P0)
		{
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8EB")]
		[Address(RVA = "0x323F770", Offset = "0x323E370", VA = "0x18323F770")]
		private void <>xLuaBaseProxy_OnDestroyRoom()
		{
		}

		// Token: 0x0600A8EC RID: 43244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A8EC")]
		[Address(RVA = "0x323F6E0", Offset = "0x323E2E0", VA = "0x18323F6E0")]
		private BuildingData.ObstacleRect[] <>xLuaBaseProxy_GenerateDynamicObstacles(GridPosition P0)
		{
			return null;
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8ED")]
		[Address(RVA = "0x323F9D0", Offset = "0x323E5D0", VA = "0x18323F9D0")]
		private void <>xLuaBaseProxy_OnVCharacterUpdated(VCharacter P0)
		{
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8EE")]
		[Address(RVA = "0x323F950", Offset = "0x323E550", VA = "0x18323F950")]
		private void <>xLuaBaseProxy_OnVCharacterToDestroy(VCharacter P0)
		{
		}

		// Token: 0x0600A8EF RID: 43247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A8EF")]
		[Address(RVA = "0x323F8D0", Offset = "0x323E4D0", VA = "0x18323F8D0")]
		private void <>xLuaBaseProxy_OnSelectChanged(bool P0)
		{
		}

		// Token: 0x0400A0E7 RID: 41191
		[Token(Token = "0x400A0E7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DIYRoom _diyRoom;

		// Token: 0x0400A0E8 RID: 41192
		[Token(Token = "0x400A0E8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _reflectFadeHeight;

		// Token: 0x0400A0E9 RID: 41193
		[Token(Token = "0x400A0E9")]
		[FieldOffset(Offset = "0x8C")]
		private int m_roomIndex;

		// Token: 0x0400A0EA RID: 41194
		[Token(Token = "0x400A0EA")]
		[FieldOffset(Offset = "0x90")]
		private ReflectCameraHolder m_reflectCameraHolder;

		// Token: 0x0400A0EB RID: 41195
		[Token(Token = "0x400A0EB")]
		[FieldOffset(Offset = "0x98")]
		private List<MeshRenderer> m_reflectRegistedRenderers;

		// Token: 0x0400A0EC RID: 41196
		[Token(Token = "0x400A0EC")]
		[FieldOffset(Offset = "0xA0")]
		private List<VFurnitureEntity> m_vFurnitureList;

		// Token: 0x0400A0ED RID: 41197
		[Token(Token = "0x400A0ED")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_needBuildInteractSlot;

		// Token: 0x0400A0EE RID: 41198
		[Token(Token = "0x400A0EE")]
		[FieldOffset(Offset = "0xA9")]
		private byte m_buildInteractSlotLatestNonce;

		// Token: 0x0400A0EF RID: 41199
		[Token(Token = "0x400A0EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomIndex;

		// Token: 0x0400A0F0 RID: 41200
		[Token(Token = "0x400A0F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_vFurnitureList;

		// Token: 0x0400A0F1 RID: 41201
		[Token(Token = "0x400A0F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPreInit;

		// Token: 0x0400A0F2 RID: 41202
		[Token(Token = "0x400A0F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400A0F3 RID: 41203
		[Token(Token = "0x400A0F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EnableVFurnitureOutline;

		// Token: 0x0400A0F4 RID: 41204
		[Token(Token = "0x400A0F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EnableFurnitureOutlineBySubType;

		// Token: 0x0400A0F5 RID: 41205
		[Token(Token = "0x400A0F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckHasInteractFurniture;

		// Token: 0x0400A0F6 RID: 41206
		[Token(Token = "0x400A0F6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StopAllMusicInteractFurniture;

		// Token: 0x0400A0F7 RID: 41207
		[Token(Token = "0x400A0F7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshFurnitureBridge;

		// Token: 0x0400A0F8 RID: 41208
		[Token(Token = "0x400A0F8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A0F9 RID: 41209
		[Token(Token = "0x400A0F9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateVFurniture;

		// Token: 0x0400A0FA RID: 41210
		[Token(Token = "0x400A0FA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroyRoom;

		// Token: 0x0400A0FB RID: 41211
		[Token(Token = "0x400A0FB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GenerateDynamicObstacles;

		// Token: 0x0400A0FC RID: 41212
		[Token(Token = "0x400A0FC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnVCharacterUpdated;

		// Token: 0x0400A0FD RID: 41213
		[Token(Token = "0x400A0FD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnVCharacterToDestroy;

		// Token: 0x0400A0FE RID: 41214
		[Token(Token = "0x400A0FE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetupInternalDIYRoom;

		// Token: 0x0400A0FF RID: 41215
		[Token(Token = "0x400A0FF")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnSelectChanged;

		// Token: 0x0400A100 RID: 41216
		[Token(Token = "0x400A100")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnSetup;

		// Token: 0x0400A101 RID: 41217
		[Token(Token = "0x400A101")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnFurnitureRegistered;

		// Token: 0x0400A102 RID: 41218
		[Token(Token = "0x400A102")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnFurnitureUnregistered;

		// Token: 0x0400A103 RID: 41219
		[Token(Token = "0x400A103")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnFloorModifierChanged;

		// Token: 0x0400A104 RID: 41220
		[Token(Token = "0x400A104")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnWallModifierChanged;

		// Token: 0x0400A105 RID: 41221
		[Token(Token = "0x400A105")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnIntersectionStateChanged;

		// Token: 0x0400A106 RID: 41222
		[Token(Token = "0x400A106")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
