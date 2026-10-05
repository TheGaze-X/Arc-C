using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200704B RID: 28747
	[Token(Token = "0x200704B")]
	public class ActMultiV3PrepareMainLostConnectView : ActMultiV3PrepareMainFadeViewBase, IPingListener
	{
		// Token: 0x06028CF3 RID: 167155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF3")]
		[Address(RVA = "0x243A330", Offset = "0x2438F30", VA = "0x18243A330", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainViewModelProperty property)
		{
		}

		// Token: 0x06028CF4 RID: 167156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF4")]
		[Address(RVA = "0x243A390", Offset = "0x2438F90", VA = "0x18243A390", Slot = "8")]
		public void UpdatePing(int ping)
		{
		}

		// Token: 0x06028CF5 RID: 167157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF5")]
		[Address(RVA = "0x243A5B0", Offset = "0x24391B0", VA = "0x18243A5B0")]
		private void _EntryAnimDone()
		{
		}

		// Token: 0x06028CF6 RID: 167158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF6")]
		[Address(RVA = "0x243A630", Offset = "0x2439230", VA = "0x18243A630")]
		public ActMultiV3PrepareMainLostConnectView()
		{
		}

		// Token: 0x0403A32E RID: 238382
		[Token(Token = "0x403A32E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403A32F RID: 238383
		[Token(Token = "0x403A32F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _loopAnim;

		// Token: 0x0403A330 RID: 238384
		[Token(Token = "0x403A330")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_entryAnimTween;

		// Token: 0x0403A331 RID: 238385
		[Token(Token = "0x403A331")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A332 RID: 238386
		[Token(Token = "0x403A332")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdatePing;

		// Token: 0x0403A333 RID: 238387
		[Token(Token = "0x403A333")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EntryAnimDone;

		// Token: 0x0403A334 RID: 238388
		[Token(Token = "0x403A334")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
