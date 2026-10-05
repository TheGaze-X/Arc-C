using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AFC RID: 6908
	[Token(Token = "0x2001AFC")]
	[CreateAssetMenu(menuName = "Torappu/Building/UI/BuildingCharSelectRoomConfig")]
	[Serializable]
	public class BuildingCharSelectRoomConfig : ScriptableObject, IHotfixable
	{
		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x0600AE74 RID: 44660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014A2")]
		public List<BuildingCharSelectRoomConfig.RoomConfig> roomConfigs
		{
			[Token(Token = "0x600AE74")]
			[Address(RVA = "0x3290850", Offset = "0x328F450", VA = "0x183290850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AE75 RID: 44661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE75")]
		[Address(RVA = "0x32907F0", Offset = "0x328F3F0", VA = "0x1832907F0")]
		public BuildingCharSelectRoomConfig()
		{
		}

		// Token: 0x0400A71D RID: 42781
		[Token(Token = "0x400A71D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BuildingCharSelectRoomConfig.RoomConfig> _roomConfigs;

		// Token: 0x0400A71E RID: 42782
		[Token(Token = "0x400A71E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomConfigs;

		// Token: 0x0400A71F RID: 42783
		[Token(Token = "0x400A71F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AFD RID: 6909
		[Token(Token = "0x2001AFD")]
		[Serializable]
		public struct RoomConfig
		{
			// Token: 0x0400A720 RID: 42784
			[Token(Token = "0x400A720")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.RoomType type;

			// Token: 0x0400A721 RID: 42785
			[Token(Token = "0x400A721")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;

			// Token: 0x0400A722 RID: 42786
			[Token(Token = "0x400A722")]
			[FieldOffset(Offset = "0x10")]
			public Color color;
		}
	}
}
