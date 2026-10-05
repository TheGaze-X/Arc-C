using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using UnityEngine;

namespace Torappu.Building.EditorTools
{
	// Token: 0x02001A97 RID: 6807
	[Token(Token = "0x2001A97")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(VRoom))]
	public class VRoomEditor : MonoBehaviour
	{
		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x0600AB89 RID: 43913 RVA: 0x000425B8 File Offset: 0x000407B8
		// (set) Token: 0x0600AB8A RID: 43914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001440")]
		[Inspect]
		[ReadOnly]
		public bool isLoaded
		{
			[Token(Token = "0x600AB89")]
			[Address(RVA = "0x1DBF210", Offset = "0x1DBDE10", VA = "0x181DBF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AB8A")]
			[Address(RVA = "0x1DBF2F0", Offset = "0x1DBDEF0", VA = "0x181DBF2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x0600AB8B RID: 43915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001441")]
		public VGridPlane floorPlane
		{
			[Token(Token = "0x600AB8B")]
			[Address(RVA = "0x3288300", Offset = "0x3286F00", VA = "0x183288300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x0600AB8C RID: 43916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001442")]
		public VGridPlane backwallPlane
		{
			[Token(Token = "0x600AB8C")]
			[Address(RVA = "0x32882E0", Offset = "0x3286EE0", VA = "0x1832882E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x0600AB8D RID: 43917 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AB8E RID: 43918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001443")]
		private protected VRoom room
		{
			[Token(Token = "0x600AB8D")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600AB8E")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x0600AB8F RID: 43919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001444")]
		protected VRoomGraphic graphic
		{
			[Token(Token = "0x600AB8F")]
			[Address(RVA = "0x3288320", Offset = "0x3286F20", VA = "0x183288320")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB90")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public VRoomEditor()
		{
		}

		// Token: 0x0400A3BF RID: 41919
		[Token(Token = "0x400A3BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingDB _buildingDB;

		// Token: 0x0400A3C0 RID: 41920
		[Token(Token = "0x400A3C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingLocalDataDB _buildingLocalDataDB;

		// Token: 0x0400A3C1 RID: 41921
		[Token(Token = "0x400A3C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _prefabId;

		// Token: 0x0400A3C2 RID: 41922
		[Token(Token = "0x400A3C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _obstacleId;

		// Token: 0x0400A3C3 RID: 41923
		[Token(Token = "0x400A3C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingData.RoomType _roomId;

		// Token: 0x0400A3C6 RID: 41926
		[Token(Token = "0x400A3C6")]
		[FieldOffset(Offset = "0x48")]
		[Inspect(Priority = 10)]
		[ReadOnly]
		[Group("Internal")]
		private BuildingData.PrefabInfo m_prefabInfo;

		// Token: 0x0400A3C7 RID: 41927
		[Token(Token = "0x400A3C7")]
		[FieldOffset(Offset = "0x50")]
		[Inspect(Priority = 10)]
		[ReadOnly]
		[Group("Internal")]
		private BuildingData.ObstacleData m_obstacleData;
	}
}
