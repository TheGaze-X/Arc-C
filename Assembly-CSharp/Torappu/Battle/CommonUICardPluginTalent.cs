using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024AC RID: 9388
	[Token(Token = "0x20024AC")]
	public class CommonUICardPluginTalent : UIPluginTalent
	{
		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x0600F15E RID: 61790 RVA: 0x00058F20 File Offset: 0x00057120
		[Token(Token = "0x17001F61")]
		public override UIPluginTalent.PluginType type
		{
			[Token(Token = "0x600F15E")]
			[Address(RVA = "0x687CF0", Offset = "0x6868F0", VA = "0x180687CF0", Slot = "33")]
			get
			{
				return UIPluginTalent.PluginType.UNIT_HUD;
			}
		}

		// Token: 0x0600F15F RID: 61791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F15F")]
		[Address(RVA = "0x687AF0", Offset = "0x6866F0", VA = "0x180687AF0", Slot = "34")]
		protected override UIPluginTalent.UnitTalentUIPlugin LoadPlugin(string pluginName)
		{
			return null;
		}

		// Token: 0x0600F160 RID: 61792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F160")]
		[Address(RVA = "0x687950", Offset = "0x686550", VA = "0x180687950", Slot = "29")]
		protected override void DoAttach()
		{
		}

		// Token: 0x0600F161 RID: 61793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F161")]
		[Address(RVA = "0x687A00", Offset = "0x686600", VA = "0x180687A00", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x0600F162 RID: 61794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F162")]
		[Address(RVA = "0x687A80", Offset = "0x686680", VA = "0x180687A80", Slot = "36")]
		protected override void FinishPlugin()
		{
		}

		// Token: 0x0600F163 RID: 61795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F163")]
		[Address(RVA = "0x687C50", Offset = "0x686850", VA = "0x180687C50")]
		public CommonUICardPluginTalent()
		{
		}

		// Token: 0x0600F164 RID: 61796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F164")]
		[Address(RVA = "0x681E90", Offset = "0x680A90", VA = "0x180681E90")]
		private void <>xLuaBaseProxy_DoAttach()
		{
		}

		// Token: 0x0600F165 RID: 61797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F165")]
		[Address(RVA = "0x681EA0", Offset = "0x680AA0", VA = "0x180681EA0")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0600F166 RID: 61798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F166")]
		[Address(RVA = "0x687C40", Offset = "0x686840", VA = "0x180687C40")]
		private void <>xLuaBaseProxy_FinishPlugin()
		{
		}

		// Token: 0x04010B18 RID: 68376
		[Token(Token = "0x4010B18")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _isAlwaysAttachedPlugin;

		// Token: 0x04010B19 RID: 68377
		[Token(Token = "0x4010B19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x04010B1A RID: 68378
		[Token(Token = "0x4010B1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadPlugin;

		// Token: 0x04010B1B RID: 68379
		[Token(Token = "0x4010B1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04010B1C RID: 68380
		[Token(Token = "0x4010B1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04010B1D RID: 68381
		[Token(Token = "0x4010B1D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FinishPlugin;

		// Token: 0x04010B1E RID: 68382
		[Token(Token = "0x4010B1E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
