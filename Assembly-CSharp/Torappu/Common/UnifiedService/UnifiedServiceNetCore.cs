using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Common.UnifiedService
{
	// Token: 0x020016DD RID: 5853
	[Token(Token = "0x20016DD")]
	public abstract class UnifiedServiceNetCore : IHotfixable
	{
		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x0600943C RID: 37948 RVA: 0x00039D38 File Offset: 0x00037F38
		// (set) Token: 0x0600943D RID: 37949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000FDF")]
		public UnifiedServiceNetState netState
		{
			[Token(Token = "0x600943C")]
			[Address(RVA = "0x2B416E0", Offset = "0x2B402E0", VA = "0x182B416E0")]
			[CompilerGenerated]
			get
			{
				return UnifiedServiceNetState.NONE;
			}
			[Token(Token = "0x600943D")]
			[Address(RVA = "0x2B41840", Offset = "0x2B40440", VA = "0x182B41840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x0600943E RID: 37950 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600943F RID: 37951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000036")]
		public event Action<UnifiedServiceNetState> onStateChanged
		{
			[Token(Token = "0x600943E")]
			[Address(RVA = "0x2B415E0", Offset = "0x2B401E0", VA = "0x182B415E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600943F")]
			[Address(RVA = "0x2B41740", Offset = "0x2B40340", VA = "0x182B41740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06009440 RID: 37952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009440")]
		[Address(RVA = "0x2B41270", Offset = "0x2B3FE70", VA = "0x182B41270")]
		public void ConnectTo(string host, int port)
		{
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009441")]
		[Address(RVA = "0x2B41320", Offset = "0x2B3FF20", VA = "0x182B41320")]
		public void DisConnect()
		{
		}

		// Token: 0x06009442 RID: 37954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009442")]
		[Address(RVA = "0x2B413A0", Offset = "0x2B3FFA0", VA = "0x182B413A0")]
		public void Update()
		{
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009443")]
		[Address(RVA = "0x2B41420", Offset = "0x2B40020", VA = "0x182B41420")]
		protected void _ChangeState(UnifiedServiceNetState state)
		{
		}

		// Token: 0x06009444 RID: 37956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009444")]
		[Address(RVA = "0x2B40E20", Offset = "0x2B3FA20", VA = "0x182B40E20", Slot = "4")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06009445 RID: 37957
		[Token(Token = "0x6009445")]
		protected abstract void OnConnectTo(string host, int port);

		// Token: 0x06009446 RID: 37958
		[Token(Token = "0x6009446")]
		protected abstract void OnDisConnect();

		// Token: 0x06009447 RID: 37959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009447")]
		[Address(RVA = "0x2B41580", Offset = "0x2B40180", VA = "0x182B41580")]
		protected UnifiedServiceNetCore()
		{
		}

		// Token: 0x04008A42 RID: 35394
		[Token(Token = "0x4008A42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_netState;

		// Token: 0x04008A43 RID: 35395
		[Token(Token = "0x4008A43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_netState;

		// Token: 0x04008A44 RID: 35396
		[Token(Token = "0x4008A44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_add_onStateChanged;

		// Token: 0x04008A45 RID: 35397
		[Token(Token = "0x4008A45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_remove_onStateChanged;

		// Token: 0x04008A46 RID: 35398
		[Token(Token = "0x4008A46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ConnectTo;

		// Token: 0x04008A47 RID: 35399
		[Token(Token = "0x4008A47")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DisConnect;

		// Token: 0x04008A48 RID: 35400
		[Token(Token = "0x4008A48")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04008A49 RID: 35401
		[Token(Token = "0x4008A49")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ChangeState;

		// Token: 0x04008A4A RID: 35402
		[Token(Token = "0x4008A4A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04008A4B RID: 35403
		[Token(Token = "0x4008A4B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
