using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059A2 RID: 22946
	[Token(Token = "0x20059A2")]
	public class CrisisV2EntryAVGAdapter : ExecutorComponent, IHotfixable
	{
		// Token: 0x17004EA7 RID: 20135
		// (get) Token: 0x06021728 RID: 137000 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021729 RID: 137001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EA7")]
		public UIPage page
		{
			[Token(Token = "0x6021728")]
			[Address(RVA = "0x1BBFBA0", Offset = "0x1BBE7A0", VA = "0x181BBFBA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6021729")]
			[Address(RVA = "0x1BBFC60", Offset = "0x1BBE860", VA = "0x181BBFC60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004EA8 RID: 20136
		// (get) Token: 0x0602172A RID: 137002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602172B RID: 137003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004EA8")]
		public IStateEngine se
		{
			[Token(Token = "0x602172A")]
			[Address(RVA = "0x1BBFC00", Offset = "0x1BBE800", VA = "0x181BBFC00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602172B")]
			[Address(RVA = "0x1BBFCE0", Offset = "0x1BBE8E0", VA = "0x181BBFCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602172C RID: 137004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602172C")]
		[Address(RVA = "0x1BBF500", Offset = "0x1BBE100", VA = "0x181BBF500", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0602172D RID: 137005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602172D")]
		[Address(RVA = "0x1BBF4A0", Offset = "0x1BBE0A0", VA = "0x181BBF4A0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0602172E RID: 137006 RVA: 0x000BA4E0 File Offset: 0x000B86E0
		[Token(Token = "0x602172E")]
		[Address(RVA = "0x1BBF7F0", Offset = "0x1BBE3F0", VA = "0x181BBF7F0")]
		private bool _OnResetToEntry(Command command)
		{
			return default(bool);
		}

		// Token: 0x0602172F RID: 137007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602172F")]
		[Address(RVA = "0x1BBFA90", Offset = "0x1BBE690", VA = "0x181BBFA90")]
		private IEnumerator _TryRouteToEntryState()
		{
			return null;
		}

		// Token: 0x06021730 RID: 137008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021730")]
		[Address(RVA = "0x1BBF740", Offset = "0x1BBE340", VA = "0x181BBF740")]
		private void OnEnable()
		{
		}

		// Token: 0x06021731 RID: 137009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021731")]
		[Address(RVA = "0x1BBF690", Offset = "0x1BBE290", VA = "0x181BBF690")]
		private void OnDestroy()
		{
		}

		// Token: 0x06021732 RID: 137010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021732")]
		[Address(RVA = "0x1BBFB40", Offset = "0x1BBE740", VA = "0x181BBFB40")]
		public CrisisV2EntryAVGAdapter()
		{
		}

		// Token: 0x0402DA5A RID: 186970
		[Token(Token = "0x402DA5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402DA5B RID: 186971
		[Token(Token = "0x402DA5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402DA5C RID: 186972
		[Token(Token = "0x402DA5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_se;

		// Token: 0x0402DA5D RID: 186973
		[Token(Token = "0x402DA5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_se;

		// Token: 0x0402DA5E RID: 186974
		[Token(Token = "0x402DA5E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0402DA5F RID: 186975
		[Token(Token = "0x402DA5F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0402DA60 RID: 186976
		[Token(Token = "0x402DA60")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnResetToEntry;

		// Token: 0x0402DA61 RID: 186977
		[Token(Token = "0x402DA61")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryRouteToEntryState;

		// Token: 0x0402DA62 RID: 186978
		[Token(Token = "0x402DA62")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402DA63 RID: 186979
		[Token(Token = "0x402DA63")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402DA64 RID: 186980
		[Token(Token = "0x402DA64")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
