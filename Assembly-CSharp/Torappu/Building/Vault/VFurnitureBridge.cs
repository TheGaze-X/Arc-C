using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A37 RID: 6711
	[Token(Token = "0x2001A37")]
	public class VFurnitureBridge : VRoom.IObject, VRoom.IVCharInteractable, IHotfixable
	{
		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x0600A833 RID: 43059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700137A")]
		public string displayName
		{
			[Token(Token = "0x600A833")]
			[Address(RVA = "0x3242B20", Offset = "0x3241720", VA = "0x183242B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x0600A834 RID: 43060 RVA: 0x00041160 File Offset: 0x0003F360
		[Token(Token = "0x1700137B")]
		public Vector2 gridPos
		{
			[Token(Token = "0x600A834")]
			[Address(RVA = "0x3242CB0", Offset = "0x32418B0", VA = "0x183242CB0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600A835 RID: 43061 RVA: 0x00041178 File Offset: 0x0003F378
		[Token(Token = "0x1700137C")]
		public GridPosition gridPosAsInt
		{
			[Token(Token = "0x600A835")]
			[Address(RVA = "0x3242C50", Offset = "0x3241850", VA = "0x183242C50", Slot = "5")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600A836 RID: 43062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700137D")]
		public GridMap gridMap
		{
			[Token(Token = "0x600A836")]
			[Address(RVA = "0x3242BA0", Offset = "0x32417A0", VA = "0x183242BA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600A837 RID: 43063 RVA: 0x00041190 File Offset: 0x0003F390
		// (set) Token: 0x0600A838 RID: 43064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700137E")]
		public Vector3 worldCenter
		{
			[Token(Token = "0x600A837")]
			[Address(RVA = "0x3242E60", Offset = "0x3241A60", VA = "0x183242E60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600A838")]
			[Address(RVA = "0x3242F60", Offset = "0x3241B60", VA = "0x183242F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600A839 RID: 43065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A83A RID: 43066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700137F")]
		private protected VGridPlane plane
		{
			[Token(Token = "0x600A839")]
			[Address(RVA = "0x3242DA0", Offset = "0x32419A0", VA = "0x183242DA0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600A83A")]
			[Address(RVA = "0x3242EE0", Offset = "0x3241AE0", VA = "0x183242EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x0600A83B RID: 43067 RVA: 0x000411A8 File Offset: 0x0003F3A8
		[Token(Token = "0x17001380")]
		public Bounds bounds
		{
			[Token(Token = "0x600A83B")]
			[Address(RVA = "0x3242AA0", Offset = "0x32416A0", VA = "0x183242AA0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x0600A83C RID: 43068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001381")]
		public VFurnitureBridge.InteractSlot[] slots
		{
			[Token(Token = "0x600A83C")]
			[Address(RVA = "0x3242E00", Offset = "0x3241A00", VA = "0x183242E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x0600A83D RID: 43069 RVA: 0x000411C0 File Offset: 0x0003F3C0
		[Token(Token = "0x17001382")]
		public bool interactable
		{
			[Token(Token = "0x600A83D")]
			[Address(RVA = "0x3242D30", Offset = "0x3241930", VA = "0x183242D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A83E RID: 43070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A83E")]
		[Address(RVA = "0x3242600", Offset = "0x3241200", VA = "0x183242600")]
		public VFurnitureBridge(DIYRoom.IAttachPointExporter controller, VGridPlane plane)
		{
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A83F")]
		[Address(RVA = "0x32416C0", Offset = "0x32402C0", VA = "0x1832416C0", Slot = "8")]
		public void OnEnter()
		{
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A840")]
		[Address(RVA = "0x32417F0", Offset = "0x32403F0", VA = "0x1832417F0", Slot = "9")]
		public void OnExit()
		{
		}

		// Token: 0x0600A841 RID: 43073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A841")]
		[Address(RVA = "0x3241460", Offset = "0x3240060", VA = "0x183241460")]
		public void EnableFurnitureOutline(bool value)
		{
		}

		// Token: 0x0600A842 RID: 43074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A842")]
		[Address(RVA = "0x3241B90", Offset = "0x3240790", VA = "0x183241B90")]
		private VFurnitureBridge.InteractSlot[] _GenerateInteractSlots()
		{
			return null;
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x000411D8 File Offset: 0x0003F3D8
		[Token(Token = "0x600A843")]
		[Address(RVA = "0x3241540", Offset = "0x3240140", VA = "0x183241540", Slot = "10")]
		public bool IsVCharInteractable(VCharacter character)
		{
			return default(bool);
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A844")]
		[Address(RVA = "0x32418D0", Offset = "0x32404D0", VA = "0x1832418D0", Slot = "11")]
		public void OnVCharInteract(VCharacter character)
		{
		}

		// Token: 0x0600A845 RID: 43077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A845")]
		[Address(RVA = "0x3241850", Offset = "0x3240450", VA = "0x183241850", Slot = "12")]
		public void OnInteractableChanged(bool interactable)
		{
		}

		// Token: 0x0400A060 RID: 41056
		[Token(Token = "0x400A060")]
		[FieldOffset(Offset = "0x10")]
		private GridPosition m_gridPos;

		// Token: 0x0400A061 RID: 41057
		[Token(Token = "0x400A061")]
		[FieldOffset(Offset = "0x18")]
		private VFurnitureBridge.InteractSlot[] m_slots;

		// Token: 0x0400A062 RID: 41058
		[Token(Token = "0x400A062")]
		[FieldOffset(Offset = "0x20")]
		private DIYRoom.IAttachPointExporter m_attachPointExporter;

		// Token: 0x0400A063 RID: 41059
		[Token(Token = "0x400A063")]
		[FieldOffset(Offset = "0x28")]
		private Bounds m_bounds;

		// Token: 0x0400A064 RID: 41060
		[Token(Token = "0x400A064")]
		[FieldOffset(Offset = "0x40")]
		private GameObject m_obj;

		// Token: 0x0400A065 RID: 41061
		[Token(Token = "0x400A065")]
		[FieldOffset(Offset = "0x48")]
		private VFurnitureOutline m_vFurnitureOutline;

		// Token: 0x0400A068 RID: 41064
		[Token(Token = "0x400A068")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_displayName;

		// Token: 0x0400A069 RID: 41065
		[Token(Token = "0x400A069")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_gridPos;

		// Token: 0x0400A06A RID: 41066
		[Token(Token = "0x400A06A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gridPosAsInt;

		// Token: 0x0400A06B RID: 41067
		[Token(Token = "0x400A06B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_gridMap;

		// Token: 0x0400A06C RID: 41068
		[Token(Token = "0x400A06C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_worldCenter;

		// Token: 0x0400A06D RID: 41069
		[Token(Token = "0x400A06D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_worldCenter;

		// Token: 0x0400A06E RID: 41070
		[Token(Token = "0x400A06E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_plane;

		// Token: 0x0400A06F RID: 41071
		[Token(Token = "0x400A06F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_plane;

		// Token: 0x0400A070 RID: 41072
		[Token(Token = "0x400A070")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_bounds;

		// Token: 0x0400A071 RID: 41073
		[Token(Token = "0x400A071")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_slots;

		// Token: 0x0400A072 RID: 41074
		[Token(Token = "0x400A072")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0400A073 RID: 41075
		[Token(Token = "0x400A073")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400A074 RID: 41076
		[Token(Token = "0x400A074")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A075 RID: 41077
		[Token(Token = "0x400A075")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400A076 RID: 41078
		[Token(Token = "0x400A076")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EnableFurnitureOutline;

		// Token: 0x0400A077 RID: 41079
		[Token(Token = "0x400A077")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateInteractSlots;

		// Token: 0x0400A078 RID: 41080
		[Token(Token = "0x400A078")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsVCharInteractable;

		// Token: 0x0400A079 RID: 41081
		[Token(Token = "0x400A079")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnVCharInteract;

		// Token: 0x0400A07A RID: 41082
		[Token(Token = "0x400A07A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnInteractableChanged;

		// Token: 0x02001A38 RID: 6712
		[Token(Token = "0x2001A38")]
		public class InteractSlot : IItemWithWeight, VRoom.IVCharInteractable, IHotfixable
		{
			// Token: 0x17001383 RID: 4995
			// (get) Token: 0x0600A846 RID: 43078 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600A847 RID: 43079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001383")]
			public VFurnitureBridge owner
			{
				[Token(Token = "0x600A846")]
				[Address(RVA = "0x3233620", Offset = "0x3232220", VA = "0x183233620")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600A847")]
				[Address(RVA = "0x32337A0", Offset = "0x32323A0", VA = "0x1832337A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001384 RID: 4996
			// (get) Token: 0x0600A848 RID: 43080 RVA: 0x000411F0 File Offset: 0x0003F3F0
			// (set) Token: 0x0600A849 RID: 43081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001384")]
			public VFurnitureBridge.InteractSlot.Options options
			{
				[Token(Token = "0x600A848")]
				[Address(RVA = "0x3233580", Offset = "0x3232180", VA = "0x183233580")]
				[CompilerGenerated]
				get
				{
					return default(VFurnitureBridge.InteractSlot.Options);
				}
				[Token(Token = "0x600A849")]
				[Address(RVA = "0x32336E0", Offset = "0x32322E0", VA = "0x1832336E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001385 RID: 4997
			// (get) Token: 0x0600A84A RID: 43082 RVA: 0x00041208 File Offset: 0x0003F408
			// (set) Token: 0x0600A84B RID: 43083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001385")]
			public float weightValue
			{
				[Token(Token = "0x600A84A")]
				[Address(RVA = "0x3233680", Offset = "0x3232280", VA = "0x183233680", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600A84B")]
				[Address(RVA = "0x3233820", Offset = "0x3232420", VA = "0x183233820")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17001386 RID: 4998
			// (get) Token: 0x0600A84C RID: 43084 RVA: 0x00041220 File Offset: 0x0003F420
			[Token(Token = "0x17001386")]
			public bool isEmpty
			{
				[Token(Token = "0x600A84C")]
				[Address(RVA = "0x32334F0", Offset = "0x32320F0", VA = "0x1832334F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001387 RID: 4999
			// (get) Token: 0x0600A84D RID: 43085 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001387")]
			public VCharacter character
			{
				[Token(Token = "0x600A84D")]
				[Address(RVA = "0x32333C0", Offset = "0x3231FC0", VA = "0x1832333C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001388 RID: 5000
			// (get) Token: 0x0600A84E RID: 43086 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001388")]
			public string displayName
			{
				[Token(Token = "0x600A84E")]
				[Address(RVA = "0x3233420", Offset = "0x3232020", VA = "0x183233420")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600A84F RID: 43087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A84F")]
			[Address(RVA = "0x3233230", Offset = "0x3231E30", VA = "0x183233230")]
			public InteractSlot(VFurnitureBridge owner, VFurnitureBridge.InteractSlot.Options options)
			{
			}

			// Token: 0x0600A850 RID: 43088 RVA: 0x00041238 File Offset: 0x0003F438
			[Token(Token = "0x600A850")]
			[Address(RVA = "0x3233050", Offset = "0x3231C50", VA = "0x183233050")]
			public bool Verify(VCharacter character)
			{
				return default(bool);
			}

			// Token: 0x0600A851 RID: 43089 RVA: 0x00041250 File Offset: 0x0003F450
			[Token(Token = "0x600A851")]
			[Address(RVA = "0x3232E60", Offset = "0x3231A60", VA = "0x183232E60")]
			public bool Register(VCharacter character)
			{
				return default(bool);
			}

			// Token: 0x0600A852 RID: 43090 RVA: 0x00041268 File Offset: 0x0003F468
			[Token(Token = "0x600A852")]
			[Address(RVA = "0x3232F70", Offset = "0x3231B70", VA = "0x183232F70")]
			public bool Unregister(VCharacter character)
			{
				return default(bool);
			}

			// Token: 0x0600A853 RID: 43091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A853")]
			[Address(RVA = "0x3232C60", Offset = "0x3231860", VA = "0x183232C60")]
			public void MakeEmpty()
			{
			}

			// Token: 0x0600A854 RID: 43092 RVA: 0x00041280 File Offset: 0x0003F480
			[Token(Token = "0x600A854")]
			[Address(RVA = "0x32325B0", Offset = "0x32311B0", VA = "0x1832325B0")]
			public bool CheckReached(Vector2 pos, float dist = 0.2f)
			{
				return default(bool);
			}

			// Token: 0x0600A855 RID: 43093 RVA: 0x00041298 File Offset: 0x0003F498
			[Token(Token = "0x600A855")]
			[Address(RVA = "0x32327E0", Offset = "0x32313E0", VA = "0x1832327E0")]
			public float GetNearestDist(Vector2 pos)
			{
				return 0f;
			}

			// Token: 0x0600A856 RID: 43094 RVA: 0x000412B0 File Offset: 0x0003F4B0
			[Token(Token = "0x600A856")]
			[Address(RVA = "0x32324C0", Offset = "0x32310C0", VA = "0x1832324C0")]
			public bool CheckInteractableWith(VCharacter character)
			{
				return default(bool);
			}

			// Token: 0x0600A857 RID: 43095 RVA: 0x000412C8 File Offset: 0x0003F4C8
			[Token(Token = "0x600A857")]
			[Address(RVA = "0x3232AC0", Offset = "0x32316C0", VA = "0x183232AC0", Slot = "5")]
			public bool IsVCharInteractable(VCharacter character)
			{
				return default(bool);
			}

			// Token: 0x0600A858 RID: 43096 RVA: 0x000412E0 File Offset: 0x0003F4E0
			[Token(Token = "0x600A858")]
			[Address(RVA = "0x32330F0", Offset = "0x3231CF0", VA = "0x1832330F0")]
			public bool _CheckSkinValid(VCharacter targetChar)
			{
				return default(bool);
			}

			// Token: 0x0600A859 RID: 43097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A859")]
			[Address(RVA = "0x3232DA0", Offset = "0x32319A0", VA = "0x183232DA0", Slot = "6")]
			public void OnVCharInteract(VCharacter character)
			{
			}

			// Token: 0x0600A85A RID: 43098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A85A")]
			[Address(RVA = "0x3232CD0", Offset = "0x32318D0", VA = "0x183232CD0", Slot = "7")]
			public void OnInteractableChanged(bool interactable)
			{
			}

			// Token: 0x0400A07B RID: 41083
			[Token(Token = "0x400A07B")]
			private const float SLOT_REACH_DISTANCE = 0.2f;

			// Token: 0x0400A07C RID: 41084
			[Token(Token = "0x400A07C")]
			[FieldOffset(Offset = "0x10")]
			private VCharacter m_character;

			// Token: 0x0400A080 RID: 41088
			[Token(Token = "0x400A080")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_owner;

			// Token: 0x0400A081 RID: 41089
			[Token(Token = "0x400A081")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_owner;

			// Token: 0x0400A082 RID: 41090
			[Token(Token = "0x400A082")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_options;

			// Token: 0x0400A083 RID: 41091
			[Token(Token = "0x400A083")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_options;

			// Token: 0x0400A084 RID: 41092
			[Token(Token = "0x400A084")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_weightValue;

			// Token: 0x0400A085 RID: 41093
			[Token(Token = "0x400A085")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_weightValue;

			// Token: 0x0400A086 RID: 41094
			[Token(Token = "0x400A086")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_isEmpty;

			// Token: 0x0400A087 RID: 41095
			[Token(Token = "0x400A087")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_character;

			// Token: 0x0400A088 RID: 41096
			[Token(Token = "0x400A088")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_displayName;

			// Token: 0x0400A089 RID: 41097
			[Token(Token = "0x400A089")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A08A RID: 41098
			[Token(Token = "0x400A08A")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_Verify;

			// Token: 0x0400A08B RID: 41099
			[Token(Token = "0x400A08B")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_Register;

			// Token: 0x0400A08C RID: 41100
			[Token(Token = "0x400A08C")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_Unregister;

			// Token: 0x0400A08D RID: 41101
			[Token(Token = "0x400A08D")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_MakeEmpty;

			// Token: 0x0400A08E RID: 41102
			[Token(Token = "0x400A08E")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_CheckReached;

			// Token: 0x0400A08F RID: 41103
			[Token(Token = "0x400A08F")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_GetNearestDist;

			// Token: 0x0400A090 RID: 41104
			[Token(Token = "0x400A090")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_CheckInteractableWith;

			// Token: 0x0400A091 RID: 41105
			[Token(Token = "0x400A091")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_IsVCharInteractable;

			// Token: 0x0400A092 RID: 41106
			[Token(Token = "0x400A092")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0__CheckSkinValid;

			// Token: 0x0400A093 RID: 41107
			[Token(Token = "0x400A093")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_OnVCharInteract;

			// Token: 0x0400A094 RID: 41108
			[Token(Token = "0x400A094")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_OnInteractableChanged;

			// Token: 0x02001A39 RID: 6713
			[Token(Token = "0x2001A39")]
			public struct Options
			{
				// Token: 0x0400A095 RID: 41109
				[Token(Token = "0x400A095")]
				[FieldOffset(Offset = "0x0")]
				public string animKey;

				// Token: 0x0400A096 RID: 41110
				[Token(Token = "0x400A096")]
				[FieldOffset(Offset = "0x8")]
				public GridPosition[] startPosList;

				// Token: 0x0400A097 RID: 41111
				[Token(Token = "0x400A097")]
				[FieldOffset(Offset = "0x10")]
				public Vector3 interactWorldPos;

				// Token: 0x0400A098 RID: 41112
				[Token(Token = "0x400A098")]
				[FieldOffset(Offset = "0x1C")]
				public Vector2 interactTime;

				// Token: 0x0400A099 RID: 41113
				[Token(Token = "0x400A099")]
				[FieldOffset(Offset = "0x24")]
				public bool specifyDir;

				// Token: 0x0400A09A RID: 41114
				[Token(Token = "0x400A09A")]
				[FieldOffset(Offset = "0x28")]
				public SharedConsts.LeftOrRight lOrR;

				// Token: 0x0400A09B RID: 41115
				[Token(Token = "0x400A09B")]
				[FieldOffset(Offset = "0x30")]
				public string interactId;
			}
		}
	}
}
