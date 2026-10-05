using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.BP
{
	// Token: 0x02001A9C RID: 6812
	[Token(Token = "0x2001A9C")]
	public class BLayoutManager : MonoBehaviour
	{
		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x0600ABB9 RID: 43961 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABBA RID: 43962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700144E")]
		public BLayoutManager.IListener listener
		{
			[Token(Token = "0x600ABB9")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600ABBA")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x0600ABBB RID: 43963 RVA: 0x000426F0 File Offset: 0x000408F0
		[Token(Token = "0x1700144F")]
		public float initZoom
		{
			[Token(Token = "0x600ABBB")]
			[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001450 RID: 5200
		// (get) Token: 0x0600ABBC RID: 43964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001450")]
		public ToggleGroup toggleGroup
		{
			[Token(Token = "0x600ABBC")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600ABBD RID: 43965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001451")]
		public Camera camera
		{
			[Token(Token = "0x600ABBD")]
			[Address(RVA = "0x3270AF0", Offset = "0x326F6F0", VA = "0x183270AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x0600ABBE RID: 43966 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABBF RID: 43967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001452")]
		public BRoomSlot selectedRoom
		{
			[Token(Token = "0x600ABBE")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600ABBF")]
			[Address(RVA = "0x3270BD0", Offset = "0x326F7D0", VA = "0x183270BD0")]
			set
			{
			}
		}

		// Token: 0x0600ABC0 RID: 43968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC0")]
		[Address(RVA = "0x326E860", Offset = "0x326D460", VA = "0x18326E860")]
		private void OnEnable()
		{
		}

		// Token: 0x0600ABC1 RID: 43969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC1")]
		[Address(RVA = "0x326E380", Offset = "0x326CF80", VA = "0x18326E380")]
		public void Init(List<RoomSlotModel> layout, BlueprintMode state)
		{
		}

		// Token: 0x0600ABC2 RID: 43970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC2")]
		[Address(RVA = "0x326E8A0", Offset = "0x326D4A0", VA = "0x18326E8A0")]
		public void OnEnter()
		{
		}

		// Token: 0x0600ABC3 RID: 43971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void OnExit()
		{
		}

		// Token: 0x0600ABC4 RID: 43972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC4")]
		[Address(RVA = "0x326EA20", Offset = "0x326D620", VA = "0x18326EA20")]
		public void OnRoomClicked(BRoomSlot room)
		{
		}

		// Token: 0x0600ABC5 RID: 43973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC5")]
		[Address(RVA = "0x326EB20", Offset = "0x326D720", VA = "0x18326EB20", Slot = "4")]
		public virtual void SetArchitectureActive(bool active)
		{
		}

		// Token: 0x0600ABC6 RID: 43974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC6")]
		[Address(RVA = "0x326E0E0", Offset = "0x326CCE0", VA = "0x18326E0E0")]
		public void FocusSelectedRoomForUI(Action<bool> finishCb)
		{
		}

		// Token: 0x0600ABC7 RID: 43975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC7")]
		[Address(RVA = "0x326DFF0", Offset = "0x326CBF0", VA = "0x18326DFF0")]
		public void FocusRoomForUI(BRoomSlot roomSlot, Action<bool> finishCb)
		{
		}

		// Token: 0x0600ABC8 RID: 43976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC8")]
		[Address(RVA = "0x326ECC0", Offset = "0x326D8C0", VA = "0x18326ECC0")]
		public void UpdateRoomHilightStatus(BRoomHilightViewModel viewModel)
		{
		}

		// Token: 0x0600ABC9 RID: 43977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABC9")]
		[Address(RVA = "0x3270660", Offset = "0x326F260", VA = "0x183270660")]
		private void _UpdateHilightStatus(BRoomHilightViewModel viewModel)
		{
		}

		// Token: 0x0600ABCA RID: 43978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCA")]
		[Address(RVA = "0x326E860", Offset = "0x326D460", VA = "0x18326E860")]
		private void _DealWithPendingHilight()
		{
		}

		// Token: 0x0600ABCB RID: 43979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCB")]
		[Address(RVA = "0x326F790", Offset = "0x326E390", VA = "0x18326F790")]
		private void _OnRoomClickNormal(BRoomSlot slot)
		{
		}

		// Token: 0x0600ABCC RID: 43980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCC")]
		[Address(RVA = "0x326F720", Offset = "0x326E320", VA = "0x18326F720")]
		private void _OnRoomClickArchitecture(BRoomSlot room)
		{
		}

		// Token: 0x0600ABCD RID: 43981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABCD")]
		[Address(RVA = "0x326F200", Offset = "0x326DE00", VA = "0x18326F200")]
		private void _FocusToRoomBySide(BRoomSlot slot, SharedConsts.LeftOrRight side, Action<bool> finishCb)
		{
		}

		// Token: 0x0600ABCE RID: 43982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABCE")]
		[Address(RVA = "0x326ED50", Offset = "0x326D950", VA = "0x18326ED50")]
		public Tween ZoomTo(float toZoom, BRoomSlot roomSlot)
		{
			return null;
		}

		// Token: 0x0600ABCF RID: 43983 RVA: 0x00042708 File Offset: 0x00040908
		[Token(Token = "0x600ABCF")]
		[Address(RVA = "0x326EC50", Offset = "0x326D850", VA = "0x18326EC50")]
		public bool TryGetRoomBySlotId(string slotId, out BRoomSlot value)
		{
			return default(bool);
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x0600ABD0 RID: 43984 RVA: 0x00042720 File Offset: 0x00040920
		[Token(Token = "0x17001453")]
		public Vector2 originPoint
		{
			[Token(Token = "0x600ABD0")]
			[Address(RVA = "0x3270B60", Offset = "0x326F760", VA = "0x183270B60")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600ABD1 RID: 43985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD1")]
		[Address(RVA = "0x326FD40", Offset = "0x326E940", VA = "0x18326FD40")]
		private void _ResetLayout()
		{
		}

		// Token: 0x0600ABD2 RID: 43986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABD2")]
		[Address(RVA = "0x326F140", Offset = "0x326DD40", VA = "0x18326F140")]
		private BRoomSlot _CreateRoom(RoomSlotModel model)
		{
			return null;
		}

		// Token: 0x0600ABD3 RID: 43987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD3")]
		[Address(RVA = "0x326F000", Offset = "0x326DC00", VA = "0x18326F000")]
		private void _ClearAll()
		{
		}

		// Token: 0x0600ABD4 RID: 43988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD4")]
		[Address(RVA = "0x3270440", Offset = "0x326F040", VA = "0x183270440")]
		private void _ResetToDefault()
		{
		}

		// Token: 0x0600ABD5 RID: 43989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD5")]
		[Address(RVA = "0x32705B0", Offset = "0x326F1B0", VA = "0x1832705B0")]
		private void _SwitchToVault(BRoomSlot room)
		{
		}

		// Token: 0x0600ABD6 RID: 43990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD6")]
		[Address(RVA = "0x326F990", Offset = "0x326E590", VA = "0x18326F990")]
		private void _ResetFullBoundGround(RectTransform rectground, Bounds worldBound, Vector2 padding, float maxZoom)
		{
		}

		// Token: 0x0600ABD7 RID: 43991 RVA: 0x00042738 File Offset: 0x00040938
		[Token(Token = "0x600ABD7")]
		[Address(RVA = "0x326EDE0", Offset = "0x326D9E0", VA = "0x18326EDE0")]
		private Rect _CalcLocalRectForBound(Bounds bound, RectTransform rect)
		{
			return default(Rect);
		}

		// Token: 0x0600ABD8 RID: 43992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABD8")]
		[Address(RVA = "0x326E6E0", Offset = "0x326D2E0", VA = "0x18326E6E0")]
		public void NotifySettleEffect(BuildingData.RoomType roomType)
		{
		}

		// Token: 0x0600ABD9 RID: 43993 RVA: 0x00042750 File Offset: 0x00040950
		[Token(Token = "0x600ABD9")]
		[Address(RVA = "0x326E1D0", Offset = "0x326CDD0", VA = "0x18326E1D0")]
		public Vector2 GetRoomAnchorBySlotId(string slotId)
		{
			return default(Vector2);
		}

		// Token: 0x0600ABDA RID: 43994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABDA")]
		[Address(RVA = "0x32709C0", Offset = "0x326F5C0", VA = "0x1832709C0")]
		public BLayoutManager()
		{
		}

		// Token: 0x0400A3ED RID: 41965
		[Token(Token = "0x400A3ED")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 FTG_PADDING;

		// Token: 0x0400A3EE RID: 41966
		[Token(Token = "0x400A3EE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 BKG_PADDING;

		// Token: 0x0400A3EF RID: 41967
		[Token(Token = "0x400A3EF")]
		private const float ZOOM_IN_FACTOR = 0.75f;

		// Token: 0x0400A3F0 RID: 41968
		[Token(Token = "0x400A3F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SafeParentComponent _container;

		// Token: 0x0400A3F1 RID: 41969
		[Token(Token = "0x400A3F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SafeParentComponent _hilightContainer;

		// Token: 0x0400A3F2 RID: 41970
		[Token(Token = "0x400A3F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ToggleGroup _toggleGroup;

		// Token: 0x0400A3F3 RID: 41971
		[Token(Token = "0x400A3F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _frontground;

		// Token: 0x0400A3F4 RID: 41972
		[Token(Token = "0x400A3F4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _background;

		// Token: 0x0400A3F5 RID: 41973
		[Token(Token = "0x400A3F5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tween", Priority = 1)]
		private float _tweenTime;

		// Token: 0x0400A3F6 RID: 41974
		[Token(Token = "0x400A3F6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Tween")]
		private Ease _tweenEaseType;

		// Token: 0x0400A3F8 RID: 41976
		[Token(Token = "0x400A3F8")]
		[FieldOffset(Offset = "0x50")]
		private float m_initZoom;

		// Token: 0x0400A3F9 RID: 41977
		[Token(Token = "0x400A3F9")]
		[FieldOffset(Offset = "0x58")]
		private BRoomSlot m_activeRoom;

		// Token: 0x0400A3FA RID: 41978
		[Token(Token = "0x400A3FA")]
		[FieldOffset(Offset = "0x60")]
		private BlueprintMode m_state;

		// Token: 0x0400A3FB RID: 41979
		[Token(Token = "0x400A3FB")]
		[FieldOffset(Offset = "0x68")]
		private List<BRoomSlot> m_rooms;

		// Token: 0x0400A3FC RID: 41980
		[Token(Token = "0x400A3FC")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, BRoomSlot> m_modelToRoomMap;

		// Token: 0x0400A3FD RID: 41981
		[Token(Token = "0x400A3FD")]
		[FieldOffset(Offset = "0x78")]
		private List<BRoomHilightContainer> m_hilightedSlots;

		// Token: 0x0400A3FE RID: 41982
		[Token(Token = "0x400A3FE")]
		[FieldOffset(Offset = "0x80")]
		private BRoomHilightViewModel m_pendingHilightChange;

		// Token: 0x02001A9D RID: 6813
		[Token(Token = "0x2001A9D")]
		public interface IListener
		{
			// Token: 0x0600ABDC RID: 43996
			[Token(Token = "0x600ABDC")]
			void OnArchitectureRoomSelected(RoomSlotModel room);
		}
	}
}
