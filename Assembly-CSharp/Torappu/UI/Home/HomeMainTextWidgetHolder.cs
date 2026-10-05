using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C49 RID: 19529
	[Token(Token = "0x2004C49")]
	public class HomeMainTextWidgetHolder : HomeMainWidgetHolderBase<HomeMainTextWidget>
	{
		// Token: 0x170044DE RID: 17630
		// (get) Token: 0x0601D506 RID: 120070 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D507 RID: 120071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170044DE")]
		public string text
		{
			[Token(Token = "0x601D506")]
			[Address(RVA = "0x16E1D50", Offset = "0x16E0950", VA = "0x1816E1D50")]
			get
			{
				return null;
			}
			[Token(Token = "0x601D507")]
			[Address(RVA = "0x16E1DB0", Offset = "0x16E09B0", VA = "0x1816E1DB0")]
			set
			{
			}
		}

		// Token: 0x0601D508 RID: 120072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D508")]
		[Address(RVA = "0x16E1C30", Offset = "0x16E0830", VA = "0x1816E1C30", Slot = "5")]
		protected override void OnWidgetChanged(HomeMainTextWidget newWidget)
		{
		}

		// Token: 0x0601D509 RID: 120073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D509")]
		[Address(RVA = "0x16E1CE0", Offset = "0x16E08E0", VA = "0x1816E1CE0")]
		public HomeMainTextWidgetHolder()
		{
		}

		// Token: 0x04026919 RID: 157977
		[Token(Token = "0x4026919")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedText;

		// Token: 0x0402691A RID: 157978
		[Token(Token = "0x402691A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_text;

		// Token: 0x0402691B RID: 157979
		[Token(Token = "0x402691B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_text;

		// Token: 0x0402691C RID: 157980
		[Token(Token = "0x402691C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnWidgetChanged;

		// Token: 0x0402691D RID: 157981
		[Token(Token = "0x402691D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
