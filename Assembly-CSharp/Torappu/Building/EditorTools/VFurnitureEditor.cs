using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using UnityEngine;

namespace Torappu.Building.EditorTools
{
	// Token: 0x02001A96 RID: 6806
	[Token(Token = "0x2001A96")]
	[ExecuteInEditMode]
	public class VFurnitureEditor : MonoBehaviour
	{
		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x0600AB84 RID: 43908 RVA: 0x000425A0 File Offset: 0x000407A0
		// (set) Token: 0x0600AB85 RID: 43909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700143D")]
		[Inspect]
		[ReadOnly]
		public bool isLoaded
		{
			[Token(Token = "0x600AB84")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AB85")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x0600AB86 RID: 43910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700143E")]
		private string furnitureID
		{
			[Token(Token = "0x600AB86")]
			[Address(RVA = "0x32882D0", Offset = "0x3286ED0", VA = "0x1832882D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600AB87 RID: 43911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700143F")]
		public VGridPlane obstaclePlane
		{
			[Token(Token = "0x600AB87")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB88")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public VFurnitureEditor()
		{
		}

		// Token: 0x0400A3BA RID: 41914
		[Token(Token = "0x400A3BA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingDB _buildingDB;

		// Token: 0x0400A3BB RID: 41915
		[Token(Token = "0x400A3BB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingLocalDataDB _buildingLocalDataDB;

		// Token: 0x0400A3BD RID: 41917
		[Token(Token = "0x400A3BD")]
		[FieldOffset(Offset = "0x30")]
		[Inspect(Priority = 10)]
		[ReadOnly]
		[Group("Internal")]
		private BuildingData.ObstacleData m_obstacleData;

		// Token: 0x0400A3BE RID: 41918
		[Token(Token = "0x400A3BE")]
		[FieldOffset(Offset = "0x38")]
		private VGridPlane m_obstaclePlane;
	}
}
