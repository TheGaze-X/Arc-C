using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B6 RID: 13238
	[Token(Token = "0x20033B6")]
	public abstract class UIBattleSandboxStateNode : UIStateNode
	{
		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0601520E RID: 86542 RVA: 0x0008A7C8 File Offset: 0x000889C8
		[Token(Token = "0x17003226")]
		public bool useBlur
		{
			[Token(Token = "0x601520E")]
			[Address(RVA = "0xD950F0", Offset = "0xD93CF0", VA = "0x180D950F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601520F RID: 86543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601520F")]
		[Address(RVA = "0xD95030", Offset = "0xD93C30", VA = "0x180D95030", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015210 RID: 86544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015210")]
		[Address(RVA = "0xD95090", Offset = "0xD93C90", VA = "0x180D95090")]
		protected UIBattleSandboxStateNode()
		{
		}

		// Token: 0x040192EF RID: 103151
		[Token(Token = "0x40192EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _parent;

		// Token: 0x040192F0 RID: 103152
		[Token(Token = "0x40192F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useBlur;

		// Token: 0x040192F1 RID: 103153
		[Token(Token = "0x40192F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useBlur;

		// Token: 0x040192F2 RID: 103154
		[Token(Token = "0x40192F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040192F3 RID: 103155
		[Token(Token = "0x40192F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
