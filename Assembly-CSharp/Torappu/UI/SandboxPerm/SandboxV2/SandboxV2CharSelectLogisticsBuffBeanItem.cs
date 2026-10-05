using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004021 RID: 16417
	[Token(Token = "0x2004021")]
	public class SandboxV2CharSelectLogisticsBuffBeanItem : SandboxV2LogisticsAbstractBeanItem
	{
		// Token: 0x0601969F RID: 104095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601969F")]
		[Address(RVA = "0x121D950", Offset = "0x121C550", VA = "0x18121D950", Slot = "4")]
		public override void Render(bool enabledItem)
		{
		}

		// Token: 0x060196A0 RID: 104096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196A0")]
		[Address(RVA = "0x121DAC0", Offset = "0x121C6C0", VA = "0x18121DAC0")]
		public SandboxV2CharSelectLogisticsBuffBeanItem()
		{
		}

		// Token: 0x0401F9EB RID: 129515
		[Token(Token = "0x401F9EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _showAnimationLocation;

		// Token: 0x0401F9EC RID: 129516
		[Token(Token = "0x401F9EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _hideAnimationLocation;

		// Token: 0x0401F9ED RID: 129517
		[Token(Token = "0x401F9ED")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401F9EE RID: 129518
		[Token(Token = "0x401F9EE")]
		[FieldOffset(Offset = "0x39")]
		private bool m_cachedEnabledItem;

		// Token: 0x0401F9EF RID: 129519
		[Token(Token = "0x401F9EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F9F0 RID: 129520
		[Token(Token = "0x401F9F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
