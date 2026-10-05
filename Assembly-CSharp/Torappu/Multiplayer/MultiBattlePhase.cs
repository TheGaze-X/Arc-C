using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.Connections;
using XLua;

namespace Torappu.Multiplayer
{
	// Token: 0x0200152D RID: 5421
	[Token(Token = "0x200152D")]
	public abstract class MultiBattlePhase : IHotfixable
	{
		// Token: 0x06007C7A RID: 31866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7A")]
		[Address(RVA = "0x2843050", Offset = "0x2841C50", VA = "0x182843050", Slot = "4")]
		public virtual void FixedUpdate()
		{
		}

		// Token: 0x06007C7B RID: 31867
		[Token(Token = "0x6007C7B")]
		public abstract void Enter();

		// Token: 0x06007C7C RID: 31868
		[Token(Token = "0x6007C7C")]
		public abstract void Leave();

		// Token: 0x06007C7D RID: 31869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7D")]
		[Address(RVA = "0x28430B0", Offset = "0x2841CB0", VA = "0x1828430B0", Slot = "7")]
		public virtual void OnGUI()
		{
		}

		// Token: 0x06007C7E RID: 31870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7E")]
		[Address(RVA = "0x2843110", Offset = "0x2841D10", VA = "0x182843110", Slot = "8")]
		public virtual void OnNetStateChanged(ConnectionState state)
		{
		}

		// Token: 0x06007C7F RID: 31871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C7F")]
		[Address(RVA = "0x2843170", Offset = "0x2841D70", VA = "0x182843170")]
		protected MultiBattlePhase()
		{
		}

		// Token: 0x04007C69 RID: 31849
		[Token(Token = "0x4007C69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x04007C6A RID: 31850
		[Token(Token = "0x4007C6A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGUI;

		// Token: 0x04007C6B RID: 31851
		[Token(Token = "0x4007C6B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnNetStateChanged;

		// Token: 0x04007C6C RID: 31852
		[Token(Token = "0x4007C6C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
