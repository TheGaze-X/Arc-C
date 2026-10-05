using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x0200469C RID: 18076
	[Token(Token = "0x200469C")]
	public class RoguelikeActivitySeedModeEntryComp : RoguelikeTopicActivityEntryComp<RoguelikeActivityEntrySeedModeEntryCompModel>
	{
		// Token: 0x0601B6D8 RID: 112344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6D8")]
		[Address(RVA = "0x14B0230", Offset = "0x14AEE30", VA = "0x1814B0230", Slot = "5")]
		protected override void _Render(RoguelikeActivityEntrySeedModeEntryCompModel actEntryCompModel)
		{
		}

		// Token: 0x0601B6D9 RID: 112345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6D9")]
		[Address(RVA = "0x14B0110", Offset = "0x14AED10", VA = "0x1814B0110")]
		private void _PlayEnableTween()
		{
		}

		// Token: 0x0601B6DA RID: 112346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6DA")]
		[Address(RVA = "0x14B04B0", Offset = "0x14AF0B0", VA = "0x1814B04B0")]
		private void _StopEnableTween()
		{
		}

		// Token: 0x0601B6DB RID: 112347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6DB")]
		[Address(RVA = "0x14AFF60", Offset = "0x14AEB60", VA = "0x1814AFF60")]
		public void OnClickOpenSeedMode()
		{
		}

		// Token: 0x0601B6DC RID: 112348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6DC")]
		[Address(RVA = "0x14B0530", Offset = "0x14AF130", VA = "0x1814B0530")]
		public RoguelikeActivitySeedModeEntryComp()
		{
		}

		// Token: 0x040237AC RID: 145324
		[Token(Token = "0x40237AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _newTrack;

		// Token: 0x040237AD RID: 145325
		[Token(Token = "0x40237AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockPanel;

		// Token: 0x040237AE RID: 145326
		[Token(Token = "0x40237AE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _disablePanel;

		// Token: 0x040237AF RID: 145327
		[Token(Token = "0x40237AF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _enablePanel;

		// Token: 0x040237B0 RID: 145328
		[Token(Token = "0x40237B0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _enableAnim;

		// Token: 0x040237B1 RID: 145329
		[Token(Token = "0x40237B1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _timeDesc;

		// Token: 0x040237B2 RID: 145330
		[Token(Token = "0x40237B2")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeActivityEntrySeedModeEntryCompModel m_cachedModel;

		// Token: 0x040237B3 RID: 145331
		[Token(Token = "0x40237B3")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_enableTween;

		// Token: 0x040237B4 RID: 145332
		[Token(Token = "0x40237B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040237B5 RID: 145333
		[Token(Token = "0x40237B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayEnableTween;

		// Token: 0x040237B6 RID: 145334
		[Token(Token = "0x40237B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StopEnableTween;

		// Token: 0x040237B7 RID: 145335
		[Token(Token = "0x40237B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickOpenSeedMode;

		// Token: 0x040237B8 RID: 145336
		[Token(Token = "0x40237B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
