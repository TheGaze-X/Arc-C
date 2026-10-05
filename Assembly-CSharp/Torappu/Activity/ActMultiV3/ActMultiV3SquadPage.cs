using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FDA RID: 28634
	[Token(Token = "0x2006FDA")]
	public class ActMultiV3SquadPage : StateEnginePage
	{
		// Token: 0x17006004 RID: 24580
		// (get) Token: 0x06028ABC RID: 166588 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028ABD RID: 166589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006004")]
		public string actId
		{
			[Token(Token = "0x6028ABC")]
			[Address(RVA = "0x23FC5E0", Offset = "0x23FB1E0", VA = "0x1823FC5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028ABD")]
			[Address(RVA = "0x23FC640", Offset = "0x23FB240", VA = "0x1823FC640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028ABE RID: 166590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ABE")]
		[Address(RVA = "0x23FC490", Offset = "0x23FB090", VA = "0x1823FC490", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06028ABF RID: 166591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028ABF")]
		[Address(RVA = "0x23FC580", Offset = "0x23FB180", VA = "0x1823FC580")]
		public ActMultiV3SquadPage()
		{
		}

		// Token: 0x06028AC0 RID: 166592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AC0")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04039F1D RID: 237341
		[Token(Token = "0x4039F1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04039F1E RID: 237342
		[Token(Token = "0x4039F1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x04039F1F RID: 237343
		[Token(Token = "0x4039F1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04039F20 RID: 237344
		[Token(Token = "0x4039F20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FDB RID: 28635
		[Token(Token = "0x2006FDB")]
		public class Params
		{
			// Token: 0x06028AC1 RID: 166593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028AC1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04039F21 RID: 237345
			[Token(Token = "0x4039F21")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
