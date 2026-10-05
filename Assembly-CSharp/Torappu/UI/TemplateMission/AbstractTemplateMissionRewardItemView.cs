using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D7C RID: 15740
	[Token(Token = "0x2003D7C")]
	public abstract class AbstractTemplateMissionRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x060187D9 RID: 100313 RVA: 0x0009A998 File Offset: 0x00098B98
		// (set) Token: 0x060187DA RID: 100314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A75")]
		public float scaler
		{
			[Token(Token = "0x60187D9")]
			[Address(RVA = "0x1101340", Offset = "0x10FFF40", VA = "0x181101340")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60187DA")]
			[Address(RVA = "0x11013A0", Offset = "0x10FFFA0", VA = "0x1811013A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060187DB RID: 100315
		[Token(Token = "0x60187DB")]
		public abstract void Render(AbstractTemplateMissionRewardItemViewModel viewModel);

		// Token: 0x060187DC RID: 100316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187DC")]
		[Address(RVA = "0x11012E0", Offset = "0x10FFEE0", VA = "0x1811012E0")]
		protected AbstractTemplateMissionRewardItemView()
		{
		}

		// Token: 0x0401E029 RID: 122921
		[Token(Token = "0x401E029")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_scaler;

		// Token: 0x0401E02A RID: 122922
		[Token(Token = "0x401E02A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_scaler;

		// Token: 0x0401E02B RID: 122923
		[Token(Token = "0x401E02B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
