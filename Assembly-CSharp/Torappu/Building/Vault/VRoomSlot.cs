using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A56 RID: 6742
	[Token(Token = "0x2001A56")]
	[RequireComponent(typeof(Collider2D), typeof(DragCancellableClickHandler))]
	public class VRoomSlot : AbstractRoomSlot, IDynamicAssetWrapper, ILODHolder, ILODListener
	{
		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x0600A964 RID: 43364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A965 RID: 43365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013C7")]
		public LODState lodState
		{
			[Token(Token = "0x600A964")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A965")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x0600A966 RID: 43366 RVA: 0x00041988 File Offset: 0x0003FB88
		[Token(Token = "0x170013C8")]
		public int assetPriority
		{
			[Token(Token = "0x600A966")]
			[Address(RVA = "0x3248CE0", Offset = "0x32478E0", VA = "0x183248CE0", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600A967 RID: 43367 RVA: 0x000419A0 File Offset: 0x0003FBA0
		// (set) Token: 0x0600A968 RID: 43368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013C9")]
		public override bool isOn
		{
			[Token(Token = "0x600A967")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A968")]
			[Address(RVA = "0x3249510", Offset = "0x3248110", VA = "0x183249510", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600A969 RID: 43369 RVA: 0x000419B8 File Offset: 0x0003FBB8
		// (set) Token: 0x0600A96A RID: 43370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013CA")]
		public bool isVisible
		{
			[Token(Token = "0x600A969")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A96A")]
			[Address(RVA = "0x3249520", Offset = "0x3248120", VA = "0x183249520")]
			set
			{
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600A96B RID: 43371 RVA: 0x000419D0 File Offset: 0x0003FBD0
		// (set) Token: 0x0600A96C RID: 43372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013CB")]
		public bool isHighlight
		{
			[Token(Token = "0x600A96B")]
			[Address(RVA = "0x32490A0", Offset = "0x3247CA0", VA = "0x1832490A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A96C")]
			[Address(RVA = "0x32494D0", Offset = "0x32480D0", VA = "0x1832494D0")]
			set
			{
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x0600A96D RID: 43373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013CC")]
		public VRoom room
		{
			[Token(Token = "0x600A96D")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x0600A96E RID: 43374 RVA: 0x000419E8 File Offset: 0x0003FBE8
		[Token(Token = "0x170013CD")]
		public Vector2 minPos
		{
			[Token(Token = "0x600A96E")]
			[Address(RVA = "0x32491A0", Offset = "0x3247DA0", VA = "0x1832491A0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x0600A96F RID: 43375 RVA: 0x00041A00 File Offset: 0x0003FC00
		[Token(Token = "0x170013CE")]
		public Vector2 center
		{
			[Token(Token = "0x600A96F")]
			[Address(RVA = "0x3248E50", Offset = "0x3247A50", VA = "0x183248E50")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x0600A970 RID: 43376 RVA: 0x00041A18 File Offset: 0x0003FC18
		[Token(Token = "0x170013CF")]
		public Vector3 worldCenter
		{
			[Token(Token = "0x600A970")]
			[Address(RVA = "0x32492D0", Offset = "0x3247ED0", VA = "0x1832492D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x0600A971 RID: 43377 RVA: 0x00041A30 File Offset: 0x0003FC30
		[Token(Token = "0x170013D0")]
		public Vector3 worldStoreyCenter
		{
			[Token(Token = "0x600A971")]
			[Address(RVA = "0x32493D0", Offset = "0x3247FD0", VA = "0x1832493D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600A972 RID: 43378 RVA: 0x00041A48 File Offset: 0x0003FC48
		[Token(Token = "0x170013D1")]
		public Rect boundingBox
		{
			[Token(Token = "0x600A972")]
			[Address(RVA = "0x3248D30", Offset = "0x3247930", VA = "0x183248D30")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600A973 RID: 43379 RVA: 0x00041A60 File Offset: 0x0003FC60
		[Token(Token = "0x170013D2")]
		public bool hasLeftDoor
		{
			[Token(Token = "0x600A973")]
			[Address(RVA = "0x3248F40", Offset = "0x3247B40", VA = "0x183248F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x0600A974 RID: 43380 RVA: 0x00041A78 File Offset: 0x0003FC78
		[Token(Token = "0x170013D3")]
		public bool hasRightDoor
		{
			[Token(Token = "0x600A974")]
			[Address(RVA = "0x3248FF0", Offset = "0x3247BF0", VA = "0x183248FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x0600A975 RID: 43381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013D4")]
		public GameObject leftDoorGameObject
		{
			[Token(Token = "0x600A975")]
			[Address(RVA = "0x32490D0", Offset = "0x3247CD0", VA = "0x1832490D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600A976 RID: 43382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013D5")]
		public GameObject rightDoorGameObject
		{
			[Token(Token = "0x600A976")]
			[Address(RVA = "0x3249200", Offset = "0x3247E00", VA = "0x183249200")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600A977 RID: 43383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A978 RID: 43384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013D6")]
		public VRoomSlot leftSlot
		{
			[Token(Token = "0x600A977")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A978")]
			[Address(RVA = "0x2203A80", Offset = "0x2202680", VA = "0x182203A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x0600A979 RID: 43385 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A97A RID: 43386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013D7")]
		public VRoomSlot rightSlot
		{
			[Token(Token = "0x600A979")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A97A")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600A97B RID: 43387 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A97C RID: 43388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013D8")]
		public VLayoutManager layout
		{
			[Token(Token = "0x600A97B")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A97C")]
			[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600A97D RID: 43389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A97D")]
		[Address(RVA = "0x3246EF0", Offset = "0x3245AF0", VA = "0x183246EF0")]
		public void Init(VRoomSlot leftSlot, VRoomSlot rightSlot, VLayoutManager layout)
		{
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A97E")]
		[Address(RVA = "0x3247240", Offset = "0x3245E40", VA = "0x183247240", Slot = "12")]
		public override void OnContentChange(RoomSlotModel model)
		{
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A97F")]
		[Address(RVA = "0x3247760", Offset = "0x3246360", VA = "0x183247760", Slot = "19")]
		protected virtual void OnSiblingReconstruct(VRoomSlot sibling)
		{
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A980")]
		[Address(RVA = "0x3247560", Offset = "0x3246160", VA = "0x183247560")]
		public void OnEnter()
		{
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A981")]
		[Address(RVA = "0x3247600", Offset = "0x3246200", VA = "0x183247600")]
		public void OnExit()
		{
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A982")]
		[Address(RVA = "0x32476A0", Offset = "0x32462A0", VA = "0x1832476A0")]
		public void OnFixedUpdate(float deltaTime)
		{
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A983")]
		[Address(RVA = "0x3248BE0", Offset = "0x32477E0", VA = "0x183248BE0")]
		private void _UpdateVisible()
		{
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A984")]
		[Address(RVA = "0x3248880", Offset = "0x3247480", VA = "0x183248880")]
		private void _UpdateLOD()
		{
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A985")]
		[Address(RVA = "0x3247740", Offset = "0x3246340", VA = "0x183247740", Slot = "18")]
		public void OnLODStateChanged(LODState state)
		{
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A986")]
		[Address(RVA = "0x3246D70", Offset = "0x3245970", VA = "0x183246D70", Slot = "16")]
		public void AddLODListener(ILODListener listener)
		{
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A987")]
		[Address(RVA = "0x3247920", Offset = "0x3246520", VA = "0x183247920", Slot = "17")]
		public void RemoveLODListener(ILODListener listener)
		{
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A988")]
		[Address(RVA = "0x3247B00", Offset = "0x3246700", VA = "0x183247B00")]
		public void UpdateLOD(int lod)
		{
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A989")]
		[Address(RVA = "0x3247DE0", Offset = "0x32469E0", VA = "0x183247DE0")]
		private void _NotifyLODLevelChanged()
		{
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A98A")]
		[Address(RVA = "0x3247710", Offset = "0x3246310", VA = "0x183247710", Slot = "10")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A98B")]
		[Address(RVA = "0x3248060", Offset = "0x3246C60", VA = "0x183248060")]
		private void _OnDiyPageSavedChanges(object arg)
		{
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A98C")]
		[Address(RVA = "0x32479E0", Offset = "0x32465E0", VA = "0x1832479E0")]
		protected void SetPositionV2(GridPosition gridPosition)
		{
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A98D")]
		[Address(RVA = "0x3247A30", Offset = "0x3246630", VA = "0x183247A30")]
		protected void SetPositionV3(GridPosition gridPosition, float z)
		{
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A98E")]
		[Address(RVA = "0x3247C40", Offset = "0x3246840", VA = "0x183247C40")]
		private string _GenerateRoomPrefabKey()
		{
			return null;
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A98F")]
		[Address(RVA = "0x32480C0", Offset = "0x3246CC0", VA = "0x1832480C0")]
		private void _ReconstructInternalRoom(bool isInit)
		{
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A990")]
		[Address(RVA = "0x3247EC0", Offset = "0x3246AC0", VA = "0x183247EC0")]
		private void _OnClicked(PointerEventData eventData)
		{
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A991")]
		[Address(RVA = "0x3248540", Offset = "0x3247140", VA = "0x183248540")]
		private void _ResizeComponentsToMatchRoomSize()
		{
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A992")]
		[Address(RVA = "0x3248790", Offset = "0x3247390", VA = "0x183248790")]
		private void _SetIsOnInternal(bool value, bool force)
		{
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A993")]
		[Address(RVA = "0x3246DF0", Offset = "0x32459F0", VA = "0x183246DF0")]
		private void Awake()
		{
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A994")]
		[Address(RVA = "0x3247480", Offset = "0x3246080", VA = "0x183247480")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A995")]
		[Address(RVA = "0x3248C50", Offset = "0x3247850", VA = "0x183248C50")]
		public VRoomSlot()
		{
		}

		// Token: 0x0400A18D RID: 41357
		[Token(Token = "0x400A18D")]
		private const float HIGHLIGHT_OFFSET_Z = 0.01f;

		// Token: 0x0400A18E RID: 41358
		[Token(Token = "0x400A18E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteRenderer _highlight;

		// Token: 0x0400A18F RID: 41359
		[Token(Token = "0x400A18F")]
		[FieldOffset(Offset = "0x28")]
		private DragCancellableClickHandler m_clickHandler;

		// Token: 0x0400A190 RID: 41360
		[Token(Token = "0x400A190")]
		[FieldOffset(Offset = "0x30")]
		private BoxCollider2D m_boxCollider;

		// Token: 0x0400A191 RID: 41361
		[Token(Token = "0x400A191")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isOn;

		// Token: 0x0400A192 RID: 41362
		[Token(Token = "0x400A192")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isVisible;

		// Token: 0x0400A193 RID: 41363
		[Token(Token = "0x400A193")]
		[FieldOffset(Offset = "0x3A")]
		private bool m_isEntered;

		// Token: 0x0400A194 RID: 41364
		[Token(Token = "0x400A194")]
		[FieldOffset(Offset = "0x40")]
		private VRoom m_internalRoom;

		// Token: 0x0400A195 RID: 41365
		[Token(Token = "0x400A195")]
		[FieldOffset(Offset = "0x48")]
		private VRoomSlot.SlotCache? m_dataCache;

		// Token: 0x0400A196 RID: 41366
		[Token(Token = "0x400A196")]
		[FieldOffset(Offset = "0x58")]
		private int m_lodValueOffset;

		// Token: 0x0400A197 RID: 41367
		[Token(Token = "0x400A197")]
		[FieldOffset(Offset = "0x5C")]
		private int m_parentLOD;

		// Token: 0x0400A198 RID: 41368
		[Token(Token = "0x400A198")]
		[FieldOffset(Offset = "0x60")]
		private List<ILODListener> m_lodListeners;

		// Token: 0x02001A57 RID: 6743
		[Token(Token = "0x2001A57")]
		private struct SlotCache
		{
			// Token: 0x0600A996 RID: 43414 RVA: 0x00041A90 File Offset: 0x0003FC90
			[Token(Token = "0x600A996")]
			[Address(RVA = "0x32372D0", Offset = "0x3235ED0", VA = "0x1832372D0")]
			public static VRoomSlot.SlotCache Create(RoomSlotModel model)
			{
				return default(VRoomSlot.SlotCache);
			}

			// Token: 0x0400A19D RID: 41373
			[Token(Token = "0x400A19D")]
			[FieldOffset(Offset = "0x0")]
			public string prefabId;
		}
	}
}
