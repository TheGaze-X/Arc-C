using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003920 RID: 14624
	[Token(Token = "0x2003920")]
	public class UILongPressButtonEx : Selectable, IHotfixable
	{
		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x060171D3 RID: 94675 RVA: 0x00094E18 File Offset: 0x00093018
		// (set) Token: 0x060171D4 RID: 94676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003733")]
		public new bool interactable
		{
			[Token(Token = "0x60171D3")]
			[Address(RVA = "0xF96C90", Offset = "0xF95890", VA = "0x180F96C90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60171D4")]
			[Address(RVA = "0xF96DB0", Offset = "0xF959B0", VA = "0x180F96DB0")]
			set
			{
			}
		}

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x060171D5 RID: 94677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060171D6 RID: 94678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003734")]
		public Action onClick
		{
			[Token(Token = "0x60171D5")]
			[Address(RVA = "0xF96CF0", Offset = "0xF958F0", VA = "0x180F96CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60171D6")]
			[Address(RVA = "0xF96F70", Offset = "0xF95B70", VA = "0x180F96F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x060171D7 RID: 94679 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060171D8 RID: 94680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003735")]
		public Func<bool> onLongPress
		{
			[Token(Token = "0x60171D7")]
			[Address(RVA = "0xF96D50", Offset = "0xF95950", VA = "0x180F96D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60171D8")]
			[Address(RVA = "0xF96FF0", Offset = "0xF95BF0", VA = "0x180F96FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060171D9 RID: 94681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171D9")]
		[Address(RVA = "0xF96200", Offset = "0xF94E00", VA = "0x180F96200", Slot = "34")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x060171DA RID: 94682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171DA")]
		[Address(RVA = "0xF96310", Offset = "0xF94F10", VA = "0x180F96310", Slot = "37")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060171DB RID: 94683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171DB")]
		[Address(RVA = "0xF964C0", Offset = "0xF950C0", VA = "0x180F964C0", Slot = "35")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		// Token: 0x060171DC RID: 94684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171DC")]
		[Address(RVA = "0xF966D0", Offset = "0xF952D0", VA = "0x180F966D0")]
		private void Update()
		{
		}

		// Token: 0x060171DD RID: 94685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171DD")]
		[Address(RVA = "0xF960C0", Offset = "0xF94CC0", VA = "0x180F960C0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060171DE RID: 94686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171DE")]
		[Address(RVA = "0xF968B0", Offset = "0xF954B0", VA = "0x180F968B0")]
		private void _FinishPointDown()
		{
		}

		// Token: 0x060171DF RID: 94687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171DF")]
		[Address(RVA = "0xF96990", Offset = "0xF95590", VA = "0x180F96990")]
		private void _UpdateLongPress()
		{
		}

		// Token: 0x060171E0 RID: 94688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171E0")]
		[Address(RVA = "0xF96BA0", Offset = "0xF957A0", VA = "0x180F96BA0")]
		public UILongPressButtonEx()
		{
		}

		// Token: 0x060171E1 RID: 94689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171E1")]
		[Address(RVA = "0xF966A0", Offset = "0xF952A0", VA = "0x180F966A0")]
		private void <>xLuaBaseProxy_OnPointerDown(PointerEventData P0)
		{
		}

		// Token: 0x060171E2 RID: 94690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171E2")]
		[Address(RVA = "0xF966B0", Offset = "0xF952B0", VA = "0x180F966B0")]
		private void <>xLuaBaseProxy_OnPointerExit(PointerEventData P0)
		{
		}

		// Token: 0x060171E3 RID: 94691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171E3")]
		[Address(RVA = "0xF966C0", Offset = "0xF952C0", VA = "0x180F966C0")]
		private void <>xLuaBaseProxy_OnPointerUp(PointerEventData P0)
		{
		}

		// Token: 0x060171E4 RID: 94692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171E4")]
		[Address(RVA = "0xF96690", Offset = "0xF95290", VA = "0x180F96690")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x0401BE70 RID: 114288
		[Token(Token = "0x401BE70")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Tooltip("Millsecs")]
		private int _longPressThreshold;

		// Token: 0x0401BE71 RID: 114289
		[Token(Token = "0x401BE71")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[Tooltip("Millsecs")]
		private int _longPressInterval;

		// Token: 0x0401BE72 RID: 114290
		[Token(Token = "0x401BE72")]
		[FieldOffset(Offset = "0x100")]
		private bool m_isPressing;

		// Token: 0x0401BE73 RID: 114291
		[Token(Token = "0x401BE73")]
		[FieldOffset(Offset = "0x108")]
		private DateTime m_pressStartTime;

		// Token: 0x0401BE74 RID: 114292
		[Token(Token = "0x401BE74")]
		[FieldOffset(Offset = "0x110")]
		private DateTime m_lastLongPressUpdateTime;

		// Token: 0x0401BE75 RID: 114293
		[Token(Token = "0x401BE75")]
		[FieldOffset(Offset = "0x118")]
		private UILongPressButtonEx.State m_state;

		// Token: 0x0401BE78 RID: 114296
		[Token(Token = "0x401BE78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0401BE79 RID: 114297
		[Token(Token = "0x401BE79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_interactable;

		// Token: 0x0401BE7A RID: 114298
		[Token(Token = "0x401BE7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onClick;

		// Token: 0x0401BE7B RID: 114299
		[Token(Token = "0x401BE7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0401BE7C RID: 114300
		[Token(Token = "0x401BE7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onLongPress;

		// Token: 0x0401BE7D RID: 114301
		[Token(Token = "0x401BE7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onLongPress;

		// Token: 0x0401BE7E RID: 114302
		[Token(Token = "0x401BE7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0401BE7F RID: 114303
		[Token(Token = "0x401BE7F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPointerExit;

		// Token: 0x0401BE80 RID: 114304
		[Token(Token = "0x401BE80")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPointerUp;

		// Token: 0x0401BE81 RID: 114305
		[Token(Token = "0x401BE81")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401BE82 RID: 114306
		[Token(Token = "0x401BE82")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401BE83 RID: 114307
		[Token(Token = "0x401BE83")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__FinishPointDown;

		// Token: 0x0401BE84 RID: 114308
		[Token(Token = "0x401BE84")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateLongPress;

		// Token: 0x0401BE85 RID: 114309
		[Token(Token = "0x401BE85")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003921 RID: 14625
		[Token(Token = "0x2003921")]
		private enum State
		{
			// Token: 0x0401BE87 RID: 114311
			[Token(Token = "0x401BE87")]
			NONE,
			// Token: 0x0401BE88 RID: 114312
			[Token(Token = "0x401BE88")]
			CLICK,
			// Token: 0x0401BE89 RID: 114313
			[Token(Token = "0x401BE89")]
			LONG_PRESS,
			// Token: 0x0401BE8A RID: 114314
			[Token(Token = "0x401BE8A")]
			CANCEL
		}
	}
}
