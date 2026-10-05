using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200245F RID: 9311
	[Token(Token = "0x200245F")]
	public class ToggleSkill : BasicSkill
	{
		// Token: 0x0600EF7D RID: 61309 RVA: 0x000582C0 File Offset: 0x000564C0
		[Token(Token = "0x600EF7D")]
		[Address(RVA = "0x67E6A0", Offset = "0x67D2A0", VA = "0x18067E6A0", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x0600EF7E RID: 61310 RVA: 0x000582D8 File Offset: 0x000564D8
		[Token(Token = "0x17001F12")]
		public bool toggled
		{
			[Token(Token = "0x600EF7E")]
			[Address(RVA = "0x67ED10", Offset = "0x67D910", VA = "0x18067ED10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EF7F RID: 61311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF7F")]
		[Address(RVA = "0x67E750", Offset = "0x67D350", VA = "0x18067E750", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EF80 RID: 61312 RVA: 0x000582F0 File Offset: 0x000564F0
		[Token(Token = "0x600EF80")]
		[Address(RVA = "0x67E350", Offset = "0x67CF50", VA = "0x18067E350", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF81 RID: 61313 RVA: 0x00058308 File Offset: 0x00056508
		[Token(Token = "0x600EF81")]
		[Address(RVA = "0x67E9B0", Offset = "0x67D5B0", VA = "0x18067E9B0", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EF82 RID: 61314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF82")]
		[Address(RVA = "0x67E8A0", Offset = "0x67D4A0", VA = "0x18067E8A0", Slot = "74")]
		protected override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600EF83 RID: 61315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF83")]
		[Address(RVA = "0x67EB60", Offset = "0x67D760", VA = "0x18067EB60")]
		private void _SetToggledInternal(bool value, bool force)
		{
		}

		// Token: 0x0600EF84 RID: 61316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF84")]
		[Address(RVA = "0x67EA60", Offset = "0x67D660", VA = "0x18067EA60")]
		private void _DoSwitchMode()
		{
		}

		// Token: 0x0600EF85 RID: 61317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF85")]
		[Address(RVA = "0x67ECA0", Offset = "0x67D8A0", VA = "0x18067ECA0")]
		public ToggleSkill()
		{
		}

		// Token: 0x0600EF86 RID: 61318 RVA: 0x00058320 File Offset: 0x00056520
		[Token(Token = "0x600EF86")]
		[Address(RVA = "0x634DF0", Offset = "0x6339F0", VA = "0x180634DF0")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EF87 RID: 61319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF87")]
		[Address(RVA = "0x634E10", Offset = "0x633A10", VA = "0x180634E10")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EF88 RID: 61320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF88")]
		[Address(RVA = "0x635F00", Offset = "0x634B00", VA = "0x180635F00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040108D2 RID: 67794
		[Token(Token = "0x40108D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private int _switchToMode;

		// Token: 0x040108D3 RID: 67795
		[Token(Token = "0x40108D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private bool _switchToModeDown;

		// Token: 0x040108D4 RID: 67796
		[Token(Token = "0x40108D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int _downMode;

		// Token: 0x040108D5 RID: 67797
		[Token(Token = "0x40108D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool _switchToState;

		// Token: 0x040108D6 RID: 67798
		[Token(Token = "0x40108D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		[SerializeField]
		private bool _restartFSM;

		// Token: 0x040108D7 RID: 67799
		[Token(Token = "0x40108D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		[SerializeField]
		private bool _skipAudioWhenToggleInternal;

		// Token: 0x040108D8 RID: 67800
		[Token(Token = "0x40108D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x127")]
		[SerializeField]
		private bool _useAbilityHandleToggle;

		// Token: 0x040108D9 RID: 67801
		[Token(Token = "0x40108D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool m_toggled;

		// Token: 0x040108DA RID: 67802
		[Token(Token = "0x40108DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int m_defaultModeIndex;

		// Token: 0x040108DB RID: 67803
		[Token(Token = "0x40108DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x040108DC RID: 67804
		[Token(Token = "0x40108DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_toggled;

		// Token: 0x040108DD RID: 67805
		[Token(Token = "0x40108DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040108DE RID: 67806
		[Token(Token = "0x40108DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x040108DF RID: 67807
		[Token(Token = "0x40108DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x040108E0 RID: 67808
		[Token(Token = "0x40108E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040108E1 RID: 67809
		[Token(Token = "0x40108E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetToggledInternal;

		// Token: 0x040108E2 RID: 67810
		[Token(Token = "0x40108E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoSwitchMode;

		// Token: 0x040108E3 RID: 67811
		[Token(Token = "0x40108E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
