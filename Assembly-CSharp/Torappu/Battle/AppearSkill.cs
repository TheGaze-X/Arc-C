using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002445 RID: 9285
	[Token(Token = "0x2002445")]
	public class AppearSkill : BasicSkill, IEffectSource
	{
		// Token: 0x0600ED68 RID: 60776 RVA: 0x00056C40 File Offset: 0x00054E40
		[Token(Token = "0x600ED68")]
		[Address(RVA = "0x634AC0", Offset = "0x6336C0", VA = "0x180634AC0", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x0600ED69 RID: 60777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001E8B")]
		public string overrideStartEffect
		{
			[Token(Token = "0x600ED69")]
			[Address(RVA = "0x635050", Offset = "0x633C50", VA = "0x180635050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E8C RID: 7820
		// (get) Token: 0x0600ED6A RID: 60778 RVA: 0x00056C58 File Offset: 0x00054E58
		[Token(Token = "0x17001E8C")]
		public override bool overrideAudioSignalId
		{
			[Token(Token = "0x600ED6A")]
			[Address(RVA = "0x634FF0", Offset = "0x633BF0", VA = "0x180634FF0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ED6B RID: 60779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6B")]
		[Address(RVA = "0x634BF0", Offset = "0x6337F0", VA = "0x180634BF0", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600ED6C RID: 60780 RVA: 0x00056C70 File Offset: 0x00054E70
		[Token(Token = "0x600ED6C")]
		[Address(RVA = "0x6348D0", Offset = "0x6334D0", VA = "0x1806348D0", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600ED6D RID: 60781 RVA: 0x00056C88 File Offset: 0x00054E88
		[Token(Token = "0x600ED6D")]
		[Address(RVA = "0x634EE0", Offset = "0x633AE0", VA = "0x180634EE0", Slot = "51")]
		public override bool UseSkill(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600ED6E RID: 60782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6E")]
		[Address(RVA = "0x634B30", Offset = "0x633730", VA = "0x180634B30", Slot = "58")]
		public override void OnBorn()
		{
		}

		// Token: 0x0600ED6F RID: 60783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED6F")]
		[Address(RVA = "0x634CF0", Offset = "0x6338F0", VA = "0x180634CF0", Slot = "59")]
		public override void OnLocate()
		{
		}

		// Token: 0x0600ED70 RID: 60784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED70")]
		[Address(RVA = "0x634A00", Offset = "0x633600", VA = "0x180634A00", Slot = "70")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600ED71 RID: 60785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED71")]
		[Address(RVA = "0x634F90", Offset = "0x633B90", VA = "0x180634F90")]
		public AppearSkill()
		{
		}

		// Token: 0x0600ED72 RID: 60786 RVA: 0x00056CA0 File Offset: 0x00054EA0
		[Token(Token = "0x600ED72")]
		[Address(RVA = "0x634DF0", Offset = "0x6339F0", VA = "0x180634DF0")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600ED73 RID: 60787 RVA: 0x00056CB8 File Offset: 0x00054EB8
		[Token(Token = "0x600ED73")]
		[Address(RVA = "0x634E80", Offset = "0x633A80", VA = "0x180634E80")]
		private bool <>xLuaBaseProxy_get_overrideAudioSignalId()
		{
			return default(bool);
		}

		// Token: 0x0600ED74 RID: 60788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED74")]
		[Address(RVA = "0x634E10", Offset = "0x633A10", VA = "0x180634E10")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600ED75 RID: 60789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED75")]
		[Address(RVA = "0x634E00", Offset = "0x633A00", VA = "0x180634E00")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600ED76 RID: 60790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED76")]
		[Address(RVA = "0x634E20", Offset = "0x633A20", VA = "0x180634E20")]
		private void <>xLuaBaseProxy_OnLocate()
		{
		}

		// Token: 0x0600ED77 RID: 60791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED77")]
		[Address(RVA = "0x634DE0", Offset = "0x6339E0", VA = "0x180634DE0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x04010689 RID: 67209
		[Token(Token = "0x4010689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _overrideStartEffect;

		// Token: 0x0401068A RID: 67210
		[Token(Token = "0x401068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private bool _switchToState;

		// Token: 0x0401068B RID: 67211
		[Token(Token = "0x401068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		[SerializeField]
		private bool _castOnLocate;

		// Token: 0x0401068C RID: 67212
		[Token(Token = "0x401068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x122")]
		[SerializeField]
		private bool _overrideAudioSignalId;

		// Token: 0x0401068D RID: 67213
		[Token(Token = "0x401068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x123")]
		private bool m_available;

		// Token: 0x0401068E RID: 67214
		[Token(Token = "0x401068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x0401068F RID: 67215
		[Token(Token = "0x401068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_overrideStartEffect;

		// Token: 0x04010690 RID: 67216
		[Token(Token = "0x4010690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_overrideAudioSignalId;

		// Token: 0x04010691 RID: 67217
		[Token(Token = "0x4010691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010692 RID: 67218
		[Token(Token = "0x4010692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x04010693 RID: 67219
		[Token(Token = "0x4010693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UseSkill;

		// Token: 0x04010694 RID: 67220
		[Token(Token = "0x4010694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04010695 RID: 67221
		[Token(Token = "0x4010695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLocate;

		// Token: 0x04010696 RID: 67222
		[Token(Token = "0x4010696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04010697 RID: 67223
		[Token(Token = "0x4010697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
