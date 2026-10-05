using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004382 RID: 17282
	[Token(Token = "0x2004382")]
	public class SandboxV2RiftReservePage : StateEnginePage
	{
		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x0601A88A RID: 108682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EF5")]
		public string topicId
		{
			[Token(Token = "0x601A88A")]
			[Address(RVA = "0x13B7A90", Offset = "0x13B6690", VA = "0x1813B7A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A88B RID: 108683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A88B")]
		[Address(RVA = "0x13B7980", Offset = "0x13B6580", VA = "0x1813B7980", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601A88C RID: 108684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A88C")]
		[Address(RVA = "0x13B78D0", Offset = "0x13B64D0", VA = "0x1813B78D0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601A88D RID: 108685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A88D")]
		[Address(RVA = "0x13B7A30", Offset = "0x13B6630", VA = "0x1813B7A30")]
		public SandboxV2RiftReservePage()
		{
		}

		// Token: 0x0601A88F RID: 108687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A88F")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601A890 RID: 108688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A890")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04021C59 RID: 138329
		[Token(Token = "0x4021C59")]
		[FieldOffset(Offset = "0xF0")]
		private string m_topicId;

		// Token: 0x04021C5A RID: 138330
		[Token(Token = "0x4021C5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04021C5B RID: 138331
		[Token(Token = "0x4021C5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04021C5C RID: 138332
		[Token(Token = "0x4021C5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04021C5D RID: 138333
		[Token(Token = "0x4021C5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004383 RID: 17283
		[Token(Token = "0x2004383")]
		public class Param
		{
			// Token: 0x0601A891 RID: 108689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A891")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04021C5E RID: 138334
			[Token(Token = "0x4021C5E")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}
	}
}
