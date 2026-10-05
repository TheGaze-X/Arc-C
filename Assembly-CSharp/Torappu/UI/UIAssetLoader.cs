using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.Resource;
using Torappu.UI.Shop;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037A0 RID: 14240
	[Token(Token = "0x20037A0")]
	public class UIAssetLoader : SingletonMonoBehaviour<UIAssetLoader>, ISingletonNotAutoCreate, ILuaCallCSharp, IHotfixable
	{
		// Token: 0x06016964 RID: 92516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016964")]
		public T LoadAsset<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06016965 RID: 92517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016965")]
		public T LoadAsset<T>(string path, int group) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06016966 RID: 92518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016966")]
		[Address(RVA = "0xEFD6E0", Offset = "0xEFC2E0", VA = "0x180EFD6E0")]
		public void UnloadAsset(UnityEngine.Object asset, int group = 0)
		{
		}

		// Token: 0x06016967 RID: 92519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016967")]
		[Address(RVA = "0xEFDA90", Offset = "0xEFC690", VA = "0x180EFDA90")]
		private void _LegacyDirectLoader_RemoveAsset(string assetPath)
		{
		}

		// Token: 0x06016968 RID: 92520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016968")]
		[Address(RVA = "0xEFD660", Offset = "0xEFC260", VA = "0x180EFD660")]
		public void UnloadAssetGroup(int group)
		{
		}

		// Token: 0x06016969 RID: 92521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016969")]
		[Address(RVA = "0xEFCFC0", Offset = "0xEFBBC0", VA = "0x180EFCFC0")]
		public static ILoadAsset AsILoadAsset()
		{
			return null;
		}

		// Token: 0x0601696A RID: 92522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601696A")]
		[Address(RVA = "0xEFD3C0", Offset = "0xEFBFC0", VA = "0x180EFD3C0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601696B RID: 92523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601696B")]
		[Address(RVA = "0xEFD4E0", Offset = "0xEFC0E0", VA = "0x180EFD4E0")]
		private void Start()
		{
		}

		// Token: 0x0601696C RID: 92524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601696C")]
		[Address(RVA = "0xEFD2B0", Offset = "0xEFBEB0", VA = "0x180EFD2B0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0601696D RID: 92525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700360E")]
		public Sprite missingSprite
		{
			[Token(Token = "0x601696D")]
			[Address(RVA = "0xEFE130", Offset = "0xEFCD30", VA = "0x180EFE130")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0601696E RID: 92526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700360F")]
		public UIItemCard itemCardPrefab
		{
			[Token(Token = "0x601696E")]
			[Address(RVA = "0xEFE0C0", Offset = "0xEFCCC0", VA = "0x180EFE0C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0601696F RID: 92527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003610")]
		public UICharacterCardPanel uiCharacterCard
		{
			[Token(Token = "0x601696F")]
			[Address(RVA = "0xEFE2E0", Offset = "0xEFCEE0", VA = "0x180EFE2E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x06016970 RID: 92528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003611")]
		public CommonTopMenu commonTopMenuPrefab
		{
			[Token(Token = "0x6016970")]
			[Address(RVA = "0xEFDFA0", Offset = "0xEFCBA0", VA = "0x180EFDFA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x06016971 RID: 92529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003612")]
		public UIShopCashIconText cashIconText
		{
			[Token(Token = "0x6016971")]
			[Address(RVA = "0xEFDED0", Offset = "0xEFCAD0", VA = "0x180EFDED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x06016972 RID: 92530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003613")]
		public CommonResourceBar commonResourceBarPrefab
		{
			[Token(Token = "0x6016972")]
			[Address(RVA = "0xEFDF30", Offset = "0xEFCB30", VA = "0x180EFDF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x06016973 RID: 92531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003614")]
		public GameObject trackPointPrefab
		{
			[Token(Token = "0x6016973")]
			[Address(RVA = "0xEFE270", Offset = "0xEFCE70", VA = "0x180EFE270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x06016974 RID: 92532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003615")]
		public Shader blurShader
		{
			[Token(Token = "0x6016974")]
			[Address(RVA = "0xEFDE00", Offset = "0xEFCA00", VA = "0x180EFDE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x06016975 RID: 92533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003616")]
		public StaticOutlinks staticOutlinks
		{
			[Token(Token = "0x6016975")]
			[Address(RVA = "0xEFE210", Offset = "0xEFCE10", VA = "0x180EFE210")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x06016976 RID: 92534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003617")]
		public UICharIllustInfoCache illustInfo
		{
			[Token(Token = "0x6016976")]
			[Address(RVA = "0xEFE010", Offset = "0xEFCC10", VA = "0x180EFE010")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016977 RID: 92535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016977")]
		[Address(RVA = "0xEFD8C0", Offset = "0xEFC4C0", VA = "0x180EFD8C0")]
		private IEnumerator _BindTimeTicker()
		{
			return null;
		}

		// Token: 0x06016978 RID: 92536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016978")]
		[Address(RVA = "0xEFDC30", Offset = "0xEFC830", VA = "0x180EFDC30")]
		private void _OnTickTime()
		{
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x06016979 RID: 92537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003618")]
		public BuildingStaticOutlinks buildingOutlinks
		{
			[Token(Token = "0x6016979")]
			[Address(RVA = "0xEFDE70", Offset = "0xEFCA70", VA = "0x180EFDE70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0601697A RID: 92538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003619")]
		public BuildingGlobalNotificationHolder notifyHolder
		{
			[Token(Token = "0x601697A")]
			[Address(RVA = "0xEFE1A0", Offset = "0xEFCDA0", VA = "0x180EFE1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601697B RID: 92539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601697B")]
		[Address(RVA = "0xEFDB10", Offset = "0xEFC710", VA = "0x180EFDB10")]
		private BuildingStaticOutlinks _LoadBuildingOutlinks()
		{
			return null;
		}

		// Token: 0x0601697C RID: 92540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601697C")]
		[Address(RVA = "0xEFD200", Offset = "0xEFBE00", VA = "0x180EFD200")]
		public static GameObject LoadPrefab(string path, int group = 0)
		{
			return null;
		}

		// Token: 0x0601697D RID: 92541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601697D")]
		[Address(RVA = "0xEFD780", Offset = "0xEFC380", VA = "0x180EFD780")]
		public static void UnloadUnusedAssets()
		{
		}

		// Token: 0x0601697E RID: 92542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601697E")]
		[Address(RVA = "0xEFDBB0", Offset = "0xEFC7B0", VA = "0x180EFDBB0")]
		private void _OnLowMemory()
		{
		}

		// Token: 0x0601697F RID: 92543 RVA: 0x00091EC0 File Offset: 0x000900C0
		[Token(Token = "0x601697F")]
		[Address(RVA = "0xEFDA00", Offset = "0xEFC600", VA = "0x180EFDA00")]
		private static bool _EnableFrequentUIUUA()
		{
			return default(bool);
		}

		// Token: 0x06016980 RID: 92544 RVA: 0x00091ED8 File Offset: 0x000900D8
		[Token(Token = "0x6016980")]
		[Address(RVA = "0xEFD970", Offset = "0xEFC570", VA = "0x180EFD970")]
		private static bool _EnableDelayedUnload()
		{
			return default(bool);
		}

		// Token: 0x06016981 RID: 92545 RVA: 0x00091EF0 File Offset: 0x000900F0
		[Token(Token = "0x6016981")]
		[Address(RVA = "0xEFD180", Offset = "0xEFBD80", VA = "0x180EFD180")]
		public static bool IsLargeMemoryDevice()
		{
			return default(bool);
		}

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x06016982 RID: 92546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700361A")]
		public BaseAssetLoader EditorOnly_BaseAssetLoader
		{
			[Token(Token = "0x6016982")]
			[Address(RVA = "0xEFDDA0", Offset = "0xEFC9A0", VA = "0x180EFDDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016983 RID: 92547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016983")]
		[Address(RVA = "0xEFD480", Offset = "0xEFC080", VA = "0x180EFD480")]
		[Inspect]
		public void OpenInspectWindow()
		{
		}

		// Token: 0x06016984 RID: 92548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016984")]
		[Address(RVA = "0xEFD120", Offset = "0xEFBD20", VA = "0x180EFD120")]
		public UIAssetLoader.EditorInterface CreateEditorInterface()
		{
			return null;
		}

		// Token: 0x06016985 RID: 92549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016985")]
		[Address(RVA = "0xEFDD30", Offset = "0xEFC930", VA = "0x180EFDD30")]
		public UIAssetLoader()
		{
		}

		// Token: 0x0401B39F RID: 111519
		[Token(Token = "0x401B39F")]
		public const int DEFAULT_GROUP = 0;

		// Token: 0x0401B3A0 RID: 111520
		[Token(Token = "0x401B3A0")]
		private const int TIME_TICK_INTERVAL = 2;

		// Token: 0x0401B3A1 RID: 111521
		[Token(Token = "0x401B3A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StaticOutlinks _staticOutlinks;

		// Token: 0x0401B3A2 RID: 111522
		[Token(Token = "0x401B3A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIShopCashIconText _cashIconText;

		// Token: 0x0401B3A3 RID: 111523
		[Token(Token = "0x401B3A3")]
		[FieldOffset(Offset = "0x28")]
		private bool m_shouldUnloadUnusedAssets;

		// Token: 0x0401B3A4 RID: 111524
		[Token(Token = "0x401B3A4")]
		[FieldOffset(Offset = "0x29")]
		private bool m_isInited;

		// Token: 0x0401B3A5 RID: 111525
		[Token(Token = "0x401B3A5")]
		[FieldOffset(Offset = "0x30")]
		private BaseAssetLoader m_baseAssetLoader;

		// Token: 0x0401B3A6 RID: 111526
		[Token(Token = "0x401B3A6")]
		[FieldOffset(Offset = "0x38")]
		private ILoadAsset m_loaderInterface;

		// Token: 0x0401B3A7 RID: 111527
		[Token(Token = "0x401B3A7")]
		[FieldOffset(Offset = "0x40")]
		private UICharIllustInfoCache m_illustInfo;

		// Token: 0x0401B3A8 RID: 111528
		[Token(Token = "0x401B3A8")]
		[FieldOffset(Offset = "0x48")]
		private bool m_startBindTimeTicker;

		// Token: 0x0401B3A9 RID: 111529
		[Token(Token = "0x401B3A9")]
		[FieldOffset(Offset = "0x50")]
		private BuildingStaticOutlinks m_buildingOutlinks;

		// Token: 0x0401B3AA RID: 111530
		[Token(Token = "0x401B3AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadAsset;

		// Token: 0x0401B3AB RID: 111531
		[Token(Token = "0x401B3AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadAsset;

		// Token: 0x0401B3AC RID: 111532
		[Token(Token = "0x401B3AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UnloadAsset;

		// Token: 0x0401B3AD RID: 111533
		[Token(Token = "0x401B3AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LegacyDirectLoader_RemoveAsset;

		// Token: 0x0401B3AE RID: 111534
		[Token(Token = "0x401B3AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnloadAssetGroup;

		// Token: 0x0401B3AF RID: 111535
		[Token(Token = "0x401B3AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AsILoadAsset;

		// Token: 0x0401B3B0 RID: 111536
		[Token(Token = "0x401B3B0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401B3B1 RID: 111537
		[Token(Token = "0x401B3B1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B3B2 RID: 111538
		[Token(Token = "0x401B3B2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B3B3 RID: 111539
		[Token(Token = "0x401B3B3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_missingSprite;

		// Token: 0x0401B3B4 RID: 111540
		[Token(Token = "0x401B3B4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_itemCardPrefab;

		// Token: 0x0401B3B5 RID: 111541
		[Token(Token = "0x401B3B5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_uiCharacterCard;

		// Token: 0x0401B3B6 RID: 111542
		[Token(Token = "0x401B3B6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_commonTopMenuPrefab;

		// Token: 0x0401B3B7 RID: 111543
		[Token(Token = "0x401B3B7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_cashIconText;

		// Token: 0x0401B3B8 RID: 111544
		[Token(Token = "0x401B3B8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_commonResourceBarPrefab;

		// Token: 0x0401B3B9 RID: 111545
		[Token(Token = "0x401B3B9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_trackPointPrefab;

		// Token: 0x0401B3BA RID: 111546
		[Token(Token = "0x401B3BA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_blurShader;

		// Token: 0x0401B3BB RID: 111547
		[Token(Token = "0x401B3BB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_staticOutlinks;

		// Token: 0x0401B3BC RID: 111548
		[Token(Token = "0x401B3BC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_illustInfo;

		// Token: 0x0401B3BD RID: 111549
		[Token(Token = "0x401B3BD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__BindTimeTicker;

		// Token: 0x0401B3BE RID: 111550
		[Token(Token = "0x401B3BE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnTickTime;

		// Token: 0x0401B3BF RID: 111551
		[Token(Token = "0x401B3BF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_buildingOutlinks;

		// Token: 0x0401B3C0 RID: 111552
		[Token(Token = "0x401B3C0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_notifyHolder;

		// Token: 0x0401B3C1 RID: 111553
		[Token(Token = "0x401B3C1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__LoadBuildingOutlinks;

		// Token: 0x0401B3C2 RID: 111554
		[Token(Token = "0x401B3C2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadPrefab;

		// Token: 0x0401B3C3 RID: 111555
		[Token(Token = "0x401B3C3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_UnloadUnusedAssets;

		// Token: 0x0401B3C4 RID: 111556
		[Token(Token = "0x401B3C4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnLowMemory;

		// Token: 0x0401B3C5 RID: 111557
		[Token(Token = "0x401B3C5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__EnableFrequentUIUUA;

		// Token: 0x0401B3C6 RID: 111558
		[Token(Token = "0x401B3C6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__EnableDelayedUnload;

		// Token: 0x0401B3C7 RID: 111559
		[Token(Token = "0x401B3C7")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_IsLargeMemoryDevice;

		// Token: 0x0401B3C8 RID: 111560
		[Token(Token = "0x401B3C8")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_EditorOnly_BaseAssetLoader;

		// Token: 0x0401B3C9 RID: 111561
		[Token(Token = "0x401B3C9")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OpenInspectWindow;

		// Token: 0x0401B3CA RID: 111562
		[Token(Token = "0x401B3CA")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CreateEditorInterface;

		// Token: 0x0401B3CB RID: 111563
		[Token(Token = "0x401B3CB")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020037A1 RID: 14241
		[Token(Token = "0x20037A1")]
		public class Assets : BaseAssetLoader.IAssets, ILoadAsset, IHotfixable
		{
			// Token: 0x06016986 RID: 92550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016986")]
			[Address(RVA = "0xEEF7E0", Offset = "0xEEE3E0", VA = "0x180EEF7E0")]
			private Assets()
			{
			}

			// Token: 0x06016987 RID: 92551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016987")]
			[Address(RVA = "0xEEF390", Offset = "0xEEDF90", VA = "0x180EEF390")]
			public static UIAssetLoader.Assets Create(int groupId)
			{
				return null;
			}

			// Token: 0x06016988 RID: 92552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016988")]
			public T LoadAsset<T>(string path) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x06016989 RID: 92553 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016989")]
			[Address(RVA = "0xEEF4F0", Offset = "0xEEE0F0", VA = "0x180EEF4F0", Slot = "6")]
			public UnityEngine.Object LoadAsset(string path)
			{
				return null;
			}

			// Token: 0x0601698A RID: 92554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601698A")]
			[Address(RVA = "0xEEF580", Offset = "0xEEE180", VA = "0x180EEF580", Slot = "7")]
			public void UnloadAsset(UnityEngine.Object asset)
			{
			}

			// Token: 0x0601698B RID: 92555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601698B")]
			[Address(RVA = "0xEEF690", Offset = "0xEEE290", VA = "0x180EEF690")]
			public void UnloadAssets()
			{
			}

			// Token: 0x0401B3CC RID: 111564
			[Token(Token = "0x401B3CC")]
			[FieldOffset(Offset = "0x10")]
			private int m_groupId;

			// Token: 0x0401B3CD RID: 111565
			[Token(Token = "0x401B3CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401B3CE RID: 111566
			[Token(Token = "0x401B3CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x0401B3CF RID: 111567
			[Token(Token = "0x401B3CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LoadAsset;

			// Token: 0x0401B3D0 RID: 111568
			[Token(Token = "0x401B3D0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix1_LoadAsset;

			// Token: 0x0401B3D1 RID: 111569
			[Token(Token = "0x401B3D1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UnloadAsset;

			// Token: 0x0401B3D2 RID: 111570
			[Token(Token = "0x401B3D2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UnloadAssets;
		}

		// Token: 0x020037A2 RID: 14242
		[Token(Token = "0x20037A2")]
		[Obsolete]
		public class LegacyDirectLoader : AbstractAssetLoader
		{
			// Token: 0x0601698C RID: 92556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601698C")]
			[Address(RVA = "0xEF9820", Offset = "0xEF8420", VA = "0x180EF9820", Slot = "10")]
			public override void ClearAll()
			{
			}

			// Token: 0x0601698D RID: 92557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601698D")]
			[Address(RVA = "0xEF9B40", Offset = "0xEF8740", VA = "0x180EF9B40", Slot = "11")]
			protected override void OnAssetLoaded(string path, UnityEngine.Object asset)
			{
			}

			// Token: 0x0601698E RID: 92558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601698E")]
			[Address(RVA = "0xEF9BF0", Offset = "0xEF87F0", VA = "0x180EF9BF0", Slot = "12")]
			protected override void OnAssetUnloading(UnityEngine.Object asset)
			{
			}

			// Token: 0x0601698F RID: 92559 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601698F")]
			[Address(RVA = "0xEF9D30", Offset = "0xEF8930", VA = "0x180EF9D30")]
			public LegacyDirectLoader()
			{
			}

			// Token: 0x0401B3D3 RID: 111571
			[Token(Token = "0x401B3D3")]
			[FieldOffset(Offset = "0x10")]
			private ListDict<int, string> m_assetPathMap;
		}

		// Token: 0x020037A3 RID: 14243
		[Token(Token = "0x20037A3")]
		private class LoadAssetInterface : ILoadAsset
		{
			// Token: 0x06016990 RID: 92560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016990")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public LoadAssetInterface(UIAssetLoader closure)
			{
			}

			// Token: 0x06016991 RID: 92561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016991")]
			public T LoadAsset<T>(string path) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x06016992 RID: 92562 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016992")]
			[Address(RVA = "0xEF9DC0", Offset = "0xEF89C0", VA = "0x180EF9DC0", Slot = "5")]
			public UnityEngine.Object LoadAsset(string path)
			{
				return null;
			}

			// Token: 0x06016993 RID: 92563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016993")]
			[Address(RVA = "0xEF9E70", Offset = "0xEF8A70", VA = "0x180EF9E70", Slot = "6")]
			public void UnloadAsset(UnityEngine.Object asset)
			{
			}

			// Token: 0x0401B3D4 RID: 111572
			[Token(Token = "0x401B3D4")]
			[FieldOffset(Offset = "0x10")]
			private UIAssetLoader m_closure;
		}

		// Token: 0x020037A4 RID: 14244
		[Token(Token = "0x20037A4")]
		public class EditorInterface
		{
			// Token: 0x06016994 RID: 92564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016994")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EditorInterface()
			{
			}
		}
	}
}
