using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Building.Vault.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A60 RID: 6752
	[Token(Token = "0x2001A60")]
	public class VCharacterController : SingletonMonoBehaviour<VCharacterController>, ISingletonNotAutoCreate, IHotfixable
	{
		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013F0")]
		public VCharacterController.VCharacterElevatorController elevatorController
		{
			[Token(Token = "0x600A9F7")]
			[Address(RVA = "0x3259CA0", Offset = "0x32588A0", VA = "0x183259CA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x0600A9F8 RID: 43512 RVA: 0x00041C10 File Offset: 0x0003FE10
		[Token(Token = "0x170013F1")]
		public VCharacterController.Options options
		{
			[Token(Token = "0x600A9F8")]
			[Address(RVA = "0x325A190", Offset = "0x3258D90", VA = "0x18325A190")]
			get
			{
				return default(VCharacterController.Options);
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x0600A9F9 RID: 43513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013F2")]
		public VCharacter character
		{
			[Token(Token = "0x600A9F9")]
			[Address(RVA = "0x3259BE0", Offset = "0x32587E0", VA = "0x183259BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x0600A9FA RID: 43514 RVA: 0x00041C28 File Offset: 0x0003FE28
		[Token(Token = "0x170013F3")]
		public float moveSpeed
		{
			[Token(Token = "0x600A9FA")]
			[Address(RVA = "0x325A0B0", Offset = "0x3258CB0", VA = "0x18325A0B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x0600A9FB RID: 43515 RVA: 0x00041C40 File Offset: 0x0003FE40
		[Token(Token = "0x170013F4")]
		public bool inControlMode
		{
			[Token(Token = "0x600A9FB")]
			[Address(RVA = "0x3259D00", Offset = "0x3258900", VA = "0x183259D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x0600A9FC RID: 43516 RVA: 0x00041C58 File Offset: 0x0003FE58
		// (set) Token: 0x0600A9FD RID: 43517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013F5")]
		public bool inElevatorRoom
		{
			[Token(Token = "0x600A9FC")]
			[Address(RVA = "0x3259D90", Offset = "0x3258990", VA = "0x183259D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A9FD")]
			[Address(RVA = "0x325A3B0", Offset = "0x3258FB0", VA = "0x18325A3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x0600A9FE RID: 43518 RVA: 0x00041C70 File Offset: 0x0003FE70
		[Token(Token = "0x170013F6")]
		public bool interactable
		{
			[Token(Token = "0x600A9FE")]
			[Address(RVA = "0x3259E60", Offset = "0x3258A60", VA = "0x183259E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x0600A9FF RID: 43519 RVA: 0x00041C88 File Offset: 0x0003FE88
		[Token(Token = "0x170013F7")]
		public bool interacting
		{
			[Token(Token = "0x600A9FF")]
			[Address(RVA = "0x3259EE0", Offset = "0x3258AE0", VA = "0x183259EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x0600AA00 RID: 43520 RVA: 0x00041CA0 File Offset: 0x0003FEA0
		[Token(Token = "0x170013F8")]
		public bool specialnteractable
		{
			[Token(Token = "0x600AA00")]
			[Address(RVA = "0x325A310", Offset = "0x3258F10", VA = "0x18325A310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x00041CB8 File Offset: 0x0003FEB8
		[Token(Token = "0x170013F9")]
		public bool moveable
		{
			[Token(Token = "0x600AA01")]
			[Address(RVA = "0x325A110", Offset = "0x3258D10", VA = "0x18325A110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x0600AA02 RID: 43522 RVA: 0x00041CD0 File Offset: 0x0003FED0
		[Token(Token = "0x170013FA")]
		public bool inUpDownstairs
		{
			[Token(Token = "0x600AA02")]
			[Address(RVA = "0x3259DF0", Offset = "0x32589F0", VA = "0x183259DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x0600AA03 RID: 43523 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		[Token(Token = "0x170013FB")]
		public bool isGoingUp
		{
			[Token(Token = "0x600AA03")]
			[Address(RVA = "0x325A010", Offset = "0x3258C10", VA = "0x18325A010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x0600AA04 RID: 43524 RVA: 0x00041D00 File Offset: 0x0003FF00
		[Token(Token = "0x170013FC")]
		public bool isGoingDown
		{
			[Token(Token = "0x600AA04")]
			[Address(RVA = "0x3259F70", Offset = "0x3258B70", VA = "0x183259F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x0600AA05 RID: 43525 RVA: 0x00041D18 File Offset: 0x0003FF18
		[Token(Token = "0x170013FD")]
		public bool canGoUpstairs
		{
			[Token(Token = "0x600AA05")]
			[Address(RVA = "0x3259B60", Offset = "0x3258760", VA = "0x183259B60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x0600AA06 RID: 43526 RVA: 0x00041D30 File Offset: 0x0003FF30
		[Token(Token = "0x170013FE")]
		public bool canGoDownstairs
		{
			[Token(Token = "0x600AA06")]
			[Address(RVA = "0x3259AE0", Offset = "0x32586E0", VA = "0x183259AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x0600AA07 RID: 43527 RVA: 0x00041D48 File Offset: 0x0003FF48
		[Token(Token = "0x170013FF")]
		public VCharacterController.DoorPosState doorPosState
		{
			[Token(Token = "0x600AA07")]
			[Address(RVA = "0x3259C40", Offset = "0x3258840", VA = "0x183259C40")]
			get
			{
				return VCharacterController.DoorPosState.NORMAL;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x0600AA08 RID: 43528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001400")]
		private VRoomSlot predictedNextSlot
		{
			[Token(Token = "0x600AA08")]
			[Address(RVA = "0x325A230", Offset = "0x3258E30", VA = "0x18325A230")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA09")]
		[Address(RVA = "0x3256D60", Offset = "0x3255960", VA = "0x183256D60")]
		public void SetMoveHolder(IMoveHolder moveHolder)
		{
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x00041D60 File Offset: 0x0003FF60
		[Token(Token = "0x600AA0A")]
		[Address(RVA = "0x3256EE0", Offset = "0x3255AE0", VA = "0x183256EE0")]
		public bool StartControlVChar(VCharacter character)
		{
			return default(bool);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x00041D78 File Offset: 0x0003FF78
		[Token(Token = "0x600AA0B")]
		[Address(RVA = "0x3257200", Offset = "0x3255E00", VA = "0x183257200")]
		public bool StopControl()
		{
			return default(bool);
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA0C")]
		[Address(RVA = "0x3257BF0", Offset = "0x32567F0", VA = "0x183257BF0")]
		public void VCharacterGoUpstairs()
		{
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA0D")]
		[Address(RVA = "0x3257AF0", Offset = "0x32566F0", VA = "0x183257AF0")]
		public void VCharacterGoDownstairs()
		{
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA0E")]
		[Address(RVA = "0x32569B0", Offset = "0x32555B0", VA = "0x1832569B0")]
		public void InteractInControl()
		{
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA0F")]
		[Address(RVA = "0x3256DE0", Offset = "0x32559E0", VA = "0x183256DE0")]
		public void SpecialInteractInControl()
		{
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA10")]
		[Address(RVA = "0x3258240", Offset = "0x3256E40", VA = "0x183258240")]
		public void VCharacterShowEmoji(string emojiId)
		{
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA11")]
		[Address(RVA = "0x3256870", Offset = "0x3255470", VA = "0x183256870")]
		public VRoom GetVRoomBySlotId(string slotId)
		{
			return null;
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA12")]
		[Address(RVA = "0x3257CF0", Offset = "0x32568F0", VA = "0x183257CF0")]
		public void VCharacterMove(ref Vector2 direction)
		{
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA13")]
		[Address(RVA = "0x3258590", Offset = "0x3257190", VA = "0x183258590")]
		private void _DoVCharMove(Vector2 direction)
		{
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA14")]
		[Address(RVA = "0x3258400", Offset = "0x3257000", VA = "0x183258400")]
		private void _DisableCurrentHighlight()
		{
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA15")]
		[Address(RVA = "0x32595E0", Offset = "0x32581E0", VA = "0x1832595E0")]
		private void _RefreshHighlightDoor(GridPosition pos)
		{
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x00041D90 File Offset: 0x0003FF90
		[Token(Token = "0x600AA16")]
		[Address(RVA = "0x3256C00", Offset = "0x3255800", VA = "0x183256C00")]
		public bool IsPositionDoorRow(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x00041DA8 File Offset: 0x0003FFA8
		[Token(Token = "0x600AA17")]
		[Address(RVA = "0x3258320", Offset = "0x3256F20", VA = "0x183258320")]
		private bool _CheckMovePositionChangeRoom(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x00041DC0 File Offset: 0x0003FFC0
		[Token(Token = "0x600AA18")]
		[Address(RVA = "0x32594E0", Offset = "0x32580E0", VA = "0x1832594E0")]
		private VCharacterController.DoorPosState _RefreshDoorPosState(GridPosition pos)
		{
			return VCharacterController.DoorPosState.NORMAL;
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x00041DD8 File Offset: 0x0003FFD8
		[Token(Token = "0x600AA19")]
		[Address(RVA = "0x32579D0", Offset = "0x32565D0", VA = "0x1832579D0")]
		public bool VCharRoomChanged(VCharacter character, VRoom room, bool force = false)
		{
			return default(bool);
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1A")]
		[Address(RVA = "0x3259840", Offset = "0x3258440", VA = "0x183259840")]
		public void _RefreshInteractCandidate()
		{
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x00041DF0 File Offset: 0x0003FFF0
		[Token(Token = "0x600AA1B")]
		[Address(RVA = "0x3258990", Offset = "0x3257590", VA = "0x183258990")]
		private bool _FindInteractFurnitureSlotCandidate()
		{
			return default(bool);
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x00041E08 File Offset: 0x00040008
		[Token(Token = "0x600AA1C")]
		[Address(RVA = "0x3258CE0", Offset = "0x32578E0", VA = "0x183258CE0")]
		private bool _FindInteractVFurnitureEntityCandidate()
		{
			return default(bool);
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1D")]
		[Address(RVA = "0x3259170", Offset = "0x3257D70", VA = "0x183259170")]
		private void _OnRoomUpdated()
		{
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1E")]
		[Address(RVA = "0x3259110", Offset = "0x3257D10", VA = "0x183259110")]
		private void _NotifyNeedDetialUpdate()
		{
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA1F")]
		[Address(RVA = "0x3256C90", Offset = "0x3255890", VA = "0x183256C90")]
		public void NotifyStateChanged()
		{
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA20")]
		[Address(RVA = "0x32593C0", Offset = "0x3257FC0", VA = "0x1832593C0")]
		private void _OnStateChanged()
		{
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA21")]
		[Address(RVA = "0x3257540", Offset = "0x3256140", VA = "0x183257540")]
		public void UpdateControlInput()
		{
		}

		// Token: 0x0600AA22 RID: 43554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA22")]
		[Address(RVA = "0x32566C0", Offset = "0x32552C0", VA = "0x1832566C0")]
		private void FocusCharacter()
		{
		}

		// Token: 0x0600AA23 RID: 43555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA23")]
		[Address(RVA = "0x3256CF0", Offset = "0x32558F0", VA = "0x183256CF0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600AA24 RID: 43556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA24")]
		[Address(RVA = "0x3256320", Offset = "0x3254F20", VA = "0x183256320", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x0600AA25 RID: 43557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA25")]
		[Address(RVA = "0x3259A00", Offset = "0x3258600", VA = "0x183259A00")]
		public VCharacterController()
		{
		}

		// Token: 0x0400A20A RID: 41482
		[Token(Token = "0x400A20A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _moveMaxSpeed;

		// Token: 0x0400A20B RID: 41483
		[Token(Token = "0x400A20B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _moveSpeed;

		// Token: 0x0400A20C RID: 41484
		[Token(Token = "0x400A20C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _moveAnimScale;

		// Token: 0x0400A20D RID: 41485
		[Token(Token = "0x400A20D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _colliderRangeY;

		// Token: 0x0400A20E RID: 41486
		[Token(Token = "0x400A20E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _cameraFocusMaxDist;

		// Token: 0x0400A20F RID: 41487
		[Token(Token = "0x400A20F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _cameraZoom;

		// Token: 0x0400A210 RID: 41488
		[Token(Token = "0x400A210")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _highlightWhenMove;

		// Token: 0x0400A211 RID: 41489
		[Token(Token = "0x400A211")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool _forceIdleWhenCannotMove;

		// Token: 0x0400A212 RID: 41490
		[Token(Token = "0x400A212")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _elevatorTime;

		// Token: 0x0400A213 RID: 41491
		[Token(Token = "0x400A213")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _elevatorAutoMoveTime;

		// Token: 0x0400A214 RID: 41492
		[Token(Token = "0x400A214")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _elevatorCurve;

		// Token: 0x0400A215 RID: 41493
		[Token(Token = "0x400A215")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _elevatorHeightOffset;

		// Token: 0x0400A216 RID: 41494
		[Token(Token = "0x400A216")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _distanceToInteract;

		// Token: 0x0400A217 RID: 41495
		[Token(Token = "0x400A217")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _distanceToInteractUpdate;

		// Token: 0x0400A218 RID: 41496
		[Token(Token = "0x400A218")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _focusDoorSpeedRatio;

		// Token: 0x0400A219 RID: 41497
		[Token(Token = "0x400A219")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _speedToLeaveInteract;

		// Token: 0x0400A21A RID: 41498
		[Token(Token = "0x400A21A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _canInterruptSpecialAnim;

		// Token: 0x0400A21B RID: 41499
		[Token(Token = "0x400A21B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private VCharacterEmojiPanel _emojiPanel;

		// Token: 0x0400A21C RID: 41500
		[Token(Token = "0x400A21C")]
		[FieldOffset(Offset = "0x68")]
		private VCharacterController.VCharacterElevatorController m_elevatorController;

		// Token: 0x0400A21D RID: 41501
		[Token(Token = "0x400A21D")]
		[FieldOffset(Offset = "0x70")]
		private VCharacterController.VCharacterMoveChecker m_moveChecker;

		// Token: 0x0400A21E RID: 41502
		[Token(Token = "0x400A21E")]
		[FieldOffset(Offset = "0x78")]
		private VCharacterEmojiPanel m_emojiPanel;

		// Token: 0x0400A21F RID: 41503
		[Token(Token = "0x400A21F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_needDetailUpdate;

		// Token: 0x0400A220 RID: 41504
		[Token(Token = "0x400A220")]
		[FieldOffset(Offset = "0x81")]
		private bool m_stateChanged;

		// Token: 0x0400A221 RID: 41505
		[Token(Token = "0x400A221")]
		[FieldOffset(Offset = "0x88")]
		private IMoveHolder m_moveHolder;

		// Token: 0x0400A222 RID: 41506
		[Token(Token = "0x400A222")]
		[FieldOffset(Offset = "0x90")]
		private float m_moveSpeed;

		// Token: 0x0400A223 RID: 41507
		[Token(Token = "0x400A223")]
		[FieldOffset(Offset = "0x94")]
		private float m_moveSpeedScale;

		// Token: 0x0400A224 RID: 41508
		[Token(Token = "0x400A224")]
		[FieldOffset(Offset = "0x98")]
		private Vector2 m_direction;

		// Token: 0x0400A225 RID: 41509
		[Token(Token = "0x400A225")]
		[FieldOffset(Offset = "0xA0")]
		private VCharacter m_character;

		// Token: 0x0400A226 RID: 41510
		[Token(Token = "0x400A226")]
		[FieldOffset(Offset = "0xA8")]
		private VRoom.IVCharInteractable m_interactCandidate;

		// Token: 0x0400A227 RID: 41511
		[Token(Token = "0x400A227")]
		[FieldOffset(Offset = "0xB0")]
		private Vector2 m_moveDir;

		// Token: 0x0400A228 RID: 41512
		[Token(Token = "0x400A228")]
		[FieldOffset(Offset = "0xB8")]
		private VCharacterController.DoorPosState m_doorPosState;

		// Token: 0x0400A229 RID: 41513
		[Token(Token = "0x400A229")]
		[FieldOffset(Offset = "0xC0")]
		private VDoor m_predictedDoor;

		// Token: 0x0400A22A RID: 41514
		[Token(Token = "0x400A22A")]
		[FieldOffset(Offset = "0xC8")]
		private VCharacterController.Options m_options;

		// Token: 0x0400A22C RID: 41516
		[Token(Token = "0x400A22C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_elevatorController;

		// Token: 0x0400A22D RID: 41517
		[Token(Token = "0x400A22D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x0400A22E RID: 41518
		[Token(Token = "0x400A22E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x0400A22F RID: 41519
		[Token(Token = "0x400A22F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_moveSpeed;

		// Token: 0x0400A230 RID: 41520
		[Token(Token = "0x400A230")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inControlMode;

		// Token: 0x0400A231 RID: 41521
		[Token(Token = "0x400A231")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_inElevatorRoom;

		// Token: 0x0400A232 RID: 41522
		[Token(Token = "0x400A232")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_inElevatorRoom;

		// Token: 0x0400A233 RID: 41523
		[Token(Token = "0x400A233")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0400A234 RID: 41524
		[Token(Token = "0x400A234")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_interacting;

		// Token: 0x0400A235 RID: 41525
		[Token(Token = "0x400A235")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_specialnteractable;

		// Token: 0x0400A236 RID: 41526
		[Token(Token = "0x400A236")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_moveable;

		// Token: 0x0400A237 RID: 41527
		[Token(Token = "0x400A237")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_inUpDownstairs;

		// Token: 0x0400A238 RID: 41528
		[Token(Token = "0x400A238")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isGoingUp;

		// Token: 0x0400A239 RID: 41529
		[Token(Token = "0x400A239")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isGoingDown;

		// Token: 0x0400A23A RID: 41530
		[Token(Token = "0x400A23A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_canGoUpstairs;

		// Token: 0x0400A23B RID: 41531
		[Token(Token = "0x400A23B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_canGoDownstairs;

		// Token: 0x0400A23C RID: 41532
		[Token(Token = "0x400A23C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_doorPosState;

		// Token: 0x0400A23D RID: 41533
		[Token(Token = "0x400A23D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_predictedNextSlot;

		// Token: 0x0400A23E RID: 41534
		[Token(Token = "0x400A23E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetMoveHolder;

		// Token: 0x0400A23F RID: 41535
		[Token(Token = "0x400A23F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_StartControlVChar;

		// Token: 0x0400A240 RID: 41536
		[Token(Token = "0x400A240")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_StopControl;

		// Token: 0x0400A241 RID: 41537
		[Token(Token = "0x400A241")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_VCharacterGoUpstairs;

		// Token: 0x0400A242 RID: 41538
		[Token(Token = "0x400A242")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_VCharacterGoDownstairs;

		// Token: 0x0400A243 RID: 41539
		[Token(Token = "0x400A243")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_InteractInControl;

		// Token: 0x0400A244 RID: 41540
		[Token(Token = "0x400A244")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SpecialInteractInControl;

		// Token: 0x0400A245 RID: 41541
		[Token(Token = "0x400A245")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_VCharacterShowEmoji;

		// Token: 0x0400A246 RID: 41542
		[Token(Token = "0x400A246")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetVRoomBySlotId;

		// Token: 0x0400A247 RID: 41543
		[Token(Token = "0x400A247")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_VCharacterMove;

		// Token: 0x0400A248 RID: 41544
		[Token(Token = "0x400A248")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__DoVCharMove;

		// Token: 0x0400A249 RID: 41545
		[Token(Token = "0x400A249")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__DisableCurrentHighlight;

		// Token: 0x0400A24A RID: 41546
		[Token(Token = "0x400A24A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__RefreshHighlightDoor;

		// Token: 0x0400A24B RID: 41547
		[Token(Token = "0x400A24B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_IsPositionDoorRow;

		// Token: 0x0400A24C RID: 41548
		[Token(Token = "0x400A24C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CheckMovePositionChangeRoom;

		// Token: 0x0400A24D RID: 41549
		[Token(Token = "0x400A24D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__RefreshDoorPosState;

		// Token: 0x0400A24E RID: 41550
		[Token(Token = "0x400A24E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_VCharRoomChanged;

		// Token: 0x0400A24F RID: 41551
		[Token(Token = "0x400A24F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__RefreshInteractCandidate;

		// Token: 0x0400A250 RID: 41552
		[Token(Token = "0x400A250")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__FindInteractFurnitureSlotCandidate;

		// Token: 0x0400A251 RID: 41553
		[Token(Token = "0x400A251")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__FindInteractVFurnitureEntityCandidate;

		// Token: 0x0400A252 RID: 41554
		[Token(Token = "0x400A252")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OnRoomUpdated;

		// Token: 0x0400A253 RID: 41555
		[Token(Token = "0x400A253")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__NotifyNeedDetialUpdate;

		// Token: 0x0400A254 RID: 41556
		[Token(Token = "0x400A254")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_NotifyStateChanged;

		// Token: 0x0400A255 RID: 41557
		[Token(Token = "0x400A255")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x0400A256 RID: 41558
		[Token(Token = "0x400A256")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_UpdateControlInput;

		// Token: 0x0400A257 RID: 41559
		[Token(Token = "0x400A257")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_FocusCharacter;

		// Token: 0x0400A258 RID: 41560
		[Token(Token = "0x400A258")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400A259 RID: 41561
		[Token(Token = "0x400A259")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400A25A RID: 41562
		[Token(Token = "0x400A25A")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A61 RID: 6753
		[Token(Token = "0x2001A61")]
		public struct Options
		{
			// Token: 0x0400A25B RID: 41563
			[Token(Token = "0x400A25B")]
			[FieldOffset(Offset = "0x0")]
			public float elevatorHeightOffset;

			// Token: 0x0400A25C RID: 41564
			[Token(Token = "0x400A25C")]
			[FieldOffset(Offset = "0x8")]
			public AnimationCurve elevatorCurve;

			// Token: 0x0400A25D RID: 41565
			[Token(Token = "0x400A25D")]
			[FieldOffset(Offset = "0x10")]
			public float elevatorTime;

			// Token: 0x0400A25E RID: 41566
			[Token(Token = "0x400A25E")]
			[FieldOffset(Offset = "0x14")]
			public float elevatorAutoMoveTime;

			// Token: 0x0400A25F RID: 41567
			[Token(Token = "0x400A25F")]
			[FieldOffset(Offset = "0x18")]
			public float focusDoorSpeedRatio;

			// Token: 0x0400A260 RID: 41568
			[Token(Token = "0x400A260")]
			[FieldOffset(Offset = "0x1C")]
			public float moveAnimScale;

			// Token: 0x0400A261 RID: 41569
			[Token(Token = "0x400A261")]
			[FieldOffset(Offset = "0x20")]
			public float colliderRangeY;
		}

		// Token: 0x02001A62 RID: 6754
		[Token(Token = "0x2001A62")]
		public enum DoorPosState
		{
			// Token: 0x0400A263 RID: 41571
			[Token(Token = "0x400A263")]
			NORMAL,
			// Token: 0x0400A264 RID: 41572
			[Token(Token = "0x400A264")]
			BESIDE_LDOOR,
			// Token: 0x0400A265 RID: 41573
			[Token(Token = "0x400A265")]
			BESIDE_RDOOR
		}

		// Token: 0x02001A63 RID: 6755
		[Token(Token = "0x2001A63")]
		public class VCharacterElevatorController : IHotfixable
		{
			// Token: 0x0600AA26 RID: 43558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA26")]
			[Address(RVA = "0x325CA80", Offset = "0x325B680", VA = "0x18325CA80")]
			public VCharacterElevatorController(VCharacterController controller)
			{
			}

			// Token: 0x17001401 RID: 5121
			// (get) Token: 0x0600AA27 RID: 43559 RVA: 0x00041E20 File Offset: 0x00040020
			[Token(Token = "0x17001401")]
			public bool inUpDownstairs
			{
				[Token(Token = "0x600AA27")]
				[Address(RVA = "0x325CBA0", Offset = "0x325B7A0", VA = "0x18325CBA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001402 RID: 5122
			// (get) Token: 0x0600AA28 RID: 43560 RVA: 0x00041E38 File Offset: 0x00040038
			// (set) Token: 0x0600AA29 RID: 43561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001402")]
			public bool isGoingUp
			{
				[Token(Token = "0x600AA28")]
				[Address(RVA = "0x325CCE0", Offset = "0x325B8E0", VA = "0x18325CCE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600AA29")]
				[Address(RVA = "0x325CDB0", Offset = "0x325B9B0", VA = "0x18325CDB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001403 RID: 5123
			// (get) Token: 0x0600AA2A RID: 43562 RVA: 0x00041E50 File Offset: 0x00040050
			// (set) Token: 0x0600AA2B RID: 43563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001403")]
			public bool isGoingDown
			{
				[Token(Token = "0x600AA2A")]
				[Address(RVA = "0x325CC80", Offset = "0x325B880", VA = "0x18325CC80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600AA2B")]
				[Address(RVA = "0x325CD40", Offset = "0x325B940", VA = "0x18325CD40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600AA2C RID: 43564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA2C")]
			[Address(RVA = "0x325A910", Offset = "0x3259510", VA = "0x18325A910")]
			public void OnDisable()
			{
			}

			// Token: 0x0600AA2D RID: 43565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA2D")]
			[Address(RVA = "0x325AF40", Offset = "0x3259B40", VA = "0x18325AF40")]
			public void Refresh(VCharacter character)
			{
			}

			// Token: 0x0600AA2E RID: 43566 RVA: 0x00041E68 File Offset: 0x00040068
			[Token(Token = "0x600AA2E")]
			[Address(RVA = "0x325A420", Offset = "0x3259020", VA = "0x18325A420")]
			public bool CanGoUpDownStairs(bool isUp, VCharacter character)
			{
				return default(bool);
			}

			// Token: 0x0600AA2F RID: 43567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA2F")]
			[Address(RVA = "0x325AE50", Offset = "0x3259A50", VA = "0x18325AE50")]
			public void OnRoomUpdated(VCharacter character)
			{
			}

			// Token: 0x0600AA30 RID: 43568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA30")]
			[Address(RVA = "0x325BC80", Offset = "0x325A880", VA = "0x18325BC80")]
			private void _RefreshAutoMovingElevators(string slotId)
			{
			}

			// Token: 0x0600AA31 RID: 43569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA31")]
			[Address(RVA = "0x325C2E0", Offset = "0x325AEE0", VA = "0x18325C2E0")]
			private void _UpdateAutoMovingElevators(BuildingModel buildingModel, string slotId)
			{
			}

			// Token: 0x0600AA32 RID: 43570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA32")]
			[Address(RVA = "0x325C060", Offset = "0x325AC60", VA = "0x18325C060")]
			private void _RefreshUpdownElevatorSlots(string slotId)
			{
			}

			// Token: 0x0600AA33 RID: 43571 RVA: 0x00041E80 File Offset: 0x00040080
			[Token(Token = "0x600AA33")]
			[Address(RVA = "0x325A530", Offset = "0x3259130", VA = "0x18325A530")]
			public bool CanMoveToNextRoom(VRoomSlot nextSlot)
			{
				return default(bool);
			}

			// Token: 0x0600AA34 RID: 43572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA34")]
			[Address(RVA = "0x325C490", Offset = "0x325B090", VA = "0x18325C490")]
			private void _UpdateMovingElevators(string slotId, VRoom targetRoom, float duration)
			{
			}

			// Token: 0x0600AA35 RID: 43573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA35")]
			[Address(RVA = "0x325B330", Offset = "0x3259F30", VA = "0x18325B330")]
			private void _ElevatorCurveMove(VElevatorRoom.ElevatorObj obj, VCharacterController.VCharacterElevatorController.ElevatorMovingState movingState, float duration)
			{
			}

			// Token: 0x0600AA36 RID: 43574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA36")]
			[Address(RVA = "0x325B850", Offset = "0x325A450", VA = "0x18325B850")]
			private void _OnElevatorMoveSuccess(VElevatorRoom.ElevatorObj obj, VRoom targetRoom)
			{
			}

			// Token: 0x0600AA37 RID: 43575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA37")]
			[Address(RVA = "0x325C770", Offset = "0x325B370", VA = "0x18325C770")]
			private void _UpdateMovingRelatedElevators(string slotId, SharedConsts.Direction direction, VRoom targetRoom, float duration)
			{
			}

			// Token: 0x0600AA38 RID: 43576 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AA38")]
			[Address(RVA = "0x325A820", Offset = "0x3259420", VA = "0x18325A820")]
			public IEnumerator DoMoveByElevator(VCharacter character, bool isUp)
			{
				return null;
			}

			// Token: 0x0400A268 RID: 41576
			[Token(Token = "0x400A268")]
			[FieldOffset(Offset = "0x18")]
			private VCharacterController m_controller;

			// Token: 0x0400A269 RID: 41577
			[Token(Token = "0x400A269")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<VElevatorRoom.ElevatorObj, VCharacterController.VCharacterElevatorController.ElevatorMovingState> m_movingElevators;

			// Token: 0x0400A26A RID: 41578
			[Token(Token = "0x400A26A")]
			[FieldOffset(Offset = "0x28")]
			private List<VCharacter> m_sharedCharacters;

			// Token: 0x0400A26B RID: 41579
			[Token(Token = "0x400A26B")]
			[FieldOffset(Offset = "0x30")]
			private string m_upstairsSlotId;

			// Token: 0x0400A26C RID: 41580
			[Token(Token = "0x400A26C")]
			[FieldOffset(Offset = "0x38")]
			private string m_downstairsSlotId;

			// Token: 0x0400A26D RID: 41581
			[Token(Token = "0x400A26D")]
			private const float ROOM_PLANE_OFFSET_MAX = 0.5f;

			// Token: 0x0400A26E RID: 41582
			[Token(Token = "0x400A26E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400A26F RID: 41583
			[Token(Token = "0x400A26F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_inUpDownstairs;

			// Token: 0x0400A270 RID: 41584
			[Token(Token = "0x400A270")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_isGoingUp;

			// Token: 0x0400A271 RID: 41585
			[Token(Token = "0x400A271")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_isGoingUp;

			// Token: 0x0400A272 RID: 41586
			[Token(Token = "0x400A272")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_isGoingDown;

			// Token: 0x0400A273 RID: 41587
			[Token(Token = "0x400A273")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_isGoingDown;

			// Token: 0x0400A274 RID: 41588
			[Token(Token = "0x400A274")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnDisable;

			// Token: 0x0400A275 RID: 41589
			[Token(Token = "0x400A275")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_Refresh;

			// Token: 0x0400A276 RID: 41590
			[Token(Token = "0x400A276")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_CanGoUpDownStairs;

			// Token: 0x0400A277 RID: 41591
			[Token(Token = "0x400A277")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_OnRoomUpdated;

			// Token: 0x0400A278 RID: 41592
			[Token(Token = "0x400A278")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__RefreshAutoMovingElevators;

			// Token: 0x0400A279 RID: 41593
			[Token(Token = "0x400A279")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__UpdateAutoMovingElevators;

			// Token: 0x0400A27A RID: 41594
			[Token(Token = "0x400A27A")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__RefreshUpdownElevatorSlots;

			// Token: 0x0400A27B RID: 41595
			[Token(Token = "0x400A27B")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_CanMoveToNextRoom;

			// Token: 0x0400A27C RID: 41596
			[Token(Token = "0x400A27C")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0__UpdateMovingElevators;

			// Token: 0x0400A27D RID: 41597
			[Token(Token = "0x400A27D")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0__ElevatorCurveMove;

			// Token: 0x0400A27E RID: 41598
			[Token(Token = "0x400A27E")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__OnElevatorMoveSuccess;

			// Token: 0x0400A27F RID: 41599
			[Token(Token = "0x400A27F")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0__UpdateMovingRelatedElevators;

			// Token: 0x0400A280 RID: 41600
			[Token(Token = "0x400A280")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_DoMoveByElevator;

			// Token: 0x02001A64 RID: 6756
			[Token(Token = "0x2001A64")]
			private class ElevatorMovingState
			{
				// Token: 0x17001404 RID: 5124
				// (get) Token: 0x0600AA39 RID: 43577 RVA: 0x00041E98 File Offset: 0x00040098
				[Token(Token = "0x17001404")]
				public bool isMoving
				{
					[Token(Token = "0x600AA39")]
					[Address(RVA = "0x3251650", Offset = "0x3250250", VA = "0x183251650")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600AA3A RID: 43578 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600AA3A")]
				[Address(RVA = "0x103F530", Offset = "0x103E130", VA = "0x18103F530")]
				public void ResetTween()
				{
				}

				// Token: 0x0600AA3B RID: 43579 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600AA3B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ElevatorMovingState()
				{
				}

				// Token: 0x0400A281 RID: 41601
				[Token(Token = "0x400A281")]
				[FieldOffset(Offset = "0x10")]
				public VRoom targetRoom;

				// Token: 0x0400A282 RID: 41602
				[Token(Token = "0x400A282")]
				[FieldOffset(Offset = "0x18")]
				public Tween movingTween;

				// Token: 0x0400A283 RID: 41603
				[Token(Token = "0x400A283")]
				[FieldOffset(Offset = "0x20")]
				public bool isMovingUp;
			}
		}

		// Token: 0x02001A68 RID: 6760
		[Token(Token = "0x2001A68")]
		public class VCharacterMoveChecker
		{
			// Token: 0x0600AA48 RID: 43592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA48")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public VCharacterMoveChecker(VCharacterController controller)
			{
			}

			// Token: 0x17001407 RID: 5127
			// (get) Token: 0x0600AA49 RID: 43593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001407")]
			private VCharacter character
			{
				[Token(Token = "0x600AA49")]
				[Address(RVA = "0x325E550", Offset = "0x325D150", VA = "0x18325E550")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001408 RID: 5128
			// (get) Token: 0x0600AA4A RID: 43594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001408")]
			private GridMap gridMap
			{
				[Token(Token = "0x600AA4A")]
				[Address(RVA = "0x325E5C0", Offset = "0x325D1C0", VA = "0x18325E5C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600AA4B RID: 43595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA4B")]
			[Address(RVA = "0x325D8E0", Offset = "0x325C4E0", VA = "0x18325D8E0")]
			public void Verify(ref VCharacterController.DoorPosState doorPosState, ref Vector2 direction)
			{
			}

			// Token: 0x0600AA4C RID: 43596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA4C")]
			[Address(RVA = "0x325E360", Offset = "0x325CF60", VA = "0x18325E360")]
			private void _VerifyDoorState(ref VCharacterController.DoorPosState doorPosState)
			{
			}

			// Token: 0x0600AA4D RID: 43597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA4D")]
			[Address(RVA = "0x325DE50", Offset = "0x325CA50", VA = "0x18325DE50")]
			private void _VerifyDirection(VCharacterController.DoorPosState doorPosState, ref Vector2 direction)
			{
			}

			// Token: 0x0600AA4E RID: 43598 RVA: 0x00041EE0 File Offset: 0x000400E0
			[Token(Token = "0x600AA4E")]
			[Address(RVA = "0x325D9B0", Offset = "0x325C5B0", VA = "0x18325D9B0")]
			private bool _CheckMovePositionValid(VCharacterController.DoorPosState doorPosState, GridPosition pos, bool ignoreEmptyGridCheck)
			{
				return default(bool);
			}

			// Token: 0x0600AA4F RID: 43599 RVA: 0x00041EF8 File Offset: 0x000400F8
			[Token(Token = "0x600AA4F")]
			[Address(RVA = "0x325DD40", Offset = "0x325C940", VA = "0x18325DD40")]
			private bool _IsPositionDoor(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x0600AA50 RID: 43600 RVA: 0x00041F10 File Offset: 0x00040110
			[Token(Token = "0x600AA50")]
			[Address(RVA = "0x325DE10", Offset = "0x325CA10", VA = "0x18325DE10")]
			private bool _IsPositionNotBesideWall(GridPosition pos)
			{
				return default(bool);
			}

			// Token: 0x0600AA51 RID: 43601 RVA: 0x00041F28 File Offset: 0x00040128
			[Token(Token = "0x600AA51")]
			[Address(RVA = "0x325DDA0", Offset = "0x325C9A0", VA = "0x18325DDA0")]
			private bool _IsPositionFocusToDoor(GridPosition pos, Vector2 direction)
			{
				return default(bool);
			}

			// Token: 0x0600AA52 RID: 43602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AA52")]
			[Address(RVA = "0x325DB10", Offset = "0x325C710", VA = "0x18325DB10")]
			private void _FocusToDoorPosition(GridPosition pos, ref Vector2 direction)
			{
			}

			// Token: 0x0400A292 RID: 41618
			[Token(Token = "0x400A292")]
			[FieldOffset(Offset = "0x10")]
			private VCharacterController m_controller;
		}
	}
}
