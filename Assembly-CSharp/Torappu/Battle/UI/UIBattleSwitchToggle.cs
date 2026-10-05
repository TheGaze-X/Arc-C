using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003373 RID: 13171
	[Token(Token = "0x2003373")]
	[RequireComponent(typeof(Toggle))]
	public class UIBattleSwitchToggle : UISwitchToggle, IHotfixable
	{
		// Token: 0x170031EE RID: 12782
		// (get) Token: 0x06015033 RID: 86067 RVA: 0x0008A138 File Offset: 0x00088338
		// (set) Token: 0x06015034 RID: 86068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031EE")]
		public override bool isOn
		{
			[Token(Token = "0x6015033")]
			[Address(RVA = "0xD6E530", Offset = "0xD6D130", VA = "0x180D6E530", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6015034")]
			[Address(RVA = "0xD6E5A0", Offset = "0xD6D1A0", VA = "0x180D6E5A0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x06015035 RID: 86069 RVA: 0x0008A150 File Offset: 0x00088350
		[Token(Token = "0x170031EF")]
		public override bool interactable
		{
			[Token(Token = "0x6015035")]
			[Address(RVA = "0xD6E480", Offset = "0xD6D080", VA = "0x180D6E480", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06015036 RID: 86070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015036")]
		[Address(RVA = "0xD6E2A0", Offset = "0xD6CEA0", VA = "0x180D6E2A0", Slot = "7")]
		public override void SetInteractable(bool val, bool force = false)
		{
		}

		// Token: 0x06015037 RID: 86071 RVA: 0x0008A168 File Offset: 0x00088368
		[Token(Token = "0x6015037")]
		[Address(RVA = "0xD6E390", Offset = "0xD6CF90", VA = "0x180D6E390")]
		private bool _IsFunctionDisabled()
		{
			return default(bool);
		}

		// Token: 0x06015038 RID: 86072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015038")]
		[Address(RVA = "0xD6E420", Offset = "0xD6D020", VA = "0x180D6E420")]
		public UIBattleSwitchToggle()
		{
		}

		// Token: 0x06015039 RID: 86073 RVA: 0x0008A180 File Offset: 0x00088380
		[Token(Token = "0x6015039")]
		[Address(RVA = "0xD6E370", Offset = "0xD6CF70", VA = "0x180D6E370")]
		private bool <>xLuaBaseProxy_get_isOn()
		{
			return default(bool);
		}

		// Token: 0x0601503A RID: 86074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601503A")]
		[Address(RVA = "0xD6E380", Offset = "0xD6CF80", VA = "0x180D6E380")]
		private void <>xLuaBaseProxy_set_isOn(bool P0)
		{
		}

		// Token: 0x0601503B RID: 86075 RVA: 0x0008A198 File Offset: 0x00088398
		[Token(Token = "0x601503B")]
		[Address(RVA = "0xD6E360", Offset = "0xD6CF60", VA = "0x180D6E360")]
		private bool <>xLuaBaseProxy_get_interactable()
		{
			return default(bool);
		}

		// Token: 0x0601503C RID: 86076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601503C")]
		[Address(RVA = "0xD6E350", Offset = "0xD6CF50", VA = "0x180D6E350")]
		private void <>xLuaBaseProxy_SetInteractable(bool P0, bool P1)
		{
		}

		// Token: 0x0401900B RID: 102411
		[Token(Token = "0x401900B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isOn;

		// Token: 0x0401900C RID: 102412
		[Token(Token = "0x401900C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isOn;

		// Token: 0x0401900D RID: 102413
		[Token(Token = "0x401900D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_interactable;

		// Token: 0x0401900E RID: 102414
		[Token(Token = "0x401900E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetInteractable;

		// Token: 0x0401900F RID: 102415
		[Token(Token = "0x401900F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsFunctionDisabled;

		// Token: 0x04019010 RID: 102416
		[Token(Token = "0x4019010")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
