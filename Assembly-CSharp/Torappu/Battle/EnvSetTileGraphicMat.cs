using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002297 RID: 8855
	[Token(Token = "0x2002297")]
	public class EnvSetTileGraphicMat : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DECE RID: 57038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DECE")]
		public override void OnEnvEvent<T>(T obj, string status)
		{
		}

		// Token: 0x0600DECF RID: 57039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DECF")]
		[Address(RVA = "0x3655250", Offset = "0x3653E50", VA = "0x183655250", Slot = "19")]
		public override void OnEnvChanged(string status)
		{
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DED0")]
		[Address(RVA = "0x3655380", Offset = "0x3653F80", VA = "0x183655380")]
		private void _DoOptOnMainGraphic(EnvSetTileGraphicMat.MainGraphicStatusSetting setting)
		{
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DED1")]
		[Address(RVA = "0x3655B30", Offset = "0x3654730", VA = "0x183655B30")]
		private void _DoOptOnTile(Tile tile, EnvSetTileGraphicMat.TileStatusSetting setting)
		{
		}

		// Token: 0x0600DED2 RID: 57042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DED2")]
		[Address(RVA = "0x3655FF0", Offset = "0x3654BF0", VA = "0x183655FF0")]
		private EnvSetTileGraphicMat.TileMaterialConfig _GetNewMatConfig(Tile tile)
		{
			return null;
		}

		// Token: 0x0600DED3 RID: 57043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DED3")]
		[Address(RVA = "0x3656410", Offset = "0x3655010", VA = "0x183656410")]
		public EnvSetTileGraphicMat()
		{
		}

		// Token: 0x0600DED4 RID: 57044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DED4")]
		[Address(RVA = "0x3652050", Offset = "0x3650C50", VA = "0x183652050")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0)
		{
		}

		// Token: 0x0400F1D9 RID: 61913
		[Token(Token = "0x400F1D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnvSetTileGraphicMat.TileStatusSetting[] _settings;

		// Token: 0x0400F1DA RID: 61914
		[Token(Token = "0x400F1DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private EnvSetTileGraphicMat.MainGraphicStatusSetting[] _gameObjectSettings;

		// Token: 0x0400F1DB RID: 61915
		[Token(Token = "0x400F1DB")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<Tile, EnvSetTileGraphicMat.TileMaterialConfig> m_tileMaterialDict;

		// Token: 0x0400F1DC RID: 61916
		[Token(Token = "0x400F1DC")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, EnvSetTileGraphicMat.GameObjectMaterialConfig> m_mainGraphicDict;

		// Token: 0x0400F1DD RID: 61917
		[Token(Token = "0x400F1DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnvEvent;

		// Token: 0x0400F1DE RID: 61918
		[Token(Token = "0x400F1DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F1DF RID: 61919
		[Token(Token = "0x400F1DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoOptOnMainGraphic;

		// Token: 0x0400F1E0 RID: 61920
		[Token(Token = "0x400F1E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoOptOnTile;

		// Token: 0x0400F1E1 RID: 61921
		[Token(Token = "0x400F1E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetNewMatConfig;

		// Token: 0x0400F1E2 RID: 61922
		[Token(Token = "0x400F1E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002298 RID: 8856
		[Token(Token = "0x2002298")]
		[Serializable]
		public class TileStatusSetting
		{
			// Token: 0x0600DED5 RID: 57045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DED5")]
			[Address(RVA = "0x365CBD0", Offset = "0x365B7D0", VA = "0x18365CBD0")]
			public TileStatusSetting()
			{
			}

			// Token: 0x0400F1E3 RID: 61923
			[Token(Token = "0x400F1E3")]
			[FieldOffset(Offset = "0x10")]
			public string statusKey;

			// Token: 0x0400F1E4 RID: 61924
			[Token(Token = "0x400F1E4")]
			[FieldOffset(Offset = "0x18")]
			public string materialShaderKey;

			// Token: 0x0400F1E5 RID: 61925
			[Token(Token = "0x400F1E5")]
			[FieldOffset(Offset = "0x20")]
			public float startValue;

			// Token: 0x0400F1E6 RID: 61926
			[Token(Token = "0x400F1E6")]
			[FieldOffset(Offset = "0x24")]
			public float targetValue;

			// Token: 0x0400F1E7 RID: 61927
			[Token(Token = "0x400F1E7")]
			[FieldOffset(Offset = "0x28")]
			public float targetTime;

			// Token: 0x0400F1E8 RID: 61928
			[Token(Token = "0x400F1E8")]
			[FieldOffset(Offset = "0x2C")]
			public bool simplySetNotActive;
		}

		// Token: 0x02002299 RID: 8857
		[Token(Token = "0x2002299")]
		[Serializable]
		public class MainGraphicStatusSetting
		{
			// Token: 0x0600DED6 RID: 57046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DED6")]
			[Address(RVA = "0x365B080", Offset = "0x3659C80", VA = "0x18365B080")]
			public MainGraphicStatusSetting()
			{
			}

			// Token: 0x0400F1E9 RID: 61929
			[Token(Token = "0x400F1E9")]
			[FieldOffset(Offset = "0x10")]
			public string subGraphicKey;

			// Token: 0x0400F1EA RID: 61930
			[Token(Token = "0x400F1EA")]
			[FieldOffset(Offset = "0x18")]
			public string statusKey;

			// Token: 0x0400F1EB RID: 61931
			[Token(Token = "0x400F1EB")]
			[FieldOffset(Offset = "0x20")]
			public string materialShaderKey;

			// Token: 0x0400F1EC RID: 61932
			[Token(Token = "0x400F1EC")]
			[FieldOffset(Offset = "0x28")]
			public float startValue;

			// Token: 0x0400F1ED RID: 61933
			[Token(Token = "0x400F1ED")]
			[FieldOffset(Offset = "0x2C")]
			public float targetValue;

			// Token: 0x0400F1EE RID: 61934
			[Token(Token = "0x400F1EE")]
			[FieldOffset(Offset = "0x30")]
			public float targetTime;
		}

		// Token: 0x0200229A RID: 8858
		[Token(Token = "0x200229A")]
		private class TileMaterialConfig
		{
			// Token: 0x0600DED7 RID: 57047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DED7")]
			[Address(RVA = "0x365CB40", Offset = "0x365B740", VA = "0x18365CB40")]
			public TileMaterialConfig()
			{
			}

			// Token: 0x0400F1EF RID: 61935
			[Token(Token = "0x400F1EF")]
			[FieldOffset(Offset = "0x10")]
			public string tileMatKey;

			// Token: 0x0400F1F0 RID: 61936
			[Token(Token = "0x400F1F0")]
			[FieldOffset(Offset = "0x18")]
			public List<Material> materials;
		}

		// Token: 0x0200229B RID: 8859
		[Token(Token = "0x200229B")]
		private class GameObjectMaterialConfig
		{
			// Token: 0x0600DED8 RID: 57048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DED8")]
			[Address(RVA = "0x3657330", Offset = "0x3655F30", VA = "0x183657330")]
			public GameObjectMaterialConfig()
			{
			}

			// Token: 0x0400F1F1 RID: 61937
			[Token(Token = "0x400F1F1")]
			[FieldOffset(Offset = "0x10")]
			public string gameObjectName;

			// Token: 0x0400F1F2 RID: 61938
			[Token(Token = "0x400F1F2")]
			[FieldOffset(Offset = "0x18")]
			public List<Material> materials;

			// Token: 0x0400F1F3 RID: 61939
			[Token(Token = "0x400F1F3")]
			[FieldOffset(Offset = "0x20")]
			public List<MeshRenderer> renderList;
		}
	}
}
