using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A50 RID: 6736
	[Token(Token = "0x2001A50")]
	[SelectionBase]
	public class VRoom : MonoBehaviour, IHotfixable
	{
		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x0600A90F RID: 43279 RVA: 0x000417F0 File Offset: 0x0003F9F0
		[Token(Token = "0x170013AA")]
		public bool isOn
		{
			[Token(Token = "0x600A90F")]
			[Address(RVA = "0x324D910", Offset = "0x324C510", VA = "0x18324D910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x0600A910 RID: 43280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AB")]
		public List<VRoom.IObject> roomObjects
		{
			[Token(Token = "0x600A910")]
			[Address(RVA = "0x324DBB0", Offset = "0x324C7B0", VA = "0x18324DBB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x0600A911 RID: 43281 RVA: 0x00041808 File Offset: 0x0003FA08
		[Token(Token = "0x170013AC")]
		public GridPosition size
		{
			[Token(Token = "0x600A911")]
			[Address(RVA = "0x324DC20", Offset = "0x324C820", VA = "0x18324DC20")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x0600A912 RID: 43282 RVA: 0x00041820 File Offset: 0x0003FA20
		[Token(Token = "0x170013AD")]
		protected Vector3 gridUnit
		{
			[Token(Token = "0x600A912")]
			[Address(RVA = "0x324D7C0", Offset = "0x324C3C0", VA = "0x18324D7C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x0600A913 RID: 43283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AE")]
		public VGridPlane floorPlane
		{
			[Token(Token = "0x600A913")]
			[Address(RVA = "0x324D5E0", Offset = "0x324C1E0", VA = "0x18324D5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x0600A914 RID: 43284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AF")]
		public VGridPlane backwallPlane
		{
			[Token(Token = "0x600A914")]
			[Address(RVA = "0x324D470", Offset = "0x324C070", VA = "0x18324D470")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600A915 RID: 43285 RVA: 0x00041838 File Offset: 0x0003FA38
		[Token(Token = "0x170013B0")]
		public bool enableBackWall
		{
			[Token(Token = "0x600A915")]
			[Address(RVA = "0x324D570", Offset = "0x324C170", VA = "0x18324D570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x0600A916 RID: 43286 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A917 RID: 43287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013B1")]
		public RoomSlotModel model
		{
			[Token(Token = "0x600A916")]
			[Address(RVA = "0x324DAC0", Offset = "0x324C6C0", VA = "0x18324DAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A917")]
			[Address(RVA = "0x324DD20", Offset = "0x324C920", VA = "0x18324DD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600A918 RID: 43288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B2")]
		public VRoomGraphic graphic
		{
			[Token(Token = "0x600A918")]
			[Address(RVA = "0x324D750", Offset = "0x324C350", VA = "0x18324D750")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x0600A919 RID: 43289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B3")]
		public VFurnitureManager furnitureMgr
		{
			[Token(Token = "0x600A919")]
			[Address(RVA = "0x324D6E0", Offset = "0x324C2E0", VA = "0x18324D6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x0600A91A RID: 43290 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A91B RID: 43291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013B4")]
		public VRoomSlot slot
		{
			[Token(Token = "0x600A91A")]
			[Address(RVA = "0x324DCB0", Offset = "0x324C8B0", VA = "0x18324DCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A91B")]
			[Address(RVA = "0x324DDB0", Offset = "0x324C9B0", VA = "0x18324DDB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x0600A91C RID: 43292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B5")]
		[Inspect]
		[ReadOnly]
		[Group("Door")]
		public VDoor leftDoor
		{
			[Token(Token = "0x600A91C")]
			[Address(RVA = "0x324DA50", Offset = "0x324C650", VA = "0x18324DA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x0600A91D RID: 43293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B6")]
		[Inspect]
		[ReadOnly]
		[Group("Door")]
		public VDoor rightDoor
		{
			[Token(Token = "0x600A91D")]
			[Address(RVA = "0x324DB30", Offset = "0x324C730", VA = "0x18324DB30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x0600A91E RID: 43294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B7")]
		protected VLayoutManager layout
		{
			[Token(Token = "0x600A91E")]
			[Address(RVA = "0x324D9C0", Offset = "0x324C5C0", VA = "0x18324D9C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x0600A91F RID: 43295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B8")]
		protected Animator animator
		{
			[Token(Token = "0x600A91F")]
			[Address(RVA = "0x324D3C0", Offset = "0x324BFC0", VA = "0x18324D3C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x0600A920 RID: 43296 RVA: 0x00041850 File Offset: 0x0003FA50
		[Token(Token = "0x170013B9")]
		protected bool isEntered
		{
			[Token(Token = "0x600A920")]
			[Address(RVA = "0x324D890", Offset = "0x324C490", VA = "0x18324D890")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A921 RID: 43297 RVA: 0x00041868 File Offset: 0x0003FA68
		[Token(Token = "0x600A921")]
		[Address(RVA = "0x324A370", Offset = "0x3248F70", VA = "0x18324A370")]
		public static bool TryGetRoomObject(GameObject go, out VRoom.Object obj)
		{
			return default(bool);
		}

		// Token: 0x0600A922 RID: 43298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A922")]
		[Address(RVA = "0x3249640", Offset = "0x3248240", VA = "0x183249640", Slot = "4")]
		public virtual void Init(VRoomSlot slot, RoomSlotModel model)
		{
		}

		// Token: 0x0600A923 RID: 43299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A923")]
		[Address(RVA = "0x3249530", Offset = "0x3248130", VA = "0x183249530")]
		public void Init_EditorOnly(RoomSlotModel model)
		{
		}

		// Token: 0x0600A924 RID: 43300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A924")]
		[Address(RVA = "0x3249E30", Offset = "0x3248A30", VA = "0x183249E30")]
		public void OnSiblingReconstruct()
		{
		}

		// Token: 0x0600A925 RID: 43301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A925")]
		[Address(RVA = "0x3249930", Offset = "0x3248530", VA = "0x183249930")]
		public void OnContentChanged(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600A926 RID: 43302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A926")]
		[Address(RVA = "0x32499C0", Offset = "0x32485C0", VA = "0x1832499C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A927 RID: 43303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A927")]
		[Address(RVA = "0x323F8D0", Offset = "0x323E4D0", VA = "0x18323F8D0", Slot = "5")]
		public virtual void OnSelectChanged(bool isOn)
		{
		}

		// Token: 0x0600A928 RID: 43304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A928")]
		[Address(RVA = "0x323F860", Offset = "0x323E460", VA = "0x18323F860", Slot = "6")]
		protected virtual void OnPreInit()
		{
		}

		// Token: 0x0600A929 RID: 43305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A929")]
		[Address(RVA = "0x323F7F0", Offset = "0x323E3F0", VA = "0x18323F7F0", Slot = "7")]
		protected virtual void OnPostInit()
		{
		}

		// Token: 0x0600A92A RID: 43306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A92A")]
		[Address(RVA = "0x3249A50", Offset = "0x3248650", VA = "0x183249A50", Slot = "8")]
		public virtual void OnEnter()
		{
		}

		// Token: 0x0600A92B RID: 43307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A92B")]
		[Address(RVA = "0x3249C00", Offset = "0x3248800", VA = "0x183249C00", Slot = "9")]
		public virtual void OnExit()
		{
		}

		// Token: 0x0600A92C RID: 43308 RVA: 0x00041880 File Offset: 0x0003FA80
		[Token(Token = "0x600A92C")]
		[Address(RVA = "0x3249DC0", Offset = "0x32489C0", VA = "0x183249DC0", Slot = "10")]
		public virtual bool OnInteractSelf()
		{
			return default(bool);
		}

		// Token: 0x0600A92D RID: 43309 RVA: 0x00041898 File Offset: 0x0003FA98
		[Token(Token = "0x600A92D")]
		[Address(RVA = "0x3249840", Offset = "0x3248440", VA = "0x183249840")]
		public bool OnClicked(PointerEventData eventData, out bool willFocus)
		{
			return default(bool);
		}

		// Token: 0x0600A92E RID: 43310 RVA: 0x000418B0 File Offset: 0x0003FAB0
		[Token(Token = "0x600A92E")]
		[Address(RVA = "0x324BEC0", Offset = "0x324AAC0", VA = "0x18324BEC0")]
		private bool _TryInteractObjects(PointerEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A92F")]
		[Address(RVA = "0x324C250", Offset = "0x324AE50", VA = "0x18324C250")]
		private void _UpdateCharacters(bool isInit)
		{
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A930")]
		[Address(RVA = "0x324AFE0", Offset = "0x3249BE0", VA = "0x18324AFE0")]
		private void _InitFloorAndBackwall(bool ignoreBuiltInObstacles)
		{
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A931")]
		[Address(RVA = "0x324A4A0", Offset = "0x32490A0", VA = "0x18324A4A0", Slot = "11")]
		protected virtual void UpdateVFurniture(VRoom.Object obj)
		{
		}

		// Token: 0x0600A932 RID: 43314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A932")]
		[Address(RVA = "0x323F770", Offset = "0x323E370", VA = "0x18323F770", Slot = "12")]
		protected virtual void OnDestroyRoom()
		{
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A933")]
		[Address(RVA = "0x323F9D0", Offset = "0x323E5D0", VA = "0x18323F9D0", Slot = "13")]
		protected virtual void OnVCharacterUpdated(VCharacter vc)
		{
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A934")]
		[Address(RVA = "0x323F950", Offset = "0x323E550", VA = "0x18323F950", Slot = "14")]
		protected virtual void OnVCharacterToDestroy(VCharacter vc)
		{
		}

		// Token: 0x0600A935 RID: 43317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A935")]
		[Address(RVA = "0x323F6E0", Offset = "0x323E2E0", VA = "0x18323F6E0", Slot = "15")]
		protected virtual BuildingData.ObstacleRect[] GenerateDynamicObstacles(GridPosition gridSize)
		{
			return null;
		}

		// Token: 0x0600A936 RID: 43318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A936")]
		[Address(RVA = "0x3249FA0", Offset = "0x3248BA0", VA = "0x183249FA0")]
		public void OnStayCharacterChangeRoom(VCharacter vChar, bool isMoveIn)
		{
		}

		// Token: 0x0600A937 RID: 43319 RVA: 0x000418C8 File Offset: 0x0003FAC8
		[Token(Token = "0x600A937")]
		[Address(RVA = "0x324AA40", Offset = "0x3249640", VA = "0x18324AA40")]
		private bool _ContainsStayCharacter(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600A938 RID: 43320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A938")]
		[Address(RVA = "0x324BA30", Offset = "0x324A630", VA = "0x18324BA30")]
		private void _OnVCharAsyncLoadFinished(VCharacter vChar, int instId, EventPool<BuildingEvent> eventPool)
		{
		}

		// Token: 0x0600A939 RID: 43321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A939")]
		[Address(RVA = "0x324A520", Offset = "0x3249120", VA = "0x18324A520")]
		private void _AddVaultCharacter(ref VCharacter vChar, int charInstId, BuildingCharModel charModel, EventPool<BuildingEvent> eventPool)
		{
		}

		// Token: 0x0600A93A RID: 43322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A93A")]
		[Address(RVA = "0x324BD10", Offset = "0x324A910", VA = "0x18324BD10")]
		private void _RemoveVaultCharacter(VCharacter vChar, EventPool<BuildingEvent> eventPool)
		{
		}

		// Token: 0x0600A93B RID: 43323 RVA: 0x000418E0 File Offset: 0x0003FAE0
		[Token(Token = "0x600A93B")]
		[Address(RVA = "0x324ADB0", Offset = "0x32499B0", VA = "0x18324ADB0")]
		private BuildingCharModel _FindStayCharByInstId(int instId)
		{
			return default(BuildingCharModel);
		}

		// Token: 0x0600A93C RID: 43324 RVA: 0x000418F8 File Offset: 0x0003FAF8
		[Token(Token = "0x600A93C")]
		[Address(RVA = "0x324AB70", Offset = "0x3249770", VA = "0x18324AB70")]
		private BuildingCharModel _FindStayCharByCharId(string charId)
		{
			return default(BuildingCharModel);
		}

		// Token: 0x0600A93D RID: 43325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A93D")]
		[Address(RVA = "0x324D0F0", Offset = "0x324BCF0", VA = "0x18324D0F0")]
		public VRoom()
		{
		}

		// Token: 0x0400A12F RID: 41263
		[Token(Token = "0x400A12F")]
		[NonSerialized]
		public const string FLOOR_CONTAINER_NAME = "_Floor";

		// Token: 0x0400A130 RID: 41264
		[Token(Token = "0x400A130")]
		[NonSerialized]
		public const string BACKWALL_CONTAINER_NAME = "_Wall";

		// Token: 0x0400A131 RID: 41265
		[Token(Token = "0x400A131")]
		[FieldOffset(Offset = "0x0")]
		private static List<RaycastResult> s_sharedRaycastResults;

		// Token: 0x0400A132 RID: 41266
		[Token(Token = "0x400A132")]
		[FieldOffset(Offset = "0x8")]
		private static List<string> s_sharedCharIdList;

		// Token: 0x0400A133 RID: 41267
		[Token(Token = "0x400A133")]
		[FieldOffset(Offset = "0x18")]
		private List<BuildingCharModel> m_stayChars;

		// Token: 0x0400A134 RID: 41268
		[Token(Token = "0x400A134")]
		[FieldOffset(Offset = "0x20")]
		private string m_stayCharSignature;

		// Token: 0x0400A135 RID: 41269
		[Token(Token = "0x400A135")]
		[FieldOffset(Offset = "0x28")]
		private ListSet<int> m_loadedOrLoadingChars;

		// Token: 0x0400A136 RID: 41270
		[Token(Token = "0x400A136")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VRoomGraphic _graphic;

		// Token: 0x0400A137 RID: 41271
		[Token(Token = "0x400A137")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VFloorPlane _floorPlane;

		// Token: 0x0400A138 RID: 41272
		[Token(Token = "0x400A138")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VBackwallPlane _backwallPlane;

		// Token: 0x0400A139 RID: 41273
		[Token(Token = "0x400A139")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _enableBackWall;

		// Token: 0x0400A13A RID: 41274
		[Token(Token = "0x400A13A")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isEntered;

		// Token: 0x0400A13B RID: 41275
		[Token(Token = "0x400A13B")]
		[FieldOffset(Offset = "0x50")]
		private VDoor m_leftDoor;

		// Token: 0x0400A13C RID: 41276
		[Token(Token = "0x400A13C")]
		[FieldOffset(Offset = "0x58")]
		private VDoor m_rightDoor;

		// Token: 0x0400A13D RID: 41277
		[Token(Token = "0x400A13D")]
		[FieldOffset(Offset = "0x60")]
		protected List<VRoom.IObject> m_objects;

		// Token: 0x0400A13E RID: 41278
		[Token(Token = "0x400A13E")]
		[FieldOffset(Offset = "0x68")]
		protected VFurnitureManager m_furnitureMgr;

		// Token: 0x0400A141 RID: 41281
		[Token(Token = "0x400A141")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isOn;

		// Token: 0x0400A142 RID: 41282
		[Token(Token = "0x400A142")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_roomObjects;

		// Token: 0x0400A143 RID: 41283
		[Token(Token = "0x400A143")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_size;

		// Token: 0x0400A144 RID: 41284
		[Token(Token = "0x400A144")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_gridUnit;

		// Token: 0x0400A145 RID: 41285
		[Token(Token = "0x400A145")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_floorPlane;

		// Token: 0x0400A146 RID: 41286
		[Token(Token = "0x400A146")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_backwallPlane;

		// Token: 0x0400A147 RID: 41287
		[Token(Token = "0x400A147")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_enableBackWall;

		// Token: 0x0400A148 RID: 41288
		[Token(Token = "0x400A148")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x0400A149 RID: 41289
		[Token(Token = "0x400A149")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_model;

		// Token: 0x0400A14A RID: 41290
		[Token(Token = "0x400A14A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_graphic;

		// Token: 0x0400A14B RID: 41291
		[Token(Token = "0x400A14B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_furnitureMgr;

		// Token: 0x0400A14C RID: 41292
		[Token(Token = "0x400A14C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_slot;

		// Token: 0x0400A14D RID: 41293
		[Token(Token = "0x400A14D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_slot;

		// Token: 0x0400A14E RID: 41294
		[Token(Token = "0x400A14E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_leftDoor;

		// Token: 0x0400A14F RID: 41295
		[Token(Token = "0x400A14F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_rightDoor;

		// Token: 0x0400A150 RID: 41296
		[Token(Token = "0x400A150")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_layout;

		// Token: 0x0400A151 RID: 41297
		[Token(Token = "0x400A151")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_animator;

		// Token: 0x0400A152 RID: 41298
		[Token(Token = "0x400A152")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_isEntered;

		// Token: 0x0400A153 RID: 41299
		[Token(Token = "0x400A153")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TryGetRoomObject;

		// Token: 0x0400A154 RID: 41300
		[Token(Token = "0x400A154")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400A155 RID: 41301
		[Token(Token = "0x400A155")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Init_EditorOnly;

		// Token: 0x0400A156 RID: 41302
		[Token(Token = "0x400A156")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnSiblingReconstruct;

		// Token: 0x0400A157 RID: 41303
		[Token(Token = "0x400A157")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnContentChanged;

		// Token: 0x0400A158 RID: 41304
		[Token(Token = "0x400A158")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A159 RID: 41305
		[Token(Token = "0x400A159")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnSelectChanged;

		// Token: 0x0400A15A RID: 41306
		[Token(Token = "0x400A15A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnPreInit;

		// Token: 0x0400A15B RID: 41307
		[Token(Token = "0x400A15B")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400A15C RID: 41308
		[Token(Token = "0x400A15C")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A15D RID: 41309
		[Token(Token = "0x400A15D")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400A15E RID: 41310
		[Token(Token = "0x400A15E")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnInteractSelf;

		// Token: 0x0400A15F RID: 41311
		[Token(Token = "0x400A15F")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x0400A160 RID: 41312
		[Token(Token = "0x400A160")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__TryInteractObjects;

		// Token: 0x0400A161 RID: 41313
		[Token(Token = "0x400A161")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__UpdateCharacters;

		// Token: 0x0400A162 RID: 41314
		[Token(Token = "0x400A162")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__InitFloorAndBackwall;

		// Token: 0x0400A163 RID: 41315
		[Token(Token = "0x400A163")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_UpdateVFurniture;

		// Token: 0x0400A164 RID: 41316
		[Token(Token = "0x400A164")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnDestroyRoom;

		// Token: 0x0400A165 RID: 41317
		[Token(Token = "0x400A165")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnVCharacterUpdated;

		// Token: 0x0400A166 RID: 41318
		[Token(Token = "0x400A166")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnVCharacterToDestroy;

		// Token: 0x0400A167 RID: 41319
		[Token(Token = "0x400A167")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GenerateDynamicObstacles;

		// Token: 0x0400A168 RID: 41320
		[Token(Token = "0x400A168")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OnStayCharacterChangeRoom;

		// Token: 0x0400A169 RID: 41321
		[Token(Token = "0x400A169")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__ContainsStayCharacter;

		// Token: 0x0400A16A RID: 41322
		[Token(Token = "0x400A16A")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__OnVCharAsyncLoadFinished;

		// Token: 0x0400A16B RID: 41323
		[Token(Token = "0x400A16B")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__AddVaultCharacter;

		// Token: 0x0400A16C RID: 41324
		[Token(Token = "0x400A16C")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__RemoveVaultCharacter;

		// Token: 0x0400A16D RID: 41325
		[Token(Token = "0x400A16D")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__FindStayCharByInstId;

		// Token: 0x0400A16E RID: 41326
		[Token(Token = "0x400A16E")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__FindStayCharByCharId;

		// Token: 0x0400A16F RID: 41327
		[Token(Token = "0x400A16F")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A51 RID: 6737
		[Token(Token = "0x2001A51")]
		public interface IObject
		{
			// Token: 0x170013BA RID: 5050
			// (get) Token: 0x0600A93F RID: 43327
			[Token(Token = "0x170013BA")]
			Vector2 gridPos { [Token(Token = "0x600A93F")] get; }

			// Token: 0x170013BB RID: 5051
			// (get) Token: 0x0600A940 RID: 43328
			[Token(Token = "0x170013BB")]
			GridPosition gridPosAsInt { [Token(Token = "0x600A940")] get; }

			// Token: 0x170013BC RID: 5052
			// (get) Token: 0x0600A941 RID: 43329
			[Token(Token = "0x170013BC")]
			GridMap gridMap { [Token(Token = "0x600A941")] get; }

			// Token: 0x170013BD RID: 5053
			// (get) Token: 0x0600A942 RID: 43330
			[Token(Token = "0x170013BD")]
			Vector3 worldCenter { [Token(Token = "0x600A942")] get; }

			// Token: 0x0600A943 RID: 43331
			[Token(Token = "0x600A943")]
			void OnEnter();

			// Token: 0x0600A944 RID: 43332
			[Token(Token = "0x600A944")]
			void OnExit();
		}

		// Token: 0x02001A52 RID: 6738
		[Token(Token = "0x2001A52")]
		public interface IVCharInteractable
		{
			// Token: 0x0600A945 RID: 43333
			[Token(Token = "0x600A945")]
			bool IsVCharInteractable(VCharacter character);

			// Token: 0x0600A946 RID: 43334
			[Token(Token = "0x600A946")]
			void OnVCharInteract(VCharacter character);

			// Token: 0x0600A947 RID: 43335
			[Token(Token = "0x600A947")]
			void OnInteractableChanged(bool interactable);
		}

		// Token: 0x02001A53 RID: 6739
		[Token(Token = "0x2001A53")]
		public abstract class Object : MonoBehaviour, VRoom.IObject, IHotfixable
		{
			// Token: 0x170013BE RID: 5054
			// (get) Token: 0x0600A948 RID: 43336 RVA: 0x00041910 File Offset: 0x0003FB10
			// (set) Token: 0x0600A949 RID: 43337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170013BE")]
			[Inspect(InspectorLevel.Debug)]
			[ReadOnly]
			public Vector2 gridPos
			{
				[Token(Token = "0x600A948")]
				[Address(RVA = "0x3236380", Offset = "0x3234F80", VA = "0x183236380", Slot = "4")]
				get
				{
					return default(Vector2);
				}
				[Token(Token = "0x600A949")]
				[Address(RVA = "0x32367E0", Offset = "0x32353E0", VA = "0x1832367E0", Slot = "10")]
				set
				{
				}
			}

			// Token: 0x170013BF RID: 5055
			// (get) Token: 0x0600A94A RID: 43338 RVA: 0x00041928 File Offset: 0x0003FB28
			// (set) Token: 0x0600A94B RID: 43339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170013BF")]
			public GridPosition gridPosAsInt
			{
				[Token(Token = "0x600A94A")]
				[Address(RVA = "0x32362E0", Offset = "0x3234EE0", VA = "0x1832362E0", Slot = "5")]
				get
				{
					return default(GridPosition);
				}
				[Token(Token = "0x600A94B")]
				[Address(RVA = "0x3236740", Offset = "0x3235340", VA = "0x183236740")]
				set
				{
				}
			}

			// Token: 0x170013C0 RID: 5056
			// (get) Token: 0x0600A94C RID: 43340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013C0")]
			public GridMap gridMap
			{
				[Token(Token = "0x600A94C")]
				[Address(RVA = "0x3236230", Offset = "0x3234E30", VA = "0x183236230", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x170013C1 RID: 5057
			// (get) Token: 0x0600A94D RID: 43341 RVA: 0x00041940 File Offset: 0x0003FB40
			// (set) Token: 0x0600A94E RID: 43342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170013C1")]
			public bool positionFree
			{
				[Token(Token = "0x600A94D")]
				[Address(RVA = "0x3236680", Offset = "0x3235280", VA = "0x183236680")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600A94E")]
				[Address(RVA = "0x3236C10", Offset = "0x3235810", VA = "0x183236C10")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			// Token: 0x170013C2 RID: 5058
			// (get) Token: 0x0600A94F RID: 43343
			[Token(Token = "0x170013C2")]
			public abstract Vector3 worldCenter { [Token(Token = "0x600A94F")] get; }

			// Token: 0x170013C3 RID: 5059
			// (get) Token: 0x0600A950 RID: 43344 RVA: 0x00041958 File Offset: 0x0003FB58
			// (set) Token: 0x0600A951 RID: 43345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170013C3")]
			public bool isOn
			{
				[Token(Token = "0x600A950")]
				[Address(RVA = "0x3236510", Offset = "0x3235110", VA = "0x183236510")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600A951")]
				[Address(RVA = "0x3236A60", Offset = "0x3235660", VA = "0x183236A60")]
				set
				{
				}
			}

			// Token: 0x170013C4 RID: 5060
			// (get) Token: 0x0600A952 RID: 43346 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600A953 RID: 43347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170013C4")]
			public VRoom room
			{
				[Token(Token = "0x600A952")]
				[Address(RVA = "0x32366E0", Offset = "0x32352E0", VA = "0x1832366E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600A953")]
				[Address(RVA = "0x3236C80", Offset = "0x3235880", VA = "0x183236C80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170013C5 RID: 5061
			// (get) Token: 0x0600A954 RID: 43348 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600A955 RID: 43349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170013C5")]
			private protected VGridPlane plane
			{
				[Token(Token = "0x600A954")]
				[Address(RVA = "0x3236620", Offset = "0x3235220", VA = "0x183236620")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600A955")]
				[Address(RVA = "0x3236B90", Offset = "0x3235790", VA = "0x183236B90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170013C6 RID: 5062
			// (get) Token: 0x0600A956 RID: 43350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013C6")]
			protected VLayoutManager layout
			{
				[Token(Token = "0x600A956")]
				[Address(RVA = "0x3236570", Offset = "0x3235170", VA = "0x183236570")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600A957 RID: 43351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A957")]
			[Address(RVA = "0x3235CC0", Offset = "0x32348C0", VA = "0x183235CC0", Slot = "12")]
			public virtual void Init(VRoom room, VGridPlane plane)
			{
			}

			// Token: 0x0600A958 RID: 43352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A958")]
			[Address(RVA = "0x3236030", Offset = "0x3234C30", VA = "0x183236030")]
			public void Refresh(VRoom room, VGridPlane plane)
			{
			}

			// Token: 0x0600A959 RID: 43353
			[Token(Token = "0x600A959")]
			public abstract void OnInit();

			// Token: 0x0600A95A RID: 43354
			[Token(Token = "0x600A95A")]
			public abstract void OnEnter();

			// Token: 0x0600A95B RID: 43355
			[Token(Token = "0x600A95B")]
			public abstract void OnExit();

			// Token: 0x0600A95C RID: 43356 RVA: 0x00041970 File Offset: 0x0003FB70
			[Token(Token = "0x600A95C")]
			[Address(RVA = "0x3235EC0", Offset = "0x3234AC0", VA = "0x183235EC0", Slot = "16")]
			public virtual bool OnInteract()
			{
				return default(bool);
			}

			// Token: 0x0600A95D RID: 43357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A95D")]
			[Address(RVA = "0x3235FD0", Offset = "0x3234BD0", VA = "0x183235FD0", Slot = "17")]
			protected virtual void OnSelect()
			{
			}

			// Token: 0x0600A95E RID: 43358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A95E")]
			[Address(RVA = "0x3235E60", Offset = "0x3234A60", VA = "0x183235E60", Slot = "18")]
			protected virtual void OnDeselect()
			{
			}

			// Token: 0x0600A95F RID: 43359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A95F")]
			[Address(RVA = "0x32360D0", Offset = "0x3234CD0", VA = "0x1832360D0")]
			protected void _SetIsOnInternal(bool value, bool force)
			{
			}

			// Token: 0x0600A960 RID: 43360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A960")]
			[Address(RVA = "0x32361D0", Offset = "0x3234DD0", VA = "0x1832361D0")]
			protected Object()
			{
			}

			// Token: 0x0400A170 RID: 41328
			[Token(Token = "0x400A170")]
			[FieldOffset(Offset = "0x18")]
			private bool m_isOn;

			// Token: 0x0400A174 RID: 41332
			[Token(Token = "0x400A174")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_gridPos;

			// Token: 0x0400A175 RID: 41333
			[Token(Token = "0x400A175")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_gridPos;

			// Token: 0x0400A176 RID: 41334
			[Token(Token = "0x400A176")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_gridPosAsInt;

			// Token: 0x0400A177 RID: 41335
			[Token(Token = "0x400A177")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_gridPosAsInt;

			// Token: 0x0400A178 RID: 41336
			[Token(Token = "0x400A178")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_gridMap;

			// Token: 0x0400A179 RID: 41337
			[Token(Token = "0x400A179")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_positionFree;

			// Token: 0x0400A17A RID: 41338
			[Token(Token = "0x400A17A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_positionFree;

			// Token: 0x0400A17B RID: 41339
			[Token(Token = "0x400A17B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_get_isOn;

			// Token: 0x0400A17C RID: 41340
			[Token(Token = "0x400A17C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_set_isOn;

			// Token: 0x0400A17D RID: 41341
			[Token(Token = "0x400A17D")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_room;

			// Token: 0x0400A17E RID: 41342
			[Token(Token = "0x400A17E")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_set_room;

			// Token: 0x0400A17F RID: 41343
			[Token(Token = "0x400A17F")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_get_plane;

			// Token: 0x0400A180 RID: 41344
			[Token(Token = "0x400A180")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_set_plane;

			// Token: 0x0400A181 RID: 41345
			[Token(Token = "0x400A181")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_get_layout;

			// Token: 0x0400A182 RID: 41346
			[Token(Token = "0x400A182")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400A183 RID: 41347
			[Token(Token = "0x400A183")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_Refresh;

			// Token: 0x0400A184 RID: 41348
			[Token(Token = "0x400A184")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_OnInteract;

			// Token: 0x0400A185 RID: 41349
			[Token(Token = "0x400A185")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_OnSelect;

			// Token: 0x0400A186 RID: 41350
			[Token(Token = "0x400A186")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_OnDeselect;

			// Token: 0x0400A187 RID: 41351
			[Token(Token = "0x400A187")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0__SetIsOnInternal;

			// Token: 0x0400A188 RID: 41352
			[Token(Token = "0x400A188")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
