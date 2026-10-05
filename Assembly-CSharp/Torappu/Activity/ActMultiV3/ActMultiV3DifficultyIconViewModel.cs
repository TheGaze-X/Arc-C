using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EF9 RID: 28409
	[Token(Token = "0x2006EF9")]
	public class ActMultiV3DifficultyIconViewModel : IHotfixable
	{
		// Token: 0x17005F48 RID: 24392
		// (get) Token: 0x060285CD RID: 165325 RVA: 0x000D1A78 File Offset: 0x000CFC78
		// (set) Token: 0x060285CE RID: 165326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F48")]
		public ActMultiV3MapDiffType diffType
		{
			[Token(Token = "0x60285CD")]
			[Address(RVA = "0x23AAAE0", Offset = "0x23A96E0", VA = "0x1823AAAE0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MapDiffType.NONE;
			}
			[Token(Token = "0x60285CE")]
			[Address(RVA = "0x23AABC0", Offset = "0x23A97C0", VA = "0x1823AABC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005F49 RID: 24393
		// (get) Token: 0x060285CF RID: 165327 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060285D0 RID: 165328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005F49")]
		public string diffName
		{
			[Token(Token = "0x60285CF")]
			[Address(RVA = "0x23AAA80", Offset = "0x23A9680", VA = "0x1823AAA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60285D0")]
			[Address(RVA = "0x23AAB40", Offset = "0x23A9740", VA = "0x1823AAB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060285D1 RID: 165329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285D1")]
		[Address(RVA = "0x23AA880", Offset = "0x23A9480", VA = "0x1823AA880")]
		public void Load(string actId, ActMultiV3MapDiffType difficultyType)
		{
		}

		// Token: 0x060285D2 RID: 165330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285D2")]
		[Address(RVA = "0x23AAA20", Offset = "0x23A9620", VA = "0x1823AAA20")]
		public ActMultiV3DifficultyIconViewModel()
		{
		}

		// Token: 0x04039624 RID: 235044
		[Token(Token = "0x4039624")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diffType;

		// Token: 0x04039625 RID: 235045
		[Token(Token = "0x4039625")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_diffType;

		// Token: 0x04039626 RID: 235046
		[Token(Token = "0x4039626")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_diffName;

		// Token: 0x04039627 RID: 235047
		[Token(Token = "0x4039627")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_diffName;

		// Token: 0x04039628 RID: 235048
		[Token(Token = "0x4039628")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Load;

		// Token: 0x04039629 RID: 235049
		[Token(Token = "0x4039629")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
