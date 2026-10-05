using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004997 RID: 18839
	[Token(Token = "0x2004997")]
	public class MedalHideExpireSwitch : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x0601C62A RID: 116266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601C62B RID: 116267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700432E")]
		public Action onToggleClicked
		{
			[Token(Token = "0x601C62A")]
			[Address(RVA = "0x15EB480", Offset = "0x15EA080", VA = "0x1815EB480")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601C62B")]
			[Address(RVA = "0x15EB4E0", Offset = "0x15EA0E0", VA = "0x1815EB4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601C62C RID: 116268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C62C")]
		[Address(RVA = "0x15EB330", Offset = "0x15E9F30", VA = "0x1815EB330")]
		public void Render(MedalListViewModel viewModel)
		{
		}

		// Token: 0x0601C62D RID: 116269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C62D")]
		[Address(RVA = "0x15EB220", Offset = "0x15E9E20", VA = "0x1815EB220")]
		public void EventOnToggleClicked()
		{
		}

		// Token: 0x0601C62E RID: 116270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C62E")]
		[Address(RVA = "0x15EB420", Offset = "0x15EA020", VA = "0x1815EB420")]
		public MedalHideExpireSwitch()
		{
		}

		// Token: 0x040252D7 RID: 152279
		[Token(Token = "0x40252D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x040252D9 RID: 152281
		[Token(Token = "0x40252D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onToggleClicked;

		// Token: 0x040252DA RID: 152282
		[Token(Token = "0x40252DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onToggleClicked;

		// Token: 0x040252DB RID: 152283
		[Token(Token = "0x40252DB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040252DC RID: 152284
		[Token(Token = "0x40252DC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnToggleClicked;

		// Token: 0x040252DD RID: 152285
		[Token(Token = "0x40252DD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
