using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E32 RID: 15922
	[Token(Token = "0x2003E32")]
	public class SquadHomePluginLoader : PageSingleComponent
	{
		// Token: 0x06018BE4 RID: 101348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BE4")]
		[Address(RVA = "0x1141030", Offset = "0x113FC30", VA = "0x181141030")]
		public SquadHomePluginView Init(SquadHomePlugin.PluginInputParams param)
		{
			return null;
		}

		// Token: 0x06018BE5 RID: 101349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BE5")]
		[Address(RVA = "0x1141590", Offset = "0x1140190", VA = "0x181141590")]
		private void _Release()
		{
		}

		// Token: 0x06018BE6 RID: 101350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BE6")]
		[Address(RVA = "0x1141390", Offset = "0x113FF90", VA = "0x181141390")]
		public void Release()
		{
		}

		// Token: 0x06018BE7 RID: 101351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BE7")]
		[Address(RVA = "0x11413F0", Offset = "0x113FFF0", VA = "0x1811413F0")]
		private void _CreatePlugin(SquadHomePlugin.PluginInputParams param, SquadHomePluginView view)
		{
		}

		// Token: 0x06018BE8 RID: 101352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018BE8")]
		[Address(RVA = "0x1140FD0", Offset = "0x113FBD0", VA = "0x181140FD0")]
		public SquadHomePlugin GetActivePlugin()
		{
			return null;
		}

		// Token: 0x06018BE9 RID: 101353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BE9")]
		[Address(RVA = "0x1141760", Offset = "0x1140360", VA = "0x181141760")]
		public SquadHomePluginLoader()
		{
		}

		// Token: 0x0401E65C RID: 124508
		[Token(Token = "0x401E65C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _pluginContainer;

		// Token: 0x0401E65D RID: 124509
		[Token(Token = "0x401E65D")]
		[FieldOffset(Offset = "0x28")]
		private SquadHomePlugin m_plugin;

		// Token: 0x0401E65E RID: 124510
		[Token(Token = "0x401E65E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E65F RID: 124511
		[Token(Token = "0x401E65F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Release;

		// Token: 0x0401E660 RID: 124512
		[Token(Token = "0x401E660")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Release;

		// Token: 0x0401E661 RID: 124513
		[Token(Token = "0x401E661")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreatePlugin;

		// Token: 0x0401E662 RID: 124514
		[Token(Token = "0x401E662")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetActivePlugin;

		// Token: 0x0401E663 RID: 124515
		[Token(Token = "0x401E663")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
