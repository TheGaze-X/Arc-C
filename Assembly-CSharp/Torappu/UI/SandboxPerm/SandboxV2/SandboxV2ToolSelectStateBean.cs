using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200444F RID: 17487
	[Token(Token = "0x200444F")]
	public class SandboxV2ToolSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x0601AB95 RID: 109461 RVA: 0x000A30E0 File Offset: 0x000A12E0
		[Token(Token = "0x17003F6F")]
		public SandboxV2ToolSelectStateBean.Input input
		{
			[Token(Token = "0x601AB95")]
			[Address(RVA = "0x13E9570", Offset = "0x13E8170", VA = "0x1813E9570")]
			get
			{
				return default(SandboxV2ToolSelectStateBean.Input);
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x0601AB96 RID: 109462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F70")]
		public SandboxV2ToolSelectProp prop
		{
			[Token(Token = "0x601AB96")]
			[Address(RVA = "0x13E9600", Offset = "0x13E8200", VA = "0x1813E9600")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601AB97 RID: 109463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB97")]
		[Address(RVA = "0x13E93E0", Offset = "0x13E7FE0", VA = "0x1813E93E0")]
		public void SetInput(SandboxV2ToolSelectStateBean.Input input)
		{
		}

		// Token: 0x0601AB98 RID: 109464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB98")]
		[Address(RVA = "0x13E9180", Offset = "0x13E7D80", VA = "0x1813E9180")]
		public void ConfirmSelect()
		{
		}

		// Token: 0x0601AB99 RID: 109465 RVA: 0x000A30F8 File Offset: 0x000A12F8
		[Token(Token = "0x601AB99")]
		[Address(RVA = "0x13E91E0", Offset = "0x13E7DE0", VA = "0x1813E91E0")]
		public SandboxV2ToolSelectStateBean.Output GenOutput()
		{
			return default(SandboxV2ToolSelectStateBean.Output);
		}

		// Token: 0x0601AB9A RID: 109466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB9A")]
		[Address(RVA = "0x13E9480", Offset = "0x13E8080", VA = "0x1813E9480")]
		public SandboxV2ToolSelectStateBean()
		{
		}

		// Token: 0x0402220D RID: 139789
		[Token(Token = "0x402220D")]
		[FieldOffset(Offset = "0x10")]
		private SandboxV2ToolSelectStateBean.Input m_input;

		// Token: 0x0402220E RID: 139790
		[Token(Token = "0x402220E")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isConfirm;

		// Token: 0x0402220F RID: 139791
		[Token(Token = "0x402220F")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2ToolSelectProp m_prop;

		// Token: 0x04022210 RID: 139792
		[Token(Token = "0x4022210")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_input;

		// Token: 0x04022211 RID: 139793
		[Token(Token = "0x4022211")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04022212 RID: 139794
		[Token(Token = "0x4022212")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetInput;

		// Token: 0x04022213 RID: 139795
		[Token(Token = "0x4022213")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ConfirmSelect;

		// Token: 0x04022214 RID: 139796
		[Token(Token = "0x4022214")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenOutput;

		// Token: 0x04022215 RID: 139797
		[Token(Token = "0x4022215")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004450 RID: 17488
		[Token(Token = "0x2004450")]
		public struct Input
		{
			// Token: 0x04022216 RID: 139798
			[Token(Token = "0x4022216")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04022217 RID: 139799
			[Token(Token = "0x4022217")]
			[FieldOffset(Offset = "0x8")]
			public bool isMultipleMode;

			// Token: 0x04022218 RID: 139800
			[Token(Token = "0x4022218")]
			[FieldOffset(Offset = "0xC")]
			public int editIndex;

			// Token: 0x04022219 RID: 139801
			[Token(Token = "0x4022219")]
			[FieldOffset(Offset = "0x10")]
			public int selectMaxCnt;

			// Token: 0x0402221A RID: 139802
			[Token(Token = "0x402221A")]
			[FieldOffset(Offset = "0x18")]
			public List<string> selectToolList;

			// Token: 0x0402221B RID: 139803
			[Token(Token = "0x402221B")]
			[FieldOffset(Offset = "0x20")]
			public List<string> blackToolList;

			// Token: 0x0402221C RID: 139804
			[Token(Token = "0x402221C")]
			[FieldOffset(Offset = "0x28")]
			public bool scrollToTail;
		}

		// Token: 0x02004451 RID: 17489
		[Token(Token = "0x2004451")]
		public struct Output
		{
			// Token: 0x0402221D RID: 139805
			[Token(Token = "0x402221D")]
			[FieldOffset(Offset = "0x0")]
			public bool isEnsure;

			// Token: 0x0402221E RID: 139806
			[Token(Token = "0x402221E")]
			[FieldOffset(Offset = "0x8")]
			public List<string> selectToolList;
		}
	}
}
