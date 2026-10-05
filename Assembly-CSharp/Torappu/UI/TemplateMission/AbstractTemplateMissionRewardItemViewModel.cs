using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DB0 RID: 15792
	[Token(Token = "0x2003DB0")]
	public abstract class AbstractTemplateMissionRewardItemViewModel : IHotfixable
	{
		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x060188E4 RID: 100580 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060188E5 RID: 100581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003A9C")]
		public ItemBundle commonItemBundle
		{
			[Token(Token = "0x60188E4")]
			[Address(RVA = "0x1101200", Offset = "0x10FFE00", VA = "0x181101200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60188E5")]
			[Address(RVA = "0x1101260", Offset = "0x10FFE60", VA = "0x181101260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060188E6 RID: 100582
		[Token(Token = "0x60188E6")]
		public abstract void Init(string keyId, string itemId, int count, ItemType itemType);

		// Token: 0x060188E7 RID: 100583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188E7")]
		[Address(RVA = "0x11011A0", Offset = "0x10FFDA0", VA = "0x1811011A0")]
		protected AbstractTemplateMissionRewardItemViewModel()
		{
		}

		// Token: 0x0401E1BE RID: 123326
		[Token(Token = "0x401E1BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_commonItemBundle;

		// Token: 0x0401E1BF RID: 123327
		[Token(Token = "0x401E1BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_commonItemBundle;

		// Token: 0x0401E1C0 RID: 123328
		[Token(Token = "0x401E1C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
