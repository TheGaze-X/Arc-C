using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200235F RID: 9055
	[Token(Token = "0x200235F")]
	public class MapGraphic : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x0600E596 RID: 58774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CC7")]
		public MapGraphic.MapSettings mapSettings
		{
			[Token(Token = "0x600E596")]
			[Address(RVA = "0x5C2320", Offset = "0x5C0F20", VA = "0x1805C2320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x0600E597 RID: 58775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CC8")]
		public MapGraphic.LightmapSettings lightmapSettings
		{
			[Token(Token = "0x600E597")]
			[Address(RVA = "0x5C22C0", Offset = "0x5C0EC0", VA = "0x1805C22C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x0600E598 RID: 58776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CC9")]
		public MapGraphic.EffectSettings effectSettings
		{
			[Token(Token = "0x600E598")]
			[Address(RVA = "0x5C2200", Offset = "0x5C0E00", VA = "0x1805C2200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x0600E599 RID: 58777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001CCA")]
		public TileGraphic[] graphics
		{
			[Token(Token = "0x600E599")]
			[Address(RVA = "0x5C2260", Offset = "0x5C0E60", VA = "0x1805C2260")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E59A RID: 58778 RVA: 0x00053220 File Offset: 0x00051420
		[Token(Token = "0x600E59A")]
		[Address(RVA = "0x5C1D00", Offset = "0x5C0900", VA = "0x1805C1D00")]
		public MapGraphic.CameraConfig GetCameraConfig()
		{
			return default(MapGraphic.CameraConfig);
		}

		// Token: 0x0600E59B RID: 58779 RVA: 0x00053238 File Offset: 0x00051438
		[Token(Token = "0x600E59B")]
		[Address(RVA = "0x5C1690", Offset = "0x5C0290", VA = "0x1805C1690")]
		public bool AttachToMap()
		{
			return default(bool);
		}

		// Token: 0x0600E59C RID: 58780 RVA: 0x00053250 File Offset: 0x00051450
		[Token(Token = "0x600E59C")]
		[Address(RVA = "0x5C1F80", Offset = "0x5C0B80", VA = "0x1805C1F80")]
		public float GetTileHeight(TileData.HeightType heightType)
		{
			return 0f;
		}

		// Token: 0x0600E59D RID: 58781 RVA: 0x00053268 File Offset: 0x00051468
		[Token(Token = "0x600E59D")]
		[Address(RVA = "0x5C1EA0", Offset = "0x5C0AA0", VA = "0x1805C1EA0")]
		public Vector3 GetCameraView()
		{
			return default(Vector3);
		}

		// Token: 0x0600E59E RID: 58782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E59E")]
		[Address(RVA = "0x5C2060", Offset = "0x5C0C60", VA = "0x1805C2060")]
		public MapGraphic()
		{
		}

		// Token: 0x0400FD42 RID: 64834
		[Token(Token = "0x400FD42")]
		public const string KEY_CAMERA_FOCUS = "camera_focus";

		// Token: 0x0400FD43 RID: 64835
		[Token(Token = "0x400FD43")]
		public const string KEY_CAMERA_OFFSET = "camera_offset";

		// Token: 0x0400FD44 RID: 64836
		[Token(Token = "0x400FD44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MapGraphic.MapSettings _mapSettings;

		// Token: 0x0400FD45 RID: 64837
		[Token(Token = "0x400FD45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MapGraphic.LightmapSettings _lightmapSettings;

		// Token: 0x0400FD46 RID: 64838
		[Token(Token = "0x400FD46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MapGraphic.EffectSettings _effectSettings;

		// Token: 0x0400FD47 RID: 64839
		[Token(Token = "0x400FD47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ReadOnly]
		private TileGraphic[] _graphics;

		// Token: 0x0400FD48 RID: 64840
		[Token(Token = "0x400FD48")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isCameraConfigInited;

		// Token: 0x0400FD49 RID: 64841
		[Token(Token = "0x400FD49")]
		[FieldOffset(Offset = "0x40")]
		private MapGraphic.CameraConfig m_cameraConfig;

		// Token: 0x0400FD4A RID: 64842
		[Token(Token = "0x400FD4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mapSettings;

		// Token: 0x0400FD4B RID: 64843
		[Token(Token = "0x400FD4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lightmapSettings;

		// Token: 0x0400FD4C RID: 64844
		[Token(Token = "0x400FD4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_effectSettings;

		// Token: 0x0400FD4D RID: 64845
		[Token(Token = "0x400FD4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_graphics;

		// Token: 0x0400FD4E RID: 64846
		[Token(Token = "0x400FD4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCameraConfig;

		// Token: 0x0400FD4F RID: 64847
		[Token(Token = "0x400FD4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AttachToMap;

		// Token: 0x0400FD50 RID: 64848
		[Token(Token = "0x400FD50")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetTileHeight;

		// Token: 0x0400FD51 RID: 64849
		[Token(Token = "0x400FD51")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCameraView;

		// Token: 0x0400FD52 RID: 64850
		[Token(Token = "0x400FD52")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002360 RID: 9056
		[Token(Token = "0x2002360")]
		[Serializable]
		public class MapSettings
		{
			// Token: 0x0600E59F RID: 58783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E59F")]
			[Address(RVA = "0x5C27A0", Offset = "0x5C13A0", VA = "0x1805C27A0")]
			public MapSettings()
			{
			}

			// Token: 0x0400FD53 RID: 64851
			[Token(Token = "0x400FD53")]
			[FieldOffset(Offset = "0x10")]
			[Enum(EnumDisplay.Checkbox)]
			public CameraViewLevel cameraView;

			// Token: 0x0400FD54 RID: 64852
			[Token(Token = "0x400FD54")]
			[FieldOffset(Offset = "0x14")]
			public float highlandHeight;

			// Token: 0x0400FD55 RID: 64853
			[Token(Token = "0x400FD55")]
			[FieldOffset(Offset = "0x18")]
			public float layerHeight;

			// Token: 0x0400FD56 RID: 64854
			[Token(Token = "0x400FD56")]
			[FieldOffset(Offset = "0x20")]
			public string theme;
		}

		// Token: 0x02002361 RID: 9057
		[Token(Token = "0x2002361")]
		[Serializable]
		public class LightmapSettings
		{
			// Token: 0x0600E5A0 RID: 58784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5A0")]
			[Address(RVA = "0x5C15E0", Offset = "0x5C01E0", VA = "0x1805C15E0")]
			public LightmapSettings()
			{
			}

			// Token: 0x0400FD57 RID: 64855
			[Token(Token = "0x400FD57")]
			[FieldOffset(Offset = "0x10")]
			public bool repackLightmap;

			// Token: 0x0400FD58 RID: 64856
			[Token(Token = "0x400FD58")]
			[FieldOffset(Offset = "0x11")]
			public bool bakeLightmapInXYPlane;

			// Token: 0x0400FD59 RID: 64857
			[Token(Token = "0x400FD59")]
			[FieldOffset(Offset = "0x18")]
			public string skyBoxKey;

			// Token: 0x0400FD5A RID: 64858
			[Token(Token = "0x400FD5A")]
			[FieldOffset(Offset = "0x20")]
			public float indirectResolution;

			// Token: 0x0400FD5B RID: 64859
			[Token(Token = "0x400FD5B")]
			[FieldOffset(Offset = "0x24")]
			public float lightmapResolution;

			// Token: 0x0400FD5C RID: 64860
			[Token(Token = "0x400FD5C")]
			[FieldOffset(Offset = "0x28")]
			public float ambientIntensity;

			// Token: 0x0400FD5D RID: 64861
			[Token(Token = "0x400FD5D")]
			[FieldOffset(Offset = "0x2C")]
			public float reflectionIntensity;

			// Token: 0x0400FD5E RID: 64862
			[Token(Token = "0x400FD5E")]
			[FieldOffset(Offset = "0x30")]
			public float indirectIntensity;

			// Token: 0x0400FD5F RID: 64863
			[Token(Token = "0x400FD5F")]
			[FieldOffset(Offset = "0x34")]
			public float albedoBoost;

			// Token: 0x0400FD60 RID: 64864
			[Token(Token = "0x400FD60")]
			[FieldOffset(Offset = "0x38")]
			public bool compressLightmaps;

			// Token: 0x0400FD61 RID: 64865
			[Token(Token = "0x400FD61")]
			[FieldOffset(Offset = "0x39")]
			[Group("Ambient Occlusion", Expandable = false, Priority = 1)]
			public bool ambientOcclusionEnabled;

			// Token: 0x0400FD62 RID: 64866
			[Token(Token = "0x400FD62")]
			[FieldOffset(Offset = "0x3C")]
			[Group("Ambient Occlusion")]
			public float aoMaxDistance;

			// Token: 0x0400FD63 RID: 64867
			[Token(Token = "0x400FD63")]
			[FieldOffset(Offset = "0x40")]
			[Group("Ambient Occlusion")]
			public float aoIndirectContribution;

			// Token: 0x0400FD64 RID: 64868
			[Token(Token = "0x400FD64")]
			[FieldOffset(Offset = "0x44")]
			[Group("Ambient Occlusion")]
			public float aoDirectContribution;

			// Token: 0x0400FD65 RID: 64869
			[Token(Token = "0x400FD65")]
			[FieldOffset(Offset = "0x48")]
			[Group("Final Gather", Expandable = false, Priority = 2)]
			public bool finalGatherEnabled;

			// Token: 0x0400FD66 RID: 64870
			[Token(Token = "0x400FD66")]
			[FieldOffset(Offset = "0x4C")]
			[Group("Final Gather")]
			public int finalGatherRayCount;

			// Token: 0x02002362 RID: 9058
			[Token(Token = "0x2002362")]
			public enum TorappuLightmapsMode
			{
				// Token: 0x0400FD68 RID: 64872
				[Token(Token = "0x400FD68")]
				NonDirectional,
				// Token: 0x0400FD69 RID: 64873
				[Token(Token = "0x400FD69")]
				CombinedDirectional
			}
		}

		// Token: 0x02002363 RID: 9059
		[Token(Token = "0x2002363")]
		[Serializable]
		public class EffectSettings
		{
			// Token: 0x0600E5A1 RID: 58785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E5A1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			public MapEffectData[] GetMapEffects()
			{
				return null;
			}

			// Token: 0x0600E5A2 RID: 58786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E5A2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EffectSettings()
			{
			}

			// Token: 0x0400FD6A RID: 64874
			[Token(Token = "0x400FD6A")]
			[FieldOffset(Offset = "0x10")]
			public string cameraEffect;

			// Token: 0x0400FD6B RID: 64875
			[Token(Token = "0x400FD6B")]
			[FieldOffset(Offset = "0x18")]
			public MapEffectData[] mapEffects;
		}

		// Token: 0x02002364 RID: 9060
		[Token(Token = "0x2002364")]
		public struct CameraConfig
		{
			// Token: 0x0400FD6C RID: 64876
			[Token(Token = "0x400FD6C")]
			[FieldOffset(Offset = "0x0")]
			public Transform focus;

			// Token: 0x0400FD6D RID: 64877
			[Token(Token = "0x400FD6D")]
			[FieldOffset(Offset = "0x8")]
			public Vector3 cameraOffset;
		}
	}
}
