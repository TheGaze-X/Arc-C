using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DA8 RID: 15784
	[Token(Token = "0x2003DA8")]
	public class TemplateMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003A8A RID: 14986
		// (get) Token: 0x060188B3 RID: 100531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A8A")]
		public TemplateMissionProperty property
		{
			[Token(Token = "0x60188B3")]
			[Address(RVA = "0x11151B0", Offset = "0x1113DB0", VA = "0x1811151B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003A8B RID: 14987
		// (get) Token: 0x060188B4 RID: 100532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A8B")]
		public TemplateMissionInputParam inputParam
		{
			[Token(Token = "0x60188B4")]
			[Address(RVA = "0x1115150", Offset = "0x1113D50", VA = "0x181115150")]
			get
			{
				return null;
			}
		}

		// Token: 0x060188B5 RID: 100533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188B5")]
		[Address(RVA = "0x1114FE0", Offset = "0x1113BE0", VA = "0x181114FE0")]
		public void SetInputData(TemplateMissionInputParam param)
		{
		}

		// Token: 0x060188B6 RID: 100534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188B6")]
		[Address(RVA = "0x1115060", Offset = "0x1113C60", VA = "0x181115060")]
		public TemplateMissionStateBean()
		{
		}

		// Token: 0x0401E16F RID: 123247
		[Token(Token = "0x401E16F")]
		[FieldOffset(Offset = "0x10")]
		private TemplateMissionProperty m_property;

		// Token: 0x0401E170 RID: 123248
		[Token(Token = "0x401E170")]
		[FieldOffset(Offset = "0x18")]
		private TemplateMissionInputParam m_param;

		// Token: 0x0401E171 RID: 123249
		[Token(Token = "0x401E171")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x0401E172 RID: 123250
		[Token(Token = "0x401E172")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inputParam;

		// Token: 0x0401E173 RID: 123251
		[Token(Token = "0x401E173")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetInputData;

		// Token: 0x0401E174 RID: 123252
		[Token(Token = "0x401E174")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
