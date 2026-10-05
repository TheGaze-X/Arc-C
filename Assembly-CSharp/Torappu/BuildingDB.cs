using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.DIY.UI;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005AD RID: 1453
	[Token(Token = "0x20005AD")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/BuildingDB")]
	[Serializable]
	public class BuildingDB : ConstTable<BuildingData, BuildingDB>
	{
		// Token: 0x0600609E RID: 24734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609E")]
		[Address(RVA = "0x1CE5790", Offset = "0x1CE4390", VA = "0x181CE5790", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600609F")]
		[Address(RVA = "0x1CE5270", Offset = "0x1CE3E70", VA = "0x181CE5270")]
		public void LoadBuildingTable()
		{
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x0002F5E0 File Offset: 0x0002D7E0
		[Token(Token = "0x60060A0")]
		[Address(RVA = "0x1CE60F0", Offset = "0x1CE4CF0", VA = "0x181CE60F0")]
		public bool TryGetRoom(string id, out BuildingData.RoomData room, out BuildingData.IRoomBean bean)
		{
			return default(bool);
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x0002F5F8 File Offset: 0x0002D7F8
		[Token(Token = "0x60060A1")]
		[Address(RVA = "0x1CE5D90", Offset = "0x1CE4990", VA = "0x181CE5D90")]
		public bool TryGetRoomData(string id, out BuildingData.RoomData room)
		{
			return default(bool);
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x0002F610 File Offset: 0x0002D810
		[Token(Token = "0x60060A2")]
		[Address(RVA = "0x1CE5E80", Offset = "0x1CE4A80", VA = "0x181CE5E80")]
		public bool TryGetRoomData(BuildingData.RoomType type, out BuildingData.RoomData room)
		{
			return default(bool);
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x0002F628 File Offset: 0x0002D828
		[Token(Token = "0x60060A3")]
		[Address(RVA = "0x1CE5BC0", Offset = "0x1CE47C0", VA = "0x181CE5BC0")]
		public bool TryGetItemFormula(string itemId, out string formulaId)
		{
			return default(bool);
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x0002F640 File Offset: 0x0002D840
		[Token(Token = "0x60060A4")]
		[Address(RVA = "0x1CE6000", Offset = "0x1CE4C00", VA = "0x181CE6000")]
		public bool TryGetRoomPrefab(string prefabId, out BuildingData.PrefabInfo prefabInfo)
		{
			return default(bool);
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x0002F658 File Offset: 0x0002D858
		[Token(Token = "0x60060A5")]
		[Address(RVA = "0x1CE5AB0", Offset = "0x1CE46B0", VA = "0x181CE5AB0")]
		public bool TryGetFurnitureData(string id, out BuildingData.CustomData.FurnitureData furnitureData)
		{
			return default(bool);
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060A6")]
		[Address(RVA = "0x1CE4DE0", Offset = "0x1CE39E0", VA = "0x181CE4DE0")]
		public string[] GetAllFurnitureNames()
		{
			return null;
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060A7")]
		[Address(RVA = "0x1CE55E0", Offset = "0x1CE41E0", VA = "0x181CE55E0")]
		public List<BuildingData.CustomData.FurnitureTypeData> LoadTypes(BuildingData.RoomType selectedRoomId = BuildingData.RoomType.NONE, bool filterRoomType = false)
		{
			return null;
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060A8")]
		[Address(RVA = "0x1CE5330", Offset = "0x1CE3F30", VA = "0x181CE5330")]
		public List<BuildingData.FurnitureSubType> LoadSubTypesByType(BuildingData.FurnitureType type, BuildingData.RoomType selectedRoomId = BuildingData.RoomType.NONE, bool filterRoomType = false)
		{
			return null;
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060A9")]
		[Address(RVA = "0x1CE5170", Offset = "0x1CE3D70", VA = "0x181CE5170")]
		public string GetSubTypeDisplayName(BuildingData.FurnitureSubType subType)
		{
			return null;
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AA")]
		[Address(RVA = "0x1CE4FC0", Offset = "0x1CE3BC0", VA = "0x181CE4FC0")]
		public string GetFurnitureTypeDisplayName(BuildingData.FurnitureType type)
		{
			return null;
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AB")]
		[Address(RVA = "0x1CE4EC0", Offset = "0x1CE3AC0", VA = "0x181CE4EC0")]
		public string GetFilterDisplayName(DIYFilterType filterType)
		{
			return null;
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060AC")]
		[Address(RVA = "0x1CE58A0", Offset = "0x1CE44A0", VA = "0x181CE58A0")]
		public void QueryRoomDataByCategoryAndSize(BuildingData.RoomCategory category, GridPosition size, Action<BuildingData.RoomData> action)
		{
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060AD")]
		[Address(RVA = "0x1CE50C0", Offset = "0x1CE3CC0", VA = "0x181CE50C0")]
		public BuildingData.IRoomBean GetRoomBean(BuildingData.RoomType type)
		{
			return null;
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x0002F670 File Offset: 0x0002D870
		[Token(Token = "0x60060AE")]
		[Address(RVA = "0x1CE5CB0", Offset = "0x1CE48B0", VA = "0x181CE5CB0")]
		public bool TryGetLayout(string id, out BuildingData.LayoutData layout)
		{
			return default(bool);
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x0002F688 File Offset: 0x0002D888
		[Token(Token = "0x60060AF")]
		[Address(RVA = "0x1CE6240", Offset = "0x1CE4E40", VA = "0x181CE6240")]
		public bool TryGetStorey(string storeyId, out BuildingData.LayoutData.StoreyData storeyData)
		{
			return default(bool);
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x0002F6A0 File Offset: 0x0002D8A0
		[Token(Token = "0x60060B0")]
		[Address(RVA = "0x1CE4CB0", Offset = "0x1CE38B0", VA = "0x181CE4CB0")]
		public bool CheckIfSkinInteractable(string interactId, string skinId)
		{
			return default(bool);
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B1")]
		[Address(RVA = "0x1CE6C30", Offset = "0x1CE5830", VA = "0x181CE6C30")]
		private Dictionary<BuildingData.RoomType, BuildingData.IRoomBean> _LoadRoomBeans()
		{
			return null;
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B2")]
		[Address(RVA = "0x1CE6390", Offset = "0x1CE4F90", VA = "0x181CE6390")]
		private string[] _LoadAllFurnitureNames()
		{
			return null;
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B3")]
		[Address(RVA = "0x1CE6700", Offset = "0x1CE5300", VA = "0x181CE6700")]
		private Dictionary<string, HashSet<string>> _LoadInteractSkinInfo()
		{
			return null;
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060B4")]
		[Address(RVA = "0x1CE69E0", Offset = "0x1CE55E0", VA = "0x181CE69E0")]
		private Dictionary<string, string> _LoadItemFormulatInfo()
		{
			return null;
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060B5")]
		[Address(RVA = "0x1CE6E70", Offset = "0x1CE5A70", VA = "0x181CE6E70")]
		public BuildingDB()
		{
		}

		// Token: 0x04002A1A RID: 10778
		[Token(Token = "0x4002A1A")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		private Dictionary<BuildingData.RoomType, BuildingData.IRoomBean> m_beans;

		// Token: 0x04002A1B RID: 10779
		[Token(Token = "0x4002A1B")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		private string[] m_furnitureNames;

		// Token: 0x04002A1C RID: 10780
		[Token(Token = "0x4002A1C")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		private Dictionary<string, HashSet<string>> m_interactSkinInfo;

		// Token: 0x04002A1D RID: 10781
		[Token(Token = "0x4002A1D")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		private Dictionary<string, string> m_formaulaInfo;

		// Token: 0x04002A1E RID: 10782
		[Token(Token = "0x4002A1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04002A1F RID: 10783
		[Token(Token = "0x4002A1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadBuildingTable;

		// Token: 0x04002A20 RID: 10784
		[Token(Token = "0x4002A20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetRoom;

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryGetRoomData;

		// Token: 0x04002A22 RID: 10786
		[Token(Token = "0x4002A22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_TryGetRoomData;

		// Token: 0x04002A23 RID: 10787
		[Token(Token = "0x4002A23")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryGetItemFormula;

		// Token: 0x04002A24 RID: 10788
		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryGetRoomPrefab;

		// Token: 0x04002A25 RID: 10789
		[Token(Token = "0x4002A25")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetFurnitureData;

		// Token: 0x04002A26 RID: 10790
		[Token(Token = "0x4002A26")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetAllFurnitureNames;

		// Token: 0x04002A27 RID: 10791
		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadTypes;

		// Token: 0x04002A28 RID: 10792
		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadSubTypesByType;

		// Token: 0x04002A29 RID: 10793
		[Token(Token = "0x4002A29")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSubTypeDisplayName;

		// Token: 0x04002A2A RID: 10794
		[Token(Token = "0x4002A2A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetFurnitureTypeDisplayName;

		// Token: 0x04002A2B RID: 10795
		[Token(Token = "0x4002A2B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetFilterDisplayName;

		// Token: 0x04002A2C RID: 10796
		[Token(Token = "0x4002A2C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_QueryRoomDataByCategoryAndSize;

		// Token: 0x04002A2D RID: 10797
		[Token(Token = "0x4002A2D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetRoomBean;

		// Token: 0x04002A2E RID: 10798
		[Token(Token = "0x4002A2E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryGetLayout;

		// Token: 0x04002A2F RID: 10799
		[Token(Token = "0x4002A2F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TryGetStorey;

		// Token: 0x04002A30 RID: 10800
		[Token(Token = "0x4002A30")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CheckIfSkinInteractable;

		// Token: 0x04002A31 RID: 10801
		[Token(Token = "0x4002A31")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadRoomBeans;

		// Token: 0x04002A32 RID: 10802
		[Token(Token = "0x4002A32")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadAllFurnitureNames;

		// Token: 0x04002A33 RID: 10803
		[Token(Token = "0x4002A33")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadInteractSkinInfo;

		// Token: 0x04002A34 RID: 10804
		[Token(Token = "0x4002A34")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__LoadItemFormulatInfo;

		// Token: 0x04002A35 RID: 10805
		[Token(Token = "0x4002A35")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
