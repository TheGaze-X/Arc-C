using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035EA RID: 13802
	[Token(Token = "0x20035EA")]
	public abstract class CommonSquadTopMenuViewBase : DataBinder<CommonSquadGroupViewProperty>
	{
		// Token: 0x06015FA4 RID: 90020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FA4")]
		[Address(RVA = "0xE7B5C0", Offset = "0xE7A1C0", VA = "0x180E7B5C0", Slot = "8")]
		public virtual void RegisterTutorialGO()
		{
		}

		// Token: 0x06015FA5 RID: 90021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015FA5")]
		[Address(RVA = "0xE7B620", Offset = "0xE7A220", VA = "0x180E7B620")]
		protected CommonSquadTopMenuViewBase()
		{
		}

		// Token: 0x0401A68F RID: 108175
		[Token(Token = "0x401A68F")]
		[FieldOffset(Offset = "0x20")]
		protected UIStateFinder stateFinder;

		// Token: 0x0401A690 RID: 108176
		[Token(Token = "0x401A690")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0401A691 RID: 108177
		[Token(Token = "0x401A691")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035EB RID: 13803
		[Token(Token = "0x20035EB")]
		public class CommonSquadTopMenuRouteToOtherOutput
		{
			// Token: 0x06015FA6 RID: 90022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015FA6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CommonSquadTopMenuRouteToOtherOutput()
			{
			}

			// Token: 0x0401A692 RID: 108178
			[Token(Token = "0x401A692")]
			[FieldOffset(Offset = "0x10")]
			public UIRouteTarget routeTarget;

			// Token: 0x0401A693 RID: 108179
			[Token(Token = "0x401A693")]
			[FieldOffset(Offset = "0x18")]
			public object param;

			// Token: 0x0401A694 RID: 108180
			[Token(Token = "0x401A694")]
			[FieldOffset(Offset = "0x20")]
			public Action<UIRouteTarget, object> baseHandler;
		}
	}
}
