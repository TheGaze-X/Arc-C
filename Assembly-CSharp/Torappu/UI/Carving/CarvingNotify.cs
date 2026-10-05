using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200609E RID: 24734
	[Token(Token = "0x200609E")]
	public class CarvingNotify : UINotifyView<CarvingNotify.Param>
	{
		// Token: 0x06023CA2 RID: 146594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CA2")]
		[Address(RVA = "0x1E7BF30", Offset = "0x1E7AB30", VA = "0x181E7BF30", Slot = "9")]
		protected override void Render(CarvingNotify.Param param)
		{
		}

		// Token: 0x06023CA3 RID: 146595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CA3")]
		[Address(RVA = "0x1E7C0F0", Offset = "0x1E7ACF0", VA = "0x181E7C0F0")]
		public CarvingNotify()
		{
		}

		// Token: 0x040319FE RID: 203262
		[Token(Token = "0x40319FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _notifyText;

		// Token: 0x040319FF RID: 203263
		[Token(Token = "0x40319FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04031A00 RID: 203264
		[Token(Token = "0x4031A00")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_tween;

		// Token: 0x04031A01 RID: 203265
		[Token(Token = "0x4031A01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031A02 RID: 203266
		[Token(Token = "0x4031A02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200609F RID: 24735
		[Token(Token = "0x200609F")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06023CA4 RID: 146596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CA4")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x04031A03 RID: 203267
			[Token(Token = "0x4031A03")]
			[FieldOffset(Offset = "0x10")]
			public string notifyTips;
		}
	}
}
