using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042EF RID: 17135
	[Token(Token = "0x20042EF")]
	public class SandboxV2DungeonZoneViewModel : IHotfixable
	{
		// Token: 0x0601A568 RID: 107880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A568")]
		[Address(RVA = "0x13492F0", Offset = "0x1347EF0", VA = "0x1813492F0")]
		public void LoadData(SandboxV2DungeonZoneViewModel.LoadParam loadParam)
		{
		}

		// Token: 0x0601A569 RID: 107881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A569")]
		[Address(RVA = "0x13494B0", Offset = "0x13480B0", VA = "0x1813494B0")]
		public void UpdateData(SandboxV2DungeonZoneViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A56A RID: 107882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A56A")]
		[Address(RVA = "0x1349570", Offset = "0x1348170", VA = "0x181349570")]
		public SandboxV2DungeonZoneViewModel()
		{
		}

		// Token: 0x040216A0 RID: 136864
		[Token(Token = "0x40216A0")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x040216A1 RID: 136865
		[Token(Token = "0x40216A1")]
		[FieldOffset(Offset = "0x18")]
		public string zoneName;

		// Token: 0x040216A2 RID: 136866
		[Token(Token = "0x40216A2")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2MapZoneData mapZoneData;

		// Token: 0x040216A3 RID: 136867
		[Token(Token = "0x40216A3")]
		[FieldOffset(Offset = "0x28")]
		public List<string> nodes;

		// Token: 0x040216A4 RID: 136868
		[Token(Token = "0x40216A4")]
		[FieldOffset(Offset = "0x30")]
		public bool isShow;

		// Token: 0x040216A5 RID: 136869
		[Token(Token = "0x40216A5")]
		[FieldOffset(Offset = "0x31")]
		public bool unlocked;

		// Token: 0x040216A6 RID: 136870
		[Token(Token = "0x40216A6")]
		[FieldOffset(Offset = "0x34")]
		public SandboxV2WeatherType zoneWeatherType;

		// Token: 0x040216A7 RID: 136871
		[Token(Token = "0x40216A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040216A8 RID: 136872
		[Token(Token = "0x40216A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040216A9 RID: 136873
		[Token(Token = "0x40216A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042F0 RID: 17136
		[Token(Token = "0x20042F0")]
		public struct LoadParam
		{
			// Token: 0x040216AA RID: 136874
			[Token(Token = "0x40216AA")]
			[FieldOffset(Offset = "0x0")]
			public string zoneId;

			// Token: 0x040216AB RID: 136875
			[Token(Token = "0x40216AB")]
			[FieldOffset(Offset = "0x8")]
			public PlayerSandboxV2 playerTopicData;

			// Token: 0x040216AC RID: 136876
			[Token(Token = "0x40216AC")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2MapData mapData;

			// Token: 0x040216AD RID: 136877
			[Token(Token = "0x40216AD")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2Data topicDetailData;
		}

		// Token: 0x020042F1 RID: 17137
		[Token(Token = "0x20042F1")]
		public struct UpdateParam
		{
			// Token: 0x040216AE RID: 136878
			[Token(Token = "0x40216AE")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2Data topicDetailData;

			// Token: 0x040216AF RID: 136879
			[Token(Token = "0x40216AF")]
			[FieldOffset(Offset = "0x8")]
			public PlayerSandboxV2.Dungeon playerDungeonData;

			// Token: 0x040216B0 RID: 136880
			[Token(Token = "0x40216B0")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Dungeon.Zone playerZoneData;
		}
	}
}
