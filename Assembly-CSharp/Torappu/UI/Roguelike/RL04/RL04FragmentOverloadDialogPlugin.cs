using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x020056B4 RID: 22196
	[Token(Token = "0x20056B4")]
	public class RL04FragmentOverloadDialogPlugin : RoguelikeFragmentOverloadDialog.Plugin, IHotfixable
	{
		// Token: 0x060208ED RID: 133357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208ED")]
		[Address(RVA = "0x1AB1C40", Offset = "0x1AB0840", VA = "0x181AB1C40", Slot = "4")]
		public override void OnRender(RoguelikeFragmentOverloadDialog.Options options)
		{
		}

		// Token: 0x060208EE RID: 133358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60208EE")]
		[Address(RVA = "0x1AB1D40", Offset = "0x1AB0940", VA = "0x181AB1D40")]
		private string _GetHeavyDebuffDesc()
		{
			return null;
		}

		// Token: 0x060208EF RID: 133359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60208EF")]
		[Address(RVA = "0x1AB1F10", Offset = "0x1AB0B10", VA = "0x181AB1F10")]
		public RL04FragmentOverloadDialogPlugin()
		{
		}

		// Token: 0x0402C1B7 RID: 180663
		[Token(Token = "0x402C1B7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textHeavy;

		// Token: 0x0402C1B8 RID: 180664
		[Token(Token = "0x402C1B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402C1B9 RID: 180665
		[Token(Token = "0x402C1B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetHeavyDebuffDesc;

		// Token: 0x0402C1BA RID: 180666
		[Token(Token = "0x402C1BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
