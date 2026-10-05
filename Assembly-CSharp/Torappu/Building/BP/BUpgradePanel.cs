using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.BP
{
	// Token: 0x02001AA8 RID: 6824
	[Token(Token = "0x2001AA8")]
	public class BUpgradePanel : MonoBehaviour
	{
		// Token: 0x14000056 RID: 86
		// (add) Token: 0x0600AC34 RID: 44084 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600AC35 RID: 44085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000056")]
		public event Action onComplete
		{
			[Token(Token = "0x600AC34")]
			[Address(RVA = "0x327B3B0", Offset = "0x3279FB0", VA = "0x18327B3B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600AC35")]
			[Address(RVA = "0x327B450", Offset = "0x327A050", VA = "0x18327B450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600AC36 RID: 44086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC36")]
		[Address(RVA = "0x327A730", Offset = "0x3279330", VA = "0x18327A730")]
		public void Setup(RoomSlotModel room)
		{
		}

		// Token: 0x0600AC37 RID: 44087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC37")]
		[Address(RVA = "0x327B140", Offset = "0x3279D40", VA = "0x18327B140")]
		private void _OnTimeTick(CountDownTask.TickValue tickValue)
		{
		}

		// Token: 0x0600AC38 RID: 44088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC38")]
		[Address(RVA = "0x327B2D0", Offset = "0x3279ED0", VA = "0x18327B2D0")]
		private void _OnTimeout()
		{
		}

		// Token: 0x0600AC39 RID: 44089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC39")]
		[Address(RVA = "0x327B080", Offset = "0x3279C80", VA = "0x18327B080")]
		private void _ClearRoomModel()
		{
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC3A")]
		[Address(RVA = "0x327B010", Offset = "0x3279C10", VA = "0x18327B010")]
		private void _ClearCountDownTask()
		{
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC3B")]
		[Address(RVA = "0x327AB40", Offset = "0x3279740", VA = "0x18327AB40")]
		private void Update()
		{
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC3C")]
		[Address(RVA = "0x327A690", Offset = "0x3279290", VA = "0x18327A690")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC3D")]
		[Address(RVA = "0x327AA40", Offset = "0x3279640", VA = "0x18327AA40")]
		public void UpdateRestTime(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC3E")]
		[Address(RVA = "0x327B0C0", Offset = "0x3279CC0", VA = "0x18327B0C0")]
		private void _DetachCompleteBG()
		{
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC3F")]
		[Address(RVA = "0x327AD20", Offset = "0x3279920", VA = "0x18327AD20")]
		private void _AttachCompleteBG()
		{
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC40")]
		[Address(RVA = "0x327B390", Offset = "0x3279F90", VA = "0x18327B390")]
		public BUpgradePanel()
		{
		}

		// Token: 0x0400A457 RID: 42071
		[Token(Token = "0x400A457")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _restTimeLabel;

		// Token: 0x0400A458 RID: 42072
		[Token(Token = "0x400A458")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PiecewiseProgressBar _progressBar;

		// Token: 0x0400A459 RID: 42073
		[Token(Token = "0x400A459")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _inprogressLabel;

		// Token: 0x0400A45A RID: 42074
		[Token(Token = "0x400A45A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _completeLabel;

		// Token: 0x0400A45B RID: 42075
		[Token(Token = "0x400A45B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _progressBarWidthFactor;

		// Token: 0x0400A45C RID: 42076
		[Token(Token = "0x400A45C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _completeBGVerticalOffset;

		// Token: 0x0400A45D RID: 42077
		[Token(Token = "0x400A45D")]
		[FieldOffset(Offset = "0x40")]
		private RoomSlotModel m_model;

		// Token: 0x0400A45E RID: 42078
		[Token(Token = "0x400A45E")]
		[FieldOffset(Offset = "0x48")]
		private CountDownTask m_cdTask;

		// Token: 0x0400A45F RID: 42079
		[Token(Token = "0x400A45F")]
		[FieldOffset(Offset = "0x50")]
		private bool m_needUpdateBarScale;

		// Token: 0x0400A460 RID: 42080
		[Token(Token = "0x400A460")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_completeBGInstance;

		// Token: 0x0400A462 RID: 42082
		[Token(Token = "0x400A462")]
		[FieldOffset(Offset = "0x68")]
		private BUpgradePanel.RoomSlotModelListener m_modelListener;

		// Token: 0x02001AA9 RID: 6825
		[Token(Token = "0x2001AA9")]
		private class RoomSlotModelListener : RoomSlotModel.IListener
		{
			// Token: 0x0600AC41 RID: 44097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC41")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public RoomSlotModelListener(BUpgradePanel room)
			{
			}

			// Token: 0x0600AC42 RID: 44098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC42")]
			[Address(RVA = "0x3287170", Offset = "0x3285D70", VA = "0x183287170", Slot = "5")]
			public void OnContentChange(RoomSlotModel slotModel)
			{
			}

			// Token: 0x0600AC43 RID: 44099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC43")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			public void OnRegister(RoomSlotModel slotModel)
			{
			}

			// Token: 0x0600AC44 RID: 44100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AC44")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public void OnPostLayoutContentChanged()
			{
			}

			// Token: 0x0400A463 RID: 42083
			[Token(Token = "0x400A463")]
			[FieldOffset(Offset = "0x10")]
			private BUpgradePanel m_panel;
		}
	}
}
