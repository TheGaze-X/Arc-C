using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002451 RID: 9297
	[Token(Token = "0x2002451")]
	public class CastSkillWithCost : CastSkill, IHudPluginSource
	{
		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x0600EEC0 RID: 61120 RVA: 0x00057B40 File Offset: 0x00055D40
		// (set) Token: 0x0600EEC1 RID: 61121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001EF7")]
		public int requiredCost
		{
			[Token(Token = "0x600EEC0")]
			[Address(RVA = "0x642290", Offset = "0x640E90", VA = "0x180642290")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600EEC1")]
			[Address(RVA = "0x6422F0", Offset = "0x640EF0", VA = "0x1806422F0")]
			set
			{
			}
		}

		// Token: 0x0600EEC2 RID: 61122 RVA: 0x00057B58 File Offset: 0x00055D58
		[Token(Token = "0x600EEC2")]
		[Address(RVA = "0x641ED0", Offset = "0x640AD0", VA = "0x180641ED0", Slot = "19")]
		public override bool IsAvailable(PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEC3 RID: 61123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEC3")]
		[Address(RVA = "0x641F90", Offset = "0x640B90", VA = "0x180641F90", Slot = "57")]
		public override void OnInit()
		{
		}

		// Token: 0x0600EEC4 RID: 61124 RVA: 0x00057B70 File Offset: 0x00055D70
		[Token(Token = "0x600EEC4")]
		[Address(RVA = "0x641A60", Offset = "0x640660", VA = "0x180641A60", Slot = "49")]
		protected override bool DoCast([Optional] Ability.FinishCallbackDelegate finishCb, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEC5 RID: 61125 RVA: 0x00057B88 File Offset: 0x00055D88
		[Token(Token = "0x600EEC5")]
		[Address(RVA = "0x6420E0", Offset = "0x640CE0", VA = "0x1806420E0", Slot = "80")]
		protected virtual bool ReduceCost(int cost, PlayerSide operationSide = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600EEC6 RID: 61126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEC6")]
		[Address(RVA = "0x641D80", Offset = "0x640980", VA = "0x180641D80", Slot = "79")]
		public void GatherHudPluginTypes(List<string> pluginNames)
		{
		}

		// Token: 0x0600EEC7 RID: 61127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEC7")]
		[Address(RVA = "0x642210", Offset = "0x640E10", VA = "0x180642210")]
		public CastSkillWithCost()
		{
		}

		// Token: 0x0600EEC8 RID: 61128 RVA: 0x00057BA0 File Offset: 0x00055DA0
		[Token(Token = "0x600EEC8")]
		[Address(RVA = "0x636840", Offset = "0x635440", VA = "0x180636840")]
		private bool <>xLuaBaseProxy_IsAvailable(PlayerSide P0)
		{
			return default(bool);
		}

		// Token: 0x0600EEC9 RID: 61129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EEC9")]
		[Address(RVA = "0x641620", Offset = "0x640220", VA = "0x180641620")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600EECA RID: 61130 RVA: 0x00057BB8 File Offset: 0x00055DB8
		[Token(Token = "0x600EECA")]
		[Address(RVA = "0x641610", Offset = "0x640210", VA = "0x180641610")]
		private bool <>xLuaBaseProxy_DoCast(Ability.FinishCallbackDelegate P0, PlayerSide P1)
		{
			return default(bool);
		}

		// Token: 0x0401080A RID: 67594
		[Token(Token = "0x401080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private int m_requiredCost;

		// Token: 0x0401080B RID: 67595
		[Token(Token = "0x401080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requiredCost;

		// Token: 0x0401080C RID: 67596
		[Token(Token = "0x401080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_requiredCost;

		// Token: 0x0401080D RID: 67597
		[Token(Token = "0x401080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsAvailable;

		// Token: 0x0401080E RID: 67598
		[Token(Token = "0x401080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401080F RID: 67599
		[Token(Token = "0x401080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoCast;

		// Token: 0x04010810 RID: 67600
		[Token(Token = "0x4010810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReduceCost;

		// Token: 0x04010811 RID: 67601
		[Token(Token = "0x4010811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherHudPluginTypes;

		// Token: 0x04010812 RID: 67602
		[Token(Token = "0x4010812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
