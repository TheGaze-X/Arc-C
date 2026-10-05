using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F9F RID: 28575
	[Token(Token = "0x2006F9F")]
	public class ActMultiV3QuickMatchStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005F9D RID: 24477
		// (get) Token: 0x060288F8 RID: 166136 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060288F9 RID: 166137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F9D")]
		public TeamInst cacheTeamInst
		{
			[Token(Token = "0x60288F8")]
			[Address(RVA = "0x23E5CB0", Offset = "0x23E48B0", VA = "0x1823E5CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60288F9")]
			[Address(RVA = "0x23E5D70", Offset = "0x23E4970", VA = "0x1823E5D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005F9E RID: 24478
		// (get) Token: 0x060288FA RID: 166138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F9E")]
		public ActMultiV3QuickMatchProp prop
		{
			[Token(Token = "0x60288FA")]
			[Address(RVA = "0x23E5D10", Offset = "0x23E4910", VA = "0x1823E5D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060288FB RID: 166139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288FB")]
		[Address(RVA = "0x23E5BC0", Offset = "0x23E47C0", VA = "0x1823E5BC0")]
		public ActMultiV3QuickMatchStateBean()
		{
		}

		// Token: 0x04039C45 RID: 236613
		[Token(Token = "0x4039C45")]
		[FieldOffset(Offset = "0x18")]
		private ActMultiV3QuickMatchProp m_prop;

		// Token: 0x04039C46 RID: 236614
		[Token(Token = "0x4039C46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cacheTeamInst;

		// Token: 0x04039C47 RID: 236615
		[Token(Token = "0x4039C47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_cacheTeamInst;

		// Token: 0x04039C48 RID: 236616
		[Token(Token = "0x4039C48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04039C49 RID: 236617
		[Token(Token = "0x4039C49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
