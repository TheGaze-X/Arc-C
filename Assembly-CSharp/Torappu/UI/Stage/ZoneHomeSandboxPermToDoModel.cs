using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067F0 RID: 26608
	[Token(Token = "0x20067F0")]
	public class ZoneHomeSandboxPermToDoModel : ZoneHomeToDoItemModel, IHotfixable
	{
		// Token: 0x17005A26 RID: 23078
		// (get) Token: 0x06026226 RID: 156198 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026227 RID: 156199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A26")]
		public ZoneHomeSandboxPermToDoPluginBaseModel permModel
		{
			[Token(Token = "0x6026226")]
			[Address(RVA = "0x2145CD0", Offset = "0x21448D0", VA = "0x182145CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026227")]
			[Address(RVA = "0x2145D30", Offset = "0x2144930", VA = "0x182145D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06026228 RID: 156200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026228")]
		[Address(RVA = "0x2145720", Offset = "0x2144320", VA = "0x182145720")]
		public static ZoneHomeSandboxPermToDoModel LoadData()
		{
			return null;
		}

		// Token: 0x06026229 RID: 156201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026229")]
		[Address(RVA = "0x2145B90", Offset = "0x2144790", VA = "0x182145B90")]
		private static ZoneHomeSandboxPermToDoPluginBaseModel _CreateBaseBaseModel(SandboxPermTemplateType type, SandboxPermBasicData basicData)
		{
			return null;
		}

		// Token: 0x0602622A RID: 156202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602622A")]
		[Address(RVA = "0x2145C20", Offset = "0x2144820", VA = "0x182145C20")]
		public ZoneHomeSandboxPermToDoModel()
		{
		}

		// Token: 0x04035B5B RID: 219995
		[Token(Token = "0x4035B5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_permModel;

		// Token: 0x04035B5C RID: 219996
		[Token(Token = "0x4035B5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_permModel;

		// Token: 0x04035B5D RID: 219997
		[Token(Token = "0x4035B5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035B5E RID: 219998
		[Token(Token = "0x4035B5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateBaseBaseModel;

		// Token: 0x04035B5F RID: 219999
		[Token(Token = "0x4035B5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
