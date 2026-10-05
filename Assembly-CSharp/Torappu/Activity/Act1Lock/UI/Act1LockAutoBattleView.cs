using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200789E RID: 30878
	[Token(Token = "0x200789E")]
	public class Act1LockAutoBattleView : DataBinder<Act1LockDetailAutoBattleProperty>
	{
		// Token: 0x0602B49E RID: 177310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B49E")]
		[Address(RVA = "0x2707E10", Offset = "0x2706A10", VA = "0x182707E10")]
		public void OnAutoBattleLocked()
		{
		}

		// Token: 0x0602B49F RID: 177311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B49F")]
		[Address(RVA = "0x2707EA0", Offset = "0x2706AA0", VA = "0x182707EA0", Slot = "7")]
		public override void OnValueChanged(Act1LockDetailAutoBattleProperty property)
		{
		}

		// Token: 0x0602B4A0 RID: 177312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4A0")]
		[Address(RVA = "0x2708090", Offset = "0x2706C90", VA = "0x182708090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B4A1 RID: 177313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B4A1")]
		[Address(RVA = "0x2708100", Offset = "0x2706D00", VA = "0x182708100")]
		public Act1LockAutoBattleView()
		{
		}

		// Token: 0x0403E909 RID: 256265
		[Token(Token = "0x403E909")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _autoBattleLocked;

		// Token: 0x0403E90A RID: 256266
		[Token(Token = "0x403E90A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _tglAutoBattle;

		// Token: 0x0403E90B RID: 256267
		[Token(Token = "0x403E90B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _tglPractice;

		// Token: 0x0403E90C RID: 256268
		[Token(Token = "0x403E90C")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403E90D RID: 256269
		[Token(Token = "0x403E90D")]
		[FieldOffset(Offset = "0x39")]
		private bool m_isAutoBattleUnlocked;

		// Token: 0x0403E90E RID: 256270
		[Token(Token = "0x403E90E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAutoBattleLocked;

		// Token: 0x0403E90F RID: 256271
		[Token(Token = "0x403E90F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E910 RID: 256272
		[Token(Token = "0x403E910")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E911 RID: 256273
		[Token(Token = "0x403E911")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
