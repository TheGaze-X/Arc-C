using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003741 RID: 14145
	[Token(Token = "0x2003741")]
	public class UIJoystickController : IHotfixable
	{
		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0601678A RID: 92042 RVA: 0x00091560 File Offset: 0x0008F760
		[Token(Token = "0x170035DD")]
		public bool isDragging
		{
			[Token(Token = "0x601678A")]
			[Address(RVA = "0xEEE370", Offset = "0xEECF70", VA = "0x180EEE370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601678B RID: 92043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601678B")]
		[Address(RVA = "0xEEE310", Offset = "0xEECF10", VA = "0x180EEE310")]
		private UIJoystickController()
		{
		}

		// Token: 0x0601678C RID: 92044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601678C")]
		[Address(RVA = "0xEEE290", Offset = "0xEECE90", VA = "0x180EEE290")]
		public UIJoystickController(Component host)
		{
		}

		// Token: 0x0601678D RID: 92045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601678D")]
		[Address(RVA = "0xEED640", Offset = "0xEEC240", VA = "0x180EED640")]
		public void Start(string joystickName, [Optional] Action onDragStop)
		{
		}

		// Token: 0x0601678E RID: 92046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601678E")]
		[Address(RVA = "0xEED5A0", Offset = "0xEEC1A0", VA = "0x180EED5A0")]
		public void StartDrag(PointerEventData eventData)
		{
		}

		// Token: 0x0601678F RID: 92047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601678F")]
		[Address(RVA = "0xEED4A0", Offset = "0xEEC0A0", VA = "0x180EED4A0")]
		public void SetJoystickActive(bool isActived)
		{
		}

		// Token: 0x06016790 RID: 92048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016790")]
		[Address(RVA = "0xEED890", Offset = "0xEEC490", VA = "0x180EED890")]
		public void Tick()
		{
		}

		// Token: 0x06016791 RID: 92049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016791")]
		[Address(RVA = "0xEEDAB0", Offset = "0xEEC6B0", VA = "0x180EEDAB0")]
		private Func<float, bool> _CreateYieldWaitForValid(string joystickName)
		{
			return null;
		}

		// Token: 0x06016792 RID: 92050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016792")]
		[Address(RVA = "0xEEDBA0", Offset = "0xEEC7A0", VA = "0x180EEDBA0")]
		private ETCJoystick _GetValidJoystick(bool isRunning = true)
		{
			return null;
		}

		// Token: 0x06016793 RID: 92051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016793")]
		[Address(RVA = "0xEEE060", Offset = "0xEECC60", VA = "0x180EEE060")]
		private void _TickForPendingPointDown()
		{
		}

		// Token: 0x06016794 RID: 92052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016794")]
		[Address(RVA = "0xEED980", Offset = "0xEEC580", VA = "0x180EED980")]
		private void _BeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06016795 RID: 92053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016795")]
		[Address(RVA = "0xEEE100", Offset = "0xEECD00", VA = "0x180EEE100")]
		private void _TriggerJoystickOnDrag()
		{
		}

		// Token: 0x06016796 RID: 92054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016796")]
		[Address(RVA = "0xEEE1C0", Offset = "0xEECDC0", VA = "0x180EEE1C0")]
		private void _TriggerJoystickPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x06016797 RID: 92055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016797")]
		[Address(RVA = "0xEEDD90", Offset = "0xEEC990", VA = "0x180EEDD90")]
		private void _TickDrag()
		{
		}

		// Token: 0x06016798 RID: 92056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016798")]
		[Address(RVA = "0xEEDC50", Offset = "0xEEC850", VA = "0x180EEDC50")]
		private void _StopDrag()
		{
		}

		// Token: 0x06016799 RID: 92057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016799")]
		[Address(RVA = "0xEED1D0", Offset = "0xEEBDD0", VA = "0x180EED1D0")]
		public void OnMove(Vector2 move)
		{
		}

		// Token: 0x0601679A RID: 92058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601679A")]
		[Address(RVA = "0xEED350", Offset = "0xEEBF50", VA = "0x180EED350")]
		public void OnStop()
		{
		}

		// Token: 0x0601679B RID: 92059 RVA: 0x00091578 File Offset: 0x0008F778
		[Token(Token = "0x601679B")]
		[Address(RVA = "0xEED160", Offset = "0xEEBD60", VA = "0x180EED160")]
		public int GetInstId()
		{
			return 0;
		}

		// Token: 0x0401B10A RID: 110858
		[Token(Token = "0x401B10A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Component m_host;

		// Token: 0x0401B10B RID: 110859
		[Token(Token = "0x401B10B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_joystickName;

		// Token: 0x0401B10C RID: 110860
		[Token(Token = "0x401B10C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action m_onDragStop;

		// Token: 0x0401B10D RID: 110861
		[Token(Token = "0x401B10D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TickFunction m_tickFunction;

		// Token: 0x0401B10E RID: 110862
		[Token(Token = "0x401B10E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PointerEventData m_pendingPointerDownEventData;

		// Token: 0x0401B10F RID: 110863
		[Token(Token = "0x401B10F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PointerEventData m_dragPointerDownEventData;

		// Token: 0x0401B110 RID: 110864
		[Token(Token = "0x401B110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isDragging;

		// Token: 0x0401B111 RID: 110865
		[Token(Token = "0x401B111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401B112 RID: 110866
		[Token(Token = "0x401B112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0401B113 RID: 110867
		[Token(Token = "0x401B113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B114 RID: 110868
		[Token(Token = "0x401B114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartDrag;

		// Token: 0x0401B115 RID: 110869
		[Token(Token = "0x401B115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetJoystickActive;

		// Token: 0x0401B116 RID: 110870
		[Token(Token = "0x401B116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0401B117 RID: 110871
		[Token(Token = "0x401B117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateYieldWaitForValid;

		// Token: 0x0401B118 RID: 110872
		[Token(Token = "0x401B118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetValidJoystick;

		// Token: 0x0401B119 RID: 110873
		[Token(Token = "0x401B119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TickForPendingPointDown;

		// Token: 0x0401B11A RID: 110874
		[Token(Token = "0x401B11A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__BeginDrag;

		// Token: 0x0401B11B RID: 110875
		[Token(Token = "0x401B11B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TriggerJoystickOnDrag;

		// Token: 0x0401B11C RID: 110876
		[Token(Token = "0x401B11C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TriggerJoystickPointerUp;

		// Token: 0x0401B11D RID: 110877
		[Token(Token = "0x401B11D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TickDrag;

		// Token: 0x0401B11E RID: 110878
		[Token(Token = "0x401B11E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__StopDrag;

		// Token: 0x0401B11F RID: 110879
		[Token(Token = "0x401B11F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnMove;

		// Token: 0x0401B120 RID: 110880
		[Token(Token = "0x401B120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0401B121 RID: 110881
		[Token(Token = "0x401B121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetInstId;
	}
}
